<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateProject
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
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblEmpNameL = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblClientAddr = New System.Windows.Forms.Label()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblEmpNameF = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(124, 74)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 63
        '
        'lblEmpNameL
        '
        Me.lblEmpNameL.AutoSize = True
        Me.lblEmpNameL.Location = New System.Drawing.Point(12, 55)
        Me.lblEmpNameL.Name = "lblEmpNameL"
        Me.lblEmpNameL.Size = New System.Drawing.Size(54, 13)
        Me.lblEmpNameL.TabIndex = 62
        Me.lblEmpNameL.Text = "Project ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(124, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 58
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 57
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 56
        '
        'lblClientAddr
        '
        Me.lblClientAddr.AutoSize = True
        Me.lblClientAddr.Location = New System.Drawing.Point(12, 107)
        Me.lblClientAddr.Name = "lblClientAddr"
        Me.lblClientAddr.Size = New System.Drawing.Size(67, 13)
        Me.lblClientAddr.TabIndex = 55
        Me.lblClientAddr.Text = "Charge Rate"
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(12, 81)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(82, 13)
        Me.lblEmpID.TabIndex = 54
        Me.lblEmpID.Text = "Linked Client ID"
        '
        'lblEmpNameF
        '
        Me.lblEmpNameF.AutoSize = True
        Me.lblEmpNameF.Location = New System.Drawing.Point(12, 29)
        Me.lblEmpNameF.Name = "lblEmpNameF"
        Me.lblEmpNameF.Size = New System.Drawing.Size(71, 13)
        Me.lblEmpNameF.TabIndex = 53
        Me.lblEmpNameF.Text = "Project Name"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(296, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(296, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(296, 47)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "Deactivate"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(296, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "Update"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmUpdateProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 159)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblEmpNameL)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblClientAddr)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.lblEmpNameF)
        Me.Name = "frmUpdateProject"
        Me.Text = "Update Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpNameL As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblClientAddr As System.Windows.Forms.Label
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents lblEmpNameF As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
