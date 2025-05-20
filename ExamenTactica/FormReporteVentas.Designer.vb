<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteVentas))
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonGenerarReporte = New System.Windows.Forms.Button()
        Me.TextBoxIngresarIdVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxIdVenta = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBoxVolver.Image = CType(resources.GetObject("PictureBoxVolver.Image"), System.Drawing.Image)
        Me.PictureBoxVolver.Location = New System.Drawing.Point(1204, 6)
        Me.PictureBoxVolver.Name = "PictureBoxVolver"
        Me.PictureBoxVolver.Size = New System.Drawing.Size(28, 27)
        Me.PictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVolver.TabIndex = 20
        Me.PictureBoxVolver.TabStop = False
        '
        'PictureBoxCerrar
        '
        Me.PictureBoxCerrar.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBoxCerrar.Image = CType(resources.GetObject("PictureBoxCerrar.Image"), System.Drawing.Image)
        Me.PictureBoxCerrar.Location = New System.Drawing.Point(1238, 7)
        Me.PictureBoxCerrar.Name = "PictureBoxCerrar"
        Me.PictureBoxCerrar.Size = New System.Drawing.Size(34, 27)
        Me.PictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCerrar.TabIndex = 18
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
        Me.TextBoxProductos.TabIndex = 19
        Me.TextBoxProductos.Text = "Reporte Ventas"
        Me.TextBoxProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonGenerarReporte)
        Me.Panel1.Controls.Add(Me.TextBoxIngresarIdVenta)
        Me.Panel1.Controls.Add(Me.TextBoxIdVenta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 522)
        Me.Panel1.TabIndex = 21
        '
        'ButtonGenerarReporte
        '
        Me.ButtonGenerarReporte.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGenerarReporte.FlatAppearance.BorderSize = 0
        Me.ButtonGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerarReporte.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerarReporte.Location = New System.Drawing.Point(538, 410)
        Me.ButtonGenerarReporte.Name = "ButtonGenerarReporte"
        Me.ButtonGenerarReporte.Size = New System.Drawing.Size(272, 44)
        Me.ButtonGenerarReporte.TabIndex = 20
        Me.ButtonGenerarReporte.Text = "Generar Reporte"
        Me.ButtonGenerarReporte.UseVisualStyleBackColor = False
        '
        'TextBoxIngresarIdVenta
        '
        Me.TextBoxIngresarIdVenta.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarIdVenta.Location = New System.Drawing.Point(559, 159)
        Me.TextBoxIngresarIdVenta.Name = "TextBoxIngresarIdVenta"
        Me.TextBoxIngresarIdVenta.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarIdVenta.TabIndex = 19
        '
        'TextBoxIdVenta
        '
        Me.TextBoxIdVenta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIdVenta.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdVenta.Location = New System.Drawing.Point(400, 160)
        Me.TextBoxIdVenta.Name = "TextBoxIdVenta"
        Me.TextBoxIdVenta.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxIdVenta.TabIndex = 18
        Me.TextBoxIdVenta.Text = "ID de Venta :"
        '
        'FormReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Ventas"
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
    Friend WithEvents TextBoxIngresarIdVenta As TextBox
    Friend WithEvents TextBoxIdVenta As TextBox
    Friend WithEvents ButtonGenerarReporte As Button
End Class
