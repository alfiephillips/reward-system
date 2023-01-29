Public Class FRMMain
    Private Sub FRMMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDB.TBLPUPIL' table. You can move, or remove it, as needed.
        Me.TBLPUPILTableAdapter.Fill(Me.DSDB.TBLPUPIL)
        'TODO: This line of code loads data into the 'DSDB.LNKPupilRewards' table. You can move, or remove it, as needed.
        Me.LNKPupilRewardsTableAdapter.Fill(Me.DSDB.LNKPupilRewards)
        'TODO: This line of code loads data into the 'DSDB.LNKPupilBehaviour' table. You can move, or remove it, as needed.
        Me.LNKPupilBehaviourTableAdapter.Fill(Me.DSDB.LNKPupilBehaviour)
        'TODO: This line of code loads data into the 'DSDB.TBLBEHAVIOUR' table. You can move, or remove it, as needed.
        Me.TBLBEHAVIOURTableAdapter.Fill(Me.DSDB.TBLBEHAVIOUR)
        'TODO: This line of code loads data into the 'DSDB.TBLPUPIL' table. You can move, or remove it, as needed.
        Me.TBLPUPILTableAdapter.Fill(Me.DSDB.TBLPUPIL)
        'TODO: This line of code loads data into the 'DSDB.TBLREWARDS' table. You can move, or remove it, as needed.
        Me.TBLREWARDSTableAdapter.Fill(Me.DSDB.TBLREWARDS)
        'TODO: This line of code loads data into the 'DSDB.TBLUSERS' table. You can move, or remove it, as needed.
        Me.TBLUSERSTableAdapter.Fill(Me.DSDB.TBLUSERS)
        'TODO: This line of code loads data into the 'ConnMyDB.TBLPUPIL' table. You can move, or remove it, as needed.

        lblDescription.Text = "Pupils will be able to earn reward points for:
        • Good attendance at school
        • Good behaviour in lessons
        • Working hard in class
        • Gaining good marks in tests and examinations
        • Taking part in sporting and musical activities
        • Representing the school in competitions and events
        • Taking part in after school clubs and activities
        • Taking part in activities such as litter patrols

Points may also be deducted from a Pupil by Staff."
    End Sub

    Public Function getAvailableRewards(ByVal cmb As ComboBox, points As Integer)
        'set local variables
        Dim data As AvailableRewards
        Dim rowCount, loopCount As Integer
        Dim pointsExceeded As Boolean

        loopCount = 0
        pointsExceeded = False
        rowCount = DSDB.Tables("TBLREWARDS").Rows.Count - 1

        Dim availableRewards(rowCount) As String
        Dim nextRewardPointDiff As Integer

        Do While (loopCount <= rowCount) And (pointsExceeded = False)
            Dim reward As Reward

            reward.rewardName = DSDB.Tables("TBLREWARDS").Rows(loopCount)(1)
            reward.pointsRequired = DSDB.Tables("TBLREWARDS").Rows(loopCount)(2)

            If reward.pointsRequired <= points Then
                availableRewards(loopCount) = reward.rewardName
                loopCount += 1
            Else
                reward.pointsRequired = DSDB.Tables("TBLREWARDS").Rows(loopCount)(2)
                nextRewardPointDiff = reward.pointsRequired - points
                pointsExceeded = True
            End If
        Loop

        For count = 0 To loopCount - 1
            cmb.Items.Add(availableRewards(count))
        Next count

        data.cmb = cmb
        data.available = availableRewards
        data.nextRewardPointDiff = nextRewardPointDiff

        Return data
    End Function

    Public Function getAccountInfo(ByVal lbl As Label, ByVal dbLocation As Integer)
        'set local variables
        Dim accountInfo As Pupil
        Dim userID, level As Integer
        Dim username As String

        'define all rows in the user table
        With DSDB.Tables("TBLUSERS")
            userID = .Rows(dbLocation)(0)
            username = .Rows(dbLocation)(1)
            level = .Rows(dbLocation)(3)
        End With

        'check user level
        Select Case level
            Case 1
                'set local variables for pupil
                Dim fName, sName, dateOfBirth As String
                Dim pupilLocation, rowCount, pupilID, dbPupilID, yearGroup, points As Integer
                Dim pupilFound As Boolean

                pupilFound = False
                pupilLocation = 0
                rowCount = DSDB.Tables("TBLUSERS").Rows.Count - 1 'get row count for user table
                pupilID = CInt(DSDB.Tables("TBLUSERS").Rows(dbLocation)(6)) 'find the foreign key for pupil id

                Do While (pupilLocation <= rowCount) And (pupilFound = False) 'search for user until past the maximum amount of rows
                    'find the name that corresponds to the current loop count
                    dbPupilID = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(0).ToString()

                    'check if the username is the same as the dbUsername
                    If pupilID = dbPupilID Then
                        pupilFound = True
                    Else
                        pupilLocation += 1
                    End If
                Loop

                'if the pupil is found, set its properties to the corresponding row in the table
                If (pupilFound) Then
                    fName = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(1)
                    sName = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(2)
                    dateOfBirth = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(3)
                    yearGroup = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(4)
                    points = DSDB.Tables("TBLPUPIL").Rows(pupilLocation)(5)
                Else
                    Return False
                End If

                'amend the referenced label
                lbl.Text = "User ID: " & CStr(userID) &
                   vbNewLine & "Username: " & username &
                   vbNewLine & "Type: Pupil" &
                   vbNewLine & "DOB: " & dateOfBirth &
                   vbNewLine & "First name: " & fName &
                   vbNewLine & "Surname: " & sName &
                   vbNewLine & "Year Group: " & CStr(yearGroup)

                'add to the pupil record
                With accountInfo
                    .fName = fName
                    .sName = sName
                    .dateOfBirth = dateOfBirth
                    .yearGroup = yearGroup
                    .points = points
                End With

                'return a tuple to either access the label or the account record
                Return Tuple.Create(lbl, accountInfo)

            Case 2
                lbl.Text = "User ID: " & CStr(userID) &
                   vbNewLine & "Username: " & username & vbNewLine & "Type: Staff"

                Return Tuple.Create(lbl, 0)
            Case 3
                lbl.Text = "User ID: " & CStr(userID) &
                   vbNewLine & "Username: " & username & vbNewLine & "Type: Admin"

                Return Tuple.Create(lbl, 0)
            Case Else
                Return vbNull
        End Select
    End Function

    Public Function securityCheck(ByVal dbLocation As Integer)
        Dim dbSecurityQuestion, dbSecurityAnswer, inputAnswer As String
        Dim tryCount As Integer
        Dim correctAnswer As Boolean

        tryCount = 1
        correctAnswer = False

        dbSecurityQuestion = DSDB.Tables("TBLUSERS").Rows(dbLocation)(4).ToString()
        dbSecurityAnswer = DSDB.Tables("TBLUSERS").Rows(dbLocation)(5).ToString()


        While tryCount <= 3 And correctAnswer = False
            inputAnswer = InputBox(Title:="Security Check", Prompt:=dbSecurityQuestion)
            If inputAnswer <> dbSecurityAnswer Then
                MsgBox("Wrong answer! You have " & CStr(3 - (tryCount)) & " tries left.")
                tryCount += 1
            Else
                correctAnswer = True
            End If
        End While

        Return correctAnswer
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        Me.Hide()
        FRMLogin.ShowDialog()
    End Sub
End Class
