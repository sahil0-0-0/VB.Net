Imports System.Reflection.Metadata

Public Class Calculator
    Dim sign As String
    Dim value As Double
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Scr.Text = Scr.Text + "1"
        Msign.Enabled = False
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Scr.Text = Scr.Text + "2"
        Msign.Enabled = False
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Scr.Text = Scr.Text + "3"
        Msign.Enabled = False
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Scr.Text = Scr.Text + "4"
        Msign.Enabled = False
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Scr.Text = Scr.Text + "5"
        Msign.Enabled = False
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Scr.Text = Scr.Text + "6"
        Msign.Enabled = False
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Scr.Text = Scr.Text + "7"
        Msign.Enabled = False
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Scr.Text = Scr.Text + "8"
        Msign.Enabled = False
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Scr.Text = Scr.Text + "9"
        Msign.Enabled = False
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Scr.Text = Scr.Text + "0"
        Msign.Enabled = False
    End Sub

    Private Sub Pntbtn_Click(sender As Object, e As EventArgs) Handles Pntbtn.Click
        Scr.Text = Scr.Text + "."
        Pntbtn.Enabled = False
    End Sub

    Private Sub Msign_Click(sender As Object, e As EventArgs) Handles Msign.Click
        Scr.Text = Scr.Text + "-"
        Msign.Enabled = False
    End Sub

    Private Sub Clrbtn_Click(sender As Object, e As EventArgs) Handles Clrbtn.Click
        Scr.Clear()
        Pntbtn.Enabled = True
        Msign.Enabled = True
    End Sub

    Private Sub Acbtn_Click(sender As Object, e As EventArgs) Handles Acbtn.Click
        Scr.Clear()
        Miniscr.Clear()
        Pntbtn.Enabled = True
        Msign.Enabled = True
    End Sub

    Private Sub Plusbtn_Click(sender As Object, e As EventArgs) Handles Plusbtn.Click
        sign = "+"
        Display()
    End Sub

    Private Sub Minusbtn_Click(sender As Object, e As EventArgs) Handles Minusbtn.Click
        sign = "-"
        Display()
    End Sub

    Private Sub Mulbtn_Click(sender As Object, e As EventArgs) Handles Mulbtn.Click
        sign = "x"
        Display()
    End Sub

    Private Sub Divbtn_Click(sender As Object, e As EventArgs) Handles Divbtn.Click
        sign = "/"
        Display()
    End Sub

    Public Sub Display()
        value = Scr.Text
        Miniscr.Text = Miniscr.Text & " = " & CStr(value) & " " & CStr(sign) & " "
        Scr.Clear()
        Scr.Focus()
        Pntbtn.Enabled = True
        Msign.Enabled = True
    End Sub

    Private Sub Ansbtn_Click(sender As Object, e As EventArgs) Handles Ansbtn.Click
        Pntbtn.Enabled = True
        Msign.Enabled = True

        Miniscr.Text = Miniscr.Text + Scr.Text

        If sign = "+" Then
            Scr.Text = value + Val(Scr.Text)
        ElseIf sign = "-" Then
            Scr.Text = value - Val(Scr.Text)
        ElseIf sign = "x" Then
            Scr.Text = value * Val(Scr.Text)
        ElseIf sign = "/" Then
            Scr.Text = value / Val(Scr.Text)
        End If
    End Sub


End Class