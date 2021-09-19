Public Class Form5
    Private Sub PuntosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PuntosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PuntosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PuntuacionesDataSet2)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntuacionesDataSet2.puntos' Puede moverla o quitarla según sea necesario.
        Me.PuntosTableAdapter.Fill(Me.PuntuacionesDataSet2.puntos)

    End Sub
End Class