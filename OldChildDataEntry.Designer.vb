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
        Me.GBProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBProgress
        '
        Me.GBProgress.Controls.Add(Me.radAhead)
        Me.GBProgress.Controls.Add(Me.radDelay)
        Me.GBProgress.Controls.Add(Me.radTarget)
        Me.GBProgress.Location = New System.Drawing.Point(31, 166)
        Me.GBProgress.Name = "GBProgress"
        Me.GBProgress.Size = New System.Drawing.Size(153, 93)
        Me.GBProgress.TabIndex = 10
        Me.GBProgress.TabStop = False
        Me.GBProgress.Text = "Progress"
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
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(26, 86)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(86, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date Completed:"
        '
        'mskDate
        '
        Me.mskDate.BeepOnError = True
        Me.mskDate.Location = New System.Drawing.Point(124, 83)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(100, 20)
        Me.mskDate.TabIndex = 11
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'OldChildDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 372)
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
End Class
