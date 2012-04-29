﻿Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class MainForm

    Private Sub Logout(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        Login.Show()
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
        Dim MsgCount As Integer
        Dim ArchFold As String = "C:\Childrens Centre\Archive\" + Year(Date.Today).ToString + "\"
        Dim ChildFold As String = "C:\Childrens Centre\Child Data\"

        'confirm the archiving
        MsgCount = MsgBox("Are you sure you want to archive? (This will store data elsewhere and require manual configuration to load this data)", MsgBoxStyle.YesNo, "Confirm Archive")
        'if yes was clicked
        If MsgCount = 6 Then
            Dim ChildData = From Child In System.IO.Directory.EnumerateDirectories(ChildFold)
            Dim i As Integer = 1

            Try
                'create archive folder if it doesn't exist
                If DirectoryExists(ArchFold) = False Then
                    CreateDirectory(ArchFold)
                End If
                'enumerate directories and move them to the archive folder
                For Each Child In ChildData
                    Dim CopyFold As String = ArchFold + Child.Remove(0, 31)
                    CreateDirectory(CopyFold)
                    MoveDirectory(Child, CopyFold)
                    i = i + 1
                Next
            Catch ex As IO.IOException
                MsgBox("A filesystem error occurred, please contact your administrator", MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As System.Object, e As System.EventArgs) Handles cmdHelp.Click
        Dim doc As String
        'set location of the help document
        doc = "C:\Help.docx"
        'start Word with this document
        Process.Start("WinWord", doc)
    End Sub
End Class