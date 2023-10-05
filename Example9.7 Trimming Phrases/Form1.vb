Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")
        TextTrim.Text = Trim(myPhrase)
    End Sub

    Private Sub btnTrimR_Click(sender As Object, e As EventArgs) Handles btnTrimR.Click

        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")
        TextTrim.Text = RTrim(myPhrase)
    End Sub

    Private Sub btnTrimL_Click(sender As Object, e As EventArgs) Handles btnTrimL.Click

        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")
        TextTrim.Text = LTrim(myPhrase)
    End Sub
End Class
