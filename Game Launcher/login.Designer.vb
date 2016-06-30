<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits MetroFramework.Forms.MetroForm

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
        Me.UsernameTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.UsernameLabel = New MetroFramework.Controls.MetroLabel()
        Me.PasswordLabel = New MetroFramework.Controls.MetroLabel()
        Me.loginb = New MetroFramework.Controls.MetroButton()
        Me.cancel_login = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.CustomButton.Image = Nothing
        Me.UsernameTextBox.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.UsernameTextBox.CustomButton.Name = ""
        Me.UsernameTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameTextBox.CustomButton.TabIndex = 1
        Me.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameTextBox.CustomButton.UseSelectable = True
        Me.UsernameTextBox.CustomButton.Visible = False
        Me.UsernameTextBox.Lines = New String(-1) {}
        Me.UsernameTextBox.Location = New System.Drawing.Point(190, 89)
        Me.UsernameTextBox.MaxLength = 32767
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.Size = New System.Drawing.Size(151, 23)
        Me.UsernameTextBox.TabIndex = 0
        Me.UsernameTextBox.UseSelectable = True
        Me.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String() {"MetroTextBox2"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(190, 144)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(151, 23)
        Me.MetroTextBox2.TabIndex = 1
        Me.MetroTextBox2.Text = "MetroTextBox2"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(190, 64)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(68, 19)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(190, 119)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(63, 19)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password"
        '
        'loginb
        '
        Me.loginb.Location = New System.Drawing.Point(190, 201)
        Me.loginb.Name = "loginb"
        Me.loginb.Size = New System.Drawing.Size(75, 23)
        Me.loginb.TabIndex = 4
        Me.loginb.Text = "Login"
        Me.loginb.UseSelectable = True
        '
        'cancel_login
        '
        Me.cancel_login.Location = New System.Drawing.Point(284, 201)
        Me.cancel_login.Name = "cancel_login"
        Me.cancel_login.Size = New System.Drawing.Size(75, 23)
        Me.cancel_login.TabIndex = 5
        Me.cancel_login.Text = "Abbrechen"
        Me.cancel_login.UseSelectable = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 231)
        Me.Controls.Add(Me.cancel_login)
        Me.Controls.Add(Me.loginb)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Name = "login"
        Me.Text = "login"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UsernameLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents PasswordLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents loginb As MetroFramework.Controls.MetroButton
    Friend WithEvents cancel_login As MetroFramework.Controls.MetroButton
End Class
