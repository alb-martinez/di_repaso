Imports System.Data.OleDb

Public Class Form6
    Dim dbName As String = "escuelaaccess.mdb"
    Dim dbPath As String = Application.StartupPath & "\" & dbName
    Dim cadenaConexion As String = "PROVIDER=Microsoft.Jet.OleDb.4.0; " &
        "Data Source =" & dbPath
    Friend oleConexion As OleDbConnection = New OleDbConnection(cadenaConexion)

    Dim resultados
    Dim comando As New OleDbCommand()


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btConexion_Click(sender As Object, e As EventArgs) Handles btConexion.Click
        Conexion()
    End Sub

    Private Sub btInsercion_Click(sender As Object, e As EventArgs) Handles btInsercion.Click
        Inserccion()
    End Sub

    Private Sub btConsultaEscalar_Click(sender As Object, e As EventArgs) Handles btConsultaEscalar.Click
        consultaEscalar()
    End Sub

    Private Sub btConsulta_Click(sender As Object, e As EventArgs) Handles btConsulta.Click
        consulta()
    End Sub

    Private Sub btConsultaDesconectado_Click(sender As Object, e As EventArgs) Handles btConsultaDesconectado.Click
        ConsultaDesconectada()
    End Sub

    Private Sub btDesconexion_Click(sender As Object, e As EventArgs) Handles btDesconexion.Click
        oleConexion.Close()
        MessageBox.Show("Desconectado de la base de datos")
    End Sub

    Public Sub Conexion()
        Try
            oleConexion.Open()
            MessageBox.Show("Conectado a la base de datos")
        Catch ex As OleDbException
            MessageBox.Show("No se ha poedido conectar " + ex.Message)
        End Try
    End Sub

    Public Sub Inserccion()
        ' CommandText : Contiene la cadena de texto que representa la sentencia SQL y la realizamos por parametros
        comando.CommandText = "INSERT INTO alumnos(Id, Nombre, Apellidos, FechaNac, Provincia, Edad) " &
            "VALUES(@Id,@Nombre,@Apellidos,@FechaNac,@Provincia,@Edad)"
        ' Parametros del insert
        comando.Parameters.AddWithValue("@Id", 1)
        comando.Parameters.AddWithValue("@Nombre", "Federico")
        comando.Parameters.AddWithValue("@Apellidos", "Rodriguez")
        comando.Parameters.AddWithValue("@FechaNac", "01/01/1981")
        comando.Parameters.AddWithValue("@Provincia", "Valencia")
        comando.Parameters.AddWithValue("@Edad", 50)

        ' Conexion necesaria en oleDB
        comando.Connection = oleConexion

        ' Dentro de un bloque try/catch se llama al metodo .ExecuteNonQuery() que devuelve un entero con el nº de filas afectadas
        Try
            resultados = comando.ExecuteNonQuery()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        End Try

        ' No desconecto porque he habilitado un botón para ello
        ' oleConexion.Close()
        MessageBox.Show("Se han añadido " & resultados & " filas")

    End Sub

    Public Sub consultaEscalar()
        ' CommandText : Contiene la cadena de texto que representa la sentencia SQL
        comando.CommandText = "SELECT COUNT(*) FROM alumnos"

        ' Conexion necesaria en oleDB
        comando.Connection = oleConexion

        ' Llamada al metodo .ExecuteScalar
        resultados = comando.ExecuteScalar()

        ' Info del resultado
        MessageBox.Show("Hay " & resultados & " alumnos")
    End Sub

    Public Sub consulta()
        ' CommandText : Contiene la cadena de texto que representa la sentencia SQL
        comando.CommandText = "SELECT * FROM alumnos"

        ' Se crea un objeto DataReader que permite la navegación hacia delante y
        ' de solo lectura de los registros
        Dim lectorDatos As OleDbDataReader

        ' Conexion necesaria en oleDB
        comando.Connection = oleConexion

        ' Para obtener un objeto DataReader, tendremos que llamar al metodo .ExecuteReader de un objeto Command
        lectorDatos = comando.ExecuteReader()

        ' Limpiado del Listbox
        Me.lbListaAlumnos.Items.Clear()
        ' Recorrido de las filas devueltas en el DataReader y se muestran en el ListBox
        While lectorDatos.Read()
            Me.lbListaAlumnos.Items.Add(lectorDatos("Nombre"))
        End While

        ' Cerrado de recursos
        lectorDatos.Close()
    End Sub

    Public Sub ConsultaDesconectada()
        ' Creación del DataAdapter
        Dim adaptadorDatos As New OleDbDataAdapter("SELECT * FROM alumnos ORDER BY Nombre", oleConexion)

        ' Creación del DataSet
        Dim conjuntoDatos As New DataSet()

        ' Conecta con la BBDD, carga el DataSet y desconecta
        adaptadorDatos.Fill(conjuntoDatos, "alumnos")
        oleConexion.Close()

        ' Ahora DESCONECTADO, puedes trabajar con los datos del DataSet
        Dim tabla As DataTable
        tabla = conjuntoDatos.Tables("alumnos")
        Dim fila As DataRow
        Me.lbListaAlumnos.Items.Clear()
        For Each fila In tabla.Rows
            ' Muestra los datos en un listBox
            Me.lbListaAlumnos.Items.Add(fila.Item("Nombre") & " " & fila.Item("Apellidos"))
        Next
    End Sub

    Private Sub btMasDatos_Click(sender As Object, e As EventArgs)

    End Sub
End Class