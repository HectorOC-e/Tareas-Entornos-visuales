<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula_Cuadratica
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formula_Cuadratica))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtValorx2 = New System.Windows.Forms.TextBox()
        Me.txtValorx = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtResultado2 = New System.Windows.Forms.TextBox()
        Me.btnSalirTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtResultado1 = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenuPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarAlMenuPrincipalToolStripMenuItem
        '
        Me.RegresarAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarAlMenuPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Name = "RegresarAlMenuPrincipalToolStripMenuItem"
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(297, 32)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Text = "Regresar al menu principal"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtValorx2
        '
        Me.txtValorx2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorx2.Location = New System.Drawing.Point(28, 107)
        Me.txtValorx2.Name = "txtValorx2"
        Me.txtValorx2.Size = New System.Drawing.Size(77, 30)
        Me.txtValorx2.TabIndex = 2
        '
        'txtValorx
        '
        Me.txtValorx.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorx.Location = New System.Drawing.Point(172, 108)
        Me.txtValorx.Name = "txtValorx"
        Me.txtValorx.Size = New System.Drawing.Size(72, 30)
        Me.txtValorx.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(308, 107)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(85, 30)
        Me.txtValor.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(51, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 54)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cálculo con fórmula cuadrática"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(111, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(250, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(190, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ax   +  bx  +  c  =  0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(410, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "= 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtValorx2)
        Me.GroupBox1.Controls.Add(Me.txtValorx)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(60, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 164)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(129, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(220, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "2"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Transparent
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnCalcular.FlatAppearance.BorderSize = 2
        Me.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(513, 60)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(110, 55)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtResultado2)
        Me.GroupBox2.Controls.Add(Me.btnSalirTodo)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.txtResultado1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Location = New System.Drawing.Point(60, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 168)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(41, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 28)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(23, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 34)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(41, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 28)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(23, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 34)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "x"
        '
        'txtResultado2
        '
        Me.txtResultado2.Enabled = False
        Me.txtResultado2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado2.ForeColor = System.Drawing.Color.Aqua
        Me.txtResultado2.Location = New System.Drawing.Point(74, 102)
        Me.txtResultado2.Multiline = True
        Me.txtResultado2.Name = "txtResultado2"
        Me.txtResultado2.Size = New System.Drawing.Size(245, 49)
        Me.txtResultado2.TabIndex = 15
        '
        'btnSalirTodo
        '
        Me.btnSalirTodo.BackColor = System.Drawing.Color.Transparent
        Me.btnSalirTodo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSalirTodo.FlatAppearance.BorderSize = 2
        Me.btnSalirTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSalirTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirTodo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirTodo.Location = New System.Drawing.Point(513, 65)
        Me.btnSalirTodo.Name = "btnSalirTodo"
        Me.btnSalirTodo.Size = New System.Drawing.Size(100, 55)
        Me.btnSalirTodo.TabIndex = 14
        Me.btnSalirTodo.Text = "Salir todo"
        Me.btnSalirTodo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(354, 65)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 55)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtResultado1
        '
        Me.txtResultado1.Enabled = False
        Me.txtResultado1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado1.ForeColor = System.Drawing.Color.Aqua
        Me.txtResultado1.Location = New System.Drawing.Point(74, 38)
        Me.txtResultado1.Multiline = True
        Me.txtResultado1.Name = "txtResultado1"
        Me.txtResultado1.Size = New System.Drawing.Size(245, 49)
        Me.txtResultado1.TabIndex = 12
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Formula_Cuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 517)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formula_Cuadratica"
        Me.Text = "Formula_Cuadratica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtValorx2 As TextBox
    Friend WithEvents txtValorx As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalirTodo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtResultado1 As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtResultado2 As TextBox
End Class
