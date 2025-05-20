Imports Microsoft.VisualBasic
Imports System

Namespace ExamenTactica.BLL
    Public Class ClienteBLL
        Private clienteDAL As New ClienteDAL()

        ' Metodos.
        ' Metodo para agregar un cliente.
        Public Function AgregarCliente(cliente As Cliente) As String
            If String.IsNullOrEmpty(cliente.Nombre) OrElse
               String.IsNullOrEmpty(cliente.Telefono) OrElse
               String.IsNullOrEmpty(cliente.Correo) Then
                Return "Todos los campos son obligatorios."
            End If

            If clienteDAL.ClienteExiste(cliente.Nombre, cliente.Correo) Then
                Return "El cliente que desea agregar ya existe."
            End If

            clienteDAL.AgregarCliente(cliente)
            Return "El cliente ha sido agregado con exito."
        End Function

        ' Metodo para obtener el cliente por id.
        Public Function ObtenerClientePorId(id As Long) As Cliente
            If id <= 0 Then
                Throw New ArgumentException("El id del cliente no es correcto.")
            End If
            Return clienteDAL.ObtenerClientePorId(id)
        End Function

        ' Metodo para obtener el cliente por nombre.
        Public Function BuscarClientePorNombre(nombre As String) As Cliente
            If String.IsNullOrEmpty(nombre) Then
                Throw New ArgumentException("El nombre del cliente no es valido.")
            End If
            Return clienteDAL.ObtenerClientePorNombre(nombre)
        End Function

        ' Metodo para actualizar el cliente.
        Public Function ActualizarCliente(cliente As Cliente) As String
            If cliente.Id <= 0 Then
                Return "El id del cliente no es correcto"
            End If

            If String.IsNullOrEmpty(cliente.Nombre) OrElse
               String.IsNullOrEmpty(cliente.Telefono) OrElse
               String.IsNullOrEmpty(cliente.Correo) Then
                Return "Todos los campos son obligatorios."
            End If

            clienteDAL.ActualizarCliente(cliente)
            Return "El cliente ha asido actualizado con exito."
        End Function

        ' Metodo para eliminar un cliente.
        Public Function EliminarCliente(id As Long) As String
            If id <= 0 Then
                Return "El id del cliente es incorrecto."
            End If

            clienteDAL.EliminarCliente(id)
            Return "El cliente ha sido eliminado con exito."
        End Function
    End Class
End Namespace
