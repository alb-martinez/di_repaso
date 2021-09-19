<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim InicialesLabel As System.Windows.Forms.Label
        Dim PuntosLabel As System.Windows.Forms.Label
        Me.PuntuacionesDataSet2 = New RepasoExamDI.puntuacionesDataSet2()
        Me.PuntosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntosTableAdapter = New RepasoExamDI.puntuacionesDataSet2TableAdapters.puntosTableAdapter()
        Me.TableAdapterManager = New RepasoExamDI.puntuacionesDataSet2TableAdapters.TableAdapterManager()
        Me.PuntosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PuntosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PuntosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicialesTextBox = New System.Windows.Forms.TextBox()
        Me.PuntosTextBox = New System.Windows.Forms.TextBox()
        InicialesLabel = New System.Windows.Forms.Label()
        PuntosLabel = New System.Windows.Forms.Label()
        CType(Me.PuntuacionesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PuntosBindingNavigator.SuspendLayout()
        CType(Me.PuntosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PuntuacionesDataSet2
        '
        Me.PuntuacionesDataSet2.DataSetName = "puntuacionesDataSet2"
        Me.PuntuacionesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuntosBindingSource
        '
        Me.PuntosBindingSource.DataMember = "puntos"
        Me.PuntosBindingSource.DataSource = Me.PuntuacionesDataSet2
        '
        'PuntosTableAdapter
        '
        Me.PuntosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.nombresTableAdapter = Nothing
        Me.TableAdapterManager.puntosTableAdapter = Me.PuntosTableAdapter
        Me.TableAdapterManager.UpdateOrder = RepasoExamDI.puntuacionesDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PuntosBindingNavigator
        '
        Me.PuntosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PuntosBindingNavigator.BindingSource = Me.PuntosBindingSource
        Me.PuntosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PuntosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PuntosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PuntosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PuntosBindingNavigatorSaveItem})
        Me.PuntosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PuntosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PuntosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PuntosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PuntosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PuntosBindingNavigator.Name = "PuntosBindingNavigator"
        Me.PuntosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PuntosBindingNavigator.Size = New System.Drawing.Size(1042, 33)
        Me.PuntosBindingNavigator.TabIndex = 0
        Me.PuntosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 25)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PuntosBindingNavigatorSaveItem
        '
        Me.PuntosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PuntosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PuntosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PuntosBindingNavigatorSaveItem.Name = "PuntosBindingNavigatorSaveItem"
        Me.PuntosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PuntosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PuntosDataGridView
        '
        Me.PuntosDataGridView.AutoGenerateColumns = False
        Me.PuntosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PuntosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.PuntosDataGridView.DataSource = Me.PuntosBindingSource
        Me.PuntosDataGridView.Location = New System.Drawing.Point(50, 80)
        Me.PuntosDataGridView.Name = "PuntosDataGridView"
        Me.PuntosDataGridView.RowHeadersWidth = 62
        Me.PuntosDataGridView.RowTemplate.Height = 28
        Me.PuntosDataGridView.Size = New System.Drawing.Size(527, 271)
        Me.PuntosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "iniciales"
        Me.DataGridViewTextBoxColumn1.HeaderText = "iniciales"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "puntos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "puntos"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'InicialesLabel
        '
        InicialesLabel.AutoSize = True
        InicialesLabel.Location = New System.Drawing.Point(61, 383)
        InicialesLabel.Name = "InicialesLabel"
        InicialesLabel.Size = New System.Drawing.Size(68, 20)
        InicialesLabel.TabIndex = 2
        InicialesLabel.Text = "iniciales:"
        '
        'InicialesTextBox
        '
        Me.InicialesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PuntosBindingSource, "iniciales", True))
        Me.InicialesTextBox.Location = New System.Drawing.Point(135, 380)
        Me.InicialesTextBox.Name = "InicialesTextBox"
        Me.InicialesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InicialesTextBox.TabIndex = 3
        '
        'PuntosLabel
        '
        PuntosLabel.AutoSize = True
        PuntosLabel.Location = New System.Drawing.Point(286, 386)
        PuntosLabel.Name = "PuntosLabel"
        PuntosLabel.Size = New System.Drawing.Size(62, 20)
        PuntosLabel.TabIndex = 4
        PuntosLabel.Text = "puntos:"
        '
        'PuntosTextBox
        '
        Me.PuntosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PuntosBindingSource, "puntos", True))
        Me.PuntosTextBox.Location = New System.Drawing.Point(360, 383)
        Me.PuntosTextBox.Name = "PuntosTextBox"
        Me.PuntosTextBox.Size = New System.Drawing.Size(100, 26)
        Me.PuntosTextBox.TabIndex = 5
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 635)
        Me.Controls.Add(InicialesLabel)
        Me.Controls.Add(Me.InicialesTextBox)
        Me.Controls.Add(PuntosLabel)
        Me.Controls.Add(Me.PuntosTextBox)
        Me.Controls.Add(Me.PuntosDataGridView)
        Me.Controls.Add(Me.PuntosBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.PuntuacionesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PuntosBindingNavigator.ResumeLayout(False)
        Me.PuntosBindingNavigator.PerformLayout()
        CType(Me.PuntosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PuntuacionesDataSet2 As puntuacionesDataSet2
    Friend WithEvents PuntosBindingSource As BindingSource
    Friend WithEvents PuntosTableAdapter As puntuacionesDataSet2TableAdapters.puntosTableAdapter
    Friend WithEvents TableAdapterManager As puntuacionesDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents PuntosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PuntosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PuntosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents InicialesTextBox As TextBox
    Friend WithEvents PuntosTextBox As TextBox
End Class
