Public Class FRMLogin
    'global variables for use across the entire program
    Public dbUsername, dbPassword, dbLevel As String
    Public dbLocation As Integer

    Private Sub FRMLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the first field the user is required for data input
        txtUsername.Focus()
    End Sub

    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click
        'define local variables
        Dim loopCount, rowCount, level As Integer
        Dim username, password As String
        Dim userFound As Boolean

        'Dim startTime, endTime As DateTime TODO: Add session info
        'Dim currentDate As DateTime

        'set the username and password variables to their corresponding text fields
        username = txtUsername.Text
        password = txtPassword.Text

        'get the amount of rows in user table
        rowCount = FRMMain.DSDB.TBLUSERS.Rows.Count - 1

        'initial values
        loopCount = 0
        userFound = False

        'repeat loop while less than the row count and the user isn't found
        Do While (loopCount <= rowCount) And (userFound = False)
            'find the name that corresponds to the current loop count
            dbUsername = FRMMain.DSDB.Tables("TBLUSERS").Rows(loopCount)(1).ToString()

            'check if the username is the same as the dbUsername
            If username = dbUsername Then
                userFound = True
            Else
                'increment the count to continue the loop
                loopCount += 1
            End If
        Loop

        'set global variable dbLocation to the row our user holds in the database for more efficient access in other controls
        dbLocation = loopCount

        'if user isn't found, show error
        If Not userFound Then
            'error handling
            MsgBox("User not found!")
            txtPassword.Text = ""
        Else
            'find the password that corresponds with the current loop count
            dbPassword = FRMMain.DSDB.Tables("TBLUSERS").Rows(loopCount)(2).ToString()

            'check if password matches, display error message if they don't
            If password <> dbPassword Then
                MsgBox("Password doesn't match to this user.")
            Else
                'find the dbLevel corresponding to the loop count
                level = FRMMain.DSDB.Tables("TBLUSERS").Rows(loopCount)(3).ToString()
                dbLevel = level

                'TODO: Store session info

                'based on level, show 3 different forms
                Select Case level
                    'for each case, reset the username and password fields so data isn't saved after logging out
                    Case 1
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        Me.Hide()
                        FRMPupil.ShowDialog()
                    Case 2
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        Me.Hide()
                        FRMStaff.ShowDialog()
                    Case 3
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                        Me.Hide()
                        FRMAdmin.ShowDialog()
                End Select

                'repeat login process
                Me.Show()
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub
End Class