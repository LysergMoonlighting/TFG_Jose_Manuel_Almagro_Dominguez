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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
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
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(23, 77)
        Me.user.Margin = New System.Windows.Forms.Padding(2)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(171, 20)
        Me.user.TabIndex = 3
        '
        'pasw
        '
        Me.pasw.Location = New System.Drawing.Point(23, 135)
        Me.pasw.Margin = New System.Windows.Forms.Padding(2)
        Me.pasw.Name = "pasw"
        Me.pasw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pasw.Size = New System.Drawing.Size(171, 20)
        Me.pasw.TabIndex = 4
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(23, 206)
        Me.email.Margin = New System.Windows.Forms.Padding(2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(171, 20)
        Me.email.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 292)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(379, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emailchek
        '
        Me.emailchek.Location = New System.Drawing.Point(232, 206)
        Me.emailchek.Margin = New System.Windows.Forms.Padding(2)
        Me.emailchek.Name = "emailchek"
        Me.emailchek.Size = New System.Drawing.Size(171, 20)
        Me.emailchek.TabIndex = 7
        '
        'passwchek
        '
        Me.passwchek.Location = New System.Drawing.Point(232, 135)
        Me.passwchek.Margin = New System.Windows.Forms.Padding(2)
        Me.passwchek.Name = "passwchek"
        Me.passwchek.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwchek.Size = New System.Drawing.Size(171, 20)
        Me.passwchek.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Repite Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Repite Contraseña"
        '
        'Errorlabel
        '
        Me.Errorlabel.AutoSize = True
        Me.Errorlabel.Location = New System.Drawing.Point(21, 257)
        Me.Errorlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Errorlabel.Name = "Errorlabel"
        Me.Errorlabel.Size = New System.Drawing.Size(0, 13)
        Me.Errorlabel.TabIndex = 11
        '
        'usererror
        '
        Me.usererror.AutoSize = True
        Me.usererror.Location = New System.Drawing.Point(230, 77)
        Me.usererror.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.usererror.Name = "usererror"
        Me.usererror.Size = New System.Drawing.Size(0, 13)
        Me.usererror.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, -2)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(337, 55)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Crear Usuario"
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 387)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Registrar"
        Me.Text = "Crear Usuario"
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
