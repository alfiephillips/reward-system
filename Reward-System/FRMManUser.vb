Public Class FRMManUser
    Private Sub FRMManUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.TBLUSERS' table. You can move, or remove it, as needed.
        Me.TBLUSERSTableAdapter.Fill(Me.DSDB.TBLUSERS)
    End Sub
End Class