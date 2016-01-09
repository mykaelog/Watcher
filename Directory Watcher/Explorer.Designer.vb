<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorer
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
        Me.arbol_directorios = New System.Windows.Forms.TreeView()
        Me.nombre_ruta = New System.Windows.Forms.TextBox()
        Me.aceptar_ruta = New System.Windows.Forms.Button()
        Me.cancelar_ruta = New System.Windows.Forms.Button()
        Me.label_nombre_ruta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'arbol_directorios
        '
        Me.arbol_directorios.Location = New System.Drawing.Point(12, 12)
        Me.arbol_directorios.Name = "arbol_directorios"
        Me.arbol_directorios.Size = New System.Drawing.Size(544, 183)
        Me.arbol_directorios.TabIndex = 0
        '
        'nombre_ruta
        '
        Me.nombre_ruta.Location = New System.Drawing.Point(104, 223)
        Me.nombre_ruta.Name = "nombre_ruta"
        Me.nombre_ruta.Size = New System.Drawing.Size(290, 20)
        Me.nombre_ruta.TabIndex = 1
        '
        'aceptar_ruta
        '
        Me.aceptar_ruta.Location = New System.Drawing.Point(400, 221)
        Me.aceptar_ruta.Name = "aceptar_ruta"
        Me.aceptar_ruta.Size = New System.Drawing.Size(76, 23)
        Me.aceptar_ruta.TabIndex = 2
        Me.aceptar_ruta.Text = "Aceptar"
        Me.aceptar_ruta.UseVisualStyleBackColor = True
        '
        'cancelar_ruta
        '
        Me.cancelar_ruta.Location = New System.Drawing.Point(482, 221)
        Me.cancelar_ruta.Name = "cancelar_ruta"
        Me.cancelar_ruta.Size = New System.Drawing.Size(74, 23)
        Me.cancelar_ruta.TabIndex = 3
        Me.cancelar_ruta.Text = "Cancelar"
        Me.cancelar_ruta.UseVisualStyleBackColor = True
        '
        'label_nombre_ruta
        '
        Me.label_nombre_ruta.AutoSize = True
        Me.label_nombre_ruta.Location = New System.Drawing.Point(9, 226)
        Me.label_nombre_ruta.Name = "label_nombre_ruta"
        Me.label_nombre_ruta.Size = New System.Drawing.Size(76, 13)
        Me.label_nombre_ruta.TabIndex = 4
        Me.label_nombre_ruta.Text = "Nombre Ruta :"
        Me.label_nombre_ruta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Explorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 272)
        Me.Controls.Add(Me.label_nombre_ruta)
        Me.Controls.Add(Me.cancelar_ruta)
        Me.Controls.Add(Me.aceptar_ruta)
        Me.Controls.Add(Me.nombre_ruta)
        Me.Controls.Add(Me.arbol_directorios)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Explorer"
        Me.Text = "Explorer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents arbol_directorios As System.Windows.Forms.TreeView
    Friend WithEvents nombre_ruta As System.Windows.Forms.TextBox
    Friend WithEvents aceptar_ruta As System.Windows.Forms.Button
    Friend WithEvents cancelar_ruta As System.Windows.Forms.Button
    Friend WithEvents label_nombre_ruta As System.Windows.Forms.Label
End Class
