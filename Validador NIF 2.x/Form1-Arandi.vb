Public Class Form1


#Region " SUBRUTINAS DEL FORM "

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaskedTextBox1.Focus()

    End Sub

    Private Sub Botón1_Comprobar(sender As Object, e As EventArgs) Handles KryptonButton1.Click

        MaskedTextBox1.Text = UCase(MaskedTextBox1.Text)
        If SetNum(MaskedTextBox1.Text) = "" Then Exit Sub

        Dim Cadena As String = MaskedTextBox1.Text
        Dim Letra As String = NIF(SetNum(Cadena))
        Dim Última As String = Mid(Cadena, 12, 1)

        If Len(SetNum(Cadena)) > 7 Then

            If Última = "" Then

                Label2.Image = My.Resources.security_card48
                Label1.Text = "Letra: " & Letra
                MaskedTextBox1.Text = Cadena & Letra
                CopiaTexto()

            Else

                If Letra = Última Then

                    Label2.Image = My.Resources.check_verde36
                    Label1.Text = "Correcto"
                    CopiaTexto()

                Else

                    Label2.Image = My.Resources.error32
                    Label1.Text = "Error: letra " & Letra

                End If

            End If

        Else

            Msg("error")

        End If

    End Sub

    Private Sub Botón2_Nuevo(sender As Object, e As EventArgs) Handles KryptonButton2.Click

        Label1.Text = "Validador NIF"
        MaskedTextBox1.Clear()
        MaskedTextBox1.Focus()

    End Sub

    Private Sub Botón3_Pegar(sender As Object, e As EventArgs) Handles KryptonButton3.Click

        MaskedTextBox1.Clear()
        MaskedTextBox1.Paste()
        Label2.Image = My.Resources.security_card48
        Label1.Text = ""
        If ComprobarLetraAlPegarToolStripMenuItem1.Checked = True Then Call Botón1_Comprobar(sender, e)

    End Sub

    Private Sub CopiarResultadoAlPortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarResultadoAlPortapapelesToolStripMenuItem1.Click

        If CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = True Then

            CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = False

        ElseIf CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = False Then

            CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = True

        End If

    End Sub

    Private Sub ValidadorSiempreEncimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidadorSiempreEncimaToolStripMenuItem1.Click

        If ValidadorSiempreEncimaToolStripMenuItem1.Checked = True Then

            ValidadorSiempreEncimaToolStripMenuItem1.Checked = False
            Me.TopMost = False

        ElseIf ValidadorSiempreEncimaToolStripMenuItem1.Checked = False Then

            ValidadorSiempreEncimaToolStripMenuItem1.Checked = True
            Me.TopMost = True

        End If

    End Sub

    Private Sub ComprobarLetraAlPegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobarLetraAlPegarToolStripMenuItem1.Click

        If ComprobarLetraAlPegarToolStripMenuItem1.Checked = True Then

            ComprobarLetraAlPegarToolStripMenuItem1.Checked = False

        ElseIf ComprobarLetraAlPegarToolStripMenuItem1.Checked = False Then

            ComprobarLetraAlPegarToolStripMenuItem1.Checked = True

        End If
    End Sub

    Private Sub CómoFuncionaValidadorNIFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CómoFuncionaValidadorNIFToolStripMenuItem1.Click

        Form2.Show()

    End Sub

    Private Sub AcercaDeLaAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeLaAplicaciónToolStripMenuItem1.Click

        Form3.Show()

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click

        MaskedTextBox1.SelectAll()
        MaskedTextBox1.Copy()

    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click

        Call Botón3_Pegar(sender, e)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

        Call Botón2_Nuevo(sender, e)

    End Sub

#End Region

#Region " SUBRUTINAS DE APOYO "

    Private Sub Msg(ByVal tipo As String)

        If tipo = "error" Then

            'MsgBox("El DNI introducido no es válido. Por favor, asegúrate de que estén los 8 dígitos. (La letra es op" & _
            '       "cional)" & vbCrLf & vbCrLf & "Ejemplos: 12345678, 12.345.678-A, 12345678A, 12.345.678A, 12345678-A", _
            '       MsgBoxStyle.Exclamation, "Error")
            Form4.Show()

        End If

    End Sub

    Private Sub CopiaTexto()

        If CopiarResultadoAlPortapapelesToolStripMenuItem1.Checked = True Then

            MaskedTextBox1.SelectAll()
            MaskedTextBox1.Copy()

        End If

    End Sub

#End Region

#Region " FUNCIONES "

    Private Function NIF(DNI As Long)

        ' Función original: http://es.wikibooks.org/wiki/Algoritmo_para_obtener_la_letra_del_NIF#Visual_Basic
        ' NIF = DNI & "-" & Mid$("TRWAGMYFPDXBNJZSQVHLCKE", (DNI Mod 23) + 1, 1)

        Try

            NIF = Mid$("TRWAGMYFPDXBNJZSQVHLCKE", (DNI Mod 23) + 1, 1)

        Catch ex As Exception

            Msg("error")
            Return "ERROR"

        End Try

    End Function

    Public Function SetNum(ByVal texto As String) As String

        Dim StrChars As String = texto.ToCharArray
        Dim outputStr As String = ""

        Try

            For Each w As String In StrChars

                If Char.IsDigit(w) = True Then

                    outputStr &= w

                End If

            Next

        Catch ex As Exception

        End Try

        Return outputStr

    End Function

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Form4.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
