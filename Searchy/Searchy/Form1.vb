Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        version_label.Text = My.Application.Info.Version.ToString
        If My.Settings.RememberLastSearchEngine = True Then
            ComboBox1.Text = My.Settings.RememberLastSearchEngine_value.ToString
        End If
        If My.Settings.RememberLastSearchQuery = True Then
            TextBox1.Text = My.Settings.RememberLastSearchQuery_value.ToString
            WebBrowser1.Navigate(My.Settings.RememberLastSearchEngine_value.ToString)
        End If
        ComboBox1.Text = My.Settings.DefaultSerachEngine.ToString
        If My.Settings.ShowOpenInBrowserButton = True Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If
        If My.Settings.ShowResultsPreview = True Then
            Label2.Visible = True
            WebBrowser1.Visible = True
        Else
            Label2.Visible = False
            WebBrowser1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Google" Then
            WebBrowser1.Navigate("https://www.google.co.za/search?q=" & TextBox1.Text.ToString)
        End If
        If ComboBox1.Text = "Yahoo" Then
            WebBrowser1.Navigate("https://search.yahoo.com/search;_ylt=AuZofarTFB0Bfxqb9LY04nLoQeF_?p=" & TextBox1.Text.ToString)
        End If
        If ComboBox1.Text = "Bing" Then
            WebBrowser1.Navigate("https://www.bing.com/search?q=" & TextBox1.Text.ToString)
        End If
    End Sub

    Private Sub Button1_DoubleClick(sender As Object, e As EventArgs) Handles Button1.DoubleClick
        If My.Settings.DoubleClickSearchToOpenInBrowser = True Then
            Process.Start(WebBrowser1.Url.ToString)
        Else
            'Do nothing
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If My.Settings.RememberLastSearchQuery = True Then
            My.Settings.RememberLastSearchQuery_value = TextBox1.Text.ToString()
        End If
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        WebBrowser1.Visible = False
        Label3.Visible = True
        Label3.Text = "Finding that for you..."
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        Label3.Text = "Finishing up..."
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Label3.Visible = False
        WebBrowser1.Visible = True
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
End Class
