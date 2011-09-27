Imports System.IO
Imports System.Security.Cryptography
Public Class OldChildDataEntry
    Dim StrMonth As String, DateDir As String, RadChecked As String, ChildID As String, LoadRad As String, LoadDate As String

    Private Sub OldChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'initialise variables
        Me.ToolTip1.IsBalloon = False
        Me.mskDate.Mask = "00/00/0000"
        mskDate.ValidatingType = GetType(System.DateTime)
        RadioGroupController()
        lblLoadedChildID.Visible = False
        lblLoadedHeading.Visible = False
        lblLoadedProgressBox.Visible = False
        lblLoadedUpdateDate.Visible = False
        'check if the user already added a user and chose to add data for them
        If NewChildDataEntry.lblChIdCarryForward.Text.Length <> 1 Then
            ChildID = InputBox("What Is The Child's ID?", "ID?")
        Else
            ChildID = NewChildDataEntry.lblChIdCarryForward.Text
        End If
    End Sub

    Private Sub mskDate_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) Handles mskDate.MaskInputRejected
        'set the tooptip to notify if the text is rejectde by the mask
        ToolTip1.ToolTipTitle = "Invalid Input"
        ToolTip1.Show("Sorry, Only Numbers 0-9 Are Allowed In Dates", mskDate, 500)
    End Sub

    Public Sub RadioGroupController()
        'add radio buttons to the controller
        GBProgress.Controls.Add(radDelay)
        GBProgress.Controls.Add(radAhead)
        GBProgress.Controls.Add(radTarget)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Dim strDate As String, RawDate As String
        Dim MsgCount As Integer
        Dim stream As FileStream

        RawDate = mskDate.Text
        strDate = RawDate
        DateStripper(strDate)
        'convert date to month
        MonthConvInt2Str(strDate, StrMonth)
        'create dirs
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth) = True Then
            MsgCount = MsgBox("Child's Data for This Month Already Exists. Overwrite?", MsgBoxStyle.YesNoCancel)
            If MsgCount = 6 Then 'yes
                My.Computer.FileSystem.DeleteDirectory("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID + "\" + StrMonth)
            Else
                InitDataFields()
                Exit Sub
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + StrMonth)
        End If
        'determine which radio button has been checked
        RadButtonCheck()
        'create the progress.txt file
        stream = File.Create("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + StrMonth + "\Progress.txt")
        stream.Close()
        'write to the file
        My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + StrMonth + "\Progress.txt", RadChecked + vbCrLf + RawDate, False)
        MsgCount = MsgBox("Add More Data?", MsgBoxStyle.YesNo)
        If MsgCount = 6 Then
            MsgCount = MsgBox("Same Child ID?", MsgBoxStyle.YesNo)
            If MsgCount = 6 Then
                InitDataFields()
            Else
                ChildID = InputBox("New Child ID?", "New ID?")
            End If
        Else
            MainForm.Show()
        End If
    End Sub

    Function DateStripper(ByRef DateDir)
        'strip the date so that only the month remains
        DateDir = DateDir.Remove(0, 3)
        DateDir = DateDir.Remove(2, 5)
        'strip the leading 0, if there is one
        If DateDir.StartsWith("0") = True Then
            DateDir = DateDir.Remove(0, 1)
        End If
        Return DateDir
    End Function

    Function RadButtonCheck()
        RadChecked = ""
        Select Case True
            Case radAhead.Checked
                RadChecked = "A"
            Case radDelay.Checked
                RadChecked = "D"
            Case radTarget.Checked
                RadChecked = "T"
        End Select
        Return RadChecked
    End Function

    Function MonthConvInt2Str(ByRef SelCase As String, ByRef StrMonth As String)
        'take the variable representing the month as a number and return it as a string (StrMonth)
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

    Private Sub InitDataFields()
        mskDate.Text = ""
    End Sub
    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cmdGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraph.Click
        DGraph.Show()
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Dim LoadChID As String

        LoadChID = InputBox("What Child's Data Do You Wish To View?", "ID?")
        LoadDate = ""
        LoadRad = ""
        ReadProgressTxt(LoadChID)
        lblLoadedHeading.Visible = True
        lblLoadedUpdateDate.Text = "On: " + LoadDate
        lblLoadedUpdateDate.Visible = True
        lblLoadedChildID.Text = "Child: " + LoadChID + " Was:"
        'find out which rad button should be checked, then check it
        If LoadRad = "A" Then
            lblLoadedProgressBox.Text = "AHEAD OF TARGET"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.DarkGreen
        ElseIf LoadRad = "D" Then
            lblLoadedProgressBox.Text = "AT RISK OF DELAY"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.Red
        ElseIf LoadRad = "T" Then
            lblLoadedProgressBox.Text = "ON TARGET"
            lblLoadedProgressBox.Visible = True
            lblLoadedProgressBox.ForeColor = Color.LightGreen
        End If
    End Sub

    Private Sub ReadProgressTxt(ByRef LoadID)
        Dim fileReader As StreamReader
        Dim LineCount As Integer

        'point the streamreader to the right file
        fileReader =
            My.Computer.FileSystem.OpenTextFileReader("C:\Childrens Centre\Child Data\" + "Child" + LoadID + "\Info.txt")
        'initialise the line counter
        LineCount = 1
        'While the streamreader isn't at the end of the file, read data into vars
        While fileReader.EndOfStream = False
            If LineCount = 1 Then
                LoadDate = fileReader.ReadLine()
            ElseIf LineCount = 2 Then
                LoadRad = fileReader.ReadLine()
            End If
            LineCount = LineCount + 1
        End While
    End Sub
End Class