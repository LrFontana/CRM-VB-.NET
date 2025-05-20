Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class VentaBLL

    Private ventaDAL As New VentaDAL()
    Private ventaItemDAL As New VentaItemDAL()
    Private clienteDAL As New ClienteDAL()

    ' Metodo para agregar una venta.
    Public Function AgregarVenta(idCliente As Long, productos As List(Of VentaItem)) As String

        If clienteDAL.ClienteExiste(idCliente) = False Then
            Return "El cliente no existe."
        End If

        ' Calcula el total de la venta.
        Dim total As Single = 0
        For Each ventaItem In productos
            total += ventaItem.PrecioTotal
        Next

        ' Crear la venta.
        Dim nuevaVenta As New Venta() With {
            .idCliente = idCliente,
            .Fecha = DateTime.Now,
            .total = total
        }

        ventaDAL.AgregarVenta(nuevaVenta)

        ' agregar los productos (VentaItems) relacionados con la venta.
        For Each ventaItem In productos
            ventaItem.IdVenta = nuevaVenta.Id
            ventaItemDAL.AgregarVentaItem(ventaItem)
        Next

        Return "La venta ha sido agregada con exito."
    End Function

    ' Metodo para actualizar una venta.
    Public Function ActualizarVenta(venta As Venta) As String

        If ventaDAL.ObtenerVentaPorId(venta.Id) Is Nothing Then
            Return "La venta no existe."
        End If


        ventaDAL.ActualizarVenta(venta)
        Return "La venta ha sido actualizada con exito."
    End Function

    ' Metodo para obtener una venta por id.
    Public Function ObtenerVentaPorId(id As Long) As Venta

        Dim venta As Venta = ventaDAL.ObtenerVentaPorId(id)
        If venta Is Nothing Then
            Throw New ArgumentException("La venta no existe.")
        End If

        Return venta
    End Function

    ' Metodo para eliminar una venta.
    Public Function EliminarVenta(id As Long) As String

        If ventaDAL.ObtenerVentaPorId(id) Is Nothing Then
            Return "La venta no existe."
        End If


        ventaDAL.EliminarVenta(id)

        ' Eliminar los elementos asociados a la venta (si los hay).
        Dim ventaItems As List(Of VentaItem) = ventaItemDAL.ObtenerVentaItemsPorIdVenta(id)
        For Each item In ventaItems
            ventaItemDAL.EliminarVentaItem(item.Id)
        Next

        Return "La venta ha sido eliminada con exito."
    End Function
End Class
