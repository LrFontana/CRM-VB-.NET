Imports System
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class VentaDAL
    Private dbConnection As New DbConnection()

    ' Agregar venta.
    Public Function AgregarVenta(venta As Venta) As Integer
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO ventas (Fecha, Total, IDCliente) OUTPUT INSERTED.ID VALUES (@Fecha, @Total, @IDCliente)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.Parameters.AddWithValue("@IDCliente", venta.IDCliente)

                ConnectionDb.Open()

                Try
                    Dim idVenta As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    Debug.WriteLine("ID de venta creada: " & idVenta)

                    Return idVenta
                Catch ex As Exception
                    Debug.WriteLine("Error en la inserción de la venta: " & ex.Message)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    ' Obtener todos las ventas.
    Public Function ObtenerTodosLasVentas() As List(Of Venta)
        Dim ventas As New List(Of Venta)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM ventas"

            Using cmd As New SqlCommand(query, ConnectionDb)
                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim venta As New Venta() With {
                        .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        .IDCliente = reader.GetInt32(reader.GetOrdinal("IDCliente")),
                        .Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                        .Total = reader.GetDouble(reader.GetOrdinal("Total"))
                    }

                        ventas.Add(venta)
                    End While
                End Using
            End Using
        End Using
        Return ventas
    End Function

    ' Obtener venta por id.
    Public Function ObtenerVentaPorId(ventaId As Integer) As Venta
        Dim venta As New Venta()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM ventas WHERE ID = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", ventaId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        venta.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        venta.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        venta.Total = reader.GetDouble(reader.GetOrdinal("Total"))
                        venta.IDCliente = reader.GetInt32(reader.GetOrdinal("IDCliente"))
                    End If
                End Using
            End Using
        End Using

        Return venta
    End Function

    ' Obtener venta por nombre cliente.
    Public Function ObtenerVentasPorClienteNombre(nombre As String) As List(Of Venta)
        Dim ventas As New List(Of Venta)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT v.ID, v.Fecha, v.Total, v.IDCliente 
                               FROM ventas v
                               INNER JOIN clientes c ON v.IDCliente = c.ID
                               WHERE c.Cliente = @Nombre"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim venta As New Venta()
                        venta.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        venta.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        venta.Total = reader.GetDouble(reader.GetOrdinal("Total"))
                        venta.IDCliente = reader.GetInt32(reader.GetOrdinal("IDCliente"))
                        ventas.Add(venta)
                    End While
                End Using
            End Using
        End Using

        Return ventas
    End Function

    ' Obtener venta por correo cliente.
    Public Function ObtenerVentaPorClienteCorreo(correo As String) As List(Of Venta)
        Dim ventas As New List(Of Venta)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT v.ID, v.Fecha, v.Total, v.IDCliente 
                               FROM ventas v
                               INNER JOIN clientes c ON v.IDCliente = c.ID
                               WHERE c.Cliente = @Correo"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Correo", correo)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim venta As New Venta()
                        venta.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        venta.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                        venta.Total = reader.GetDouble(reader.GetOrdinal("Total"))
                        venta.IDCliente = reader.GetInt32(reader.GetOrdinal("IDCliente"))
                        ventas.Add(venta)
                    End While
                End Using
            End Using
        End Using

        Return ventas
    End Function

    ' Actualizar venta.
    Public Sub ActualizarVenta(venta As Venta)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE ventas SET fecha = @Fecha, total = @Total, idCliente = @IDCliente WHERE ID = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.Parameters.AddWithValue("@IDCliente", venta.IDCliente)
                cmd.Parameters.AddWithValue("@ID", venta.ID)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar Venta.
    Public Function EliminarVenta(ventaId As Integer) As Boolean
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM ventas WHERE Id = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", ventaId)

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

    ' Metodo para calcular el total de la venta sumando los precios de los VentaItems.
    Public Function CalcularTotalVenta(idVenta As Integer) As Double
        Dim total As Double = 0

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()

            Dim query As String = "SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @IDVenta"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@IDVenta", idVenta)

                ConnectionDb.Open()

                ' Ejecutamos la consulta y obtenemos el resultado.
                total = Convert.ToDouble(cmd.ExecuteScalar())
            End Using
        End Using

        Return total
    End Function

    ' Verifica si la venta existe.
    Public Function VentaExiste(idVenta As Integer) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM ventas WHERE ID = @ID"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@ID", idVenta)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Obtiene el total de una venta por id.
    Public Function ObtenerTotalDeVenta(idVenta As Integer) As Double
        Dim total As Double = 0

        Using connection As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @IDVenta"

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@IDVenta", idVenta)

                connection.Open()
                Dim result = cmd.ExecuteScalar()

                If result IsNot DBNull.Value Then
                    total = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        Return total
    End Function

    ' Obtener detalle de venta.
    Public Function ObtenerDetalleVenta(idVenta As Integer) As DataTable
        Dim query As String = "
        SELECT 
            v.ID AS IdVenta,
            c.Nombre AS Cliente,
            v.Fecha,
            p.Nombre AS Producto,
            vi.Cantidad,
            vi.PrecioUnitario,
            (vi.Cantidad * vi.PrecioUnitario) AS Importe
        FROM ventas v
        INNER JOIN clientes c ON v.IDCliente = c.ID
        INNER JOIN ventasitems vi ON v.ID = vi.IDVenta
        INNER JOIN productos p ON vi.IDProducto = p.ID
        WHERE v.ID = @IdVenta"

        Using conn As SqlConnection = dbConnection.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdVenta", idVenta)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
End Class
