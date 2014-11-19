
Public Class frmEmpsClock

    Private Sub Submitted_WorkBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Submitted_WorkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TheEmployeesClock_dBDataSet)

    End Sub

    Private Sub frmEmpsClock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TheEmployeesClock_dBDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me._TheEmployeesClock_dBDataSet.Employees)
        'TODO: This line of code loads data into the '_TheEmployeesClock_dBDataSet.Submitted_Work' table. You can move, or remove it, as needed.
        Me.Submitted_WorkTableAdapter.Fill(Me._TheEmployeesClock_dBDataSet.Submitted_Work)
        'TODO: This line of code loads data into the '_TheEmployeesClock_dBDataSet.Submitted_Work' table. You can move, or remove it, as needed.
        Me.Submitted_WorkTableAdapter.Fill(Me._TheEmployeesClock_dBDataSet.Submitted_Work)

    End Sub

    Private Sub Submitted_WorkBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles Submitted_WorkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Submitted_WorkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TheEmployeesClock_dBDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.EmployeesTableAdapter.FillBy(Me._TheEmployeesClock_dBDataSet.Employees)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCreateEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateEmp.Click
        frmNewEmp.Show()
    End Sub

    Private Sub lstProfile_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstProfile.SelectedIndexChanged
        ' employee selects their profile, and is prompted with dialog box to enter password
        MessageBox.Show("Enter your password.")
    End Sub

    ' Populate Employee listbox with profile names
    Public Sub LoadWorkItem()
        ' Load the data
        ' Select records

    End Sub
End Class
