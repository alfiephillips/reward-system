Public Class FRMManPupil
    Private Sub FRMManPupil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.TBLPUPIL' table. You can move, or remove it, as needed.
        Me.TBLPUPILTableAdapter.Fill(Me.DSDB.TBLPUPIL)

    End Sub
End Class