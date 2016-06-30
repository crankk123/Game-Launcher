<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.h1z1js = New MetroFramework.Controls.MetroButton()
        Me.payday2 = New MetroFramework.Controls.MetroButton()
        Me.arma3 = New MetroFramework.Controls.MetroButton()
        Me.csgo = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.thedivision = New MetroFramework.Controls.MetroButton()
        Me.farcry3 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.beta = New MetroFramework.Controls.MetroButton()
        Me.update_button = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.LabelCompanyName = New MetroFramework.Controls.MetroLabel()
        Me.LabelCopyright = New MetroFramework.Controls.MetroLabel()
        Me.LabelProductName = New MetroFramework.Controls.MetroLabel()
        Me.LabelVersion = New MetroFramework.Controls.MetroLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.thecrew = New MetroFramework.Controls.MetroButton()
        Me.rainbowsix = New MetroFramework.Controls.MetroButton()
        Me.insurgency = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        Me.MetroTabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage5)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage6)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(24, 63)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 5
        Me.MetroTabControl1.Size = New System.Drawing.Size(485, 240)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.insurgency)
        Me.MetroTabPage1.Controls.Add(Me.h1z1js)
        Me.MetroTabPage1.Controls.Add(Me.payday2)
        Me.MetroTabPage1.Controls.Add(Me.arma3)
        Me.MetroTabPage1.Controls.Add(Me.csgo)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Steam"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'h1z1js
        '
        Me.h1z1js.Location = New System.Drawing.Point(107, 39)
        Me.h1z1js.Name = "h1z1js"
        Me.h1z1js.Size = New System.Drawing.Size(101, 30)
        Me.h1z1js.TabIndex = 5
        Me.h1z1js.Text = "H1Z1 Just Survice"
        Me.h1z1js.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.h1z1js.UseSelectable = True
        '
        'payday2
        '
        Me.payday2.Location = New System.Drawing.Point(0, 39)
        Me.payday2.Name = "payday2"
        Me.payday2.Size = New System.Drawing.Size(101, 30)
        Me.payday2.TabIndex = 4
        Me.payday2.Text = "Payday2"
        Me.payday2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.payday2.UseSelectable = True
        '
        'arma3
        '
        Me.arma3.Location = New System.Drawing.Point(107, 3)
        Me.arma3.Name = "arma3"
        Me.arma3.Size = New System.Drawing.Size(101, 30)
        Me.arma3.TabIndex = 3
        Me.arma3.Text = "Arma3"
        Me.arma3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.arma3.UseSelectable = True
        '
        'csgo
        '
        Me.csgo.Location = New System.Drawing.Point(0, 3)
        Me.csgo.Name = "csgo"
        Me.csgo.Size = New System.Drawing.Size(101, 30)
        Me.csgo.TabIndex = 2
        Me.csgo.Text = "CSGO"
        Me.csgo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.csgo.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.rainbowsix)
        Me.MetroTabPage2.Controls.Add(Me.thecrew)
        Me.MetroTabPage2.Controls.Add(Me.thedivision)
        Me.MetroTabPage2.Controls.Add(Me.farcry3)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Uplay"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'thedivision
        '
        Me.thedivision.Location = New System.Drawing.Point(103, 3)
        Me.thedivision.Name = "thedivision"
        Me.thedivision.Size = New System.Drawing.Size(101, 30)
        Me.thedivision.TabIndex = 5
        Me.thedivision.Text = "The Division"
        Me.thedivision.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.thedivision.UseSelectable = True
        '
        'farcry3
        '
        Me.farcry3.Location = New System.Drawing.Point(-4, 3)
        Me.farcry3.Name = "farcry3"
        Me.farcry3.Size = New System.Drawing.Size(101, 30)
        Me.farcry3.TabIndex = 4
        Me.farcry3.Text = "FarCry3"
        Me.farcry3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.farcry3.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Freunde"
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.BackColor = System.Drawing.Color.BlueViolet
        Me.MetroTabPage4.Controls.Add(Me.beta)
        Me.MetroTabPage4.Controls.Add(Me.update_button)
        Me.MetroTabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Einstellungen"
        Me.MetroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'beta
        '
        Me.beta.Location = New System.Drawing.Point(4, 42)
        Me.beta.Name = "beta"
        Me.beta.Size = New System.Drawing.Size(102, 23)
        Me.beta.TabIndex = 5
        Me.beta.Text = "Beta"
        Me.beta.UseSelectable = True
        Me.beta.Visible = False
        '
        'update_button
        '
        Me.update_button.Location = New System.Drawing.Point(3, 12)
        Me.update_button.Name = "update_button"
        Me.update_button.Size = New System.Drawing.Size(103, 23)
        Me.update_button.TabIndex = 4
        Me.update_button.Text = "Update Suchen?"
        Me.update_button.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.update_button.UseSelectable = True
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.Controls.Add(Me.LabelCompanyName)
        Me.MetroTabPage5.Controls.Add(Me.LabelCopyright)
        Me.MetroTabPage5.Controls.Add(Me.LabelProductName)
        Me.MetroTabPage5.Controls.Add(Me.LabelVersion)
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage5.TabIndex = 4
        Me.MetroTabPage5.Text = "Über"
        Me.MetroTabPage5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(2, 45)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(66, 19)
        Me.LabelCompanyName.TabIndex = 10
        Me.LabelCompanyName.Text = "Company"
        Me.LabelCompanyName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(3, 26)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(67, 19)
        Me.LabelCopyright.TabIndex = 9
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(3, 7)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(55, 19)
        Me.LabelProductName.TabIndex = 8
        Me.LabelProductName.Text = "Produkt"
        Me.LabelProductName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelVersion.Location = New System.Drawing.Point(3, 64)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(51, 19)
        Me.LabelVersion.TabIndex = 7
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'thecrew
        '
        Me.thecrew.Location = New System.Drawing.Point(-4, 39)
        Me.thecrew.Name = "thecrew"
        Me.thecrew.Size = New System.Drawing.Size(101, 30)
        Me.thecrew.TabIndex = 6
        Me.thecrew.Text = "The Crew"
        Me.thecrew.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.thecrew.UseSelectable = True
        '
        'rainbowsix
        '
        Me.rainbowsix.Location = New System.Drawing.Point(103, 39)
        Me.rainbowsix.Name = "rainbowsix"
        Me.rainbowsix.Size = New System.Drawing.Size(101, 30)
        Me.rainbowsix.TabIndex = 7
        Me.rainbowsix.Text = "Rainbow Six"
        Me.rainbowsix.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rainbowsix.UseSelectable = True
        '
        'insurgency
        '
        Me.insurgency.Location = New System.Drawing.Point(0, 75)
        Me.insurgency.Name = "insurgency"
        Me.insurgency.Size = New System.Drawing.Size(101, 30)
        Me.insurgency.TabIndex = 6
        Me.insurgency.Text = "Insurgency"
        Me.insurgency.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.insurgency.UseSelectable = True
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(477, 198)
        Me.MetroTabPage6.TabIndex = 5
        Me.MetroTabPage6.Text = "Changelog"
        Me.MetroTabPage6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 326)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Game Launcher"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage5.ResumeLayout(False)
        Me.MetroTabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents csgo As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LabelCompanyName As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelCopyright As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelProductName As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelVersion As MetroFramework.Controls.MetroLabel
    Friend WithEvents arma3 As MetroFramework.Controls.MetroButton
    Friend WithEvents update_button As MetroFramework.Controls.MetroButton
    Friend WithEvents farcry3 As MetroFramework.Controls.MetroButton
    Friend WithEvents thedivision As MetroFramework.Controls.MetroButton
    Friend WithEvents beta As MetroFramework.Controls.MetroButton
    Friend WithEvents payday2 As MetroFramework.Controls.MetroButton
    Friend WithEvents h1z1js As MetroFramework.Controls.MetroButton
    Friend WithEvents thecrew As MetroFramework.Controls.MetroButton
    Friend WithEvents rainbowsix As MetroFramework.Controls.MetroButton
    Friend WithEvents insurgency As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
End Class
