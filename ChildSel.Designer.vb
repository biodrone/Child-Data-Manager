<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildSel
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
        Me.cmbChild = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdCont = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbChild
        '
        Me.cmbChild.FormattingEnabled = True
        Me.cmbChild.Location = New System.Drawing.Point(12, 29)
        Me.cmbChild.Name = "cmbChild"
        Me.cmbChild.Size = New System.Drawing.Size(121, 21)
        Me.cmbChild.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(9, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(73, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Select A Child"
        '
        'cmdCont
        '
        Me.cmdCont.Location = New System.Drawing.Point(142, 30)
        Me.cmdCont.Name = "cmdCont"
        Me.cmdCont.Size = New System.Drawing.Size(57, 19)
        Me.cmdCont.TabIndex = 4
        Me.cmdCont.Text = "Continue"
        Me.cmdCont.UseVisualStyleBackColor = True
        '
        'ChildSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 61)
        Me.Controls.Add(Me.cmdCont)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmbChild)
        Me.Name = "ChildSel"
        Me.Text = "Child Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbChild As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdCont As System.Windows.Forms.Button
End Class
