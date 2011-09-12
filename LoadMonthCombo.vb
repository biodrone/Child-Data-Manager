Public Class LoadMonthCombo
    Dim LoadID As String

    Private Sub LoadMonthCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim curFold As String
        LoadID = InputBox("What is the ID of the Child You Would Like to See?")
        lblChildIDHide.Text = LoadID
        For Each curFold In System.IO.Directory.GetDirectories("C:\Childrens Centre\Child Data\" + "Child" + LoadID + "\")
            'curFold.ToString.Substring(37) 'THIS DOESN'T WORK! Shows up as C: still. CUT THAT OFF!
            Select Case True
                Case curFold.EndsWith("January")
                    curFold = "January"
                Case curFold.EndsWith("February")
                    curFold = "February"
                Case curFold.EndsWith("March")
                    curFold = "March"
                Case curFold.EndsWith("April")
                    curFold = "April"
                Case curFold.EndsWith("May")
                    curFold = "May"
                Case curFold.EndsWith("June")
                    curFold = "June"
                Case curFold.EndsWith("July")
                    curFold = "July"
                Case curFold.EndsWith("August")
                    curFold = "August"
                Case curFold.EndsWith("September")
                    curFold = "September"
                Case curFold.EndsWith("October")
                    curFold = "October"
                Case curFold.EndsWith("November")
                    curFold = "November"
                Case curFold.EndsWith("December")
                    curFold = "December"
            End Select
            comLoadMonth.Items.Add(curFold)
        Next

    End Sub

    Private Sub cmdDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDone.Click
        lblLoadMonth.Text = comLoadMonth.SelectedItem.ToString
        ChildDataEntry.LoadChildData()
    End Sub
End Class