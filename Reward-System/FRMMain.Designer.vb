<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BSUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDB = New Reward_System.DSDB()
        Me.BSLnkPupilBehaviour = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSLnkPupilRewards = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSRewards = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSBehaviour = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.TBLUSERSTableAdapter = New Reward_System.DSDBTableAdapters.TBLUSERSTableAdapter()
        Me.TBLREWARDSTableAdapter = New Reward_System.DSDBTableAdapters.TBLREWARDSTableAdapter()
        Me.TBLBEHAVIOURTableAdapter = New Reward_System.DSDBTableAdapters.TBLBEHAVIOURTableAdapter()
        Me.LNKPupilBehaviourTableAdapter = New Reward_System.DSDBTableAdapters.LNKPupilBehaviourTableAdapter()
        Me.LNKPupilRewardsTableAdapter = New Reward_System.DSDBTableAdapters.LNKPupilRewardsTableAdapter()
        Me.BSPupil = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPUPILTableAdapter = New Reward_System.DSDBTableAdapters.TBLPUPILTableAdapter()
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSLnkPupilBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSLnkPupilRewards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSRewards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSPupil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSUser
        '
        Me.BSUser.DataMember = "TBLUSERS"
        Me.BSUser.DataSource = Me.DSDB
        '
        'DSDB
        '
        Me.DSDB.DataSetName = "DSDB"
        Me.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSLnkPupilBehaviour
        '
        Me.BSLnkPupilBehaviour.DataMember = "LNKPupilBehaviour"
        Me.BSLnkPupilBehaviour.DataSource = Me.DSDB
        '
        'BSLnkPupilRewards
        '
        Me.BSLnkPupilRewards.DataMember = "LNKPupilRewards"
        Me.BSLnkPupilRewards.DataSource = Me.DSDB
        '
        'BSRewards
        '
        Me.BSRewards.DataMember = "TBLREWARDS"
        Me.BSRewards.DataSource = Me.DSDB
        '
        'BSBehaviour
        '
        Me.BSBehaviour.DataMember = "TBLBEHAVIOUR"
        Me.BSBehaviour.DataSource = Me.DSDB
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(77, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(429, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Greenparks School System"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Location = New System.Drawing.Point(512, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 26)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(31, 71)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(529, 231)
        Me.lblDescription.TabIndex = 2
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAdmin.Location = New System.Drawing.Point(239, 357)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(112, 21)
        Me.lblAdmin.TabIndex = 3
        Me.lblAdmin.Text = "Admin Access"
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLogIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(266, 321)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(56, 21)
        Me.lblLogIn.TabIndex = 4
        Me.lblLogIn.Text = "Log In"
        '
        'TBLUSERSTableAdapter
        '
        Me.TBLUSERSTableAdapter.ClearBeforeFill = True
        '
        'TBLREWARDSTableAdapter
        '
        Me.TBLREWARDSTableAdapter.ClearBeforeFill = True
        '
        'TBLBEHAVIOURTableAdapter
        '
        Me.TBLBEHAVIOURTableAdapter.ClearBeforeFill = True
        '
        'LNKPupilBehaviourTableAdapter
        '
        Me.LNKPupilBehaviourTableAdapter.ClearBeforeFill = True
        '
        'LNKPupilRewardsTableAdapter
        '
        Me.LNKPupilRewardsTableAdapter.ClearBeforeFill = True
        '
        'BSPupil
        '
        Me.BSPupil.DataMember = "TBLPUPIL"
        Me.BSPupil.DataSource = Me.DSDB
        '
        'TBLPUPILTableAdapter
        '
        Me.TBLPUPILTableAdapter.ClearBeforeFill = True
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLogIn)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FRMMain"
        Me.Text = "Greenparks School Reward Scheme"
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSLnkPupilBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSLnkPupilRewards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSRewards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSPupil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BSUser As BindingSource
    Friend WithEvents BSLnkPupilBehaviour As BindingSource
    Friend WithEvents BSLnkPupilRewards As BindingSource
    Friend WithEvents BSRewards As BindingSource
    Friend WithEvents BSBehaviour As BindingSource
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblLogIn As Label
    Friend WithEvents DSDB As DSDB
    Friend WithEvents TBLUSERSTableAdapter As DSDBTableAdapters.TBLUSERSTableAdapter
    Friend WithEvents TBLREWARDSTableAdapter As DSDBTableAdapters.TBLREWARDSTableAdapter
    Friend WithEvents TBLBEHAVIOURTableAdapter As DSDBTableAdapters.TBLBEHAVIOURTableAdapter
    Friend WithEvents LNKPupilBehaviourTableAdapter As DSDBTableAdapters.LNKPupilBehaviourTableAdapter
    Friend WithEvents LNKPupilRewardsTableAdapter As DSDBTableAdapters.LNKPupilRewardsTableAdapter
    Friend WithEvents BSPupil As BindingSource
    Friend WithEvents TBLPUPILTableAdapter As DSDBTableAdapters.TBLPUPILTableAdapter
End Class
