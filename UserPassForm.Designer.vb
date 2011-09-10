<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPassForm
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.cmdInfoSave = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.MaskedTextBox()
        Me.txtPassVeri = New System.Windows.Forms.TextBox()
        Me.lblPassVeri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(144, 36)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 7
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(37, 39)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(58, 13)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(37, 65)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "Password:"
        '
        'cmdInfoSave
        '
        Me.cmdInfoSave.Location = New System.Drawing.Point(144, 123)
        Me.cmdInfoSave.Name = "cmdInfoSave"
        Me.cmdInfoSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdInfoSave.TabIndex = 11
        Me.cmdInfoSave.Text = "Save"
        Me.cmdInfoSave.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(144, 63)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 12
        '
        'txtPassVeri
        '
        Me.txtPassVeri.Location = New System.Drawing.Point(144, 90)
        Me.txtPassVeri.Name = "txtPassVeri"
        Me.txtPassVeri.Size = New System.Drawing.Size(100, 20)
        Me.txtPassVeri.TabIndex = 13
        '
        'lblPassVeri
        '
        Me.lblPassVeri.AutoSize = True
        Me.lblPassVeri.Location = New System.Drawing.Point(37, 93)
        Me.lblPassVeri.Name = "lblPassVeri"
        Me.lblPassVeri.Size = New System.Drawing.Size(101, 13)
        Me.lblPassVeri.TabIndex = 14
        Me.lblPassVeri.Text = "Re-Enter Password:"
        '
        'UserPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 183)
        Me.Controls.Add(Me.lblPassVeri)
        Me.Controls.Add(Me.txtPassVeri)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.cmdInfoSave)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "UserPassForm"
        Me.Text = "Enter Your Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents cmdInfoSave As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPassVeri As System.Windows.Forms.TextBox
    Friend WithEvents lblPassVeri As System.Windows.Forms.Label
End Class
