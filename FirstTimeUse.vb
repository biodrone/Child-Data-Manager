Public NotInheritable Class FirstTimeUse

    Private Sub FirstTimeUse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Users\admin") = False Then
            Title_FTUC.Text = "First Time? Welcome! Please Create A New User."
        Else
            Title_FTUC.Text = "Welcome To The Data Manager!"
        End If
    End Sub

End Class
