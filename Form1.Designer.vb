<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
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
        Me.cmdFirstUser.Location = New System.Drawing.Point(12, 8)
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
        'txtUser
        '
        Me.txtUser.AcceptsTab = True
        Me.txtUser.Location = New System.Drawing.Point(71, 58)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.AcceptsTab = True
        Me.txtPass.Location = New System.Drawing.Point(72, 84)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(10, 61)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(58, 13)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(10, 87)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 14
        Me.lblPass.Text = "Password:"
        '
        'Login
        '
        Me.AcceptButton = Me.cmdLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(354, 166)
        Me.Controls.Add(Me.cmdFirstUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLogIn)
        Me.Controls.Add(Me.cmdAddUser)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.Text = "Login Portal"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmdAddUser As System.Windows.Forms.Button
    Friend WithEvents cmdLogIn As System.Windows.Forms.Button
    Friend WithEvents ResetEnsPass As System.Windows.Forms.Button
    Friend WithEvents cmdFirstUser As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label

End Class
