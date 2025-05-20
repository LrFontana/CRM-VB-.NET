<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBoxClientes = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBoxLimpiarLista = New System.Windows.Forms.PictureBox()
        Me.PanelMostrarClientes = New System.Windows.Forms.Panel()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.PictureBoxBuscar = New System.Windows.Forms.PictureBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxIngresarCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxIngresarTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxIngresarNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.PictureBoxCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVolver = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMostrarClientes.SuspendLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBoxClientes
        '
        Me.TextBoxClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TextBoxClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxClientes.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClientes.ForeColor = System.Drawing.Color.Maroon
        Me.TextBoxClientes.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxClientes.Name = "TextBoxClientes"
        Me.TextBoxClientes.Size = New System.Drawing.Size(1284, 40)
        Me.TextBoxClientes.TabIndex = 2
        Me.TextBoxClientes.Text = "Clientes"
        Me.TextBoxClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Panel1.TabIndex = 3
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
        Me.PictureBoxLimpiarLista.Location = New System.Drawing.Point(585, 37)
        Me.PictureBoxLimpiarLista.Name = "PictureBoxLimpiarLista"
        Me.PictureBoxLimpiarLista.Size = New System.Drawing.Size(34, 33)
        Me.PictureBoxLimpiarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLimpiarLista.TabIndex = 3
        Me.PictureBoxLimpiarLista.TabStop = False
        '
        'PanelMostrarClientes
        '
        Me.PanelMostrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.PanelMostrarClientes.Controls.Add(Me.DataGridViewClientes)
        Me.PanelMostrarClientes.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMostrarClientes.Location = New System.Drawing.Point(0, 77)
        Me.PanelMostrarClientes.Name = "PanelMostrarClientes"
        Me.PanelMostrarClientes.Size = New System.Drawing.Size(684, 444)
        Me.PanelMostrarClientes.TabIndex = 2
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClientes.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewClientes.GridColor = System.Drawing.Color.Black
        Me.DataGridViewClientes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewClientes.Size = New System.Drawing.Size(684, 444)
        Me.DataGridViewClientes.TabIndex = 0
        '
        'PictureBoxBuscar
        '
        Me.PictureBoxBuscar.Image = CType(resources.GetObject("PictureBoxBuscar.Image"), System.Drawing.Image)
        Me.PictureBoxBuscar.Location = New System.Drawing.Point(535, 37)
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
        Me.TextBoxBuscar.Size = New System.Drawing.Size(378, 33)
        Me.TextBoxBuscar.TabIndex = 0
        Me.TextBoxBuscar.Text = "Por favor ingrese un nombre"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxIngresarCorreo)
        Me.Panel2.Controls.Add(Me.TextBoxIngresarTelefono)
        Me.Panel2.Controls.Add(Me.TextBoxIngresarNombre)
        Me.Panel2.Controls.Add(Me.TextBoxCorreo)
        Me.Panel2.Controls.Add(Me.TextBoxTelefono)
        Me.Panel2.Controls.Add(Me.TextBoxNombre)
        Me.Panel2.Controls.Add(Me.ButtonEliminar)
        Me.Panel2.Controls.Add(Me.ButtonActualizar)
        Me.Panel2.Controls.Add(Me.ButtonAgregar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(602, 521)
        Me.Panel2.TabIndex = 8
        '
        'TextBoxIngresarCorreo
        '
        Me.TextBoxIngresarCorreo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarCorreo.Location = New System.Drawing.Point(169, 265)
        Me.TextBoxIngresarCorreo.Name = "TextBoxIngresarCorreo"
        Me.TextBoxIngresarCorreo.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarCorreo.TabIndex = 19
        '
        'TextBoxIngresarTelefono
        '
        Me.TextBoxIngresarTelefono.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarTelefono.Location = New System.Drawing.Point(169, 184)
        Me.TextBoxIngresarTelefono.Name = "TextBoxIngresarTelefono"
        Me.TextBoxIngresarTelefono.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarTelefono.TabIndex = 18
        '
        'TextBoxIngresarNombre
        '
        Me.TextBoxIngresarNombre.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIngresarNombre.Location = New System.Drawing.Point(169, 97)
        Me.TextBoxIngresarNombre.Name = "TextBoxIngresarNombre"
        Me.TextBoxIngresarNombre.Size = New System.Drawing.Size(234, 23)
        Me.TextBoxIngresarNombre.TabIndex = 17
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(60, 261)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxCorreo.TabIndex = 16
        Me.TextBoxCorreo.Text = "Correo :"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(60, 180)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxTelefono.TabIndex = 15
        Me.TextBoxTelefono.Text = "Telefono :"
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
        'PictureBoxCerrar
        '
        Me.PictureBoxCerrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBoxCerrar.Image = CType(resources.GetObject("PictureBoxCerrar.Image"), System.Drawing.Image)
        Me.PictureBoxCerrar.Location = New System.Drawing.Point(1238, 7)
        Me.PictureBoxCerrar.Name = "PictureBoxCerrar"
        Me.PictureBoxCerrar.Size = New System.Drawing.Size(34, 27)
        Me.PictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCerrar.TabIndex = 2
        Me.PictureBoxCerrar.TabStop = False
        '
        'PictureBoxVolver
        '
        Me.PictureBoxVolver.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBoxVolver.Image = CType(resources.GetObject("PictureBoxVolver.Image"), System.Drawing.Image)
        Me.PictureBoxVolver.Location = New System.Drawing.Point(1204, 7)
        Me.PictureBoxVolver.Name = "PictureBoxVolver"
        Me.PictureBoxVolver.Size = New System.Drawing.Size(28, 27)
        Me.PictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxVolver.TabIndex = 9
        Me.PictureBoxVolver.TabStop = False
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.PictureBoxVolver)
        Me.Controls.Add(Me.PictureBoxCerrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLimpiarLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMostrarClientes.ResumeLayout(False)
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBoxClientes As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents PictureBoxBuscar As PictureBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextBoxIngresarCorreo As TextBox
    Friend WithEvents TextBoxIngresarTelefono As TextBox
    Friend WithEvents TextBoxIngresarNombre As TextBox
    Friend WithEvents PanelMostrarClientes As Panel
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents PictureBoxLimpiarLista As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBoxCerrar As PictureBox
    Friend WithEvents PictureBoxVolver As PictureBox
End Class
