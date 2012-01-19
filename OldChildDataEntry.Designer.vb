<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldChildDataEntry
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
        Me.GBProgress = New System.Windows.Forms.GroupBox()
        Me.radAhead = New System.Windows.Forms.RadioButton()
        Me.radDelay = New System.Windows.Forms.RadioButton()
        Me.radTarget = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.mskDate = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdGraph = New System.Windows.Forms.Button()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblLoadedSex = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblLoadedHeading = New System.Windows.Forms.Label()
        Me.lblChildID = New System.Windows.Forms.Label()
        Me.lblInfoHeader = New System.Windows.Forms.Label()
        Me.GBProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBProgress
        '
        Me.GBProgress.Controls.Add(Me.radAhead)
        Me.GBProgress.Controls.Add(Me.radDelay)
        Me.GBProgress.Controls.Add(Me.radTarget)
        Me.GBProgress.Location = New System.Drawing.Point(263, 113)
        Me.GBProgress.Name = "GBProgress"
        Me.GBProgress.Size = New System.Drawing.Size(165, 93)
        Me.GBProgress.TabIndex = 10
        Me.GBProgress.TabStop = False
        Me.GBProgress.Text = "Progress"
        '
        'radAhead
        '
        Me.radAhead.AutoSize = True
        Me.radAhead.Location = New System.Drawing.Point(10, 68)
        Me.radAhead.Name = "radAhead"
        Me.radAhead.Size = New System.Drawing.Size(104, 17)
        Me.radAhead.TabIndex = 7
        Me.radAhead.TabStop = True
        Me.radAhead.Text = "Ahead Of Target"
        Me.radAhead.UseVisualStyleBackColor = True
        '
        'radDelay
        '
        Me.radDelay.AutoSize = True
        Me.radDelay.Location = New System.Drawing.Point(10, 22)
        Me.radDelay.Name = "radDelay"
        Me.radDelay.Size = New System.Drawing.Size(101, 17)
        Me.radDelay.TabIndex = 5
        Me.radDelay.TabStop = True
        Me.radDelay.Text = "At Risk of Delay"
        Me.radDelay.UseVisualStyleBackColor = True
        '
        'radTarget
        '
        Me.radTarget.AutoSize = True
        Me.radTarget.Location = New System.Drawing.Point(10, 45)
        Me.radTarget.Name = "radTarget"
        Me.radTarget.Size = New System.Drawing.Size(73, 17)
        Me.radTarget.TabIndex = 6
        Me.radTarget.TabStop = True
        Me.radTarget.Text = "On Target"
        Me.radTarget.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(260, 78)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(80, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date of Report:"
        '
        'mskDate
        '
        Me.mskDate.BeepOnError = True
        Me.mskDate.Location = New System.Drawing.Point(358, 75)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(70, 20)
        Me.mskDate.TabIndex = 11
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'cmdGraph
        '
        Me.cmdGraph.Location = New System.Drawing.Point(5, 320)
        Me.cmdGraph.Name = "cmdGraph"
        Me.cmdGraph.Size = New System.Drawing.Size(137, 40)
        Me.cmdGraph.TabIndex = 30
        Me.cmdGraph.Text = "Graph"
        Me.cmdGraph.UseVisualStyleBackColor = True
        '
        'cmdLogout
        '
        Me.cmdLogout.Location = New System.Drawing.Point(291, 320)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(137, 40)
        Me.cmdLogout.TabIndex = 29
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(148, 320)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(137, 40)
        Me.cmdNext.TabIndex = 28
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'lblLoadedSex
        '
        Me.lblLoadedSex.AutoSize = True
        Me.lblLoadedSex.Location = New System.Drawing.Point(16, 113)
        Me.lblLoadedSex.Name = "lblLoadedSex"
        Me.lblLoadedSex.Size = New System.Drawing.Size(25, 13)
        Me.lblLoadedSex.TabIndex = 36
        Me.lblLoadedSex.Text = "Sex"
        Me.lblLoadedSex.Visible = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(16, 153)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(66, 13)
        Me.lblDOB.TabIndex = 34
        Me.lblDOB.Text = "Date of Birth"
        Me.lblDOB.Visible = False
        '
        'lblLoadedHeading
        '
        Me.lblLoadedHeading.AutoSize = True
        Me.lblLoadedHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadedHeading.Location = New System.Drawing.Point(13, 24)
        Me.lblLoadedHeading.Name = "lblLoadedHeading"
        Me.lblLoadedHeading.Size = New System.Drawing.Size(129, 31)
        Me.lblLoadedHeading.TabIndex = 32
        Me.lblLoadedHeading.Text = "Child Info"
        Me.lblLoadedHeading.Visible = False
        '
        'lblChildID
        '
        Me.lblChildID.AutoSize = True
        Me.lblChildID.Location = New System.Drawing.Point(16, 73)
        Me.lblChildID.Name = "lblChildID"
        Me.lblChildID.Size = New System.Drawing.Size(41, 13)
        Me.lblChildID.TabIndex = 37
        Me.lblChildID.Text = "ChildID"
        '
        'lblInfoHeader
        '
        Me.lblInfoHeader.AutoSize = True
        Me.lblInfoHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoHeader.Location = New System.Drawing.Point(239, 24)
        Me.lblInfoHeader.Name = "lblInfoHeader"
        Me.lblInfoHeader.Size = New System.Drawing.Size(189, 31)
        Me.lblInfoHeader.TabIndex = 38
        Me.lblInfoHeader.Text = "Add New Data"
        Me.lblInfoHeader.Visible = False
        '
        'OldChildDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 372)
        Me.Controls.Add(Me.lblInfoHeader)
        Me.Controls.Add(Me.lblChildID)
        Me.Controls.Add(Me.lblLoadedSex)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblLoadedHeading)
        Me.Controls.Add(Me.cmdGraph)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.mskDate)
        Me.Controls.Add(Me.GBProgress)
        Me.Name = "OldChildDataEntry"
        Me.Text = "OldChildDataEntry"
        Me.GBProgress.ResumeLayout(False)
        Me.GBProgress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBProgress As System.Windows.Forms.GroupBox
    Friend WithEvents radAhead As System.Windows.Forms.RadioButton
    Friend WithEvents radDelay As System.Windows.Forms.RadioButton
    Friend WithEvents radTarget As System.Windows.Forms.RadioButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents mskDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdGraph As System.Windows.Forms.Button
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblLoadedSex As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblLoadedHeading As System.Windows.Forms.Label
    Friend WithEvents lblChildID As System.Windows.Forms.Label
    Friend WithEvents lblInfoHeader As System.Windows.Forms.Label
End Class
