<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpCreate = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsernameLogin = New System.Windows.Forms.TextBox()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtConfirmCreate = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassCreate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsernameCreate = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCreate.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Game_Launcher.My.Resources.Resources.Chat_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(365, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpCreate
        '
        Me.grpCreate.Controls.Add(Me.PictureBox2)
        Me.grpCreate.Controls.Add(Me.Label3)
        Me.grpCreate.Controls.Add(Me.btnLogin)
        Me.grpCreate.Controls.Add(Me.Label2)
        Me.grpCreate.Controls.Add(Me.txtPassLogin)
        Me.grpCreate.Controls.Add(Me.Label1)
        Me.grpCreate.Controls.Add(Me.txtUsernameLogin)
        Me.grpCreate.Location = New System.Drawing.Point(12, 168)
        Me.grpCreate.Name = "grpCreate"
        Me.grpCreate.Size = New System.Drawing.Size(365, 166)
        Me.grpCreate.TabIndex = 2
        Me.grpCreate.TabStop = False
        Me.grpCreate.Text = "Login"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Plus_15
        Me.PictureBox2.Location = New System.Drawing.Point(9, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Create Account"
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Key_15
        Me.btnLogin.Location = New System.Drawing.Point(247, 122)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(112, 33)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Sign In"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Passsword"
        '
        'txtPassLogin
        '
        Me.txtPassLogin.Location = New System.Drawing.Point(6, 96)
        Me.txtPassLogin.Name = "txtPassLogin"
        Me.txtPassLogin.Size = New System.Drawing.Size(353, 20)
        Me.txtPassLogin.TabIndex = 1
        Me.txtPassLogin.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.Location = New System.Drawing.Point(6, 47)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.Size = New System.Drawing.Size(353, 20)
        Me.txtUsernameLogin.TabIndex = 0
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.Label7)
        Me.grpLogin.Controls.Add(Me.txtEmail)
        Me.grpLogin.Controls.Add(Me.txtConfirmCreate)
        Me.grpLogin.Controls.Add(Me.PictureBox3)
        Me.grpLogin.Controls.Add(Me.Label4)
        Me.grpLogin.Controls.Add(Me.btnCreate)
        Me.grpLogin.Controls.Add(Me.Label5)
        Me.grpLogin.Controls.Add(Me.txtPassCreate)
        Me.grpLogin.Controls.Add(Me.Label6)
        Me.grpLogin.Controls.Add(Me.txtUsernameCreate)
        Me.grpLogin.Location = New System.Drawing.Point(12, 351)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(365, 244)
        Me.grpLogin.TabIndex = 3
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(6, 152)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(353, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtConfirmCreate
        '
        Me.txtConfirmCreate.Location = New System.Drawing.Point(195, 112)
        Me.txtConfirmCreate.Name = "txtConfirmCreate"
        Me.txtConfirmCreate.Size = New System.Drawing.Size(164, 20)
        Me.txtConfirmCreate.TabIndex = 8
        Me.txtConfirmCreate.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Key_15
        Me.PictureBox3.Location = New System.Drawing.Point(9, 196)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Login"
        '
        'btnCreate
        '
        Me.btnCreate.Image = Global.Game_Launcher.My.Resources.Resources.icons8_Plus_15
        Me.btnCreate.Location = New System.Drawing.Point(247, 178)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(112, 33)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Sign Up"
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Passsword"
        '
        'txtPassCreate
        '
        Me.txtPassCreate.Location = New System.Drawing.Point(6, 112)
        Me.txtPassCreate.Name = "txtPassCreate"
        Me.txtPassCreate.Size = New System.Drawing.Size(164, 20)
        Me.txtPassCreate.TabIndex = 1
        Me.txtPassCreate.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Username"
        '
        'txtUsernameCreate
        '
        Me.txtUsernameCreate.Location = New System.Drawing.Point(6, 47)
        Me.txtUsernameCreate.Name = "txtUsernameCreate"
        Me.txtUsernameCreate.Size = New System.Drawing.Size(353, 20)
        Me.txtUsernameCreate.TabIndex = 0
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 573)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.grpCreate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCreate.ResumeLayout(False)
        Me.grpCreate.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpCreate As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsernameLogin As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassCreate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsernameCreate As TextBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpLogin.Enter

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtConfirmCreate As TextBox
End Class
