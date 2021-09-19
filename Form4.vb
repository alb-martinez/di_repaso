Public Class Form4
    ' Variable para la ordenacion
    Dim ordenado As Boolean = True

    Private Sub btOrdenar_Click(sender As Object, e As EventArgs) Handles btOrdenar.Click
        Dim listaNueva(lbPalabras.Items.Count - 1) As Object

        If ordenado Then
            lbPalabras.Sorted = True
            ordenado = False
        ElseIf ordenado = False Then
            lbPalabras.Sorted = False
            lbPalabras.Items.CopyTo(listaNueva, 0)
            Array.Reverse(listaNueva)
            lbPalabras.Items.Clear()
            lbPalabras.Items.AddRange(listaNueva)
            ordenado += 1
        End If
    End Sub

    Private Sub comprobarCantidadPalabras()
        If (lbPalabras.Items.Count < 3) Then
            btBorrar.Enabled = False
        ElseIf (lbPalabras.Items.Count >= 3) Then
            btBorrar.Enabled = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntuacionesDataSet2.nombres' Puede moverla o quitarla según sea necesario.
        Me.NombresTableAdapter1.Fill(Me.PuntuacionesDataSet2.nombres)

        comprobarCantidadPalabras()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim mensaje = "Escriba la palabra a añadir"
        Dim titulo = "Palabra nueva"
        Dim result As String


        result = InputBox(mensaje, titulo)
        If (result = "") Then
            MsgBox("Debe introducir una palabra")
        Else
            If (comprobarDuplicada(result)) Then
                MsgBox("La palabra está repetida", , "Añadir Palabra")
            Else
                lbPalabras.Items.Add(result)

            End If
        End If
        comprobarCantidadPalabras()
    End Sub

    Private Function comprobarDuplicada(ByRef palabra As String) As Boolean
        Dim duplicada As Boolean

        For Each itemValue As String In lbPalabras.Items
            If itemValue = palabra Then
                duplicada = True
            End If
        Next

        Return duplicada
    End Function

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Dim mensaje As String = "¿Seguro que desea borrar la palabra?"
        Dim titulo = "Borrar Palabra"
        Dim result As DialogResult

        If (lbPalabras.SelectedIndex) = -1 Then
            MsgBox("Debe seleccionar una palabra a borrar", , "Borrar Palabra")
        Else
            result = MessageBox.Show(mensaje + "  " + lbPalabras.SelectedItem.ToString, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.No) Then
                Me.Close()
            Else
                lbPalabras.Items.RemoveAt(lbPalabras.SelectedIndex)
            End If
        End If

        comprobarCantidadPalabras()
    End Sub



    Private Sub btPasar_Click(sender As Object, e As EventArgs) 
        Dim mensaje As String = "¿Seguro que desea borrar la palabra?"
        Dim titulo = "Borrar Palabra"
        Dim result As DialogResult


        If (lbPalabras.SelectedIndex) = -1 Then
            MsgBox("Debe seleccionar una palabra a pasar", , "Pasar Palabra")
        Else
            result = MessageBox.Show(mensaje + "  " + lbPalabras.SelectedItem.ToString, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.No) Then
                Me.Close()
            Else
                'NombreTextBox.Text = lbPalabras.SelectedItem.ToString
            End If
        End If
    End Sub


End Class