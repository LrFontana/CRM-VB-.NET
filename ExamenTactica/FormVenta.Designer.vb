<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxIdVenta = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBoxLimpiarLista = New System.Windows.Forms.PictureBox()
        Me.PanelMostrarClientes = New System.Windows.Forms.Panel()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.PictureBoxBuscar = New System.Windows.Forms.PictureBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxVentas = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarClientes.SuspendLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.DarkGoldenrod
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
        Me.PictureBoxCerrar.BackColor = System.Drawing.Color.DarkGoldenrod
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
        Me.Panel2.Controls.Add(Me.TextBoxIdVenta)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.ComboBoxCliente)
        Me.Panel2.Controls.Add(Me.DateTimePickerFecha)
        Me.Panel2.Controls.Add(Me.TextBoxFecha)
        Me.Panel2.Controls.Add(Me.TextBoxNombre)
        Me.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.Panel2.Controls.Add(Me.ButtonActualizar)
        Me.Panel2.Controls.Add(Me.ButtonAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 521)
        Me.Panel2.TabIndex = 18
        '
        'TextBoxIdVenta
        '
        Me.TextBoxIdVenta.Location = New System.Drawing.Point(169, 124)
        Me.TextBoxIdVenta.Name = "TextBoxIdVenta"
        Me.TextBoxIdVenta.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxIdVenta.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(60, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(92, 20)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "ID Venta  :"
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(169, 200)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(234, 21)
        Me.ComboBoxCliente.TabIndex = 21
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(169, 289)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePickerFecha.TabIndex = 20
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFecha.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFecha.Location = New System.Drawing.Point(60, 289)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxFecha.TabIndex = 15
        Me.TextBoxFecha.Text = "Fecha :"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(60, 202)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxNombre.TabIndex = 14
        Me.TextBoxNombre.Text = "Cliente :"
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEliminar.FlatAppearance.BorderSize = 0
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(410, 457)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(128, 44)
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
        Me.ButtonActualizar.Location = New System.Drawing.Point(225, 457)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(137, 44)
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
        Me.ButtonAgregar.Location = New System.Drawing.Point(60, 457)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(114, 44)
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
        Me.Panel1.Location = New System.Drawing.Point(600, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 521)
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
        Me.PictureBoxLimpiarLista.Location = New System.Drawing.Point(513, 38)
        Me.PictureBoxLimpiarLista.Name = "PictureBoxLimpiarLista"
        Me.PictureBoxLimpiarLista.Size = New System.Drawing.Size(34, 33)
        Me.PictureBoxLimpiarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLimpiarLista.TabIndex = 3
        Me.PictureBoxLimpiarLista.TabStop = False
        '
        'PanelMostrarClientes
        '
        Me.PanelMostrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.PanelMostrarClientes.Controls.Add(Me.DataGridViewVentas)
        Me.PanelMostrarClientes.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMostrarClientes.Location = New System.Drawing.Point(0, 77)
        Me.PanelMostrarClientes.Name = "PanelMostrarClientes"
        Me.PanelMostrarClientes.Size = New System.Drawing.Size(684, 444)
        Me.PanelMostrarClientes.TabIndex = 2
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVentas.GridColor = System.Drawing.Color.Black
        Me.DataGridViewVentas.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewVentas.Size = New System.Drawing.Size(684, 444)
        Me.DataGridViewVentas.TabIndex = 0
        '
        'PictureBoxBuscar
        '
        Me.PictureBoxBuscar.Image = CType(resources.GetObject("PictureBoxBuscar.Image"), System.Drawing.Image)
        Me.PictureBoxBuscar.Location = New System.Drawing.Point(463, 38)
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
        Me.TextBoxBuscar.Size = New System.Drawing.Size(312, 33)
        Me.TextBoxBuscar.TabIndex = 0
        Me.TextBoxBuscar.Text = "por favor ingrese un cliente"
        '
        'TextBoxVentas
        '
        Me.TextBoxVentas.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBoxVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxVentas.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVentas.ForeColor = System.Drawing.Color.Maroon
        Me.TextBoxVentas.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxVentas.Name = "TextBoxVentas"
        Me.TextBoxVentas.Size = New System.Drawing.Size(1284, 40)
        Me.TextBoxVentas.TabIndex = 16
        Me.TextBoxVentas.Text = "Ventas"
        Me.TextBoxVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormVenta"
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarClientes.ResumeLayout(False)
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxVolver As PictureBox
    Friend WithEvents PictureBoxCerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBoxLimpiarLista As PictureBox
    Friend WithEvents PanelMostrarClientes As Panel
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents PictureBoxBuscar As PictureBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents TextBoxVentas As TextBox
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBoxIdVenta As TextBox
End Class
