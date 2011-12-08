Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class MainForm
    Private Sub Logout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub AddOld(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddOld.Click
        OldChildDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub AddNew(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        NewChildDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub Graph(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraph.Click
        DGraph.Show()
        Me.Close()
    End Sub

    Private Sub Archive(sender As System.Object, e As System.EventArgs) Handles cmdArchive.Click
        Dim msgcount As Integer = 0
        msgcount = MsgBox("Are you sure you want to archive? (This will store data elsewhere and require manual configuration to load this data)", MsgBoxStyle.YesNo, "Confirm Archive")
        Dim ArchFold As String = "C:\Childrens Centre\Archive\", ChildFold As String = "C:\Childrens Centre\Child Data\"
        Dim CurMonth As String = NewChildDataEntry.MonthConvInt2Str(Today.Month, CurMonth), ArchYear As String = ArchFold + Today.Year.ToString + "\"
        Dim ArchMonth As String = (ArchYear + CurMonth)
        If msgcount = 6 Then
            Try
                If DirectoryExists(ArchFold) = False Then
                    CreateDirectory(ArchFold)
                End If
                CreateDirectory(ArchYear)
                CreateDirectory(ArchMonth)
                MoveDirectory(ChildFold, ArchMonth, FileIO.UIOption.AllDialogs)
                CreateDirectory("C:\Childrens Centre\Child Data")

            Catch ex As IO.IOException
                MsgBox("A filesystem error occurred, please contact your administrator", MsgBoxStyle.Critical, "Error!")
            End Try
        Else
            Exit Sub
        End If

    End Sub
End Class