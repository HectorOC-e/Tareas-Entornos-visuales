Public Class DeduccionOexento
    Private Sub RegresarAlMenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenuPrincipalToolStripMenuItem.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnSalirtodo_Click(sender As Object, e As EventArgs) Handles btnSalirtodo.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSalario.Clear()
        txtEXoDED.Clear()
        txtSalarioNeto.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim salario, salarioNeto As Double

        Try
            If (txtSalario.Text) = "" Then
                MsgBox("Debe escribir el salario", vbOKOnly + vbExclamation, "Alerta")
            ElseIf Not IsNumeric(txtSalario.text) Then
                MsgBox("Debe escribir un salario válido", vbOKOnly + vbExclamation, "Alerta")
                txtSalario.Clear()
            ElseIf Val(txtSalario.Text) < 0 Then
                MsgBox("Debe escribir un salario válido", vbOKOnly + vbExclamation, "Alerta")
                txtSalario.Clear()
            ElseIf IsNumeric(txtSalario.Text) Then
                salario = Val(txtSalario.Text)

                If salario < 16582.92 Then
                    txtEXoDED.Text = "Salario Exento"
                    txtSalarioNeto.Text = salario

                ElseIf salario >= 16582.93 And salario <= 23536.61 Then
                    txtEXoDED.Text = "Salario Con Deduccion 15%"
                    salarioNeto = salario - (salario * 0.15)
                    txtSalarioNeto.Text = salarioNeto

                ElseIf salario > 23536.61 And salario < 50317.69 Then
                    txtEXoDED.Text = "Salario Con Deduccion 20%"
                    salarioNeto = salario - (salario * 0.2)
                    txtSalarioNeto.Text = salarioNeto

                ElseIf salario >= 50317.69 Then
                    txtEXoDED.Text = "Salario Con Deduccion 25%"
                    salarioNeto = salario - (salario * 0.25)
                    txtSalarioNeto.Text = salarioNeto

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class