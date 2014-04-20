Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        version_label.Text = My.Application.Info.Version.ToString
        ComboBox1.Text = My.Settings.DefaultSerachEngine.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class
