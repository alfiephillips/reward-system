Public Class FRMManLNKPupilBehaviour
    Private Sub FRMManLNKPupilBehaviour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.LNKPupilBehaviour' table. You can move, or remove it, as needed.
        Me.LNKPupilBehaviourTableAdapter.Fill(Me.DSDB.LNKPupilBehaviour)

    End Sub
End Class