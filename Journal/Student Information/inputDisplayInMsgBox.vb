Public Class inputDisplayInMsgBox

    Dim str As String
    Dim crs As String
    Dim sem As String
    Dim gen As String
    Dim sprt As String
    Dim skls As String
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If TextBox1.Text = "" Then
            MsgBox("Kindly Enter your skill ", MsgBoxStyle.Information)
            TextBox1.Focus()
        Else
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        str = str + "NAME : " + stdname.Text + Chr(13)
        str = str + "AGE : " + stdage.Text + Chr(13)
        str = str + "PHONE NUMBER : " + stdphno.Text + Chr(13)
        str = str + "Email Id : " + stdemail.Text + Chr(13)
        str = str + "BIRTHDAY DATE : " + bdate.Value + Chr(13)
        str = str + "COURSE : " + Selectedcourse() + Chr(13)
        str = str + "SEMESTER : " + Selectedsem() + Chr(13)
        str = str + "GENDER : " + Selectedgen() + Chr(13)
        str = str + "FAVORITE SPORTS : " + Selectedsports() + Chr(13)
        str = str + "SKILLS : " + Skills() + Chr(13)
        MsgBox(str, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "STUDENT INFORMATION")
    End Sub

    Function Selectedcourse() As String
        If bcombtn.Checked Then
            crs = "B.Com"
        End If
        If bbabtn.Checked Then
            crs = "BBA"
        End If
        If bcabtn.Checked Then
            crs = "BCA"
        End If
        Return crs
    End Function

    Function Selectedsem() As String
        sem = ComboBox1.SelectedItem
        Return sem
    End Function

    Function Selectedgen() As String
        If malebtn.Checked Then
            gen = "MALE"
        End If
        If femalebtn.Checked Then
            gen = "FEMALE"
        End If
        Return gen
    End Function

    Function Selectedsports() As String
        If bdmtn.Checked Then
            sprt += "BADMINTON ,"
        End If
        If crkt.Checked Then
            sprt += "CRICKET ,"
        End If
        If tns.Checked Then
            sprt += "TENNIS ,"
        End If
        If otr.Checked Then
            sprt += "OTHER"
        End If
        Return sprt
    End Function

    Function Skills() As String
        For i = 0 To 3
            skls = skls + ListBox1.Items(i) + " ,"
        Next
        Return skls
    End Function

End Class