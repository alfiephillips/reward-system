Public Class FRMManReward
    Private Sub FRMManReward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.TBLREWARDS' table. You can move, or remove it, as needed.
        Me.TBLREWARDSTableAdapter.Fill(Me.DSDB.TBLREWARDS)

    End Sub
End Class