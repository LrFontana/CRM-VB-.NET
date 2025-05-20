Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient

Public Class ProductoDAL

    Private dbConnection As New DbConnection()

    ' Agregar producto.
    Public Sub AgregarProducto(producto As Producto)
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO Productos (nombre, precio, categoria) VALUES (@Nombre, @Precio, @Categoria)"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
                cmd.Parameters.AddWithValue("@Precio", producto.Precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)

                connectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener Producto por id.
    Public Function ObtenerProductoPorId(productoId As Long) As Producto
        Dim producto As New Producto()

        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM Productos WHERE ID = @Id"
            connectionDb.Open()

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Id", productoId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        producto.Id = reader.GetInt64(reader.GetOrdinal("Id"))
                        producto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        producto.Precio = reader.GetDecimal(reader.GetOrdinal("Precio"))
                        producto.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                    End If
                End Using
            End Using
        End Using

        Return producto
    End Function

    ' Actualizar producto.
    Public Sub ActualizarProducto(producto As Producto)
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE Productos SET nombre = @Nombre, precio = @Precio, categoria = @Categoria WHERE ID = @Id"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
                cmd.Parameters.AddWithValue("@Precio", producto.Precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)
                cmd.Parameters.AddWithValue("@Id", producto.Id)

                connectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar producto.
    Public Sub EliminarProducto(productoId As Long)
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM Productos WHERE ID = @Id"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Id", productoId)

                connectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Verifica si el producto existe.
    Public Function ProductoExiste(nombre As String) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM Productos WHERE Nombre = @Nombre"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

End Class
