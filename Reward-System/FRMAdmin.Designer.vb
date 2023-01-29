<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAccountInfo = New System.Windows.Forms.Label()
        Me.btnManUser = New System.Windows.Forms.Button()
        Me.btnManPupil = New System.Windows.Forms.Button()
        Me.btnManBehaviour = New System.Windows.Forms.Button()
        Me.btnManReward = New System.Windows.Forms.Button()
        Me.btnManBehaviourTrans = New System.Windows.Forms.Button()
        Me.btnManRewardTrans = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(828, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 26)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "LOG OUT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAccountInfo
        '
        Me.lblAccountInfo.AutoSize = True
        Me.lblAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblAccountInfo.Name = "lblAccountInfo"
        Me.lblAccountInfo.Size = New System.Drawing.Size(0, 16)
        Me.lblAccountInfo.TabIndex = 4
        '
        'btnManUser
        '
        Me.btnManUser.Location = New System.Drawing.Point(15, 168)
        Me.btnManUser.Name = "btnManUser"
        Me.btnManUser.Size = New System.Drawing.Size(97, 41)
        Me.btnManUser.TabIndex = 5
        Me.btnManUser.Text = "Manage Users"
        Me.btnManUser.UseVisualStyleBackColor = True
        '
        'btnManPupil
        '
        Me.btnManPupil.Location = New System.Drawing.Point(15, 215)
        Me.btnManPupil.Name = "btnManPupil"
        Me.btnManPupil.Size = New System.Drawing.Size(97, 41)
        Me.btnManPupil.TabIndex = 6
        Me.btnManPupil.Text = "Manage Pupils"
        Me.btnManPupil.UseVisualStyleBackColor = True
        '
        'btnManBehaviour
        '
        Me.btnManBehaviour.Location = New System.Drawing.Point(118, 168)
        Me.btnManBehaviour.Name = "btnManBehaviour"
        Me.btnManBehaviour.Size = New System.Drawing.Size(97, 41)
        Me.btnManBehaviour.TabIndex = 7
        Me.btnManBehaviour.Text = "Manage Behaviour"
        Me.btnManBehaviour.UseVisualStyleBackColor = True
        '
        'btnManReward
        '
        Me.btnManReward.Location = New System.Drawing.Point(118, 215)
        Me.btnManReward.Name = "btnManReward"
        Me.btnManReward.Size = New System.Drawing.Size(97, 41)
        Me.btnManReward.TabIndex = 8
        Me.btnManReward.Text = "Manage Reward"
        Me.btnManReward.UseVisualStyleBackColor = True
        '
        'btnManBehaviourTrans
        '
        Me.btnManBehaviourTrans.Location = New System.Drawing.Point(12, 323)
        Me.btnManBehaviourTrans.Name = "btnManBehaviourTrans"
        Me.btnManBehaviourTrans.Size = New System.Drawing.Size(97, 56)
        Me.btnManBehaviourTrans.TabIndex = 9
        Me.btnManBehaviourTrans.Text = "Manage Behaviour Transactions"
        Me.btnManBehaviourTrans.UseVisualStyleBackColor = True
        '
        'btnManRewardTrans
        '
        Me.btnManRewardTrans.Location = New System.Drawing.Point(15, 385)
        Me.btnManRewardTrans.Name = "btnManRewardTrans"
        Me.btnManRewardTrans.Size = New System.Drawing.Size(97, 57)
        Me.btnManRewardTrans.TabIndex = 10
        Me.btnManRewardTrans.Text = "Manage Reward Transactions"
        Me.btnManRewardTrans.UseVisualStyleBackColor = True
        '
        'FRMAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 561)
        Me.Controls.Add(Me.btnManRewardTrans)
        Me.Controls.Add(Me.btnManBehaviourTrans)
        Me.Controls.Add(Me.btnManReward)
        Me.Controls.Add(Me.btnManBehaviour)
        Me.Controls.Add(Me.btnManPupil)
        Me.Controls.Add(Me.btnManUser)
        Me.Controls.Add(Me.lblAccountInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FRMAdmin"
        Me.Text = "FRMAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblAccountInfo As Label
    Friend WithEvents btnManUser As Button
    Friend WithEvents btnManPupil As Button
    Friend WithEvents btnManBehaviour As Button
    Friend WithEvents btnManReward As Button
    Friend WithEvents btnManBehaviourTrans As Button
    Friend WithEvents btnManRewardTrans As Button
End Class
