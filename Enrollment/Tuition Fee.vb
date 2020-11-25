Public Class Tuition_Fee
    Private Sub StSemesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StSemesterToolStripMenuItem.Click
        firstsem.Show()
    End Sub

    Private Sub NdSemesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NdSemesterToolStripMenuItem.Click
        MsgBox("1st semester is still on going!", MsgBoxStyle.Information, "Enrollment System")
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo)
        If vbYes Then
            Me.Close()
            Form1.Show()

        End If
    End Sub

    Private Sub ViewTuitionFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTuitionFeeToolStripMenuItem.Click
        viewassesment.Show()
    End Sub

    Private Sub PayTuitionFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayTuitionFeeToolStripMenuItem.Click
        payment.Show()
    End Sub
End Class