Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = "El DNI introducido no es válido. Por favor, asegúrate de que estén los 8 dígitos. (La letra es op" & _
                   "cional)" & vbCrLf & vbCrLf & "Ejemplos: 12345678, 12.345.678-A, 12345678A, 12.345.678A, 12345678-A"
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        Form1.Enabled = False

    End Sub

    Private Sub Form4_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        Form1.Enabled = True

    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click

        Me.Close()

    End Sub
End Class