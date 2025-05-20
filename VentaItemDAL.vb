Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class VentaItemDAL
    Private dbConnection As New DbConnection()

    ' Agregar ventaItem.
    Public Sub AgregarVentaItem(ventaItem As VentaItem)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO VentasItems (idventa, idproducto, preciounitario, cantidad, preciototal) VALUES (@IdVenta, @IdProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IdVenta", ventaItem.IdVenta)
                cmd.Parameters.AddWithValue("@IdProducto", ventaItem.IdProducto)
                cmd.Parameters.AddWithValue("@PrecioUnitario", ventaItem.PrecioUnitario)
                cmd.Parameters.AddWithValue("@Cantidad", ventaItem.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", ventaItem.PrecioTotal)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener ventaItems por id.
    Public Function ObtenerVentaItemsPorId(ventaId As Long) As List(Of VentaItem)
        Dim listaVentaItems As New List(Of VentaItem)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM VentasItems WHERE idventa = @IdVenta"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IdVenta", ventaId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ventaItem As New VentaItem()
                        ventaItem.Id = reader.GetInt64(reader.GetOrdinal("Id"))
                        ventaItem.IdVenta = reader.GetInt64(reader.GetOrdinal("IdVenta"))
                        ventaItem.IdProducto = reader.GetInt64(reader.GetOrdinal("IdProducto"))
                        ventaItem.PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PrecioUnitario"))
                        ventaItem.Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                        ventaItem.PrecioTotal = reader.GetDecimal(reader.GetOrdinal("PrecioTotal"))
                        listaVentaItems.Add(ventaItem)
                    End While
                End Using
            End Using
        End Using

        Return listaVentaItems
    End Function

    ' Actualizar ventaItem.
    Public Sub ActualizarVentaItem(ventaItem As VentaItem)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE VentasItems SET idventa = @IdVenta, idproducto = @IdProducto, preciounitario = @PrecioUnitario, cantidad = @Cantidad, preciototal = @PrecioTotal WHERE id = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IdVenta", ventaItem.IdVenta)
                cmd.Parameters.AddWithValue("@IdProducto", ventaItem.IdProducto)
                cmd.Parameters.AddWithValue("@PrecioUnitario", ventaItem.PrecioUnitario)
                cmd.Parameters.AddWithValue("@Cantidad", ventaItem.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", ventaItem.PrecioTotal)
                cmd.Parameters.AddWithValue("@Id", ventaItem.Id)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar VentaItem.
    Public Sub EliminarVentaItem(ventaItemId As Long)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM VentasItems WHERE id = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Id", ventaItemId)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Verifica si la ventaItem existe.
    Public Function VentaItemExiste(idVenta As Long, idProducto As Long) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM VentasItems WHERE IdVenta = @IdVenta AND IdProducto = @IdProducto"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@IdVenta", idVenta)
                cmd.Parameters.AddWithValue("@IdProducto", idProducto)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

End Class
