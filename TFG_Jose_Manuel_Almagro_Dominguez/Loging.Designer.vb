<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loging))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pasw = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.ButtonEntrar = New System.Windows.Forms.Button()
        Me.ButtonRegistrar = New System.Windows.Forms.Button()
        Me.logingerrorText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonEntrar, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRegistrar, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.logingerrorText, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.69231!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.173077!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.173077!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.173077!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.807693!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.173077!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.807693!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(799, 622)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.pasw, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(201, 411)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(393, 44)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'pasw
        '
        Me.pasw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pasw.Location = New System.Drawing.Point(2, 19)
        Me.pasw.Margin = New System.Windows.Forms.Padding(2)
        Me.pasw.Name = "pasw"
        Me.pasw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pasw.Size = New System.Drawing.Size(389, 20)
        Me.pasw.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(201, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 352)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.user, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(201, 361)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(393, 44)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'user
        '
        Me.user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.user.Location = New System.Drawing.Point(2, 19)
        Me.user.Margin = New System.Windows.Forms.Padding(2)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(389, 20)
        Me.user.TabIndex = 8
        '
        'ButtonEntrar
        '
        Me.ButtonEntrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonEntrar.Location = New System.Drawing.Point(201, 461)
        Me.ButtonEntrar.Name = "ButtonEntrar"
        Me.ButtonEntrar.Size = New System.Drawing.Size(393, 44)
        Me.ButtonEntrar.TabIndex = 8
        Me.ButtonEntrar.Text = "Entrar"
        Me.ButtonEntrar.UseVisualStyleBackColor = True
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRegistrar.Location = New System.Drawing.Point(201, 540)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(393, 44)
        Me.ButtonRegistrar.TabIndex = 9
        Me.ButtonRegistrar.Text = "Registrarse"
        Me.ButtonRegistrar.UseVisualStyleBackColor = True
        '
        'logingerrorText
        '
        Me.logingerrorText.AutoSize = True
        Me.logingerrorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.logingerrorText.ForeColor = System.Drawing.Color.Red
        Me.logingerrorText.Location = New System.Drawing.Point(201, 508)
        Me.logingerrorText.Name = "logingerrorText"
        Me.logingerrorText.Size = New System.Drawing.Size(0, 20)
        Me.logingerrorText.TabIndex = 10
        '
        'Loging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 622)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loging"
        Me.Text = "Tales of Veridiam"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents pasw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents ButtonEntrar As Button
    Friend WithEvents ButtonRegistrar As Button
    Friend WithEvents logingerrorText As Label
End Class
