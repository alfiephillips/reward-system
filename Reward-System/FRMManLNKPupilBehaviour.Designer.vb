<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMManLNKPupilBehaviour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMManLNKPupilBehaviour))
        Me.bNavLNKPupilBehaviour = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BSLNKPupilBehaviour = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDB = New Reward_System.DSDB()
        Me.LNKPupilBehaviourTableAdapter = New Reward_System.DSDBTableAdapters.LNKPupilBehaviourTableAdapter()
        Me.dGridPupils = New System.Windows.Forms.DataGridView()
        Me.LNKPBehIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BehaviourIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PupilIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bNavLNKPupilBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavLNKPupilBehaviour.SuspendLayout()
        CType(Me.BSLNKPupilBehaviour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dGridPupils, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bNavLNKPupilBehaviour
        '
        Me.bNavLNKPupilBehaviour.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bNavLNKPupilBehaviour.BindingSource = Me.BSLNKPupilBehaviour
        Me.bNavLNKPupilBehaviour.CountItem = Me.BindingNavigatorCountItem
        Me.bNavLNKPupilBehaviour.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bNavLNKPupilBehaviour.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bNavLNKPupilBehaviour.Location = New System.Drawing.Point(0, 0)
        Me.bNavLNKPupilBehaviour.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bNavLNKPupilBehaviour.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bNavLNKPupilBehaviour.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bNavLNKPupilBehaviour.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bNavLNKPupilBehaviour.Name = "bNavLNKPupilBehaviour"
        Me.bNavLNKPupilBehaviour.PositionItem = Me.BindingNavigatorPositionItem
        Me.bNavLNKPupilBehaviour.Size = New System.Drawing.Size(1904, 25)
        Me.bNavLNKPupilBehaviour.TabIndex = 4
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
        'BSLNKPupilBehaviour
        '
        Me.BSLNKPupilBehaviour.DataMember = "LNKPupilBehaviour"
        Me.BSLNKPupilBehaviour.DataSource = Me.DSDB
        '
        'DSDB
        '
        Me.DSDB.DataSetName = "DSDB"
        Me.DSDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LNKPupilBehaviourTableAdapter
        '
        Me.LNKPupilBehaviourTableAdapter.ClearBeforeFill = True
        '
        'dGridPupils
        '
        Me.dGridPupils.AllowUserToOrderColumns = True
        Me.dGridPupils.AutoGenerateColumns = False
        Me.dGridPupils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridPupils.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LNKPBehIDDataGridViewTextBoxColumn, Me.EventDateDataGridViewTextBoxColumn, Me.PointsChangeDataGridViewTextBoxColumn, Me.BehaviourIDDataGridViewTextBoxColumn, Me.PupilIDDataGridViewTextBoxColumn})
        Me.dGridPupils.DataSource = Me.BSLNKPupilBehaviour
        Me.dGridPupils.Location = New System.Drawing.Point(12, 37)
        Me.dGridPupils.Name = "dGridPupils"
        Me.dGridPupils.Size = New System.Drawing.Size(544, 800)
        Me.dGridPupils.TabIndex = 6
        '
        'LNKPBehIDDataGridViewTextBoxColumn
        '
        Me.LNKPBehIDDataGridViewTextBoxColumn.DataPropertyName = "LNKPBehID"
        Me.LNKPBehIDDataGridViewTextBoxColumn.HeaderText = "LNKPBehID"
        Me.LNKPBehIDDataGridViewTextBoxColumn.Name = "LNKPBehIDDataGridViewTextBoxColumn"
        '
        'EventDateDataGridViewTextBoxColumn
        '
        Me.EventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate"
        Me.EventDateDataGridViewTextBoxColumn.HeaderText = "EventDate"
        Me.EventDateDataGridViewTextBoxColumn.Name = "EventDateDataGridViewTextBoxColumn"
        '
        'PointsChangeDataGridViewTextBoxColumn
        '
        Me.PointsChangeDataGridViewTextBoxColumn.DataPropertyName = "PointsChange"
        Me.PointsChangeDataGridViewTextBoxColumn.HeaderText = "PointsChange"
        Me.PointsChangeDataGridViewTextBoxColumn.Name = "PointsChangeDataGridViewTextBoxColumn"
        '
        'BehaviourIDDataGridViewTextBoxColumn
        '
        Me.BehaviourIDDataGridViewTextBoxColumn.DataPropertyName = "BehaviourID"
        Me.BehaviourIDDataGridViewTextBoxColumn.HeaderText = "BehaviourID"
        Me.BehaviourIDDataGridViewTextBoxColumn.Name = "BehaviourIDDataGridViewTextBoxColumn"
        '
        'PupilIDDataGridViewTextBoxColumn
        '
        Me.PupilIDDataGridViewTextBoxColumn.DataPropertyName = "PupilID"
        Me.PupilIDDataGridViewTextBoxColumn.HeaderText = "PupilID"
        Me.PupilIDDataGridViewTextBoxColumn.Name = "PupilIDDataGridViewTextBoxColumn"
        '
        'FRMManLNKPupilBehaviour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.dGridPupils)
        Me.Controls.Add(Me.bNavLNKPupilBehaviour)
        Me.Name = "FRMManLNKPupilBehaviour"
        Me.Text = "FRMManLNKPupilBehaviour"
        CType(Me.bNavLNKPupilBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavLNKPupilBehaviour.ResumeLayout(False)
        Me.bNavLNKPupilBehaviour.PerformLayout()
        CType(Me.BSLNKPupilBehaviour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dGridPupils, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bNavLNKPupilBehaviour As BindingNavigator
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
    Friend WithEvents BSLNKPupilBehaviour As BindingSource
    Friend WithEvents DSDB As DSDB
    Friend WithEvents LNKPupilBehaviourTableAdapter As DSDBTableAdapters.LNKPupilBehaviourTableAdapter
    Friend WithEvents dGridPupils As DataGridView
    Friend WithEvents LNKPBehIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BehaviourIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PupilIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
