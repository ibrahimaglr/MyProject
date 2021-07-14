Public Class Form5
    'İBRAHİM AĞLAR
    '2018165006
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 1 To 5
            parametrelifonksiyon(index)
        Next
    End Sub
    'hocam tam olarak ne için recursive kullandığımızı anlamadığım böyle yaptım yanlış yapmış olabilirim ama doğrusunu kesin biliyorumdur.
    Function parametrelifonksiyon(n As Integer) As Integer
        If n = 1 Then ListBox1.Items.Add("*****")
        If n = 2 Then ListBox1.Items.Add("****")
        If n = 3 Then ListBox1.Items.Add("***")
        If n = 4 Then ListBox1.Items.Add("**")
        If n = 5 Then ListBox1.Items.Add("*")
        Return parametrelifonksiyon
    End Function
End Class