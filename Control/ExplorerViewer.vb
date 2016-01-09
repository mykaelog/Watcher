

Public Class ExplorerViewer

    Public Sub New()

    End Sub

    'Private Sub List(ByVal Tree As TreeView)

    '    Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo) = My.Computer.FileSystem.Drives
    '    Dim rootDir As String = String.Empty

    '    For i As Integer = 0 To drives.Count - 1
    '        If Not drives(i).IsReady Then
    '            Continue For
    '        End If
    '        rootDir = drives(i).Name
    '        Tree.Nodes.Add(rootDir)
    '        PopulateTreeView(rootDir, Tree.Nodes(i))
    '        Continue For
    '    Next

    'End Sub

    'Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)

    '    Dim folder As String = String.Empty

    '    Try
    '        Dim folders() As String = IO.Directory.GetDirectories(dir)
    '        If folders.Length <> 0 Then
    '            Dim childNode As TreeNode = Nothing
    '            For Each folder In folders
    '                childNode = New TreeNode(folder)
    '                If (childNode.Level > 0) Then
    '                    Continue For
    '                End If
    '                parentNode.Nodes.Add(childNode)
    '                PopulateTreeView(folder, childNode)
    '            Next
    '        End If
    '    Catch ex As UnauthorizedAccessException
    '        parentNode.Nodes.Add(folder & ": Access Denied")
    '    End Try
    'End Sub


End Class
