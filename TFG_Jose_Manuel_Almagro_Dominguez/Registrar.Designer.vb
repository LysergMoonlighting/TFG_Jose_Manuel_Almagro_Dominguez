<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pasw = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.emailchek = New System.Windows.Forms.TextBox()
        Me.passwchek = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Errorlabel = New System.Windows.Forms.Label()
        Me.usererror = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(31, 95)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(227, 22)
        Me.user.TabIndex = 3
        '
        'pasw
        '
        Me.pasw.Location = New System.Drawing.Point(31, 166)
        Me.pasw.Name = "pasw"
        Me.pasw.Size = New System.Drawing.Size(227, 22)
        Me.pasw.TabIndex = 4
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(31, 253)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(227, 22)
        Me.email.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(505, 65)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emailchek
        '
        Me.emailchek.Location = New System.Drawing.Point(309, 253)
        Me.emailchek.Name = "emailchek"
        Me.emailchek.Size = New System.Drawing.Size(227, 22)
        Me.emailchek.TabIndex = 7
        '
        'passwchek
        '
        Me.passwchek.Location = New System.Drawing.Point(309, 166)
        Me.passwchek.Name = "passwchek"
        Me.passwchek.Size = New System.Drawing.Size(227, 22)
        Me.passwchek.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Repite Contraseña"
        '
        'Errorlabel
        '
        Me.Errorlabel.AutoSize = True
        Me.Errorlabel.Location = New System.Drawing.Point(28, 316)
        Me.Errorlabel.Name = "Errorlabel"
        Me.Errorlabel.Size = New System.Drawing.Size(0, 20)
        Me.Errorlabel.TabIndex = 11
        '
        'usererror
        '
        Me.usererror.AutoSize = True
        Me.usererror.Location = New System.Drawing.Point(306, 95)
        Me.usererror.Name = "usererror"
        Me.usererror.Size = New System.Drawing.Size(0, 20)
        Me.usererror.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 69)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Crear Usuario"
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 476)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.usererror)
        Me.Controls.Add(Me.Errorlabel)
        Me.Controls.Add(Me.emailchek)
        Me.Controls.Add(Me.passwchek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.pasw)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrar"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents pasw As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents emailchek As TextBox
    Friend WithEvents passwchek As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Errorlabel As Label
    Friend WithEvents usererror As Label
    Friend WithEvents Label6 As Label
End Class
