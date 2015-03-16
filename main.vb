Imports System.IO
Imports RFCOMAPILib

Public Class frmMain

    Private bHasAttachments As Boolean
    Private attachments As List(Of String)
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Not bHasAttachments) Then
            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ProgressBar.Maximum = dlgOpen.FileNames.Length
                Dim i As Integer = 0
                'Create and send each fax
                For Each sFile In dlgOpen.FileNames
                    'Add attachment to listview
                    Dim lvItem As New ListViewItem
                    lvItem.Text = Path.GetFileName(sFile)
                    lvItem.Tag = sFile
                    lvAttachments.Items.Add(lvItem)

                    'Add attachment to attachments array
                    attachments.Add(sFile)
                    i += 1
                    If (ProgressBar.Maximum <= i) Then
                        ProgressBar.Value = i
                    End If

                    'lblStatus.Text = String.Format("Faxing {0} of {1}.", i, faxesCount)
                    Me.Refresh()
                Next
            End If

            'Check if there are attachments
            If lvAttachments.Items.Count > 0 Then
                lblAttachments.Visible = True
                lvAttachments.Visible = True

                lblStatus.Text = "Ready to Fax!"
                bHasAttachments = True
                btnSubmit.Text = "Fax"
            Else
                Reset_UI()
            End If
            Exit Sub
        Else
            'Get the variables
            Dim strServerName As String = txtRFsvr.Text
            Dim strUserName As String = txtRFuser.Text
            Dim strRecName As String = txtRFRecName.Text
            Dim strRecFax As String = txtRFRecFax.Text

            'Save Settings if Option Checked
            If (chkSaveRecieptInfo.Checked) Then
                My.Settings.Server = strServerName
                My.Settings.User = strUserName
                My.Settings.RecipientName = strRecName
                My.Settings.RecipientFax = strRecFax
                My.Settings.Save()
            End If

            'Connect to RightFax Server
            Dim objRightFax As New FaxServer
            Try
                objRightFax = ConnectToServer(strServerName, strUserName, False)
                objRightFax.OpenServer()
            Catch ex As Exception
                MsgBox("Rightfax server error. Please check your connection and settings and try again. " + ex.Message)
                Reset_UI()
                Exit Sub
            End Try

            If rbOneFax.Checked And Not rbOneFaxPerAttachment.Checked Then
                Try

                    'Fax out ONE Fax with many attachments
                    'Create Fax Object
                    Dim objFax As Fax = CreateFax(objRightFax, strRecName, strRecFax)

                    'Add each attachment to the fax object
                    Dim strAttachment As String
                    For Each strAttachment In attachments
                        objFax.Attachments.Add(strAttachment, False) ' false = don't delete file after faxing
                    Next

                    'Send the fax
                    SendFax(objFax)
                Catch ex As Exception
                    MsgBox("Error creating or sending fax. " + ex.Message)
                    Reset_UI()
                    Exit Sub
                End Try

            ElseIf rbOneFaxPerAttachment.Checked And Not rbOneFax.Checked Then
                'Send a fax for each attachment
                Dim strAttachment As String
                Try
                    For Each strAttachment In attachments
                        Dim objFax As Fax = CreateFax(objRightFax, strRecName, strRecFax)
                        objFax.Attachments.Add(strAttachment, False) ' false = don't delete file after faxing
                        SendFax(objFax)
                    Next

                Catch ex As Exception
                    MsgBox("Error creating or sending fax. " + ex.Message)
                    Reset_UI()
                    Exit Sub
                End Try
            Else
                MsgBox("An error occured: Unknown fax mode chosen. Please try again.", vbOKOnly, "An Error Has Occurred")
                Reset_UI()
                Exit Sub
            End If


            'Close Server
            objRightFax.CloseServer()
            objRightFax = Nothing

            'Reset UI and show done.
            Reset_UI()
            lblStatus.Text = "DONE!"
        End If
    End Sub


    Private Sub Reset_UI()
        bHasAttachments = False
        btnSubmit.Text = "Select Files"
        lblStatus.Text = String.Empty

        chkSaveRecieptInfo.Checked = False

        'Clear attachments array
        attachments.Clear()
        'Clear attachments listview
        lvAttachments.Items.Clear()
        ProgressBar.Value = 0
        ProgressBar.Maximum = 1

        lblAttachments.Visible = False
        lvAttachments.Visible = False

    End Sub

    Private Sub lvAttachments_ItemActivate(sender As Object, e As EventArgs) Handles lvAttachments.ItemActivate
        Dim selectedItem As String = sender.SelectedItems(0).Tag
        Process.Start(selectedItem)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Settings
        txtRFsvr.Text = My.Settings.Server
        txtRFuser.Text = My.Settings.User
        txtRFRecName.Text = My.Settings.RecipientName
        txtRFRecFax.Text = My.Settings.RecipientFax

        attachments = New List(Of String)
        Reset_UI()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
