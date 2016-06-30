Imports System.IO


Public Class main
    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Process.Start("updater.exe", "/checknow ")
    End Sub



    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName

        '  If Directory.Exists("/cache") Then

        'Directory.Delete("/cache", True)

        'MsgBox("Cache deleted successfully")

        'Else
        'MsgBox("There is no cache")

        'End If

    End Sub

    Private Sub arma3_Click(sender As Object, e As EventArgs) Handles arma3.Click
        Process.Start("steam://rungameid/107410")

    End Sub

    Private Sub csgo_Click(sender As Object, e As EventArgs) Handles csgo.Click
        Process.Start("steam://rungameid/730")
    End Sub

    Private Sub farcry3_Click(sender As Object, e As EventArgs) Handles farcry3.Click
        Process.Start("uplay://launch/46/1")
    End Sub

    Private Sub thedivision_Click(sender As Object, e As EventArgs) Handles thedivision.Click
        Process.Start("uplay://launch/568/0")
    End Sub

    Private Sub beta_Click(sender As Object, e As EventArgs) Handles beta.Click
        Process.Start("updater.exe", "/justcheck -critical ")
    End Sub

    Private Sub payday2_Click(sender As Object, e As EventArgs) Handles payday2.Click
        Process.Start("steam://rungameid/218620")
    End Sub

    Private Sub h1z1js_Click(sender As Object, e As EventArgs) Handles h1z1js.Click
        Process.Start("steam://rungameid/295110")
    End Sub

    Private Sub thecrew_Click(sender As Object, e As EventArgs) Handles thecrew.Click
        Process.Start("uplay://launch/413/0")
    End Sub

    Private Sub rainbowsix_Click(sender As Object, e As EventArgs) Handles rainbowsix.Click
        Process.Start("uplay://launch/635/0")
    End Sub

    Private Sub insurgency_Click(sender As Object, e As EventArgs) Handles insurgency.Click
        Process.Start("steam://rungameid/222880")
    End Sub
End Class
