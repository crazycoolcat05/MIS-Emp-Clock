
Public Class frmEmpsClock

    Private Sub btnCreateEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateEmp.Click
        frmNewEmp.Show()
    End Sub

    Private Sub lstProfile_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstProfile.SelectedIndexChanged
        ' employee selects their profile, and is prompted with dialog box to enter password
        MessageBox.Show("Enter your password.")
    End Sub


End Class
