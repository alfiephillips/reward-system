Public Class FRMManBehaviour
    Private Sub FRMManBehaviour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.TBLBEHAVIOUR' table. You can move, or remove it, as needed.
        Me.TBLBEHAVIOURTableAdapter.Fill(Me.DSDB.TBLBEHAVIOUR)

    End Sub
End Class