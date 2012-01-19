﻿Public Class UserPassForm

    Public Sub UserPassForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide() 'hide main form
    End Sub

    Public Sub cmdInfoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfoSave.Click
        Me.Hide() 'hide the current Form
        Login.AddUser() 'trigger the AddUser subroutine on the main Form
        'initialise text boxes
        txtUser.Text = ""
        txtPass.Text = ""
        txtPassVeri.Text = ""
    End Sub
End Class