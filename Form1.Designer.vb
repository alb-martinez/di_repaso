<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btTablero = New System.Windows.Forms.Button()
        Me.btMensajes = New System.Windows.Forms.Button()
        Me.btListBox = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btMttoAccess = New System.Windows.Forms.Button()
        Me.btTragaperras = New System.Windows.Forms.Button()
        Me.btHundir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btTablero
        '
        Me.btTablero.Location = New System.Drawing.Point(13, 13)
        Me.btTablero.Name = "btTablero"
        Me.btTablero.Size = New System.Drawing.Size(114, 53)
        Me.btTablero.TabIndex = 0
        Me.btTablero.Text = "CREAR TABLERO"
        Me.btTablero.UseVisualStyleBackColor = True
        '
        'btMensajes
        '
        Me.btMensajes.Location = New System.Drawing.Point(13, 72)
        Me.btMensajes.Name = "btMensajes"
        Me.btMensajes.Size = New System.Drawing.Size(114, 53)
        Me.btMensajes.TabIndex = 1
        Me.btMensajes.Text = "CREAR MENSAJES"
        Me.btMensajes.UseVisualStyleBackColor = True
        '
        'btListBox
        '
        Me.btListBox.Location = New System.Drawing.Point(13, 131)
        Me.btListBox.Name = "btListBox"
        Me.btListBox.Size = New System.Drawing.Size(114, 53)
        Me.btListBox.TabIndex = 2
        Me.btListBox.Text = "LISTBOX"
        Me.btListBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 53)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "MTTOBD MYSQL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btMttoAccess
        '
        Me.btMttoAccess.Location = New System.Drawing.Point(13, 249)
        Me.btMttoAccess.Name = "btMttoAccess"
        Me.btMttoAccess.Size = New System.Drawing.Size(114, 53)
        Me.btMttoAccess.TabIndex = 4
        Me.btMttoAccess.Text = "MTTOBD ACCESS"
        Me.btMttoAccess.UseVisualStyleBackColor = True
        '
        'btTragaperras
        '
        Me.btTragaperras.Location = New System.Drawing.Point(13, 308)
        Me.btTragaperras.Name = "btTragaperras"
        Me.btTragaperras.Size = New System.Drawing.Size(114, 53)
        Me.btTragaperras.TabIndex = 5
        Me.btTragaperras.Text = "TRAGAPERRAS"
        Me.btTragaperras.UseVisualStyleBackColor = True
        '
        'btHundir
        '
        Me.btHundir.Location = New System.Drawing.Point(13, 367)
        Me.btHundir.Name = "btHundir"
        Me.btHundir.Size = New System.Drawing.Size(114, 53)
        Me.btHundir.TabIndex = 6
        Me.btHundir.Text = "BARQUITOS"
        Me.btHundir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btHundir)
        Me.Controls.Add(Me.btTragaperras)
        Me.Controls.Add(Me.btMttoAccess)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btListBox)
        Me.Controls.Add(Me.btMensajes)
        Me.Controls.Add(Me.btTablero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btTablero As Button
    Friend WithEvents btMensajes As Button
    Friend WithEvents btListBox As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btMttoAccess As Button
    Friend WithEvents btTragaperras As Button
    Friend WithEvents btHundir As Button
End Class
