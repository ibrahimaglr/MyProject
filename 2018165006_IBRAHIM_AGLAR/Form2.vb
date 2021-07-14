Public Class Form2
    'İBRAHİM AĞLAR
    '2018165006
    Dim x, y, z As Int16
    Dim g As Graphics
    Dim kalemim = New Pen(Color.Blue, 2)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim yukseklik, alcaklık As Single
        yukseklik = (Me.Width / 2) - 50
        alcaklık = (Me.Height / 2) - 50
        g = Me.CreateGraphics()
        g.Clear(Me.BackColor)
        g.DrawEllipse(kalemim, yukseklik, alcaklık, 100, 100)
        g.Dispose()
    End Sub
    Dim counter As Integer
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'buraya Button2.DoubleClick yazınca çalışması lazım noramlde
        'doubleClick olayını yapamadım bilgisayarımdan kaynaklı olabilir
        ' bu yüzden sayaca yaptım
        counter += 1
        If (counter Mod 2 = 0) Then
            rastgele()
            rastgele2()
            rastgele3()
            rastgele4()
        End If
    End Sub
    Public Sub rastgele()
        Dim rastgele As New Random
        x = rastgele.Next(256)
        y = rastgele.Next(256)
        z = rastgele.Next(256)
        Dim fırça As SolidBrush = New SolidBrush(Color.FromArgb(x, y, z))
        Dim yukseklik, alcaklık As Single
        yukseklik = (Me.Width / 2) - 60
        alcaklık = (Me.Height / 2) - 10
        g = Me.CreateGraphics()
        g.FillEllipse(fırça, yukseklik, alcaklık, 20, 20)
        g.Dispose()
    End Sub
    Public Sub rastgele2()
        Dim rastgele2 As New Random
        x = rastgele2.Next(256)
        y = rastgele2.Next(256)
        z = rastgele2.Next(256)
        Dim fırça As SolidBrush = New SolidBrush(Color.FromArgb(z, y, x))
        Dim yukseklik, alcaklık As Single
        yukseklik = (Me.Width / 2) - 10
        alcaklık = (Me.Height / 2) + 40
        g = Me.CreateGraphics()
        g.FillEllipse(fırça, yukseklik, alcaklık, 20, 20)
        g.Dispose()
    End Sub
    Public Sub rastgele3()
        Dim rastgele2 As New Random
        x = rastgele2.Next(256)
        y = rastgele2.Next(256)
        z = rastgele2.Next(256)
        Dim fırça As SolidBrush = New SolidBrush(Color.FromArgb(y, z, x))
        Dim yukseklik, alcaklık As Single
        yukseklik = (Me.Width / 2) - 10
        alcaklık = (Me.Height / 2) - 60
        g = Me.CreateGraphics()
        g.FillEllipse(fırça, yukseklik, alcaklık, 20, 20)
        g.Dispose()
    End Sub
    Public Sub rastgele4()
        Dim rastgele4 As New Random
        x = rastgele4.Next(256)
        y = rastgele4.Next(256)
        z = rastgele4.Next(256)
        Dim fırça As SolidBrush = New SolidBrush(Color.FromArgb(z, x, y))
        Dim yukseklik, alcaklık As Single
        yukseklik = (Me.Width / 2) + 40
        alcaklık = (Me.Height / 2) - 10
        g = Me.CreateGraphics()
        g.FillEllipse(fırça, yukseklik, alcaklık, 20, 20)
        g.Dispose()
    End Sub
End Class