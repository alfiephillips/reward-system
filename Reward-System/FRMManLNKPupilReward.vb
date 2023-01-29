Public Class FRMManLNKPupilReward
    Private Sub FRMManLNKPupilReward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.LNKPupilRewards' table. You can move, or remove it, as needed.
        Me.LNKPupilRewardsTableAdapter.Fill(Me.DSDB.LNKPupilRewards)

    End Sub
End Class