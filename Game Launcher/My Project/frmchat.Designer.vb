<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchat
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchat))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bwchat = New System.ComponentModel.BackgroundWorker()
        Me.tmchat = New System.Windows.Forms.Timer(Me.components)
        Me.mycolor = New System.Windows.Forms.ColorDialog()
        Me.myfont = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAlleChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPrivateMessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChattingBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.UserEmail = New System.Windows.Forms.Label()
        Me.UserTel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(935, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bwchat
        '
        Me.bwchat.WorkerReportsProgress = True
        Me.bwchat.WorkerSupportsCancellation = True
        '
        'tmchat
        '
        Me.tmchat.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FileToolStripMenuItem, Me.FontsToolStripMenuItem, Me.ClearAlleChatToolStripMenuItem, Me.ViewPrivateMessagesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 27)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Settings_19
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Settings_19
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Microsoft_Access_19
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Shutdown_19
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FontsToolStripMenuItem
        '
        Me.FontsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontToolStripMenuItem, Me.ChangeColorToolStripMenuItem})
        Me.FontsToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Fonticons_23
        Me.FontsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontsToolStripMenuItem.Name = "FontsToolStripMenuItem"
        Me.FontsToolStripMenuItem.Size = New System.Drawing.Size(71, 27)
        Me.FontsToolStripMenuItem.Text = "Fonts"
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Generic_Text_19
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change Font"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Fill_Color_19
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'ClearAlleChatToolStripMenuItem
        '
        Me.ClearAlleChatToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Erase_23
        Me.ClearAlleChatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearAlleChatToolStripMenuItem.Name = "ClearAlleChatToolStripMenuItem"
        Me.ClearAlleChatToolStripMenuItem.Size = New System.Drawing.Size(116, 27)
        Me.ClearAlleChatToolStripMenuItem.Text = "Clear alle chat"
        '
        'ViewPrivateMessagesToolStripMenuItem
        '
        Me.ViewPrivateMessagesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ViewPrivateMessagesToolStripMenuItem.Image = Global.Game_Launcher.My.Resources.Resources.icons8_New_Message_15
        Me.ViewPrivateMessagesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewPrivateMessagesToolStripMenuItem.Name = "ViewPrivateMessagesToolStripMenuItem"
        Me.ViewPrivateMessagesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ViewPrivateMessagesToolStripMenuItem.Size = New System.Drawing.Size(152, 27)
        Me.ViewPrivateMessagesToolStripMenuItem.Text = "View Private Messages"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChattingBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 364)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'ChattingBox
        '
        Me.ChattingBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChattingBox.Location = New System.Drawing.Point(3, 16)
        Me.ChattingBox.Name = "ChattingBox"
        Me.ChattingBox.Size = New System.Drawing.Size(567, 345)
        Me.ChattingBox.TabIndex = 0
        Me.ChattingBox.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstFriends)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.PicBox)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 364)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UserTel)
        Me.GroupBox4.Controls.Add(Me.UserEmail)
        Me.GroupBox4.Controls.Add(Me.Username)
        Me.GroupBox4.Location = New System.Drawing.Point(165, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 105)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'PicBox
        '
        Me.PicBox.Location = New System.Drawing.Point(6, 19)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(153, 105)
        Me.PicBox.TabIndex = 0
        Me.PicBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMessage)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 413)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 81)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(7, 10)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(560, 65)
        Me.txtMessage.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game_Launcher.My.Resources.Resources.Chat_Logo
        Me.PictureBox2.Location = New System.Drawing.Point(672, 423)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnSend
        '
        Me.btnSend.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Send_Message_40
        Me.btnSend.Location = New System.Drawing.Point(591, 439)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 49)
        Me.btnSend.TabIndex = 6
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(7, 131)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(319, 225)
        Me.lstFriends.TabIndex = 5
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(7, 20)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 0
        Me.Username.Text = "Username"
        '
        'UserEmail
        '
        Me.UserEmail.AutoSize = True
        Me.UserEmail.Location = New System.Drawing.Point(7, 46)
        Me.UserEmail.Name = "UserEmail"
        Me.UserEmail.Size = New System.Drawing.Size(32, 13)
        Me.UserEmail.TabIndex = 1
        Me.UserEmail.Text = "Email"
        '
        'UserTel
        '
        Me.UserTel.AutoSize = True
        Me.UserTel.Location = New System.Drawing.Point(6, 73)
        Me.UserTel.Name = "UserTel"
        Me.UserTel.Size = New System.Drawing.Size(58, 13)
        Me.UserTel.TabIndex = 2
        Me.UserTel.Text = "Telephone"
        '
        'frmchat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 542)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmchat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Launcher Chat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bwchat As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmchat As Timer
    Friend WithEvents mycolor As ColorDialog
    Friend WithEvents myfont As FontDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAlleChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPrivateMessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChattingBox As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSend As Button
    Friend WithEvents lstFriends As ListBox
    Friend WithEvents UserTel As Label
    Friend WithEvents UserEmail As Label
    Friend WithEvents Username As Label
End Class
