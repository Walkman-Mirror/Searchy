'Put description here
'   Free Software from DeavmiOSS. GPL v3 or above.

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
'   Contact the DeavmiOSS organization by electronic mail: mailto:deavmioss@gmail.com

Public Class Searchy

    'Public declarations
    Public version As String = My.Application.Info.Version.ToString & " (pre-release)"
    Dim ProgramFilesDir As String = Environment.GetEnvironmentVariable("ProgramFiles")

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
        Select Case cbEngine.Text
            ' == Web ==
            Case "Google"
                OpenLink("https://www.google.co.za/search?q=" & Query)
            Case "Yahoo"
                OpenLink("https://search.yahoo.com/search;_ylt=AuZofarTFB0Bfxqb9LY04nLoQeF_?p=" & Query)
            Case "Bing"
                OpenLink("https://www.bing.com/search?q=" & Query)
            Case "DuckDuckGo"
                OpenLink("https://duckduckgo.com/?q=" & Query)
                ' == Images ==
            Case "Google Images"
                OpenLink("https://www.google.com/search?tbm=isch&qscrl=1&q=" & Query)
            Case "Google Images (Atari Breakout)"
                OpenLink("https://www.google.com/search?tbm=isch&qscrl=1&tbs=boee:1&q=" & Query)
            Case "Bing Images"
                OpenLink("http://www.bing.com/images/search?q=" & Query)
                ' == Music ==
            Case "SoundCloud"
                OpenLink("https://soundcloud.com/search?q=" & Query)
            Case "Beatport"
                OpenLink("http://www.beatport.com/search?query=" & Query)
                ' == Video ==
            Case "YouTube"
                OpenLink("https://www.youtube.com/results?search_query=" & Query)
            Case "Dailymotion"
                OpenLink("https://www.dailymotion.com/en/relevance/search/" & Query)
            Case "Google Videos"
                OpenLink("https://www.google.com/search?tbm=vid&qscrl=1&q=" & Query)
            Case "Bing Videos"
                OpenLink(("http://www.bing.com/videos/search?q=" & Query)
                ' == Social ==
            Case "Reddit"
                OpenLink("http://www.reddit.com/search?q=" & Query)
                ' == Maps ==
            Case "Google Maps"
                OpenLink("https://www.google.com/maps/place/" & Query)
                ' == Info ==
            Case "Wikipedia"
                OpenLink("https://en.wikipedia.org/wiki/" & Query)
            Case "Newgrounds"
                OpenLink("http://www.newgrounds.com/search?topsearch_type=15&topsearch_text=" & Query)
                ' == Products ==
            Case "eBay"
                OpenLink("http://www.ebay.com/sch/i.html?_trksid=p2050601.m570.l1313&_nkw=" & Query & "&_sacat=0&_from=R40")
            Case "Amazon"
                OpenLink("http://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Daps&field-keywords=" & Query)
                ' == Code ==
            Case "GitHub"
                OpenLink("https://github.com/search?q=" & Query)
            Case "Bitbucket"
                OpenLink("https://bitbucket.org/" & Query)
            Case "Stack Overflow"
                OpenLink("https://stackoverflow.com/search?q=" & Query)
            Case "Super User"
                OpenLink("https://superuser.com/search?q=" & Query)
            Case "Stack Exchange"
                OpenLink("https://stackexchange.com/search?q=" & Query)
        End Select
    End Sub

    'settings

    Private Sub cbEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEngine.SelectedIndexChanged
        Select Case cbEngine.Text
            Case "Google"
                lblTypeOfSearch.Text = "Search the Web:"
        End Select
        If My.Settings.RememberLastSearchEngine = True Then My.Settings.RememberLastSearchEngine_value = cbEngine.Text
    End Sub

    Private Sub txtQuery_TextChanged(sender As Object, e As EventArgs) Handles txtQuery.TextChanged
        If My.Settings.RememberLastSearchQuery = True Then My.Settings.RememberLastSearchQuery_value = txtQuery.Text
    End Sub

    'links

    Private Sub NotificationContextMenuProjectSite_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuProjectSite.Click
        OpenLink("https://deavmi.github.io/Searchy")
    End Sub

    Private Sub NotificationContextMenuSubmitFeedback_Click(sender As Object, e As EventArgs) Handles NotificationContextMenuSubmitFeedback.Click
        OpenLink("https://github.com/deavmi/Searchy/issues/new")
    End Sub

    Private Sub OpenLink(link As String)
        If txtComboBrowser.Text = "Browse..." Or txtComboBrowser.Text = "" Then
            Process.Start(link)
        ElseIf txtComboBrowser.Text = "Mozilla Firefox (%ProgramFiles%\Mozilla Firefox\firefox.exe)" Then
            Process.Start(ProgramFilesDir & "\Mozilla Firefox\firefox.exe", link)
        ElseIf txtComboBrowser.Text = "Google Chrome (%ProgramFiles%\Google\Chrome\Application\chrome.exe)" Then
            Process.Start(ProgramFilesDir & "\Google\Chrome\Application\chrome.exe", link)
        ElseIf txtComboBrowser.Text = "Opera 22 (%ProgramFiles%\Opera\launcher.exe)" Then
            Process.Start(ProgramFilesDir & "\Opera\launcher.exe", link)
        ElseIf txtComboBrowser.Text = "Opera 12 (%ProgramFiles%\Opera\opera.exe)" Then
            Process.Start(ProgramFilesDir & "\Opera\opera.exe", link)
        ElseIf txtComboBrowser.Text = "Safari (%ProgramFiles%\Safari\Safari.exe)" Then
            Process.Start(ProgramFilesDir & "\Safari\Safari.exe", link)
        ElseIf txtComboBrowser.Text = "Avant Browser (%ProgramFiles%\Avant Browser\avant.exe)" Then
            Process.Start(ProgramFilesDir & "\Avant Browser\avant.exe", link)
        ElseIf txtComboBrowser.Text = "Lunascape6 (%ProgramFiles%\Lunascape\Lunascape6\Luna.exe)" Then
            Process.Start(ProgramFilesDir & "\Lunascape\Lunascape6\Luna.exe", link)
        ElseIf txtComboBrowser.Text = "Sea Monkey (%ProgramFiles%\SeaMonkey\seamonkey.exe)" Then
            Process.Start(ProgramFilesDir & "\SeaMonkey\seamonkey.exe", link)
        ElseIf txtComboBrowser.Text = "Internet Explorer (%ProgramFiles%\Internet Explorer\iexplore.exe)" Then
            Process.Start(ProgramFilesDir & "\Internet Explorer\iexplore.exe", link)
        ElseIf txtComboBrowser.Text = "Netscape Navigator 9 (%ProgramFiles%\Netscape\Navigator 9\navigator.exe)" Then
            Process.Start(ProgramFilesDir & "\Netscape\Navigator 9\navigator.exe", link)
        ElseIf System.IO.File.Exists(txtComboBrowser.Text) Then
            Process.Start(txtComboBrowser.Text, link)
        Else
            MsgBox("File """ & txtComboBrowser.Text & """ not found!", MsgBoxStyle.Critical, "Executable not found")
        End If
    End Sub

    Sub txtComboBrowser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtComboBrowser.SelectedIndexChanged
        If txtComboBrowser.Text = "Browse..." Then
            'openFileDialogBrowser.ShowDialog()
        End If

        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        End If
    End Sub

    Sub chkRememberBrowser_Click(sender As Object, e As EventArgs) Handles chkRememberBrowser.Click
        My.Settings.RememberBrowser = chkRememberBrowser.Checked
        If My.Settings.RememberBrowser = True Then
            My.Settings.LastBrowser = txtComboBrowser.Text
        End If
    End Sub
End Class
