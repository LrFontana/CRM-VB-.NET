Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class FormPrincipal
    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para cargar la imagen de fondo y ajustarla.
    Private Sub FormPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim imagen As Image = Image.FromFile("C:\Users\leand\source\repos\Examen\imagenPrincipal.jpg")

        Dim ancho As Integer = Me.ClientSize.Width
        Dim alto As Integer = imagen.Height * (ancho / imagen.Width)

        e.Graphics.DrawImage(imagen, 0, 0, ancho, alto)
    End Sub

    ' Eventos para el boton clientes.
    ' Pinta el fondo del boton.
    Private Sub Button_Clientes_Paint(sender As Object, e As PaintEventArgs) Handles Button_clientes.Paint
        Button_clientes.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_clientes.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    Private Sub Button_Clientes_MouseEnter(sender As Object, e As EventArgs) Handles Button_clientes.MouseEnter
        Button_clientes.ForeColor = Color.Red
    End Sub

    Private Sub Button_Clientes_MouseLeave(sender As Object, e As EventArgs) Handles Button_clientes.MouseLeave
        Button_clientes.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Evento para ocultar el form actual y mostrar el form clientes.
    Private Sub Button_Clientes_Click(sender As Object, e As EventArgs) Handles Button_clientes.Click

        Me.Hide()

        Dim formCliente As New FormCliente()
        formCliente.Show()
    End Sub

    ' Eventos para el boton productos.
    ' Pinta el fondo del boton.
    Private Sub Button_Productos_Paint(sender As Object, e As PaintEventArgs) Handles Button_productos.Paint
        Button_productos.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_productos.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    ' Cambiar de color las letras cuando el mouse pasa por arriba.
    Private Sub Button_Productos_MouseEnter(sender As Object, e As EventArgs) Handles Button_productos.MouseEnter
        Button_productos.ForeColor = Color.Red
    End Sub

    Private Sub Button_Productos_MouseLeave(sender As Object, e As EventArgs) Handles Button_productos.MouseLeave
        Button_productos.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Evento para ocultar el form actual y mostrar el form producto.
    Private Sub Button_Productos_Click(sender As Object, e As EventArgs) Handles Button_productos.Click

        Me.Hide()

        Dim formProducto As New FormProducto()
        formProducto.Show()
    End Sub

    ' Eventos para el boton ventas items.
    ' Pinta el fondo del boton.
    Private Sub Button_VentaItems_Paint(sender As Object, e As PaintEventArgs) Handles Button_ventaItems.Paint
        Button_ventaItems.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_ventaItems.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    ' Cambiar de color las letras cuando el mouse pasa por arriba.
    Private Sub Button_VentasItems_MouseEnter(sender As Object, e As EventArgs) Handles Button_ventaItems.MouseEnter
        Button_ventaItems.ForeColor = Color.Red
    End Sub

    Private Sub Button_VentasItems_MouseLeave(sender As Object, e As EventArgs) Handles Button_ventaItems.MouseLeave
        Button_ventaItems.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Evento para ocultar el form actual y mostrar el form producto.
    Private Sub Button_VentaItems_Click(sender As Object, e As EventArgs) Handles Button_ventaItems.Click

        Me.Hide()

        Dim formVentaItem As New FormVentaItems()
        formVentaItem.Show()
    End Sub

    ' Eventos para el boton ventas.
    ' Pinta el fondo del boton.
    Private Sub Button_Ventas_Paint(sender As Object, e As PaintEventArgs) Handles Button_ventas.Paint
        Button_ventas.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_ventas.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    ' Cambiar de color las letras cuando el mouse pasa por arriba.
    Private Sub Button_Ventas_MouseEnter(sender As Object, e As EventArgs) Handles Button_ventas.MouseEnter
        Button_ventas.ForeColor = Color.Red
    End Sub

    Private Sub Button_Ventas_MouseLeave(sender As Object, e As EventArgs) Handles Button_ventas.MouseLeave
        Button_ventas.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Eventos para el boton reporte ventas.
    ' Pinta el fondo del boton.
    Private Sub Button_Reporte_Ventas_Paint(sender As Object, e As PaintEventArgs) Handles Button_Reporte_Ventas.Paint
        Button_Reporte_Ventas.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_Reporte_Ventas.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    ' Cambiar de color las letras cuando el mouse pasa por arriba.
    Private Sub Button_Reporte_Ventas_MouseEnter(sender As Object, e As EventArgs) Handles Button_Reporte_Ventas.MouseEnter
        Button_Reporte_Ventas.ForeColor = Color.Red
    End Sub

    Private Sub Button_Reporte_Ventas_MouseLeave(sender As Object, e As EventArgs) Handles Button_Reporte_Ventas.MouseLeave
        Button_Reporte_Ventas.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Evento para ocultar el form actual y mostrar el form reporte ventas.
    Private Sub Button_ReporteVentas_Click(sender As Object, e As EventArgs) Handles Button_Reporte_Ventas.Click

        Me.Hide()

        Dim formReporteVenta As New FormReporteVentas()
        formReporteVenta.Show()
    End Sub

    ' Eventos para el boton reporte productos.
    ' Pinta el fondo del boton.
    Private Sub Button_Reporte_Producto_Paint(sender As Object, e As PaintEventArgs) Handles Button_Reporte_Productos.Paint
        Button_Reporte_Productos.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        Button_Reporte_Productos.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    ' Cambiar de color las letras cuando el mouse pasa por arriba.
    Private Sub Button_Reporte_Productos_MouseEnter(sender As Object, e As EventArgs) Handles Button_Reporte_Productos.MouseEnter
        Button_Reporte_Productos.ForeColor = Color.Red
    End Sub

    Private Sub Button_Reporte_Productos_MouseLeave(sender As Object, e As EventArgs) Handles Button_Reporte_Productos.MouseLeave
        Button_Reporte_Productos.ForeColor = Color.BlanchedAlmond
    End Sub

    ' Evento para ocultar el form actual y mostrar el form reporte productos.
    Private Sub Button_ReporteProducto_Click(sender As Object, e As EventArgs) Handles Button_Reporte_Productos.Click

        Me.Hide()

        Dim formReporteProducto As New FormReporteProductos()
        formReporteProducto.Show()
    End Sub

    ' Evento para ocultar el form actual y mostrar el form producto.
    Private Sub Button_Venta_Click(sender As Object, e As EventArgs) Handles Button_ventas.Click

        Me.Hide()

        Dim formVenta As New FormVenta()
        formVenta.Show()
    End Sub

    ' Evento picture box cerrar.
    Private Sub PictureBox_Cerrar_Click(sender As Object, e As EventArgs) Handles PictureBoxCerrar.Click

        MessageBox.Show("Gracias por utilizarnos, ¡vuelva pronto!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub


End Class