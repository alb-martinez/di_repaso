<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbPalabras = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btOrdenar = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.PuntuacionesDataSet = New RepasoExamDI.puntuacionesDataSet()
        Me.NombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombresTableAdapter = New RepasoExamDI.puntuacionesDataSetTableAdapters.nombresTableAdapter()
        Me.TableAdapterManager = New RepasoExamDI.puntuacionesDataSetTableAdapters.TableAdapterManager()
        Me.PuntuacionesDataSet2 = New RepasoExamDI.puntuacionesDataSet2()
        Me.NombresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombresTableAdapter1 = New RepasoExamDI.puntuacionesDataSet2TableAdapters.nombresTableAdapter()
        Me.TableAdapterManager1 = New RepasoExamDI.puntuacionesDataSet2TableAdapters.TableAdapterManager()
        CType(Me.PuntuacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntuacionesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPalabras
        '
        Me.lbPalabras.FormattingEnabled = True
        Me.lbPalabras.ItemHeight = 20
        Me.lbPalabras.Items.AddRange(New Object() {"caballo", "pez", "antorcha"})
        Me.lbPalabras.Location = New System.Drawing.Point(17, 53)
        Me.lbPalabras.Name = "lbPalabras"
        Me.lbPalabras.Size = New System.Drawing.Size(188, 264)
        Me.lbPalabras.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TextBox Editar Elementos"
        '
        'btAdd
        '
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Location = New System.Drawing.Point(211, 110)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(124, 51)
        Me.btAdd.TabIndex = 8
        Me.btAdd.Text = "Añadir"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btOrdenar
        '
        Me.btOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOrdenar.Location = New System.Drawing.Point(211, 53)
        Me.btOrdenar.Name = "btOrdenar"
        Me.btOrdenar.Size = New System.Drawing.Size(124, 51)
        Me.btOrdenar.TabIndex = 9
        Me.btOrdenar.Text = "Ordenar"
        Me.btOrdenar.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrar.Location = New System.Drawing.Point(211, 167)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(124, 51)
        Me.btBorrar.TabIndex = 10
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'PuntuacionesDataSet
        '
        Me.PuntuacionesDataSet.DataSetName = "puntuacionesDataSet"
        Me.PuntuacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombresBindingSource
        '
        Me.NombresBindingSource.DataMember = "nombres"
        Me.NombresBindingSource.DataSource = Me.PuntuacionesDataSet
        '
        'NombresTableAdapter
        '
        Me.NombresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nombresTableAdapter = Me.NombresTableAdapter
        Me.TableAdapterManager.puntosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RepasoExamDI.puntuacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PuntuacionesDataSet2
        '
        Me.PuntuacionesDataSet2.DataSetName = "puntuacionesDataSet2"
        Me.PuntuacionesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombresBindingSource1
        '
        Me.NombresBindingSource1.DataMember = "nombres"
        Me.NombresBindingSource1.DataSource = Me.PuntuacionesDataSet2
        '
        'NombresTableAdapter1
        '
        Me.NombresTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.nombresTableAdapter = Me.NombresTableAdapter1
        Me.TableAdapterManager1.puntosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = RepasoExamDI.puntuacionesDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 613)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btOrdenar)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPalabras)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PuntuacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntuacionesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPalabras As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btOrdenar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents PuntuacionesDataSet As puntuacionesDataSet
    Friend WithEvents NombresBindingSource As BindingSource
    Friend WithEvents NombresTableAdapter As puntuacionesDataSetTableAdapters.nombresTableAdapter
    Friend WithEvents TableAdapterManager As puntuacionesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PuntuacionesDataSet2 As puntuacionesDataSet2
    Friend WithEvents NombresBindingSource1 As BindingSource
    Friend WithEvents NombresTableAdapter1 As puntuacionesDataSet2TableAdapters.nombresTableAdapter
    Friend WithEvents TableAdapterManager1 As puntuacionesDataSet2TableAdapters.TableAdapterManager
End Class
