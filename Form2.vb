Public Class Form2
    ' Array de botones para el tablero
    Dim botonesTablero(8, 8) As Button

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarPartida()
    End Sub

    Private Sub crearBotonesTablero()

        Dim contador As Integer = 1

        ' recorrido del tableLayoutPanel
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                ' Se crea un botón nuevo en cada iteración
                botonesTablero(i, j) = New Button
                botonesTablero(i, j).Width = 99
                botonesTablero(i, j).Height = 99
                botonesTablero(i, j).Name = "bt" + contador.ToString
                botonesTablero(i, j).Text = contador.ToString

                '  Handler para el boton creado
                AddHandler botonesTablero(i, j).Click, AddressOf Button_Click
                ' Se añade el botón creado al tableLayoutPanel
                tlpTablero.Controls.Add(botonesTablero(i, j))
                contador += 1
            Next
        Next

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Variable para copiar el boton
        Dim boton As Button = TryCast(sender, Button)

        ' lanzar el metodo necesario

        boton.Enabled = False
        boton.BackColor = Color.Red
        MessageBox.Show("Has pulsado el boton " + boton.Text)

    End Sub

    Private Sub iniciarPartida()
        ' Inicializar los valore por defecto
        ' Limpiar el tablero
        tlpTablero.Controls.Clear()

        ' Volver a crear los botones de nuevo
        crearBotonesTablero()
    End Sub

End Class