Imports System.IO
Imports System.Security.Cryptography
Public Class NewChildDataEntry
    Dim ChildID As String, MonthDir As String, DateDir As String, RawDOB As String, StrMonth As String
    Dim stream As FileStream

    Private Sub NewChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolTip1.IsBalloon = False
        Me.mskdob.Mask = "00/00/0000"
        lblLoadedHeading.Hide()
    End Sub

    Private Sub mskDate_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) Handles mskdob.MaskInputRejected
        ToolTip1.ToolTipTitle = "Invalid Input"
        ToolTip1.Show("Sorry, Only Numbers 0-9 Are Allowed In Dates", mskdob, 500)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
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
            If Sex <> "M" Or "F" Then
                MsgBox("Please Enter a Valid Sex; M or F", MsgBoxStyle.Information)
                lblSex.ForeColor = Color.Red
                FailCheck = False
            End If
            If Sex.Length = 0 Then
                MsgBox("Please Enter a Sex", MsgBoxStyle.Information)
                lblSex.ForeColor = Color.Red
                FailCheck = False
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
        Else 'if it exists, check if the month exists. If so, confirm overwrite
            If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth) = True Then
                MsgCount = MsgBox("Child's Data for This Month Already Exists. Overwrite?", MsgBoxStyle.YesNoCancel)
                If MsgCount = 6 Then 'if yes, delete the dir then create it
                    My.Computer.FileSystem.DeleteDirectory("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth)
                Else
                    InitDataEntry()
                    Exit Sub
                End If
            Else
                My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
            End If
        End If
        'My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir)
        stream = File.Create("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + MonthDir + "\Progress.txt")
        stream = File.Create("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt")
        stream.Close()
        'write all of the info to the info.txt file
        My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt", ChildID + vbCrLf + Sex + vbCrLf + RawDOB, False)
        'initialise all fields
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

    Function MonthConvInt2Str(ByRef SelCase As String, ByRef StrMonth As String)
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
End Class
