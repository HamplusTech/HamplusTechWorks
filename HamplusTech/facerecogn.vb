'Imports Emgu.CV
'Imports Emgu.CV.Structure
'Imports Emgu.Util
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

Public Class facerecogn
    Public Function convertImageToBinaryArray(ByVal imagePath As String) As Byte()
        Dim fs As IO.FileStream = New IO.FileStream(imagePath, IO.FileMode.Open, IO.FileAccess.Read) ' FileMode.Open, FileAccess.Read)
        Dim br As IO.BinaryReader = New IO.BinaryReader(fs)
        Dim imageByte() As Byte = br.ReadBytes(fs.Length)
        br.Close()
        fs.Close()
        Return imageByte
    End Function


    Public img As Bitmap
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'OpenFileDialog1.OpenFile()
        With OpenFileDialog1
            .FileName = ""
            .Title = "Hamplus Tech | Please Select An Image"
            .Filter = "All Images|*.jpg;*.bmp;*.png;*.gif"
        End With
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString <> "" Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            img = New Bitmap(OpenFileDialog1.FileName.ToString)
            TextBox1.Text = PictureBox1.ImageLocation
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    'Private Sub facerecogn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Load the image from file
    '    Dim img As New Image(Of Bgr, Byte)("lena.jpg")

    '    'Load the object detector
    '    Dim objectToDetect As New HaarCascade("haarcascade_frontalface_alt2.xml")

    '    'Convert the image to Grayscale
    '    Dim imgGray As Image(Of Gray, Byte) = img.Convert(Of Gray, Byte)()

    '    For Each face As MCvAvgComp In imgGray.DetectHaarCascade(objectToDetect)(0)
    '        img.Draw(face.rect, New Bgr(Color.White), 1)
    '    Next

    '    'Show the image
    '    UI.ImageViewer.Show(img)

    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim TextBox1 As String = ""
        Dim i As Integer = 0
        For i = 0 To img.Width - 1
            i = i + 1
            For j = 0 To img.Height - 1
                j = j + 1
                If (img.GetPixel(j, i).A.ToString = "255" And _
                    img.GetPixel(j, i).B.ToString = "255" And _
                    img.GetPixel(j, i).G.ToString = "255" And _
                    img.GetPixel(j, i).R.ToString = "255") Then
                    TextBox1 = TextBox1 + "0"
                Else
                    TextBox1 = TextBox1 + "1"
                End If
            Next
            ' TextBox1 = TextBox1 + "\r\n"
        Next
        TextBox2.Text = TextBox1
        'Call convertImageToBinaryArray(PictureBox1.ImageLocation)
    End Sub
End Class
