Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class ChildSel

    Private Sub ChildSel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Months = From FolderChID In System.IO.Directory.EnumerateDirectories(ChildDataLoc)
    End Sub
End Class