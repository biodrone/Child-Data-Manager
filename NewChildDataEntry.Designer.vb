<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewChildDataEntry
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblLoadedChild = New System.Windows.Forms.Label()
        Me.lblLoadedDate = New System.Windows.Forms.Label()
        Me.lblLoadedProgress = New System.Windows.Forms.Label()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.mskdob = New System.Windows.Forms.MaskedTextBox()
        Me.lblChildIDHide = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.lblChIdCarryForward = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChildID
        '
        Me.lblChildID.AutoSize = True
        Me.lblChildID.Location = New System.Drawing.Point(5, 15)
        Me.lblChildID.Name = "lblChildID"
        Me.lblChildID.Size = New System.Drawing.Size(47, 13)
        Me.lblChildID.TabIndex = 1
        Me.lblChildID.Text = "Child ID:"
        '
        'mskChildID
        '
        Me.mskChildID.BeepOnError = True
        Me.mskChildID.Location = New System.Drawing.Point(64, 12)
        Me.mskChildID.Name = "mskChildID"
        Me.mskChildID.Size = New System.Drawing.Size(85, 20)
        Me.mskChildID.TabIndex = 2
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(12, 113)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(137, 40)
        Me.cmdNext.TabIndex = 10
        Me.cmdNext.Text = "Save"
        Me.cmdNext.UseVisualStyleBackColor = True
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
        Me.cmdLogout.Location = New System.Drawing.Point(155, 113)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(137, 40)
        Me.cmdLogout.TabIndex = 16
        Me.cmdLogout.Text = "Log Out"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(15, 67)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(37, 13)
        Me.lblDOB.TabIndex = 17
        Me.lblDOB.Text = "D.o.B:"
        '
        'mskdob
        '
        Me.mskdob.Location = New System.Drawing.Point(64, 64)
        Me.mskdob.Mask = "00/00/0000"
        Me.mskdob.Name = "mskdob"
        Me.mskdob.Size = New System.Drawing.Size(85, 20)
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
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(24, 41)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(28, 13)
        Me.lblSex.TabIndex = 25
        Me.lblSex.Text = "Sex:"
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(64, 38)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(85, 20)
        Me.txtSex.TabIndex = 26
        '
        'lblChIdCarryForward
        '
        Me.lblChIdCarryForward.AutoSize = True
        Me.lblChIdCarryForward.Location = New System.Drawing.Point(201, 19)
        Me.lblChIdCarryForward.Name = "lblChIdCarryForward"
        Me.lblChIdCarryForward.Size = New System.Drawing.Size(91, 13)
        Me.lblChIdCarryForward.TabIndex = 28
        Me.lblChIdCarryForward.Text = "ChIdCarryForward"
        Me.lblChIdCarryForward.Visible = False
        '
        'NewChildDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 168)
        Me.Controls.Add(Me.lblChIdCarryForward)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblChildIDHide)
        Me.Controls.Add(Me.mskdob)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.lblLoadedProgress)
        Me.Controls.Add(Me.lblLoadedDate)
        Me.Controls.Add(Me.lblLoadedChild)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.mskChildID)
        Me.Controls.Add(Me.lblChildID)
        Me.Name = "NewChildDataEntry"
        Me.Text = "Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChildID As System.Windows.Forms.Label
    Friend WithEvents mskChildID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblLoadedChild As System.Windows.Forms.Label
    Friend WithEvents lblLoadedDate As System.Windows.Forms.Label
    Friend WithEvents lblLoadedProgress As System.Windows.Forms.Label
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents mskdob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblChildIDHide As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents lblChIdCarryForward As System.Windows.Forms.Label
End Class
