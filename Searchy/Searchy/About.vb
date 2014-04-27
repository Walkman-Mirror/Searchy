﻿Public Class About
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim version As String = My.Application.Info.Version.ToString & " (beta)"
        Label4.Text = version
        WebBrowser1.Navigate("http://deavmi.github.io/Searchy/changelog.txt")
        WebBrowser2.Navigate("http://deavmi.github.io/Searchy/credits.txt")
        WebBrowser3.Navigate("http://deavmi.github.io/Searchy/licenses.txt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://deavmi.github.io/Searchy")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("http://github.com/deavmi/Searchy")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        changelog_text.Text = WebBrowser1.Document.Body.InnerText.ToString
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        credits_text.Text = WebBrowser2.Document.Body.InnerText.ToString
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted
        licenses_text.Text = WebBrowser3.Document.Body.InnerText.ToString
    End Sub
End Class