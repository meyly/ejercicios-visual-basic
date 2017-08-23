Public Class Form1
    Private Sub ctDato_TextChanged(sender As Object, e As EventArgs) Handles ctDato.TextChanged

        Dim sTexto As String = ctDato.Text

        ctDato.Text = "Programación de Software"

    End Sub

    Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click
        If (ctDato.Text <> "") Then IsLista.Items.Add(ctDato.Text)
    End Sub

    Private Sub cvCursiva_CheckedChanged(sender As Object, e As EventArgs) Handles cvCursiva.CheckedChanged
        If (cvCursiva.Checked) Then
            ctDato.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Italic)
        Else
            ctDato.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular)
        End If
    End Sub

    Private Sub bolectura_CheckedChanged(sender As Object, e As EventArgs) Handles bolectura.CheckedChanged
        If (bolectura.Checked) Then ctDato.ReadOnly = False
        If (boescritura.Checked) Then ctDato.ReadOnly = True
    End Sub

    Private Sub bdhColortexto_Scroll(sender As Object, e As ScrollEventArgs) Handles bdhColortexto.Scroll
        ctDato.ForeColor = Color.FromArgb(bdhColortexto.Value, bdhColortexto.Value, bdhColortexto.Value)
    End Sub

    Private Sub IsLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IsLista.SelectedIndexChanged
        ctDato.Text = IsLista.SelectedItem
    End Sub

    Private Sub itOpcionesSalir_Click(sender As Object, e As EventArgs) Handles itOpcionesSalir.Click
        Close()
    End Sub

    Private Sub itOpcionesColor_Click(sender As Object, e As EventArgs) Handles itOpcionesColor.Click
        'Establecer color actual de la caja de texto
        dlgColor.Color = ctDato.BackColor
        'Mostrar el dialogo dglColor
        If (dlgColor.ShowDialog() = DialogResult.OK) Then
            'Si se pulsó aceptar,establecer el color de fondo de la caja de texto
            ctDato.BackColor = dlgColor.Color


        End If
    End Sub

    Private Sub itAyudaAcercaDe_Click(sender As Object, e As EventArgs) Handles itAyudaAcercaDe.Click
        MessageBox.Show("Aplicación saludo. Versión 1.0" + Environment.NewLine + "Copyright(c)Meyly Suarez, 2017", "acerca del saludo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
