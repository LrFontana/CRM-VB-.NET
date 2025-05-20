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

        If productoDAL.ProductoExiste(producto.Nombre) Then
            Return "El producto que desea agregar ya existe."
        End If

        productoDAL.AgregarProducto(producto)
        Return "El producto ha sido agregado con exito."
    End Function

    ' Metodo para obtener el producto por id.
    Public Function ObtenerProductoPorId(id As Long) As Producto
        If id <= 0 Then
            Throw New ArgumentException("El id del producto no es correcto.")
        End If
        Return productoDAL.ObtenerProductoPorId(id)
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
    Public Function EliminarProducto(id As Long) As String
        If id <= 0 Then
            Return "El id del producto es incorrecto."
        End If

        productoDAL.EliminarProducto(id)
        Return "El producto ha sido eliminado con exito."
    End Function
End Class
