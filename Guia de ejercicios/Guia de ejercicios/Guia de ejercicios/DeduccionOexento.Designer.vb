<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeduccionOexento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeduccionOexento))
        Me.RegresarAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalarioNeto = New System.Windows.Forms.TextBox()
        Me.txtEXoDED = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalirtodo = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegresarAlMenuPrincipalToolStripMenuItem
        '
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarAlMenuPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Name = "RegresarAlMenuPrincipalToolStripMenuItem"
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(253, 27)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Text = "Regresar al menu principal"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenuPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtSalario)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(11, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculo Salario Exento o Deduccion"
        '
        'txtSalario
        '
        Me.txtSalario.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalario.ForeColor = System.Drawing.Color.Gold
        Me.txtSalario.Location = New System.Drawing.Point(63, 59)
        Me.txtSalario.Multiline = True
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(122, 42)
        Me.txtSalario.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSalarioNeto)
        Me.GroupBox2.Controls.Add(Me.txtEXoDED)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 160)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salario  a Recibir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Salario Neto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 69)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Exento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deduduccion"
        '
        'txtSalarioNeto
        '
        Me.txtSalarioNeto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSalarioNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalarioNeto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSalarioNeto.ForeColor = System.Drawing.Color.Gold
        Me.txtSalarioNeto.Location = New System.Drawing.Point(337, 89)
        Me.txtSalarioNeto.Multiline = True
        Me.txtSalarioNeto.Name = "txtSalarioNeto"
        Me.txtSalarioNeto.ReadOnly = True
        Me.txtSalarioNeto.Size = New System.Drawing.Size(111, 35)
        Me.txtSalarioNeto.TabIndex = 3
        '
        'txtEXoDED
        '
        Me.txtEXoDED.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtEXoDED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEXoDED.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtEXoDED.ForeColor = System.Drawing.Color.Gold
        Me.txtEXoDED.Location = New System.Drawing.Point(147, 33)
        Me.txtEXoDED.Multiline = True
        Me.txtEXoDED.Name = "txtEXoDED"
        Me.txtEXoDED.ReadOnly = True
        Me.txtEXoDED.Size = New System.Drawing.Size(119, 109)
        Me.txtEXoDED.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.Gold
        Me.btnCalcular.Location = New System.Drawing.Point(340, 60)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(120, 43)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Gold
        Me.btnLimpiar.Location = New System.Drawing.Point(340, 137)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(120, 42)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalirtodo
        '
        Me.btnSalirtodo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalirtodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalirtodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalirtodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btnSalirtodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirtodo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirtodo.ForeColor = System.Drawing.Color.Gold
        Me.btnSalirtodo.Location = New System.Drawing.Point(202, 380)
        Me.btnSalirtodo.Name = "btnSalirtodo"
        Me.btnSalirtodo.Size = New System.Drawing.Size(135, 36)
        Me.btnSalirtodo.TabIndex = 5
        Me.btnSalirtodo.Text = "Salir Todo"
        Me.btnSalirtodo.UseVisualStyleBackColor = False
        '
        'DeduccionOexento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 439)
        Me.Controls.Add(Me.btnSalirtodo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DeduccionOexento"
        Me.Text = "Salario a recibir"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegresarAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalarioNeto As TextBox
    Friend WithEvents txtEXoDED As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalirtodo As Button
End Class
