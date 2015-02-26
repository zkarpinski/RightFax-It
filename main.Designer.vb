<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.chkSaveRecieptInfo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkRFCoverSheet = New System.Windows.Forms.CheckBox()
        Me.txtRFRecFax = New System.Windows.Forms.TextBox()
        Me.lblRFRecFax = New System.Windows.Forms.Label()
        Me.txtRFRecName = New System.Windows.Forms.TextBox()
        Me.lblRFRecName = New System.Windows.Forms.Label()
        Me.grpRFServer = New System.Windows.Forms.GroupBox()
        Me.txtRFsvr = New System.Windows.Forms.TextBox()
        Me.lblRFserver = New System.Windows.Forms.Label()
        Me.txtRFuser = New System.Windows.Forms.TextBox()
        Me.lblRFuser = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblBranding = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblAttachments = New System.Windows.Forms.Label()
        Me.lvAttachments = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOneFaxPerAttachment = New System.Windows.Forms.RadioButton()
        Me.rbOneFax = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout
        Me.grpRFServer.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.SuspendLayout
        '
        'chkSaveRecieptInfo
        '
        Me.chkSaveRecieptInfo.AutoSize = true
        Me.chkSaveRecieptInfo.BackColor = System.Drawing.SystemColors.Control
        Me.chkSaveRecieptInfo.Location = New System.Drawing.Point(10, 17)
        Me.chkSaveRecieptInfo.Name = "chkSaveRecieptInfo"
        Me.chkSaveRecieptInfo.Size = New System.Drawing.Size(151, 17)
        Me.chkSaveRecieptInfo.TabIndex = 4
        Me.chkSaveRecieptInfo.Text = "Save recipient info for later"
        Me.chkSaveRecieptInfo.UseVisualStyleBackColor = false
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.chkRFCoverSheet)
        Me.GroupBox2.Controls.Add(Me.txtRFRecFax)
        Me.GroupBox2.Controls.Add(Me.lblRFRecFax)
        Me.GroupBox2.Controls.Add(Me.txtRFRecName)
        Me.GroupBox2.Controls.Add(Me.lblRFRecName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 53)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Fax Info"
        '
        'chkRFCoverSheet
        '
        Me.chkRFCoverSheet.AutoSize = true
        Me.chkRFCoverSheet.Checked = true
        Me.chkRFCoverSheet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRFCoverSheet.Location = New System.Drawing.Point(17, 78)
        Me.chkRFCoverSheet.Name = "chkRFCoverSheet"
        Me.chkRFCoverSheet.Size = New System.Drawing.Size(122, 17)
        Me.chkRFCoverSheet.TabIndex = 11
        Me.chkRFCoverSheet.Text = "Include Cover Sheet"
        Me.chkRFCoverSheet.UseVisualStyleBackColor = true
        Me.chkRFCoverSheet.Visible = false
        '
        'txtRFRecFax
        '
        Me.txtRFRecFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRFRecFax.Location = New System.Drawing.Point(98, 28)
        Me.txtRFRecFax.Name = "txtRFRecFax"
        Me.txtRFRecFax.Size = New System.Drawing.Size(100, 20)
        Me.txtRFRecFax.TabIndex = 3
        '
        'lblRFRecFax
        '
        Me.lblRFRecFax.AutoSize = true
        Me.lblRFRecFax.BackColor = System.Drawing.SystemColors.Control
        Me.lblRFRecFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRFRecFax.Location = New System.Drawing.Point(15, 29)
        Me.lblRFRecFax.Name = "lblRFRecFax"
        Me.lblRFRecFax.Size = New System.Drawing.Size(75, 13)
        Me.lblRFRecFax.TabIndex = 7
        Me.lblRFRecFax.Text = "Recipient Fax:"
        '
        'txtRFRecName
        '
        Me.txtRFRecName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRFRecName.Location = New System.Drawing.Point(98, 8)
        Me.txtRFRecName.Name = "txtRFRecName"
        Me.txtRFRecName.Size = New System.Drawing.Size(100, 20)
        Me.txtRFRecName.TabIndex = 2
        '
        'lblRFRecName
        '
        Me.lblRFRecName.AutoSize = true
        Me.lblRFRecName.BackColor = System.Drawing.SystemColors.Control
        Me.lblRFRecName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRFRecName.Location = New System.Drawing.Point(8, 13)
        Me.lblRFRecName.Name = "lblRFRecName"
        Me.lblRFRecName.Size = New System.Drawing.Size(86, 13)
        Me.lblRFRecName.TabIndex = 5
        Me.lblRFRecName.Text = "Recipient Name:"
        '
        'grpRFServer
        '
        Me.grpRFServer.BackColor = System.Drawing.SystemColors.Control
        Me.grpRFServer.Controls.Add(Me.txtRFsvr)
        Me.grpRFServer.Controls.Add(Me.lblRFserver)
        Me.grpRFServer.Controls.Add(Me.txtRFuser)
        Me.grpRFServer.Controls.Add(Me.lblRFuser)
        Me.grpRFServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpRFServer.Location = New System.Drawing.Point(1, 25)
        Me.grpRFServer.Name = "grpRFServer"
        Me.grpRFServer.Size = New System.Drawing.Size(212, 53)
        Me.grpRFServer.TabIndex = 15
        Me.grpRFServer.TabStop = false
        Me.grpRFServer.Text = "Server Info"
        '
        'txtRFsvr
        '
        Me.txtRFsvr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRFsvr.Location = New System.Drawing.Point(99, 12)
        Me.txtRFsvr.Name = "txtRFsvr"
        Me.txtRFsvr.Size = New System.Drawing.Size(100, 20)
        Me.txtRFsvr.TabIndex = 0
        '
        'lblRFserver
        '
        Me.lblRFserver.AutoSize = true
        Me.lblRFserver.BackColor = System.Drawing.SystemColors.Control
        Me.lblRFserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRFserver.Location = New System.Drawing.Point(51, 15)
        Me.lblRFserver.Name = "lblRFserver"
        Me.lblRFserver.Size = New System.Drawing.Size(41, 13)
        Me.lblRFserver.TabIndex = 5
        Me.lblRFserver.Text = "Server:"
        '
        'txtRFuser
        '
        Me.txtRFuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRFuser.Location = New System.Drawing.Point(99, 31)
        Me.txtRFuser.Name = "txtRFuser"
        Me.txtRFuser.Size = New System.Drawing.Size(100, 20)
        Me.txtRFuser.TabIndex = 1
        '
        'lblRFuser
        '
        Me.lblRFuser.AutoSize = true
        Me.lblRFuser.BackColor = System.Drawing.SystemColors.Control
        Me.lblRFuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRFuser.Location = New System.Drawing.Point(32, 33)
        Me.lblRFuser.Name = "lblRFuser"
        Me.lblRFuser.Size = New System.Drawing.Size(58, 13)
        Me.lblRFuser.TabIndex = 7
        Me.lblRFuser.Text = "Username:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(221, 284)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(126, 32)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Select Files/Fax"
        Me.btnSubmit.UseVisualStyleBackColor = false
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'dlgOpen
        '
        Me.dlgOpen.Multiselect = true
        '
        'lblBranding
        '
        Me.lblBranding.AutoSize = true
        Me.lblBranding.BackColor = System.Drawing.Color.Transparent
        Me.lblBranding.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBranding.Location = New System.Drawing.Point(422, 336)
        Me.lblBranding.Name = "lblBranding"
        Me.lblBranding.Size = New System.Drawing.Size(108, 9)
        Me.lblBranding.TabIndex = 21
        Me.lblBranding.Text = "Created by: Zachary Karpinski"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(265, 327)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(38, 13)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "DONE"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(1, 322)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(529, 23)
        Me.ProgressBar.TabIndex = 20
        Me.ProgressBar.Value = 88
        '
        'lblAttachments
        '
        Me.lblAttachments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAttachments.Location = New System.Drawing.Point(0, 174)
        Me.lblAttachments.Name = "lblAttachments"
        Me.lblAttachments.Size = New System.Drawing.Size(213, 20)
        Me.lblAttachments.TabIndex = 23
        Me.lblAttachments.Text = "Attachments"
        Me.lblAttachments.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvAttachments
        '
        Me.lvAttachments.Location = New System.Drawing.Point(0, 189)
        Me.lvAttachments.Name = "lvAttachments"
        Me.lvAttachments.Size = New System.Drawing.Size(213, 131)
        Me.lvAttachments.TabIndex = 24
        Me.lvAttachments.UseCompatibleStateImageBehavior = false
        Me.lvAttachments.View = System.Windows.Forms.View.List
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.rbOneFaxPerAttachment)
        Me.GroupBox1.Controls.Add(Me.rbOneFax)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(355, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 63)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Send Mode"
        '
        'rbOneFaxPerAttachment
        '
        Me.rbOneFaxPerAttachment.AutoSize = true
        Me.rbOneFaxPerAttachment.Location = New System.Drawing.Point(7, 36)
        Me.rbOneFaxPerAttachment.Name = "rbOneFaxPerAttachment"
        Me.rbOneFaxPerAttachment.Size = New System.Drawing.Size(140, 17)
        Me.rbOneFaxPerAttachment.TabIndex = 1
        Me.rbOneFaxPerAttachment.Text = "One Fax Per Attachment"
        Me.rbOneFaxPerAttachment.UseVisualStyleBackColor = true
        '
        'rbOneFax
        '
        Me.rbOneFax.AutoSize = true
        Me.rbOneFax.Checked = true
        Me.rbOneFax.Location = New System.Drawing.Point(7, 18)
        Me.rbOneFax.Name = "rbOneFax"
        Me.rbOneFax.Size = New System.Drawing.Size(161, 17)
        Me.rbOneFax.TabIndex = 0
        Me.rbOneFax.TabStop = true
        Me.rbOneFax.Text = "One Fax - Many Attachments"
        Me.rbOneFax.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.chkSaveRecieptInfo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(355, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 36)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Options"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(530, 345)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvAttachments)
        Me.Controls.Add(Me.lblAttachments)
        Me.Controls.Add(Me.lblBranding)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpRFServer)
        Me.Controls.Add(Me.btnSubmit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "RightFax It"
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.grpRFServer.ResumeLayout(false)
        Me.grpRFServer.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents chkSaveRecieptInfo As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkRFCoverSheet As CheckBox
    Friend WithEvents txtRFRecFax As TextBox
    Friend WithEvents lblRFRecFax As Label
    Friend WithEvents txtRFRecName As TextBox
    Friend WithEvents lblRFRecName As Label
    Friend WithEvents grpRFServer As GroupBox
    Friend WithEvents txtRFsvr As TextBox
    Friend WithEvents lblRFserver As Label
    Friend WithEvents txtRFuser As TextBox
    Friend WithEvents lblRFuser As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents lblBranding As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents lblAttachments As Label
    Friend WithEvents lvAttachments As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbOneFax As RadioButton
    Friend WithEvents rbOneFaxPerAttachment As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
End Class
