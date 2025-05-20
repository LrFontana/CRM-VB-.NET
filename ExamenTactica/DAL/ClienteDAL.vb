Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient

Public Class ClienteDAL

    Private dbConnection As New DbConnection()

    ' Metodos.
    ' Agregar Cliente.
    Public Sub AgregarCliente(cliente As Cliente)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO clientes (cliente, telefono, correo) VALUES (@Cliente, @Telefono, @Correo)"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Cliente", cliente.Cliente)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener todos los clientes.
    Public Function ObtenerTodosLosClientes() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)()

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM clientes"

            Using cmd As New SqlCommand(query, ConnectionDb)
                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Cliente() With {
                        .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        .Cliente = reader.GetString(reader.GetOrdinal("Cliente")),
                        .Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                        .Correo = reader.GetString(reader.GetOrdinal("Correo"))
                    }

                        clientes.Add(cliente)
                    End While
                End Using
            End Using
        End Using
        Return clientes
    End Function

    ' Obtener Cliente por id.
    Public Function ObtenerClientePorId(clienteId As Integer) As Cliente
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM clientes WHERE Id = @ID"
            Dim cliente As New Cliente()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", clienteId)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cliente.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        cliente.Cliente = reader.GetString(reader.GetOrdinal("Cliente"))
                        cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                        cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"))
                    End If
                End Using
            End Using
            Return cliente
        End Using
    End Function

    ' Obtener Cliente por nombre.
    Public Function ObtenerClientePorNombre(nombre As String) As Cliente
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT * FROM clientes WHERE Cliente = @Cliente"
            Dim cliente As New Cliente()

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Cliente", nombre)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cliente.ID = reader.GetInt32(reader.GetOrdinal("ID"))
                        cliente.Cliente = reader.GetString(reader.GetOrdinal("Cliente"))
                        cliente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                        cliente.Correo = reader.GetString(reader.GetOrdinal("Correo"))
                    End If
                End Using
            End Using
            Return cliente
        End Using
    End Function

    ' Obtener nombre cliente por id.
    Public Function ObtenerNombreClientePorId(id As Integer) As String
        Dim nombreCliente As String = String.Empty
        Dim query As String = "SELECT Cliente FROM clientes WHERE ID = @ID"

        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", id)

                ConnectionDb.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        nombreCliente = reader.GetString(reader.GetOrdinal("Cliente"))
                    End If
                End Using
            End Using
        End Using

        Return nombreCliente
    End Function

    ' Actualizar Cliente.
    Public Sub ActualizarCliente(cliente As Cliente)
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "UPDATE clientes SET cliente = @Cliente, telefono = @Telefono, correo = @Correo WHERE Id = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@Cliente", cliente.Cliente)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)
                cmd.Parameters.AddWithValue("@ID", cliente.ID)

                ConnectionDb.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar Cliente.
    Public Function EliminarCliente(clienteId As Integer) As Boolean
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "DELETE FROM clientes WHERE Id = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", clienteId)

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

    ' Verifica si el cliente existe.
    Public Function ClienteExiste(correo As String) As Boolean
        Using connectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM clientes WHERE Correo = @Correo"

            Using cmd As New SqlCommand(query, connectionDb)
                cmd.Parameters.AddWithValue("@Correo", correo)

                connectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Verifica si el cliente existe por id.
    Public Function ClienteExistePorId(idCliente As Integer) As Boolean
        Using ConnectionDb As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM clientes WHERE ID = @ID"

            Using cmd As New SqlCommand(query, ConnectionDb)
                cmd.Parameters.AddWithValue("@ID", idCliente)

                ConnectionDb.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Depuración: Verificar el valor de count
                Debug.WriteLine("ClienteExistePorId: IDCliente = " & idCliente & " - Count: " & count)

                Return count > 0
            End Using
        End Using
    End Function
End Class
