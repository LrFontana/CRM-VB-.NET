<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentaItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentaItems))
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxProductos = New System.Windows.Forms.ComboBox()
        Me.ButtonCrearVentaItem = New System.Windows.Forms.Button()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxProducto = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBoxLimpiarLista = New System.Windows.Forms.PictureBox()
        Me.PanelMostrarClientes = New System.Windows.Forms.Panel()
        Me.DataGridViewVentaItem = New System.Windows.Forms.DataGridView()
        Me.PictureBoxBuscar = New System.Windows.Forms.PictureBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxVentaItems = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarClientes.SuspendLayout()
        CType(Me.DataGridViewVentaItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBoxVolver.Image = CType(resources.GetObject("PictureBoxVolver.Image"), System.Drawing.Image)
        Me.PictureBoxVolver.Location = New System.Drawing.Point(1204, 7)
        Me.PictureBoxVolver.Name = "PictureBoxVolver"
        Me.PictureBoxVolver.Size = New System.Drawing.Size(28, 27)
        Me.PictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVolver.TabIndex = 19
        Me.PictureBoxVolver.TabStop = False
        '
        'PictureBoxCerrar
        '
        Me.PictureBoxCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBoxCerrar.Image = CType(resources.GetObject("PictureBoxCerrar.Image"), System.Drawing.Image)
        Me.PictureBoxCerrar.Location = New System.Drawing.Point(1238, 7)
        Me.PictureBoxCerrar.Name = "PictureBoxCerrar"
        Me.PictureBoxCerrar.Size = New System.Drawing.Size(34, 27)
        Me.PictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCerrar.TabIndex = 15
        Me.PictureBoxCerrar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumericUpDownCantidad)
        Me.Panel2.Controls.Add(Me.ComboBoxProductos)
        Me.Panel2.Controls.Add(Me.ButtonCrearVentaItem)
        Me.Panel2.Controls.Add(Me.TextBoxCantidad)
        Me.Panel2.Controls.Add(Me.TextBoxProducto)
        Me.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.Panel2.Controls.Add(Me.ButtonActualizar)
        Me.Panel2.Controls.Add(Me.ButtonAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 521)
        Me.Panel2.TabIndex = 18
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(143, 228)
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(234, 23)
        Me.NumericUpDownCantidad.TabIndex = 29
        '
        'ComboBoxProductos
        '
        Me.ComboBoxProductos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProductos.FormattingEnabled = True
        Me.ComboBoxProductos.Location = New System.Drawing.Point(143, 139)
        Me.ComboBoxProductos.Name = "ComboBoxProductos"
        Me.ComboBoxProductos.Size = New System.Drawing.Size(234, 28)
        Me.ComboBoxProductos.TabIndex = 28
        '
        'ButtonCrearVentaItem
        '
        Me.ButtonCrearVentaItem.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCrearVentaItem.FlatAppearance.BorderSize = 0
        Me.ButtonCrearVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCrearVentaItem.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCrearVentaItem.Location = New System.Drawing.Point(421, 456)
        Me.ButtonCrearVentaItem.Name = "ButtonCrearVentaItem"
        Me.ButtonCrearVentaItem.Size = New System.Drawing.Size(177, 44)
        Me.ButtonCrearVentaItem.TabIndex = 26
        Me.ButtonCrearVentaItem.Text = "Crear Venta"
        Me.ButtonCrearVentaItem.UseVisualStyleBackColor = False
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCantidad.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidad.Location = New System.Drawing.Point(34, 228)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxCantidad.TabIndex = 22
        Me.TextBoxCantidad.Text = "Cantidad :"
        '
        'TextBoxProducto
        '
        Me.TextBoxProducto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxProducto.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProducto.Location = New System.Drawing.Point(34, 147)
        Me.TextBoxProducto.Name = "TextBoxProducto"
        Me.TextBoxProducto.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxProducto.TabIndex = 21
        Me.TextBoxProducto.Text = "Producto :"
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEliminar.FlatAppearance.BorderSize = 0
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(291, 456)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(124, 44)
        Me.ButtonEliminar.TabIndex = 13
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonActualizar.FlatAppearance.BorderSize = 0
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizar.Location = New System.Drawing.Point(132, 456)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(133, 44)
        Me.ButtonActualizar.TabIndex = 12
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAgregar.FlatAppearance.BorderSize = 0
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonAgregar.Location = New System.Drawing.Point(4, 456)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(110, 44)
        Me.ButtonAgregar.TabIndex = 11
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxLimpiarLista)
        Me.Panel1.Controls.Add(Me.PanelMostrarClientes)
        Me.Panel1.Controls.Add(Me.PictureBoxBuscar)
        Me.Panel1.Controls.Add(Me.TextBoxBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(619, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 521)
        Me.Panel1.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(18, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 26)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "Buscar :"
        '
        'PictureBoxLimpiarLista
        '
        Me.PictureBoxLimpiarLista.Image = CType(resources.GetObject("PictureBoxLimpiarLista.Image"), System.Drawing.Image)
        Me.PictureBoxLimpiarLista.Location = New System.Drawing.Point(585, 38)
        Me.PictureBoxLimpiarLista.Name = "PictureBoxLimpiarLista"
        Me.PictureBoxLimpiarLista.Size = New System.Drawing.Size(34, 33)
        Me.PictureBoxLimpiarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLimpiarLista.TabIndex = 3
        Me.PictureBoxLimpiarLista.TabStop = False
        '
        'PanelMostrarClientes
        '
        Me.PanelMostrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.PanelMostrarClientes.Controls.Add(Me.DataGridViewVentaItem)
        Me.PanelMostrarClientes.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMostrarClientes.Location = New System.Drawing.Point(0, 77)
        Me.PanelMostrarClientes.Name = "PanelMostrarClientes"
        Me.PanelMostrarClientes.Size = New System.Drawing.Size(684, 444)
        Me.PanelMostrarClientes.TabIndex = 2
        '
        'DataGridViewVentaItem
        '
        Me.DataGridViewVentaItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentaItem.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewVentaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentaItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVentaItem.GridColor = System.Drawing.Color.Black
        Me.DataGridViewVentaItem.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewVentaItem.Name = "DataGridViewVentaItem"
        Me.DataGridViewVentaItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewVentaItem.Size = New System.Drawing.Size(684, 444)
        Me.DataGridViewVentaItem.TabIndex = 0
        '
        'PictureBoxBuscar
        '
        Me.PictureBoxBuscar.Image = CType(resources.GetObject("PictureBoxBuscar.Image"), System.Drawing.Image)
        Me.PictureBoxBuscar.Location = New System.Drawing.Point(535, 38)
        Me.PictureBoxBuscar.Name = "PictureBoxBuscar"
        Me.PictureBoxBuscar.Size = New System.Drawing.Size(34, 33)
        Me.PictureBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxBuscar.TabIndex = 1
        Me.PictureBoxBuscar.TabStop = False
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(115, 38)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(384, 33)
        Me.TextBoxBuscar.TabIndex = 0
        Me.TextBoxBuscar.Text = "Por favor ingrese un id de venta"
        '
        'TextBoxVentaItems
        '
        Me.TextBoxVentaItems.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TextBoxVentaItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxVentaItems.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVentaItems.ForeColor = System.Drawing.Color.Maroon
        Me.TextBoxVentaItems.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxVentaItems.Name = "TextBoxVentaItems"
        Me.TextBoxVentaItems.Size = New System.Drawing.Size(1284, 40)
        Me.TextBoxVentaItems.TabIndex = 16
        Me.TextBoxVentaItems.Text = "Detalle Venta"
        Me.TextBoxVentaItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormVentaItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxVentaItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVentaItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormVentaItems"
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarClientes.ResumeLayout(False)
        CType(Me.DataGridViewVentaItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxVolver As PictureBox
    Friend WithEvents PictureBoxCerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBoxLimpiarLista As PictureBox
    Friend WithEvents PanelMostrarClientes As Panel
    Friend WithEvents DataGridViewVentaItem As DataGridView
    Friend WithEvents PictureBoxBuscar As PictureBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents TextBoxVentaItems As TextBox
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents TextBoxProducto As TextBox
    Friend WithEvents ButtonCrearVentaItem As Button
    Friend WithEvents ComboBoxProductos As ComboBox
    Friend WithEvents NumericUpDownCantidad As NumericUpDown
End Class
