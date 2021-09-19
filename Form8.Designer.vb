<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.pbUno = New System.Windows.Forms.PictureBox()
        Me.pbDos = New System.Windows.Forms.PictureBox()
        Me.pbTres = New System.Windows.Forms.PictureBox()
        Me.btSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbDinero = New System.Windows.Forms.Label()
        Me.lbGanancias = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.lbDineroApostado = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pbUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbUno
        '
        Me.pbUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbUno.Location = New System.Drawing.Point(252, 139)
        Me.pbUno.Name = "pbUno"
        Me.pbUno.Size = New System.Drawing.Size(100, 100)
        Me.pbUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUno.TabIndex = 0
        Me.pbUno.TabStop = False
        '
        'pbDos
        '
        Me.pbDos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbDos.Location = New System.Drawing.Point(358, 139)
        Me.pbDos.Name = "pbDos"
        Me.pbDos.Size = New System.Drawing.Size(100, 100)
        Me.pbDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDos.TabIndex = 1
        Me.pbDos.TabStop = False
        '
        'pbTres
        '
        Me.pbTres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbTres.Location = New System.Drawing.Point(464, 139)
        Me.pbTres.Name = "pbTres"
        Me.pbTres.Size = New System.Drawing.Size(100, 100)
        Me.pbTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTres.TabIndex = 2
        Me.pbTres.TabStop = False
        '
        'btSpin
        '
        Me.btSpin.Location = New System.Drawing.Point(358, 257)
        Me.btSpin.Name = "btSpin"
        Me.btSpin.Size = New System.Drawing.Size(100, 50)
        Me.btSpin.TabIndex = 3
        Me.btSpin.Text = "SPIN $20"
        Me.btSpin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Location = New System.Drawing.Point(248, 45)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(57, 20)
        Me.lbInfo.TabIndex = 4
        Me.lbInfo.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "$200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$300"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "$500"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apuestas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(96, 22)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(65, 20)
        Me.lbNombre.TabIndex = 11
        Me.lbNombre.Text = "Nombre"
        '
        'lbDinero
        '
        Me.lbDinero.AutoSize = True
        Me.lbDinero.Location = New System.Drawing.Point(96, 59)
        Me.lbDinero.Name = "lbDinero"
        Me.lbDinero.Size = New System.Drawing.Size(56, 20)
        Me.lbDinero.TabIndex = 10
        Me.lbDinero.Text = "Dinero"
        '
        'lbGanancias
        '
        Me.lbGanancias.AutoSize = True
        Me.lbGanancias.Location = New System.Drawing.Point(96, 101)
        Me.lbGanancias.Name = "lbGanancias"
        Me.lbGanancias.Size = New System.Drawing.Size(56, 20)
        Me.lbGanancias.TabIndex = 13
        Me.lbGanancias.Text = "Dinero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ganancias"
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(347, 339)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(111, 56)
        Me.btGuardar.TabIndex = 14
        Me.btGuardar.Text = "GUARDAR"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'lbDineroApostado
        '
        Me.lbDineroApostado.AutoSize = True
        Me.lbDineroApostado.Location = New System.Drawing.Point(145, 139)
        Me.lbDineroApostado.Name = "lbDineroApostado"
        Me.lbDineroApostado.Size = New System.Drawing.Size(56, 20)
        Me.lbDineroApostado.TabIndex = 16
        Me.lbDineroApostado.Text = "Dinero"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Dinero apostado"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 489)
        Me.Controls.Add(Me.lbDineroApostado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.lbGanancias)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbDinero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.btSpin)
        Me.Controls.Add(Me.pbTres)
        Me.Controls.Add(Me.pbDos)
        Me.Controls.Add(Me.pbUno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form8"
        Me.Text = "Tragaperras"
        CType(Me.pbUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbUno As PictureBox
    Friend WithEvents pbDos As PictureBox
    Friend WithEvents pbTres As PictureBox
    Friend WithEvents btSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbDinero As Label
    Friend WithEvents lbGanancias As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btGuardar As Button
    Friend WithEvents lbDineroApostado As Label
    Friend WithEvents Label8 As Label
End Class
