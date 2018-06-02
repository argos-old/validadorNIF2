Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sb = New System.Text.StringBuilder()

        If Form1.TopMost = True Then

            Me.TopMost = True
            Me.BringToFront()

        End If

        sb.Append(My.Resources.InstruccionesRTF.ToString)
        RichTextBox1.Rtf = sb.ToString()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class