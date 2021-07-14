Public Class Form4
    'İBRAHİM AĞLAR
    '2018165006
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Location = New Point(15, 30)
        Timer1.Start()
        Button1.Text = ":)"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 1 To Me.Width
            Button1.Location = New Point(i, 30)
            If Button1.Location = New Point(Me.Width - Button1.Width - 15, 30) Then
                Exit For
            End If
        Next
        Timer2.Start()
        Timer1.Stop()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For i As Integer = 1 To Me.Height
            Button1.Location = New Point(Me.Width - Button1.Width - 15, i)
            If Button1.Location = New Point(Me.Width - Button1.Width - 15, Me.Height - 40) Then
                Timer3.Start()
                Timer2.Stop()
                Exit For
            End If
        Next
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        For i As Integer = 1 To Me.Width
            Button1.Location = New Point(Me.Width - Button1.Width - 15 - i, Me.Height - 40)
            If Button1.Location = New Point(15, Me.Height - 40) Then
                Timer4.Start()
                Timer3.Stop()
                Exit For
            End If
        Next
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        For i As Integer = 1 To Me.Height
            Button1.Location = New Point(15, Me.Height - 40 - i)
            If Button1.Location = New Point(15, 30) Then
                Timer4.Stop()
                Button1.Text = "TRY :)"
                Exit For
            End If
        Next
    End Sub
End Class