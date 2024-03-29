﻿'import namespaces
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class DGraph
    'define global variables
    Dim ChildID As String
    Dim DBProgress As New DataTable

    'set form load sub
    Private Sub DGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intProg As Integer, intMonth As Integer

        ''check if the user has added a new child before this
        'If ChildIDCarryForward = "" Then
        '    ChildID = InputBox("What Child Do You Wish To View?", "Child Select")
        'Else
        '    ChildID = ChildIDCarryForward
        'End If

        'check if the child exists
        Dim ChildDir As String = ChildDataLoc + "\Child" + ChildID
        If DirectoryExists(ChildDir) = False Then
            MsgBox("Sorry, That Child ID Does Not Exist", MsgBoxStyle.Critical, "Error")
            Exit Sub
            Me.Close()
        Else
            MainForm.Close()
        End If
        'name the chart
        crtChildX.Text = "Child " + ChildID
        'set up the data table
        DBProgress.Clear()
        DBProgress.Columns.Add("Progress", GetType(Integer))
        DBProgress.Columns.Add("Month", GetType(Integer))

        Dim Months = From FolderChID In System.IO.Directory.EnumerateDirectories(ChildDir)
        'begin adding data into the DBProgress data table
        For Each FolderChID In Months
            'set the filereader to the right place
            Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(FolderChID.ToString + "\Progress.txt")
            'determine the progress level of the child
            Select Case fileReader.ReadLine()
                Case "A"
                    intProg = 3
                Case "D"
                    intProg = 1
                Case "T"
                    intProg = 2
            End Select
            'enumerate through folders and change the month into an integer
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
            'add the data to the table
            DBProgress.Rows.Add(intProg, intMonth)
        Next
        'set axis properties
        With crtChildX.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = 13
            .AxisY.Minimum = 0
            .AxisY.Maximum = 3
            .AxisY.Interval = 1
            .AxisX.Title = "Month (As Numeral)"
            .AxisY.Title = "Progress"
        End With
        'do the data binding and set other properties
        With crtChildX.Series(0)
            .Points.DataBind(DBProgress.CreateDataReader, "Month", "Progress", Nothing)
            .ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
            .BorderWidth = 1
            .Color = Color.Blue
            .BorderColor = Color.Black
            .LegendText = "Child " + ChildID + " Progress"
        End With
        AddtocomboColour()
    End Sub

    Private Sub Print(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim formprinting As New PowerPacks.Printing.PrintForm
        'make the combo box and button invisible so that they don't print
        cmdPrint.Visible = False
        comboColour.Visible = False
        'print the document
        formprinting.DocumentName = "Child's Graph"
        formprinting.Form = Me
        formprinting.PrintAction = PrintAction.PrintToPrinter
        formprinting.Print()
        'make combo box and button visible again
        cmdPrint.Visible = True
        comboColour.Visible = True

        MainForm.Show()
        Me.Close()
    End Sub

    Public Sub AddtocomboColour()
        'add colour selections to the colour change combo box
        comboColour.Items.Add("Blue")
        comboColour.Items.Add("Red")
        comboColour.Items.Add("Green")
        comboColour.Items.Add("Pink")
        comboColour.Items.Add("Purple")
        comboColour.Items.Add("Black")
        comboColour.Items.Add("Yellow")
        comboColour.Items.Add("Orange")
    End Sub

    Private Sub comboColour_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboColour.SelectionChangeCommitted
        'checks when the colour combo box is changed and changes the colour
        Select Case comboColour.SelectedItem.ToString
            Case "Blue"
                crtChildX.Series(0).Color = Color.Blue
            Case "Red"
                crtChildX.Series(0).Color = Color.Red
            Case "Green"
                crtChildX.Series(0).Color = Color.Green
            Case "Pink"
                crtChildX.Series(0).Color = Color.Pink
            Case "Purple"
                crtChildX.Series(0).Color = Color.Purple
            Case "Black"
                crtChildX.Series(0).Color = Color.Black
            Case "Yellow"
                crtChildX.Series(0).Color = Color.Yellow
            Case "Orange"
                crtChildX.Series(0).Color = Color.Orange
        End Select
    End Sub

    'sub to handle cancel button
    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
        MainForm.Show()
    End Sub
End Class