<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualAdd
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
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblProjectID = New System.Windows.Forms.Label()
        Me.lblWorkDateStart = New System.Windows.Forms.Label()
        Me.lblWorkDateEnd = New System.Windows.Forms.Label()
        Me.lblWorkTimeStart = New System.Windows.Forms.Label()
        Me.lblWorkTimeEnd = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnFindEmpID = New System.Windows.Forms.Button()
        Me.btnFindProjID = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(22, 40)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "Employee ID"
        '
        'lblProjectID
        '
        Me.lblProjectID.AutoSize = True
        Me.lblProjectID.Location = New System.Drawing.Point(22, 76)
        Me.lblProjectID.Name = "lblProjectID"
        Me.lblProjectID.Size = New System.Drawing.Size(54, 13)
        Me.lblProjectID.TabIndex = 1
        Me.lblProjectID.Text = "Project ID"
        '
        'lblWorkDateStart
        '
        Me.lblWorkDateStart.AutoSize = True
        Me.lblWorkDateStart.Location = New System.Drawing.Point(22, 110)
        Me.lblWorkDateStart.Name = "lblWorkDateStart"
        Me.lblWorkDateStart.Size = New System.Drawing.Size(84, 13)
        Me.lblWorkDateStart.TabIndex = 2
        Me.lblWorkDateStart.Text = "Work Start Date"
        '
        'lblWorkDateEnd
        '
        Me.lblWorkDateEnd.AutoSize = True
        Me.lblWorkDateEnd.Location = New System.Drawing.Point(22, 142)
        Me.lblWorkDateEnd.Name = "lblWorkDateEnd"
        Me.lblWorkDateEnd.Size = New System.Drawing.Size(81, 13)
        Me.lblWorkDateEnd.TabIndex = 3
        Me.lblWorkDateEnd.Text = "Work End Date"
        '
        'lblWorkTimeStart
        '
        Me.lblWorkTimeStart.AutoSize = True
        Me.lblWorkTimeStart.Location = New System.Drawing.Point(22, 175)
        Me.lblWorkTimeStart.Name = "lblWorkTimeStart"
        Me.lblWorkTimeStart.Size = New System.Drawing.Size(84, 13)
        Me.lblWorkTimeStart.TabIndex = 4
        Me.lblWorkTimeStart.Text = "Work Start Time"
        '
        'lblWorkTimeEnd
        '
        Me.lblWorkTimeEnd.AutoSize = True
        Me.lblWorkTimeEnd.Location = New System.Drawing.Point(22, 210)
        Me.lblWorkTimeEnd.Name = "lblWorkTimeEnd"
        Me.lblWorkTimeEnd.Size = New System.Drawing.Size(81, 13)
        Me.lblWorkTimeEnd.TabIndex = 5
        Me.lblWorkTimeEnd.Text = "Work End Time"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(136, 135)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(136, 168)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(136, 203)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'btnFindEmpID
        '
        Me.btnFindEmpID.Location = New System.Drawing.Point(256, 34)
        Me.btnFindEmpID.Name = "btnFindEmpID"
        Me.btnFindEmpID.Size = New System.Drawing.Size(105, 23)
        Me.btnFindEmpID.TabIndex = 13
        Me.btnFindEmpID.Text = "Find Employee ID"
        Me.btnFindEmpID.UseVisualStyleBackColor = True
        '
        'btnFindProjID
        '
        Me.btnFindProjID.Location = New System.Drawing.Point(256, 66)
        Me.btnFindProjID.Name = "btnFindProjID"
        Me.btnFindProjID.Size = New System.Drawing.Size(105, 23)
        Me.btnFindProjID.TabIndex = 14
        Me.btnFindProjID.Text = "Find Project ID"
        Me.btnFindProjID.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(159, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(41, 256)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(64, 23)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmManualAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFindProjID)
        Me.Controls.Add(Me.btnFindEmpID)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblWorkTimeEnd)
        Me.Controls.Add(Me.lblWorkTimeStart)
        Me.Controls.Add(Me.lblWorkDateEnd)
        Me.Controls.Add(Me.lblWorkDateStart)
        Me.Controls.Add(Me.lblProjectID)
        Me.Controls.Add(Me.lblEmpID)
        Me.Name = "frmManualAdd"
        Me.Text = "Manually Add Work"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents lblProjectID As System.Windows.Forms.Label
    Friend WithEvents lblWorkDateStart As System.Windows.Forms.Label
    Friend WithEvents lblWorkDateEnd As System.Windows.Forms.Label
    Friend WithEvents lblWorkTimeStart As System.Windows.Forms.Label
    Friend WithEvents lblWorkTimeEnd As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btnFindEmpID As System.Windows.Forms.Button
    Friend WithEvents btnFindProjID As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
