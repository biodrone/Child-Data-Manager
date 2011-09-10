Imports System.IO
Imports System.Security.Cryptography
Public Class ChildDataEntry
    Dim ChildID As String, MonthDir As String, DateDir As String, RawDate As String
    Dim stream As FileStream

    Private Sub ChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolTip1.IsBalloon = False
        Me.mskDate.Mask = "00/00/0000"
        Me.mskdob.Mask = "00/00/0000"
        mskDate.ValidatingType = GetType(System.DateTime)
        RadioGroupController()
        lblLoadedHeading.Hide()
    End Sub

    Private Sub mskDate_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) Handles mskDate.MaskInputRejected
        ToolTip1.ToolTipTitle = "Invalid Input"
        ToolTip1.Show("Sorry, Only Numbers 0-9 Are Allowed In Dates", mskDate, 500)
    End Sub

    Public Sub RadioGroupController()
        GBProgress.Controls.Add(radDelay)
        GBProgress.Controls.Add(radAhead)
        GBProgress.Controls.Add(radTarget)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Dim DOB As String, IDCheck As String, SexCheck As String
        Dim MsgCount As Integer
        Dim FailCheck As Boolean

        'initialise all txtbxs and lbl colours
        lblChildID.ForeColor = Color.Black
        lblDate.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        GBProgress.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
        IDCheck = mskChildID.Text
        SexCheck = txtSex.Text
        DOB = mskdob.Text
        RawDate = mskDate.Text

        'check to see if any of the fields in the form are blank
        FailCheck = True
        While FailCheck = True
            If IDCheck.Length = 0 Then
                MsgBox("Please Enter a Child ID", MsgBoxStyle.Information)
                lblChildID.ForeColor = Color.Red
                FailCheck = False
            End If
            If SexCheck <> "M" Then
                If SexCheck <> "F" Then
                    MsgBox("Please Enter a Valid Sex; M or F", MsgBoxStyle.Information)
                    lblSex.ForeColor = Color.Red
                    FailCheck = False
                End If
            End If
            If SexCheck.Length = 0 Then
                MsgBox("Please Enter a Sex", MsgBoxStyle.Information)
                lblSex.ForeColor = Color.Red
                FailCheck = False
            End If
            If DOB.Contains("  /") Then
                MsgBox("Please Enter a D.o.B", MsgBoxStyle.Information)
                Label1.ForeColor = Color.Red
                FailCheck = False
            End If
            If RawDate.Contains("  /") Then
                MsgBox("Please Enter a Date Completed", MsgBoxStyle.Information)
                lblDate.ForeColor = Color.Red
                FailCheck = False
            End If
            If radAhead.Checked = False And radDelay.Checked = False And radTarget.Checked = False Then
                MsgBox("Please Select a Progress Button", MsgBoxStyle.OkOnly)
                GBProgress.ForeColor = Color.Red
                FailCheck = False
            End If

            'check if any boxes are not filled. If so, stop the sub here so it doesn't throw an error
            If FailCheck = False Then
                Exit Sub
            Else
                FailCheck = False
            End If
        End While

        'strip the date so that only the month remains
        DateDir = mskDate.Text.Remove(0, 3)
        DateDir = DateDir.Remove(2, 5)
        'strip the leading 0, if there is one
        If DateDir.StartsWith("0") = True Then
            DateDir = DateDir.Remove(0, 1)
        End If
        MonthDir = ""
        ChildID = ""
        ChildID = mskChildID.Text

        'Convert the raw date into a month
        MonthConvInt2Str(DateDir, MonthDir)
        'Select Case DateDir
        '    Case 1
        '        MonthDir = "January"
        '    Case 2
        '        MonthDir = "February"
        '    Case 3
        '        MonthDir = "March"
        '    Case 4
        '        MonthDir = "April"
        '    Case 5
        '        MonthDir = "May"
        '    Case 6
        '        MonthDir = "June"
        '    Case 7
        '        MonthDir = "July"
        '    Case 8
        '        MonthDir = "August"
        '    Case 9
        '        MonthDir = "September"
        '    Case 10
        '        MonthDir = "October"
        '    Case 11
        '        MonthDir = "November"
        '    Case 12
        '        MonthDir = "December"
        'End Select

        'check if the child id already exists. If not, create the directory
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\" + "Child" + ChildID) = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID)
        Else 'if it exists, check if the month exists. If so, confirm overwrite
            If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir) = True Then
                MsgCount = MsgBox("Child's Data for This Month Already Exists. Overwrite?", MsgBoxStyle.YesNoCancel)
                If MsgCount = 6 Then 'if yes, delete the dir then create it again
                    My.Computer.FileSystem.DeleteDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir, FileIO.DeleteDirectoryOption.DeleteAllContents, FileIO.RecycleOption.DeletePermanently)
                    My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
                Else
                    InitDataEntry()
                    Exit Sub
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
            End If
        End If
        My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
        stream = File.Create("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt")
        stream.Close()
        'My.Computer.FileSystem.CopyFile("C:\Childrens Centre\Child Data\Progress.txt", "C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt")

        'check which rad button is checked and write this and other variables to the file
        Select Case True
            Case radAhead.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "A" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
            Case radDelay.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "D" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
            Case radTarget.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "T" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
        End Select

        InitDataEntry()
    End Sub
    Private Sub InitDataEntry()
        'initialise txtbxs and radbuttons
        mskChildID.Text = ""
        mskDate.Text = ""
        mskdob.Text = ""
        txtSex.Text = ""
        radAhead.Checked = False
        radDelay.Checked = False
        radTarget.Checked = False

        'initialise lbl colours
        lblChildID.ForeColor = Color.Black
        lblDate.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        GBProgress.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
    End Sub
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        LoadMonthCombo.Show()
    End Sub

    Public Sub LoadChildData()
        Dim fileReader As System.IO.StreamReader, LoadID As String, LoadUpdMonth As String, LoadRad As String, LoadDOB As String
        Dim LoadSex As String
        Dim LineCount As Integer
        LoadUpdMonth = ""
        LoadID = ""
        LoadID = LoadMonthCombo.lblChildIDHide.Text
        LoadUpdMonth = LoadMonthCombo.lblLoadMonth.Text
        'MsgBox(LoadMonth)

        'point the streamreader to the right file
        fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Childrens Centre\Child Data\" + "Child" + LoadID + "\" + LoadUpdMonth + "\Progress.txt")
        'initialise the line counter
        LineCount = 1
        'While the streamreader isn't at the end of the file, the variable = the line, changed by the counter
        While fileReader.EndOfStream = False
            If LineCount = 1 Then
                LoadRad = fileReader.ReadLine()
            ElseIf LineCount = 2 Then
                LoadSex = fileReader.ReadLine()
            ElseIf LineCount = 3 Then
                LoadDOB = fileReader.ReadLine()
            Else
                LoadUpdMonth = fileReader.ReadLine()
            End If
            LineCount = LineCount + 1
        End While

        'start loading the vars necessary for the Loaded Data labels
        'isolate the month section of the d.o.b
        'LoadDOB = LoadDOB.Remove(0, 3)
        'LoadDOB = LoadDOB.Remove(2, 5)
        ''remove the leading 0, if there is one
        'If LoadDOB.StartsWith("0") = True Then
        '    LoadDOB = DateDir.Remove(0, 1)
        'End If

        'use a new var for the month string
        'Dim LoadDOBMonth As String
        'MonthConvInt2Str(LoadDOB, LoadDOBMonth)
        'Select Case LoadDOB
        '    Case 1
        '        LoadDOBMonth = "January"
        '    Case 2
        '        LoadDOBMonth = "February"
        '    Case 3
        '        LoadDOBMonth = "March"
        '    Case 4
        '        LoadDOBMonth = "April"
        '    Case 5
        '        LoadDOBMonth = "May"
        '    Case 6
        '        LoadDOBMonth = "June"
        '    Case 7
        '        LoadDOBMonth = "July"
        '    Case 8
        '        LoadDOBMonth = "August"
        '    Case 9
        '        LoadDOBMonth = "September"
        '    Case 10
        '        LoadDOBMonth = "October"
        '    Case 11
        '        LoadDOBMonth = "November"
        '    Case 12
        '        LoadDOBMonth = "December"
        'End Select

        'set all of the Loaded Data txtbxs to visible = true and put in the leading text
        lblLoadedHeading.Visible = True
        lblLoadedChildID.Text = "This Data is for Child: " + LoadID
        lblLoadedChildID.Visible = True
        lblLoadedSex.Text = "The Sex of the Child is:" + LoadSex
        lblLoadedSex.Visible = True
        lblDOB.Text = "The Child's D.o.B is: " + LoadDOB
        lblDOB.Visible = True
        lblLoadedUpdateDate.Text = "The Date of This Update Was: " + LoadUpdMonth
        lblLoadedUpdateDate.Visible = True
        'find out which rad button should be checked, then check it
        If LoadRad = "A" Then
            lblLoadedProgressBox.Text = "AHEAD OF TARGET"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.Green
        ElseIf LoadRad = "D" Then
            lblLoadedProgressBox.Text = "AT RISK OF DELAY"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.Red
        ElseIf LoadRad = "T" Then
            lblLoadedProgressBox.Text = "ON TARGET"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.Yellow
        End If

        LoadMonthCombo.Close()
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cmdGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraph.Click
        DGraph.Show()
    End Sub

    Public Sub MonthConvInt2Str(ByRef SelCase As String, ByRef VarForStr As String)
        Select Case SelCase
            Case 1
                VarForStr = "January"
            Case 2
                VarForStr = "February"
            Case 3
                VarForStr = "March"
            Case 4
                VarForStr = "April"
            Case 5
                VarForStr = "May"
            Case 6
                VarForStr = "June"
            Case 7
                VarForStr = "July"
            Case 8
                VarForStr = "August"
            Case 9
                VarForStr = "September"
            Case 10
                VarForStr = "October"
            Case 11
                VarForStr = "November"
            Case 12
                VarForStr = "December"
        End Select
    End Sub
End Class
