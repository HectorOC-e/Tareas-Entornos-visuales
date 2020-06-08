<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas_de_una_empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas_de_una_empresa))
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMediaVenta = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstVentasSuperiores = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalirTodo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbVentaEmpresa = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Gold
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 375)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 29)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(12, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Media de ventas"
        '
        'txtMediaVenta
        '
        Me.txtMediaVenta.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtMediaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMediaVenta.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMediaVenta.ForeColor = System.Drawing.Color.Gold
        Me.txtMediaVenta.Location = New System.Drawing.Point(143, 169)
        Me.txtMediaVenta.Multiline = True
        Me.txtMediaVenta.Name = "txtMediaVenta"
        Me.txtMediaVenta.Size = New System.Drawing.Size(118, 35)
        Me.txtMediaVenta.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lstVentasSuperiores)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(313, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 355)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas Superiores a la media"
        '
        'lstVentasSuperiores
        '
        Me.lstVentasSuperiores.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lstVentasSuperiores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstVentasSuperiores.ForeColor = System.Drawing.Color.Gold
        Me.lstVentasSuperiores.FormattingEnabled = True
        Me.lstVentasSuperiores.ItemHeight = 20
        Me.lstVentasSuperiores.Location = New System.Drawing.Point(20, 33)
        Me.lstVentasSuperiores.Name = "lstVentasSuperiores"
        Me.lstVentasSuperiores.Size = New System.Drawing.Size(219, 302)
        Me.lstVentasSuperiores.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMediaVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 219)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(79, 80)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 62)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Venta"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(75, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingresar Ventas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenuPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(585, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarAlMenuPrincipalToolStripMenuItem
        '
        Me.RegresarAlMenuPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Name = "RegresarAlMenuPrincipalToolStripMenuItem"
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Text = "Regresar al menu principal"
        '
        'btnSalirTodo
        '
        Me.btnSalirTodo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalirTodo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnSalirTodo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Olive
        Me.btnSalirTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalirTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirTodo.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirTodo.ForeColor = System.Drawing.Color.Gold
        Me.btnSalirTodo.Location = New System.Drawing.Point(187, 363)
        Me.btnSalirTodo.Name = "btnSalirTodo"
        Me.btnSalirTodo.Size = New System.Drawing.Size(100, 41)
        Me.btnSalirTodo.TabIndex = 13
        Me.btnSalirTodo.Text = "Salir Todo"
        Me.btnSalirTodo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(26, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 36)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Empresa  Y  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     ventas"
        '
        'cmbVentaEmpresa
        '
        Me.cmbVentaEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbVentaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVentaEmpresa.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVentaEmpresa.ForeColor = System.Drawing.Color.Yellow
        Me.cmbVentaEmpresa.FormattingEnabled = True
        Me.cmbVentaEmpresa.Location = New System.Drawing.Point(123, 293)
        Me.cmbVentaEmpresa.Name = "cmbVentaEmpresa"
        Me.cmbVentaEmpresa.Size = New System.Drawing.Size(164, 26)
        Me.cmbVentaEmpresa.TabIndex = 15
        '
        'Ventas_de_una_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(585, 434)
        Me.Controls.Add(Me.cmbVentaEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalirTodo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Ventas_de_una_empresa"
        Me.Text = "Ventas_de_una_empresa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMediaVenta As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstVentasSuperiores As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalirTodo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbVentaEmpresa As ComboBox
End Class
