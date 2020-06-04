Imports System.ComponentModel

Public Class CalcularTiempo_ICompuesto
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Tasa, Años, MontoFinal, MontoInicial As Double

        If txtMontoInicial.Text = "" Then
            MsgBox("escriba el monto inicial", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtMontoInicial.Text) Then
            MsgBox("escriba un monto inicial valida", vbOK + vbExclamation, "Mensaje especial")
            txtMontoInicial.Text = ""
        ElseIf (Val(txtMontoInicial.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtMontoInicial.Text = ""
        ElseIf IsNumeric(txtMontoInicial.Text) Then
            MontoInicial = Val(txtMontoInicial.Text)
        End If

        If txtTasaInteres.Text = "" Then
            MsgBox("escriba la tasa de interes", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtTasaInteres.Text) Then
            MsgBox("escriba una tasa de interes valida", vbOK + vbExclamation, "Mensaje especial")
            txtTasaInteres.Text = ""
        ElseIf (Val(txtTasaInteres.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtTasaInteres.Text = ""
        ElseIf IsNumeric(txtTasaInteres.Text) Then
            Tasa = Val(txtTasaInteres.Text)
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
            If Me.ValidateChildren And txtTasaInteres.Text <> String.Empty And txtMontoFinal.Text <> String.Empty And txtMontoInicial.Text <> String.Empty Then
                Años = (Math.Log(MontoFinal / MontoInicial)) / (Math.Log(1 + (Tasa / 100)))
                txtAños.Text = Años
            Else
                MessageBox.Show("Revise los datos ingresados", "Error al Calcular", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtMontoInicial_TextChanged(sender As Object, e As EventArgs) Handles txtMontoInicial.TextChanged

    End Sub

    Private Sub txtTasaInteres_TextChanged(sender As Object, e As EventArgs) Handles txtTasaInteres.TextChanged

    End Sub

    Private Sub txtMontoFinal_TextChanged(sender As Object, e As EventArgs) Handles txtMontoFinal.TextChanged

    End Sub

    Private Sub txtMontoInicial_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoInicial.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtTasaInteres_Validating(sender As Object, e As CancelEventArgs) Handles txtTasaInteres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMontoFinal_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoFinal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMontoInicial_MouseHover(sender As Object, e As EventArgs) Handles txtMontoInicial.MouseHover
        ToolTip.SetToolTip(txtMontoInicial, "Ingrese el monto que tiene de inicio")
        ToolTip.ToolTipTitle = "Monto Inicial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTasaInteres_MouseHover(sender As Object, e As EventArgs) Handles txtTasaInteres.MouseHover
        ToolTip.SetToolTip(txtTasaInteres, "Ingrese la tasa de interes")
        ToolTip.ToolTipTitle = "Tasa de Interes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMontoFinal_MouseHover(sender As Object, e As EventArgs) Handles txtMontoFinal.MouseHover
        ToolTip.SetToolTip(txtMontoFinal, "Ingrese el monto que obtendra al final")
        ToolTip.ToolTipTitle = "Monto Final"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class