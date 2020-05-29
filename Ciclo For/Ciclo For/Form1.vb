Public Class Form1
    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        'Variables de entrada
        Dim dato As Integer
        Dim fin As Integer
        Dim resultado As Integer


        'Verificamos si el valortabla es valido
        'Verificamos que no esten vacias las casillas
        If txtValorTabla.Text = "" Then
            MsgBox("Escriba un numero en la casilla del valor de la tabla", vbYesNo + vbExclamation, "Mensaje especial")
            'Verificamos que el valor ingresado sea numerico
        ElseIf Not IsNumeric(txtValorTabla.Text) Then
            MsgBox("Escriba un valor numerico en la casilla valor de la tabla", vbYesNo + vbExclamation, "Mensaje especial")
            txtValorTabla.Clear()

            'Si los valores son numericos entonces
        ElseIf IsNumeric(dato) Then
            dato = txtValorTabla.Text
        End If

        'Verificamos si el fin de la tabla es valido
        'Verificamos que no esten vacias las casillas
        If txtFinTabla.Text = "" Then
            MsgBox("Escriba un numero en la casilla de fin de la tabla", vbYesNo + vbExclamation, "Mensaje especial")
            'Verificamos que el valor ingresado sea numerico
        ElseIf Not IsNumeric(txtFinTabla.Text) Then
            MsgBox("Escriba un valor numerico en la casilla de fin de tabla", vbYesNo + vbExclamation, "Mensaje especial")
            txtFinTabla.Clear()

            'Verificamos que el valor sea positivo
        ElseIf Val(txtFinTabla.Text) < 0 Then
            MsgBox("Escriba un valor positivo en la casilla de fin de tabla", vbYesNo + vbExclamation, "Mensaje especial")
            txtFinTabla.Clear()

            'Si los valores son numericos entonces
        ElseIf IsNumeric(fin) Then
            fin = txtFinTabla.Text
        End If

        'procesos 
        For i = 1 To fin
                resultado = dato * i

                lstDato.Items.Add(dato)
                lstX.Items.Add("x")
                lstMultiplo.Items.Add(i)
                lstIgual.Items.Add("=")
                lstResultado.Items.Add(resultado)
            Next





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
