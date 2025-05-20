<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProducto))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxIngresarPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxIngresarCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxIngresarNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBoxLimpiarLista = New System.Windows.Forms.PictureBox()
        Me.PanelMostrarClientes = New System.Windows.Forms.Panel()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.PictureBoxBuscar = New System.Windows.Forms.PictureBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxProductos = New System.Windows.Forms.TextBox()
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarClientes.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxIngresarPrecio)
        Me.Panel2.Controls.Add(Me.TextBoxIngresarCategoria)
        Me.Panel2.Controls.Add(Me.TextBoxIngresarNombre)
        Me.Panel2.Controls.Add(Me.TextBoxPrecio)
        Me.Panel2.Controls.Add(Me.TextBoxCategoria)
        Me.Panel2.Controls.Add(Me.TextBoxNombre)
        Me.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.Panel2.Controls.Add(Me.ButtonActualizar)
        Me.Panel2.Controls.Add(Me.ButtonAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 521)
        Me.Panel2.TabIndex = 13
        '
        'TextBoxIngresarPrecio
        '
        Me.TextBoxIngresarPrecio.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarPrecio.Location = New System.Drawing.Point(169, 265)
        Me.TextBoxIngresarPrecio.Name = "TextBoxIngresarPrecio"
        Me.TextBoxIngresarPrecio.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarPrecio.TabIndex = 19
        '
        'TextBoxIngresarCategoria
        '
        Me.TextBoxIngresarCategoria.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarCategoria.Location = New System.Drawing.Point(169, 184)
        Me.TextBoxIngresarCategoria.Name = "TextBoxIngresarCategoria"
        Me.TextBoxIngresarCategoria.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarCategoria.TabIndex = 18
        '
        'TextBoxIngresarNombre
        '
        Me.TextBoxIngresarNombre.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarNombre.Location = New System.Drawing.Point(169, 97)
        Me.TextBoxIngresarNombre.Name = "TextBoxIngresarNombre"
        Me.TextBoxIngresarNombre.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarNombre.TabIndex = 17
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(60, 261)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxPrecio.TabIndex = 16
        Me.TextBoxPrecio.Text = "Precio :"
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCategoria.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCategoria.Location = New System.Drawing.Point(60, 180)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxCategoria.TabIndex = 15
        Me.TextBoxCategoria.Text = "Categoria :"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(60, 93)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxNombre.TabIndex = 14
        Me.TextBoxNombre.Text = "Nombre :"
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
        Me.Panel1.TabIndex = 12
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
        Me.PictureBoxLimpiarLista.Location = New System.Drawing.Point(543, 38)
        Me.PictureBoxLimpiarLista.Name = "PictureBoxLimpiarLista"
        Me.PictureBoxLimpiarLista.Size = New System.Drawing.Size(34, 33)
        Me.PictureBoxLimpiarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLimpiarLista.TabIndex = 3
        Me.PictureBoxLimpiarLista.TabStop = False
        '
        'PanelMostrarClientes
        '
        Me.PanelMostrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.PanelMostrarClientes.Controls.Add(Me.DataGridViewProductos)
        Me.PanelMostrarClientes.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMostrarClientes.Location = New System.Drawing.Point(0, 77)
        Me.PanelMostrarClientes.Name = "PanelMostrarClientes"
        Me.PanelMostrarClientes.Size = New System.Drawing.Size(684, 444)
        Me.PanelMostrarClientes.TabIndex = 2
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewProductos.GridColor = System.Drawing.Color.Black
        Me.DataGridViewProductos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewProductos.Size = New System.Drawing.Size(684, 444)
        Me.DataGridViewProductos.TabIndex = 0
        '
        'PictureBoxBuscar
        '
        Me.PictureBoxBuscar.Image = CType(resources.GetObject("PictureBoxBuscar.Image"), System.Drawing.Image)
        Me.PictureBoxBuscar.Location = New System.Drawing.Point(493, 38)
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
        Me.TextBoxBuscar.Size = New System.Drawing.Size(337, 33)
        Me.TextBoxBuscar.TabIndex = 0
        Me.TextBoxBuscar.Text = "Por favor ingrese un nombre"
        '
        'TextBoxProductos
        '
        Me.TextBoxProductos.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBoxProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxProductos.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProductos.ForeColor = System.Drawing.Color.Maroon
        Me.TextBoxProductos.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxProductos.Name = "TextBoxProductos"
        Me.TextBoxProductos.Size = New System.Drawing.Size(1284, 40)
        Me.TextBoxProductos.TabIndex = 11
        Me.TextBoxProductos.Text = "Productos"
        Me.TextBoxProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.PictureBoxVolver.Image = CType(resources.GetObject("PictureBoxVolver.Image"), System.Drawing.Image)
        Me.PictureBoxVolver.Location = New System.Drawing.Point(1204, 7)
        Me.PictureBoxVolver.Name = "PictureBoxVolver"
        Me.PictureBoxVolver.Size = New System.Drawing.Size(28, 27)
        Me.PictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVolver.TabIndex = 14
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
        Me.PictureBoxCerrar.TabIndex = 10
        Me.PictureBoxCerrar.TabStop = False
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarClientes.ResumeLayout(False)
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxVolver As PictureBox
    Friend WithEvents PictureBoxCerrar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxIngresarPrecio As TextBox
    Friend WithEvents TextBoxIngresarCategoria As TextBox
    Friend WithEvents TextBoxIngresarNombre As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBoxLimpiarLista As PictureBox
    Friend WithEvents PanelMostrarClientes As Panel
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents PictureBoxBuscar As PictureBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents TextBoxProductos As TextBox
End Class
