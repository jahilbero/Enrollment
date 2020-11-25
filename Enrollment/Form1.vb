Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Openserver()
        Me.Show()
        txtStudentNo.Select()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            NewDataSet("SELECT studentno, password FROM tb_login WHERE studentno ='" & txtStudentNo.Text & "' AND password ='" & txtPass.Text & "' AND category = 'student'")

            If data.Rows.Count > 0 Then
                MsgBox("Hello, John Astrud!", MsgBoxStyle.Information, "Enrollment System")
                Me.Hide()
                Tuition_Fee.Show()
                txtPass.Clear()



            Else

                MsgBox("Invalid Username and Password", MsgBoxStyle.Exclamation, "Enrollment System")
                txtStudentNo.Clear()
                txtPass.Clear()



            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class
