<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btJugar = New System.Windows.Forms.Button()
        Me.cbApuesta = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(100, 17)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(121, 26)
        Me.tbNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apuesta $: "
        '
        'btJugar
        '
        Me.btJugar.Location = New System.Drawing.Point(237, 28)
        Me.btJugar.Name = "btJugar"
        Me.btJugar.Size = New System.Drawing.Size(134, 52)
        Me.btJugar.TabIndex = 4
        Me.btJugar.Text = "JUGAR"
        Me.btJugar.UseVisualStyleBackColor = True
        '
        'cbApuesta
        '
        Me.cbApuesta.FormattingEnabled = True
        Me.cbApuesta.Items.AddRange(New Object() {"20", "100", "200", "500", "1000"})
        Me.cbApuesta.Location = New System.Drawing.Point(100, 60)
        Me.cbApuesta.Name = "cbApuesta"
        Me.cbApuesta.Size = New System.Drawing.Size(121, 28)
        Me.cbApuesta.TabIndex = 5
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 261)
        Me.Controls.Add(Me.cbApuesta)
        Me.Controls.Add(Me.btJugar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btJugar As Button
    Friend WithEvents cbApuesta As ComboBox
End Class
