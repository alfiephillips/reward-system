<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMManBehaviour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMManBehaviour))
        Me.bNavBehaviour = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BSBehaviour = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDB = New Reward_System.DSDB()
        Me.TBLBEHAVIOURTableAdapter = New Reward_System.DSDBTableAdapters.TBLBEHAVIOURTableAdapter()
        Me.dGridPupils = New System.Windows.Forms.DataGridView()
        Me.BehaviourIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviournameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsAppliedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bNavBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavBehaviour.SuspendLayout()
        CType(Me.BSBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dGridPupils, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bNavBehaviour
        '
        Me.bNavBehaviour.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bNavBehaviour.BindingSource = Me.BSBehaviour
        Me.bNavBehaviour.CountItem = Me.BindingNavigatorCountItem
        Me.bNavBehaviour.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bNavBehaviour.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bNavBehaviour.Location = New System.Drawing.Point(0, 0)
        Me.bNavBehaviour.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bNavBehaviour.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bNavBehaviour.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bNavBehaviour.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bNavBehaviour.Name = "bNavBehaviour"
        Me.bNavBehaviour.PositionItem = Me.BindingNavigatorPositionItem
        Me.bNavBehaviour.Size = New System.Drawing.Size(1904, 25)
        Me.bNavBehaviour.TabIndex = 4
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BSBehaviour
        '
        Me.BSBehaviour.DataMember = "TBLBEHAVIOUR"
        Me.BSBehaviour.DataSource = Me.DSDB
        '
        'DSDB
        '
        Me.DSDB.DataSetName = "DSDB"
        Me.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLBEHAVIOURTableAdapter
        '
        Me.TBLBEHAVIOURTableAdapter.ClearBeforeFill = True
        '
        'dGridPupils
        '
        Me.dGridPupils.AllowUserToOrderColumns = True
        Me.dGridPupils.AutoGenerateColumns = False
        Me.dGridPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridPupils.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BehaviourIDDataGridViewTextBoxColumn, Me.BehaviournameDataGridViewTextBoxColumn, Me.PointsAppliedDataGridViewTextBoxColumn})
        Me.dGridPupils.DataSource = Me.BSBehaviour
        Me.dGridPupils.Location = New System.Drawing.Point(12, 37)
        Me.dGridPupils.Name = "dGridPupils"
        Me.dGridPupils.Size = New System.Drawing.Size(343, 800)
        Me.dGridPupils.TabIndex = 6
        '
        'BehaviourIDDataGridViewTextBoxColumn
        '
        Me.BehaviourIDDataGridViewTextBoxColumn.DataPropertyName = "BehaviourID"
        Me.BehaviourIDDataGridViewTextBoxColumn.HeaderText = "BehaviourID"
        Me.BehaviourIDDataGridViewTextBoxColumn.Name = "BehaviourIDDataGridViewTextBoxColumn"
        '
        'BehaviournameDataGridViewTextBoxColumn
        '
        Me.BehaviournameDataGridViewTextBoxColumn.DataPropertyName = "Behaviourname"
        Me.BehaviournameDataGridViewTextBoxColumn.HeaderText = "Behaviourname"
        Me.BehaviournameDataGridViewTextBoxColumn.Name = "BehaviournameDataGridViewTextBoxColumn"
        '
        'PointsAppliedDataGridViewTextBoxColumn
        '
        Me.PointsAppliedDataGridViewTextBoxColumn.DataPropertyName = "PointsApplied"
        Me.PointsAppliedDataGridViewTextBoxColumn.HeaderText = "PointsApplied"
        Me.PointsAppliedDataGridViewTextBoxColumn.Name = "PointsAppliedDataGridViewTextBoxColumn"
        '
        'FRMManBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.dGridPupils)
        Me.Controls.Add(Me.bNavBehaviour)
        Me.Name = "FRMManBehaviour"
        Me.Text = "FRMManBehaviour"
        CType(Me.bNavBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavBehaviour.ResumeLayout(False)
        Me.bNavBehaviour.PerformLayout()
        CType(Me.BSBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dGridPupils, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bNavBehaviour As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BSBehaviour As BindingSource
    Friend WithEvents DSDB As DSDB
    Friend WithEvents TBLBEHAVIOURTableAdapter As DSDBTableAdapters.TBLBEHAVIOURTableAdapter
    Friend WithEvents dGridPupils As DataGridView
    Friend WithEvents BehaviourIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BehaviournameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsAppliedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
