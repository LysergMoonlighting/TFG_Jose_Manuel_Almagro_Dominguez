<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pruebas
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
        Me.Tabla2 = New System.Windows.Forms.DataGridView()
        Me.Tabla1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla2
        '
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.Location = New System.Drawing.Point(659, 154)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.RowHeadersWidth = 51
        Me.Tabla2.RowTemplate.Height = 24
        Me.Tabla2.Size = New System.Drawing.Size(488, 409)
        Me.Tabla2.TabIndex = 0
        '
        'Tabla1
        '
        Me.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1.Location = New System.Drawing.Point(79, 154)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.RowHeadersWidth = 51
        Me.Tabla1.RowTemplate.Height = 24
        Me.Tabla1.Size = New System.Drawing.Size(488, 409)
        Me.Tabla1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 706)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabla1)
        Me.Controls.Add(Me.Tabla2)
        Me.Name = "Pruebas"
        Me.Text = "Form1"
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents Tabla1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
