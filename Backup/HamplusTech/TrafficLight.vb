Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class TrafficLight
    Dim bmp As Bitmap = Nothing
    Private Sub TrafficLight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        Button1_Click(Button1, EventArgs.Empty)
        Button1.PerformClick()
        green()
        drawG()
        drawY()
        drawR()
        Timer1.Enabled = True
    End Sub
    Private Sub green()
        Dim mypen As Pen
        Dim mybrush As Brush
        mybrush = New SolidBrush(Color.Green)
        mypen = New Pen(Drawing.Color.Green, 5)
        Dim mygrap As Graphics = PictureBox3.CreateGraphics
        mygrap.DrawEllipse(mypen, 10, 10, 50, 50)
        mygrap.FillEllipse(mybrush, 10, 10, 50, 50)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myPen As Pen
        Dim myBrush As Brush
        myPen = New Pen(Drawing.Color.Yellow, 5)
        myBrush = New SolidBrush(Color.Yellow)
        Dim myGraphics As Graphics = PictureBox1.CreateGraphics
        myGraphics.DrawEllipse(myPen, 10, 10, 50, 50)
        myGraphics.FillEllipse(myBrush, 10, 10, 50, 50)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myPen As Pen
        Dim mybrush As Brush
        myPen = New Pen(Drawing.Color.Red, 5)
        mybrush = New SolidBrush(Color.Red)
        Dim myGraphics As Graphics = PictureBox2.CreateGraphics
        Dim myRectangle As New Rectangle
        myRectangle.X = 10
        myRectangle.Y = 10
        myRectangle.Width = 50
        myRectangle.Height = 50
        myGraphics.DrawEllipse(myPen, myRectangle)
        myGraphics.FillEllipse(mybrush, 10, 10, 50, 50)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mypen As Pen
        Dim mybrush As Brush
        mybrush = New SolidBrush(Color.Green)
        mypen = New Pen(Drawing.Color.Green, 5)
        Dim mygrap As Graphics = PictureBox3.CreateGraphics
        mygrap.DrawEllipse(mypen, 10, 10, 50, 50)
        mygrap.FillEllipse(mybrush, 10, 10, 50, 50)
    End Sub
    Private Sub drawG()
        Dim mypen As Pen
        Dim mybrush As Brush
        mypen = New Pen(Color.Green, 5)
        mybrush = New SolidBrush(Color.Green)

        With PictureBox1
            bmp = New Bitmap(.ClientSize.Width, .ClientSize.Height, Imaging.PixelFormat.Format32bppArgb)
            ' bmp = New Bitmap(.ClientRectangle.Width, .ClientRectangle.Height, Imaging.PixelFormat.Format32bppPArgb)
            Using gr As Graphics = Graphics.FromImage(bmp)
                gr.DrawEllipse(mypen, 5, 5, 25, 25)
                gr.FillEllipse(mybrush, 5, 5, 25, 25)
            End Using
            PictureBox1.Image = bmp
        End With
    End Sub

    Private Sub drawR()
        Dim mypen As Pen
        Dim mybrush As Brush
        mypen = New Pen(Color.Red, 5)
        mybrush = New SolidBrush(Color.Red)

        With PictureBox2
            bmp = New Bitmap(.ClientSize.Width, .ClientSize.Height, Imaging.PixelFormat.Format32bppArgb)
            ' bmp = New Bitmap(.ClientRectangle.Width, .ClientRectangle.Height, Imaging.PixelFormat.Format32bppPArgb)
            Using gr As Graphics = Graphics.FromImage(bmp)
                gr.DrawEllipse(mypen, 5, 5, 25, 25)
                gr.FillEllipse(mybrush, 5, 5, 25, 25)
            End Using
            PictureBox2.Image = bmp
        End With
    End Sub

    Private Sub drawY()
        Dim mypen As Pen
        Dim mybrush As Brush
        mypen = New Pen(Color.Yellow, 5)
        mybrush = New SolidBrush(Color.Yellow)

        With PictureBox3
            bmp = New Bitmap(.ClientSize.Width, .ClientSize.Height, Imaging.PixelFormat.Format32bppArgb)
            ' bmp = New Bitmap(.ClientRectangle.Width, .ClientRectangle.Height, Imaging.PixelFormat.Format32bppPArgb)
            Using gr As Graphics = Graphics.FromImage(bmp)
                gr.DrawEllipse(mypen, 5, 5, 25, 25)
                gr.FillEllipse(mybrush, 5, 5, 25, 25)
            End Using
            PictureBox3.Image = bmp
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Do Until Timer1.Interval = 1000
            Timer1.Start()
            Timer1.Interval = (1000 * 60) - 1000
            Label1.Text = Timer1.Interval
        Loop
    End Sub
End Class