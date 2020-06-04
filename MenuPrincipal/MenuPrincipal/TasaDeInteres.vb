Imports System.ComponentModel

Public Class TasaDeInteres
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
            If Me.ValidateChildren And txtAños.Text <> String.Empty And txtMontoFinal.Text <> String.Empty And txtMontoInicial.Text <> String.Empty Then
                Tasa = 100 * ((MontoFinal / MontoInicial) ^ (1 / Años) - 1)
                txtTasaInteres.Text = Tasa
            Else
                MessageBox.Show("Revise los datos ingresados", "Error al Calcular", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtMontoInicial_TextChanged(sender As Object, e As EventArgs) Handles txtMontoInicial.TextChanged

    End Sub

    Private Sub txtAños_TextChanged(sender As Object, e As EventArgs) Handles txtAños.TextChanged

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

    Private Sub txtMontoInicial_MouseHover(sender As Object, e As EventArgs) Handles txtMontoInicial.MouseHover
        ToolTip.SetToolTip(txtMontoInicial, "Ingrese el monto que tiene de inicio")
        ToolTip.ToolTipTitle = "Monto Inicial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAños_Validating(sender As Object, e As CancelEventArgs) Handles txtAños.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAños_MouseHover(sender As Object, e As EventArgs) Handles txtAños.MouseHover
        ToolTip.SetToolTip(txtAños, "Ingrese el tiempo en AÑOS")
        ToolTip.ToolTipTitle = "Años"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMontoFinal_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoFinal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMontoFinal_MouseHover(sender As Object, e As EventArgs) Handles txtMontoFinal.MouseHover
        ToolTip.SetToolTip(txtMontoFinal, "Ingrese el monto que obtendra al final")
        ToolTip.ToolTipTitle = "Monto Final"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
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
End Class

