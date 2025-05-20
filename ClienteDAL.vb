Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient

Public Class ClienteDAL

    Private dbConnection As New DbConnection()

    ' Metodos.
    ' Agregar Cliente.
    Public Sub AgregarCliente(cliente As Cliente)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO Cliente (cliente, telefono, correo) VALUES (@Cliente, @Telefono, @Correo)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Cliente", cliente.Nombre)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener Cliente por id.
    Public Function obtenerClientePorId(clienteId As Long) As Cliente
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM Cliente WHERE Id = @Id"
            Dim cliente As New Cliente()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Id", clienteId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cliente.Id = reader.GetInt64(reader.GetOrdinal("Id"))
                        cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                        cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"))
                    End If
                End Using
            End Using
            Return cliente
        End Using
    End Function

    ' Obtener Cliente por nombre.
    Public Function obtenerClientePorNombre(nombre As String) As Cliente
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM Cliente WHERE Nombre = @Nombre"
            Dim cliente As New Cliente()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cliente.Id = reader.GetInt64(reader.GetOrdinal("Id"))
                        cliente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                        cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                        cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"))
                    End If
                End Using
            End Using
            Return cliente
        End Using
    End Function

    ' Actualizar Cliente.
    Public Sub ActualizarCliente(cliente As Cliente)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE Cliente SET cliente = @Cliente, telefono = @Telefono, correo = @Correo WHERE Id = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Cliente", cliente.Nombre)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)
                cmd.Parameters.AddWithValue("@Id", cliente.Id)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar Cliente.
    Public Sub EliminarCliente(clienteId As Long)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM Cliente WHERE Id = @Id"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Id", clienteId)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Verifica si el cliente existe.
    Public Function ClienteExiste(nombre As String, correo As String) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE Nombre = @Nombre OR Correo = @Correo"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Correo", correo)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Class
