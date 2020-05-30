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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(64, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(64, 189)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(326, 383)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Multiplicación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(326, 314)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "División"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(64, 319)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Suma"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(64, 388)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Resta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label7.Location = New System.Drawing.Point(196, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 30)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Operaciones Básicas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(236, 251)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 30)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Resultados"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(158, 101)
        Me.txtValor1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 27)
        Me.txtValor1.TabIndex = 9
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(158, 184)
        Me.txtValor2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 27)
        Me.txtValor2.TabIndex = 10
        '
        'txtSuma
        '
        Me.txtSuma.BackColor = System.Drawing.Color.White
        Me.txtSuma.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSuma.Enabled = False
        Me.txtSuma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtSuma.Location = New System.Drawing.Point(158, 314)
        Me.txtSuma.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 27)
        Me.txtSuma.TabIndex = 11
        '
        'txtResta
        '
        Me.txtResta.BackColor = System.Drawing.Color.White
        Me.txtResta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtResta.Enabled = False
        Me.txtResta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtResta.Location = New System.Drawing.Point(158, 383)
        Me.txtResta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 27)
        Me.txtResta.TabIndex = 12
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.Color.White
        Me.txtDivision.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDivision.Enabled = False
        Me.txtDivision.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtDivision.Location = New System.Drawing.Point(474, 309)
        Me.txtDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(100, 27)
        Me.txtDivision.TabIndex = 13
        '
        'txtMultiplicacion
        '
        Me.txtMultiplicacion.BackColor = System.Drawing.Color.White
        Me.txtMultiplicacion.Cursor = System.Windows.Forms.Cursors.No
        Me.txtMultiplicacion.Enabled = False
        Me.txtMultiplicacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtMultiplicacion.Location = New System.Drawing.Point(474, 378)
        Me.txtMultiplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMultiplicacion.Name = "txtMultiplicacion"
        Me.txtMultiplicacion.Size = New System.Drawing.Size(100, 27)
        Me.txtMultiplicacion.TabIndex = 14
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Blue
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.Location = New System.Drawing.Point(376, 87)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(104, 41)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular!"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Maroon
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(223, 444)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 40)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "SALIR!"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Blue
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLimpiar.Location = New System.Drawing.Point(449, 170)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 41)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar!"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(310, 180)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Validar!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 497)
        Me.Controls.Add(Me.Button1)
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
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Button1 As Button
End Class
