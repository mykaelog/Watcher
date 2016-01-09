Public Class Watcher

    Dim exploreButton As Button
    Dim dirRoute As TextBox
    Dim monitorize As Button
    Dim activity As TextBox

    Dim explorerForm As Explorer

    Dim watcher As IO.FileSystemWatcher

    Delegate Sub setActivityTextCallback(text As String)

    Private Sub Watcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        exploreButton = explore_button
        dirRoute = nombre_ruta
        monitorize = monitorizar
        activity = actividad_directorio

        Me.CenterToScreen()

    End Sub

    ''' <summary>
    ''' This function check if explorer form is open to resize it or create new  Explorer Instance
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub explore_button_Click(sender As Object, e As EventArgs) Handles explore_button.Click


        If (Application.OpenForms().OfType(Of Explorer).Any = True) Then

            explorerForm.WindowState = FormWindowState.Normal

            explorerForm.BringToFront()

            explorerForm.Show()

        Else

            explorerForm = New Explorer()

            explorerForm.StartPosition = FormStartPosition.CenterParent

            explorerForm.Show()

            explorerForm.TopMost = True

        End If

    End Sub

    Private Sub monitorizar_Click(sender As Object, e As EventArgs) Handles monitorizar.Click

        Dim route As String
        route = dirRoute.Text

        If (route = "" OrElse route.Length = 0) Then
            Exit Sub
        End If

        If (monitorize.Text.ToUpper = "Parar".ToUpper) Then
            watcher.EnableRaisingEvents = False
            activity.Text &= vbCrLf & "End Process on [ " & route & " ] at [ " & Now & " ]" & vbCrLf
            monitorize.Text = "Monitorizar"
            Exit Sub
        End If

        watcher = New IO.FileSystemWatcher(route)
        watcher.IncludeSubdirectories = True
        watcher.EnableRaisingEvents = True

        watcher.NotifyFilter = IO.NotifyFilters.DirectoryName
        watcher.NotifyFilter = watcher.NotifyFilter Or IO.NotifyFilters.FileName
        watcher.NotifyFilter = watcher.NotifyFilter Or IO.NotifyFilters.Attributes
        watcher.NotifyFilter = watcher.NotifyFilter Or IO.NotifyFilters.Size

        AddHandler watcher.Created, AddressOf logChanges
        AddHandler watcher.Changed, AddressOf logChanges
        AddHandler watcher.Deleted, AddressOf logChanges
        AddHandler watcher.Renamed, AddressOf logRename

        activity.Text = "Start Process on [ " & route & " ] at [ " & Now & " ]" & vbCrLf & vbCrLf

        monitorize.Text = "Parar"

    End Sub

    Public Sub logChanges(ByVal source As Object, ByVal e As System.IO.FileSystemEventArgs)

        Dim tempTextActivity As String = ""

        If e.ChangeType = IO.WatcherChangeTypes.Changed Then

            tempTextActivity = "File [ " & e.FullPath & " ] has been modified" & vbCrLf

        End If

        If e.ChangeType = IO.WatcherChangeTypes.Created Then

            tempTextActivity = "File [ " & e.FullPath & " ] has been created" & vbCrLf

        End If

        If e.ChangeType = IO.WatcherChangeTypes.Deleted Then

            tempTextActivity = "File [ " & e.FullPath & " ] has been deleted" & vbCrLf

        End If

        Me.setActivityText(tempTextActivity)

    End Sub

    Public Sub logRename(ByVal source As Object, ByVal e As System.IO.RenamedEventArgs)

        Dim tempTextActivity As String = ""

        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then

            tempTextActivity = "File [ " & e.OldFullPath & " to " & e.FullPath & " ] has been renamed" & vbCrLf

        End If

        Me.setActivityText(tempTextActivity)

    End Sub

    Private Sub setActivityText(ByVal textString As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.

        If Me.activity.InvokeRequired Then

            Dim d As New setActivityTextCallback(AddressOf setActivityText)
            Me.Invoke(d, New Object() {textString})

        Else

            Me.activity.Text &= textString

        End If

    End Sub

End Class
