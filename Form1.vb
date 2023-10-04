Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String
        Dim Birthyear As Integer
        YourMessage = "HAPPY BIRTHDAY! HOW OLD ARE YOU NOW?"

        MsgBox(YourMessage)
        Birthyear = Val(InputBox("Birth Year"))
        MsgBox("YOU ARE NOW" & 2023 - Birthyear & "YEARS OLD")

    End Sub
End Class
