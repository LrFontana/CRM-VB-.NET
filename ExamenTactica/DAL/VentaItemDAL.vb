Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class VentaItemDAL
    Private dbConnection As New DbConnection()

    ' Agregar ventaItem.
    Public Sub AgregarVentaItem(ventaItem As VentaItem)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IDVenta", ventaItem.IDVenta)
                cmd.Parameters.AddWithValue("@IDProducto", ventaItem.IDProducto)
                cmd.Parameters.AddWithValue("@PrecioUnitario", ventaItem.PrecioUnitario)
                cmd.Parameters.AddWithValue("@Cantidad", ventaItem.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", ventaItem.PrecioTotal)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener todas las ventas items.
    Public Function ObtenerTodasLasVentaItems() As List(Of VentaItem)
        Dim ventaItems As New List(Of VentaItem)()

        Using connectionDb As SqlConnection = dbConnection.GetConnection()

            Dim query As String = "SELECT vi.ID, vi.IDVenta, vi.IDProducto, vi.Cantidad, vi.PrecioUnitario, vi.PrecioTotal, v.IDCliente
                               FROM VentaItems vi
                               INNER JOIN Ventas v ON vi.IDVenta = v.ID
                               INNER JOIN Productos p ON vi.IDProducto = p.ID"

            connectionDb.Open()

            Using cmd As New SqlCommand(query, connectionDb)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()

                        Dim ventaItem As New VentaItem() With {
                        .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        .IDVenta = reader.GetInt32(reader.GetOrdinal("IDVenta")),
                        .IDProducto = reader.GetInt32(reader.GetOrdinal("IDProducto")),
                        .Cantidad = reader.GetDouble(reader.GetOrdinal("Cantidad")),
                        .PrecioUnitario = reader.GetDouble(reader.GetOrdinal("PrecioUnitario")),
                        .PrecioTotal = reader.GetDouble(reader.GetOrdinal("PrecioTotal"))
                    }

                        Dim productoNombre As String = reader.GetString(reader.GetOrdinal("Nombre"))
                        Dim idCliente As String = reader.GetString(reader.GetOrdinal("IDCliente"))

                        ventaItems.Add(ventaItem)
                    End While
                End Using
            End Using
        End Using

        Return ventaItems
    End Function

    'Obtener venta item id.
    Public Function ObtenerVentaItemId(idVentaItem As Integer) As VentaItem
        Dim ventaItem As New VentaItem()
        Try

            Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
                Dim query As String = "SELECT ID, IDProducto, Cantidad, PrecioUnitario, PrecioTotal FROM ventasitems WHERE ID = @ID"

                Using cmd As New SqlCommand(query, ConnectionDb)
                    cmd.Parameters.AddWithValue("@ID", idVentaItem)
                    ConnectionDb.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            ventaItem.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                            ventaItem.IDProducto = reader.GetInt32(reader.GetOrdinal("IDProducto"))
                            ventaItem.Cantidad = reader.GetDouble(reader.GetOrdinal("Cantidad"))
                            ventaItem.PrecioUnitario = reader.GetDouble(reader.GetOrdinal("PrecioUnitario"))
                            ventaItem.PrecioTotal = reader.GetDouble(reader.GetOrdinal("PrecioTotal"))
                        Else
                            ventaItem = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error al obtener el VentaItem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ventaItem
    End Function

    ' Obtener ventaItems por id.
    Public Function ObtenerVentaItemsPorId(ventaId As Integer) As List(Of VentaItem)
        Dim listaVentaItems As New List(Of VentaItem)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM ventasitems WHERE IDVenta = @IDVenta"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IDVenta", ventaId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ventaItem As New VentaItem()
                        ventaItem.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        ventaItem.IDVenta = reader.GetInt32(reader.GetOrdinal("IDVenta"))
                        ventaItem.IDProducto = reader.GetInt32(reader.GetOrdinal("IDProducto"))
                        ventaItem.PrecioUnitario = reader.GetDouble(reader.GetOrdinal("PrecioUnitario"))
                        ventaItem.Cantidad = reader.GetDouble(reader.GetOrdinal("Cantidad"))
                        ventaItem.PrecioTotal = reader.GetDouble(reader.GetOrdinal("PrecioTotal"))
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
            Dim query As String = "UPDATE ventasitems SET IDVenta = @IDVenta,IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE ID = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IDProducto", ventaItem.IDProducto)
                cmd.Parameters.AddWithValue("@IDVenta", ventaItem.IDVenta)
                cmd.Parameters.AddWithValue("@PrecioUnitario", ventaItem.PrecioUnitario)
                cmd.Parameters.AddWithValue("@Cantidad", ventaItem.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", ventaItem.PrecioTotal)
                cmd.Parameters.AddWithValue("@ID", ventaItem.ID)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar VentaItems.
    Public Function EliminarVentaItem(ventaItemId As Integer) As Boolean
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM ventasitems WHERE Id = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", ventaItemId)

                ConnectionDb.Open()
                Dim row As Integer = cmd.ExecuteNonQuery()

                If row > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function

    ' Obtner precio total.
    Public Function ObtenerVentaItemsConPrecioTotal() As List(Of VentaItem)
        Dim ventaItems As New List(Of VentaItem)()

        Using connectionDb As SqlConnection = dbConnection.GetConnection()

            Dim query As String = "SELECT vi.ID, vi.IDProducto, vi.Cantidad, p.PrecioUnitario
                               FROM ventasitems vi
                               INNER JOIN productos p ON vi.IDProducto = p.ID"

            connectionDb.Open()

            Using cmd As New SqlCommand(query, connectionDb)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()

                        Dim ventaItem As New VentaItem() With {
                            .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            .IDProducto = reader.GetInt32(reader.GetOrdinal("IDProducto")),
                            .Cantidad = reader.GetDouble(reader.GetOrdinal("Cantidad"))
                        }

                        Dim precioUnitario As Double = reader.GetDouble(reader.GetOrdinal("PrecioUnitario"))

                        ventaItem.PrecioTotal = ventaItem.Cantidad * precioUnitario

                        ventaItems.Add(ventaItem)
                    End While
                End Using
            End Using
        End Using

        Return ventaItems
    End Function

    ' Verifica si la ventaItem existe.
    Public Function VentaItemExiste(idVenta As Integer, idProducto As Integer) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM ventasitems WHERE IDVenta = @IDVenta AND IDProducto = @IDProducto"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@IDVenta", idVenta)
                cmd.Parameters.AddWithValue("@IDProducto", idProducto)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Metodo para obtener el idCliente por el nombre
    Public Function ObtenerIdClientePorNombre(nombreCliente As String) As Integer
        Try
            Using connectionDb As SqlConnection = dbConnection.GetConnection()
                Dim query As String = "SELECT ID FROM clientes WHERE Cliente = @Cliente"
                Using cmd As New SqlCommand(query, connectionDb)
                    cmd.Parameters.AddWithValue("@Cliente", nombreCliente)
                    connectionDb.Open()
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error al obtener el id del cliente: " & ex.Message)
        End Try

        Return -1
    End Function

    ' Metodo para obtener el IdVenta de un cliente.
    Public Function ObtenerIdVentaDeCliente(clienteID As Integer) As Integer
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT TOP 1 ID FROM ventas WHERE IDCliente = @IDCliente ORDER BY ID DESC"
            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@IDCliente", clienteID)
                connectionDb.Open()
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return -1
    End Function

    ' Metodo para obtener el Id producto por el nombre.
    Public Function ObtenerIDProductoPorNombre(nombreProducto As String) As Integer
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT ID FROM productos WHERE Nombre = @Nombre"
            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombreProducto)
                connectionDb.Open()
                Dim result = cmd.ExecuteScalar()

                ' Valida si el resultado es nulo o no
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return -1
    End Function

    ' Metodo para verificar si un venta item con un id especifico existe.
    Public Function VentaItemExistePorId(idVentaItem As Integer) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM ventasitems WHERE ID = @ID"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@ID", idVentaItem)
                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Obtener venta item por id de venta.
    Public Function ObtenerVentaItemsPorIdVenta(idVenta As Integer) As List(Of VentaItem)
        Dim lista As New List(Of VentaItem)

        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM ventasitems WHERE IDVenta = @IDVenta"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@IDVenta", idVenta)
                connectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New VentaItem With {
                            .ID = Convert.ToInt32(reader("ID")),
                            .IDVenta = Convert.ToInt32(reader("IDVenta")),
                            .IDProducto = Convert.ToInt32(reader("IDProducto")),
                            .Cantidad = Convert.ToInt32(reader("Cantidad")),
                            .PrecioUnitario = Convert.ToDouble(reader("PrecioUnitario")),
                            .PrecioTotal = Convert.ToDouble(reader("PrecioTotal"))
                        }
                        lista.Add(item)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function
End Class
