Public Class Form1
    Dim opt As String
    Dim result As Integer
    Dim tmp As Integer?
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        setLabelTemp(Button13.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        setLabelTemp(Button9.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        setLabelTemp(Button10.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        setLabelTemp(Button11.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        setLabelTemp(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        setLabelTemp(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        setLabelTemp(Button7.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setLabelTemp(Button1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setLabelTemp(Button2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        setLabelTemp(Button3.Text)
    End Sub

    Private Sub setLabelTemp(s As String)
        If labelTemp.Text = "0" Then
            labelTemp.Text = s
        Else
            labelTemp.Text = labelTemp.Text & s
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim s As String
        s = labelTemp.Text
        s = s.Substring(0, s.Length - 1)
        If s = "" Then
            labelTemp.Text = "0"
        Else
            labelTemp.Text = s
        End If

    End Sub

    Private Sub setOpt(s As String)

        If tmp Is Nothing Then
            opt = s
            labelOpt.Text = s
            labelTemp2.Text = labelTemp.Text
            labelTemp.Text = "0"
            tmp = Integer.Parse(labelTemp2.Text)
        Else
            countResult()
            opt = s
            labelOpt.Text = s
        End If
    End Sub

    Private Sub countResult()
        If opt = "/" Then
            result = tmp / Integer.Parse(labelTemp.Text)
        ElseIf opt = "X" Then
            result = tmp * Integer.Parse(labelTemp.Text)
        ElseIf opt = "-" Then
            result = tmp - Integer.Parse(labelTemp.Text)
        ElseIf opt = "+" Then
            result = tmp + Integer.Parse(labelTemp.Text)
        End If
        labelTemp.Text = "0"
        labelTemp2.Text = result.ToString
        tmp = result
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        setOpt(btnBagi.Text)
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        setOpt(btnKali.Text)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        setOpt(btnMin.Text)
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        setOpt(btnPlus.Text)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        countResult()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        labelOpt.Text = ""
        labelTemp.Text = "0"
        labelTemp2.Text = "0"
        opt = Nothing
        result = Nothing
        tmp = Nothing

    End Sub
End Class
