Public NotInheritable Class FirstTimeUse

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub FirstTimeUse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).
        If My.Computer.FileSystem.DirectoryExists("C:\Childrens Centre\Users\admin") = False Then
            Title_FTUC.Text = "First Time? Welcome! Please Create A New User."
        Else
            Title_FTUC.Text = "Welcome To The Data Manager!"
        End If

    End Sub

End Class
