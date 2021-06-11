Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1
    Dim bmp As Bitmap = Nothing

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Draw()
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Draw()
    End Sub

    Private Sub Draw()
        With PictureBox1
            bmp = New Bitmap(.ClientRectangle.Width, .ClientRectangle.Height, Imaging.PixelFormat.Format32bppArgb)
            Using gr As Graphics = Graphics.FromImage(bmp)
                gr.DrawEllipse(Pens.Red, PictureBox1.ClientRectangle)
                gr.DrawRectangle(Pens.Red, PictureBox1.ClientRectangle)
                gr.DrawLine(Pens.Red, 0, 0, .ClientRectangle.Width, .ClientRectangle.Height)
            End Using
            PictureBox1.Image = bmp
        End With
    End Sub
End Class