Imports Microsoft.VisualBasic
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DbConnection
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
