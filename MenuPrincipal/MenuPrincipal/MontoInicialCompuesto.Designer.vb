Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MontoInicialCompuesto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MontoInicialCompuesto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.txtMontoFinal = New System.Windows.Forms.TextBox()
        Me.txtMontoInicial = New System.Windows.Forms.TextBox()
        Me.txtAños = New System.Windows.Forms.TextBox()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasa de Interes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "El Monto Inicial Sera :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero De Años"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto Final"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(18, 268)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(201, 268)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(61, 313)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(190, 38)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Regresar al menu principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Calculo Monto Inicial"
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.Location = New System.Drawing.Point(176, 81)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.Size = New System.Drawing.Size(100, 22)
        Me.txtTasaInteres.TabIndex = 8
        '
        'txtMontoFinal
        '
        Me.txtMontoFinal.Location = New System.Drawing.Point(176, 168)
        Me.txtMontoFinal.Name = "txtMontoFinal"
        Me.txtMontoFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtMontoFinal.TabIndex = 9
        '
        'txtMontoInicial
        '
        Me.txtMontoInicial.Enabled = False
        Me.txtMontoInicial.Location = New System.Drawing.Point(176, 212)
        Me.txtMontoInicial.Name = "txtMontoInicial"
        Me.txtMontoInicial.Size = New System.Drawing.Size(100, 22)
        Me.txtMontoInicial.TabIndex = 10
        '
        'txtAños
        '
        Me.txtAños.Location = New System.Drawing.Point(176, 124)
        Me.txtAños.Name = "txtAños"
        Me.txtAños.Size = New System.Drawing.Size(100, 22)
        Me.txtAños.TabIndex = 11
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'MontoInicialCompuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 362)
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
        Me.Name = "MontoInicialCompuesto"
        Me.Text = "MontoInicialCompuesto"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTasaInteres As TextBox
    Friend WithEvents txtMontoFinal As TextBox
    Friend WithEvents txtMontoInicial As TextBox
    Friend WithEvents txtAños As TextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Tasa, Años, MontoFinal, MontoInicial As Double

        If txtTasaInteres.Text = "" Then
            MsgBox("escriba la tasa", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtTasaInteres.Text) Then
            MsgBox("escriba una tasa de interes valida", vbOK + vbExclamation, "Mensaje especial")
            txtTasaInteres.Text = ""
        ElseIf (Val(txtTasaInteres.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtTasaInteres.Text = ""
        ElseIf IsNumeric(txtTasaInteres.Text) Then
            Tasa = Val(txtTasaInteres.Text)
        End If

        If txtAños.Text = "" Then
            MsgBox("escriba los años", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtAños.Text) Then
            MsgBox("escriba una cantidad de años valida", vbOK + vbExclamation, "Mensaje especial")
            txtAños.Text = ""
        ElseIf (Val(txtAños.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtAños.Text = ""
        ElseIf IsNumeric(txtAños.Text) Then
            Años = Val(txtAños.Text)
        End If

        If txtMontoFinal.Text = "" Then
            MsgBox("escriba el monto final", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtMontoFinal.Text) Then
            MsgBox("escriba un monto valido", vbOK + vbExclamation, "Mensaje especial")
            txtMontoFinal.Text = ""
        ElseIf (Val(txtMontoFinal.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtMontoFinal.Text = ""
        ElseIf IsNumeric(txtMontoFinal.Text) Then
            MontoFinal = Val(txtMontoFinal.Text)
        End If


        Try
            If Me.ValidateChildren And txtAños.Text <> String.Empty And txtMontoFinal.Text <> String.Empty And txtTasaInteres.Text <> String.Empty Then
                For i = 1 To Años Step 1
                    MontoInicial = MontoFinal
                    MontoInicial /= ((1 + (Tasa / 100)) ^ i)
                Next

                txtMontoInicial.Text = MontoInicial
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAños.Clear()
        txtMontoFinal.Clear()
        txtTasaInteres.Clear()
        txtMontoInicial.Clear()

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub txtTasaInteres_TextChanged(sender As Object, e As EventArgs) Handles txtTasaInteres.TextChanged

    End Sub

    Private Sub txtTasaInteres_Validating(sender As Object, e As CancelEventArgs) Handles txtTasaInteres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAños_TextChanged(sender As Object, e As EventArgs) Handles txtAños.TextChanged

    End Sub

    Private Sub txtAños_Validating(sender As Object, e As CancelEventArgs) Handles txtAños.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMontoFinal_TextChanged(sender As Object, e As EventArgs) Handles txtMontoFinal.TextChanged

    End Sub

    Private Sub txtMontoFinal_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoFinal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtTasaInteres_MouseHover(sender As Object, e As EventArgs) Handles txtTasaInteres.MouseHover
        ToolTip.SetToolTip(txtTasaInteres, "Ingrese el porcentaje de interes")
        ToolTip.ToolTipTitle = "Tasa de Interes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAños_MouseHover(sender As Object, e As EventArgs) Handles txtAños.MouseHover
        ToolTip.SetToolTip(txtAños, "Ingrese el tiempo en AÑOS")
        ToolTip.ToolTipTitle = "Años"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMontoFinal_MouseHover(sender As Object, e As EventArgs) Handles txtMontoFinal.MouseHover
        ToolTip.SetToolTip(txtMontoFinal, "Ingrese el monto que obtendra al final")
        ToolTip.ToolTipTitle = "Monto Final"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
