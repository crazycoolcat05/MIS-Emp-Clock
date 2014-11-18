<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProject
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblClientAddr = New System.Windows.Forms.Label()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblEmpNameF = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(134, 70)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 52
        '
        'lblEmpNameL
        '
        Me.lblEmpNameL.AutoSize = True
        Me.lblEmpNameL.Location = New System.Drawing.Point(22, 51)
        Me.lblEmpNameL.Name = "lblEmpNameL"
        Me.lblEmpNameL.Size = New System.Drawing.Size(54, 13)
        Me.lblEmpNameL.TabIndex = 51
        Me.lblEmpNameL.Text = "Project ID"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Ext"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(304, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Accept"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(134, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 44
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(134, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 43
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 42
        '
        'lblClientAddr
        '
        Me.lblClientAddr.AutoSize = True
        Me.lblClientAddr.Location = New System.Drawing.Point(22, 103)
        Me.lblClientAddr.Name = "lblClientAddr"
        Me.lblClientAddr.Size = New System.Drawing.Size(67, 13)
        Me.lblClientAddr.TabIndex = 38
        Me.lblClientAddr.Text = "Charge Rate"
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(22, 77)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(82, 13)
        Me.lblEmpID.TabIndex = 37
        Me.lblEmpID.Text = "Linked Client ID"
        '
        'lblEmpNameF
        '
        Me.lblEmpNameF.AutoSize = True
        Me.lblEmpNameF.Location = New System.Drawing.Point(22, 25)
        Me.lblEmpNameF.Name = "lblEmpNameF"
        Me.lblEmpNameF.Size = New System.Drawing.Size(71, 13)
        Me.lblEmpNameF.TabIndex = 36
        Me.lblEmpNameF.Text = "Project Name"
        '
        'frmNewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 146)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblEmpNameL)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblClientAddr)
        Me.Controls.Add(Me.lblEmpID)
        Me.Controls.Add(Me.lblEmpNameF)
        Me.Name = "frmNewProject"
        Me.Text = "New Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpNameL As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblClientAddr As System.Windows.Forms.Label
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents lblEmpNameF As System.Windows.Forms.Label
End Class
