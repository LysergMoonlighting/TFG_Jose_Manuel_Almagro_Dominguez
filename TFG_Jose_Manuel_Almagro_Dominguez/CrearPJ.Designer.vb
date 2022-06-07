<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearPJ
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbRace = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbcharacterName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbRace, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbcharacterName, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(677, 191)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbRace
        '
        Me.cbRace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbRace.FormattingEnabled = True
        Me.cbRace.Location = New System.Drawing.Point(373, 79)
        Me.cbRace.Name = "cbRace"
        Me.cbRace.Size = New System.Drawing.Size(230, 33)
        Me.cbRace.TabIndex = 0
        '
        'Button1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Button1, 3)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(70, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(533, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "!Crear Personaje¡"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbcharacterName
        '
        Me.tbcharacterName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcharacterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.tbcharacterName.Location = New System.Drawing.Point(70, 79)
        Me.tbcharacterName.Name = "tbcharacterName"
        Me.tbcharacterName.Size = New System.Drawing.Size(230, 31)
        Me.tbcharacterName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Raza"
        '
        'CrearPJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 191)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CrearPJ"
        Me.Text = "Form3"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbRace As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbcharacterName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
