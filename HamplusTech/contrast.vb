Imports System.Drawing
Public Class contrast
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .Title = "Select Image"
            .FileName = ""
            .Filter = "All Images|*.jpg;*.bmp;*.gif;*.png"
            .ShowDialog()
        End With
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        GroupBox1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldLowerBound.Scroll
        sldLowerBound.Minimum = 0
        sldLowerBound.Maximum = 255
        txLowerBound.Text = sldLowerBound.Value
        PictureBox1.Height = txLowerBound.Text

    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sldUpperBound.Scroll
        sldUpperBound.Minimum = 0
        sldUpperBound.Maximum = 255
        txUpperBound.Text = sldUpperBound.Value
        PictureBox1.Width = txUpperBound.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.BackColor = Color.Blue
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.CheckedItems.Item("Blue") Then
            PictureBox1.BackColor = Color.Blue
        ElseIf CheckedListBox1.CheckedItems.Item("Green") Then
            PictureBox1.BackColor = Color.Green
        Else
            PictureBox1.BackColor = Color.Red
        End If
    End Sub
End Class