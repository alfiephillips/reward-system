Public Class FRMAdmin
    Dim dbLocation As Integer = FRMLogin.dbLocation

    Private Sub FRMAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'security question for the verification of the user
        Dim verified As Boolean
        verified = FRMMain.securityCheck(dbLocation:=dbLocation)

        If verified = False Then
            Me.Close()
        End If

        lblAccountInfo = FRMMain.getAccountInfo(lblAccountInfo, dbLocation) 'use function to find the user's account info based on their location in the database.
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnManUser_Click(sender As Object, e As EventArgs) Handles btnManUser.Click
        FRMManUser.ShowDialog()
    End Sub

    Private Sub btnManPupil_Click(sender As Object, e As EventArgs) Handles btnManPupil.Click
        FRMManPupil.ShowDialog()
    End Sub

    Private Sub btnManBehaviour_Click(sender As Object, e As EventArgs) Handles btnManBehaviour.Click
        FRMManBehaviour.ShowDialog()
    End Sub

    Private Sub btnManReward_Click(sender As Object, e As EventArgs) Handles btnManReward.Click
        FRMManReward.ShowDialog()
    End Sub

    Private Sub btnManBehaviourTrans_Click(sender As Object, e As EventArgs) Handles btnManBehaviourTrans.Click
        FRMManLNKPupilBehaviour.ShowDialog()
    End Sub

    Private Sub btnManRewardTrans_Click(sender As Object, e As EventArgs) Handles btnManRewardTrans.Click
        FRMManLNKPupilReward.ShowDialog()
    End Sub
End Class