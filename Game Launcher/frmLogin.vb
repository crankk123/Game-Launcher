


Public Class frmlogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 365


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.AcceptButton = btnCreate
        Me.grpLogin.Enabled = False
        Me.grpCreate.Enabled = True
        Me.Height = 612
        txtUsernameCreate.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.AcceptButton = btnLogin
        Me.grpLogin.Enabled = True
        Me.grpCreate.Enabled = False
        Me.Height = 365
        txtUsernameLogin.Focus()

    End Sub
End Class