<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contrast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.cbEnable = New System.Windows.Forms.CheckBox
        Me.sldLowerBound = New System.Windows.Forms.TrackBar
        Me.sldUpperBound = New System.Windows.Forms.TrackBar
        Me.txLowerBound = New System.Windows.Forms.TextBox
        Me.txUpperBound = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        CType(Me.sldLowerBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldUpperBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Parameter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbEnable
        '
        Me.cbEnable.AutoSize = True
        Me.cbEnable.Location = New System.Drawing.Point(16, 13)
        Me.cbEnable.Name = "cbEnable"
        Me.cbEnable.Size = New System.Drawing.Size(59, 17)
        Me.cbEnable.TabIndex = 1
        Me.cbEnable.Text = "Enable"
        Me.cbEnable.UseVisualStyleBackColor = True
        '
        'sldLowerBound
        '
        Me.sldLowerBound.Location = New System.Drawing.Point(90, 39)
        Me.sldLowerBound.Name = "sldLowerBound"
        Me.sldLowerBound.Size = New System.Drawing.Size(104, 45)
        Me.sldLowerBound.TabIndex = 2
        '
        'sldUpperBound
        '
        Me.sldUpperBound.Location = New System.Drawing.Point(93, 83)
        Me.sldUpperBound.Name = "sldUpperBound"
        Me.sldUpperBound.Size = New System.Drawing.Size(104, 45)
        Me.sldUpperBound.TabIndex = 3
        '
        'txLowerBound
        '
        Me.txLowerBound.Enabled = False
        Me.txLowerBound.Location = New System.Drawing.Point(200, 39)
        Me.txLowerBound.Name = "txLowerBound"
        Me.txLowerBound.ReadOnly = True
        Me.txLowerBound.Size = New System.Drawing.Size(40, 20)
        Me.txLowerBound.TabIndex = 4
        '
        'txUpperBound
        '
        Me.txUpperBound.Enabled = False
        Me.txUpperBound.Location = New System.Drawing.Point(204, 90)
        Me.txUpperBound.Name = "txUpperBound"
        Me.txUpperBound.ReadOnly = True
        Me.txUpperBound.Size = New System.Drawing.Size(40, 20)
        Me.txUpperBound.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(106, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Get Pic"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Height"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Width"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sldLowerBound)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbEnable)
        Me.GroupBox1.Controls.Add(Me.sldUpperBound)
        Me.GroupBox1.Controls.Add(Me.txLowerBound)
        Me.GroupBox1.Controls.Add(Me.txUpperBound)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 126)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(266, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Blue"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(266, 247)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Red"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(266, 270)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "Green"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(266, 293)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "Rotate"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Blue", "Green", "Red"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(243, 22)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(70, 49)
        Me.CheckedListBox1.TabIndex = 15
        '
        'contrast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 281)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "contrast"
        Me.Text = "contrast"
        CType(Me.sldLowerBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldUpperBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbEnable As System.Windows.Forms.CheckBox
    Friend WithEvents sldLowerBound As System.Windows.Forms.TrackBar
    Friend WithEvents sldUpperBound As System.Windows.Forms.TrackBar
    Friend WithEvents txLowerBound As System.Windows.Forms.TextBox
    Friend WithEvents txUpperBound As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
