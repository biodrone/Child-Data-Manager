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
        Dim ArchFold As String = "C:\Childrens Centre\Archive\", ChildFold As String = "C:\Childrens Centre\Child Data"
        Dim ArchYear As String = Today.Year.ToString 'MAKE A YEAR FOLDER FOR EACH CHILD SO THAT YOU CAN COPY THE NEXT YEARS DATA INTO IT
        If msgcount = 6 Then
            Dim ChildData = From Child In System.IO.Directory.EnumerateDirectories(ChildFold)
            Dim i As Integer = 1
            Try
                If DirectoryExists(ArchFold) = False Then
                    CreateDirectory(ArchFold)
                End If
                For Each Child In ChildData
                    Dim CopyFold As String = ArchFold + "Child" + i.ToString
                    CreateDirectory(CopyFold)
                    MoveDirectory(Child, CopyFold, FileIO.UIOption.AllDialogs)
                    CreateDirectory(Child)
                    Try
                        MoveFile(CopyFold + "\Info.txt", Child + "\Info.txt")
                    Catch ex As IO.IOException
                        MsgBox("Child Information File Not Found", MsgBoxStyle.Critical)
                    End Try
                    i = i + 1
                Next
            Catch ex As IO.IOException
                MsgBox("A filesystem error occurred, please contact your administrator", MsgBoxStyle.Critical, "Error!")
            End Try
            'NEXT, CREATE A BUTTON THAT DELETES EACH CHILD'S ACCOUNT AT YEARS END TO MAKE WAY FOR THE NEW ROUND OF KIDS
        End If
    End Sub
End Class