Public Class LoadMonthCombo
    Dim LoadID As String

    Private Sub LoadMonthCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MonthFolds As String
        LoadID = InputBox("What is the ID of the Child You Would Like to See?")
        lblChildIDHide.Text = LoadID
        For Each MonthFolds In System.IO.Directory.GetDirectories("C:\Childrens Centre\Child Data\" + "Child" + LoadID + "\")
            'MonthFolds.ToString.Substring(37) 'THIS DOESN'T WORK! Shows up as C: still. CUT THAT OFF!
            Select Case True
                Case MonthFolds.EndsWith("January")
                    MonthFolds = "January"
                Case MonthFolds.EndsWith("February")
                    MonthFolds = "February"
                Case MonthFolds.EndsWith("March")
                    MonthFolds = "March"
                Case MonthFolds.EndsWith("April")
                    MonthFolds = "April"
                Case MonthFolds.EndsWith("May")
                    MonthFolds = "May"
                Case MonthFolds.EndsWith("June")
                    MonthFolds = "June"
                Case MonthFolds.EndsWith("July")
                    MonthFolds = "July"
                Case MonthFolds.EndsWith("August")
                    MonthFolds = "August"
                Case MonthFolds.EndsWith("September")
                    MonthFolds = "September"
                Case MonthFolds.EndsWith("October")
                    MonthFolds = "October"
                Case MonthFolds.EndsWith("November")
                    MonthFolds = "November"
                Case MonthFolds.EndsWith("December")
                    MonthFolds = "December"
            End Select
            comLoadMonth.Items.Add(MonthFolds)
        Next

    End Sub

    Private Sub cmdDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDone.Click
        Try
            lblLoadMonth.Text = comLoadMonth.SelectedItem.ToString
            ChildDataEntry.LoadChildData()
        Catch NullError As NullReferenceException
            MsgBox("Please Select A Month", MsgBoxStyle.Information)
            comLoadMonth.DroppedDown = True
        End Try
    End Sub
End Class