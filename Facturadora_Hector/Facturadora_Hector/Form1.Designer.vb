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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvalor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.cbbIsv = New System.Windows.Forms.ComboBox()
        Me.cbbDescuento = New System.Windows.Forms.ComboBox()
        Me.chkIsv = New System.Windows.Forms.CheckBox()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIsv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Black
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(415, 349)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(415, 257)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(127, 34)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Facturadora"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.txtvalor2)
        Me.GroupBox1.Controls.Add(Me.txtValor1)
        Me.GroupBox1.Controls.Add(Me.cbbIsv)
        Me.GroupBox1.Controls.Add(Me.cbbDescuento)
        Me.GroupBox1.Controls.Add(Me.chkIsv)
        Me.GroupBox1.Controls.Add(Me.chkDescuento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 360)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'txtvalor2
        '
        Me.txtvalor2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtvalor2.Location = New System.Drawing.Point(142, 113)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(162, 30)
        Me.txtvalor2.TabIndex = 14
        '
        'txtValor1
        '
        Me.txtValor1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtValor1.Location = New System.Drawing.Point(142, 59)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(162, 30)
        Me.txtValor1.TabIndex = 13
        '
        'cbbIsv
        '
        Me.cbbIsv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbIsv.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cbbIsv.FormattingEnabled = True
        Me.cbbIsv.Items.AddRange(New Object() {"15%", "17%"})
        Me.cbbIsv.Location = New System.Drawing.Point(27, 279)
        Me.cbbIsv.Name = "cbbIsv"
        Me.cbbIsv.Size = New System.Drawing.Size(277, 31)
        Me.cbbIsv.TabIndex = 12
        '
        'cbbDescuento
        '
        Me.cbbDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbDescuento.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.cbbDescuento.FormattingEnabled = True
        Me.cbbDescuento.Items.AddRange(New Object() {"15%", "20%", "50%", "70%", "10%", "5%"})
        Me.cbbDescuento.Location = New System.Drawing.Point(27, 200)
        Me.cbbDescuento.Name = "cbbDescuento"
        Me.cbbDescuento.Size = New System.Drawing.Size(277, 31)
        Me.cbbDescuento.TabIndex = 11
        '
        'chkIsv
        '
        Me.chkIsv.AutoSize = True
        Me.chkIsv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkIsv.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.chkIsv.Location = New System.Drawing.Point(27, 246)
        Me.chkIsv.Name = "chkIsv"
        Me.chkIsv.Size = New System.Drawing.Size(131, 27)
        Me.chkIsv.TabIndex = 10
        Me.chkIsv.Text = "Aplicar ISV"
        Me.chkIsv.UseVisualStyleBackColor = True
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDescuento.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.chkDescuento.Location = New System.Drawing.Point(27, 167)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(186, 27)
        Me.chkDescuento.TabIndex = 8
        Me.chkDescuento.Text = "Aplicar Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(23, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "P. Unitario"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIsv)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.Location = New System.Drawing.Point(568, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 360)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Factura"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtTotal.Location = New System.Drawing.Point(159, 272)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(162, 30)
        Me.txtTotal.TabIndex = 22
        '
        'txtIsv
        '
        Me.txtIsv.Enabled = False
        Me.txtIsv.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtIsv.Location = New System.Drawing.Point(159, 209)
        Me.txtIsv.Name = "txtIsv"
        Me.txtIsv.Size = New System.Drawing.Size(162, 30)
        Me.txtIsv.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(59, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ISV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(56, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Total"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtDescuento.Location = New System.Drawing.Point(159, 139)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(162, 30)
        Me.txtDescuento.TabIndex = 18
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtSubtotal.Location = New System.Drawing.Point(159, 76)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(162, 30)
        Me.txtSubtotal.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(56, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(56, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Descuento"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.Black
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalcular.Location = New System.Drawing.Point(415, 164)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(127, 34)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(956, 469)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturadora Pro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtvalor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents cbbIsv As ComboBox
    Friend WithEvents cbbDescuento As ComboBox
    Friend WithEvents chkIsv As CheckBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIsv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Al activar boton salir pues se saldra
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'cuando se active el boton nuevo se limpiara todas las casillas
        txtDescuento.Clear()
        txtIsv.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtValor1.Clear()
        txtvalor2.Clear()
        chkDescuento.Checked = False
        chkIsv.Checked = False
        cbbDescuento.SelectedItem = Nothing
        cbbIsv.SelectedItem = Nothing
        btnNuevo.Enabled = False

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Al activar el boton calcular se hara todo lo siguiente
        'Declaramos las variables a validar
        Dim Valor1 As Double
        Dim Valor2 As Int16
        Dim descuento, subTotal, total, ISV As Double

        'Verificamos si el valor 1 es valido
        'Verificamos que no esten vacias las casillas
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla del Precio Unitario", vbYesNo + vbExclamation, "Mensaje especial")
            'Verificamos que el valor ingresado sea numerico
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Escriba un valor numerico en la casilla del Precio Unitario", vbYesNo + vbExclamation, "Mensaje especial")
            txtValor1.Clear()

            'Verificamos que el valor sea positivo
        ElseIf Val(txtValor1.Text) < 0 Then
            MsgBox("Escriba un valor positivo en la casilla del Precio Unitario", vbYesNo + vbExclamation, "Mensaje especial")
            txtValor1.Clear()

            'Si los valores son numericos entonces
        ElseIf IsNumeric(Valor1) Then
            Valor1 = Val(txtValor1.Text)
        End If

        'Verificamos si el valor 2 es valido
        'Verificamos que no esten vacias las casillas
        If txtvalor2.Text = "" Then
            MsgBox("Escriba un numero en la casilla de Cantidad", vbYesNo + vbExclamation, "Mensaje especial")
            'Verificamos que el valor ingresado sea numerico
        ElseIf Not IsNumeric(txtvalor2.Text) Then
            MsgBox("Escriba un valor numerico en la casilla de Cantidad", vbYesNo + vbExclamation, "Mensaje especial")
            txtvalor2.Clear()

            'Verificamos que el valor sea positivo
        ElseIf Val(txtvalor2.Text) < 0 Then
            MsgBox("Escriba un valor positivo en la casilla de Cantidad", vbYesNo + vbExclamation, "Mensaje especial")
            txtvalor2.Clear()

            'Si los valores son numericos entonces
        ElseIf IsNumeric(Valor2) Then
            Valor2 = Val(txtvalor2.Text)
        End If

        'Verificacion si marco una opcion descuento o isv
        If chkDescuento.Checked = False And chkIsv.Checked = False Then
            MsgBox("Debe seleccionar una opción 'ISV' o 'Descuento' ", vbYesNo + vbExclamation, "Mensaje especial")
        End If

        'Calcular Subtotal
        subTotal = Valor1 * Valor2

        'Condicion para validar que selecciono el usuario
        If chkDescuento.Checked Then

            'Dependiendo que opcion elija el usuario se hara un proceso diferente de descuento
            If cbbDescuento.SelectedItem = "15%" Then
                descuento = subTotal * 0.15

            ElseIf cbbDescuento.SelectedItem = "20%" Then
                descuento = subTotal * 0.2

            ElseIf cbbDescuento.SelectedItem = "50%" Then
                descuento = subTotal * 0.5

            ElseIf cbbDescuento.SelectedItem = "70%" Then
                descuento = subTotal * 0.7

            ElseIf cbbDescuento.SelectedItem = "10%" Then
                descuento = subTotal * 0.1

            ElseIf cbbDescuento.SelectedItem = "5%" Then
                descuento = subTotal * 0.05

            End If

            'Calculamos el total
            total = subTotal - descuento

            'Mostramos en la apliación
            txtSubtotal.Text = subTotal
            txtDescuento.Text = descuento
            txtTotal.Text = total

        ElseIf chkIsv.Checked Then

            'Dependiendo que opcion elija el usuario se hara un proceso diferente de ISV
            If cbbIsv.SelectedItem = "15%" Then
                ISV = subTotal * 0.15

            ElseIf cbbIsv.SelectedItem = "17%" Then
                ISV = subTotal * 0.17

            End If

            'Calculamos el total
            total = subTotal + ISV

            'Mostramos en la aplicación
            txtSubtotal.Text = subTotal
            txtIsv.Text = ISV
            txtTotal.Text = total

        End If

        btnNuevo.Enabled = True
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            cbbDescuento.Enabled = True
            chkIsv.Enabled = False
            cbbIsv.Enabled = False
        End If

        If chkDescuento.Checked = False Then
            cbbDescuento.Enabled = False
            cbbDescuento.SelectedItem = Nothing
            chkIsv.Enabled = True
        End If
    End Sub

    Private Sub chkIsv_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsv.CheckedChanged
        If chkIsv.Checked = True Then
            cbbIsv.Enabled = True
            chkDescuento.Enabled = False
            cbbDescuento.Enabled = False
        End If

        If chkIsv.Checked = False Then
            cbbIsv.Enabled = False
            cbbIsv.SelectedItem = Nothing
            chkDescuento.Enabled = True
        End If

    End Sub
End Class
