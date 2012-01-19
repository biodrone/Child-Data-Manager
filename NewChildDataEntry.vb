Imports System.IO
Imports System.Security.Cryptography
Public Class NewChildDataEntry
    Dim ChildID As String, MonthDir As String, DateDir As String, RawDOB As String, StrMonth As String
    Dim stream As FileStream

    Private Sub NewChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolTip1.IsBalloon = False
        Me.mskdob.Mask = "00/00/0000"
        lblLoadedHeading.Hide()
        AcceptButton = cmdNext
    End Sub

    Private Sub mskDate_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) Handles mskdob.MaskInputRejected
        'set the tooptip to notify if the text is rejected by the mask
        ToolTip1.ToolTipTitle = "Invalid Input"
        ToolTip1.Show("Sorry, Only Numbers 0-9 Are Allowed In Dates", mskdob, 500)
    End Sub

    Public Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Dim DOB As String, ID As String, Sex As String
        Dim MsgCount As Integer
        Dim FailCheck As Boolean

        'initialise label colours
        lblChildID.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
        'presence check on all form fields
        FailCheck = True
        'load variables for presence check
        ID = mskChildID.Text
        Sex = txtSex.Text
        DOB = mskdob.Text
        While FailCheck = True
            'check ID
            If ID.Length = 0 Then
                MsgBox("Please Enter a Child ID", MsgBoxStyle.Information)
                lblChildID.ForeColor = Color.Red
                FailCheck = False
            End If
            'check sex
            If Sex <> "M" Then
                If Sex <> "F" Then
                    MsgBox("Please Enter a Valid Sex; M or F", MsgBoxStyle.Information)
                    lblSex.ForeColor = Color.Red
                    FailCheck = False
                ElseIf Sex.Length = 0 Then
                    MsgBox("Please Enter a Sex", MsgBoxStyle.Information)
                    lblSex.ForeColor = Color.Red
                    FailCheck = False
                End If
            End If
            'check DOB
            If DOB.Contains("  /") Then
                MsgBox("Please Enter a D.o.B", MsgBoxStyle.Information)
                Label1.ForeColor = Color.Red
                FailCheck = False
            End If
            'if anything failed, exit
            If FailCheck = False Then
                Exit Sub
            Else
                'kill the while loop
                FailCheck = False
            End If
        End While
        'initialise vars
        StrMonth = ""
        ChildID = ""
        RawDOB = mskdob.Text
        ChildID = mskChildID.Text
        'strip the date so that only the month remains
        DateDir = mskdob.Text.Remove(0, 3)
        DateDir = DateDir.Remove(2, 5)
        'strip the leading 0, if there is one
        If DateDir.StartsWith("0") = True Then
            DateDir = DateDir.Remove(0, 1)
        End If
        'Convert the raw date into a month
        MonthConvInt2Str(DateDir, StrMonth)
        'check if the child id dir already exists. If not, create it
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\Child" + ChildID) = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID)
        Else 'if it exists, confirm overwrite
            MsgCount = MsgBox("This Child Already Exists. Overwrite?", MsgBoxStyle.YesNoCancel)
            If MsgCount = 6 Then 'yes
                My.Computer.FileSystem.DeleteDirectory("C:\Childrens Centre\Child Data\Child" + ChildID, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID)
            End If
        End If
        'My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
        'stream = File.Create("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + MonthDir + "\Progress.txt")
        stream = File.Create("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt")
        stream.Close()
        'write all of the info to the info.txt file
        My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt", ChildID + vbCrLf + Sex + vbCrLf + RawDOB, False)
        'initialise all fields
        MsgCount = MsgBox("Do You Wish To Add Data For This Child?", MsgBoxStyle.OkCancel, "Add Data For This Child?")
        If MsgCount = 1 Then
            ChildIDCarryForward = ChildID
            OldChildDataEntry.Show()
        Else
            ChildIDCarryForward = ""
            MainForm.Show()
            Me.Close()
        End If
        InitDataEntry()
    End Sub

    Private Sub InitDataEntry()
        'initialise textboxes and radio buttons
        mskChildID.Text = ""
        mskdob.Text = ""
        txtSex.Text = ""
        'initialise lbl colours
        lblChildID.ForeColor = Color.Black
        Label1.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        LoadChildData()
    End Sub

    Public Sub LoadChildData()
        Dim LoadID As String, LoadDOB As String, LoadSex As String

        LoadID = InputBox("What Is The ID Of The Child You Would Like To See?", "ID?")
        LoadSex = ""
        LoadDOB = ""
        'load all data
        ReadInfoTxt(LoadID, LoadSex, LoadDOB)
        'set all of the Loaded Data txtbxs to visible = true and put in the leading text
        lblLoadedHeading.Visible = True
        lblLoadedChildID.Text = "This Data is for Child: " + LoadID
        lblLoadedChildID.Visible = True
        lblLoadedSex.Text = "The Sex of the Child is:" + LoadSex
        lblLoadedSex.Visible = True
        lblDOB.Text = "The Child's D.o.B is: " + LoadDOB
        lblDOB.Visible = True
    End Sub

    Private Sub ReadInfoTxt(ByRef LoadID, ByRef LoadSex, ByRef LoadDOB)
        Dim fileReader As System.IO.StreamReader
        Dim LineCount As Integer

        'point the streamreader to the right file
        fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Childrens Centre\Child Data\" + "Child" + LoadID + "\Info.txt")
        'initialise the line counter
        LineCount = 1
        'While the streamreader isn't at the end of the file, the variable = the line, changed by the counter
        While fileReader.EndOfStream = False
            If LineCount = 1 Then
                LoadID = fileReader.ReadLine()
            ElseIf LineCount = 2 Then
                LoadSex = fileReader.ReadLine()
            ElseIf LineCount = 3 Then
                LoadDOB = fileReader.ReadLine()
            End If
            LineCount = LineCount + 1
        End While
    End Sub

    Public Function MonthConvInt2Str(ByRef SelCase As String, ByRef StrMonth As String)
        Select Case SelCase
            Case 1
                StrMonth = "January"
            Case 2
                StrMonth = "February"
            Case 3
                StrMonth = "March"
            Case 4
                StrMonth = "April"
            Case 5
                StrMonth = "May"
            Case 6
                StrMonth = "June"
            Case 7
                StrMonth = "July"
            Case 8
                StrMonth = "August"
            Case 9
                StrMonth = "September"
            Case 10
                StrMonth = "October"
            Case 11
                StrMonth = "November"
            Case 12
                StrMonth = "December"
        End Select
        Return StrMonth
    End Function

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cmdGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraph.Click
        DGraph.Show()
    End Sub

    
End Class
