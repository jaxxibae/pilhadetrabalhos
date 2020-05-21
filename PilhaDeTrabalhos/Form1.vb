Public Class Form1
    Dim Trabalhos As New Stack

    Sub UpdateData()
        Input.Clear()
        TextBox2.Clear()

        For i = 0 To Trabalhos.Count - 1
            TextBox2.Text &= Trabalhos(i) & vbNewLine
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Trabalhos.Push(Input.Text)
        UpdateData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Trabalhos.Pop()
        UpdateData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("A pilha tem " & Trabalhos.Count & " trabalhos.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Trabalhos.Contains(Input.Text) Then
            MessageBox.Show("O trabalho " & Input.Text & " existe.")
        Else
            MessageBox.Show("O trabalho " & Input.Text & " não existe.")
        End If

        Input.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Trabalhos.Clear()
        UpdateData()
    End Sub
End Class
