Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

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
    End Sub
End Class