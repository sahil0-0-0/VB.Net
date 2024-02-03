Public Class tic_tac_toe
    Dim p1 As String
    Dim p2 As String
    Dim p1sign As String
    Dim p2sign As String
    Dim Demo As Boolean

    Private Sub plybtn_Click(sender As Object, e As EventArgs) Handles plybtn.Click
        p1 = plyr1name.Text
        p2 = plyr2name.Text
        If selectX.Checked Then
            p1sign = "X"
            p2sign = "O"
        End If
        If selectO.Checked Then
            p1sign = "O"
            p2sign = "X"
        End If
        plyrturn.Text = p1 + " TURN"
        p1lbl.Text = p1 + " wins:"
        p2lbl.Text = p2 + " wins:"
        btnEnableTrue()
    End Sub

    Private Sub tic_tac_toe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEnableFalse()
    End Sub

    Public Sub btnEnableFalse()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Public Sub btnEnableTrue()
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If Demo = False Then
            CType(sender, Button).Text = p1sign
            plyrturn.Text = p2 + " TURN"
            Demo = True
            CType(sender, Button).Enabled = False
        Else
            CType(sender, Button).Text = p2sign
            plyrturn.Text = p1 + " TURN"
            Demo = False
            CType(sender, Button).Enabled = False
        End If
        winner()
    End Sub

    Public Sub winner()
        If btn1.Text = p1sign And btn2.Text = p1sign And btn3.Text = p1sign Then
            p1win()
        End If
        If btn4.Text = p1sign And btn5.Text = p1sign And btn6.Text = p1sign Then
            p1win()
        End If
        If btn7.Text = p1sign And btn8.Text = p1sign And btn9.Text = p1sign Then
            p1win()
        End If
        If btn1.Text = p1sign And btn4.Text = p1sign And btn7.Text = p1sign Then
            p1win()
        End If
        If btn2.Text = p1sign And btn5.Text = p1sign And btn8.Text = p1sign Then
            p1win()
        End If
        If btn3.Text = p1sign And btn6.Text = p1sign And btn9.Text = p1sign Then
            p1win()
        End If
        If btn1.Text = p1sign And btn5.Text = p1sign And btn9.Text = p1sign Then
            p1win()
        End If
        If btn3.Text = p1sign And btn5.Text = p1sign And btn7.Text = p1sign Then
            p1win()
        End If
        If btn1.Text = p2sign And btn2.Text = p2sign And btn3.Text = p2sign Then
            p2win()
        End If
        If btn4.Text = p2sign And btn5.Text = p2sign And btn6.Text = p2sign Then
            p2win()
        End If
        If btn7.Text = p2sign And btn8.Text = p2sign And btn9.Text = p2sign Then
            p2win()
        End If
        If btn1.Text = p2sign And btn4.Text = p2sign And btn7.Text = p2sign Then
            p2win()
        End If
        If btn2.Text = p2sign And btn5.Text = p2sign And btn8.Text = p2sign Then
            p2win()
        End If
        If btn3.Text = p2sign And btn6.Text = p2sign And btn9.Text = p2sign Then
            p2win()
        End If
        If btn1.Text = p2sign And btn5.Text = p2sign And btn9.Text = p2sign Then
            p2win()
        End If
        If btn3.Text = p2sign And btn2.Text = p2sign And btn7.Text = p2sign Then
            p2win()
        End If
        If btn1.Text IsNot "" And btn2.Text IsNot "" And btn3.Text IsNot "" And btn4.Text IsNot "" And btn5.Text IsNot "" And btn6.Text IsNot "" And btn7.Text IsNot "" And btn8.Text IsNot "" And btn9.Text IsNot "" Then
            plyrturn.Text = " Match Tie"
            MsgBox("The match is Tie .")
            tiescore.Text += 1
            clr()
            plyrturn.Text = p2 + " TURN"
            btnEnableTrue()
        End If
    End Sub

    Public Sub p1win()
        plyrturn.Text = p1 + " is winner"
        MsgBox("The winner is " + p1)
        p1score.Text += 1
        clr()
        plyrturn.Text = p2 + " TURN"
        btnEnableTrue()
    End Sub

    Public Sub p2win()
        plyrturn.Text = p2 + " is winner"
        MsgBox("The winner is " + p2)
        p2score.Text += 1
        clr()
        plyrturn.Text = p1 + " TURN"
        btnEnableTrue()
    End Sub

    Public Sub clr()
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
    End Sub

    Private Sub clrbtn_Click(sender As Object, e As EventArgs) Handles clrbtn.Click
        clr()
    End Sub

    Private Sub rstbtn_Click(sender As Object, e As EventArgs) Handles rstbtn.Click
        clr()
        p1score.Text = 0
        p2score.Text = 0
        tiescore.Text = 0
        plyr1name.Text = ""
        plyr2name.Text = ""
        selectX.Checked = False
        selectO.Checked = False
        plyrturn.Text = "New Match"
        p1lbl.Text = "wins"
        p2lbl.Text = "wins"
    End Sub
End Class
