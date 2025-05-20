Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient

Public Class ProductoDAL

    Private dbConnection As New DbConnection()

    ' Agregar producto.
    Public Sub AgregarProducto(producto As Producto)
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO productos (nombre, precio, categoria) VALUES (@Nombre, @Precio, @Categoria)"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
                cmd.Parameters.AddWithValue("@Precio", producto.Precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)

                connectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener todos los prodcutos.
    Public Function ObtenerTodosLosProductos() As List(Of Producto)
        Dim productos As New List(Of Producto)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM productos"

            Using cmd As New SqlCommand(query, ConnectionDb)
                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Producto() With {
                        .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        .Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        .Categoria = reader.GetString(reader.GetOrdinal("Categoria")),
                        .Precio = reader.GetDouble(reader.GetOrdinal("Precio"))
                    }

                        productos.Add(producto)
                    End While
                End Using
            End Using
        End Using
        Return productos
    End Function

    ' Obtener Producto por id.
    Public Function ObtenerProductoPorId(productoId As Integer) As Producto
        Dim producto As New Producto()

        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM productos WHERE ID = @ID"
            connectionDb.Open()

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@ID", productoId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        producto.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        producto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        producto.Precio = reader.GetDouble(reader.GetOrdinal("Precio"))
                        producto.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                    End If
                End Using
            End Using
        End Using

        Return producto
    End Function

    ' Obtener el precio producto por id.
    Public Function ObtenerPrecioPorId(id As Integer) As Decimal
        Dim precio As Decimal = 0

        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT Precio FROM productos WHERE ID = @ID"

            connectionDb.Open()
            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@ID", id)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    precio = Convert.ToDouble(result)
                End If
            End Using
        End Using

        Return precio
    End Function

    ' Obtener producto por nombre.
    Public Function ObtenerProductoPorNombre(nombre As String) As Producto
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM productos WHERE Nombre = @Nombre"
            Dim producto As New Producto()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        producto.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        producto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        producto.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                        producto.Precio = reader.GetDouble(reader.GetOrdinal("Precio"))
                    End If
                End Using
            End Using
            Return producto
        End Using
    End Function

    ' Obtener nombre producto por id.
    Public Function ObtenerNombreProductoPorId(id As Integer) As String
        Dim nombreProducto As String = String.Empty
        Dim query As String = "SELECT Nombre FROM productos WHERE ID = @ID"

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", id)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        nombreProducto = reader.GetString(reader.GetOrdinal("Nombre"))
                    End If
                End Using
            End Using
        End Using

        Return nombreProducto
    End Function

    ' Obtener producto por categoria.
    Public Function ObtenerProductoPorCategoria(categoria As String) As Producto
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM productos WHERE Categoria = @Categoria"
            Dim producto As New Producto()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Categoria", categoria)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        producto.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        producto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        producto.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                        producto.Precio = reader.GetDouble(reader.GetOrdinal("Precio"))
                    End If
                End Using
            End Using
            Return producto
        End Using
    End Function

    ' Actualizar producto.
    Public Sub ActualizarProducto(producto As Producto)
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE productos SET nombre = @Nombre, precio = @Precio, categoria = @Categoria WHERE ID = @ID"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
                cmd.Parameters.AddWithValue("@Precio", producto.Precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)
                cmd.Parameters.AddWithValue("@ID", producto.ID)

                connectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar Producto.
    Public Function EliminarProducto(productoId As Integer) As Boolean
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM productos WHERE Id = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", productoId)

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

    ' Verifica si el producto existe.
    Public Function ProductoExiste(nombre As String) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM productos WHERE Nombre = @Nombre"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Obtener el reporte mensual de productos vendidos.
    Public Function ObtenerReporteMensualProductoPorId(idProducto As Integer) As DataTable
        Dim query As String = "
        SELECT 
            p.Nombre AS Producto,
            FORMAT(v.Fecha, 'yyyy-MM') AS Mes,
            SUM(vi.Cantidad) AS CantidadTotal
        FROM ventasitems vi
        INNER JOIN ventas v ON vi.IDVenta = v.ID
        INNER JOIN productos p ON vi.IDProducto = p.ID
        WHERE p.ID = @IDProducto
        GROUP BY p.Nombre, FORMAT(v.Fecha, 'yyyy-MM')
        ORDER BY Mes, Producto"

        Using conn As SqlConnection = dbConnection.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

End Class
