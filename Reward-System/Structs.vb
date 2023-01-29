Public Module Structs
    Public Structure Pupil
        Dim fName As String
        Dim sName As String
        Dim dateOfBirth As DateTime
        Dim yearGroup As Integer
        Dim points As Integer
    End Structure

    Public Structure Reward
        Dim rewardName As String
        Dim pointsRequired As Integer
    End Structure

    Public Structure Account
        Dim lbl As Label
        Dim pupil As Pupil
    End Structure

    Public Structure AvailableRewards
        Dim cmb As ComboBox
        Dim available() As String
        Dim nextRewardPointDiff As Integer
    End Structure
End Module
