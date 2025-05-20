Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class VentaBLL

    Private ventaDAL As New VentaDAL()
    Private ventaItemDAL As New VentaItemDAL()
    Private clienteDAL As New ClienteDAL()

    ' Método para agregar una venta
    Public Function AgregarVenta(venta As Venta) As Integer

        If venta.IDCliente <> 0 AndAlso Not clienteDAL.ClienteExiste(venta.IDCliente) Then
            Return -1
        End If

        Dim idVenta As Integer = ventaDAL.AgregarVenta(venta)

        If idVenta > 0 Then
            Return idVenta
        Else
            Return -1
        End If
    End Function

    ' Metodo para obtener todos las ventas.
    Public Function ObtenerTodosLasVentas() As List(Of Venta)
        Return ventaDAL.ObtenerTodosLasVentas()
    End Function

    ' Metodo para actualizar una venta.
    Public Function ActualizarVenta(venta As Venta) As String

        If ventaDAL.ObtenerVentaPorId(venta.ID) Is Nothing Then
            Return "La venta no existe."
        End If

        ventaDAL.ActualizarVenta(venta)
        Return "La venta ha sido actualizada con exito."
    End Function

    ' Metodo para obtener una venta por id.
    Public Function ObtenerVentaPorId(id As Integer) As Venta

        Dim venta As Venta = ventaDAL.ObtenerVentaPorId(id)
        If venta Is Nothing Then
            Throw New ArgumentException("La venta no existe.")
        End If

        Return venta
    End Function

    ' Metodo para obtener una venta por nombre cliente.
    Public Function ObtenerVentaPorClienteNombre(nombre As String) As List(Of Venta)

        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ArgumentException("El nombre del cliente no puede estar vacio.")
        End If

        Dim ventas As List(Of Venta) = ventaDAL.ObtenerVentasPorClienteNombre(nombre)

        If ventas Is Nothing OrElse ventas.Count = 0 Then
            Throw New ArgumentException("No se encontro ninguna venta para el cliente.")
        End If

        Return ventas
    End Function

    ' Metodo para obtener una venta por correo cliente.
    Public Function ObtenerVentaPorClienteCorreo(correo As String) As Venta

        If String.IsNullOrWhiteSpace(correo) Then
            Throw New ArgumentException("El correo del cliente no puede estar vacio.")
        End If

        Dim ventas As List(Of Venta) = ventaDAL.ObtenerVentaPorClienteCorreo(correo)

        If ventas Is Nothing OrElse ventas.Count = 0 Then
            Throw New ArgumentException("No se encontro ninguna venta para el cliente.")
        End If

        Return ventas(0)
    End Function

    ' Metodo para eliminar una venta.
    Public Function EliminarVenta(id As Integer) As Boolean
        If id <= 0 Then
            Return False
        End If

        Dim success As Boolean = ventaDAL.EliminarVenta(id)

        Return success
    End Function

    ' Metodo para calcular el total de la venta.
    Public Function CalcularTotalVenta(idVenta As Integer) As Double

        Return ventaDAL.CalcularTotalVenta(idVenta)

    End Function

    ' Metodo para validar si la venta existe.
    Public Function ValidarProductoExiste(id As Integer) As Boolean

        If String.IsNullOrEmpty(id) Then
            Return False
        End If

        Return ventaDAL.VentaExiste(id)
    End Function

    ' Metodo para validar el nombre.
    Private Function ValidarNombre(nombre As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z\s]+$")
        Return regex.IsMatch(nombre)
    End Function

    ' Metodo para obtener el total de una venta por id.
    Public Function ObtenerTotalDeVenta(idVenta As Integer) As Double
        If idVenta <= 0 Then
            Throw New ArgumentException("El ID de la venta debe ser mayor a cero.")
        End If

        Dim ventaExistente As Venta = ObtenerVentaPorId(idVenta)

        If ventaExistente Is Nothing Then
            Throw New Exception("No se encontró una venta con ese ID.")
        End If

        Return ventaDAL.ObtenerTotalDeVenta(idVenta)
    End Function

    ' Metodo para obtener el detalle de venta.
    Public Function ObtenerDetalleVenta(idVenta As Integer) As DataTable
        If idVenta <= 0 Then Throw New ArgumentException("ID de venta invalido.")
        Return ventaDAL.ObtenerDetalleVenta(idVenta)
    End Function
End Class
