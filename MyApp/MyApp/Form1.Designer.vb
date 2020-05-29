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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.txtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.cbSuma = New System.Windows.Forms.CheckBox()
        Me.cbResta = New System.Windows.Forms.CheckBox()
        Me.cbRaiz = New System.Windows.Forms.CheckBox()
        Me.cbDivision = New System.Windows.Forms.CheckBox()
        Me.cbMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.cbPotencia = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(51, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(51, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(341, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Multiplicación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(341, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "División"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(42, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Suma"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(43, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Resta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Crimson
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Jokerman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label7.Location = New System.Drawing.Point(188, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 39)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Operaciones Básicas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Crimson
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Jokerman", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(246, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 39)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Resultados"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(168, 94)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(81, 22)
        Me.txtValor1.TabIndex = 9
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(168, 158)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(81, 22)
        Me.txtValor2.TabIndex = 10
        '
        'txtSuma
        '
        Me.txtSuma.BackColor = System.Drawing.Color.White
        Me.txtSuma.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSuma.Enabled = False
        Me.txtSuma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtSuma.Location = New System.Drawing.Point(146, 357)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(81, 22)
        Me.txtSuma.TabIndex = 11
        '
        'txtResta
        '
        Me.txtResta.BackColor = System.Drawing.Color.White
        Me.txtResta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtResta.Enabled = False
        Me.txtResta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtResta.Location = New System.Drawing.Point(146, 409)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(81, 22)
        Me.txtResta.TabIndex = 12
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.Color.White
        Me.txtDivision.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDivision.Enabled = False
        Me.txtDivision.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtDivision.Location = New System.Drawing.Point(521, 360)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(81, 22)
        Me.txtDivision.TabIndex = 13
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.BackColor = System.Drawing.Color.White
        Me.txtMultiplicacion.Cursor = System.Windows.Forms.Cursors.No
        Me.txtMultiplicacion.Enabled = False
        Me.txtMultiplicacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtMultiplicacion.Location = New System.Drawing.Point(521, 412)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(81, 22)
        Me.txtMultiplicacion.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.LightCoral
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.btnCalcular.Location = New System.Drawing.Point(43, 207)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(184, 44)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular!"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Maroon
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Jokerman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(244, 520)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(155, 46)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "SALIR!"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightCoral
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.btnLimpiar.Location = New System.Drawing.Point(431, 207)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(171, 44)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar!"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(43, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 31)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Raiz"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(341, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 31)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Potencia"
        '
        'txtPotencia
        '
        Me.txtPotencia.BackColor = System.Drawing.Color.White
        Me.txtPotencia.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPotencia.Enabled = False
        Me.txtPotencia.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtPotencia.Location = New System.Drawing.Point(521, 471)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.Size = New System.Drawing.Size(81, 22)
        Me.txtPotencia.TabIndex = 20
        '
        'txtRaiz
        '
        Me.txtRaiz.BackColor = System.Drawing.Color.White
        Me.txtRaiz.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRaiz.Enabled = False
        Me.txtRaiz.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtRaiz.Location = New System.Drawing.Point(146, 471)
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.Size = New System.Drawing.Size(81, 22)
        Me.txtRaiz.TabIndex = 21
        '
        'cbSuma
        '
        Me.cbSuma.AutoSize = True
        Me.cbSuma.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbSuma.Location = New System.Drawing.Point(309, 75)
        Me.cbSuma.Name = "cbSuma"
        Me.cbSuma.Size = New System.Drawing.Size(87, 33)
        Me.cbSuma.TabIndex = 22
        Me.cbSuma.Text = "Suma"
        Me.cbSuma.UseVisualStyleBackColor = True
        '
        'cbResta
        '
        Me.cbResta.AutoSize = True
        Me.cbResta.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbResta.Location = New System.Drawing.Point(309, 114)
        Me.cbResta.Name = "cbResta"
        Me.cbResta.Size = New System.Drawing.Size(88, 33)
        Me.cbResta.TabIndex = 23
        Me.cbResta.Text = "Resta"
        Me.cbResta.UseVisualStyleBackColor = True
        '
        'cbRaiz
        '
        Me.cbRaiz.AutoSize = True
        Me.cbRaiz.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbRaiz.Location = New System.Drawing.Point(309, 162)
        Me.cbRaiz.Name = "cbRaiz"
        Me.cbRaiz.Size = New System.Drawing.Size(76, 33)
        Me.cbRaiz.TabIndex = 24
        Me.cbRaiz.Text = "Raíz"
        Me.cbRaiz.UseVisualStyleBackColor = True
        '
        'cbDivision
        '
        Me.cbDivision.AutoSize = True
        Me.cbDivision.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbDivision.Location = New System.Drawing.Point(425, 73)
        Me.cbDivision.Name = "cbDivision"
        Me.cbDivision.Size = New System.Drawing.Size(111, 33)
        Me.cbDivision.TabIndex = 25
        Me.cbDivision.Text = "División"
        Me.cbDivision.UseVisualStyleBackColor = True
        '
        'cbMultiplicacion
        '
        Me.cbMultiplicacion.AutoSize = True
        Me.cbMultiplicacion.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbMultiplicacion.Location = New System.Drawing.Point(425, 114)
        Me.cbMultiplicacion.Name = "cbMultiplicacion"
        Me.cbMultiplicacion.Size = New System.Drawing.Size(174, 33)
        Me.cbMultiplicacion.TabIndex = 26
        Me.cbMultiplicacion.Text = "Multiplicación"
        Me.cbMultiplicacion.UseVisualStyleBackColor = True
        '
        'cbPotencia
        '
        Me.cbPotencia.AutoSize = True
        Me.cbPotencia.Font = New System.Drawing.Font("Jokerman", 12.0!)
        Me.cbPotencia.Location = New System.Drawing.Point(425, 162)
        Me.cbPotencia.Name = "cbPotencia"
        Me.cbPotencia.Size = New System.Drawing.Size(120, 33)
        Me.cbPotencia.TabIndex = 27
        Me.cbPotencia.Text = "Potencia"
        Me.cbPotencia.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(280, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 37)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Validar!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 591)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbPotencia)
        Me.Controls.Add(Me.cbMultiplicacion)
        Me.Controls.Add(Me.cbDivision)
        Me.Controls.Add(Me.cbRaiz)
        Me.Controls.Add(Me.cbResta)
        Me.Controls.Add(Me.cbSuma)
        Me.Controls.Add(Me.txtRaiz)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtMultiplicacion)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculadora Cientifica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents txtMultiplicacion As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPotencia As TextBox
    Friend WithEvents txtRaiz As TextBox
    Friend WithEvents cbSuma As CheckBox
    Friend WithEvents cbResta As CheckBox
    Friend WithEvents cbRaiz As CheckBox
    Friend WithEvents cbDivision As CheckBox
    Friend WithEvents cbMultiplicacion As CheckBox
    Friend WithEvents cbPotencia As CheckBox
    Friend WithEvents Button1 As Button
End Class
