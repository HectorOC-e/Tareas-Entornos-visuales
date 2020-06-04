Imports System.ComponentModel

Public Class Capital_ISimple
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Tasa, Años, ValorInteres, Capital As Double

        If txtValorInteres.Text = "" Then
            MsgBox("escriba el Valor de los intereses", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtValorInteres.Text) Then
            MsgBox("escriba un valor de interes valido", vbOK + vbExclamation, "Mensaje especial")
            txtValorInteres.Text = ""
        ElseIf (Val(txtValorInteres.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtValorInteres.Text = ""
        ElseIf IsNumeric(txtValorInteres.Text) Then
            ValorInteres = Val(txtValorInteres.Text)
        End If

        If txtTiempo.Text = "" Then
            MsgBox("escriba los años", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtTiempo.Text) Then
            MsgBox("escriba una cantidad de años valida", vbOK + vbExclamation, "Mensaje especial")
            txtTiempo.Text = ""
        ElseIf (Val(txtTiempo.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtTiempo.Text = ""
        ElseIf IsNumeric(txtTiempo.Text) Then
            Años = Val(txtTiempo.Text)
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


        Try
            If Me.ValidateChildren And txtTiempo.Text <> String.Empty And txtValorInteres.Text <> String.Empty And txtTasaInteres.Text <> String.Empty Then
                Capital = ValorInteres / ((Tasa / 100) * Años)
                txtCapital.Text = Capital
            Else
                MessageBox.Show("Revise los datos ingresados", "Error al Calcular", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTiempo.Clear()
        txtValorInteres.Clear()
        txtTasaInteres.Clear()
        txtCapital.Clear()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub txtValorInteres_TextChanged(sender As Object, e As EventArgs) Handles txtValorInteres.TextChanged

    End Sub

    Private Sub txtTasaInteres_TextChanged(sender As Object, e As EventArgs) Handles txtTasaInteres.TextChanged

    End Sub

    Private Sub txtTiempo_TextChanged(sender As Object, e As EventArgs) Handles txtTiempo.TextChanged

    End Sub

    Private Sub txtValorInteres_Validating(sender As Object, e As CancelEventArgs) Handles txtValorInteres.Validating
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

    Private Sub txtTiempo_Validating(sender As Object, e As CancelEventArgs) Handles txtTiempo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValorInteres_MouseHover(sender As Object, e As EventArgs) Handles txtValorInteres.MouseHover
        ToolTip.SetToolTip(txtValorInteres, "Ingrese el Valor De los Interes")
        ToolTip.ToolTipTitle = "Valor interes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTasaInteres_MouseHover(sender As Object, e As EventArgs) Handles txtTasaInteres.MouseHover
        ToolTip.SetToolTip(txtTasaInteres, "Ingrese la Tasa de Interes")
        ToolTip.ToolTipTitle = "Monto Inicial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTiempo_MouseHover(sender As Object, e As EventArgs) Handles txtTiempo.MouseHover
        ToolTip.SetToolTip(txtTiempo, "Ingrese el Tiempo en Años")
        ToolTip.ToolTipTitle = "AÑOS"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class