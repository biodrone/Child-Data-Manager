<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.cmdAddOld = New System.Windows.Forms.Button()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.cmdGraph = New System.Windows.Forms.Button()
        Me.cmdArchive = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(12, 12)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(110, 40)
        Me.cmdAddNew.TabIndex = 0
        Me.cmdAddNew.Text = "Add A New Child"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdAddOld
        '
        Me.cmdAddOld.Location = New System.Drawing.Point(128, 12)
        Me.cmdAddOld.Name = "cmdAddOld"
        Me.cmdAddOld.Size = New System.Drawing.Size(110, 40)
        Me.cmdAddOld.TabIndex = 1
        Me.cmdAddOld.Text = "Add Data For An Existing Child"
        Me.cmdAddOld.UseVisualStyleBackColor = True
        '
        'cmdLogout
        '
        Me.cmdLogout.Location = New System.Drawing.Point(592, 12)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(110, 40)
        Me.cmdLogout.TabIndex = 2
        Me.cmdLogout.Text = "Log Out"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'cmdGraph
        '
        Me.cmdGraph.Location = New System.Drawing.Point(244, 12)
        Me.cmdGraph.Name = "cmdGraph"
        Me.cmdGraph.Size = New System.Drawing.Size(110, 40)
        Me.cmdGraph.TabIndex = 28
        Me.cmdGraph.Text = "Graph"
        Me.cmdGraph.UseVisualStyleBackColor = True
        '
        'cmdArchive
        '
        Me.cmdArchive.Location = New System.Drawing.Point(360, 12)
        Me.cmdArchive.Name = "cmdArchive"
        Me.cmdArchive.Size = New System.Drawing.Size(110, 40)
        Me.cmdArchive.TabIndex = 29
        Me.cmdArchive.Text = "Archive"
        Me.cmdArchive.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(476, 12)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(110, 40)
        Me.cmdHelp.TabIndex = 30
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 60)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdArchive)
        Me.Controls.Add(Me.cmdGraph)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.cmdAddOld)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdAddOld As System.Windows.Forms.Button
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents cmdGraph As System.Windows.Forms.Button
    Friend WithEvents cmdArchive As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
End Class
