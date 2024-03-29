﻿'import namespaces
Imports System.IO
Imports System.Security.Cryptography

Public Class NewChildDataEntry
    'define global variables
    Dim ChildID As String, DateDir As String, RawDOB As String, StrMonth As String
    Dim stream As FileStream

    'set the form load sub
    Private Sub NewChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolTip1.IsBalloon = False
        Me.mskdob.Mask = "00/00/0000"
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

        'initialise label colours to black
        lblChildID.ForeColor = Color.Black
        lblDOB.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
        'presence check on all form fields
        FailCheck = True
        'load variables for presence check
        ID = mskChildID.Text
        Sex = txtSex.Text
        DOB = mskdob.Text
        While FailCheck = True 'if a field is blank, FailCheck is set to False, breaking the while loop
            'check ID
            If ID.Length = 0 Then
                MsgBox("Please Enter a Child ID", MsgBoxStyle.Information)
                lblChildID.ForeColor = Color.Red
                FailCheck = False
            End If
            If IsNumeric(ID) = False Then
                MsgBox("Please Enter a Valid Child ID", MsgBoxStyle.Information)
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
                lblDOB.ForeColor = Color.Red
                FailCheck = False
            End If
            'check for future date
            If DOB.Remove(0, 6) > Date.Now.Year Then
                MsgBox("Please Enter a valid D.o.B", MsgBoxStyle.Information, "You Have Entered a Future Date")
                lblDOB.ForeColor = Color.Red
                FailCheck = False
            End If
            'if anything failed, exit
            If FailCheck = False Then
                Exit Sub
            Else 'if nothing failed, break the while loop and move on
                FailCheck = False
            End If
        End While
        'initialise vars and set vars to textboxes
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
        'check if the child id dir already exists; if not, create it
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Child Data\Child" + ChildID) = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID)
        Else 'if it exists, confirm overwrite
            MsgCount = MsgBox("This Child Already Exists. Overwrite?", MsgBoxStyle.YesNoCancel)
            'if yes was clicked
            If MsgCount = 6 Then 'yes
                My.Computer.FileSystem.DeleteDirectory("C:\Childrens Centre\Child Data\Child" + ChildID, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Child Data\Child" + ChildID)
            End If
        End If
        'create the child's info file
        stream = File.Create("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt")
        stream.Close()
        'write all of the info to the info.txt file
        My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\Child" + ChildID + "\Info.txt", ChildID + vbCrLf + Sex + vbCrLf + RawDOB, False)
        MsgCount = MsgBox("Do You Wish To Add Data For This Child?", MsgBoxStyle.YesNoCancel, "Add Data For This Child?")
        If MsgCount = 6 Then
            ChildIDCarryForward = ChildID
            Me.Close()
            OldChildDataEntry.Show()
        Else
            ChildIDCarryForward = ""
            Me.Close()
            MainForm.Show()
        End If
        InitDataEntry()
    End Sub

    Private Sub InitDataEntry()
        'initialise textboxes
        mskChildID.Text = ""
        mskdob.Text = ""
        txtSex.Text = ""
        'initialise label colours to black
        lblChildID.ForeColor = Color.Black
        lblDOB.ForeColor = Color.Black
        lblSex.ForeColor = Color.Black
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
        Close()
        Login.Show()
    End Sub
End Class