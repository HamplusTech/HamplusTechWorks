Public Class alarm
    Private blnAlarmOn As Boolean
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            blnAlarmOn = True
        Else
            blnAlarmOn = False
        End If
    End Sub

    Private Sub alarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Dim starttime As Date
        starttime = TimeOfDay
        Timer1.Start()
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        'If blnAlarmOn Then
        '    Dim strTimes() As String = Split(TextBox1.Text, ":")
        '    Dim dteAlarmTime = New DateTime(Today.Year, Today.Month, Today.Day, _
        '    Val(strTimes(0)), Val(strTimes(1)), Val(strTimes(2)))
        '    If Now > dteAlarmTime Then
        '        Beep()
        '    End If
        'End If
    End Sub
End Class