Imports Microsoft.VisualBasic
Imports System


Public Class ClienteBLL
        Private clienteDAL As New ClienteDAL()

        ' Metodos.
        ' Metodo para agregar un cliente.
        Public Function AgregarCliente(cliente As Cliente) As String
        If String.IsNullOrEmpty(cliente.Cliente) OrElse
               String.IsNullOrEmpty(cliente.Telefono) OrElse
               String.IsNullOrEmpty(cliente.Correo) Then
            Return "Todos los campos son obligatorios."
        End If

        If Not ValidarNombre(cliente.Cliente) Then
            Return "El nombre solo puede contener letras y espacios, sin caracteres especiales ni numeros."
        End If

        If Not ValidarTelefono(cliente.Telefono) Then
            Return "El telefono solo puede contener numeros y debe tener al menos 7 digitos."
        End If

        If Not ValidarCorreo(cliente.Correo) Then
            Return "El correo que desea ingresar no tiene un formato valido."
        End If

        If clienteDAL.ClienteExiste(cliente.Correo) Then
            Return "El cliente que desea agregar ya existe."
        End If

        clienteDAL.AgregarCliente(cliente)
        Return "El cliente ha sido agregado con exito."
    End Function

    ' Metodo para obtener todos los clientes.
    Public Function ObtenerTodosLosClientes() As List(Of Cliente)
        Return clienteDAL.ObtenerTodosLosClientes()
    End Function

    ' Metodo para obtener el cliente por id.
    Public Function ObtenerClientePorId(id As Integer) As Cliente
        If id <= 0 Then
            Throw New ArgumentException("El id del cliente no es correcto.")
        End If
        Return clienteDAL.ObtenerClientePorId(id)
    End Function

    ' Metodo para obtener el cliente por nombre.
    Public Function ObtenerClientePorNombre(nombre As String) As Cliente
        If String.IsNullOrEmpty(nombre) Then
            Throw New ArgumentException("El nombre del cliente no es valido.")
        End If
        Return clienteDAL.ObtenerClientePorNombre(nombre)
    End Function

    ' Metodo para obtener el cliente por nombre por id.
    Public Function ObtenerClienteNombrePorId(id As Integer) As String
        If id <= 0 Then
            Throw New ArgumentException("El id del cliente no es valido.")
        End If

        Return clienteDAL.ObtenerNombreClientePorId(id)
    End Function


    ' Metodo para actualizar el cliente.
    Public Function ActualizarCliente(cliente As Cliente) As String
        If cliente.ID <= 0 Then
            Return "El id del cliente no es correcto"
        End If

        If String.IsNullOrEmpty(cliente.Cliente) OrElse
               String.IsNullOrEmpty(cliente.Telefono) OrElse
               String.IsNullOrEmpty(cliente.Correo) Then
            Return "Todos los campos son obligatorios."
        End If

        clienteDAL.ActualizarCliente(cliente)
            Return "El cliente ha asido actualizado con exito."
        End Function

    ' Metodo para eliminar un cliente.
    Public Function EliminarCliente(id As Integer) As Boolean
        If id <= 0 Then
            Return False
        End If

        Dim success As Boolean = clienteDAL.EliminarCliente(id)

        Return success
    End Function

    ' Metodo para validar el nombre.
    Public Function ValidarNombre(nombre As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z\s]+$")
        Return regex.IsMatch(nombre)
    End Function

    ' Metodo para validar el telefono.
    Public Function ValidarTelefono(telefono As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^[0-9]{7,}$")
        Return regex.IsMatch(telefono)
    End Function

    ' Metodo para validar el correo.
    Public Function ValidarCorreo(correo As String) As Boolean
        Try
            Dim mail As New System.Net.Mail.MailAddress(correo)
            Return True
        Catch
            Return False
        End Try
    End Function

    ' Metodo para validar si el cliente existe.
    Public Function ValidarClienteExiste(nombre As String) As Boolean

        If String.IsNullOrEmpty(nombre) Then
            Return False
        End If

        Return clienteDAL.ClienteExiste(nombre)
    End Function

    ' Metodo para validar si el cliente existe por id. 
    Public Function VerificarClienteExistentePorId(idCliente As Integer) As Boolean
        If idCliente < 0 Then
            Return False
        End If

        Return clienteDAL.ClienteExistePorId(idCliente)
    End Function
End Class

