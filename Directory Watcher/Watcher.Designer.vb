<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Watcher
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
        Me.explore_button = New System.Windows.Forms.Button()
        Me.monitorizar = New System.Windows.Forms.Button()
        Me.label_nombre_ruta = New System.Windows.Forms.Label()
        Me.nombre_ruta = New System.Windows.Forms.TextBox()
        Me.actividad_directorio = New System.Windows.Forms.TextBox()
        Me.label_actividad_directorio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'explore_button
        '
        Me.explore_button.Location = New System.Drawing.Point(405, 34)
        Me.explore_button.Name = "explore_button"
        Me.explore_button.Size = New System.Drawing.Size(107, 23)
        Me.explore_button.TabIndex = 0
        Me.explore_button.Text = "Explorar"
        Me.explore_button.UseVisualStyleBackColor = True
        '
        'monitorizar
        '
        Me.monitorizar.Location = New System.Drawing.Point(518, 34)
        Me.monitorizar.Name = "monitorizar"
        Me.monitorizar.Size = New System.Drawing.Size(98, 23)
        Me.monitorizar.TabIndex = 1
        Me.monitorizar.Text = "Monitorizar"
        Me.monitorizar.UseVisualStyleBackColor = True
        '
        'label_nombre_ruta
        '
        Me.label_nombre_ruta.AutoSize = True
        Me.label_nombre_ruta.Location = New System.Drawing.Point(26, 40)
        Me.label_nombre_ruta.Name = "label_nombre_ruta"
        Me.label_nombre_ruta.Size = New System.Drawing.Size(76, 13)
        Me.label_nombre_ruta.TabIndex = 2
        Me.label_nombre_ruta.Text = "Nombre Ruta :"
        '
        'nombre_ruta
        '
        Me.nombre_ruta.Location = New System.Drawing.Point(108, 37)
        Me.nombre_ruta.Name = "nombre_ruta"
        Me.nombre_ruta.ReadOnly = True
        Me.nombre_ruta.Size = New System.Drawing.Size(278, 20)
        Me.nombre_ruta.TabIndex = 3
        '
        'actividad_directorio
        '
        Me.actividad_directorio.Location = New System.Drawing.Point(29, 116)
        Me.actividad_directorio.Multiline = True
        Me.actividad_directorio.Name = "actividad_directorio"
        Me.actividad_directorio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.actividad_directorio.Size = New System.Drawing.Size(587, 238)
        Me.actividad_directorio.TabIndex = 4
        '
        'label_actividad_directorio
        '
        Me.label_actividad_directorio.AutoSize = True
        Me.label_actividad_directorio.Location = New System.Drawing.Point(26, 88)
        Me.label_actividad_directorio.Name = "label_actividad_directorio"
        Me.label_actividad_directorio.Size = New System.Drawing.Size(120, 13)
        Me.label_actividad_directorio.TabIndex = 5
        Me.label_actividad_directorio.Text = "Actividad del directorio :"
        '
        'Watcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 396)
        Me.Controls.Add(Me.label_actividad_directorio)
        Me.Controls.Add(Me.actividad_directorio)
        Me.Controls.Add(Me.nombre_ruta)
        Me.Controls.Add(Me.label_nombre_ruta)
        Me.Controls.Add(Me.monitorizar)
        Me.Controls.Add(Me.explore_button)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Watcher"
        Me.Text = "Monitorización"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents explore_button As System.Windows.Forms.Button
    Friend WithEvents monitorizar As System.Windows.Forms.Button
    Friend WithEvents label_nombre_ruta As System.Windows.Forms.Label
    Friend WithEvents nombre_ruta As System.Windows.Forms.TextBox
    Friend WithEvents actividad_directorio As System.Windows.Forms.TextBox
    Friend WithEvents label_actividad_directorio As System.Windows.Forms.Label

End Class
