<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraDeImpuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularMontoInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularTasaDeInteresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularElNumeroDeAñosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularElMontoFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularMontoActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularMontoFuturoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularPeriodoDeTiempoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De Interes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 44)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Financiero"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(415, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraDeImpuestoToolStripMenuItem, Me.CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(564, 36)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraDeImpuestoToolStripMenuItem
        '
        Me.CalculadoraDeImpuestoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularMontoInicialToolStripMenuItem, Me.CalcularTasaDeInteresToolStripMenuItem, Me.CalcularElNumeroDeAñosToolStripMenuItem, Me.CalcularElMontoFinalToolStripMenuItem})
        Me.CalculadoraDeImpuestoToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculadoraDeImpuestoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalculadoraDeImpuestoToolStripMenuItem.Name = "CalculadoraDeImpuestoToolStripMenuItem"
        Me.CalculadoraDeImpuestoToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.CalculadoraDeImpuestoToolStripMenuItem.Text = "Interes Compuesto"
        '
        'CalcularMontoInicialToolStripMenuItem
        '
        Me.CalcularMontoInicialToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularMontoInicialToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularMontoInicialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularMontoInicialToolStripMenuItem.Name = "CalcularMontoInicialToolStripMenuItem"
        Me.CalcularMontoInicialToolStripMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.CalcularMontoInicialToolStripMenuItem.Text = "Calcular Monto Inicial"
        '
        'CalcularTasaDeInteresToolStripMenuItem
        '
        Me.CalcularTasaDeInteresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularTasaDeInteresToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularTasaDeInteresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularTasaDeInteresToolStripMenuItem.Name = "CalcularTasaDeInteresToolStripMenuItem"
        Me.CalcularTasaDeInteresToolStripMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.CalcularTasaDeInteresToolStripMenuItem.Text = "Calcular Tasa De Interes"
        '
        'CalcularElNumeroDeAñosToolStripMenuItem
        '
        Me.CalcularElNumeroDeAñosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularElNumeroDeAñosToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularElNumeroDeAñosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularElNumeroDeAñosToolStripMenuItem.Name = "CalcularElNumeroDeAñosToolStripMenuItem"
        Me.CalcularElNumeroDeAñosToolStripMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.CalcularElNumeroDeAñosToolStripMenuItem.Text = "Calcular El Numero De años"
        '
        'CalcularElMontoFinalToolStripMenuItem
        '
        Me.CalcularElMontoFinalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularElMontoFinalToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularElMontoFinalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularElMontoFinalToolStripMenuItem.Name = "CalcularElMontoFinalToolStripMenuItem"
        Me.CalcularElMontoFinalToolStripMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.CalcularElMontoFinalToolStripMenuItem.Text = "Calcular El Monto Final"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularMontoActualToolStripMenuItem, Me.CalcularMontoFuturoToolStripMenuItem, Me.CalcularToolStripMenuItem, Me.CalcularPeriodoDeTiempoToolStripMenuItem})
        Me.CToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.CToolStripMenuItem.Text = "Interes Simple"
        '
        'CalcularMontoActualToolStripMenuItem
        '
        Me.CalcularMontoActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularMontoActualToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularMontoActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularMontoActualToolStripMenuItem.Name = "CalcularMontoActualToolStripMenuItem"
        Me.CalcularMontoActualToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.CalcularMontoActualToolStripMenuItem.Text = "Calcular Monto Actual"
        '
        'CalcularMontoFuturoToolStripMenuItem
        '
        Me.CalcularMontoFuturoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularMontoFuturoToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularMontoFuturoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularMontoFuturoToolStripMenuItem.Name = "CalcularMontoFuturoToolStripMenuItem"
        Me.CalcularMontoFuturoToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.CalcularMontoFuturoToolStripMenuItem.Text = "Calcular Monto Futuro"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.CalcularToolStripMenuItem.Text = "Calcular Tasa de interes"
        '
        'CalcularPeriodoDeTiempoToolStripMenuItem
        '
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.Name = "CalcularPeriodoDeTiempoToolStripMenuItem"
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.CalcularPeriodoDeTiempoToolStripMenuItem.Text = "Calcular Periodo De Tiempo"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(564, 321)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculadoraDeImpuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularMontoInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularTasaDeInteresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularElNumeroDeAñosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularElMontoFinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularMontoActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularMontoFuturoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularPeriodoDeTiempoToolStripMenuItem As ToolStripMenuItem
End Class
