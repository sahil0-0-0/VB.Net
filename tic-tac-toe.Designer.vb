<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tic_tac_toe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tic_tac_toe))
        plyr1 = New Label()
        plyr1name = New TextBox()
        plyr2 = New Label()
        plyr2name = New TextBox()
        choosesign = New Label()
        selectX = New RadioButton()
        selectO = New RadioButton()
        plybtn = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        scoreb = New Label()
        p1lbl = New Label()
        p2lbl = New Label()
        p1score = New Label()
        p2score = New Label()
        clrbtn = New Button()
        rstbtn = New Button()
        plyrturn = New Label()
        tiescore = New Label()
        tielbl = New Label()
        SuspendLayout()
        ' 
        ' plyr1
        ' 
        plyr1.AutoSize = True
        plyr1.FlatStyle = FlatStyle.Popup
        plyr1.Font = New Font("HP Simplified", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plyr1.ForeColor = Color.White
        plyr1.Image = CType(resources.GetObject("plyr1.Image"), Image)
        plyr1.ImageAlign = ContentAlignment.TopCenter
        plyr1.Location = New Point(28, 26)
        plyr1.Margin = New Padding(8, 0, 8, 0)
        plyr1.Name = "plyr1"
        plyr1.Size = New Size(346, 46)
        plyr1.TabIndex = 0
        plyr1.Text = "1st PLAYER NAME  :"
        ' 
        ' plyr1name
        ' 
        plyr1name.BackColor = Color.Violet
        plyr1name.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        plyr1name.ForeColor = Color.White
        plyr1name.Location = New Point(28, 96)
        plyr1name.Margin = New Padding(8, 5, 8, 5)
        plyr1name.Name = "plyr1name"
        plyr1name.Size = New Size(346, 50)
        plyr1name.TabIndex = 1
        ' 
        ' plyr2
        ' 
        plyr2.AutoSize = True
        plyr2.FlatStyle = FlatStyle.Popup
        plyr2.Font = New Font("HP Simplified", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plyr2.ForeColor = Color.White
        plyr2.Image = CType(resources.GetObject("plyr2.Image"), Image)
        plyr2.ImageAlign = ContentAlignment.TopCenter
        plyr2.Location = New Point(29, 161)
        plyr2.Margin = New Padding(8, 0, 8, 0)
        plyr2.Name = "plyr2"
        plyr2.Size = New Size(347, 46)
        plyr2.TabIndex = 2
        plyr2.Text = "2nd PLAYER NAME :"
        ' 
        ' plyr2name
        ' 
        plyr2name.BackColor = Color.Violet
        plyr2name.Font = New Font("Arial Rounded MT Bold", 22.2F)
        plyr2name.ForeColor = Color.White
        plyr2name.Location = New Point(28, 226)
        plyr2name.Margin = New Padding(8, 5, 8, 5)
        plyr2name.Name = "plyr2name"
        plyr2name.Size = New Size(346, 50)
        plyr2name.TabIndex = 3
        ' 
        ' choosesign
        ' 
        choosesign.AutoSize = True
        choosesign.FlatStyle = FlatStyle.Popup
        choosesign.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        choosesign.ForeColor = Color.White
        choosesign.Image = CType(resources.GetObject("choosesign.Image"), Image)
        choosesign.Location = New Point(40, 344)
        choosesign.Margin = New Padding(8, 0, 8, 0)
        choosesign.Name = "choosesign"
        choosesign.Size = New Size(334, 69)
        choosesign.TabIndex = 4
        choosesign.Text = "Select sign :"
        ' 
        ' selectX
        ' 
        selectX.AutoSize = True
        selectX.FlatStyle = FlatStyle.System
        selectX.Font = New Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectX.ForeColor = Color.Black
        selectX.Location = New Point(40, 416)
        selectX.Name = "selectX"
        selectX.Size = New Size(161, 144)
        selectX.TabIndex = 6
        selectX.Text = "X"
        selectX.UseVisualStyleBackColor = True
        ' 
        ' selectO
        ' 
        selectO.AutoSize = True
        selectO.FlatStyle = FlatStyle.System
        selectO.Font = New Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectO.ForeColor = Color.White
        selectO.ImageAlign = ContentAlignment.MiddleLeft
        selectO.Location = New Point(211, 416)
        selectO.Name = "selectO"
        selectO.Size = New Size(184, 144)
        selectO.TabIndex = 7
        selectO.Text = "O"
        selectO.UseVisualStyleBackColor = False
        ' 
        ' plybtn
        ' 
        plybtn.BackColor = Color.Violet
        plybtn.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plybtn.ForeColor = Color.White
        plybtn.Location = New Point(111, 574)
        plybtn.Name = "plybtn"
        plybtn.Size = New Size(188, 80)
        plybtn.TabIndex = 8
        plybtn.Text = "PLAY"
        plybtn.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.Enabled = False
        btn1.Font = New Font("Arial Rounded MT Bold", 90F)
        btn1.Location = New Point(434, 473)
        btn1.Name = "btn1"
        btn1.Size = New Size(180, 180)
        btn1.TabIndex = 24
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Enabled = False
        btn2.Font = New Font("Arial Rounded MT Bold", 90F)
        btn2.Location = New Point(620, 473)
        btn2.Name = "btn2"
        btn2.Size = New Size(180, 180)
        btn2.TabIndex = 32
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Enabled = False
        btn3.Font = New Font("Arial Rounded MT Bold", 90F)
        btn3.Location = New Point(806, 473)
        btn3.Name = "btn3"
        btn3.Size = New Size(180, 180)
        btn3.TabIndex = 33
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Enabled = False
        btn6.Font = New Font("Arial Rounded MT Bold", 90F)
        btn6.Location = New Point(806, 287)
        btn6.Name = "btn6"
        btn6.Size = New Size(180, 180)
        btn6.TabIndex = 36
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Enabled = False
        btn5.Font = New Font("Arial Rounded MT Bold", 90F)
        btn5.Location = New Point(620, 287)
        btn5.Name = "btn5"
        btn5.Size = New Size(180, 180)
        btn5.TabIndex = 35
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Enabled = False
        btn4.Font = New Font("Arial Rounded MT Bold", 90F)
        btn4.Location = New Point(434, 287)
        btn4.Name = "btn4"
        btn4.Size = New Size(180, 180)
        btn4.TabIndex = 34
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Enabled = False
        btn9.Font = New Font("Arial Rounded MT Bold", 90F)
        btn9.Location = New Point(806, 101)
        btn9.Name = "btn9"
        btn9.Size = New Size(180, 180)
        btn9.TabIndex = 39
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Enabled = False
        btn8.Font = New Font("Arial Rounded MT Bold", 90F)
        btn8.Location = New Point(620, 101)
        btn8.Name = "btn8"
        btn8.Size = New Size(180, 180)
        btn8.TabIndex = 38
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Enabled = False
        btn7.Font = New Font("Arial Rounded MT Bold", 90F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn7.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn7.Location = New Point(434, 101)
        btn7.Name = "btn7"
        btn7.Size = New Size(180, 180)
        btn7.TabIndex = 37
        btn7.UseVisualStyleBackColor = True
        ' 
        ' scoreb
        ' 
        scoreb.AutoSize = True
        scoreb.FlatStyle = FlatStyle.Popup
        scoreb.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        scoreb.ForeColor = Color.White
        scoreb.Image = CType(resources.GetObject("scoreb.Image"), Image)
        scoreb.ImageAlign = ContentAlignment.TopCenter
        scoreb.Location = New Point(1041, 26)
        scoreb.Margin = New Padding(8, 0, 8, 0)
        scoreb.Name = "scoreb"
        scoreb.Size = New Size(321, 69)
        scoreb.TabIndex = 40
        scoreb.Text = "Scoreboard"
        ' 
        ' p1lbl
        ' 
        p1lbl.AutoSize = True
        p1lbl.FlatStyle = FlatStyle.Popup
        p1lbl.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        p1lbl.ForeColor = Color.White
        p1lbl.Image = CType(resources.GetObject("p1lbl.Image"), Image)
        p1lbl.ImageAlign = ContentAlignment.TopCenter
        p1lbl.Location = New Point(1041, 190)
        p1lbl.Margin = New Padding(8, 0, 8, 0)
        p1lbl.Name = "p1lbl"
        p1lbl.Size = New Size(0, 69)
        p1lbl.TabIndex = 41
        ' 
        ' p2lbl
        ' 
        p2lbl.AutoSize = True
        p2lbl.FlatStyle = FlatStyle.Popup
        p2lbl.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        p2lbl.ForeColor = Color.White
        p2lbl.Image = CType(resources.GetObject("p2lbl.Image"), Image)
        p2lbl.ImageAlign = ContentAlignment.TopCenter
        p2lbl.Location = New Point(1041, 291)
        p2lbl.Margin = New Padding(8, 0, 8, 0)
        p2lbl.Name = "p2lbl"
        p2lbl.Size = New Size(0, 69)
        p2lbl.TabIndex = 42
        ' 
        ' p1score
        ' 
        p1score.AutoSize = True
        p1score.FlatStyle = FlatStyle.Popup
        p1score.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        p1score.ForeColor = Color.White
        p1score.Image = CType(resources.GetObject("p1score.Image"), Image)
        p1score.ImageAlign = ContentAlignment.TopCenter
        p1score.Location = New Point(1358, 190)
        p1score.Margin = New Padding(8, 0, 8, 0)
        p1score.Name = "p1score"
        p1score.Size = New Size(62, 69)
        p1score.TabIndex = 43
        p1score.Text = "0"
        ' 
        ' p2score
        ' 
        p2score.AutoSize = True
        p2score.FlatStyle = FlatStyle.Popup
        p2score.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        p2score.ForeColor = Color.White
        p2score.Image = CType(resources.GetObject("p2score.Image"), Image)
        p2score.ImageAlign = ContentAlignment.TopCenter
        p2score.Location = New Point(1358, 287)
        p2score.Margin = New Padding(8, 0, 8, 0)
        p2score.Name = "p2score"
        p2score.Size = New Size(62, 69)
        p2score.TabIndex = 44
        p2score.Text = "0"
        ' 
        ' clrbtn
        ' 
        clrbtn.BackColor = Color.Violet
        clrbtn.Font = New Font("HP Simplified", 25.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clrbtn.ForeColor = Color.White
        clrbtn.Location = New Point(1041, 483)
        clrbtn.Name = "clrbtn"
        clrbtn.Size = New Size(168, 67)
        clrbtn.TabIndex = 45
        clrbtn.Text = "CLEAR"
        clrbtn.UseVisualStyleBackColor = False
        ' 
        ' rstbtn
        ' 
        rstbtn.BackColor = Color.Violet
        rstbtn.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rstbtn.ForeColor = Color.White
        rstbtn.Location = New Point(1041, 568)
        rstbtn.Name = "rstbtn"
        rstbtn.Size = New Size(284, 80)
        rstbtn.TabIndex = 46
        rstbtn.Text = "RESTART"
        rstbtn.UseVisualStyleBackColor = False
        ' 
        ' plyrturn
        ' 
        plyrturn.AutoSize = True
        plyrturn.FlatStyle = FlatStyle.Popup
        plyrturn.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plyrturn.ForeColor = Color.White
        plyrturn.Image = CType(resources.GetObject("plyrturn.Image"), Image)
        plyrturn.ImageAlign = ContentAlignment.TopCenter
        plyrturn.Location = New Point(553, 26)
        plyrturn.Margin = New Padding(8, 0, 8, 0)
        plyrturn.Name = "plyrturn"
        plyrturn.Size = New Size(0, 69)
        plyrturn.TabIndex = 47
        ' 
        ' tiescore
        ' 
        tiescore.AutoSize = True
        tiescore.FlatStyle = FlatStyle.Popup
        tiescore.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tiescore.ForeColor = Color.White
        tiescore.Image = CType(resources.GetObject("tiescore.Image"), Image)
        tiescore.ImageAlign = ContentAlignment.TopCenter
        tiescore.Location = New Point(1358, 376)
        tiescore.Margin = New Padding(8, 0, 8, 0)
        tiescore.Name = "tiescore"
        tiescore.Size = New Size(62, 69)
        tiescore.TabIndex = 48
        tiescore.Text = "0"
        ' 
        ' tielbl
        ' 
        tielbl.AutoSize = True
        tielbl.FlatStyle = FlatStyle.Popup
        tielbl.Font = New Font("HP Simplified", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tielbl.ForeColor = Color.White
        tielbl.Image = CType(resources.GetObject("tielbl.Image"), Image)
        tielbl.ImageAlign = ContentAlignment.TopCenter
        tielbl.Location = New Point(1041, 376)
        tielbl.Margin = New Padding(8, 0, 8, 0)
        tielbl.Name = "tielbl"
        tielbl.Size = New Size(270, 69)
        tielbl.TabIndex = 49
        tielbl.Text = "match tie"
        ' 
        ' tic_tac_toe
        ' 
        AutoScaleDimensions = New SizeF(21F, 36F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1465, 677)
        Controls.Add(tielbl)
        Controls.Add(tiescore)
        Controls.Add(plyrturn)
        Controls.Add(rstbtn)
        Controls.Add(clrbtn)
        Controls.Add(p2score)
        Controls.Add(p1score)
        Controls.Add(p2lbl)
        Controls.Add(p1lbl)
        Controls.Add(scoreb)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(plybtn)
        Controls.Add(selectO)
        Controls.Add(selectX)
        Controls.Add(choosesign)
        Controls.Add(plyr2name)
        Controls.Add(plyr2)
        Controls.Add(plyr1name)
        Controls.Add(plyr1)
        Font = New Font("Verdana Pro", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(8, 5, 8, 5)
        Name = "tic_tac_toe"
        Text = "tic_tac_toe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents plyr1 As Label
    Friend WithEvents plyr1name As TextBox
    Friend WithEvents plyr2 As Label
    Friend WithEvents plyr2name As TextBox
    Friend WithEvents choosesign As Label
    Friend WithEvents choosesignn As Label
    Friend WithEvents selectX As RadioButton
    Friend WithEvents selectO As RadioButton
    Friend WithEvents plybtn As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents scoreb As Label
    Friend WithEvents p1lbl As Label
    Friend WithEvents p2lbl As Label
    Friend WithEvents p1score As Label
    Friend WithEvents p2score As Label
    Friend WithEvents clrbtn As Button
    Friend WithEvents rstbtn As Button
    Friend WithEvents turn As Label
    Friend WithEvents plyrturn As Label
    Friend WithEvents tiescore As Label
    Friend WithEvents tielbl As Label
End Class
