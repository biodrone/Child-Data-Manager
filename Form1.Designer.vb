<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cmdAddUser = New System.Windows.Forms.Button()
        Me.cmdLogIn = New System.Windows.Forms.Button()
        Me.ResetEnsPass = New System.Windows.Forms.Button()
        Me.cmdFirstUser = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(54, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 1
        '
        'cmdAddUser
        '
        Me.cmdAddUser.Location = New System.Drawing.Point(178, 8)
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.Size = New System.Drawing.Size(160, 44)
        Me.cmdAddUser.TabIndex = 2
        Me.cmdAddUser.Text = "Add New User"
        Me.cmdAddUser.UseVisualStyleBackColor = True
        '
        'cmdLogIn
        '
        Me.cmdLogIn.Location = New System.Drawing.Point(12, 9)
        Me.cmdLogIn.Name = "cmdLogIn"
        Me.cmdLogIn.Size = New System.Drawing.Size(160, 43)
        Me.cmdLogIn.TabIndex = 8
        Me.cmdLogIn.Text = "Log In"
        Me.cmdLogIn.UseVisualStyleBackColor = True
        '
        'ResetEnsPass
        '
        Me.ResetEnsPass.Location = New System.Drawing.Point(118, 280)
        Me.ResetEnsPass.Name = "ResetEnsPass"
        Me.ResetEnsPass.Size = New System.Drawing.Size(160, 23)
        Me.ResetEnsPass.TabIndex = 9
        Me.ResetEnsPass.Text = "Reset EncPassword"
        Me.ResetEnsPass.UseVisualStyleBackColor = True
        '
        'cmdFirstUser
        '
        Me.cmdFirstUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirstUser.Location = New System.Drawing.Point(12, 9)
        Me.cmdFirstUser.Name = "cmdFirstUser"
        Me.cmdFirstUser.Size = New System.Drawing.Size(326, 141)
        Me.cmdFirstUser.TabIndex = 9
        Me.cmdFirstUser.Text = "Create Your First User!"
        Me.cmdFirstUser.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(178, 107)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(160, 43)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.cmdLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(354, 166)
        Me.Controls.Add(Me.cmdFirstUser)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Controls.Add(Me.cmdAddUser)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Login Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmdAddUser As System.Windows.Forms.Button
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents ResetEnsPass As System.Windows.Forms.Button
    Friend WithEvents cmdFirstUser As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
