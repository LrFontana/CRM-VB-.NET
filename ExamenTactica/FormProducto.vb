Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports ExamenTactica.ProductoBLL

Public Class FormProducto

    Private productoBLL As New ProductoBLL()

    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para que al cargar el formulario, mostramos todos los productos en el listBox.
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductosEnDataGridView()
    End Sub

    ' Evento para la lista de productos en el data grid.
    Private Sub CargarProductosEnDataGridView()

        Dim productos As List(Of Producto) = productoBLL.ObtenerTodosLosProductos()

        If productos IsNot Nothing AndAlso productos.Count > 0 Then

            DataGridViewProductos.DataSource = New BindingList(Of Producto)(productos)
        Else

            MessageBox.Show("No se encontraron productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataGridViewProductos.DataSource = productos
    End Sub

    ' Evento para hacer la busqueda cuando el usuario hace click en el PictureBox.
    Private Sub PictureBoxBuscar_Click(sender As Object, e As EventArgs) Handles PictureBoxBuscar.Click

        ' Verifica los campos.
        If String.IsNullOrEmpty(TextBoxBuscar.Text) Then
            MessageBox.Show("El campo no puede estar vacio.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf Not Regex.IsMatch(TextBoxBuscar.Text, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("El campo debe contener solo letras y espacios.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim producto As Producto = productoBLL.ObtenerProductoPorNombre(TextBoxBuscar.Text)

            If producto IsNot Nothing Then

                Dim listaPorductos As New List(Of Producto) From {producto}
                DataGridViewProductos.DataSource = Nothing
                DataGridViewProductos.DataSource = listaPorductos
            Else
                MessageBox.Show("Producto no encontrado. Por favor, verifica el nombre e intenta de nuevo.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' Evento boton agregar.
    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        Dim nombre As String = TextBoxIngresarNombre.Text.Trim()
        Dim categoria As String = TextBoxIngresarCategoria.Text.Trim()
        Dim precio As String = TextBoxIngresarPrecio.Text.Trim()

        Dim precioDouble As Double
        If Not Double.TryParse(precio, precioDouble) Then
            MessageBox.Show("Por favor ingrese un precio valido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nuevoProducto As New Producto() With {
            .Nombre = nombre,
            .Categoria = categoria,
            .Precio = precio
        }

        Dim resultado As String = productoBLL.AgregarProducto(nuevoProducto)

        MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado = "El producto ha sido agregado con exito." Then
            TextBoxIngresarNombre.Clear()
            TextBoxIngresarCategoria.Clear()
            TextBoxIngresarPrecio.Clear()
            CargarProductosEnDataGridView()
        End If

        CargarProductosEnDataGridView()
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

        If DataGridViewProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un prodcuto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idProdcuto As Integer = Convert.ToInt32(DataGridViewProductos.SelectedRows(0).Cells("ID").Value)
        MessageBox.Show("ID del producto seleccionado: " & idProdcuto.ToString())

        Dim nombre As String = TextBoxIngresarNombre.Text.Trim()
        Dim categoria As String = TextBoxIngresarCategoria.Text.Trim()
        Dim precio As String = TextBoxIngresarPrecio.Text.Trim()

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(categoria) OrElse String.IsNullOrEmpty(precio) Then
            MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim precioDouble As Double
        If Not Double.TryParse(precio, precioDouble) Then
            MessageBox.Show("Por favor ingrese un precio valido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Crea un objeto procuto.
        Dim productoActualizado As New Producto() With {
            .ID = idProdcuto,
            .Nombre = nombre,
            .Categoria = categoria,
            .Precio = precio
            }

        Dim resultado As String = productoBLL.ActualizarProducto(productoActualizado)

        MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado = "El producto ha sido actualizado con exito." Then
            TextBoxIngresarNombre.Clear()
            TextBoxIngresarCategoria.Clear()
            TextBoxIngresarPrecio.Clear()
            CargarProductosEnDataGridView()
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

        If DataGridViewProductos.SelectedRows.Count > 0 Then

            Dim prodcutoID As Integer = Convert.ToInt32(DataGridViewProductos.SelectedRows(0).Cells("ID").Value)

            Dim result As DialogResult = MessageBox.Show("¿Esta seguro de eliminar este prodcuto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim productoBLL As New ProductoBLL()
                If productoBLL.EliminarProducto(prodcutoID) Then

                    CargarProductosEnDataGridView()
                    MessageBox.Show("Producto eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Ocurrio un error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Por favor seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        CargarProductosEnDataGridView()
    End Sub

    ' Evento picture box volver.
    Private Sub PictureBox_Volver_Click(sender As Object, e As EventArgs) Handles PictureBoxVolver.Click

        Me.Hide()

        Dim formPrincipal As New FormPrincipal()
        formPrincipal.Show()
    End Sub

    ' Evento picture box cerrar.
    Private Sub PictureBox_Cerrar_Click(sender As Object, e As EventArgs) Handles PictureBoxCerrar.Click

        MessageBox.Show("Gracias por utilizarnos, ¡vuelva pronto!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

End Class