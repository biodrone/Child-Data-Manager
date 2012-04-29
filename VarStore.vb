Public Module VarStore

    Property ChildIDCarryForward As Object = ""
    Property UsersPath As Object = "C:\Childrens Centre\Users\"
    Property ChildCentLoc As Object = "C:\Childrens Centre\"
    Property ChildDataLoc As Object = "C:\Childrens Centre\Child Data\"
    Property ArchFold As Object = "C:\Childrens Centre\Archive\" + Year(Date.Today).ToString + "\"

End Module
