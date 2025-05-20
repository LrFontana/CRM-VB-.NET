Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class VentaItemBLL

    Private ventaItemDAL As New VentaItemDAL()
    Private productoDAL As New ProductoDAL()
    Private clienteDAL As New ClienteDAL()
    Private ventaDAL As New VentaDAL()

    ' Metodos.
    ' Metodo para agregar una venta item.
    Public Function AgregarVentaItem(ventaItem As VentaItem) As String

        Dim precioUnitario As Decimal = productoDAL.ObtenerPrecioPorId(ventaItem.IDProducto)
        If precioUnitario <= 0 Then
            Return "El producto no existe o su precio no es valido."
        End If

        ventaItem.PrecioUnitario = precioUnitario

        ventaItem.PrecioTotal = ventaItem.Cantidad * ventaItem.PrecioUnitario

        ventaItemDAL.AgregarVentaItem(ventaItem)
        Return "El producto ha sido agregado a la venta con exito."
    End Function


    ' Metodo para obtener todas las ventas items. 
    Public Function ObtenerTodosLasVentaItems() As List(Of VentaItem)
        Return ventaItemDAL.ObtenerTodasLasVentaItems()
    End Function

    ' Metodo para obtener venta item por id.
    Public Function ObtenerVentaItemId(idVentaItem As Integer) As VentaItem

        Try
            ' Validar si el ID es válido (mayor que 0)
            If idVentaItem <= 0 Then
                Throw New ArgumentException("El ID de VentaItem no es valido.")
            End If

            ' Llamar a la capa DAL para obtener el VentaItem
            Dim ventaItem As VentaItem = ventaItemDAL.ObtenerVentaItemId(idVentaItem)

            ' Verificar si el VentaItem fue encontrado
            If ventaItem Is Nothing Then
                Throw New Exception("El VentaItem no existe en la base de datos.")
            End If

            ' Retornar el VentaItem encontrado
            Return ventaItem
        Catch ex As Exception
            ' Manejo de errores (puedes registrar el error si lo necesitas)
            Throw New Exception("Error al obtener el VentaItem: " & ex.Message)
        End Try

    End Function
    ' Metodo para buscar una venta item por un id venta.
    Public Function ObtenerVentaItemsPorIdVenta(idVenta As Integer) As List(Of VentaItem)
        ' Obtener todos los productos asociados con una venta específica.
        Return ventaItemDAL.ObtenerVentaItemsPorId(idVenta)
    End Function

    ' Metodo para actualizar una venta item.
    Public Function ActualizarVentaItem(ventaItem As VentaItem) As String
        If ventaItem.ID <= 0 Then
            Return "El id de la venta item no es correcto"
        End If

        ventaItemDAL.ActualizarVentaItem(ventaItem)
        Return "La venta item ha asido actualizado con exito."
    End Function

    ' Metodo para eliminar una venta item.
    Public Function EliminarVentaItem(id As Integer) As Boolean
        If id <= 0 Then
            Return False
        End If

        Dim success As Boolean = ventaItemDAL.EliminarVentaItem(id)

        Return success
    End Function

    ' Metodo para validar si la venta items existe.
    Public Function ValidarVentaItemExiste(idVenta As Integer, idProducto As Integer) As Boolean

        If idVenta <= 0 Or idProducto <= 0 Then
            Return False
        End If

        Return ventaItemDAL.VentaItemExiste(idVenta, idProducto)
    End Function

    ' Metodo para obtener el id del cliente por el nombre.
    Public Function ObtenerIdClientePorNombre(nombreCliente As String) As Integer

        If String.IsNullOrEmpty(nombreCliente) Then
            Return -1
        End If

        Return clienteDAL.ObtenerNombreClientePorId(nombreCliente)
    End Function

    ' Metodo para obtener el id de la venta de un cliente.
    Public Function ObtenerIdVentaDeCliente(clienteID As Integer) As Integer

        If clienteID <= 0 Then
            Return -1
        End If

        Dim ventas As List(Of Venta) = ventaDAL.ObtenerVentasPorClienteNombre(clienteID)

        If ventas.Count > 0 Then

            Return ventas(0).ID
        Else
            Return -1
        End If
    End Function

    ' Metodo para obtener el id producto por el nombre.
    Public Function ObtenerProductoNombrePorId(nombreProducto As String) As Integer

        If String.IsNullOrEmpty(nombreProducto) Then
            Return -1
        End If

        Return productoDAL.ObtenerNombreProductoPorId(nombreProducto)
    End Function

    ' Metodo para obtener el precio total de los venta items.
    Public Function ObtenerVentaItemsConPrecioTotal() As List(Of VentaItem)

        Dim ventaItems As List(Of VentaItem) = ventaItemDAL.ObtenerVentaItemsConPrecioTotal()

        If ventaItems Is Nothing OrElse ventaItems.Count = 0 Then
            Return New List(Of VentaItem)()
        End If

        Return ventaItems
    End Function

    ' Metodo para verificar si un venta item existe por su id.
    Public Function VentaItemExistePorId(idVentaItem As Integer) As Boolean
        ' Validación: El ID debe ser mayor que 0
        If idVentaItem <= 0 Then
            Throw New ArgumentException("El id del detalle de venta debe ser mayor que 0.")
        End If

        Return ventaItemDAL.VentaItemExistePorId(idVentaItem)
    End Function

    ' Metodo para obtener venta item por id de venta.
    Public Function ObtenerUnaListaDeVentaItemsPorId(idVenta As Integer) As List(Of VentaItem)
        Return ventaItemDAL.ObtenerVentaItemsPorIdVenta(idVenta)
    End Function
End Class
