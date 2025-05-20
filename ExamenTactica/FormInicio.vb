Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class FormInicio
    Public Sub New()

        ' Habilita el doble buffer para evitar parpadeos
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        InitializeComponent()
    End Sub

    Private Sub FormInicio_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim imagen As Image = Image.FromFile("C:\Users\leand\source\repos\Examen\imagenFondo.jpg")

        Dim ancho As Integer = Me.ClientSize.Width
        Dim alto As Integer = imagen.Height * (ancho / imagen.Width)

        e.Graphics.DrawImage(imagen, 0, 0, ancho, alto)

        ' Crea un degradado de derecha a izquierda.
        Dim colorInicio As Color = Color.FromArgb(150, Color.Gray)
        Dim colorFin As Color = Color.FromArgb(150, Color.Black)

        ' Crea un LinearGradientBrush con el degradado
        Using brocha As New LinearGradientBrush(New Rectangle(0, 0, ancho, alto), colorInicio, colorFin, LinearGradientMode.Horizontal)

            e.Graphics.FillRectangle(brocha, 0, 0, ancho, alto)
        End Using

    End Sub

    ' Boton ingresar.
    ' Evento cuando el mouse pasa por arriba del boton.
    Private Sub Button_Ingresar_MouseEnter(sender As Object, e As EventArgs) Handles Button_Ingresar.MouseEnter
        Button_Ingresar.BackColor = Color.Black
        Button_Ingresar.ForeColor = Color.White
    End Sub

    Private Sub Button_Ingresar_MouseLeave(sender As Object, e As EventArgs) Handles Button_Ingresar.MouseLeave
        Button_Ingresar.BackColor = Color.Transparent
        Button_Ingresar.ForeColor = Color.Black
    End Sub

    Private Sub Button_Ingresar_Click(sender As Object, e As EventArgs) Handles Button_Ingresar.Click

        Me.Hide()

        Dim formPrincipal As New FormPrincipal()
        formPrincipal.Show()
    End Sub


    ' Boton salir.
    ' Evento cuando el mouse pasa por arriba del boton.
    Private Sub Button_Salir_MouseEnter(sender As Object, e As EventArgs) Handles Button_Salir.MouseEnter
        Button_Salir.BackColor = Color.Black
        Button_Salir.ForeColor = Color.White
    End Sub

    Private Sub Button_Salir_MouseLeave(sender As Object, e As EventArgs) Handles Button_Salir.MouseLeave
        Button_Salir.BackColor = Color.Transparent
        Button_Salir.ForeColor = Color.Black
    End Sub

    ' Cierra el prograba y muestra el mensaje.
    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click

        MessageBox.Show("Gracias por utilizarnos, ¡vuelva pronto!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

End Class
