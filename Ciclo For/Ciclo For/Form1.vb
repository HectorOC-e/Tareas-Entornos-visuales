Public Class Form1
    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        'Variables de entrada
        Dim dato As Integer
        Dim fin As Integer
        Dim resultado As Integer

        dato = txtValorTabla.Text
        fin = txtFinTabla.Text

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
