Imports System
Imports Microsoft.VisualBasic

Public Class VentaDAL
    Private dbConnection As New DbConnection()

    ' Agregar venta.
    Public Sub AgregarVenta(venta As Venta)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO Ventas (fecha, total, idCliente) VALUES (@Fecha, @Total, @IdCliente)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener venta por id.
    Public Function ObtenerVentaPorId(ventaId As Long) As Venta
        Dim venta As New Venta()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM Ventas WHERE ID = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Id", ventaId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        venta.Id = reader.GetInt64(reader.GetOrdinal("Id"))
                        venta.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        venta.Total = reader.GetDecimal(reader.GetOrdinal("Total"))
                        venta.ClienteId = reader.GetInt64(reader.GetOrdinal("IdCliente"))
                    End If
                End Using
            End Using
        End Using

        Return venta
    End Function

    ' Actualizar venta.
    Public Sub ActualizarVenta(venta As Venta)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE Ventas SET fecha = @Fecha, total = @Total, idCliente = @IdCliente WHERE ID = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente)
                cmd.Parameters.AddWithValue("@Id", venta.Id)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar venta.
    Public Sub EliminarVenta(ventaId As Long)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM Ventas WHERE ID = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Id", ventaId)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Verifica si la venta existe.
    Public Function VentaExiste(idVenta As Long) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM Ventas WHERE ID = @IdVenta"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@IdVenta", idVenta)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Class
