Public Class Form1
    Dim input_angka, Hasil As Integer

    Dim Rumus As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles tombol6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles tombol2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub tombol1_Click(sender As Object, e As EventArgs) Handles tombol1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub tombolSamaDengan_Click(sender As Object, e As EventArgs) Handles tombolSamaDengan.Click
        Select Case Rumus
            Case "+"
                Hasil = input_angka + TextBox1.Text
            Case "-"
                Hasil = input_angka - TextBox1.Text
        End Select
        TextBox1.Text = Hasil
    End Sub

    Private Sub tombolKurang_Click(sender As Object, e As EventArgs) Handles tombolKurang.Click
        input_angka = TextBox1.Text
        Rumus = "-"
        TextBox1.Text = Nothing
    End Sub

    Private Sub tombolTambah_Click(sender As Object, e As EventArgs) Handles tombolTambah.Click
        input_angka = TextBox1.Text
        Rumus = "+"
        TextBox1.Text = Nothing
    End Sub

    Private Sub tombolClear_Click(sender As Object, e As EventArgs) Handles tombolClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub tombol0_Click(sender As Object, e As EventArgs) Handles tombol0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub tombol3_Click(sender As Object, e As EventArgs) Handles tombol3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub tombol4_Click(sender As Object, e As EventArgs) Handles tombol4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub tombol5_Click(sender As Object, e As EventArgs) Handles tombol5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub tombol7_Click(sender As Object, e As EventArgs) Handles tombol7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub tombol8_Click(sender As Object, e As EventArgs) Handles tombol8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub tombol9_Click(sender As Object, e As EventArgs) Handles tombol9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub
End Class
