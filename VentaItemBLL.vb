Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class VentaItemBLL

    Private ventaItemDAL As New VentaItemDAL()
    Private productoDAL As New ProductoDAL()

    ' Metodos.
    ' Metodo para agregar una venta item.
    Public Function AgregarVentaItem(ventaItem As VentaItem) As String

        If productoDAL.ObtenerProductoPorId(ventaItem.Idproducto) Is Nothing Then
            Return "El producto no existe."
        End If

        ' Calcular el PrecioTotal (Cantidad * PrecioUnitario).
        ventaItem.PrecioTotal = ventaItem.Cantidad * ventaItem.PrecioUnitario

        ' Agregar el producto (VentaItem) a la base de datos.
        ventaItemDAL.AgregarVentaItem(ventaItem)
        Return "El producto ha sido agregado a la venta con exito."
    End Function

    ' Metodo para buscar una venta item por id.
    Public Function ObtenerVentaItemsPorIdVenta(idVenta As Long) As List(Of VentaItem)
        ' Obtener todos los productos asociados con una venta específica.
        Return ventaItemDAL.ObtenerVentaItemsPorIdVenta(idVenta)
    End Function

    ' Metodo para actualizar una venta item.
    Public Function ActualizarVentaItem(ventaItem As VentaItem) As String

        If ventaItemDAL.ObtenerVentaItemPorId(ventaItem.Id) Is Nothing Then
            Return "El producto no existe."
        End If

        ' Calcular el PrecioTotal (Cantidad * PrecioUnitario) actualizado.
        ventaItem.PrecioTotal = ventaItem.Cantidad * ventaItem.PrecioUnitario

        ' Actualizar el VentaItem en la base de datos.
        ventaItemDAL.ActualizarVentaItem(ventaItem)
        Return "El producto ha sido actualizado en la venta con exito."
    End Function

    ' Metodo para eliminar una venta item.
    Public Function EliminarVentaItem(id As Long) As String
        ' Verificar si el VentaItem existe.
        If ventaItemDAL.ObtenerVentaItemPorId(id) Is Nothing Then
            Return "El producto no existe."
        End If

        ' Eliminar el VentaItem.
        ventaItemDAL.EliminarVentaItem(id)
        Return "El producto ha sido eliminado de la venta con exito."
    End Function
End Class
