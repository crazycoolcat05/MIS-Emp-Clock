Public Class frmEmpsClock

    Private Sub btnCreateEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateEmp.Click
        frmNewEmp.Show()
    End Sub

    Private Sub Submitted_WorkBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Submitted_WorkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TheEmployeesClock_dBDataSet)

    End Sub

    Private Sub frmEmpsClock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
End Class
