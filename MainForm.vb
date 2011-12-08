Public Class MainForm
    'set all of the buttons to open the right forms
    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub cmdAddOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddOld.Click
        OldChildDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        NewChildDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub cmdGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraph.Click
        DGraph.Show()
        Me.Close()
    End Sub

    Private Sub Archive(sender As System.Object, e As System.EventArgs) Handles cmdArchive.Click
        Dim msgcount As Integer
        msgcount = MsgBox("Are you sure you want to acrhive? (This will store data elsewhere and require manual configuration to load this data)", MsgBoxStyle.YesNo, "Confirm Archive")
        If msgcount = 6 Then

        Else
            Exit Sub
        End If

    End Sub
End Class