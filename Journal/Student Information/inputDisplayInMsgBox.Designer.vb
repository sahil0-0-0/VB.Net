<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputDisplayInMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputDisplayInMsgBox))
        titlelbl = New Label()
        stdnamelbl = New Label()
        stdagee = New Label()
        stdphnolbl = New Label()
        stdbdatelbl = New Label()
        stdcourselbl = New Label()
        stdysemlbl = New Label()
        stdemaillbl = New Label()
        stdgender = New Label()
        stdskillbtn = New Label()
        PictureBox1 = New PictureBox()
        stdname = New TextBox()
        stdage = New TextBox()
        stdphno = New TextBox()
        stdemail = New TextBox()
        bdate = New DateTimePicker()
        Panel1 = New Panel()
        bcabtn = New RadioButton()
        bcombtn = New RadioButton()
        bbabtn = New RadioButton()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        malebtn = New RadioButton()
        femalebtn = New RadioButton()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        addbtn = New Button()
        favsportlbl = New Label()
        submitbtn = New Button()
        Panel3 = New Panel()
        otr = New CheckBox()
        tns = New CheckBox()
        crkt = New CheckBox()
        bdmtn = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.BackColor = SystemColors.GradientActiveCaption
        titlelbl.Font = New Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titlelbl.Location = New Point(379, 9)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(382, 67)
        titlelbl.TabIndex = 0
        titlelbl.Text = "Student Information"
        ' 
        ' stdnamelbl
        ' 
        stdnamelbl.AutoSize = True
        stdnamelbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdnamelbl.Location = New Point(134, 126)
        stdnamelbl.Name = "stdnamelbl"
        stdnamelbl.Size = New Size(98, 45)
        stdnamelbl.TabIndex = 1
        stdnamelbl.Text = "Name :"
        ' 
        ' stdagee
        ' 
        stdagee.AutoSize = True
        stdagee.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdagee.Location = New Point(155, 189)
        stdagee.Name = "stdagee"
        stdagee.Size = New Size(77, 45)
        stdagee.TabIndex = 2
        stdagee.Text = "Age :"
        ' 
        ' stdphnolbl
        ' 
        stdphnolbl.AutoSize = True
        stdphnolbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdphnolbl.Location = New Point(27, 253)
        stdphnolbl.Name = "stdphnolbl"
        stdphnolbl.Size = New Size(205, 45)
        stdphnolbl.TabIndex = 3
        stdphnolbl.Text = "Phone Number :"
        ' 
        ' stdbdatelbl
        ' 
        stdbdatelbl.AutoSize = True
        stdbdatelbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdbdatelbl.Location = New Point(82, 375)
        stdbdatelbl.Name = "stdbdatelbl"
        stdbdatelbl.Size = New Size(150, 45)
        stdbdatelbl.TabIndex = 4
        stdbdatelbl.Text = "Birth Date :"
        ' 
        ' stdcourselbl
        ' 
        stdcourselbl.AutoSize = True
        stdcourselbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdcourselbl.Location = New Point(119, 441)
        stdcourselbl.Name = "stdcourselbl"
        stdcourselbl.Size = New Size(113, 45)
        stdcourselbl.TabIndex = 5
        stdcourselbl.Text = "Course :"
        ' 
        ' stdysemlbl
        ' 
        stdysemlbl.AutoSize = True
        stdysemlbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdysemlbl.Location = New Point(151, 495)
        stdysemlbl.Name = "stdysemlbl"
        stdysemlbl.Size = New Size(81, 45)
        stdysemlbl.TabIndex = 6
        stdysemlbl.Text = "Sem :"
        ' 
        ' stdemaillbl
        ' 
        stdemaillbl.AutoSize = True
        stdemaillbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdemaillbl.Location = New Point(108, 318)
        stdemaillbl.Name = "stdemaillbl"
        stdemaillbl.Size = New Size(124, 45)
        stdemaillbl.TabIndex = 7
        stdemaillbl.Text = "Email Id :"
        ' 
        ' stdgender
        ' 
        stdgender.AutoSize = True
        stdgender.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdgender.Location = New Point(119, 551)
        stdgender.Name = "stdgender"
        stdgender.Size = New Size(115, 45)
        stdgender.TabIndex = 8
        stdgender.Text = "Gender :"
        ' 
        ' stdskillbtn
        ' 
        stdskillbtn.AutoSize = True
        stdskillbtn.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdskillbtn.Location = New Point(695, 265)
        stdskillbtn.Name = "stdskillbtn"
        stdskillbtn.Size = New Size(94, 45)
        stdskillbtn.TabIndex = 9
        stdskillbtn.Text = "Skills :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(836, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' stdname
        ' 
        stdname.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stdname.Location = New Point(253, 124)
        stdname.Name = "stdname"
        stdname.Size = New Size(391, 43)
        stdname.TabIndex = 11
        ' 
        ' stdage
        ' 
        stdage.Font = New Font("Consolas", 18F, FontStyle.Bold)
        stdage.Location = New Point(253, 188)
        stdage.Name = "stdage"
        stdage.Size = New Size(391, 43)
        stdage.TabIndex = 12
        ' 
        ' stdphno
        ' 
        stdphno.Font = New Font("Consolas", 18F, FontStyle.Bold)
        stdphno.Location = New Point(253, 251)
        stdphno.Name = "stdphno"
        stdphno.Size = New Size(391, 43)
        stdphno.TabIndex = 13
        ' 
        ' stdemail
        ' 
        stdemail.Font = New Font("Consolas", 18F, FontStyle.Bold)
        stdemail.Location = New Point(253, 316)
        stdemail.Name = "stdemail"
        stdemail.Size = New Size(391, 43)
        stdemail.TabIndex = 14
        ' 
        ' bdate
        ' 
        bdate.Font = New Font("Consolas", 18F, FontStyle.Bold)
        bdate.Format = DateTimePickerFormat.Custom
        bdate.Location = New Point(253, 376)
        bdate.Name = "bdate"
        bdate.Size = New Size(391, 43)
        bdate.TabIndex = 15
        bdate.Value = New Date(2024, 1, 28, 14, 8, 22, 0)
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(bcabtn)
        Panel1.Controls.Add(bcombtn)
        Panel1.Controls.Add(bbabtn)
        Panel1.Font = New Font("Consolas", 18F, FontStyle.Bold)
        Panel1.Location = New Point(253, 426)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(391, 60)
        Panel1.TabIndex = 16
        ' 
        ' bcabtn
        ' 
        bcabtn.AutoSize = True
        bcabtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        bcabtn.Location = New Point(296, 14)
        bcabtn.Name = "bcabtn"
        bcabtn.Size = New Size(84, 40)
        bcabtn.TabIndex = 2
        bcabtn.TabStop = True
        bcabtn.Text = "BCA"
        bcabtn.UseVisualStyleBackColor = True
        ' 
        ' bcombtn
        ' 
        bcombtn.AutoSize = True
        bcombtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        bcombtn.Location = New Point(3, 14)
        bcombtn.Name = "bcombtn"
        bcombtn.Size = New Size(116, 40)
        bcombtn.TabIndex = 1
        bcombtn.TabStop = True
        bcombtn.Text = "B.com"
        bcombtn.UseVisualStyleBackColor = True
        ' 
        ' bbabtn
        ' 
        bbabtn.AutoSize = True
        bbabtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        bbabtn.Location = New Point(156, 14)
        bbabtn.Name = "bbabtn"
        bbabtn.Size = New Size(84, 40)
        bbabtn.TabIndex = 0
        bbabtn.TabStop = True
        bbabtn.Text = "BBA"
        bbabtn.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Consolas", 18F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"F.Y.SEM - 1", "F.Y.SEM - 2", "S.Y.SEM - 3", "S.Y.SEM - 4", "T.Y.SEM - 5", "T.Y.SEM - 6"})
        ComboBox1.Location = New Point(253, 493)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(391, 44)
        ComboBox1.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(malebtn)
        Panel2.Controls.Add(femalebtn)
        Panel2.Location = New Point(253, 544)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 60)
        Panel2.TabIndex = 18
        ' 
        ' malebtn
        ' 
        malebtn.AutoSize = True
        malebtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        malebtn.Location = New Point(3, 14)
        malebtn.Name = "malebtn"
        malebtn.Size = New Size(100, 40)
        malebtn.TabIndex = 1
        malebtn.TabStop = True
        malebtn.Text = "MALE"
        malebtn.UseVisualStyleBackColor = True
        ' 
        ' femalebtn
        ' 
        femalebtn.AutoSize = True
        femalebtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        femalebtn.Location = New Point(156, 14)
        femalebtn.Name = "femalebtn"
        femalebtn.Size = New Size(132, 40)
        femalebtn.TabIndex = 0
        femalebtn.TabStop = True
        femalebtn.Text = "FEMALE"
        femalebtn.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Consolas", 18F, FontStyle.Bold)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 36
        ListBox1.Items.AddRange(New Object() {"----------------"})
        ListBox1.Location = New Point(795, 362)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(303, 184)
        ListBox1.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 18F, FontStyle.Bold)
        TextBox1.Location = New Point(795, 267)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(303, 43)
        TextBox1.TabIndex = 20
        ' 
        ' addbtn
        ' 
        addbtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        addbtn.Location = New Point(859, 316)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(174, 40)
        addbtn.TabIndex = 21
        addbtn.Text = "ADD"
        addbtn.UseVisualStyleBackColor = True
        ' 
        ' favsportlbl
        ' 
        favsportlbl.AutoSize = True
        favsportlbl.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        favsportlbl.Location = New Point(22, 617)
        favsportlbl.Name = "favsportlbl"
        favsportlbl.Size = New Size(210, 45)
        favsportlbl.TabIndex = 22
        favsportlbl.Text = "Favorite Sports :"
        ' 
        ' submitbtn
        ' 
        submitbtn.BackColor = SystemColors.GradientActiveCaption
        submitbtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        submitbtn.Location = New Point(518, 701)
        submitbtn.Name = "submitbtn"
        submitbtn.Size = New Size(137, 51)
        submitbtn.TabIndex = 27
        submitbtn.Text = "SUBMIT"
        submitbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(otr)
        Panel3.Controls.Add(tns)
        Panel3.Controls.Add(crkt)
        Panel3.Controls.Add(bdmtn)
        Panel3.Location = New Point(253, 617)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(641, 52)
        Panel3.TabIndex = 28
        ' 
        ' otr
        ' 
        otr.AutoSize = True
        otr.Font = New Font("Consolas", 18F, FontStyle.Bold)
        otr.Location = New Point(516, 1)
        otr.Name = "otr"
        otr.Size = New Size(117, 40)
        otr.TabIndex = 30
        otr.Text = "Other"
        otr.UseVisualStyleBackColor = True
        ' 
        ' tns
        ' 
        tns.AutoSize = True
        tns.Font = New Font("Consolas", 18F, FontStyle.Bold)
        tns.Location = New Point(366, 5)
        tns.Name = "tns"
        tns.Size = New Size(133, 40)
        tns.TabIndex = 29
        tns.Text = "Tennis"
        tns.UseVisualStyleBackColor = True
        ' 
        ' crkt
        ' 
        crkt.AutoSize = True
        crkt.Font = New Font("Consolas", 18F, FontStyle.Bold)
        crkt.Location = New Point(200, 5)
        crkt.Name = "crkt"
        crkt.Size = New Size(149, 40)
        crkt.TabIndex = 28
        crkt.Text = "Cricket"
        crkt.UseVisualStyleBackColor = True
        ' 
        ' bdmtn
        ' 
        bdmtn.AutoSize = True
        bdmtn.Font = New Font("Consolas", 18F, FontStyle.Bold)
        bdmtn.Location = New Point(1, 5)
        bdmtn.Name = "bdmtn"
        bdmtn.Size = New Size(181, 40)
        bdmtn.TabIndex = 27
        bdmtn.Text = "Badminton"
        bdmtn.UseVisualStyleBackColor = True
        ' 
        ' inputDisplayInMsgBox
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1110, 764)
        Controls.Add(Panel3)
        Controls.Add(submitbtn)
        Controls.Add(favsportlbl)
        Controls.Add(addbtn)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(Panel2)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        Controls.Add(bdate)
        Controls.Add(stdemail)
        Controls.Add(stdphno)
        Controls.Add(stdage)
        Controls.Add(stdname)
        Controls.Add(PictureBox1)
        Controls.Add(stdskillbtn)
        Controls.Add(stdgender)
        Controls.Add(stdemaillbl)
        Controls.Add(stdysemlbl)
        Controls.Add(stdcourselbl)
        Controls.Add(stdbdatelbl)
        Controls.Add(stdphnolbl)
        Controls.Add(stdagee)
        Controls.Add(stdnamelbl)
        Controls.Add(titlelbl)
        Name = "inputDisplayInMsgBox"
        Text = "inputDisplayInMsgBox"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents stdnamelbl As Label
    Friend WithEvents stdagee As Label
    Friend WithEvents stdphnolbl As Label
    Friend WithEvents stdbdatelbl As Label
    Friend WithEvents stdcourselbl As Label
    Friend WithEvents stdysemlbl As Label
    Friend WithEvents stdemaillbl As Label
    Friend WithEvents stdgender As Label
    Friend WithEvents stdskillbtn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents stdname As TextBox
    Friend WithEvents stdage As TextBox
    Friend WithEvents stdphno As TextBox
    Friend WithEvents stdemail As TextBox
    Friend WithEvents bdate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bcombtn As RadioButton
    Friend WithEvents bbabtn As RadioButton
    Friend WithEvents bcabtn As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents malebtn As RadioButton
    Friend WithEvents femalebtn As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents favsportlbl As Label
    Friend WithEvents submitbtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents otr As CheckBox
    Friend WithEvents tns As CheckBox
    Friend WithEvents crkt As CheckBox
    Friend WithEvents bdmtn As CheckBox
End Class
