<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfilePicture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfilePicture))
        Me.ProfilePicture = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imagechoose = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfilePicture
        '
        Me.ProfilePicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfilePicture.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePicture.Name = "ProfilePicture"
        Me.ProfilePicture.Size = New System.Drawing.Size(403, 452)
        Me.ProfilePicture.TabIndex = 0
        Me.ProfilePicture.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(316, 387)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 53)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'imagechoose
        '
        Me.imagechoose.FileName = "OpenFileDialog1"
        Me.imagechoose.Filter = "Image Files |*.jpg;"
        Me.imagechoose.Title = "Choose Profile Picture"
        '
        'frmProfilePicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 452)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.ProfilePicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfilePicture"
        Me.Text = "ProfilePicture"
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents imagechoose As OpenFileDialog
End Class
