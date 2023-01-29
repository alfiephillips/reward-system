<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPupil
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAccountInfo = New System.Windows.Forms.Label()
        Me.cmbRewardsAvailable = New System.Windows.Forms.ComboBox()
        Me.TBLREWARDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDB = New Reward_System.DSDB()
        Me.TBLREWARDSTableAdapter = New Reward_System.DSDBTableAdapters.TBLREWARDSTableAdapter()
        Me.lblAvailableRewards = New System.Windows.Forms.Label()
        Me.lblCurrentPoints = New System.Windows.Forms.Label()
        Me.pbarPoints = New System.Windows.Forms.ProgressBar()
        Me.lblNextReward = New System.Windows.Forms.Label()
        CType(Me.TBLREWARDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(628, 15)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "LOG OUT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAccountInfo
        '
        Me.lblAccountInfo.AutoSize = True
        Me.lblAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountInfo.Location = New System.Drawing.Point(16, 22)
        Me.lblAccountInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccountInfo.Name = "lblAccountInfo"
        Me.lblAccountInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblAccountInfo.TabIndex = 5
        '
        'cmbRewardsAvailable
        '
        Me.cmbRewardsAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRewardsAvailable.FormattingEnabled = True
        Me.cmbRewardsAvailable.Location = New System.Drawing.Point(235, 37)
        Me.cmbRewardsAvailable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbRewardsAvailable.Name = "cmbRewardsAvailable"
        Me.cmbRewardsAvailable.Size = New System.Drawing.Size(265, 28)
        Me.cmbRewardsAvailable.TabIndex = 6
        Me.cmbRewardsAvailable.Text = "Please choose a reward."
        '
        'TBLREWARDSBindingSource
        '
        Me.TBLREWARDSBindingSource.DataMember = "TBLREWARDS"
        Me.TBLREWARDSBindingSource.DataSource = Me.DSDB
        '
        'DSDB
        '
        Me.DSDB.DataSetName = "DSDB"
        Me.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLREWARDSTableAdapter
        '
        Me.TBLREWARDSTableAdapter.ClearBeforeFill = True
        '
        'lblAvailableRewards
        '
        Me.lblAvailableRewards.AutoSize = True
        Me.lblAvailableRewards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableRewards.Location = New System.Drawing.Point(229, 9)
        Me.lblAvailableRewards.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailableRewards.Name = "lblAvailableRewards"
        Me.lblAvailableRewards.Size = New System.Drawing.Size(179, 25)
        Me.lblAvailableRewards.TabIndex = 7
        Me.lblAvailableRewards.Text = "Available Rewards!"
        '
        'lblCurrentPoints
        '
        Me.lblCurrentPoints.AutoSize = True
        Me.lblCurrentPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPoints.Location = New System.Drawing.Point(331, 334)
        Me.lblCurrentPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentPoints.Name = "lblCurrentPoints"
        Me.lblCurrentPoints.Size = New System.Drawing.Size(0, 21)
        Me.lblCurrentPoints.TabIndex = 8
        '
        'pbarPoints
        '
        Me.pbarPoints.Location = New System.Drawing.Point(312, 363)
        Me.pbarPoints.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbarPoints.Name = "pbarPoints"
        Me.pbarPoints.Size = New System.Drawing.Size(133, 28)
        Me.pbarPoints.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarPoints.TabIndex = 9
        '
        'lblNextReward
        '
        Me.lblNextReward.AutoSize = True
        Me.lblNextReward.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextReward.Location = New System.Drawing.Point(307, 395)
        Me.lblNextReward.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNextReward.Name = "lblNextReward"
        Me.lblNextReward.Size = New System.Drawing.Size(141, 25)
        Me.lblNextReward.TabIndex = 10
        Me.lblNextReward.Text = "Next reward in "
        '
        'FRMPupil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 690)
        Me.Controls.Add(Me.lblNextReward)
        Me.Controls.Add(Me.pbarPoints)
        Me.Controls.Add(Me.lblCurrentPoints)
        Me.Controls.Add(Me.lblAvailableRewards)
        Me.Controls.Add(Me.cmbRewardsAvailable)
        Me.Controls.Add(Me.lblAccountInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FRMPupil"
        Me.Text = "FRMPupil"
        CType(Me.TBLREWARDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblAccountInfo As Label
    Friend WithEvents cmbRewardsAvailable As ComboBox
    Friend WithEvents DSDB As DSDB
    Friend WithEvents TBLREWARDSBindingSource As BindingSource
    Friend WithEvents TBLREWARDSTableAdapter As DSDBTableAdapters.TBLREWARDSTableAdapter
    Friend WithEvents lblAvailableRewards As Label
    Friend WithEvents lblCurrentPoints As Label
    Friend WithEvents pbarPoints As ProgressBar
    Friend WithEvents lblNextReward As Label
End Class
