<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteProductos))
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonGenerarReporte = New System.Windows.Forms.Button()
        Me.TextBoxIngresarIdProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxIdProducto = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBoxVolver.Image = CType(resources.GetObject("PictureBoxVolver.Image"), System.Drawing.Image)
        Me.PictureBoxVolver.Location = New System.Drawing.Point(1194, 8)
        Me.PictureBoxVolver.Name = "PictureBoxVolver"
        Me.PictureBoxVolver.Size = New System.Drawing.Size(28, 27)
        Me.PictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVolver.TabIndex = 17
        Me.PictureBoxVolver.TabStop = False
        '
        'PictureBoxCerrar
        '
        Me.PictureBoxCerrar.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBoxCerrar.Image = CType(resources.GetObject("PictureBoxCerrar.Image"), System.Drawing.Image)
        Me.PictureBoxCerrar.Location = New System.Drawing.Point(1228, 9)
        Me.PictureBoxCerrar.Name = "PictureBoxCerrar"
        Me.PictureBoxCerrar.Size = New System.Drawing.Size(34, 27)
        Me.PictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCerrar.TabIndex = 15
        Me.PictureBoxCerrar.TabStop = False
        '
        'TextBoxProductos
        '
        Me.TextBoxProductos.BackColor = System.Drawing.Color.ForestGreen
        Me.TextBoxProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxProductos.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductos.ForeColor = System.Drawing.Color.Maroon
        Me.TextBoxProductos.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxProductos.Name = "TextBoxProductos"
        Me.TextBoxProductos.Size = New System.Drawing.Size(1284, 40)
        Me.TextBoxProductos.TabIndex = 16
        Me.TextBoxProductos.Text = "Reporte Productos"
        Me.TextBoxProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonGenerarReporte)
        Me.Panel1.Controls.Add(Me.TextBoxIngresarIdProducto)
        Me.Panel1.Controls.Add(Me.TextBoxIdProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 520)
        Me.Panel1.TabIndex = 18
        '
        'ButtonGenerarReporte
        '
        Me.ButtonGenerarReporte.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGenerarReporte.FlatAppearance.BorderSize = 0
        Me.ButtonGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerarReporte.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerarReporte.Location = New System.Drawing.Point(523, 394)
        Me.ButtonGenerarReporte.Name = "ButtonGenerarReporte"
        Me.ButtonGenerarReporte.Size = New System.Drawing.Size(272, 44)
        Me.ButtonGenerarReporte.TabIndex = 26
        Me.ButtonGenerarReporte.Text = "Generar Reporte"
        Me.ButtonGenerarReporte.UseVisualStyleBackColor = False
        '
        'TextBoxIngresarIdProducto
        '
        Me.TextBoxIngresarIdProducto.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarIdProducto.Location = New System.Drawing.Point(540, 132)
        Me.TextBoxIngresarIdProducto.Name = "TextBoxIngresarIdProducto"
        Me.TextBoxIngresarIdProducto.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarIdProducto.TabIndex = 25
        '
        'TextBoxIdProducto
        '
        Me.TextBoxIdProducto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIdProducto.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdProducto.Location = New System.Drawing.Point(358, 133)
        Me.TextBoxIdProducto.Name = "TextBoxIdProducto"
        Me.TextBoxIdProducto.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxIdProducto.TabIndex = 24
        Me.TextBoxIdProducto.Text = "ID de Producto :"
        '
        'FormReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Productos"
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxVolver As PictureBox
    Friend WithEvents PictureBoxCerrar As PictureBox
    Friend WithEvents TextBoxProductos As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonGenerarReporte As Button
    Friend WithEvents TextBoxIngresarIdProducto As TextBox
    Friend WithEvents TextBoxIdProducto As TextBox
End Class
