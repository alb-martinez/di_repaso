Public Class Form3
    Private Sub btSiNo_Click(sender As Object, e As EventArgs) Handles btSiNo.Click
        Dim result As DialogResult
        Dim mensaje As String = "¿PREGUNTA A REALIZAR?"
        Dim titulo As String = "MENSAJE SI o NO"

        result = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.No) Then
            Me.Close()
        Else
            MessageBox.Show("Has pulsado que si")
            ' Llamar al metodo necesario
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mensaje As String = "AQUI VA EL ERROR"
        Dim titulo As String = "MENSAJE DE ERROR"
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mensaje As String = "ESCRIBE LO NECESARIO"
        Dim titulo As String = "MENSAJE CON CAMPO DE TEXTO"
        Dim result As String

        result = InputBox(mensaje, titulo)
        If (result = "") Then
            MsgBox("Debes intoducir algo")
        Else
            ' Realizar algun comprobación más o llamada a algun metodo
            MsgBox("Has escrito:" + result)
        End If
    End Sub
End Class