<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnSiete = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMasMenos = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalirTodo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarHistorial = New System.Windows.Forms.Button()
        Me.lstbHistorial = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtResultado.Enabled = False
        Me.txtResultado.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.Color.Black
        Me.txtResultado.Location = New System.Drawing.Point(18, 32)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtResultado.Size = New System.Drawing.Size(410, 87)
        Me.txtResultado.TabIndex = 0
        '
        'btnCuatro
        '
        Me.btnCuatro.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCuatro.Location = New System.Drawing.Point(18, 269)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(64, 42)
        Me.btnCuatro.TabIndex = 4
        Me.btnCuatro.Text = "4"
        Me.btnCuatro.UseVisualStyleBackColor = False
        '
        'btnSiete
        '
        Me.btnSiete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSiete.Location = New System.Drawing.Point(18, 210)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(64, 42)
        Me.btnSiete.TabIndex = 3
        Me.btnSiete.Text = "7"
        Me.btnSiete.UseVisualStyleBackColor = False
        '
        'btnCero
        '
        Me.btnCero.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCero.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCero.Location = New System.Drawing.Point(18, 386)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(154, 42)
        Me.btnCero.TabIndex = 6
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = False
        '
        'btnUno
        '
        Me.btnUno.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUno.Location = New System.Drawing.Point(18, 327)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(64, 42)
        Me.btnUno.TabIndex = 5
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = False
        '
        'btnDos
        '
        Me.btnDos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDos.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(108, 327)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(64, 42)
        Me.btnDos.TabIndex = 11
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = False
        '
        'btnCinco
        '
        Me.btnCinco.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCinco.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(108, 269)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(64, 42)
        Me.btnCinco.TabIndex = 10
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(108, 210)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 42)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "8"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'btnPunto
        '
        Me.btnPunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPunto.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.Location = New System.Drawing.Point(198, 386)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(64, 42)
        Me.btnPunto.TabIndex = 18
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = False
        '
        'btnTres
        '
        Me.btnTres.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTres.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(198, 327)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(64, 42)
        Me.btnTres.TabIndex = 17
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = False
        '
        'btnSeis
        '
        Me.btnSeis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeis.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(198, 269)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(64, 42)
        Me.btnSeis.TabIndex = 16
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(198, 210)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(64, 42)
        Me.Button16.TabIndex = 15
        Me.Button16.Text = "9"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(283, 149)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(145, 42)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSuma.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(283, 386)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(64, 42)
        Me.btnSuma.TabIndex = 24
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResta.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(364, 269)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(64, 42)
        Me.btnResta.TabIndex = 23
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(283, 269)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(64, 42)
        Me.btnMultiplicacion.TabIndex = 22
        Me.btnMultiplicacion.Text = "*"
        Me.btnMultiplicacion.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDivision.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(283, 210)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(64, 42)
        Me.btnDivision.TabIndex = 21
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnMasMenos
        '
        Me.btnMasMenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasMenos.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasMenos.Location = New System.Drawing.Point(283, 327)
        Me.btnMasMenos.Name = "btnMasMenos"
        Me.btnMasMenos.Size = New System.Drawing.Size(64, 42)
        Me.btnMasMenos.TabIndex = 20
        Me.btnMasMenos.Text = "+/-"
        Me.btnMasMenos.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.Color.DarkOrange
        Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIgual.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(364, 327)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(64, 101)
        Me.btnIgual.TabIndex = 29
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btnRaiz
        '
        Me.btnRaiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaiz.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaiz.Location = New System.Drawing.Point(364, 210)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(64, 42)
        Me.btnRaiz.TabIndex = 26
        Me.btnRaiz.Text = "√"
        Me.btnRaiz.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.SalirTodo)
        Me.GroupBox1.Controls.Add(Me.btnIgual)
        Me.GroupBox1.Controls.Add(Me.txtResultado)
        Me.GroupBox1.Controls.Add(Me.btnRaiz)
        Me.GroupBox1.Controls.Add(Me.btnSuma)
        Me.GroupBox1.Controls.Add(Me.btnSiete)
        Me.GroupBox1.Controls.Add(Me.btnResta)
        Me.GroupBox1.Controls.Add(Me.btnCuatro)
        Me.GroupBox1.Controls.Add(Me.btnMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.btnUno)
        Me.GroupBox1.Controls.Add(Me.btnDivision)
        Me.GroupBox1.Controls.Add(Me.btnCero)
        Me.GroupBox1.Controls.Add(Me.btnMasMenos)
        Me.GroupBox1.Controls.Add(Me.btnPunto)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.btnTres)
        Me.GroupBox1.Controls.Add(Me.btnCinco)
        Me.GroupBox1.Controls.Add(Me.btnSeis)
        Me.GroupBox1.Controls.Add(Me.btnDos)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 444)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcu 2.0"
        '
        'SalirTodo
        '
        Me.SalirTodo.BackColor = System.Drawing.Color.DarkRed
        Me.SalirTodo.BackgroundImage = CType(resources.GetObject("SalirTodo.BackgroundImage"), System.Drawing.Image)
        Me.SalirTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SalirTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalirTodo.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirTodo.Location = New System.Drawing.Point(18, 149)
        Me.SalirTodo.Name = "SalirTodo"
        Me.SalirTodo.Size = New System.Drawing.Size(154, 41)
        Me.SalirTodo.TabIndex = 30
        Me.SalirTodo.Text = "Salir Todo"
        Me.SalirTodo.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenuPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 31)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarAlMenuPrincipalToolStripMenuItem
        '
        Me.RegresarAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RegresarAlMenuPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.Brown
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Name = "RegresarAlMenuPrincipalToolStripMenuItem"
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(253, 27)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Text = "Regresar al menu principal"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnLimpiarHistorial)
        Me.GroupBox2.Controls.Add(Me.lstbHistorial)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(506, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 443)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial"
        '
        'btnLimpiarHistorial
        '
        Me.btnLimpiarHistorial.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpiarHistorial.BackgroundImage = CType(resources.GetObject("btnLimpiarHistorial.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiarHistorial.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarHistorial.Location = New System.Drawing.Point(93, 371)
        Me.btnLimpiarHistorial.Name = "btnLimpiarHistorial"
        Me.btnLimpiarHistorial.Size = New System.Drawing.Size(131, 57)
        Me.btnLimpiarHistorial.TabIndex = 1
        Me.btnLimpiarHistorial.Text = "Limpiar Historial"
        Me.btnLimpiarHistorial.UseVisualStyleBackColor = False
        '
        'lstbHistorial
        '
        Me.lstbHistorial.BackColor = System.Drawing.Color.Black
        Me.lstbHistorial.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbHistorial.ForeColor = System.Drawing.Color.Aqua
        Me.lstbHistorial.FormattingEnabled = True
        Me.lstbHistorial.ItemHeight = 26
        Me.lstbHistorial.Location = New System.Drawing.Point(22, 25)
        Me.lstbHistorial.Name = "lstbHistorial"
        Me.lstbHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstbHistorial.Size = New System.Drawing.Size(263, 316)
        Me.lstbHistorial.TabIndex = 0
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(834, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnCuatro As Button
    Friend WithEvents btnSiete As Button
    Friend WithEvents btnCero As Button
    Friend WithEvents btnUno As Button
    Friend WithEvents btnDos As Button
    Friend WithEvents btnCinco As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents btnSeis As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMasMenos As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SalirTodo As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiarHistorial As Button
    Friend WithEvents lstbHistorial As ListBox
End Class
