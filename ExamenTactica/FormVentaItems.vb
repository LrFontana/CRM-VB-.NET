Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports ExamenTactica.VentaItemBLL

Public Class FormVentaItems

    ' Propiedades.
    Private ventaItemBLL As New VentaItemBLL()
    Private productoBLL As New ProductoBLL()
    Private ventaBLL As New VentaBLL()

    Private listaProductos As New List(Of VentaItem)
    Private listaVentaItems As New List(Of VentaItem)
    Private ventaActual As Venta = Nothing

    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para que al cargar el formulario, mostramos todas las ventas items.
    Private Sub FormVentaItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarProductosAlComboBox()

        DataGridViewVentaItem.Rows.Clear()
        DataGridViewVentaItem.Columns.Clear()


        DataGridViewVentaItem.Columns.Add("IDProducto", "ID Producto")
        DataGridViewVentaItem.Columns.Add("Producto", "Producto")
        DataGridViewVentaItem.Columns.Add("Cantidad", "Cantidad")
        DataGridViewVentaItem.Columns.Add("PrecioUnitario", "Precio Unitario")
        DataGridViewVentaItem.Columns.Add("PrecioTotal", "Precio Total")


        CargarVentaItemsEnDataGridView()

    End Sub

    ' Evento para cargar la lista de ventasItems en el data grid.
    Private Sub CargarVentaItemsEnDataGridView()
        Try

            DataGridViewVentaItem.Rows.Clear()

            If listaVentaItems.Count = 0 Then Exit Sub

            Dim productoSeleccionado As Producto = DirectCast(ComboBoxProductos.SelectedItem, Producto)

            For Each item As VentaItem In listaVentaItems

                Dim producto As Producto = productoBLL.ObtenerProductoPorId(item.IDProducto)

                DataGridViewVentaItem.Rows.Add(
                item.IDProducto,
                producto.Nombre,
                item.Cantidad,
                item.PrecioUnitario,
                item.PrecioTotal
            )
            Next

        Catch ex As Exception

            MessageBox.Show("Error al cargar los detalles de venta: " & ex.Message)
        End Try
    End Sub

    ' Evento ComboBoxProductos.
    ' Cargar la lista de productos al ComboBox al cargar el formulario
    Private Sub CargarProductosAlComboBox()
        Try

            Dim productos As List(Of Producto) = productoBLL.ObtenerTodosLosProductos()

            ComboBoxProductos.Items.Clear()

            If productos IsNot Nothing AndAlso productos.Count > 0 Then

                ComboBoxProductos.DisplayMember = "Nombre"
                ComboBoxProductos.ValueMember = "ID"

                For Each producto As Producto In productos

                    ComboBoxProductos.Items.Add(producto)
                Next
            Else
                MessageBox.Show("No se encontraron productos en la base de datos.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub

    ' Evento cuando el usuario selecciona un producto en el ComboBox
    Private Sub ComboBoxProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProductos.SelectedIndexChanged
        Try

            If ComboBoxProductos.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, seleccione un producto.")
                Return
            End If

            Dim productoSeleccionado As Producto = CType(ComboBoxProductos.SelectedItem, Producto)

            If productoSeleccionado IsNot Nothing AndAlso productoSeleccionado.ID > 0 Then

                MessageBox.Show("Producto seleccionado con exito: " & productoSeleccionado.Nombre)
            Else
                MessageBox.Show("No se pudo obtener el Producto ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar el producto: " & ex.Message)
        End Try
    End Sub


    ' Evento para hacer la busqueda cuando el usuario hace click en el PictureBox.
    Private Sub PictureBoxBuscar_Click(sender As Object, e As EventArgs) Handles PictureBoxBuscar.Click

        If String.IsNullOrWhiteSpace(TextBoxBuscar.Text) OrElse TextBoxBuscar.Text = "Por favor ingrese un id de venta" Then
            MessageBox.Show("El campo no puede estar vacio.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenta As Integer
        If Not Integer.TryParse(TextBoxBuscar.Text, idVenta) Then
            MessageBox.Show("Debe ingresar un numero valido de id de venta.", "Formato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim listaVentaItems As List(Of VentaItem) = ventaItemBLL.ObtenerUnaListaDeVentaItemsPorId(idVenta)

        DataGridViewVentaItem.Rows.Clear()

        If listaVentaItems IsNot Nothing AndAlso listaVentaItems.Count > 0 Then
            For Each item As VentaItem In listaVentaItems

                Dim nombreProducto As String = productoBLL.ObtenerProdcutoNombrePorId(item.IDProducto)

                DataGridViewVentaItem.Rows.Add(
                item.IDProducto,
                nombreProducto,
                item.Cantidad,
                item.PrecioUnitario,
                item.PrecioTotal
            )
            Next
        Else
            MessageBox.Show("No se encontraron detalles de venta para ese id.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Evento boton agregar.
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try

            If ComboBoxProductos.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, seleccione un producto valido.")
                Return
            End If

            Dim productoSeleccionado As Producto = CType(ComboBoxProductos.SelectedItem, Producto)

            Dim cantidad As Integer = Convert.ToInt32(NumericUpDownCantidad.Value)
            If cantidad <= 0 Then
                MessageBox.Show("Por favor, ingrese una cantidad mayor a 0.")
                Return
            End If

            Dim precioUnitario As Double = productoSeleccionado.Precio
            Dim precioTotal As Double = precioUnitario * cantidad

            Dim nuevoVentaItem As New VentaItem() With {
            .IDProducto = productoSeleccionado.ID,
            .Cantidad = cantidad,
            .PrecioUnitario = precioUnitario,
            .PrecioTotal = precioTotal
        }


            listaVentaItems.Add(nuevoVentaItem)

            CargarVentaItemsEnDataGridView()

            MessageBox.Show("Venta item agregado con exito.")

        Catch ex As Exception
            MessageBox.Show("Error al agregar el detalle de venta: " & ex.Message)
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

        If DataGridViewVentaItem.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim filaSeleccionada As DataGridViewRow = DataGridViewVentaItem.SelectedRows(0)
        Dim index As Integer = filaSeleccionada.Index

        If ComboBoxProductos.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim productoSeleccionado As Producto = CType(ComboBoxProductos.SelectedItem, Producto)

        Dim cantidad As Integer = Convert.ToInt32(NumericUpDownCantidad.Value)
        If cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim precioTotal As Double = productoSeleccionado.Precio * cantidad

        listaVentaItems(index).IDProducto = productoSeleccionado.ID
        listaVentaItems(index).Cantidad = cantidad
        listaVentaItems(index).PrecioUnitario = productoSeleccionado.Precio
        listaVentaItems(index).PrecioTotal = precioTotal

        CargarVentaItemsEnDataGridView()

        ComboBoxProductos.SelectedIndex = -1
        NumericUpDownCantidad.Value = 1
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

        If DataGridViewVentaItem.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Esta seguro de eliminar este detalle de venta?", "Eliminar Detalle de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim rowIndex As Integer = DataGridViewVentaItem.SelectedRows(0).Index

                listaVentaItems.RemoveAt(rowIndex)

                CargarVentaItemsEnDataGridView()

                MessageBox.Show("Detalle de venta eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Por favor seleccione un detalle de venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    ' Evento boton crear venta venta con todos lo ventam items.
    Private Sub ButtonCrearVenta_Click(sender As Object, e As EventArgs) Handles ButtonCrearVentaItem.Click
        Try

            If DataGridViewVentaItem.Rows.Count = 0 Then
                MessageBox.Show("Debe agregar al menos un producto antes de crear la venta.")
                Return
            End If

            Dim totalVenta As Double = 0
            For Each fila As DataGridViewRow In DataGridViewVentaItem.Rows
                totalVenta += CDbl(fila.Cells("PrecioTotal").Value)
            Next

            Dim nuevaVenta As New Venta() With {
            .IDCliente = 0,
            .Fecha = DateTime.Now,
            .Total = totalVenta
        }

            Dim idVentaCreada As Integer = ventaBLL.AgregarVenta(nuevaVenta)

            If idVentaCreada = -1 Then
                MessageBox.Show("Error al crear la venta.")
                Return
            End If

            For Each fila As DataGridViewRow In DataGridViewVentaItem.Rows
                Dim nuevoItem As New VentaItem() With {
                .IDVenta = idVentaCreada,
                .IDProducto = CInt(fila.Cells("IDProducto").Value),
                .Cantidad = CInt(fila.Cells("Cantidad").Value),
                .PrecioUnitario = CDbl(fila.Cells("PrecioUnitario").Value),
                .PrecioTotal = CDbl(fila.Cells("PrecioTotal").Value)
            }
                ventaItemBLL.AgregarVentaItem(nuevoItem)
            Next

            ' Éxito
            MessageBox.Show("Venta creada correctamente con el ID: " & idVentaCreada)

            ' Limpiar los datos
            DataGridViewVentaItem.DataSource = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al crear la venta: " & ex.Message)
        End Try
    End Sub

    ' Pinta el fondo del boton.
    Private Sub Button_CrearVenta_Paint(sender As Object, e As PaintEventArgs) Handles ButtonCrearVentaItem.Paint
        ButtonCrearVentaItem.FlatAppearance.MouseOverBackColor = Panel2.BackColor
        ButtonCrearVentaItem.FlatAppearance.MouseDownBackColor = Panel2.BackColor
    End Sub

    Private Sub Button_CrearVenta_MouseEnter(sender As Object, e As EventArgs) Handles ButtonCrearVentaItem.MouseEnter
        ButtonCrearVentaItem.ForeColor = Color.Red
    End Sub

    Private Sub Button_CrearVenta_MouseLeave(sender As Object, e As EventArgs) Handles ButtonCrearVentaItem.MouseLeave
        ButtonCrearVentaItem.ForeColor = Color.Black
    End Sub

    ' Evento para limpar el TextBoxBuscar.
    Private Sub TextBoxBuscar_Enter(sender As Object, e As EventArgs) Handles TextBoxBuscar.Enter

        If TextBoxBuscar.Text = "Por favor ingrese un id de venta" Then
            TextBoxBuscar.Text = ""
        End If
    End Sub

    Private Sub TextBoxBuscar_Leave(sender As Object, e As EventArgs) Handles TextBoxBuscar.Leave

        If String.IsNullOrEmpty(TextBoxBuscar.Text) Then
            TextBoxBuscar.Text = "Por favor ingrese un id de venta"
            TextBoxBuscar.ForeColor = Color.Gray
        End If
    End Sub

    ' Evento para limpiar la búsqueda.
    Private Sub PictureBoxLimpiarLista_Click(sender As Object, e As EventArgs) Handles PictureBoxLimpiarLista.Click

        TextBoxBuscar.Clear()
        CargarVentaItemsEnDataGridView()
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