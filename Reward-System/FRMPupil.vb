Public Class FRMPupil
    Dim dbLocation As Integer = FRMLogin.dbLocation
    Dim pupil As Pupil
    Private Sub FRMPupil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill Rewards Table with existing data
        Me.TBLREWARDSTableAdapter.Fill(Me.DSDB.TBLREWARDS)

        'set local variables
        Dim account As Account
        Dim availableRewards As AvailableRewards
        Dim verified As Boolean

        'set initial values
        account.lbl = lblAvailableRewards
        account.pupil = pupil


        'security question for the verification of the user
        verified = FRMMain.securityCheck(dbLocation:=dbLocation)

        'use LoadAccount sub process to load all processes to show the user account
        LoadAccount(verified, account, availableRewards)
    End Sub

    Sub LoadAccount(ByVal verified As Boolean, ByVal account As Account, ByVal availableRewards As AvailableRewards)
        'exit the form if verification fails
        If verified = False Then Me.Close()

        'use function to find the user's account info based on their location in the database.
        With account
            .lbl = FRMMain.getAccountInfo(lblAccountInfo, dbLocation).Item1
            .pupil = FRMMain.getAccountInfo(lblAccountInfo, dbLocation).Item2
        End With

        'reassign values of Account record
        lblAccountInfo = account.lbl
        pupil = account.pupil

        availableRewards = FRMMain.getAvailableRewards(cmbRewardsAvailable, pupil.points)

        'load current points
        lblCurrentPoints.Text += CStr(pupil.points)

        'set minimum value of progress bar to 0, maximum to the difference between next reward and current points + the current points, and value to the user's points
        pbarPoints.Value = pupil.points
        pbarPoints.Maximum = availableRewards.nextRewardPointDiff + pupil.points
        pbarPoints.Minimum = 0

        'set next reward text to the point difference to next reward
        lblNextReward.Text += CStr(availableRewards.nextRewardPointDiff)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the current form
        Me.Close()
    End Sub
End Class