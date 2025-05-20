Imports System
Imports Microsoft.VisualBasic

Public Class ProductoBLL
    Private productoDAL As New ProductoDAL()

    ' Metodos.
    ' Metodo para agregar un producto.
    Public Function AgregarProducto(producto As Producto) As String
        If String.IsNullOrEmpty(producto.Nombre) OrElse
           String.IsNullOrEmpty(producto.Categoria) OrElse
           producto.Precio <= 0 Then
            Return "Todos los campos son obligatorios y el precio tiene que ser mayor a 0."
        End If

        If Not ValidarNombre(producto.Nombre) Then
            Return "El nombre solo puede contener letras y espacios, sin caracteres especiales ni numeros."
        End If

        If Not ValidarCategoria(producto.Categoria) Then
            Return "La categoria solo puede contener letras y espacios, sin caracteres especiales ni numeros."
        End If

        If Not ValidarPrecio(producto.Precio) Then
            Return "El precio solo puede contener numeros y debe ser mayor a 0."
        End If

        If productoDAL.ProductoExiste(producto.Nombre) Then
            Return "La categoria que desea agregar ya existe."
        End If

        productoDAL.AgregarProducto(producto)
        Return "El producto ha sido agregado con exito."
    End Function

    ' Metodo para obtener todos los productos.
    Public Function ObtenerTodosLosProductos() As List(Of Producto)
        Return productoDAL.ObtenerTodosLosProductos()
    End Function

    ' Metodo para obtener el producto por id.
    Public Function ObtenerProductoPorId(id As Integer) As Producto
        If id <= 0 Then
            Throw New ArgumentException("El id del producto no es correcto.")
        End If
        Return productoDAL.ObtenerProductoPorId(id)
    End Function

    ' Metodo para obtener el producto por nombre.
    Public Function ObtenerProductoPorNombre(nombre As String) As Producto

        If String.IsNullOrEmpty(nombre) Then
            Throw New ArgumentException("El nombre del producto no puede estar vacio.")
        End If

        Return productoDAL.ObtenerProductoPorNombre(nombre)
    End Function

    ' Metodo para obtener el prodcuto nombre por id.
    Public Function ObtenerProdcutoNombrePorId(id As Integer) As String
        If id <= 0 Then
            Throw New ArgumentException("El id del prodcuto no es valido.")
        End If

        Return productoDAL.ObtenerNombreProductoPorId(id)
    End Function

    ' Metodo para obtener el producto por categoria.
    Public Function ObtenerProductoPorCategoria(categoria As String) As Producto
        If String.IsNullOrEmpty(categoria) Then
            Throw New ArgumentException("La categoria del producto no puede estar vacio.")
        End If

        Return productoDAL.ObtenerProductoPorCategoria(categoria)
    End Function

    ' Metodo para obtener el precio de un producto por id.
    Public Function ObtenerPrecioPorId(id As Integer) As Decimal
        If id <= 0 Then
            Throw New ArgumentException("El id del producto no es valido.")
        End If

        Return productoDAL.ObtenerPrecioPorId(id)
    End Function

    ' Metodo para actualizar el producto.
    Public Function ActualizarProducto(producto As Producto) As String
        If producto.Id <= 0 Then
            Return "El id del producto no es correcto"
        End If

        If String.IsNullOrEmpty(producto.Nombre) OrElse
           String.IsNullOrEmpty(producto.Categoria) OrElse
           producto.Precio <= 0 Then
            Return "Todos los campos son obligatorios."
        End If

        productoDAL.ActualizarProducto(producto)
        Return "El producto ha asido actualizado con exito."
    End Function

    ' Metodo para eliminar un producto.
    Public Function EliminarProducto(id As Integer) As Boolean
        If id <= 0 Then
            Return False
        End If

        Dim success As Boolean = productoDAL.EliminarProducto(id)

        Return success
    End Function

    ' Metodo para validar el nombre.
    Private Function ValidarNombre(nombre As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z\s]+$")
        Return regex.IsMatch(nombre)
    End Function

    ' Metodo para validar el categoria.
    Private Function ValidarCategoria(categoria As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z\s]+$")
        Return regex.IsMatch(categoria)
    End Function

    ' Metodo para validar el precio.
    Private Function ValidarPrecio(precio As Single) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^\d+(\.\d{1,2})?$")
        Return regex.IsMatch(precio)
    End Function

    ' Metodo para validar si el producto existe.
    Public Function ValidarProductoExiste(nombre As String) As Boolean

        If String.IsNullOrEmpty(nombre) Then
            Return False
        End If

        Return productoDAL.ProductoExiste(nombre)
    End Function

    ' Metodo para obtener el reporte mensual de productos vendidos.
    Public Function ObtenerReporteMensualProducto(idProducto As Integer) As DataTable
        Return productoDAL.ObtenerReporteMensualProductoPorId(idProducto)
    End Function
End Class
