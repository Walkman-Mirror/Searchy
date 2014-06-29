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
' Contact the DeavmiOSS orginization by electronic mail: mailto:tristankildaire@gmail.com or mailto:walkman@hackermail.com (mailto:matthewcarter17@gmail.com)

Public Class Preferences

    Private Sub Done(sender As Object, e As EventArgs) Handles btnDone.Click
        ApplyChanges()
        Me.Close()
    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Haven't finished this code yet.
        CheckBox1.Checked = My.Settings.RememberLastSearchEngine
        CheckBox2.Checked = My.Settings.RememberLastSearchQuery
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ApplyChanges()
    End Sub

    Private Sub ApplyChanges()
        My.Settings.RememberLastSearchEngine = CheckBox1.Checked
        My.Settings.RememberLastSearchQuery = CheckBox2.Checked
        My.Settings.Save()
    End Sub

    Private Sub Reset(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.Reset()
        MsgBox("Setting have been reset!", MsgBoxStyle.Information)
        ApplyChanges()
    End Sub
End Class