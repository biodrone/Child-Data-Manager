Public Class OldChildDataEntry
    Private Sub OldChildDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ToolTip1.IsBalloon = False
        Me.mskDate.Mask = "00/00/0000"
        mskDate.ValidatingType = GetType(System.DateTime)
        RadioGroupController()
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
    Function DateStripper()
        Dim DateDir As String
        'strip the date so that only the month remains
        DateDir = mskDate.Text.Remove(0, 3)
        DateDir = DateDir.Remove(2, 5)
        'strip the leading 0, if there is one
        If DateDir.StartsWith("0") = True Then
            DateDir = DateDir.Remove(0, 1)
        End If

    End Function
    Function RadButtonCheck()
        Select Case True
            Case radAhead.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "A" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
            Case radDelay.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "D" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
            Case radTarget.Checked
                My.Computer.FileSystem.WriteAllText("C:\Childrens Centre\Child Data\" + "Child" + ChildID + "\" + MonthDir + "\Progress.txt", "T" + vbCrLf + SexCheck + vbCrLf + DOB + vbCrLf + RawDate, False)
        End Select
    End Function
    Function MonthConvInt2Str(ByRef SelCase As String, ByRef VarForStr As String)
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
    End Function

End Class