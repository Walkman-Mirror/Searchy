Public Class Form1
    Public version As String = My.Application.Info.Version.ToString & " (pre-release)"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        version_label_small.Text = version
        If My.Settings.RememberLastSearchEngine = True Then
            ComboBox1.Text = My.Settings.RememberLastSearchEngine_value.ToString
        End If
        If My.Settings.RememberLastSearchQuery = True Then TextBox1.Text = My.Settings.RememberLastSearchQuery_value
        ComboBox1.Text = My.Settings.DefaultSerachEngine
        KeyChecker.Interval = My.Settings.KeyCheckerInterval
        KeyChecker.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.TopButtonClosesApp = False Then
            Me.Hide()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(Query:=TextBox1.Text)
    End Sub

    Private Sub Search(Query As String)
        If ComboBox1.Text = "Google" Then
            Process.Start("https://www.google.co.za/search?q=" & Query.ToString)
        End If
        If ComboBox1.Text = "Yahoo" Then
            Process.Start("https://search.yahoo.com/search;_ylt=AuZofarTFB0Bfxqb9LY04nLoQeF_?p=" & Query.ToString)
        End If
        If ComboBox1.Text = "Bing" Then
            Process.Start("https://www.bing.com/search?q=" & Query.ToString)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If My.Settings.RememberLastSearchEngine = True Then My.Settings.RememberLastSearchEngine_value = ComboBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If My.Settings.RememberLastSearchQuery = True Then My.Settings.RememberLastSearchQuery_value = TextBox1.Text
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Application.Exit()
    End Sub

    Private Sub ProjectSiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectSiteToolStripMenuItem.Click
        Process.Start("https://deavmi.github.io/Searchy")
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.Visible = True Then
            HideToolStripMenuItem.Text = "&Hide"
        Else
            HideToolStripMenuItem.Text = "S&how"
        End If
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub SubmitFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitFeedbackToolStripMenuItem.Click
        Process.Start("mailto:tristankildaire@gmail.com")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub KeyChecker_Tick(sender As Object, e As EventArgs) Handles KeyChecker.Tick
        If My.Computer.Keyboard.CtrlKeyDown = True And My.Computer.Keyboard.ShiftKeyDown = True Then
            If Me.Visible = True Then
                Me.Hide()
            Else
                Me.Show()
            End If
        End If
    End Sub
End Class
