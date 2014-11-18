Public Class frmNewEmp

    Private Sub frmNewEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_TheEmployeesClock_dBDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me._TheEmployeesClock_dBDataSet.Employees)
        ' test github
    End Sub
End Class