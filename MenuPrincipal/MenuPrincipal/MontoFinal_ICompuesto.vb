﻿Imports System.ComponentModel

Public Class MontoFinal_ICompuesto
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

        If txtTasaInteres.Text = "" Then
            MsgBox("escriba la tasa de interes", vbOK + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtTasaInteres.Text) Then
            MsgBox("escriba una tasa de interes valida", vbOK + vbExclamation, "Mensaje especial")
            txtTasaInteres.Text = ""
        ElseIf (Val(txtTasaInteres.Text)) < 0 Then
            MsgBox("el valor es negativo, ingrese un valor positivo")
            txtTasaInteres.Text = ""
        ElseIf IsNumeric(txtTasaInteres.Text) Then
            MontoFinal = Val(txtTasaInteres.Text)
        End If


        Try
            If Me.ValidateChildren And txtAños.Text <> String.Empty And txtTasaInteres.Text <> String.Empty And txtMontoInicial.Text <> String.Empty Then
                For i = 1 To Años Step 1
                    MontoFinal = MontoInicial
                    MontoFinal *= (1 + (Tasa / 100) ^ i)
                Next
                txtMontoFinal.Text = MontoFinal
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

    Private Sub txtAños_TextChanged(sender As Object, e As EventArgs) Handles txtAños.TextChanged

    End Sub

    Private Sub txtTasaInteres_TextChanged(sender As Object, e As EventArgs) Handles txtTasaInteres.TextChanged

    End Sub

    Private Sub txtMontoInicial_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoInicial.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAños_Validating(sender As Object, e As CancelEventArgs) Handles txtAños.Validating
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

    Private Sub txtMontoInicial_MouseHover(sender As Object, e As EventArgs) Handles txtMontoInicial.MouseHover
        ToolTip.SetToolTip(txtMontoInicial, "Ingrese el monto que tiene de inicio")
        ToolTip.ToolTipTitle = "Monto Inicial"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAños_MouseHover(sender As Object, e As EventArgs) Handles txtAños.MouseHover
        ToolTip.SetToolTip(txtAños, "Ingrese el tiempo en AÑOS")
        ToolTip.ToolTipTitle = "Años"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTasaInteres_MouseHover(sender As Object, e As EventArgs) Handles txtTasaInteres.MouseHover
        ToolTip.SetToolTip(txtTasaInteres, "Ingrese la tasa de interes")
        ToolTip.ToolTipTitle = "Tasa de Interes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class