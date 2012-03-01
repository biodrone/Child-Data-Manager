﻿Imports System.IO
Imports System.Security.Cryptography

Public Class Login
    Dim arrsave As String, UsernameBox As String, PasswordBox As String, userpasssave As String
    Dim filereader As String, userpassreset As String, strUser As String, strPass As String, currentN As String
    Dim n As Integer, l As Integer, intusers As Integer, passhash As Integer, Attempts As Integer = 0
    Dim PasswordEnc As String, currentField As String, currentFieldDec As String, UnEncPass As String = ""
    Dim PassOverBool As Boolean, AllowPassword As Boolean = False, AddUsrValidation As Boolean = False
    Dim UserFail As Boolean = True, HashMatch As Boolean

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ChildCentLoc As String = "C:\Childrens Centre", UsersLoc As String = ChildCentLoc + "\Users"
        Dim AdminUser As String = UsersLoc + "\admin"
        AcceptButton = cmdLogIn
        userpasssave = ""
        txtPass.Text = ""
        If My.Computer.FileSystem.DirectoryExists(AdminUser) = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Childrens Centre\Users\admin")
            cmdLogIn.Visible = False
            cmdExit.Visible = False
            cmdAddUser.Visible = False
            cmdFirstUser.Visible = True
        Else
            cmdLogIn.Visible = True
            cmdExit.Visible = True
            cmdAddUser.Visible = True
            cmdFirstUser.Visible = False
        End If
    End Sub

    Public Sub cmdAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUser.Click
        'initialise text boxes
        UsernameBox = ""
        PasswordBox = ""
        'check to see if the user is registered before they can add a new user
        UsernameBox = InputBox("Username?", , " ")
        PasswordBox = InputBox("Password?", , " ")
        'inisialise HashMatch and decrypt the password
        HashMatch = False
        HashMatch = MD5_Dec()
        'if validation succeeds, show the userpassform, if not then msgbox
        If HashMatch = True Then
            UserPassForm.Show()
        Else
            MsgBox("Sorry, You Do Not Have Privileges To Do This!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub AddUser()
        Dim MsgCount As Integer
        Dim PassFilePath As String, PasshashEnc As String, UserFoldPath As String
        'set all variables
        UsernameBox = UserPassForm.txtUser.Text
        PasswordBox = UserPassForm.txtPass.Text
        UserFoldPath = "C:\Childrens Centre\Users\" + UsernameBox
        PassFilePath = "C:\Childrens Centre\Users\" + UsernameBox + "\EncryptedPassword.txt"
        'check dir's and confirm overwrites
        If My.Computer.FileSystem.DirectoryExists(UserFoldPath) = False Then
            If My.Computer.FileSystem.FileExists(PassFilePath) = True Then
                'checks if the user wants to overwrite their password
                MsgCount = MsgBox("Overwrite Password?", MsgBoxStyle.YesNo, "Overwrite?")
                If MsgCount = 6 Then
                    Kill(PassFilePath)
                    If UserPassForm.txtPass.Text = UserPassForm.txtPassVeri.Text Then
                        My.Computer.FileSystem.CreateDirectory(UserFoldPath)
                        My.Computer.FileSystem.WriteAllText(PassFilePath, PasswordBox, False)
                        PasshashEnc = MD5_Enc(PassFilePath)
                        My.Computer.FileSystem.WriteAllText(PassFilePath, PasshashEnc, False)
                    Else
                        MsgBox("Sorry, Passwords Do Not Match!", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                If UserPassForm.txtPass.Text = UserPassForm.txtPassVeri.Text Then
                    My.Computer.FileSystem.CreateDirectory(UserFoldPath)
                    My.Computer.FileSystem.WriteAllText(PassFilePath, PasswordBox, False)
                    PasshashEnc = MD5_Enc(PassFilePath)
                    My.Computer.FileSystem.WriteAllText(PassFilePath, PasshashEnc, False)
                Else
                    MsgBox("Sorry, Passwords Do Not Match!", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("This User Already Exists", MsgBoxStyle.Information)
        End If
        'easy way to create another user
        MsgCount = MsgBox("Create Another User?", MsgBoxStyle.YesNoCancel)
        If MsgCount = 7 Then
            Me.Show()
        ElseIf MsgCount = 6 Then
            UserPassForm.Show()
        ElseIf MsgCount = 2 Then
            Me.Show()
        End If
        'reset visibilities
        cmdLogIn.Visible = True
        cmdExit.Visible = True
        cmdAddUser.Visible = True
        cmdFirstUser.Visible = False
    End Sub

    Public Sub cmdLogIn_Click() Handles cmdLogIn.Click
        Dim MsgCount As Integer
        'initialise and set vars
        UsernameBox = ""
        PasswordBox = ""
        UsernameBox = txtUser.Text
        'make sure that a username has been entered
        If UsernameBox = "" Then
            MsgBox("Please Enter A Username", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'make sure that a password has been entered
        PasswordBox = txtPass.Text
        If PasswordBox = "" Then
            MsgBox("Please Enter A Password", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'checks if user already exists and then decrypt
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Users\" + UsernameBox) Then
            HashMatch = MD5_Dec()
            If HashMatch = True Then
                MsgBox("Congratulations! You Have Logged In!", MsgBoxStyle.Information)
                Me.Hide()
                MainForm.Show()
            Else
                MsgCount = MsgBox("Sorry, Could Not Log You In!", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox("Sorry, User Does Not Exist")
            Exit Sub
        End If
        're-initialise
        txtPass.Text = ""
        txtUser.Text = ""
    End Sub

    Public Function ReadPassFile(ByVal FileName As String) As String
        Dim StoredHash As FileStream
        StoredHash = File.Open(FileName, FileMode.Open, FileAccess.Read)
        Return StoredHash.ToString
    End Function

    Public Function MD5_Enc(ByVal FileName As String) As String 'MD5 hasher
        Dim md5 As New MD5CryptoServiceProvider
        Dim passpath As FileStream
        Dim hash() As Byte

        Try
            passpath = File.Open(FileName, FileMode.Open, FileAccess.ReadWrite)
            hash = md5.ComputeHash(passpath)
            passpath.Close()
            md5.Clear()
            Return BitConverter.ToString(hash).Replace("-", "").ToUpper
        Catch
            MsgBox("An Error Occurred!", MsgBoxStyle.Critical)
            Return Nothing
        End Try

    End Function

    Public Function MD5_Dec() As String 'decrypts MD5 hashes and checks them against the stored passwords
        Dim OldHash As String, TempPassVeri As String, NewHash As String, UserFoldPath As String
        UserFoldPath = "C:\Childrens Centre\Users\" + UsernameBox
        OldHash = My.Computer.FileSystem.ReadAllText(UserFoldPath + "\EncryptedPassword.txt")
        'create a temp file to store the users entered password to match it against the ine already on file
        TempPassVeri = My.Computer.FileSystem.GetTempFileName()
        My.Computer.FileSystem.WriteAllText(TempPassVeri, PasswordBox, False)
        NewHash = MD5_Enc(TempPassVeri)
        Kill(TempPassVeri)
        If NewHash = OldHash Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CreateFirstUser(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirstUser.Click
        UserPassForm.Show()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class

