Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports ExamenTactica.VentaBLL
Imports ExamenTactica.ClienteBLL

Public Class FormVenta

    Private ventaBLL As New VentaBLL()
    Private clienteBLL As New ClienteBLL()

    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para que al cargar el formulario, mostramos todos las ventas en el listBox.
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientesAlComboBox()

        DataGridViewVentas.Rows.Clear()
        DataGridViewVentas.Columns.Clear()

        DataGridViewVentas.Columns.Add("ID", "ID Venta")
        DataGridViewVentas.Columns.Add("Cliente", "Cliente")
        DataGridViewVentas.Columns.Add("Fecha", "Fecha")
        DataGridViewVentas.Columns.Add("Total", "Total")

        CargarVentasEnDataGridView()
    End Sub

    ' Evento para la lista de ventas en el data grid.
    Private Sub CargarVentasEnDataGridView()

        Try
            DataGridViewVentas.Rows.Clear()

            Dim ventas As List(Of Venta) = ventaBLL.ObtenerTodosLasVentas()
            Dim clientes As List(Of Cliente) = clienteBLL.ObtenerTodosLosClientes()

            If ventas Is Nothing OrElse ventas.Count = 0 Then
                MessageBox.Show("No se encontraron ventas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            For Each venta As Venta In ventas

                Dim cliente As Cliente = clientes.FirstOrDefault(Function(c) c.ID = venta.IDCliente)
                Dim nombreCliente As String = If(cliente IsNot Nothing, cliente.Cliente, "Desconocido")

                DataGridViewVentas.Rows.Add(
                venta.ID,
                nombreCliente,
                venta.Fecha.ToShortDateString(),
                venta.Total.ToString("C")
            )
            Next

        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message)
        End Try
    End Sub

    ' Evento para hacer la busqueda cuando el usuario hace click en el PictureBox.
    Private Sub PictureBoxBuscar_Click(sender As Object, e As EventArgs) Handles PictureBoxBuscar.Click

        Try
            Dim nombreCliente As String = TextBoxBuscar.Text.Trim()

            If String.IsNullOrEmpty(nombreCliente) Then
                MessageBox.Show("Por favor ingrese el nombre del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ventasFiltradas As List(Of Venta) = ventaBLL.ObtenerVentaPorClienteNombre(nombreCliente)

            DataGridViewVentas.Rows.Clear()

            If ventasFiltradas IsNot Nothing AndAlso ventasFiltradas.Count > 0 Then
                For Each venta As Venta In ventasFiltradas
                    Dim cliente As Cliente = clienteBLL.ObtenerClientePorId(venta.IDCliente)

                    DataGridViewVentas.Rows.Add(
                    venta.ID,
                    cliente.Cliente,
                    venta.Fecha.ToShortDateString(),
                    venta.Total.ToString("C")
                )
                Next
            Else
                MessageBox.Show("No se encontraron ventas para ese cliente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento ComboBoxCliente.
    ' Cargar la lista de clientes al ComboBox al cargar el formulario.
    Private Sub CargarClientesAlComboBox()
        Try

            Dim clientes As List(Of Cliente) = clienteBLL.ObtenerTodosLosClientes()

            ComboBoxCliente.Items.Clear()

            If clientes IsNot Nothing AndAlso clientes.Count > 0 Then

                ComboBoxCliente.DisplayMember = "Cliente"
                ComboBoxCliente.ValueMember = "ID"

                For Each cliente As Cliente In clientes

                    ComboBoxCliente.Items.Add(cliente)
                Next
            Else
                MessageBox.Show("No se encontraron clientes en la base de datos.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los clientes: " & ex.Message)
        End Try
    End Sub

    ' Evento cuando el usuario selecciona un producto en el ComboBox
    Private Sub ComboBoxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCliente.SelectedIndexChanged
        Try

            If ComboBoxCliente.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, seleccione un cliente.")
                Return
            End If

            Dim clienteSeleccionado As Cliente = CType(ComboBoxCliente.SelectedItem, Cliente)

            If clienteSeleccionado IsNot Nothing AndAlso clienteSeleccionado.ID > 0 Then

                MessageBox.Show("Cliente seleccionado con exito: " & clienteSeleccionado.Cliente)
            Else
                MessageBox.Show("No se pudo obtener el Cliente ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar el cliente: " & ex.Message)
        End Try
    End Sub

    ' Evento boton agregar.
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim idVenta As Integer
            If Not Integer.TryParse(TextBoxIdVenta.Text.Trim(), idVenta) Then
                MessageBox.Show("Por favor ingrese un ID de venta valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ComboBoxCliente.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim clienteSeleccionado As Cliente = CType(ComboBoxCliente.SelectedItem, Cliente)
            Dim fechaVenta As Date = DateTimePickerFecha.Value

            ' Verificar que la venta existe
            Dim ventaExistente As Venta = ventaBLL.ObtenerVentaPorId(idVenta)

            If ventaExistente Is Nothing Then
                MessageBox.Show("No se encontro una venta con ese id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Asignar cliente y fecha
            ventaExistente.IDCliente = clienteSeleccionado.ID
            ventaExistente.Fecha = fechaVenta
            ventaExistente.Total = ventaBLL.ObtenerTotalDeVenta(idVenta)

            ' Actualizar en base de datos
            ventaBLL.ActualizarVenta(ventaExistente)

            MessageBox.Show("Venta actualizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarVentasEnDataGridView()

            TextBoxIdVenta.Clear()
            ComboBoxCliente.SelectedIndex = -1
            DateTimePickerFecha.Value = Date.Now


        Catch ex As Exception
            MessageBox.Show("Error al agregar la venta: " & ex.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    ' Evento Boton actualizar.
    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

        Try
            If DataGridViewVentas.SelectedRows.Count = 0 Then
                MessageBox.Show("Por favor, seleccione una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim filaSeleccionada As DataGridViewRow = DataGridViewVentas.SelectedRows(0)
            Dim index As Integer = filaSeleccionada.Index

            If ComboBoxCliente.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim clienteSeleccionado As Cliente = CType(ComboBoxCliente.SelectedItem, Cliente)

            Dim fecha As DateTime = DateTimePickerFecha.Value

            Dim idVenta As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)

            Dim ventaExistente As Venta = ventaBLL.ObtenerVentaPorId(idVenta)

            If ventaExistente Is Nothing Then
                MessageBox.Show("No se encontro la venta en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ventaExistente.IDCliente = clienteSeleccionado.ID
            ventaExistente.Fecha = fecha

            ' Actualizar la venta en la base de datos.
            ventaBLL.ActualizarVenta(ventaExistente)


            MessageBox.Show("Venta actualizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarVentasEnDataGridView()

            TextBoxIdVenta.Clear()
            ComboBoxCliente.SelectedIndex = -1
            DateTimePickerFecha.Value = Date.Now

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la venta: " & ex.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

        If DataGridViewVentas.SelectedRows.Count > 0 Then

            Dim ventaID As Integer = Convert.ToInt32(DataGridViewVentas.SelectedRows(0).Cells("ID").Value)
            Dim result As DialogResult = MessageBox.Show("¿Esta seguro de eliminar esta venta?", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim ventaBLL As New VentaBLL()
                If ventaBLL.EliminarVenta(ventaID) Then

                    CargarVentasEnDataGridView()
                    MessageBox.Show("Producto eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ocurrio un error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Por favor seleccione una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        If TextBoxBuscar.Text = "Por favor ingrese un nombre de cliente." Then
            TextBoxBuscar.Text = ""
        End If
    End Sub

    Private Sub TextBoxBuscar_Leave(sender As Object, e As EventArgs) Handles TextBoxBuscar.Leave

        If String.IsNullOrEmpty(TextBoxBuscar.Text) Then
            TextBoxBuscar.Text = "Por favor ingrese un nombre de cliente."
            TextBoxBuscar.ForeColor = Color.Gray
        End If
    End Sub

    ' Evento para limpiar la búsqueda.
    Private Sub PictureBoxLimpiarLista_Click(sender As Object, e As EventArgs) Handles PictureBoxLimpiarLista.Click

        TextBoxBuscar.Clear()
        CargarVentasEnDataGridView()
    End Sub

    ' Evento picture box volver.
    Private Sub PictureBox_Volver_Click(sender As Object, e As EventArgs) Handles PictureBoxVolver.Click

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

