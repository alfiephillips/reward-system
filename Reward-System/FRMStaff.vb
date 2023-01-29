Public Class FRMStaff
    Dim dbLocation As Integer = FRMLogin.dbLocation
    Private Sub FRMStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'security question for the verification of the user
        Dim verified As Boolean
        verified = FRMMain.securityCheck(dbLocation:=dbLocation)

        If verified = False Then
            Me.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class