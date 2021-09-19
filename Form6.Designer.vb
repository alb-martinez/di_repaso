<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btDesconexion = New System.Windows.Forms.Button()
        Me.lbListaAlumnos = New System.Windows.Forms.ListBox()
        Me.btConsultaDesconectado = New System.Windows.Forms.Button()
        Me.btConsulta = New System.Windows.Forms.Button()
        Me.btConsultaEscalar = New System.Windows.Forms.Button()
        Me.btInsercion = New System.Windows.Forms.Button()
        Me.btConexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btDesconexion
        '
        Me.btDesconexion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDesconexion.Location = New System.Drawing.Point(202, 14)
        Me.btDesconexion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btDesconexion.Name = "btDesconexion"
        Me.btDesconexion.Size = New System.Drawing.Size(180, 117)
        Me.btDesconexion.TabIndex = 20
        Me.btDesconexion.Text = "Desconexión"
        Me.btDesconexion.UseVisualStyleBackColor = True
        '
        'lbListaAlumnos
        '
        Me.lbListaAlumnos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbListaAlumnos.FormattingEnabled = True
        Me.lbListaAlumnos.ItemHeight = 23
        Me.lbListaAlumnos.Location = New System.Drawing.Point(201, 287)
        Me.lbListaAlumnos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbListaAlumnos.Name = "lbListaAlumnos"
        Me.lbListaAlumnos.Size = New System.Drawing.Size(264, 349)
        Me.lbListaAlumnos.TabIndex = 19
        '
        'btConsultaDesconectado
        '
        Me.btConsultaDesconectado.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsultaDesconectado.Location = New System.Drawing.Point(13, 519)
        Me.btConsultaDesconectado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btConsultaDesconectado.Name = "btConsultaDesconectado"
        Me.btConsultaDesconectado.Size = New System.Drawing.Size(180, 117)
        Me.btConsultaDesconectado.TabIndex = 18
        Me.btConsultaDesconectado.Text = "Consulta Desconectado"
        Me.btConsultaDesconectado.UseVisualStyleBackColor = True
        '
        'btConsulta
        '
        Me.btConsulta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsulta.Location = New System.Drawing.Point(13, 393)
        Me.btConsulta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btConsulta.Name = "btConsulta"
        Me.btConsulta.Size = New System.Drawing.Size(180, 117)
        Me.btConsulta.TabIndex = 17
        Me.btConsulta.Text = "Consulta"
        Me.btConsulta.UseVisualStyleBackColor = True
        '
        'btConsultaEscalar
        '
        Me.btConsultaEscalar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsultaEscalar.Location = New System.Drawing.Point(13, 267)
        Me.btConsultaEscalar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btConsultaEscalar.Name = "btConsultaEscalar"
        Me.btConsultaEscalar.Size = New System.Drawing.Size(180, 117)
        Me.btConsultaEscalar.TabIndex = 16
        Me.btConsultaEscalar.Text = "Consulta Escalar"
        Me.btConsultaEscalar.UseVisualStyleBackColor = True
        '
        'btInsercion
        '
        Me.btInsercion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInsercion.Location = New System.Drawing.Point(13, 141)
        Me.btInsercion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btInsercion.Name = "btInsercion"
        Me.btInsercion.Size = New System.Drawing.Size(180, 117)
        Me.btInsercion.TabIndex = 15
        Me.btInsercion.Text = "Inserción"
        Me.btInsercion.UseVisualStyleBackColor = True
        '
        'btConexion
        '
        Me.btConexion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConexion.Location = New System.Drawing.Point(13, 14)
        Me.btConexion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btConexion.Name = "btConexion"
        Me.btConexion.Size = New System.Drawing.Size(180, 117)
        Me.btConexion.TabIndex = 14
        Me.btConexion.Text = "Conexión"
        Me.btConexion.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 860)
        Me.Controls.Add(Me.btDesconexion)
        Me.Controls.Add(Me.lbListaAlumnos)
        Me.Controls.Add(Me.btConsultaDesconectado)
        Me.Controls.Add(Me.btConsulta)
        Me.Controls.Add(Me.btConsultaEscalar)
        Me.Controls.Add(Me.btInsercion)
        Me.Controls.Add(Me.btConexion)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btDesconexion As Button
    Friend WithEvents lbListaAlumnos As ListBox
    Friend WithEvents btConsultaDesconectado As Button
    Friend WithEvents btConsulta As Button
    Friend WithEvents btConsultaEscalar As Button
    Friend WithEvents btInsercion As Button
    Friend WithEvents btConexion As Button
End Class
