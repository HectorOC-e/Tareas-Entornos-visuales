Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Inicio
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim division As Double
        Dim multiplicacion As Integer
        Dim potencia As Integer
        Dim raiz As Double

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        'Proceso

        If cbSuma.Checked = True Then
            suma = Valor1 + Valor2
            txtSuma.Text = suma


        End If

        If cbResta.Checked = True Then
            resta = Valor1 - Valor2
            txtResta.Text = resta
        End If

        If cbRaiz.Checked = True Then
            raiz = Valor1 ^ (1 / 2)
            txtRaiz.Text = raiz
        End If

        If cbPotencia.Checked = True Then
            potencia = Valor1 ^ Valor2
            txtPotencia.Text = potencia
        End If

        If cbMultiplicacion.Checked = True Then
            multiplicacion = Valor1 * Valor2
            txtMultiplicacion.Text = multiplicacion
        End If

        If cbDivision.Checked = True Then
            division = Valor1 / Valor2
            If Valor2 = 0 Then
                MsgBox("No ha sido posible realizar la división!", vbInformation)
            Else
                txtDivision.Text = division
            End If

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'se sale
        End

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDivision.Clear()
        txtMultiplicacion.Clear()
        txtResta.Clear()
        txtSuma.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
        txtRaiz.Clear()
        txtPotencia.Clear()

        cbSuma.Checked = False
        cbResta.Checked = False
        cbRaiz.Checked = False
        cbPotencia.Checked = False
        cbMultiplicacion.Checked = False
        cbDivision.Checked = False


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbSuma.CheckedChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Valor1 As Int16
        If txtValor1.Text = "" Then
            MsgBox("escriba un numero en la casilla del valor 1", vbYesNo + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("escriba un valor numerico en la casilla del valor 2", vbYesNo + vbExclamation, "Mensaje especial")
            txtValor1.Text = ""
        ElseIf IsNumeric(Valor1) Then
            Valor1 = Val(txtValor1.Text)
            If Valor1 = 0 Then
                MsgBox("el valor 1 es 0")
            ElseIf Valor1 > 0 Then
                MsgBox("el valor 1 es positivo")
            ElseIf Valor1 < 0 Then
                MsgBox("el valor 1 es negativo")
            End If
        End If

        Dim Valor2 As Int16
        If txtValor2.Text = "" Then
            MsgBox("escriba un numero en la casilla del valor 2", vbYesNo + vbExclamation, "Mensaje especial")
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("escriba un valor numerico en la casilla del valor 2", vbAbortRetryIgnore)
            txtValor2.Text = ""
        ElseIf IsNumeric(Valor1) Then
            Valor2 = Val(txtValor2.Text)
            If Valor2 = 0 Then
                MsgBox("el valor 2 numero 0")
            ElseIf Valor2 > 0 Then
                MsgBox("el valor 2 es positivo")
            ElseIf Valor2 < 0 Then
                MsgBox("el valor 2 es negativo")
            End If
        End If

    End Sub
End Class
