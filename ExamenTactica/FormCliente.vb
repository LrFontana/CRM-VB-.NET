Imports System.ComponentModel
Imports ExamenTactica.ClienteBLL
Public Class FormCliente

    Private clienteBLL As New ClienteBLL()

    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para que al cargar el formulario, mostramos todos los clientes.
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientesEnDataGridView()
    End Sub

    ' Evento para la lista de clientes en el data grid.
    Private Sub CargarClientesEnDataGridView()

        Dim clientes As List(Of Cliente) = clienteBLL.ObtenerTodosLosClientes()

        ' Verificar si la lista no esta vacia.
        If clientes IsNot Nothing AndAlso clientes.Count > 0 Then

            DataGridViewClientes.DataSource = New BindingList(Of Cliente)(clientes)
        Else

            MessageBox.Show("No se encontraron clientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Evento para hacer la busqueda cuando el usuario hace click en el PictureBox.
    Private Sub PictureBoxBuscar_Click(sender As Object, e As EventArgs) Handles PictureBoxBuscar.Click

        ' Verificar los campos.
        If String.IsNullOrEmpty(TextBoxBuscar.Text) Then
            MessageBox.Show("El campo no puede estar vacio.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Not TextBoxBuscar.Text.All(AddressOf Char.IsLetter) Then
            MessageBox.Show("El campo debe contener solo letras.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim cliente As Cliente = clienteBLL.ObtenerClientePorNombre(TextBoxBuscar.Text)

            If cliente IsNot Nothing Then

                Dim listaClientes As New List(Of Cliente) From {cliente}
                DataGridViewClientes.DataSource = Nothing
                DataGridViewClientes.DataSource = listaClientes
            Else
                MessageBox.Show("Cliente no encontrado. Por favor, verifica el nombre e intenta de nuevo.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' Evento boton agregar.
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        Dim nombre As String = TextBoxIngresarNombre.Text.Trim()
        Dim telefono As String = TextBoxIngresarTelefono.Text.Trim()
        Dim correo As String = TextBoxIngresarCorreo.Text.Trim()

        ' Crea el objeto cliente.
        Dim nuevoCliente As New Cliente() With {
            .Cliente = nombre,
            .Telefono = telefono,
            .Correo = correo
        }

        Dim resultado As String = clienteBLL.AgregarCliente(nuevoCliente)

        MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado = "El cliente ha sido agregado con exito." Then
            TextBoxIngresarNombre.Clear()
            TextBoxIngresarTelefono.Clear()
            TextBoxIngresarCorreo.Clear()
            CargarClientesEnDataGridView()
        End If

        CargarClientesEnDataGridView()
    End Sub

    ' Pinta el fondo del boton.
    Private Sub Button_Agregar_Paint(sender As Object, e As PaintEventArgs) Handles ButtonAgregar.Paint
        ButtonAgregar.FlatAppearance.MouseOverBackColor = Panel2.BackColor
        ButtonAgregar.FlatAppearance.MouseDownBackColor = Panel2.BackColor
    End Sub

    Private Sub Button_Agregar_MouseEnter(sender As Object, e As EventArgs) Handles ButtonAgregar.MouseEnter
        ButtonAgregar.ForeColor = Color.DarkGreen
    End Sub

    Private Sub Button_Agregar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAgregar.MouseLeave
        ButtonAgregar.ForeColor = Color.Black
    End Sub

    ' Evento boton actualizar.
    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

        If DataGridViewClientes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un cliente para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idCliente As Integer = Convert.ToInt32(DataGridViewClientes.SelectedRows(0).Cells("ID").Value)
        MessageBox.Show("ID del cliente seleccionado: " & idCliente.ToString())

        Dim nombre As String = TextBoxIngresarNombre.Text.Trim()
        Dim telefono As String = TextBoxIngresarTelefono.Text.Trim()
        Dim correo As String = TextBoxIngresarCorreo.Text.Trim()

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(telefono) OrElse String.IsNullOrEmpty(correo) Then
            MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Crea un objeto cliente.
        Dim clienteActualizado As New Cliente() With {
            .ID = idCliente,
            .Cliente = nombre,
            .Telefono = telefono,
            .Correo = correo
            }

        Dim resultado As String = clienteBLL.ActualizarCliente(clienteActualizado)

        MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado = "El cliente ha sido actualizado con exito." Then
            CargarClientesEnDataGridView()
        End If
    End Sub

    ' Pinta el fondo del boton.
    Private Sub Button_Actualizar_Paint(sender As Object, e As PaintEventArgs) Handles ButtonActualizar.Paint
        ButtonActualizar.FlatAppearance.MouseOverBackColor = Panel2.BackColor
        ButtonActualizar.FlatAppearance.MouseDownBackColor = Panel2.BackColor
    End Sub

    Private Sub Button_Actualizar_MouseEnter(sender As Object, e As EventArgs) Handles ButtonActualizar.MouseEnter
        ButtonActualizar.ForeColor = Color.DarkOrange
    End Sub

    Private Sub Button_Actualizar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonActualizar.MouseLeave
        ButtonActualizar.ForeColor = Color.Black
    End Sub

    ' Evento boton eliminar.
    Private Sub BotonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        If DataGridViewClientes.SelectedRows.Count > 0 Then

            Dim clienteID As Integer = Convert.ToInt32(DataGridViewClientes.SelectedRows(0).Cells("ID").Value)

            Dim result As DialogResult = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim clienteBLL As New ClienteBLL()
                If clienteBLL.EliminarCliente(clienteID) Then

                    CargarClientesEnDataGridView()
                    MessageBox.Show("Cliente eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ocurrio un error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Por favor seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Pinta el fondo del boton.
    Private Sub Button_Eliminar_Paint(sender As Object, e As PaintEventArgs) Handles ButtonEliminar.Paint
        ButtonEliminar.FlatAppearance.MouseOverBackColor = Panel2.BackColor
        ButtonEliminar.FlatAppearance.MouseDownBackColor = Panel2.BackColor
    End Sub

    Private Sub Button_Eliminar_MouseEnter(sender As Object, e As EventArgs) Handles ButtonEliminar.MouseEnter
        ButtonEliminar.ForeColor = Color.Red
    End Sub

    Private Sub Button_Eliminar_MouseLeave(sender As Object, e As EventArgs) Handles ButtonEliminar.MouseLeave
        ButtonEliminar.ForeColor = Color.Black
    End Sub

    ' Evento para limpar el TextBoxBuscar.
    Private Sub TextBoxBuscar_Enter(sender As Object, e As EventArgs) Handles TextBoxBuscar.Enter

        If TextBoxBuscar.Text = "Por favor ingrese un nombre" Then
            TextBoxBuscar.Text = ""
        End If
    End Sub

    Private Sub TextBoxBuscar_Leave(sender As Object, e As EventArgs) Handles TextBoxBuscar.Leave

        If String.IsNullOrEmpty(TextBoxBuscar.Text) Then
            TextBoxBuscar.Text = "Por favor ingrese un nombre"
            TextBoxBuscar.ForeColor = Color.Gray
        End If
    End Sub

    ' Evento para limpiar la búsqueda y cargar todos los clientes.
    Private Sub PictureBoxLimpiarLista_Click(sender As Object, e As EventArgs) Handles PictureBoxLimpiarLista.Click

        TextBoxBuscar.Clear()
        CargarClientesEnDataGridView()
    End Sub

    ' Evento picture box volver.
    Private Sub PictuireBox_Volver_Click(sender As Object, e As EventArgs) Handles PictureBoxVolver.Click

        Me.Hide()

        Dim formPrincipal As New FormPrincipal()
        formPrincipal.Show()
    End Sub

    ' Evento picture box cerrar.
    Private Sub PictuireBox_Cerrar_Click(sender As Object, e As EventArgs) Handles PictureBoxCerrar.Click

        MessageBox.Show("Gracias por utilizarnos, ¡vuelva pronto!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub
End Class