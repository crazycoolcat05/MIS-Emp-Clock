﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpsClock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpsClock))
        Me.tabEmpsClock = New System.Windows.Forms.TabControl()
        Me.tabEmployee = New System.Windows.Forms.TabPage()
        Me.Submitted_WorkDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.lblSubmittedWorkEmp = New System.Windows.Forms.Label()
        Me.lstProject = New System.Windows.Forms.ListBox()
        Me.lstProfile = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblShowTimer = New System.Windows.Forms.Label()
        Me.lblTimerDescrip = New System.Windows.Forms.Label()
        Me.lblShowTimeE = New System.Windows.Forms.Label()
        Me.lblShowDateE = New System.Windows.Forms.Label()
        Me.lblTimeDescripE = New System.Windows.Forms.Label()
        Me.lblDateDescripE = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.tabAdmin = New System.Windows.Forms.TabPage()
        Me.Submitted_WorkDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnManualAdd = New System.Windows.Forms.Button()
        Me.lblShowTimeA = New System.Windows.Forms.Label()
        Me.lblShowDateA = New System.Windows.Forms.Label()
        Me.lblTimeDescripA = New System.Windows.Forms.Label()
        Me.lblDateDescripA = New System.Windows.Forms.Label()
        Me.lblSubmittedWork = New System.Windows.Forms.Label()
        Me.btnCreateProject = New System.Windows.Forms.Button()
        Me.btnCreateClient = New System.Windows.Forms.Button()
        Me.btnCreateEmp = New System.Windows.Forms.Button()
        Me.lstProjects = New System.Windows.Forms.ListBox()
        Me.lstClients = New System.Windows.Forms.ListBox()
        Me.lstEmployees = New System.Windows.Forms.ListBox()
        Me.lblProjects = New System.Windows.Forms.Label()
        Me.lblClients = New System.Windows.Forms.Label()
        Me.lbEmployees = New System.Windows.Forms.Label()
        Me.Submitted_WorkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Submitted_WorkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Submitted_WorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TheEmployeesClock_dBDataSet = New TheEmployeesClock._TheEmployeesClock_dBDataSet()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Submitted_WorkTableAdapter = New TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.Submitted_WorkTableAdapter()
        Me.TableAdapterManager = New TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.TableAdapterManager()
        Me.EmployeesTableAdapter = New TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.EmployeesTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tabEmpsClock.SuspendLayout()
        Me.tabEmployee.SuspendLayout()
        CType(Me.Submitted_WorkDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdmin.SuspendLayout()
        CType(Me.Submitted_WorkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Submitted_WorkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Submitted_WorkBindingNavigator.SuspendLayout()
        CType(Me.Submitted_WorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TheEmployeesClock_dBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabEmpsClock
        '
        Me.tabEmpsClock.Controls.Add(Me.tabEmployee)
        Me.tabEmpsClock.Controls.Add(Me.tabAdmin)
        Me.tabEmpsClock.Location = New System.Drawing.Point(12, 28)
        Me.tabEmpsClock.Name = "tabEmpsClock"
        Me.tabEmpsClock.SelectedIndex = 0
        Me.tabEmpsClock.Size = New System.Drawing.Size(1207, 490)
        Me.tabEmpsClock.TabIndex = 0
        '
        'tabEmployee
        '
        Me.tabEmployee.AutoScroll = True
        Me.tabEmployee.Controls.Add(Me.ComboBox1)
        Me.tabEmployee.Controls.Add(Me.Submitted_WorkDataGridView1)
        Me.tabEmployee.Controls.Add(Me.btnPause)
        Me.tabEmployee.Controls.Add(Me.lblSubmittedWorkEmp)
        Me.tabEmployee.Controls.Add(Me.lstProject)
        Me.tabEmployee.Controls.Add(Me.lstProfile)
        Me.tabEmployee.Controls.Add(Me.btnReset)
        Me.tabEmployee.Controls.Add(Me.btnStop)
        Me.tabEmployee.Controls.Add(Me.btnStart)
        Me.tabEmployee.Controls.Add(Me.lblShowTimer)
        Me.tabEmployee.Controls.Add(Me.lblTimerDescrip)
        Me.tabEmployee.Controls.Add(Me.lblShowTimeE)
        Me.tabEmployee.Controls.Add(Me.lblShowDateE)
        Me.tabEmployee.Controls.Add(Me.lblTimeDescripE)
        Me.tabEmployee.Controls.Add(Me.lblDateDescripE)
        Me.tabEmployee.Controls.Add(Me.lblProject)
        Me.tabEmployee.Controls.Add(Me.lblProfile)
        Me.tabEmployee.Location = New System.Drawing.Point(4, 22)
        Me.tabEmployee.Name = "tabEmployee"
        Me.tabEmployee.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmployee.Size = New System.Drawing.Size(1199, 464)
        Me.tabEmployee.TabIndex = 1
        Me.tabEmployee.Text = "Employees"
        Me.tabEmployee.UseVisualStyleBackColor = True
        '
        'Submitted_WorkDataGridView1
        '
        Me.Submitted_WorkDataGridView1.AutoGenerateColumns = False
        Me.Submitted_WorkDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Submitted_WorkDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.Submitted_WorkDataGridView1.DataSource = Me.Submitted_WorkBindingSource
        Me.Submitted_WorkDataGridView1.Location = New System.Drawing.Point(11, 242)
        Me.Submitted_WorkDataGridView1.Name = "Submitted_WorkDataGridView1"
        Me.Submitted_WorkDataGridView1.Size = New System.Drawing.Size(1157, 194)
        Me.Submitted_WorkDataGridView1.TabIndex = 16
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(772, 111)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 16
        Me.btnPause.Text = "PAUSE"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'lblSubmittedWorkEmp
        '
        Me.lblSubmittedWorkEmp.AutoSize = True
        Me.lblSubmittedWorkEmp.Location = New System.Drawing.Point(530, 208)
        Me.lblSubmittedWorkEmp.Name = "lblSubmittedWorkEmp"
        Me.lblSubmittedWorkEmp.Size = New System.Drawing.Size(159, 13)
        Me.lblSubmittedWorkEmp.TabIndex = 15
        Me.lblSubmittedWorkEmp.Text = "Your Previously Submitted Work"
        '
        'lstProject
        '
        Me.lstProject.FormattingEnabled = True
        Me.lstProject.Location = New System.Drawing.Point(122, 75)
        Me.lstProject.Name = "lstProject"
        Me.lstProject.Size = New System.Drawing.Size(120, 30)
        Me.lstProject.TabIndex = 14
        '
        'lstProfile
        '
        Me.lstProfile.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeesBindingSource, "emp_id", True))
        Me.lstProfile.FormattingEnabled = True
        Me.lstProfile.Location = New System.Drawing.Point(122, 27)
        Me.lstProfile.Name = "lstProfile"
        Me.lstProfile.Size = New System.Drawing.Size(120, 30)
        Me.lstProfile.TabIndex = 13
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1118, 6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(908, 82)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(772, 82)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblShowTimer
        '
        Me.lblShowTimer.AutoSize = True
        Me.lblShowTimer.Location = New System.Drawing.Point(862, 50)
        Me.lblShowTimer.Name = "lblShowTimer"
        Me.lblShowTimer.Size = New System.Drawing.Size(43, 13)
        Me.lblShowTimer.TabIndex = 9
        Me.lblShowTimer.Text = "xx:xx:xx"
        '
        'lblTimerDescrip
        '
        Me.lblTimerDescrip.AutoSize = True
        Me.lblTimerDescrip.Location = New System.Drawing.Point(840, 26)
        Me.lblTimerDescrip.Name = "lblTimerDescrip"
        Me.lblTimerDescrip.Size = New System.Drawing.Size(95, 13)
        Me.lblTimerDescrip.TabIndex = 8
        Me.lblTimerDescrip.Text = "RUNNING TIMER"
        '
        'lblShowTimeE
        '
        Me.lblShowTimeE.AutoSize = True
        Me.lblShowTimeE.Location = New System.Drawing.Point(500, 75)
        Me.lblShowTimeE.Name = "lblShowTimeE"
        Me.lblShowTimeE.Size = New System.Drawing.Size(79, 13)
        Me.lblShowTimeE.TabIndex = 7
        Me.lblShowTimeE.Text = "xx:xx:xx am/pm"
        '
        'lblShowDateE
        '
        Me.lblShowDateE.AutoSize = True
        Me.lblShowDateE.Location = New System.Drawing.Point(500, 34)
        Me.lblShowDateE.Name = "lblShowDateE"
        Me.lblShowDateE.Size = New System.Drawing.Size(73, 13)
        Me.lblShowDateE.TabIndex = 6
        Me.lblShowDateE.Text = "XX/XX/XXXX"
        '
        'lblTimeDescripE
        '
        Me.lblTimeDescripE.AutoSize = True
        Me.lblTimeDescripE.Location = New System.Drawing.Point(404, 75)
        Me.lblTimeDescripE.Name = "lblTimeDescripE"
        Me.lblTimeDescripE.Size = New System.Drawing.Size(70, 13)
        Me.lblTimeDescripE.TabIndex = 5
        Me.lblTimeDescripE.Text = "Current Time:"
        '
        'lblDateDescripE
        '
        Me.lblDateDescripE.AutoSize = True
        Me.lblDateDescripE.Location = New System.Drawing.Point(404, 34)
        Me.lblDateDescripE.Name = "lblDateDescripE"
        Me.lblDateDescripE.Size = New System.Drawing.Size(70, 13)
        Me.lblDateDescripE.TabIndex = 4
        Me.lblDateDescripE.Text = "Current Date:"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(19, 75)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(76, 13)
        Me.lblProject.TabIndex = 1
        Me.lblProject.Text = "Select Project:"
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Location = New System.Drawing.Point(19, 27)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(72, 13)
        Me.lblProfile.TabIndex = 0
        Me.lblProfile.Text = "Select Profile:"
        '
        'tabAdmin
        '
        Me.tabAdmin.AutoScroll = True
        Me.tabAdmin.Controls.Add(Me.Submitted_WorkDataGridView)
        Me.tabAdmin.Controls.Add(Me.btnSearch)
        Me.tabAdmin.Controls.Add(Me.btnManualAdd)
        Me.tabAdmin.Controls.Add(Me.lblShowTimeA)
        Me.tabAdmin.Controls.Add(Me.lblShowDateA)
        Me.tabAdmin.Controls.Add(Me.lblTimeDescripA)
        Me.tabAdmin.Controls.Add(Me.lblDateDescripA)
        Me.tabAdmin.Controls.Add(Me.lblSubmittedWork)
        Me.tabAdmin.Controls.Add(Me.btnCreateProject)
        Me.tabAdmin.Controls.Add(Me.btnCreateClient)
        Me.tabAdmin.Controls.Add(Me.btnCreateEmp)
        Me.tabAdmin.Controls.Add(Me.lstProjects)
        Me.tabAdmin.Controls.Add(Me.lstClients)
        Me.tabAdmin.Controls.Add(Me.lstEmployees)
        Me.tabAdmin.Controls.Add(Me.lblProjects)
        Me.tabAdmin.Controls.Add(Me.lblClients)
        Me.tabAdmin.Controls.Add(Me.lbEmployees)
        Me.tabAdmin.Location = New System.Drawing.Point(4, 22)
        Me.tabAdmin.Name = "tabAdmin"
        Me.tabAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdmin.Size = New System.Drawing.Size(1199, 464)
        Me.tabAdmin.TabIndex = 0
        Me.tabAdmin.Text = "Admin"
        Me.tabAdmin.UseVisualStyleBackColor = True
        '
        'Submitted_WorkDataGridView
        '
        Me.Submitted_WorkDataGridView.AutoGenerateColumns = False
        Me.Submitted_WorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Submitted_WorkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Submitted_WorkDataGridView.DataSource = Me.Submitted_WorkBindingSource
        Me.Submitted_WorkDataGridView.Location = New System.Drawing.Point(15, 221)
        Me.Submitted_WorkDataGridView.Name = "Submitted_WorkDataGridView"
        Me.Submitted_WorkDataGridView.Size = New System.Drawing.Size(1157, 219)
        Me.Submitted_WorkDataGridView.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1097, 185)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnManualAdd
        '
        Me.btnManualAdd.Location = New System.Drawing.Point(1080, 6)
        Me.btnManualAdd.Name = "btnManualAdd"
        Me.btnManualAdd.Size = New System.Drawing.Size(113, 23)
        Me.btnManualAdd.TabIndex = 15
        Me.btnManualAdd.Text = "Manually Add Work"
        Me.btnManualAdd.UseVisualStyleBackColor = True
        '
        'lblShowTimeA
        '
        Me.lblShowTimeA.AutoSize = True
        Me.lblShowTimeA.Location = New System.Drawing.Point(847, 96)
        Me.lblShowTimeA.Name = "lblShowTimeA"
        Me.lblShowTimeA.Size = New System.Drawing.Size(79, 13)
        Me.lblShowTimeA.TabIndex = 14
        Me.lblShowTimeA.Text = "xx:xx:xx am/pm"
        '
        'lblShowDateA
        '
        Me.lblShowDateA.AutoSize = True
        Me.lblShowDateA.Location = New System.Drawing.Point(847, 55)
        Me.lblShowDateA.Name = "lblShowDateA"
        Me.lblShowDateA.Size = New System.Drawing.Size(73, 13)
        Me.lblShowDateA.TabIndex = 13
        Me.lblShowDateA.Text = "XX/XX/XXXX"
        '
        'lblTimeDescripA
        '
        Me.lblTimeDescripA.AutoSize = True
        Me.lblTimeDescripA.Location = New System.Drawing.Point(751, 96)
        Me.lblTimeDescripA.Name = "lblTimeDescripA"
        Me.lblTimeDescripA.Size = New System.Drawing.Size(70, 13)
        Me.lblTimeDescripA.TabIndex = 12
        Me.lblTimeDescripA.Text = "Current Time:"
        '
        'lblDateDescripA
        '
        Me.lblDateDescripA.AutoSize = True
        Me.lblDateDescripA.Location = New System.Drawing.Point(751, 55)
        Me.lblDateDescripA.Name = "lblDateDescripA"
        Me.lblDateDescripA.Size = New System.Drawing.Size(70, 13)
        Me.lblDateDescripA.TabIndex = 11
        Me.lblDateDescripA.Text = "Current Date:"
        '
        'lblSubmittedWork
        '
        Me.lblSubmittedWork.AutoSize = True
        Me.lblSubmittedWork.Location = New System.Drawing.Point(588, 185)
        Me.lblSubmittedWork.Name = "lblSubmittedWork"
        Me.lblSubmittedWork.Size = New System.Drawing.Size(83, 13)
        Me.lblSubmittedWork.TabIndex = 9
        Me.lblSubmittedWork.Text = "Submitted Work"
        '
        'btnCreateProject
        '
        Me.btnCreateProject.Location = New System.Drawing.Point(472, 146)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateProject.TabIndex = 8
        Me.btnCreateProject.Text = "Create New"
        Me.btnCreateProject.UseVisualStyleBackColor = True
        '
        'btnCreateClient
        '
        Me.btnCreateClient.Location = New System.Drawing.Point(280, 146)
        Me.btnCreateClient.Name = "btnCreateClient"
        Me.btnCreateClient.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateClient.TabIndex = 7
        Me.btnCreateClient.Text = "Create New"
        Me.btnCreateClient.UseVisualStyleBackColor = True
        '
        'btnCreateEmp
        '
        Me.btnCreateEmp.Location = New System.Drawing.Point(93, 146)
        Me.btnCreateEmp.Name = "btnCreateEmp"
        Me.btnCreateEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateEmp.TabIndex = 6
        Me.btnCreateEmp.Text = "Create New"
        Me.btnCreateEmp.UseVisualStyleBackColor = True
        '
        'lstProjects
        '
        Me.lstProjects.FormattingEnabled = True
        Me.lstProjects.Location = New System.Drawing.Point(427, 45)
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(120, 95)
        Me.lstProjects.TabIndex = 5
        '
        'lstClients
        '
        Me.lstClients.FormattingEnabled = True
        Me.lstClients.Location = New System.Drawing.Point(235, 45)
        Me.lstClients.Name = "lstClients"
        Me.lstClients.Size = New System.Drawing.Size(120, 95)
        Me.lstClients.TabIndex = 4
        '
        'lstEmployees
        '
        Me.lstEmployees.FormattingEnabled = True
        Me.lstEmployees.Location = New System.Drawing.Point(48, 45)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(120, 95)
        Me.lstEmployees.TabIndex = 3
        '
        'lblProjects
        '
        Me.lblProjects.AutoSize = True
        Me.lblProjects.Location = New System.Drawing.Point(424, 20)
        Me.lblProjects.Name = "lblProjects"
        Me.lblProjects.Size = New System.Drawing.Size(45, 13)
        Me.lblProjects.TabIndex = 2
        Me.lblProjects.Text = "Projects"
        '
        'lblClients
        '
        Me.lblClients.AutoSize = True
        Me.lblClients.Location = New System.Drawing.Point(232, 20)
        Me.lblClients.Name = "lblClients"
        Me.lblClients.Size = New System.Drawing.Size(38, 13)
        Me.lblClients.TabIndex = 1
        Me.lblClients.Text = "Clients"
        '
        'lbEmployees
        '
        Me.lbEmployees.AutoSize = True
        Me.lbEmployees.Location = New System.Drawing.Point(45, 20)
        Me.lbEmployees.Name = "lbEmployees"
        Me.lbEmployees.Size = New System.Drawing.Size(58, 13)
        Me.lbEmployees.TabIndex = 0
        Me.lbEmployees.Text = "Employees"
        '
        'Submitted_WorkBindingNavigator
        '
        Me.Submitted_WorkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Submitted_WorkBindingNavigator.BindingSource = Me.Submitted_WorkBindingSource
        Me.Submitted_WorkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Submitted_WorkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Submitted_WorkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Submitted_WorkBindingNavigatorSaveItem})
        Me.Submitted_WorkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Submitted_WorkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Submitted_WorkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Submitted_WorkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Submitted_WorkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Submitted_WorkBindingNavigator.Name = "Submitted_WorkBindingNavigator"
        Me.Submitted_WorkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Submitted_WorkBindingNavigator.Size = New System.Drawing.Size(1231, 25)
        Me.Submitted_WorkBindingNavigator.TabIndex = 1
        Me.Submitted_WorkBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Submitted_WorkBindingNavigatorSaveItem
        '
        Me.Submitted_WorkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Submitted_WorkBindingNavigatorSaveItem.Image = CType(resources.GetObject("Submitted_WorkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Submitted_WorkBindingNavigatorSaveItem.Name = "Submitted_WorkBindingNavigatorSaveItem"
        Me.Submitted_WorkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Submitted_WorkBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Submitted_WorkBindingSource
        '
        Me.Submitted_WorkBindingSource.DataMember = "Submitted_Work"
        Me.Submitted_WorkBindingSource.DataSource = Me._TheEmployeesClock_dBDataSet
        '
        '_TheEmployeesClock_dBDataSet
        '
        Me._TheEmployeesClock_dBDataSet.DataSetName = "_TheEmployeesClock_dBDataSet"
        Me._TheEmployeesClock_dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "emp_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "emp_id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "project_id"
        Me.DataGridViewTextBoxColumn14.HeaderText = "project_id"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "time_startdate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "time_startdate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "time_enddate"
        Me.DataGridViewTextBoxColumn16.HeaderText = "time_enddate"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "time_startime"
        Me.DataGridViewTextBoxColumn17.HeaderText = "time_startime"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "time_endtime"
        Me.DataGridViewTextBoxColumn18.HeaderText = "time_endtime"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "total_time_worked"
        Me.DataGridViewTextBoxColumn19.HeaderText = "total_time_worked"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "approval_status"
        Me.DataGridViewTextBoxColumn20.HeaderText = "approval_status"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "emp_payment_status"
        Me.DataGridViewTextBoxColumn21.HeaderText = "emp_payment_status"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "client_payment_status"
        Me.DataGridViewTextBoxColumn22.HeaderText = "client_payment_status"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me._TheEmployeesClock_dBDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "emp_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "emp_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "project_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "project_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "time_startdate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "time_startdate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "time_enddate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "time_enddate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "time_startime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "time_startime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time_endtime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "time_endtime"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "total_time_worked"
        Me.DataGridViewTextBoxColumn8.HeaderText = "total_time_worked"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "approval_status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "approval_status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "emp_payment_status"
        Me.DataGridViewTextBoxColumn10.HeaderText = "emp_payment_status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "client_payment_status"
        Me.DataGridViewTextBoxColumn11.HeaderText = "client_payment_status"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Submitted_WorkTableAdapter
        '
        Me.Submitted_WorkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.ProjectsTableAdapter = Nothing
        Me.TableAdapterManager.Submitted_WorkTableAdapter = Me.Submitted_WorkTableAdapter
        Me.TableAdapterManager.UpdateOrder = TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'frmEmpsClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 530)
        Me.Controls.Add(Me.Submitted_WorkBindingNavigator)
        Me.Controls.Add(Me.tabEmpsClock)
        Me.Name = "frmEmpsClock"
        Me.Text = "The Employee's Clock"
        Me.tabEmpsClock.ResumeLayout(False)
        Me.tabEmployee.ResumeLayout(False)
        Me.tabEmployee.PerformLayout()
        CType(Me.Submitted_WorkDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdmin.ResumeLayout(False)
        Me.tabAdmin.PerformLayout()
        CType(Me.Submitted_WorkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Submitted_WorkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Submitted_WorkBindingNavigator.ResumeLayout(False)
        Me.Submitted_WorkBindingNavigator.PerformLayout()
        CType(Me.Submitted_WorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TheEmployeesClock_dBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabEmpsClock As System.Windows.Forms.TabControl
    Friend WithEvents tabAdmin As System.Windows.Forms.TabPage
    Friend WithEvents tabEmployee As System.Windows.Forms.TabPage
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblShowTimer As System.Windows.Forms.Label
    Friend WithEvents lblTimerDescrip As System.Windows.Forms.Label
    Friend WithEvents lblShowTimeE As System.Windows.Forms.Label
    Friend WithEvents lblShowDateE As System.Windows.Forms.Label
    Friend WithEvents lblTimeDescripE As System.Windows.Forms.Label
    Friend WithEvents lblDateDescripE As System.Windows.Forms.Label
    Friend WithEvents lblProject As System.Windows.Forms.Label
    Friend WithEvents lblProfile As System.Windows.Forms.Label
    Friend WithEvents lblSubmittedWork As System.Windows.Forms.Label
    Friend WithEvents btnCreateProject As System.Windows.Forms.Button
    Friend WithEvents btnCreateClient As System.Windows.Forms.Button
    Friend WithEvents btnCreateEmp As System.Windows.Forms.Button
    Friend WithEvents lstProjects As System.Windows.Forms.ListBox
    Friend WithEvents lstClients As System.Windows.Forms.ListBox
    Friend WithEvents lstEmployees As System.Windows.Forms.ListBox
    Friend WithEvents lblProjects As System.Windows.Forms.Label
    Friend WithEvents lblClients As System.Windows.Forms.Label
    Friend WithEvents lbEmployees As System.Windows.Forms.Label
    Friend WithEvents lstProject As System.Windows.Forms.ListBox
    Friend WithEvents lstProfile As System.Windows.Forms.ListBox
    Friend WithEvents lblSubmittedWorkEmp As System.Windows.Forms.Label
    Friend WithEvents lblShowTimeA As System.Windows.Forms.Label
    Friend WithEvents lblShowDateA As System.Windows.Forms.Label
    Friend WithEvents lblTimeDescripA As System.Windows.Forms.Label
    Friend WithEvents lblDateDescripA As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnManualAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents _TheEmployeesClock_dBDataSet As TheEmployeesClock._TheEmployeesClock_dBDataSet
    Friend WithEvents Submitted_WorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Submitted_WorkTableAdapter As TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.Submitted_WorkTableAdapter
    Friend WithEvents TableAdapterManager As TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Submitted_WorkBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Submitted_WorkBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Submitted_WorkDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Submitted_WorkDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As TheEmployeesClock._TheEmployeesClock_dBDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
