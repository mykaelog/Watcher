Imports System.Runtime.InteropServices

Public Class Explorer


    Dim dirStructure As New TreeView
    Dim accept As Button
    Dim reject As Button
    Dim dirRoute As TextBox

    Dim drives As System.Collections.ObjectModel.ReadOnlyCollection(Of IO.DriveInfo)
    Dim folders() As String
    Dim limitRecursive As Integer = 1

    Private Sub Explorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dirStructure = arbol_directorios
        dirRoute = nombre_ruta
        accept = aceptar_ruta
        reject = cancelar_ruta

        Me.CenterToScreen()

        listDrives()

    End Sub

    Private Sub cancelar_ruta_Click(sender As Object, e As EventArgs) Handles cancelar_ruta.Click

        Me.Dispose()

        Watcher.BringToFront()

    End Sub


    Private Sub aceptar_ruta_Click(sender As Object, e As EventArgs) Handles aceptar_ruta.Click

        Dim action As Integer

        If (dirRoute.Text = "") Then

            action = MsgBox("No has seleccionado ningún directorio", MsgBoxStyle.OkCancel, "¡Advertencia!")

            If (action = DialogResult.OK) Then

                Me.Dispose()

            End If

        Else

            Watcher.nombre_ruta.Text = dirRoute.Text

            Me.Dispose()

        End If

    End Sub

    Private Sub listDrives()

        Dim rootDir As String = String.Empty
        Dim rootNode As TreeNode
        drives = My.Computer.FileSystem.Drives

        For i As Integer = 0 To drives.Count - 1 Step 1

            rootNode = Nothing

            If Not drives(i).IsReady Then
                Continue For
            End If

            rootDir = drives(i).Name

            rootNode = New TreeNode(rootDir)
            rootNode.Text = rootDir
            rootNode.Nodes.Add("*DUMMY*")

            dirStructure.Nodes.Add(rootNode)

        Next

    End Sub

    Private Sub populateTreeViewDirectories(ByVal dir As String, ByVal parentNode As TreeNode, Optional ByVal level As Boolean = True)

        Dim folder As String = String.Empty

        Try

            folders = IO.Directory.GetDirectories(dir).[Select](Function(d) New With { _
                Key .Attr = New IO.DirectoryInfo(d).Attributes, _
                Key .Dir = d _
            }).Where(Function(x) Not x.Attr.HasFlag(IO.FileAttributes.System)).Where(Function(x) Not x.Attr.HasFlag(IO.FileAttributes.Hidden)).[Select](Function(x) x.Dir).ToArray()

            If folders.Length <> 0 Then

                Dim childNode As TreeNode = Nothing

                For Each folder In folders

                    childNode = New TreeNode(folder)

                    If (childNode.Level > 0) Then
                        Continue For
                    End If

                    Dim infoDir As IO.DirectoryInfo
                    infoDir = New IO.DirectoryInfo(folder)

                    childNode.Text = infoDir.Name.Replace("\\\\", "\\").Replace("\\", "\")

                    parentNode.Nodes.Add(childNode)

                    If (level = True) Then
                        populateTreeViewDirectories(folder, childNode, False)
                    End If

                Next

            End If

        Catch ex As UnauthorizedAccessException

            parentNode.Nodes.Add(folder & ": Access Denied")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub _BeforeCollapse(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles arbol_directorios.BeforeCollapse

        e.Node.Nodes.Clear()
        e.Node.Nodes.Add("*DUMMY*")

    End Sub

    Private Sub _BeforeExpand(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles arbol_directorios.BeforeExpand

        e.Node.Nodes.Clear()
        populateTreeViewDirectories(e.Node.FullPath, e.Node)


    End Sub

    Private Sub arbol_directorios_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles arbol_directorios.AfterSelect

        Try
            dirRoute.Text = e.Node.FullPath.Replace("\\\\", "\\").Replace("\\", "\")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub arbol_directorios_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles arbol_directorios.NodeMouseClick

        'e.Node.BackColor = Color.Blue
    End Sub
End Class