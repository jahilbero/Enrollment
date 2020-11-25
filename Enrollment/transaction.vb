Public Class transaction
    Private Sub transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Succesfull Transaction", MsgBoxStyle.Exclamation, "Enrollment System")

        Dim number1, number2 As Integer
        number1 = payment.TextBox5.Text
        number2 = payment.txtPayment.Text
        TextBox5.Text = number1 - number2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class