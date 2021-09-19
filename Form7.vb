Public Class Form7
    Dim nombreJug As String
    Dim dineroApostado As Double

    Private Sub btJugar_Click(sender As Object, e As EventArgs) Handles btJugar.Click

        If comprobaciones() Then
            Form8.traerDatos(nombreJug, dineroApostado)
            Form8.crearPartida()

            Form8.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        nombreJug = tbNombre.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApuesta.SelectedIndexChanged
        dineroApostado = cbApuesta.SelectedItem.ToString
    End Sub

    Private Function comprobaciones() As Boolean
        If tbNombre.Text = "" Then
            MessageBox.Show("Por favor, indique un nombre")
            Return False
        ElseIf cbApuesta.SelectedItem = Nothing Then
            MessageBox.Show("Por favor, indique una apuesta")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class