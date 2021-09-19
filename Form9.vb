Public Class Form9

    Dim letras As String() = {"A", "B", "C", "D", "F", "G", "H", "I", "J", "K"}
    Dim tableroMaquina(10, 10) As Button
    Dim tableroJugador(10, 10) As Button
    Dim tableLetras(10) As Button
    Dim nombreBoton As Integer
    Dim barcoDeTres(3) As Integer
    Dim barcoDeDos(2) As Integer
    Dim barcoDeUno(1) As Integer



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenaTablero()
        colocaBarcos()
    End Sub


    Public Sub rellenaTablero()
        Dim filas = 10
        Dim columnas = 10
        Dim contador As Integer = 1
        Dim contador2 As Integer = 1

        For i = 0 To filas - 1
            For j = 0 To columnas - 1
                tableroMaquina(i, j) = New Button
                tableroMaquina(i, j).Width = 48
                tableroMaquina(i, j).Height = 48
                tableroMaquina(i, j).Name = contador
                AddHandler tableroMaquina(i, j).Click, AddressOf MaquinaClik
                tbMaquina.Controls.Add(tableroMaquina(i, j))
                contador += 1
            Next
        Next

        For i = 0 To filas - 1
            For j = 0 To columnas - 1
                tableroJugador(i, j) = New Button
                tableroJugador(i, j).Width = 48
                tableroJugador(i, j).Height = 48
                tableroJugador(i, j).Name = contador2
                AddHandler tableroJugador(i, j).Click, AddressOf Button_Click
                tbJugador.Controls.Add(tableroJugador(i, j))
                contador2 += 1
            Next
        Next

        For i = 0 To 9
            tableLetras(i) = New Button
            tableLetras(i).Width = 48
            tableLetras(i).Height = 48
            tableLetras(i).Name = "bt" & i
            tableLetras(i).Text = letras(i)
            tableLetras(i).Enabled = False
            tlbLetrasMaq.Controls.Add(tableLetras(i))

        Next

        For i = 0 To 9
            tableLetras(i) = New Button
            tableLetras(i).Width = 48
            tableLetras(i).Height = 48
            tableLetras(i).Name = "bt" & i
            tableLetras(i).Text = i + 1
            tableLetras(i).Enabled = False
            tlbNumerosMaq.Controls.Add(tableLetras(i))
        Next

        For i = 0 To 9
            tableLetras(i) = New Button
            tableLetras(i).Width = 48
            tableLetras(i).Height = 48
            tableLetras(i).Name = "bt" & i
            tableLetras(i).Text = letras(i)
            tableLetras(i).Enabled = False
            tblLetrasJug.Controls.Add(tableLetras(i))

        Next

        For i = 0 To 9
            tableLetras(i) = New Button
            tableLetras(i).Width = 48
            tableLetras(i).Height = 48
            tableLetras(i).Name = "bt" & i
            tableLetras(i).Text = i + 1
            tableLetras(i).Enabled = False
            tlbNumerosJug.Controls.Add(tableLetras(i))
        Next

    End Sub



    Private Sub Button_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub colocaBarcos()
        For i = 0 To 2
            seleccionaBarcos(i)
        Next
    End Sub


    Public Sub seleccionaBarcos(ByVal tamaño)
        Dim pos1 As Integer
        Dim pos2 As Integer

        'pos1 = CInt((1 - 10) * Rnd() + 10)
        'pos2 = CInt((1 - 10) * Rnd() + 10)
        Dim Random As New Random()
        pos1 = Random.Next(1, 10)
        pos2 = Random.Next(1, 10)

        nombreBoton = tableroMaquina(pos1, pos2).Name
        'MessageBox.Show("un barco de 3 en " & nombreBoton & nombreBoton + 1 & nombreBoton + 2)

        If tamaño = 0 Then
            barcoDeUno(tamaño) = nombreBoton
            MessageBox.Show(barcoDeUno(tamaño))
        ElseIf tamaño = 1 Then
            For i = 0 To tamaño
                barcoDeDos(i) = nombreBoton
                nombreBoton = nombreBoton + 1
                MessageBox.Show(barcoDeDos(tamaño))
            Next
        ElseIf tamaño = 2 Then
            For i = 0 To tamaño
                barcoDeTres(i) = nombreBoton
                nombreBoton = nombreBoton + 1
                MessageBox.Show(barcoDeTres(tamaño))
            Next
        End If
    End Sub

    Private Sub MaquinaClik(sender As Object, e As EventArgs)
        Dim boton As Button = TryCast(sender, Button)

        MessageBox.Show(boton.Name)


        If barcoDeTres.Contains(boton.Name) Then
            MessageBox.Show("has tocado un barco de tres")
            boton.Enabled = False
            boton.BackColor = Color.Red
        ElseIf barcoDeDos.Contains(boton.Name) Then
            MessageBox.Show("has tocado un barco de dos")
            boton.Enabled = False
            boton.BackColor = Color.Red
        ElseIf barcoDeUno.Contains(boton.Name) Then
            MessageBox.Show("has tocado un barco de uno")
            boton.Enabled = False
            boton.BackColor = Color.Red
        Else
            MessageBox.Show("has tocado agua")
            boton.BackColor = Color.Blue
        End If


    End Sub



End Class