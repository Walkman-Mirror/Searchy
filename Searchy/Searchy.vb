Public Class Searchy
    Public version As String = My.Application.Info.Version.ToString & " (pre-release)"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersionSmall.Text = version
        If My.Settings.RememberLastSearchEngine = True Then cbEngine.Text = My.Settings.RememberLastSearchEngine_value
        If My.Settings.RememberLastSearchQuery = True Then txtQuery.Text = My.Settings.RememberLastSearchQuery_value
        cbEngine.Text = My.Settings.DefaultSerachEngine
        timerKeyChecker.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If My.Settings.TopButtonClosesApp = False Then
            Me.Hide()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(Query:=txtQuery.Text)
    End Sub

    Private Sub Search(Query As String)
        'Site search engines
        If txtQuery.Text = "" Then
            'idk do nothing ;D
        ElseIf cbEngine.Text = "Google" Then
            Process.Start("https://www.google.co.za/search?q=" & Query & "&qscrl=1")
        ElseIf cbEngine.Text = "Yahoo" Then
            Process.Start("https://search.yahoo.com/search;_ylt=AuZofarTFB0Bfxqb9LY04nLoQeF_?p=" & Query)
        ElseIf cbEngine.Text = "Bing" Then
            Process.Start("https://www.bing.com/search?q=" & Query)
        ElseIf cbEngine.Text = "DuckDuckGo" Then
            Process.Start("https://duckduckgo.com/?q=" & Query)
        ElseIf cbEngine.Text = "YouTube" Then 'Video search engines
            Process.Start("https://www.youtube.com/results?search_query=" & Query)
        ElseIf cbEngine.Text = "Dailymotion" Then
            Process.Start("https://www.dailymotion.com/en/relevance/search/" & Query)
        ElseIf cbEngine.Text = "SoundCloud" Then
            Process.Start("https://soundcloud.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Beatport" Then
            Process.Start("http://www.beatport.com/search?query=" & Query)
        ElseIf cbEngine.Text = "GitHub" Then 'Code search engines
            Process.Start("https://github.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Bitbucket" Then
            Process.Start("https://bitbucket.org/" & Query)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEngine.SelectedIndexChanged
        If My.Settings.RememberLastSearchEngine = True Then My.Settings.RememberLastSearchEngine_value = cbEngine.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtQuery.TextChanged
        If My.Settings.RememberLastSearchQuery = True Then My.Settings.RememberLastSearchQuery_value = txtQuery.Text
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotificationIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub ProjectSiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuProjectSite.Click
        Process.Start("https://deavmi.github.io/Searchy")
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NotificationContextMenu.Opening
        If Me.Visible = True Then
            NotificationContextMenuHide.Text = "&Hide"
        Else
            NotificationContextMenuHide.Text = "S&how"
        End If
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuHide.Click
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub SubmitFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuSubmitFeedback.Click
        Process.Start("mailto:tristankildaire@gmail.com")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub KeyChecker_Tick(sender As Object, e As EventArgs) Handles timerKeyChecker.Tick
        If My.Computer.Keyboard.CtrlKeyDown = True And My.Computer.Keyboard.ShiftKeyDown = True Then
            If Me.Visible = True Then
                Me.Hide()
            Else
                Me.Show()
            End If
        End If
    End Sub
End Class