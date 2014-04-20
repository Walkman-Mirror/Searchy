Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        version_label.Text = My.Application.Info.Version.ToString
        If My.Settings.RememberLastSearchEngine = True Then
            ComboBox1.Text = My.Settings.RememberLastSearchEngine_value.ToString
        End If
        ComboBox1.Text = My.Settings.DefaultSerachEngine.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Google" Then
            WebBrowser1.Navigate("https://www.google.co.za/search?q=" & TextBox1.Text.ToString)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(WebBrowser1.Url.ToString)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If My.Settings.RememberLastSearchEngine = True Then
            My.Settings.RememberLastSearchEngine_value = ComboBox1.Text.ToString
        End If
    End Sub
End Class
