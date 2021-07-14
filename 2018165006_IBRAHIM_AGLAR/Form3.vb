Public Class Form3
    'İBRAHİM AĞLAR
    '2018165006
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result, delete As Integer
        If ListBox1.SelectedIndex <> -1 Then
            result = (ListBox1.Items(ListBox1.SelectedIndex)) - 1
            For i = 0 To ListBox1.Items.Count - 1
                If ListBox1.GetSelected(i) = True Then
                    If Val(ListBox1.Items(i)) > result Then
                        result = ListBox1.Items(i)
                        delete = i.ToString
                    End If

                    TextBox1.Text = result
                End If
            Next
            ListBox1.Items.Remove(ListBox1.Items(delete))
            ListBox1.ClearSelected()
        Else
            MsgBox("eleman seçmedin!!")
        End If
    End Sub
End Class