Public Class firstsem
    Private Sub firstsem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewDataSet("SELECT    coursecode, coursedescription, section, lec, lab, day, time, room, tuition, labfee, total FROM tb_myschedule")
        DataGridView1.DataSource = data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class