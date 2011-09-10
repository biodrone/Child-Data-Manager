Imports System.IO
Imports System.Security.Cryptography

Public Class Form1
    Dim arr1(0 To 5, 0 To 5) As Integer, i As Integer, j As Integer
    Dim arrsave As String, UsernameBox As String, PasswordBox As String, userpasssave As String
    Dim filereader As String, userpassreset As String, strUser As String, strPass As String, currentN As String
    Dim n As Integer, l As Integer, intusers As Integer, passhash As Integer, Attempts As Integer = 0
    Dim PasswordEnc As String, currentField As String, currentFieldDec As String, UnEncPass As String = ""
    Dim PassOverBool As Boolean, AllowPassword As Boolean = False, AddUsrValidation As Boolean = False
    Dim UserFail As Boolean = True, HashMatch As Boolean

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userpasssave = ""
        'Now the colour is blue!
    End Sub

    Public Sub cmdAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUser.Click
        UsernameBox = ""
        PasswordBox = ""
        HashMatch = False
        HashMatch = MD5_Dec()

        If HashMatch = True Then
            UserPassForm.Show()
        Else
            MsgBox("Sorry, You Do Not Have Privileges To Do This!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub AddUser()
        Dim MsgCount As Integer
        Dim PassFilePath As String, PasshashEnc As String, UserFoldPath As String

        UsernameBox = UserPassForm.txtUser.Text
        PasswordBox = UserPassForm.txtPass.Text
        UserFoldPath = "C:\Users\" + UsernameBox
        PassFilePath = "C:\Users\" + UsernameBox + "\EncryptedPassword.txt"

        If My.Computer.FileSystem.DirectoryExists(UserFoldPath) = True Then
            MsgBox("This User Already Exists", MsgBoxStyle.Information)
            If My.Computer.FileSystem.FileExists(PassFilePath) = True Then
                MsgCount = MsgBox("Overwrite Password?", MsgBoxStyle.YesNo, ) 'checks if the user wants to overwrite their password
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
        End If

        MsgCount = MsgBox("Create Another User?", MsgBoxStyle.YesNoCancel)
        If MsgCount = 7 Then
            Me.Show()
        ElseIf MsgCount = 6 Then
            UserPassForm.Show()
        ElseIf MsgCount = 2 Then
            Me.Show()
        End If
    End Sub

    Public Sub cmdLogIn_Click() Handles cmdLogIn.Click
        Dim MsgCount As Integer
        UsernameBox = ""
        PasswordBox = ""

        UsernameBox = InputBox("Username?", , " ")
        While UsernameBox = " "
            UsernameBox = InputBox("Username?", , " ")
        End While
        If UsernameBox = "" Then
            Exit Sub
        End If
        If My.Computer.FileSystem.DirectoryExists("C:/Users/" + UsernameBox) Then
            HashMatch = MD5_Dec()
            If HashMatch = True Then
                MsgBox("Congratulations! You Have Logged In!", MsgBoxStyle.Information)
                Me.Hide()
                ChildDataEntry.Show()
            Else
                MsgCount = MsgBox("Sorry, Could Not Log You In!", MsgBoxStyle.RetryCancel)
                If MsgCount = 4 Then
                    cmdLogIn_Click()
                End If
            End If
        Else
            MsgBox("Sorry, User Does Not Exist")
            cmdLogIn_Click()
        End If
    End Sub

    Public Function ReadPassFile(ByVal FileName As String) As String
        Dim StoredHash As FileStream
        StoredHash = File.Open(FileName, FileMode.Open, FileAccess.Read)
        Return StoredHash.ToString
    End Function
    Public Function MD5_Enc(ByVal FileName As String) As String
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
    Public Function MD5_Dec() As String
        Dim OldHash As String, TempPassVeri As String, NewHash As String, UserFoldPath As String
        PasswordBox = InputBox("Password?")
        UserFoldPath = "C:\Users\" + UsernameBox
        OldHash = My.Computer.FileSystem.ReadAllText(UserFoldPath + "\EncryptedPassword.txt")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UserPassForm.Show()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class

'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'    Dim strHash As String
'    strHash = MD5_Enc("C:\pass.txt")
'    MsgBox(strHash)
'End Sub

'Function RandEncrypter()
'    Dim MsgCount As Integer
'    Dim endofword As Integer
'    Dim m As Integer
'    Dim currentChar As String
'    PasswordEnc = ""
'    UnEncPass = ""
'    endofword = Len(PasswordBox) + 1 'for the do while loop - get the length of the password and add 1
'    m = 1
'    'If My.Computer.FileSystem.FileExists("C:\Users\" + UsernameBox + "\EncryptedPassword") = True Then
'    '    MsgBox("Overwrite Password?", MsgBoxStyle.YesNo, ) 'checks if the user wants to overwrite their password
'    '    If MsgCount = 7 Then
'    '        PassOverBool = False
'        Else
'    My.Computer.FileSystem.DeleteFile("C:\Users\" + UsernameBox + "\EncryptedPassword")
'    Do While m <> endofword
'        currentChar = Mid(PasswordBox, m, 1) 'get current letter of password
'        PasswordEnc = Asc(currentChar) 'ASCII val of current letter
'        My.Computer.FileSystem.WriteAllText("C:\Users\" + UsernameBox + "\EncryptedPassword", PasswordEnc + vbCrLf, True)
'        m = m + 1 'next letter of users password
'    Loop
'        End If
'    Else
'    Do While m <> endofword
'        currentChar = Mid(PasswordBox, m, 1) 'get current letter of password
'        PasswordEnc = Asc(currentChar) 'ASCII val of current letter
'        My.Computer.FileSystem.WriteAllText("C:\Users\" + UsernameBox + "\EncryptedPassword", PasswordEnc + vbCrLf, True)
'        m = m + 1 'next letter of users password
'    Loop
'    End If
'    Return PasswordEnc
'End Function

'Function RandDecrypter(ByRef Attempts As Integer)
'    Dim MsgCount As Integer
'    If Attempts < 3 Then
'        UnEncPass = ""
'        UsernameBox = InputBox("What Is Your Username?", "Attempts: " + (3 - Attempts).ToString)
'        If UsernameBox.Length.ToString >= 1 Then
'            If My.Computer.FileSystem.DirectoryExists("C:\Users\" + UsernameBox + "\") = True Then
'                Dim fileReader =
'                    My.Computer.FileSystem.OpenTextFileReader("C:\Users\" + UsernameBox + "\EncryptedPassword")
'                Do
'                    Dim currentLine As Integer = fileReader.ReadLine() 'Initialise currentLine each loop
'                    UnEncPass = UnEncPass + Chr(currentLine) 'add the latest char of the password
'                Loop Until fileReader.EndOfStream = True
'                fileReader.Close()
'                UserFail = False
'                Attempts = 0
'            Else
'                Attempts = Attempts + 1
'                MsgCount = MsgBox("Username Is Not Valid!", MsgBoxStyle.RetryCancel)
'                If MsgCount = 2 Then
'                    Return Nothing
'                Else
'                    Call RandDecrypter(Attempts)
'                End If
'            End If
'        Else
'            MsgBox("Username Is Not Long Enough, Please Try Again!", MsgBoxStyle.Exclamation)
'            Attempts = Attempts + 1
'            Call RandDecrypter(Attempts)
'        End If

'        Call PasswordVerifyFunct(UserFail, 0)
'    Else
'        MsgBox("Sorry, No Attempts Left!", MsgBoxStyle.Exclamation)
'        Me.Show()
'    End If
'    Return UnEncPass
'End Function

'Function PasswordVerifyFunct(ByVal UserFail As Boolean, ByRef Attempts As Integer)
'    Dim PasswordVerify As String
'    Dim MsgCount As Integer
'    If UserFail = False Then
'        If Attempts < 3 Then
'            PasswordVerify = InputBox("What Is Your Password?", "Attempts Left: " + (3 - Attempts).ToString)
'            If PasswordVerify = UnEncPass Then
'                AllowPassword = True
'                AddUsrValidation = True
'            Else
'                MsgBox("Sorry, Incorrect Password!", MsgBoxStyle.Exclamation)
'                Attempts = Attempts + 1
'                Call PasswordVerifyFunct(False, Attempts)
'            End If
'        Else
'            MsgCount = MsgBox("No Attempts Left!", MsgBoxStyle.RetryCancel)
'            If MsgCount = 4 Then
'                Call RandDecrypter(0)
'            Else
'                Return Nothing
'            End If
'        End If
'    End If
'End Function