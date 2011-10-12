<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGraph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.crtChildX = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.comboColour = New System.Windows.Forms.ComboBox()
        CType(Me.crtChildX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtChildX
        '
        ChartArea1.Name = "ChartArea1"
        Me.crtChildX.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.crtChildX.Legends.Add(Legend1)
        Me.crtChildX.Location = New System.Drawing.Point(12, 12)
        Me.crtChildX.Name = "crtChildX"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.crtChildX.Series.Add(Series1)
        Me.crtChildX.Size = New System.Drawing.Size(725, 479)
        Me.crtChildX.TabIndex = 0
        Me.crtChildX.Text = "Child Data Chart"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(618, 497)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(119, 53)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'pd1
        '
        Me.pd1.DocumentName = "pdoc"
        '
        'comboColour
        '
        Me.comboColour.FormattingEnabled = True
        Me.comboColour.Location = New System.Drawing.Point(256, 497)
        Me.comboColour.Name = "comboColour"
        Me.comboColour.Size = New System.Drawing.Size(138, 21)
        Me.comboColour.TabIndex = 2
        Me.comboColour.Text = "Click to Change Colour"
        '
        'DGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 562)
        Me.Controls.Add(Me.comboColour)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.crtChildX)
        Me.Name = "DGraph"
        Me.Text = "DGraph"
        CType(Me.crtChildX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crtChildX As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents pd1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents comboColour As System.Windows.Forms.ComboBox
End Class
