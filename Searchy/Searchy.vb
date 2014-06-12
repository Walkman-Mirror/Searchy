Public Class Searchy

    'Public declarations
    Public version As String = My.Application.Info.Version.ToString & " (pre-release)"

    'window-related stuff

    Private Sub Searchy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersionSmall.Text = version
        If My.Settings.RememberLastSearchEngine = True Then cbEngine.Text = My.Settings.RememberLastSearchEngine_value
        If My.Settings.RememberLastSearchQuery = True Then txtQuery.Text = My.Settings.RememberLastSearchQuery_value
        cbEngine.Text = My.Settings.DefaultSearchEngine
        timerKeyChecker.Start()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If My.Settings.TopButtonClosesApp = False Then
            Me.Hide()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub NotificationIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotificationIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub NotificationContextMenuExit_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub NotificationContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NotificationContextMenu.Opening
        If Me.Visible = True Then
            NotificationContextMenuHide.Text = "&Hide"
        Else
            NotificationContextMenuHide.Text = "S&how"
        End If
    End Sub

    Private Sub NotificationContextMenuHide_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuHide.Click
        If Me.Visible = True Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub NotificationContextMenuAbout_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub timerKeyChecker_Tick(sender As Object, e As EventArgs) Handles timerKeyChecker.Tick
        If My.Computer.Keyboard.CtrlKeyDown = True And My.Computer.Keyboard.ShiftKeyDown = True Then
            If Me.Visible = True Then
                Me.Hide()
            Else
                Me.Show()
            End If
        End If
    End Sub

    'start searches

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(Query:=txtQuery.Text)
    End Sub

    Private Sub Search(Query As String)
        If txtQuery.Text = "" Then
            ' == Web ==
        ElseIf cbEngine.Text = "Google" Then 'Google
            Process.Start("https://www.google.co.za/search?q=" & Query & "&qscrl=1")
        ElseIf cbEngine.Text = "Yahoo" Then 'Yahoo
            Process.Start("https://search.yahoo.com/search;_ylt=AuZofarTFB0Bfxqb9LY04nLoQeF_?p=" & Query)
        ElseIf cbEngine.Text = "Bing" Then 'Bing
            Process.Start("https://www.bing.com/search?q=" & Query)
        ElseIf cbEngine.Text = "DuckDuckGo" Then 'DuckDuckGo
            Process.Start("https://duckduckgo.com/?q=" & Query)
            ' == Images ==
        ElseIf cbEngine.Text = "Google Image search" Then 'Google Image Search
            Process.Start("https://www.google.com/search?newwindow=1&site=&tbm=isch&source=hp&biw=1360&bih=621&q=" & Query & "&btnG=Search+by+image&oq=&gs_l=")
            ' == Music ==
        ElseIf cbEngine.Text = "SoundCloud" Then 'SoundCloud
            Process.Start("https://soundcloud.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Beatport" Then 'Beatport
            Process.Start("http://www.beatport.com/search?query=" & Query)
            ' == Video ==
        ElseIf cbEngine.Text = "YouTube" Then 'YouTube
            Process.Start("https://www.youtube.com/results?search_query=" & Query)
        ElseIf cbEngine.Text = "Dailymotion" Then 'Dailymotion
            Process.Start("https://www.dailymotion.com/en/relevance/search/" & Query)
        ElseIf cbEngine.Text = "Google Video Search" Then 'Google Video Search
            Process.Start("https://www.google.com/search?tbm=vid&hl=en&source=hp&biw=&bih=&q=" & Query & "&btnG=Google+Search&gbv=2&oq=&gs_l=")
            ' == Info ==
        ElseIf cbEngine.Text = "Wikipedia" Then 'Wikipedia
            Process.Start("https://en.wikipedia.org/wiki/" & Query)
        ElseIf cbEngine.Text = "Newsgrounds" Then 'Newsgrounds
            Process.Start("http://www.newgrounds.com/search?topsearch_text=" & Query & "&topsearch_type=15")
            ' == Products ==
        ElseIf cbEngine.Text = "eBay" Then 'eBay
            Process.Start("http://www.ebay.com/sch/i.html?_trksid=p2050601.m570.l1313&_nkw=" & Query & "&_sacat=0&_from=R40")
        ElseIf cbEngine.Text = "Amazon" Then 'Amazon
            Process.Start("http://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=" & Query)
            ' == Code ==
        ElseIf cbEngine.Text = "GitHub" Then 'GitHub
            Process.Start("https://github.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Bitbucket" Then 'Bitbucket
            Process.Start("https://bitbucket.org/" & Query)
        ElseIf cbEngine.Text = "Stack Overflow" Then 'Stack Overflow
            Process.Start("https://stackoverflow.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Super User" Then 'Super User
            Process.Start("https://superuser.com/search?q=" & Query)
        ElseIf cbEngine.Text = "Stack Exchange" Then 'Stack Exchange
            Process.Start("https://stackexchange.com/search?q=" & Query)

        End If
    End Sub

    'settings

    Private Sub cbEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEngine.SelectedIndexChanged
        If My.Settings.RememberLastSearchEngine = True Then My.Settings.RememberLastSearchEngine_value = cbEngine.Text
    End Sub

    Private Sub txtQuery_TextChanged(sender As Object, e As EventArgs) Handles txtQuery.TextChanged
        If My.Settings.RememberLastSearchQuery = True Then My.Settings.RememberLastSearchQuery_value = txtQuery.Text
    End Sub

    'links

    Private Sub NotificationContextMenuProjectSite_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuProjectSite.Click
        Process.Start("https://deavmi.github.io/Searchy")
    End Sub

    Private Sub NotificationContextMenuSubmitFeedback_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuSubmitFeedback.Click
        Process.Start("https://github.com/deavmi/Searchy/issues/new")
    End Sub

End Class
