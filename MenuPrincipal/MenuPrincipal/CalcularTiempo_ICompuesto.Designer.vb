<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularTiempo_ICompuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcularTiempo_ICompuesto))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAños = New System.Windows.Forms.TextBox()
        Me.txtMontoInicial = New System.Windows.Forms.TextBox()
        Me.txtMontoFinal = New System.Windows.Forms.TextBox()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "%"
        '
        'txtAños
        '
        Me.txtAños.Enabled = False
        Me.txtAños.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAños.Location = New System.Drawing.Point(271, 235)
        Me.txtAños.Name = "txtAños"
        Me.txtAños.Size = New System.Drawing.Size(100, 34)
        Me.txtAños.TabIndex = 36
        '
        'txtMontoInicial
        '
        Me.txtMontoInicial.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoInicial.Location = New System.Drawing.Point(271, 92)
        Me.txtMontoInicial.Name = "txtMontoInicial"
        Me.txtMontoInicial.Size = New System.Drawing.Size(100, 34)
        Me.txtMontoInicial.TabIndex = 35
        '
        'txtMontoFinal
        '
        Me.txtMontoFinal.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoFinal.Location = New System.Drawing.Point(271, 184)
        Me.txtMontoFinal.Name = "txtMontoFinal"
        Me.txtMontoFinal.Size = New System.Drawing.Size(100, 34)
        Me.txtMontoFinal.TabIndex = 34
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteres.Location = New System.Drawing.Point(271, 137)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.Size = New System.Drawing.Size(100, 34)
        Me.txtTasaInteres.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Calculo Del Tiempo"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(101, 389)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(234, 68)
        Me.btnMenu.TabIndex = 31
        Me.btnMenu.Text = "Regresar al menu principal"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Tomato
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(271, 317)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 39)
        Me.btnLimpiar.TabIndex = 30
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Tomato
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(58, 317)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(109, 39)
        Me.btnCalcular.TabIndex = 29
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 28)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Monto Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 28)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Numero De Años"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 28)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "El Monto Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 28)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "La Tasa de Interes es: "
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'CalcularTiempo_ICompuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(430, 480)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAños)
        Me.Controls.Add(Me.txtMontoInicial)
        Me.Controls.Add(Me.txtMontoFinal)
        Me.Controls.Add(Me.txtTasaInteres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalcularTiempo_ICompuesto"
        Me.Text = "CalcularTiempo"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtAños As TextBox
    Friend WithEvents txtMontoInicial As TextBox
    Friend WithEvents txtMontoFinal As TextBox
    Friend WithEvents txtTasaInteres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
