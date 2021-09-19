Imports System.Data.OleDb
Public Class Form8

    Dim m, a, b, c As Integer
    Dim jugador As String
    Dim dinero As Double
    Dim ganancias As Double
    Dim fecha As Date = FormatDateTime(Now, DateFormat.ShortDate)

    Dim dbName As String = "tragaperras.mdb"
    Dim dbPath As String = Application.StartupPath & "\" & dbName
    Dim cadenaConexion As String = "PROVIDER=Microsoft.Jet.OleDb.4.0; " &
        "Data Source =" & dbPath
    Friend oleConexion As OleDbConnection = New OleDbConnection(cadenaConexion)

    Dim resultados
    Dim comando As New OleDbCommand()

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDinero.Text = dinero
        lbNombre.Text = jugador
        lbDineroApostado.Text = dinero
        btGuardar.Enabled = False
    End Sub

    Public Sub crearPartida()
        Me.lbNombre.Text = jugador
        Me.lbDinero.Text = dinero
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        m = m + 10

        If m < 1000 Then
            a = Int(1 + Rnd() * 3)
            b = Int(1 + Rnd() * 3)
            c = Int(1 + Rnd() * 3)

            Select Case a
                Case 1
                    pbUno.Image = My.Resources.virus
                Case 2
                    pbUno.Image = My.Resources.jabon
                Case 3
                    pbUno.Image = My.Resources.mascarilla
            End Select

            Select Case b
                Case 1
                    pbDos.Image = My.Resources.virus
                Case 2
                    pbDos.Image = My.Resources.jabon
                Case 3
                    pbDos.Image = My.Resources.mascarilla
            End Select

            Select Case c
                Case 1
                    pbTres.Image = My.Resources.virus
                Case 2
                    pbTres.Image = My.Resources.jabon
                Case 3
                    pbTres.Image = My.Resources.mascarilla
            End Select

        Else
            Timer1.Enabled = False
            m = 0

            'If a = b Or a = c Or b = c Then
            '    lbInfo.Text = "Good Luck! You won $20!"
            '    ganancias += ganancias + 20
            '    lbGanancias.Text = ganancias
            '    pbTres.Enabled = True
            'ElseIf a = c Then
            '    lbInfo.Text = "Good Luck! You won $70!"
            '    ganancias += ganancias + 70
            '    lbGanancias.Text = ganancias
            'ElseIf b = c Then
            '    lbInfo.Text = "Good Luck! You won $80!"
            '    ganancias += ganancias + 80
            '    lbGanancias.Text = ganancias
            'ElseIf a = b And b = c Then
            '    lbInfo.Text = "Jackpot! You won $300!"
            '    ganancias += ganancias + 300
            '    lbGanancias.Text = ganancias
            'Else
            '    lbInfo.Text = "No lucky, please try again!"
            'End If

            If a = b And b = c Then
                lbInfo.Text = "Jackpot! You won $1100!"
                ganancias += ganancias + 1000
                lbGanancias.Text = ganancias
            Else
                lbInfo.Text = "No lucky, please try again!"
            End If

            If finPartida() = True Then
                btSpin.Enabled = False
                btGuardar.Enabled = True
            End If

        End If
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        comando.CommandText = "insert into tragaperras (nombre, apuesta, ganancia, fecha) " &
            "values(@nombre, @apuesta, @ganancia, @fecha)"
        ' parametros del insert
        ' comando.Parameters.AddWithValue("@id", 1)
        comando.Parameters.AddWithValue("@nombre", jugador)
        comando.Parameters.AddWithValue("@apuesta", lbDineroApostado.Text)
        comando.Parameters.AddWithValue("@ganancia", ganancias)
        comando.Parameters.AddWithValue("@fecha", fecha)

        ' conexion
        comando.Connection = oleConexion
        oleConexion.Open()

        'try catch
        Try
            resultados = comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MessageBox.Show("Se han guardado " & resultados & " filas")

        oleConexion.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btSpin.Click
        lbInfo.Text = "...."
        Timer1.Enabled = True
        dinero = dinero - 20
        lbDinero.Text = dinero

    End Sub

    Public Function finPartida() As Boolean
        Dim mensaje As String = "Ha tenido unas ganancias totales de " + ganancias.ToString
        Dim titulo As String = "FIN DE PARTIDA"

        If dinero = 0 Then
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If

    End Function
    Public Function traerDatos(ByVal nombre1, ByVal dinero)
        Me.jugador = nombre1
        Me.dinero = dinero
    End Function


End Class