Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String

        a = "programacion"

        If TextBox1.Text = a Then
            MsgBox("HOLA PROGRAMACIÓN!!!")
        Else
            MsgBox("Ingrese la palabra correcta...")



        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
