<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadMonthCombo
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
        Me.comLoadMonth = New System.Windows.Forms.ComboBox()
        Me.lblChildIDHide = New System.Windows.Forms.Label()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.LoadMonthHide = New System.Windows.Forms.Label()
        Me.lnlLoadMonth = New System.Windows.Forms.Label()
        Me.lblLoadMonth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comLoadMonth
        '
        Me.comLoadMonth.FormattingEnabled = True
        Me.comLoadMonth.Location = New System.Drawing.Point(51, 46)
        Me.comLoadMonth.Name = "comLoadMonth"
        Me.comLoadMonth.Size = New System.Drawing.Size(115, 21)
        Me.comLoadMonth.TabIndex = 0
        Me.comLoadMonth.Text = "Select The Month"
        '
        'lblChildIDHide
        '
        Me.lblChildIDHide.AutoSize = True
        Me.lblChildIDHide.Location = New System.Drawing.Point(241, 241)
        Me.lblChildIDHide.Name = "lblChildIDHide"
        Me.lblChildIDHide.Size = New System.Drawing.Size(0, 13)
        Me.lblChildIDHide.TabIndex = 1
        Me.lblChildIDHide.Visible = False
        '
        'cmdDone
        '
        Me.cmdDone.Location = New System.Drawing.Point(51, 91)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(115, 23)
        Me.cmdDone.TabIndex = 2
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'LoadMonthHide
        '
        Me.LoadMonthHide.AutoSize = True
        Me.LoadMonthHide.Location = New System.Drawing.Point(201, 187)
        Me.LoadMonthHide.Name = "LoadMonthHide"
        Me.LoadMonthHide.Size = New System.Drawing.Size(0, 13)
        Me.LoadMonthHide.TabIndex = 3
        '
        'lnlLoadMonth
        '
        Me.lnlLoadMonth.AutoSize = True
        Me.lnlLoadMonth.Location = New System.Drawing.Point(241, 241)
        Me.lnlLoadMonth.Name = "lnlLoadMonth"
        Me.lnlLoadMonth.Size = New System.Drawing.Size(0, 13)
        Me.lnlLoadMonth.TabIndex = 4
        Me.lnlLoadMonth.Visible = False
        '
        'lblLoadMonth
        '
        Me.lblLoadMonth.AutoSize = True
        Me.lblLoadMonth.Location = New System.Drawing.Point(234, 86)
        Me.lblLoadMonth.Name = "lblLoadMonth"
        Me.lblLoadMonth.Size = New System.Drawing.Size(0, 13)
        Me.lblLoadMonth.TabIndex = 5
        Me.lblLoadMonth.Visible = False
        '
        'LoadMonthCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 166)
        Me.Controls.Add(Me.lblLoadMonth)
        Me.Controls.Add(Me.lnlLoadMonth)
        Me.Controls.Add(Me.LoadMonthHide)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.lblChildIDHide)
        Me.Controls.Add(Me.comLoadMonth)
        Me.Name = "LoadMonthCombo"
        Me.Text = "LoadMonthCombo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comLoadMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblChildIDHide As System.Windows.Forms.Label
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents LoadMonthHide As System.Windows.Forms.Label
    Friend WithEvents lnlLoadMonth As System.Windows.Forms.Label
    Friend WithEvents lblLoadMonth As System.Windows.Forms.Label
End Class
