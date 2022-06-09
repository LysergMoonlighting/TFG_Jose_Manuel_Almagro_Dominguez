<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Desconectar = New System.Windows.Forms.Button()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cobre = New System.Windows.Forms.Label()
        Me.Plata = New System.Windows.Forms.Label()
        Me.Oro = New System.Windows.Forms.Label()
        Me.Adamantino = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BorrarItem = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.recargar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Desconectar, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvInventario, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 7, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 7, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.recargar, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(977, 597)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Desconectar
        '
        Me.Desconectar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Desconectar.Image = CType(resources.GetObject("Desconectar.Image"), System.Drawing.Image)
        Me.Desconectar.Location = New System.Drawing.Point(696, 32)
        Me.Desconectar.Name = "Desconectar"
        Me.Desconectar.Size = New System.Drawing.Size(42, 105)
        Me.Desconectar.TabIndex = 11
        Me.Desconectar.UseVisualStyleBackColor = True
        '
        'dgvInventario
        '
        Me.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgvInventario, 5)
        Me.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventario.Location = New System.Drawing.Point(51, 172)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.dgvInventario, 5)
        Me.dgvInventario.Size = New System.Drawing.Size(639, 385)
        Me.dgvInventario.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Cobre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Plata, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Oro, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Adamantino, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(744, 172)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(177, 245)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(3, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 62)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Platino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(3, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 61)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Oro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 61)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Plata"
        '
        'Cobre
        '
        Me.Cobre.AutoSize = True
        Me.Cobre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cobre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Cobre.Location = New System.Drawing.Point(91, 0)
        Me.Cobre.Name = "Cobre"
        Me.Cobre.Size = New System.Drawing.Size(83, 61)
        Me.Cobre.TabIndex = 0
        Me.Cobre.Text = "Label1"
        '
        'Plata
        '
        Me.Plata.AutoSize = True
        Me.Plata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Plata.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Plata.Location = New System.Drawing.Point(91, 61)
        Me.Plata.Name = "Plata"
        Me.Plata.Size = New System.Drawing.Size(83, 61)
        Me.Plata.TabIndex = 1
        Me.Plata.Text = "Label1"
        '
        'Oro
        '
        Me.Oro.AutoSize = True
        Me.Oro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Oro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Oro.Location = New System.Drawing.Point(91, 122)
        Me.Oro.Name = "Oro"
        Me.Oro.Size = New System.Drawing.Size(83, 61)
        Me.Oro.TabIndex = 2
        Me.Oro.Text = "Label1"
        '
        'Adamantino
        '
        Me.Adamantino.AutoSize = True
        Me.Adamantino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Adamantino.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Adamantino.Location = New System.Drawing.Point(91, 183)
        Me.Adamantino.Name = "Adamantino"
        Me.Adamantino.Size = New System.Drawing.Size(83, 62)
        Me.Adamantino.TabIndex = 3
        Me.Adamantino.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 61)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cobre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 5)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(639, 111)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Inventario"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BorrarItem, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button2, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(744, 452)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(177, 97)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'BorrarItem
        '
        Me.BorrarItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrarItem.Location = New System.Drawing.Point(3, 3)
        Me.BorrarItem.Name = "BorrarItem"
        Me.BorrarItem.Size = New System.Drawing.Size(171, 37)
        Me.BorrarItem.TabIndex = 0
        Me.BorrarItem.Text = "Borrar"
        Me.BorrarItem.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Añadir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'recargar
        '
        Me.recargar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recargar.Image = CType(resources.GetObject("recargar.Image"), System.Drawing.Image)
        Me.recargar.Location = New System.Drawing.Point(3, 143)
        Me.recargar.Name = "recargar"
        Me.recargar.Size = New System.Drawing.Size(42, 23)
        Me.recargar.TabIndex = 6
        Me.recargar.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 597)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Inventario"
        Me.Text = "Form3"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Cobre As Label
    Friend WithEvents Plata As Label
    Friend WithEvents Oro As Label
    Friend WithEvents Adamantino As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Desconectar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BorrarItem As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents recargar As Button
End Class
