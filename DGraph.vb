﻿Public Class DGraph
    Dim ChildID As String
    Dim DBProgress As New DataTable
    Private Sub DGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intProg As Integer, intMonth As Integer
        ChildID = InputBox("What Child Do You Wish To View?", "Child Select")
        Dim ChildDir As String = "C:\Childrens Centre\Child Data\Child" + ChildID
        crtChildX.Text = "Child " + ChildID
        DBProgress.Clear()
        DBProgress.Columns.Add("Progress", GetType(Integer))
        DBProgress.Columns.Add("Month", GetType(Integer))
        Dim Months = From FolderChID In System.IO.Directory.EnumerateDirectories(ChildDir)
        Dim test As String

        For Each FolderChID In Months
            Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(FolderChID.ToString + "\Progress.txt")
            test = FolderChID.Substring(FolderChID.LastIndexOf("/") + 1)
            Select Case fileReader.ReadLine()
                Case "A"
                    intProg = 3
                Case "D"
                    intProg = 1
                Case "T"
                    intProg = 2
            End Select
            
            Select Case FolderChID.Substring(FolderChID.LastIndexOf("\") + 1)
                Case "January"
                    intMonth = 1
                Case "February"
                    intMonth = 2
                Case "March"
                    intMonth = 3
                Case "April"
                    intMonth = 4
                Case "May"
                    intMonth = 5
                Case "June"
                    intMonth = 6
                Case "July"
                    intMonth = 7
                Case "August"
                    intMonth = 8
                Case "September"
                    intMonth = 9
                Case "October"
                    intMonth = 10
                Case "November"
                    intMonth = 11
                Case "December"
                    intMonth = 12
            End Select
            DBProgress.Rows.Add(intProg, intMonth)
        Next

        With crtChildX.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = 13
            .AxisY.Minimum = 0
            .AxisY.Maximum = 3
            .AxisY.Interval = 1
            .AxisX.Title = "Month (As Numeral)"
            .AxisY.Title = "Progress"
        End With

        With crtChildX.Series(0)
            .Points.DataBind(DBProgress.CreateDataReader, "Month", "Progress", Nothing)
            .ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
            .BorderWidth = 1
            .Color = Color.Red
            .BorderColor = Color.Red
            .LegendText = "Child 1 Progress"
        End With
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Dim crtChildXPrint As New Object
        'Dim ChildDir As String = "C:\Childrens Centre\Child Data\Child" + ChildID
        crtChildX.Printing.Print(True)

        'crtChildXPrint = crtChildX
        'Dim writetempfile As New System.IO.StreamWriter(ChildDir + "\TempPrintFile.jpg")
        'writetempfile.Write(crtChildXPrint)
        'writetempfile.Close()
        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.Print()
        'End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim ChildDir As String = "C:\Childrens Centre\Child Data\Child" + ChildID

        crtChildX.Printing.Print(True)

        'PrintDocument1.DocumentName = ChildDir + "\TempPrintFile.rtf"
    End Sub
End Class