<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosJugador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosJugador))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvPersonajes = New System.Windows.Forms.DataGridView()
        Me.btCrear = New System.Windows.Forms.Button()
        Me.Entrar = New System.Windows.Forms.Button()
        Me.recargar = New System.Windows.Forms.Button()
        Me.Desconectar = New System.Windows.Forms.Button()
        Me.BttEliminarCharacter = New System.Windows.Forms.Button()
        Me.EliminarCuenta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvPersonajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvPersonajes, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btCrear, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Entrar, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.recargar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Desconectar, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BttEliminarCharacter, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.EliminarCuenta, 1, 8)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgvPersonajes
        '
        Me.dgvPersonajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPersonajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPersonajes.Location = New System.Drawing.Point(43, 92)
        Me.dgvPersonajes.Name = "dgvPersonajes"
        Me.TableLayoutPanel1.SetRowSpan(Me.dgvPersonajes, 5)
        Me.dgvPersonajes.Size = New System.Drawing.Size(514, 329)
        Me.dgvPersonajes.TabIndex = 1
        '
        'btCrear
        '
        Me.btCrear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btCrear.Location = New System.Drawing.Point(603, 92)
        Me.btCrear.Name = "btCrear"
        Me.btCrear.Size = New System.Drawing.Size(154, 61)
        Me.btCrear.TabIndex = 2
        Me.btCrear.Text = "Crear Personaje"
        Me.btCrear.UseVisualStyleBackColor = True
        '
        'Entrar
        '
        Me.Entrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Entrar.Location = New System.Drawing.Point(603, 360)
        Me.Entrar.Name = "Entrar"
        Me.Entrar.Size = New System.Drawing.Size(154, 61)
        Me.Entrar.TabIndex = 4
        Me.Entrar.Text = "Entrar"
        Me.Entrar.UseVisualStyleBackColor = True
        '
        'recargar
        '
        Me.recargar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recargar.Image = CType(resources.GetObject("recargar.Image"), System.Drawing.Image)
        Me.recargar.Location = New System.Drawing.Point(3, 25)
        Me.recargar.Name = "recargar"
        Me.recargar.Size = New System.Drawing.Size(34, 39)
        Me.recargar.TabIndex = 5
        Me.recargar.UseVisualStyleBackColor = True
        '
        'Desconectar
        '
        Me.Desconectar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Desconectar.Image = CType(resources.GetObject("Desconectar.Image"), System.Drawing.Image)
        Me.Desconectar.Location = New System.Drawing.Point(563, 25)
        Me.Desconectar.Name = "Desconectar"
        Me.Desconectar.Size = New System.Drawing.Size(34, 39)
        Me.Desconectar.TabIndex = 11
        Me.Desconectar.UseVisualStyleBackColor = True
        '
        'BttEliminarCharacter
        '
        Me.BttEliminarCharacter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BttEliminarCharacter.Location = New System.Drawing.Point(603, 226)
        Me.BttEliminarCharacter.Name = "BttEliminarCharacter"
        Me.BttEliminarCharacter.Size = New System.Drawing.Size(154, 61)
        Me.BttEliminarCharacter.TabIndex = 12
        Me.BttEliminarCharacter.Text = "Eliminar Personaje"
        Me.BttEliminarCharacter.UseVisualStyleBackColor = True
        '
        'EliminarCuenta
        '
        Me.EliminarCuenta.Location = New System.Drawing.Point(43, 427)
        Me.EliminarCuenta.Name = "EliminarCuenta"
        Me.EliminarCuenta.Size = New System.Drawing.Size(131, 20)
        Me.EliminarCuenta.TabIndex = 13
        Me.EliminarCuenta.Text = "Eliminar cuenta"
        Me.EliminarCuenta.UseVisualStyleBackColor = True
        '
        'DatosJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DatosJugador"
        Me.Text = "Form2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvPersonajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvPersonajes As DataGridView
    Friend WithEvents btCrear As Button
    Friend WithEvents Entrar As Button
    Friend WithEvents recargar As Button
    Friend WithEvents Desconectar As Button
    Friend WithEvents BttEliminarCharacter As Button
    Friend WithEvents EliminarCuenta As Button
End Class
