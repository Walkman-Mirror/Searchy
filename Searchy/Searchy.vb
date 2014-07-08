'Put description here
'   FGOSS from DeavmiOSS. GPL v3 or above.

'   This program is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   This program is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
'   Contact the DeavmiOSS organization by electronic mail: mailto:tristankildaire@gmail.com or mailto:walkman@hackermail.com (mailto:matthewcarter17@gmail.com)

Public Class Searchy

    'Public declarations
    Public version As String = My.Application.Info.Version.ToString & " (pre-release)"
    Dim UseDefaultBrowser As Boolean = True
    Dim ProgramFilesDir As String = Environment.GetEnvironmentVariable("ProgramFiles")
    Dim openIn As String = ""
    
    'window-related stuff

    Private Sub Searchy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersionSmall.Text = version
        If My.Settings.RememberLastSearchEngine = True Then cbEngine.Text = My.Settings.RememberLastSearchEngine_value
        If My.Settings.RememberLastSearchQuery = True Then txtQuery.Text = My.Settings.RememberLastSearchQuery_value
        cbEngine.Text = My.Settings.DefaultSearchEngine
        chkRememberBrowser.Checked = My.Settings.RememberBrowser
        If My.Settings.RememberBrowser = True Then
            txtComboBrowser.Text = My.Settings.LastBrowser
        End If
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
        Search(txtQuery.Text)
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
        ElseIf cbEngine.Text = "Google Images" Then 'Google Image Search
            Process.Start("https://www.google.com/search?newwindow=1&site=&tbm=isch&source=hp&biw=1360&bih=621&q=" & Query & "&btnG=Search+by+image&oq=&gs_l=")
        ElseIf cbEngine.Text = "Bing Images" Then 'Bing Image Search
            Process.Start("http://www.bing.com/images/search?q=" & Query)
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
        ElseIf cbEngine.Text = "Google Videos" Then 'Google Video Search
            Process.Start("https://www.google.com/search?tbm=vid&hl=en&source=hp&biw=&bih=&q=" & Query & "&btnG=Google+Search&gbv=2&oq=&gs_l=")
        ElseIf cbEngine.Text = "Bing Videos" Then 'Bing Video Search
            Process.Start("http://www.bing.com/videos/search?q=" & Query)
            ' == Social ==
        ElseIf cbEngine.Text = "Reddit" Then 'Reddit
            Process.Start("http://www.reddit.com/search?q=" & Query)
            ' == Maps ==
        ElseIf cbEngine.Text = "Google Maps" Then
            Process.Start("https://www.google.com/maps/place/" & Query)
            ' == Info ==
        ElseIf cbEngine.Text = "Wikipedia" Then 'Wikipedia
            Process.Start("https://en.wikipedia.org/wiki/" & Query)
        ElseIf cbEngine.Text = "Newgrounds" Then 'Newgrounds
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
    
    Private Sub GetBrowser()
        If txtComboBrowser.Text = "Browse..." Or txtComboBrowser.Text = "" Then
            UseDefaultBrowser = True
        ElseIf txtComboBrowser.Text = "Mozilla Firefox (%ProgramFiles%\Mozilla Firefox\firefox.exe)" Then
            openIn = ProgramFilesDir & "\Mozilla Firefox\firefox.exe"
        ElseIf txtComboBrowser.Text = "Google Chrome (%ProgramFiles%\Google\Chrome\Application\chrome.exe)" Then
            openIn = ProgramFilesDir & "\Google\Chrome\Application\chrome.exe"
        ElseIf txtComboBrowser.Text = "Opera 22 (%ProgramFiles%\Opera\launcher.exe)" Then
            openIn = ProgramFilesDir & "\Opera\launcher.exe"
        ElseIf txtComboBrowser.Text = "Opera 12 (%ProgramFiles%\Opera\opera.exe)" Then
            openIn = ProgramFilesDir & "\Opera\opera.exe"
        ElseIf txtComboBrowser.Text = "Safari (%ProgramFiles%\Safari\Safari.exe)" Then
            openIn = ProgramFilesDir & "\Safari\Safari.exe"
        ElseIf txtComboBrowser.Text = "Avant Browser (%ProgramFiles%\Avant Browser\avant.exe)" Then
            openIn = ProgramFilesDir & "\Avant Browser\avant.exe"
        ElseIf txtComboBrowser.Text = "Lunascape6 (%ProgramFiles%\Lunascape\Lunascape6\Luna.exe)" Then
            openIn = ProgramFilesDir & "\Lunascape\Lunascape6\Luna.exe"
        ElseIf txtComboBrowser.Text = "Sea Monkey (%ProgramFiles%\SeaMonkey\seamonkey.exe)" Then
            openIn = ProgramFilesDir & "\SeaMonkey\seamonkey.exe"
        ElseIf txtComboBrowser.Text = "Internet Explorer (%ProgramFiles%\Internet Explorer\iexplore.exe)" Then
            openIn = ProgramFilesDir & "\Internet Explorer\iexplore.exe"
        ElseIf txtComboBrowser.Text = "Netscape Navigator 9 (%ProgramFiles%\Netscape\Navigator 9\navigator.exe)" Then
            openIn = ProgramFilesDir & "\Netscape\Navigator 9\navigator.exe"
        ElseIf system.io.File.Exists(txtComboBrowser.Text) Then
            openIn = txtComboBrowser.Text
        End If
    End Sub
    
    Sub TxtComboBrowser_SelectedIndexChanged(sender As Object, e As EventArgs)
        If txtComboBrowser.Text = "Default link handler" Then
            UseDefaultBrowser = True
        Else
            UseDefaultBrowser = False
        End If

        If txtComboBrowser.Text = "Browse..." Then
            'openFileDialogBrowser.ShowDialog()
        End If
        
        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        End If
    End Sub
    
    Sub ChkRememberBrowser_Click(sender As Object, e As EventArgs)
        My.Settings.RememberBrowser = chkRememberBrowser.Checked
        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        End If
    End Sub
End Class
