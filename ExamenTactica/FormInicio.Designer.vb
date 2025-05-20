<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.Button_Ingresar = New System.Windows.Forms.Button()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Ingresar
        '
        Me.Button_Ingresar.BackColor = System.Drawing.Color.Transparent
        Me.Button_Ingresar.FlatAppearance.BorderSize = 0
        Me.Button_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ingresar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ingresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Ingresar.Location = New System.Drawing.Point(128, 311)
        Me.Button_Ingresar.Name = "Button_Ingresar"
        Me.Button_Ingresar.Size = New System.Drawing.Size(132, 49)
        Me.Button_Ingresar.TabIndex = 0
        Me.Button_Ingresar.Text = "Ingresar"
        Me.Button_Ingresar.UseVisualStyleBackColor = False
        '
        'Button_Salir
        '
        Me.Button_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Button_Salir.FlatAppearance.BorderSize = 0
        Me.Button_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Salir.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Salir.Location = New System.Drawing.Point(321, 311)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(126, 49)
        Me.Button_Salir.TabIndex = 0
        Me.Button_Salir.Text = "Salir"
        Me.Button_Salir.UseVisualStyleBackColor = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.Button_Ingresar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Ingresar As Button
    Friend WithEvents Button_Salir As Button
End Class
