<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cantidadXnumeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cantidadXnumeros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalirtodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSumatotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbNumAcumulados = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalNum = New System.Windows.Forms.TextBox()
        Me.txtImpares = New System.Windows.Forms.TextBox()
        Me.txtPares = New System.Windows.Forms.TextBox()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarAlMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnSalirtodo)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.txtDato)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(82, 257)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(97, 43)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalirtodo
        '
        Me.btnSalirtodo.BackColor = System.Drawing.Color.Transparent
        Me.btnSalirtodo.BackgroundImage = CType(resources.GetObject("btnSalirtodo.BackgroundImage"), System.Drawing.Image)
        Me.btnSalirtodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalirtodo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSalirtodo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnSalirtodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnSalirtodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalirtodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirtodo.Location = New System.Drawing.Point(136, 328)
        Me.btnSalirtodo.Name = "btnSalirtodo"
        Me.btnSalirtodo.Size = New System.Drawing.Size(111, 43)
        Me.btnSalirtodo.TabIndex = 2
        Me.btnSalirtodo.Text = "Salir todo"
        Me.btnSalirtodo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(20, 328)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(97, 43)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtDato
        '
        Me.txtDato.BackColor = System.Drawing.Color.Black
        Me.txtDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDato.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.ForeColor = System.Drawing.Color.Aqua
        Me.txtDato.Location = New System.Drawing.Point(20, 151)
        Me.txtDato.Multiline = True
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(227, 55)
        Me.txtDato.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtSumatotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbNumAcumulados)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTotalNum)
        Me.GroupBox2.Controls.Add(Me.txtImpares)
        Me.GroupBox2.Controls.Add(Me.txtPares)
        Me.GroupBox2.Controls.Add(Me.txtPositivos)
        Me.GroupBox2.Controls.Add(Me.txtNegativos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(387, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 414)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'txtSumatotal
        '
        Me.txtSumatotal.BackColor = System.Drawing.Color.Black
        Me.txtSumatotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSumatotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSumatotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumatotal.ForeColor = System.Drawing.Color.Aqua
        Me.txtSumatotal.Location = New System.Drawing.Point(124, 361)
        Me.txtSumatotal.Name = "txtSumatotal"
        Me.txtSumatotal.ReadOnly = True
        Me.txtSumatotal.Size = New System.Drawing.Size(167, 30)
        Me.txtSumatotal.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Suma Total"
        '
        'cmbNumAcumulados
        '
        Me.cmbNumAcumulados.BackColor = System.Drawing.Color.Black
        Me.cmbNumAcumulados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNumAcumulados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumAcumulados.ForeColor = System.Drawing.Color.Aqua
        Me.cmbNumAcumulados.FormattingEnabled = True
        Me.cmbNumAcumulados.Location = New System.Drawing.Point(40, 52)
        Me.cmbNumAcumulados.Name = "cmbNumAcumulados"
        Me.cmbNumAcumulados.Size = New System.Drawing.Size(238, 31)
        Me.cmbNumAcumulados.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Numeros Acumulados"
        '
        'txtTotalNum
        '
        Me.txtTotalNum.BackColor = System.Drawing.Color.Black
        Me.txtTotalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalNum.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTotalNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNum.ForeColor = System.Drawing.Color.Aqua
        Me.txtTotalNum.Location = New System.Drawing.Point(124, 308)
        Me.txtTotalNum.Name = "txtTotalNum"
        Me.txtTotalNum.ReadOnly = True
        Me.txtTotalNum.Size = New System.Drawing.Size(167, 30)
        Me.txtTotalNum.TabIndex = 8
        '
        'txtImpares
        '
        Me.txtImpares.BackColor = System.Drawing.Color.Black
        Me.txtImpares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpares.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtImpares.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpares.ForeColor = System.Drawing.Color.Aqua
        Me.txtImpares.Location = New System.Drawing.Point(124, 257)
        Me.txtImpares.Name = "txtImpares"
        Me.txtImpares.ReadOnly = True
        Me.txtImpares.Size = New System.Drawing.Size(167, 30)
        Me.txtImpares.TabIndex = 7
        '
        'txtPares
        '
        Me.txtPares.BackColor = System.Drawing.Color.Black
        Me.txtPares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPares.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPares.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPares.ForeColor = System.Drawing.Color.Aqua
        Me.txtPares.Location = New System.Drawing.Point(124, 207)
        Me.txtPares.Name = "txtPares"
        Me.txtPares.ReadOnly = True
        Me.txtPares.Size = New System.Drawing.Size(167, 30)
        Me.txtPares.TabIndex = 6
        '
        'txtPositivos
        '
        Me.txtPositivos.BackColor = System.Drawing.Color.Black
        Me.txtPositivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPositivos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtPositivos.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositivos.ForeColor = System.Drawing.Color.Aqua
        Me.txtPositivos.Location = New System.Drawing.Point(124, 151)
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.ReadOnly = True
        Me.txtPositivos.Size = New System.Drawing.Size(167, 30)
        Me.txtPositivos.TabIndex = 5
        '
        'txtNegativos
        '
        Me.txtNegativos.BackColor = System.Drawing.Color.Black
        Me.txtNegativos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNegativos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNegativos.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNegativos.ForeColor = System.Drawing.Color.Aqua
        Me.txtNegativos.Location = New System.Drawing.Point(124, 102)
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.ReadOnly = True
        Me.txtNegativos.Size = New System.Drawing.Size(167, 30)
        Me.txtNegativos.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Nums."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pares"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Positivos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Negativos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(30, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 66)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calculo numeros negativos, positivos, pares e impares" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       y el total de numer" &
    "os que se va ingresando"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenuPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(739, 31)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarAlMenuPrincipalToolStripMenuItem
        '
        Me.RegresarAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.RegresarAlMenuPrincipalToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RegresarAlMenuPrincipalToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarAlMenuPrincipalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Name = "RegresarAlMenuPrincipalToolStripMenuItem"
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(253, 27)
        Me.RegresarAlMenuPrincipalToolStripMenuItem.Text = "Regresar al menu principal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(16, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(232, 71)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cantidad de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                numeros " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          a  ingresar"
        '
        'cantidadXnumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 586)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cantidadXnumeros"
        Me.Text = "cantidadXnumeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDato As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalirtodo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarAlMenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTotalNum As TextBox
    Friend WithEvents txtImpares As TextBox
    Friend WithEvents txtPares As TextBox
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbNumAcumulados As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSumatotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
