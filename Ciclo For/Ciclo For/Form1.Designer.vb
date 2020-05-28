<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFinTabla = New System.Windows.Forms.TextBox()
        Me.txtValorTabla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProceso = New System.Windows.Forms.Button()
        Me.lstDato = New System.Windows.Forms.ListBox()
        Me.lstX = New System.Windows.Forms.ListBox()
        Me.lstMultiplo = New System.Windows.Forms.ListBox()
        Me.lstResultado = New System.Windows.Forms.ListBox()
        Me.lstIgual = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnProceso)
        Me.GroupBox1.Controls.Add(Me.txtFinTabla)
        Me.GroupBox1.Controls.Add(Me.txtValorTabla)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(26, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos para calcular"
        '
        'txtFinTabla
        '
        Me.txtFinTabla.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFinTabla.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinTabla.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFinTabla.Location = New System.Drawing.Point(6, 192)
        Me.txtFinTabla.Name = "txtFinTabla"
        Me.txtFinTabla.Size = New System.Drawing.Size(157, 25)
        Me.txtFinTabla.TabIndex = 7
        '
        'txtValorTabla
        '
        Me.txtValorTabla.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtValorTabla.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTabla.ForeColor = System.Drawing.SystemColors.Window
        Me.txtValorTabla.Location = New System.Drawing.Point(8, 108)
        Me.txtValorTabla.Name = "txtValorTabla"
        Me.txtValorTabla.Size = New System.Drawing.Size(157, 25)
        Me.txtValorTabla.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(5, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingrese el fin de la tabla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(5, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese el numero de la tabla"
        '
        'btnProceso
        '
        Me.btnProceso.BackColor = System.Drawing.Color.DimGray
        Me.btnProceso.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceso.Location = New System.Drawing.Point(29, 239)
        Me.btnProceso.Name = "btnProceso"
        Me.btnProceso.Size = New System.Drawing.Size(218, 46)
        Me.btnProceso.TabIndex = 1
        Me.btnProceso.Text = "Consultar Tabla"
        Me.btnProceso.UseVisualStyleBackColor = False
        '
        'lstDato
        '
        Me.lstDato.BackColor = System.Drawing.Color.DimGray
        Me.lstDato.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDato.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstDato.FormattingEnabled = True
        Me.lstDato.ItemHeight = 18
        Me.lstDato.Location = New System.Drawing.Point(421, 59)
        Me.lstDato.Name = "lstDato"
        Me.lstDato.Size = New System.Drawing.Size(63, 292)
        Me.lstDato.TabIndex = 1
        '
        'lstX
        '
        Me.lstX.BackColor = System.Drawing.Color.DimGray
        Me.lstX.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstX.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstX.FormattingEnabled = True
        Me.lstX.ItemHeight = 18
        Me.lstX.Location = New System.Drawing.Point(490, 59)
        Me.lstX.Name = "lstX"
        Me.lstX.Size = New System.Drawing.Size(41, 292)
        Me.lstX.TabIndex = 2
        '
        'lstMultiplo
        '
        Me.lstMultiplo.BackColor = System.Drawing.Color.DimGray
        Me.lstMultiplo.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMultiplo.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstMultiplo.FormattingEnabled = True
        Me.lstMultiplo.ItemHeight = 18
        Me.lstMultiplo.Location = New System.Drawing.Point(537, 59)
        Me.lstMultiplo.Name = "lstMultiplo"
        Me.lstMultiplo.Size = New System.Drawing.Size(63, 292)
        Me.lstMultiplo.TabIndex = 3
        '
        'lstResultado
        '
        Me.lstResultado.BackColor = System.Drawing.Color.DimGray
        Me.lstResultado.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResultado.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstResultado.FormattingEnabled = True
        Me.lstResultado.ItemHeight = 18
        Me.lstResultado.Location = New System.Drawing.Point(644, 59)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(108, 292)
        Me.lstResultado.TabIndex = 4
        '
        'lstIgual
        '
        Me.lstIgual.BackColor = System.Drawing.Color.DimGray
        Me.lstIgual.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIgual.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstIgual.FormattingEnabled = True
        Me.lstIgual.ItemHeight = 18
        Me.lstIgual.Location = New System.Drawing.Point(606, 59)
        Me.lstIgual.Name = "lstIgual"
        Me.lstIgual.Size = New System.Drawing.Size(32, 292)
        Me.lstIgual.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(179, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(434, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Calculadora de tablas de multiplicar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(660, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(780, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstIgual)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.lstMultiplo)
        Me.Controls.Add(Me.lstX)
        Me.Controls.Add(Me.lstDato)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Tablas de Multiplicar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFinTabla As TextBox
    Friend WithEvents txtValorTabla As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProceso As Button
    Friend WithEvents lstDato As ListBox
    Friend WithEvents lstX As ListBox
    Friend WithEvents lstMultiplo As ListBox
    Friend WithEvents lstResultado As ListBox
    Friend WithEvents lstIgual As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
