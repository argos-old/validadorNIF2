Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.TopMost = True Then

            Me.TopMost = True
            Me.BringToFront()

        End If

    End Sub

End Class