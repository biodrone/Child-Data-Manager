<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildDataEntry
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
        Me.lblChildID = New System.Windows.Forms.Label()
        Me.mskChildID = New System.Windows.Forms.MaskedTextBox()
        Me.mskDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.radDelay = New System.Windows.Forms.RadioButton()
        Me.radTarget = New System.Windows.Forms.RadioButton()
        Me.radAhead = New System.Windows.Forms.RadioButton()
        Me.GBProgress = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.lblLoadedHeading = New System.Windows.Forms.Label()
        Me.lblLoadedChild = New System.Windows.Forms.Label()
        Me.lblLoadedDate = New System.Windows.Forms.Label()
        Me.lblLoadedProgress = New System.Windows.Forms.Label()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskdob = New System.Windows.Forms.MaskedTextBox()
        Me.lblChildIDHide = New System.Windows.Forms.Label()
        Me.lblLoadedChildID = New System.Windows.Forms.Label()
        Me.lblLoadedUpdateDate = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblLoadedProgressBox = New System.Windows.Forms.Label()
        Me.lblLoadedSex = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.cmdGraph = New System.Windows.Forms.Button()
        Me.GBProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChildID
        '
        Me.lblChildID.AutoSize = True
        Me.lblChildID.Location = New System.Drawing.Point(54, 37)
        Me.lblChildID.Name = "lblChildID"
        Me.lblChildID.Size = New System.Drawing.Size(47, 13)
        Me.lblChildID.TabIndex = 1
        Me.lblChildID.Text = "Child ID:"
        '
        'mskChildID
        '
        Me.mskChildID.BeepOnError = True
        Me.mskChildID.Location = New System.Drawing.Point(113, 34)
        Me.mskChildID.Mask = "0"
        Me.mskChildID.Name = "mskChildID"
        Me.mskChildID.Size = New System.Drawing.Size(100, 20)
        Me.mskChildID.TabIndex = 2
        '
        'mskDate
        '
        Me.mskDate.BeepOnError = True
        Me.mskDate.Location = New System.Drawing.Point(113, 112)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(100, 20)
        Me.mskDate.TabIndex = 3
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(15, 115)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(86, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date Completed:"
        '
        'radDelay
        '
        Me.radDelay.AutoSize = True
        Me.radDelay.Location = New System.Drawing.Point(18, 19)
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
        Me.radTarget.Location = New System.Drawing.Point(18, 42)
        Me.radTarget.Name = "radTarget"
        Me.radTarget.Size = New System.Drawing.Size(73, 17)
        Me.radTarget.TabIndex = 6
        Me.radTarget.TabStop = True
        Me.radTarget.Text = "On Target"
        Me.radTarget.UseVisualStyleBackColor = True
        '
        'radAhead
        '
        Me.radAhead.AutoSize = True
        Me.radAhead.Location = New System.Drawing.Point(18, 65)
        Me.radAhead.Name = "radAhead"
        Me.radAhead.Size = New System.Drawing.Size(104, 17)
        Me.radAhead.TabIndex = 7
        Me.radAhead.TabStop = True
        Me.radAhead.Text = "Ahead Of Target"
        Me.radAhead.UseVisualStyleBackColor = True
        '
        'GBProgress
        '
        Me.GBProgress.Controls.Add(Me.radAhead)
        Me.GBProgress.Controls.Add(Me.radDelay)
        Me.GBProgress.Controls.Add(Me.radTarget)
        Me.GBProgress.Location = New System.Drawing.Point(60, 149)
        Me.GBProgress.Name = "GBProgress"
        Me.GBProgress.Size = New System.Drawing.Size(153, 93)
        Me.GBProgress.TabIndex = 9
        Me.GBProgress.TabStop = False
        Me.GBProgress.Text = "Progress"
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(298, 385)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(137, 40)
        Me.cmdNext.TabIndex = 10
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(155, 385)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(137, 40)
        Me.cmdLoad.TabIndex = 11
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'lblLoadedHeading
        '
        Me.lblLoadedHeading.AutoSize = True
        Me.lblLoadedHeading.Location = New System.Drawing.Point(342, 9)
        Me.lblLoadedHeading.Name = "lblLoadedHeading"
        Me.lblLoadedHeading.Size = New System.Drawing.Size(69, 13)
        Me.lblLoadedHeading.TabIndex = 12
        Me.lblLoadedHeading.Text = "Loaded Data"
        Me.lblLoadedHeading.Visible = False
        '
        'lblLoadedChild
        '
        Me.lblLoadedChild.AutoSize = True
        Me.lblLoadedChild.Location = New System.Drawing.Point(345, 34)
        Me.lblLoadedChild.Name = "lblLoadedChild"
        Me.lblLoadedChild.Size = New System.Drawing.Size(0, 13)
        Me.lblLoadedChild.TabIndex = 13
        '
        'lblLoadedDate
        '
        Me.lblLoadedDate.AutoSize = True
        Me.lblLoadedDate.Location = New System.Drawing.Point(348, 61)
        Me.lblLoadedDate.Name = "lblLoadedDate"
        Me.lblLoadedDate.Size = New System.Drawing.Size(0, 13)
        Me.lblLoadedDate.TabIndex = 14
        '
        'lblLoadedProgress
        '
        Me.lblLoadedProgress.AutoSize = True
        Me.lblLoadedProgress.Location = New System.Drawing.Point(348, 87)
        Me.lblLoadedProgress.Name = "lblLoadedProgress"
        Me.lblLoadedProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblLoadedProgress.TabIndex = 15
        '
        'cmdLogout
        '
        Me.cmdLogout.Location = New System.Drawing.Point(441, 385)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(137, 40)
        Me.cmdLogout.TabIndex = 16
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "D.o.B:"
        '
        'mskdob
        '
        Me.mskdob.Location = New System.Drawing.Point(113, 86)
        Me.mskdob.Mask = "00/00/0000"
        Me.mskdob.Name = "mskdob"
        Me.mskdob.Size = New System.Drawing.Size(100, 20)
        Me.mskdob.TabIndex = 18
        '
        'lblChildIDHide
        '
        Me.lblChildIDHide.AutoSize = True
        Me.lblChildIDHide.Location = New System.Drawing.Point(577, 8)
        Me.lblChildIDHide.Name = "lblChildIDHide"
        Me.lblChildIDHide.Size = New System.Drawing.Size(0, 13)
        Me.lblChildIDHide.TabIndex = 19
        Me.lblChildIDHide.Visible = False
        '
        'lblLoadedChildID
        '
        Me.lblLoadedChildID.AutoSize = True
        Me.lblLoadedChildID.Location = New System.Drawing.Point(342, 38)
        Me.lblLoadedChildID.Name = "lblLoadedChildID"
        Me.lblLoadedChildID.Size = New System.Drawing.Size(18, 13)
        Me.lblLoadedChildID.TabIndex = 20
        Me.lblLoadedChildID.Text = "ID"
        Me.lblLoadedChildID.Visible = False
        '
        'lblLoadedUpdateDate
        '
        Me.lblLoadedUpdateDate.AutoSize = True
        Me.lblLoadedUpdateDate.Location = New System.Drawing.Point(342, 117)
        Me.lblLoadedUpdateDate.Name = "lblLoadedUpdateDate"
        Me.lblLoadedUpdateDate.Size = New System.Drawing.Size(80, 13)
        Me.lblLoadedUpdateDate.TabIndex = 21
        Me.lblLoadedUpdateDate.Text = "Date of Update"
        Me.lblLoadedUpdateDate.Visible = False
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(342, 91)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(30, 13)
        Me.lblDOB.TabIndex = 22
        Me.lblDOB.Text = "DOB"
        Me.lblDOB.Visible = False
        '
        'lblLoadedProgressBox
        '
        Me.lblLoadedProgressBox.AutoSize = True
        Me.lblLoadedProgressBox.Location = New System.Drawing.Point(342, 149)
        Me.lblLoadedProgressBox.Name = "lblLoadedProgressBox"
        Me.lblLoadedProgressBox.Size = New System.Drawing.Size(48, 13)
        Me.lblLoadedProgressBox.TabIndex = 23
        Me.lblLoadedProgressBox.Text = "Progress"
        Me.lblLoadedProgressBox.Visible = False
        '
        'lblLoadedSex
        '
        Me.lblLoadedSex.AutoSize = True
        Me.lblLoadedSex.Location = New System.Drawing.Point(342, 65)
        Me.lblLoadedSex.Name = "lblLoadedSex"
        Me.lblLoadedSex.Size = New System.Drawing.Size(25, 13)
        Me.lblLoadedSex.TabIndex = 24
        Me.lblLoadedSex.Text = "Sex"
        Me.lblLoadedSex.Visible = False
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(73, 63)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(28, 13)
        Me.lblSex.TabIndex = 25
        Me.lblSex.Text = "Sex:"
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(113, 60)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(100, 20)
        Me.txtSex.TabIndex = 26
        '
        'cmdGraph
        '
        Me.cmdGraph.Location = New System.Drawing.Point(12, 385)
        Me.cmdGraph.Name = "cmdGraph"
        Me.cmdGraph.Size = New System.Drawing.Size(137, 40)
        Me.cmdGraph.TabIndex = 27
        Me.cmdGraph.Text = "Graph"
        Me.cmdGraph.UseVisualStyleBackColor = True
        '
        'ChildDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 437)
        Me.Controls.Add(Me.cmdGraph)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblLoadedSex)
        Me.Controls.Add(Me.lblLoadedProgressBox)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblLoadedUpdateDate)
        Me.Controls.Add(Me.lblLoadedChildID)
        Me.Controls.Add(Me.lblChildIDHide)
        Me.Controls.Add(Me.mskdob)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.lblLoadedProgress)
        Me.Controls.Add(Me.lblLoadedDate)
        Me.Controls.Add(Me.lblLoadedChild)
        Me.Controls.Add(Me.lblLoadedHeading)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.mskDate)
        Me.Controls.Add(Me.mskChildID)
        Me.Controls.Add(Me.lblChildID)
        Me.Controls.Add(Me.GBProgress)
        Me.Name = "ChildDataEntry"
        Me.Text = "Data Entry"
        Me.GBProgress.ResumeLayout(False)
        Me.GBProgress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChildID As System.Windows.Forms.Label
    Friend WithEvents mskChildID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents radDelay As System.Windows.Forms.RadioButton
    Friend WithEvents radTarget As System.Windows.Forms.RadioButton
    Friend WithEvents radAhead As System.Windows.Forms.RadioButton
    Friend WithEvents GBProgress As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents lblLoadedHeading As System.Windows.Forms.Label
    Friend WithEvents lblLoadedChild As System.Windows.Forms.Label
    Friend WithEvents lblLoadedDate As System.Windows.Forms.Label
    Friend WithEvents lblLoadedProgress As System.Windows.Forms.Label
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskdob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblChildIDHide As System.Windows.Forms.Label
    Friend WithEvents lblLoadedChildID As System.Windows.Forms.Label
    Friend WithEvents lblLoadedUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblLoadedProgressBox As System.Windows.Forms.Label
    Friend WithEvents lblLoadedSex As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents cmdGraph As System.Windows.Forms.Button
End Class
