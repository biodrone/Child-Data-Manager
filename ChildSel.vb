Public Class ChildSel

    Private Sub ChildSel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Children = From ID In System.IO.Directory.EnumerateDirectories(ChildDataLoc)
        Dim Item_ID As String

        For Each ID In Children
            Item_ID = ID.Substring(31)
            cmbChild.Items.Add(Item_ID)
        Next
    End Sub
End Class