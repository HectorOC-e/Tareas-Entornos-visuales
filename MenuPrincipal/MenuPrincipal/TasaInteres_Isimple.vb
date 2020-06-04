Imports System.ComponentModel

Public Class TasaInteres_Isimple
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

        If txtCapital.Text = "" Then
            MsgBox("escriba el capital", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtCapital.Text) Then
            MsgBox("escriba un capital valida", vbOK + vbExclamation, "Mensaje especial")
            txtCapital.Text = ""
        ElseIf (Val(txtCapital.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtCapital.Text = ""
        ElseIf IsNumeric(txtCapital.Text) Then
            Capital = Val(txtCapital.Text)
        End If


        Try
            If Me.ValidateChildren And txtTiempo.Text <> String.Empty And txtValorInteres.Text <> String.Empty And txtCapital.Text <> String.Empty Then
                Tasa = (ValorInteres / (Años * Capital)) * 100
                txtTasaInteres.Text = Tasa
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

    Private Sub txtCapital_TextChanged(sender As Object, e As EventArgs) Handles txtCapital.TextChanged

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

    Private Sub txtCapital_Validating(sender As Object, e As CancelEventArgs) Handles txtCapital.Validating
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

    Private Sub txtCapital_MouseHover(sender As Object, e As EventArgs) Handles txtCapital.MouseHover
        ToolTip.SetToolTip(txtCapital, "Ingrese el Valor Del Capital")
        ToolTip.ToolTipTitle = "Valor Capital"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTiempo_MouseHover(sender As Object, e As EventArgs) Handles txtTiempo.MouseHover
        ToolTip.SetToolTip(txtTiempo, "Ingrese el Tiempo en Años")
        ToolTip.ToolTipTitle = "AÑOS"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class