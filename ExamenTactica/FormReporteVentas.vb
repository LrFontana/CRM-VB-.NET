Imports Microsoft.Office.Interop

Public Class FormReporteVentas

    Private ventaBLL As New VentaBLL()

    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    ' Evento para generar el reporte.
    Private Sub ButtonGenerarReporte_Click(sender As Object, e As EventArgs) Handles ButtonGenerarReporte.Click
        Try
            Dim idVenta As Integer
            If Not Integer.TryParse(TextBoxIngresarIdVenta.Text.Trim(), idVenta) Then
                MessageBox.Show("Por favor ingrese un ID de venta valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener los datos del reporte desde la BLL
            Dim dt As DataTable = ventaBLL.ObtenerDetalleVenta(idVenta)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron datos para esa venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Crear Excel
            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

            ' Encabezados
            For col As Integer = 0 To dt.Columns.Count - 1
                worksheet.Cells(1, col + 1) = dt.Columns(col).ColumnName
            Next

            ' Filas de datos
            For row As Integer = 0 To dt.Rows.Count - 1
                For col As Integer = 0 To dt.Columns.Count - 1
                    worksheet.Cells(row + 2, col + 1) = dt.Rows(row)(col).ToString()
                Next
            Next

            ' Mostrar Excel
            excelApp.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Pinta el fondo del boton.
    Private Sub Button_Generar_Reporte_Paint(sender As Object, e As PaintEventArgs) Handles ButtonGenerarReporte.Paint
        ButtonGenerarReporte.FlatAppearance.MouseOverBackColor = Panel1.BackColor
        ButtonGenerarReporte.FlatAppearance.MouseDownBackColor = Panel1.BackColor
    End Sub

    Private Sub Button_Generar_Reporte_MouseEnter(sender As Object, e As EventArgs) Handles ButtonGenerarReporte.MouseEnter
        ButtonGenerarReporte.ForeColor = Color.DarkGreen
    End Sub

    Private Sub Button_Generar_Reporte_MouseLeave(sender As Object, e As EventArgs) Handles ButtonGenerarReporte.MouseLeave
        ButtonGenerarReporte.ForeColor = Color.Black
    End Sub

    ' Evento picture box volver.
    Private Sub PictureBox_Volver_Click(sender As Object, e As EventArgs) Handles PictureBoxVolver.Click

        Me.Hide()

        Dim formPrincipal As New FormPrincipal()
        formPrincipal.Show()
    End Sub

    ' Evento picture box cerrar.
    Private Sub PictureBox_Cerrar_Click(sender As Object, e As EventArgs) Handles PictureBoxCerrar.Click

        MessageBox.Show("Gracias por utilizarnos, ¡vuelva pronto!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub
End Class