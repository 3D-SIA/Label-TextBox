Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nome, cognome As String
        Dim voto As Single
        nome = TextBox1.Text
        TextBox3.Text = nome
        cognome = TextBox2.Text
        TextBox4.Text = cognome
        voto = Val(TextBox5.Text)
        TextBox6.Text = voto

    End Sub
End Class
