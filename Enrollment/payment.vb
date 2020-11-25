Public Class payment
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPayment.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPayment.Text = "" Then
            MsgBox("Enter Amount", MsgBoxStyle.Critical, "Enrollment Transaction")
            txtPayment.Select()
        ElseIf Not IsNumeric(txtPayment.Text) Then
            MsgBox("Please enter numbers only", MsgBoxStyle.Critical, "Enrollment Transaction")
            txtPayment.Select()
            txtPayment.Clear()

        Else
            transaction.Show()
        End If

        Me.Close()

    End Sub
End Class