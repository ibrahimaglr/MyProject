Public Class Form1
    'İBRAHİM AĞLAR
    '2018165006
    Public Sub Formgetir(mdiFrame)
        Panel2.Controls.Clear()
        mdiFrame.MdiParent = Me
        mdiFrame.FormBorderStyle = FormBorderStyle.None
        Panel2.Controls.Add(mdiFrame)
        mdiFrame.Show()
        mdiFrame.Dock = DockStyle.Fill
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As New Form2
        Formgetir(result)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result2 As New Form3
        Formgetir(result2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result3 As New Form4
        Formgetir(result3)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result4 As New Form5
        Formgetir(result4)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result5 As New Form6
        Formgetir(result5)
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
