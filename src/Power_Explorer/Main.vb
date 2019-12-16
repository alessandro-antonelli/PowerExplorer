Imports Microsoft.DirectX.AudioVideoPlayback
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports Power_Explorer.My
Imports Power_Explorer.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Main
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Principale_Load)
            Me.Directory = ""
            Me.Interrotto = False
            Me.InitializeComponent
        End Sub

        Private Sub AggiornaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(Me.Directory, True)
        End Sub

        Private Sub AnnullaCaricamentoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Interrotto = True
        End Sub

        Private Sub AnteprimaPlayBut_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Me.SoundFile.Open(Me.ContentView.SelectedItems(0).Name, True)
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                Me.SoundFile = New Audio(Me.ContentView.SelectedItems(0).Name, True)
                ProjectData.ClearProjectError
            End Try
            Me.AnteprimaStopBut.Enabled = True
        End Sub

        Private Sub AnteprimaStopBut_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SoundFile.Stop
            Me.AnteprimaStopBut.Enabled = False
        End Sub

        Private Sub AnteprimaVidPlayButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Me.VideoFile.Open(Me.ContentView.SelectedItems(0).Name, True)
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                Me.VideoFile = New Video(Me.ContentView.SelectedItems(0).Name, True)
                ProjectData.ClearProjectError
            End Try
            Me.VideoFile.Owner = Me.PreviewDisplayPan
            Me.AnteprimaVidStopButt.Enabled = True
        End Sub

        Private Sub AnteprimaVidStopButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.VideoFile.Stop
            Me.AnteprimaVidStopButt.Enabled = False
        End Sub

        Private Sub AntivirRightClick_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MySettingsProperty.Settings.Antivirus <> "") Then
                Process.Start(MySettingsProperty.Settings.Antivirus, Me.ContentView.SelectedItems(0).Name)
            End If
        End Sub

        Public Sub Apri()
            Dim imageIndex As Integer = Me.ContentView.SelectedItems(0).ImageIndex
            If (imageIndex = MySettingsProperty.Settings.FolderIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.FolderFullIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.HardDiskIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.CDIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.USBIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.FloppyIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            ElseIf (imageIndex = MySettingsProperty.Settings.UnknownDriveIcon) Then
                Me.Go(Me.ContentView.SelectedItems(0).Name, True)
            Else
                Try 
                    Process.Start(Me.ContentView.SelectedItems(0).Name)
                Catch exception1 As Exception
                    Dim ex As Exception = exception1
                    ProjectData.SetProjectError(ex)
                    Dim exception As Exception = ex
                    MessageBox.Show("Impossibile aprire il file specificato.", "Errore nell'apertura", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Private Sub ApriConToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenWithDial.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.ProgramFiles
            Me.OpenWithDial.ShowDialog
        End Sub

        Private Sub ApriToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apri
        End Sub

        Public Sub Cancella()
            Dim count As Integer = Me.ContentView.SelectedItems.Count
            If ((count <> 0) AndAlso (count <= 1)) Then
                If (Me.ContentView.SelectedItems(0).ImageIndex = MySettingsProperty.Settings.FolderIcon) Then
                    MyProject.Forms.Delete.LoadInfo(Me.ContentView.SelectedItems(0).Name, True)
                    MyProject.Forms.Delete.Show
                Else
                    MyProject.Forms.Delete.LoadInfo(Me.ContentView.SelectedItems(0).Name, False)
                    MyProject.Forms.Delete.Show
                End If
            End If
        End Sub

        Private Sub CartellaToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Interaction.InputBox("Immettere il nome della cartella da creare:", "Nuova cartella", "Nuova cartella", -1, -1)
            MyProject.Computer.FileSystem.CreateDirectory((Me.DirectoryText.Text & "\" & str))
            Dim item As New ListViewItem
            item.Text = str
            item.ImageIndex = MySettingsProperty.Settings.FolderIcon
            Me.ContentView.Items.Add(item)
        End Sub

        Private Sub CercaAggiornamentiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Updates.Show
        End Sub

        Private Sub CompressRightClick_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Compress.LoadInfo(Me.ContentView.SelectedItems(0).Name, Me.Directory)
            MyProject.Forms.Compress.Show
        End Sub

        Private Sub ContentRightClick_Opened(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.Directory = "Computer") Then
                If (Me.ContentView.SelectedItems.Count = 0) Then
                    Me.ContentRightClick.Close
                ElseIf (Me.ContentView.SelectedItems(0).ImageIndex = MySettingsProperty.Settings.UnknownDriveIcon) Then
                    Me.ContentRightClick.Close
                Else
                    Me.RightDrive
                End If
            ElseIf (Me.ContentView.SelectedItems.Count = 0) Then
                Me.Right0
            Else
                Dim imageIndex As Integer = Me.ContentView.SelectedItems(0).ImageIndex
                If (imageIndex = MySettingsProperty.Settings.FolderIcon) Then
                    Me.RightFolder
                ElseIf (imageIndex = MySettingsProperty.Settings.ArchiveIcon) Then
                    Me.RightArchive
                Else
                    Me.RightGeneric
                End If
            End If
        End Sub

        Private Sub ContentRightClick_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.RightDefault
        End Sub

        Private Sub ContentView_ItemDrag(ByVal sender As Object, ByVal e As ItemDragEventArgs)
        End Sub

        Private Sub ContenutoWiev_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apri
        End Sub

        Private Sub ContenutoWiev_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.PreviewPicture.Visible = False
            Me.PreviewText.Visible = False
            Me.PreviewAudioPan.Visible = False
            Me.PreviewVideoPan.Visible = False
            Me.PreviewHtm.Visible = False
            Me.PreviewPicture.Image = Me.PreviewPicture.InitialImage
            Me.PreviewText.Text = ""
            Try 
                Me.SoundFile.Stop
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.VideoFile.Stop
            Catch exception3 As Exception
                Dim ex As Exception = exception3
                ProjectData.SetProjectError(ex)
                Dim exception2 As Exception = ex
                ProjectData.ClearProjectError
            End Try
            Me.PreviewHtm.Url = New Uri("about:blank")
            Me.AnteprimaStopBut.Enabled = False
            Me.DimensioniLab.Text = "0 KB"
            Me.StatusLab.Text = "Pronto."
            Dim count As Integer = Me.ContentView.SelectedItems.Count
            If (count = 0) Then
                Me.AntivirRightClick.Enabled = False
            ElseIf (count <= 1) Then
                Dim imageIndex As Integer = Me.ContentView.SelectedItems(0).ImageIndex
                If ((((((((imageIndex <> MySettingsProperty.Settings.HardDiskIcon) AndAlso (imageIndex <> MySettingsProperty.Settings.CDIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.USBIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.FloppyIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.NetworkIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.UnknownDriveIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.FolderIcon)) AndAlso (imageIndex <> MySettingsProperty.Settings.FolderFullIcon)) Then
                    Me.DimensioniLab.Text = Me.ConvertLength(MyProject.Computer.FileSystem.GetFileInfo(Me.ContentView.SelectedItems(0).Name).Length)
                    Dim num3 As Integer = Me.ContentView.SelectedItems(0).ImageIndex
                    If (num3 = MySettingsProperty.Settings.WavIcon) Then
                        If MySettingsProperty.Settings.PreviewAudio Then
                            Me.PreviewAudioPan.Visible = True
                        End If
                    ElseIf (num3 = MySettingsProperty.Settings.SoundIcon) Then
                        If MySettingsProperty.Settings.PreviewAudio Then
                            Me.PreviewAudioPan.Visible = True
                        End If
                    ElseIf (num3 = MySettingsProperty.Settings.VideoIcon) Then
                        If MySettingsProperty.Settings.PreviewVideo Then
                            Me.PreviewVideoPan.Visible = True
                        End If
                    ElseIf (num3 = MySettingsProperty.Settings.HtmlIcon) Then
                        If MySettingsProperty.Settings.PreviewHtml Then
                            Me.PreviewHtm.Visible = True
                            Me.PreviewHtm.Navigate(New Uri(Me.ContentView.SelectedItems(0).Name))
                            Me.PreviewHtm.Refresh
                        End If
                    ElseIf (num3 = MySettingsProperty.Settings.TxtIcon) Then
                        If MySettingsProperty.Settings.PreviewText Then
                            Me.PreviewText.Visible = True
                            Dim reader As New StreamReader(Me.ContentView.SelectedItems(0).Name)
                            Dim strArray As String() = New String() { reader.ReadLine, ChrW(13), reader.ReadLine, ChrW(13), reader.ReadLine, ChrW(13), reader.ReadLine }
                            Me.PreviewText.Text = String.Concat(strArray)
                            reader.Close
                        End If
                    ElseIf ((num3 = MySettingsProperty.Settings.ImageIcon) AndAlso MySettingsProperty.Settings.PreviewImages) Then
                        Me.PreviewPicture.Visible = True
                        Me.PreviewPicture.ImageLocation = Me.ContentView.SelectedItems(0).Name
                    End If
                End If
            End If
        End Sub

        Public Function ConvertLength(ByVal Weight As Long) As String
            Dim str As String = "0 KB"
            Dim num5 As Long = Weight
            If (num5 < &H400) Then
                str = (Conversions.ToString(Weight) & " B")
            ElseIf (num5 < &H100000) Then
                Dim str3 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1024)))
                If Not str3.Contains(",") Then
                    str = (str3 & " KB")
                Else
                    Dim startIndex As Short = CShort((str3.LastIndexOf(",") + 4))
                    If (str3.Length < startIndex) Then
                        startIndex = CShort(str3.LastIndexOf(","))
                    End If
                    str = (str3.Remove(startIndex, (str3.Length - startIndex)) & " KB")
                End If
            ElseIf (num5 < &H40000000) Then
                Dim str4 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1048576)))
                If Not str4.Contains(",") Then
                    str = (str4 & " MB")
                Else
                    Dim startIndex As Short = CShort((str4.LastIndexOf(",") + 4))
                    If (str4.Length < startIndex) Then
                        startIndex = CShort(str4.LastIndexOf(","))
                    End If
                    str = (str4.Remove(startIndex, (str4.Length - startIndex)) & " MB")
                End If
            ElseIf (num5 < &H10000000000) Then
                Dim str5 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1073741824)))
                If Not str5.Contains(",") Then
                    str = (str5 & " GB")
                Else
                    Dim startIndex As Short = CShort((str5.LastIndexOf(",") + 4))
                    If (str5.Length < startIndex) Then
                        startIndex = CShort(str5.LastIndexOf(","))
                    End If
                    str = (str5.Remove(startIndex, (str5.Length - startIndex)) & " GB")
                End If
            ElseIf (num5 < &H4000000000000) Then
                Dim str6 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1099511627776)))
                If Not str6.Contains(",") Then
                    str = (str6 & " TB")
                Else
                    Dim startIndex As Short = CShort((str6.LastIndexOf(",") + 4))
                    If (str6.Length < startIndex) Then
                        startIndex = CShort(str6.LastIndexOf(","))
                    End If
                    str = (str6.Remove(startIndex, (str6.Length - startIndex)) & " TB")
                End If
            End If
            Return str
        End Function

        Private Sub CopiatastoD_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Copy
        End Sub

        Private Sub CopiaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Copy
        End Sub

        Public Sub Copy()
            If (Me.ContentView.SelectedItems.Count <> 0) Then
                MyProject.Forms.CopyForm.Set1(Me.ContentView.SelectedItems(0).Name, False)
            End If
        End Sub

        Private Sub CronologiaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.History.Show
        End Sub

        Public Sub Cut()
            If (Me.ContentView.SelectedItems.Count <> 0) Then
                MyProject.Forms.CopyForm.Set1(Me.ContentView.SelectedItems(0).Name, True)
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EliminaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Cancella
        End Sub

        Private Sub EliminaToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Cancella
        End Sub

        Private Sub EliminaToolStripMenuItem1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.Cancella
        End Sub

        Private Sub EsciToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Application.Exit
        End Sub

        Private Sub FavouritesButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Favourites.txt")) Then
                Dim writer2 As New StreamWriter((Application.StartupPath & "\Favourites.txt"), False)
                writer2.Write("1")
                writer2.WriteLine
                writer2.Write((Me.DirectoryText.Text & "|" & Me.Text))
                writer2.Close
                Me.LeftFavouritesList.Items.Add(Me.Text)
            Else
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                reader.Close
                Dim writer As New StreamWriter((Application.StartupPath & "\Favourites.txt"), False)
                writer.Write(CSng((Conversions.ToSingle(reader.ReadLine) + 1!)))
                writer.WriteLine
                writer.Write(reader.ReadToEnd)
                writer.WriteLine
                writer.Write((Me.DirectoryText.Text & "|" & Me.Text))
                writer.Close
                Me.LeftFavouritesList.Items.Add(Me.Text)
            End If
        End Sub

        Private Sub FileRightClick_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.NewFile.LoadInfo(Me.Directory, False)
            MyProject.Forms.NewFile.Show
        End Sub

        Private Sub FileSystemWatcher_Changed(ByVal sender As Object, ByVal e As FileSystemEventArgs)
            Me.Go(Me.FileSystemWatcher.Path, True)
        End Sub

        Private Sub FileSystemWatcher_Renamed(ByVal sender As Object, ByVal e As RenamedEventArgs)
            Me.Go(Me.FileSystemWatcher.Path, True)
        End Sub

        Private Sub FileToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.NewBlankFile
        End Sub

        Private Sub FolderRightClick_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.NewFile.LoadInfo(Me.Directory, True)
            MyProject.Forms.NewFile.Show
        End Sub

        Public Sub Go(ByVal Percorso As String, ByVal Optional History As Boolean = True)
            Me.Interrotto = False
            Me.FileSystemWatcher.EnableRaisingEvents = False
            Me.ContentView.Items.Clear
            Me.StatusLab.Text = "Caricamento in corso..."
            Me.StatusLab.Image = Resources.clock_16
            Me.CaricamentoProg.Value = Conversions.ToInteger("0")
            Me.NumeroFileLab.Text = "0"
            Me.NumeroCartelleLab.Text = "0"
            Me.MessageLab.Visible = False
            Me.Message2Lab.Visible = False
            Me.MessagePict.Visible = False
            Dim str4 As String = Percorso
            If (str4 = "Computer") Then
                Me.DirectoryText.Text = "Computer"
                Me.Directory = "Computer"
                Me.Text = "Computer"
                Me.UnitàLab.Text = "Computer"
                Me.UnitàLab.Image = Resources.computer_16
                Dim count As Byte = CByte(MyProject.Computer.FileSystem.Drives.Count)
                Me.CaricamentoProg.Maximum = count
                Dim num7 As Byte = CByte((count - 1))
                Dim i As Byte = 0
                Do While (i <= num7)
                    Dim item As New ListViewItem
                    item.Name = MyProject.Computer.FileSystem.Drives(i).Name
                    item.Text = MyProject.Computer.FileSystem.Drives(i).Name
                    Dim item2 As New ListViewSubItem
                    Dim item3 As New ListViewSubItem
                    Try 
                        item2.Text = MyProject.Computer.FileSystem.Drives(i).DriveFormat
                        item3.Text = Me.ConvertLength(MyProject.Computer.FileSystem.GetDriveInfo(MyProject.Computer.FileSystem.Drives(i).Name).TotalSize)
                        item2.ForeColor = Color.Gray
                        item3.ForeColor = Color.Gray
                        Select Case MyProject.Computer.FileSystem.Drives(i).DriveType
                            Case DriveType.Unknown
                                item.ImageIndex = MySettingsProperty.Settings.UnknownDriveIcon
                                Exit Select
                            Case DriveType.Removable
                                item.ImageIndex = MySettingsProperty.Settings.USBIcon
                                If (item.Name = "A:\") Then
                                    item.ImageIndex = MySettingsProperty.Settings.FloppyIcon
                                End If
                                If (item.Name = "B:\") Then
                                    item.ImageIndex = MySettingsProperty.Settings.FloppyIcon
                                End If
                                Exit Select
                            Case DriveType.Fixed
                                item.ImageIndex = MySettingsProperty.Settings.HardDiskIcon
                                Exit Select
                            Case DriveType.Network
                                item.ImageIndex = MySettingsProperty.Settings.NetworkIcon
                                Exit Select
                            Case DriveType.CDRom
                                item.ImageIndex = MySettingsProperty.Settings.CDIcon
                                Exit Select
                            Case Else
                                Exit Select
                        End Select
                    Catch exception1 As Exception
                        Dim ex As Exception = exception1
                        ProjectData.SetProjectError(ex)
                        Dim exception As Exception = ex
                        item.ImageIndex = MySettingsProperty.Settings.UnknownDriveIcon
                        ProjectData.ClearProjectError
                    End Try
                    item.SubItems.Add(item2)
                    item.SubItems.Add(item3)
                    Me.ContentView.Items.Add(item)
                    Me.CaricamentoProg.Value += 1
                    i = CByte((i + 1))
                Loop
                Me.StatusLab.Text = "Caricamento completato."
                Me.StatusLab.Image = Resources.ok_32
            ElseIf (str4 = "Error") Then
                Me.MessageLab.Text = "Impossibile trovare il percorso"
                Me.Message2Lab.Text = "Il percorso specificato è errato o inesistente."
                Me.MessagePict.Image = Resources.file_locked
                Me.MessageLab.Visible = True
                Me.Message2Lab.Visible = True
                Me.MessagePict.Visible = True
                Me.StatusLab.Text = "Errore"
                Me.StatusLab.Image = Resources.cancel_16
            ElseIf (str4 = "Documenti") Then
                Me.Go(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments, True)
            ElseIf (str4 = "Desktop") Then
                Me.Go(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, True)
            ElseIf (str4 = "Immagini") Then
                Me.Go(MyProject.Computer.FileSystem.SpecialDirectories.MyPictures, True)
            ElseIf (str4 = "Musica") Then
                Me.Go(MyProject.Computer.FileSystem.SpecialDirectories.MyMusic, True)
            ElseIf (str4 = "Programmi") Then
                Me.Go(MyProject.Computer.FileSystem.SpecialDirectories.ProgramFiles, True)
            Else
                If History Then
                    If Not MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Chronology.txt")) Then
                        Dim writer2 As New StreamWriter((Application.StartupPath & "\Chronology.txt"))
                        writer2.Write("")
                        writer2.Close
                    End If
                    Dim reader As New StreamReader((Application.StartupPath & "\Chronology.txt"))
                    reader.Close
                    Dim writer As New StreamWriter((Application.StartupPath & "\Chronology.txt"), False)
                    writer.Write((Percorso & "|" & Strings.Format(MyProject.Computer.Clock.LocalTime, "dd/MM/yyyy HH:mm")))
                    writer.WriteLine
                    writer.Write(reader.ReadToEnd)
                    writer.Close
                End If
                Me.DirectoryText.Text = Percorso
                Me.Directory = Percorso
                If Not MyProject.Computer.FileSystem.DirectoryExists(Percorso) Then
                    Me.Go("Error", True)
                Else
                    Me.FileSystemWatcher.Path = Percorso
                    Me.FileSystemWatcher.EnableRaisingEvents = True
                    Me.CaricamentoProg.Maximum = MyProject.Computer.FileSystem.GetFiles(Percorso).Count
                    Me.Text = MyProject.Computer.FileSystem.GetDirectoryInfo(Percorso).Name
                    Me.UnitàLab.Text = (Percorso.Remove(2, (Percorso.Length - 2)) & " (" & MyProject.Computer.FileSystem.GetDriveInfo(Percorso.Remove(2, (Percorso.Length - 2))).DriveFormat & ")")
                    Select Case MyProject.Computer.FileSystem.GetDriveInfo(Percorso.Remove(2, (Percorso.Length - 2))).DriveType
                        Case DriveType.Removable
                            Me.UnitàLab.Image = Resources.usb_16
                            Exit Select
                        Case DriveType.Fixed
                            Me.UnitàLab.Image = Resources.hd_blu_16
                            Exit Select
                        Case DriveType.CDRom
                            Me.UnitàLab.Image = Resources.cd_16
                            Exit Select
                        Case Else
                            Exit Select
                    End Select
                    Dim num8 As Long = (MyProject.Computer.FileSystem.GetDirectories(Percorso).Count - 1)
                    Dim i As Long = 0
                    Do While (i <= num8)
                        If Me.Interrotto Then
                            Me.StatusLab.Text = "Caricamento interrotto"
                            Me.StatusLab.Image = Resources.cancel_16
                            Return
                        End If
                        Dim item4 As New ListViewItem
                        item4.Text = MyProject.Computer.FileSystem.GetDirectories(Percorso)(CInt(i)).Remove(0, (MyProject.Computer.FileSystem.GetDirectories(Percorso)(CInt(i)).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                        item4.Name = MyProject.Computer.FileSystem.GetDirectories(Percorso)(CInt(i))
                        item4.ImageIndex = MySettingsProperty.Settings.FolderIcon
                        Me.ContentView.Items.Add(item4)
                        Me.NumeroCartelleLab.Text = Conversions.ToString(CDbl((Conversions.ToDouble(Me.NumeroCartelleLab.Text) + 1)))
                        i = (i + 1)
                    Loop
                    Dim num9 As Long = (MyProject.Computer.FileSystem.GetFiles(Percorso).Count - 1)
                    Dim j As Long = 0
                    Do While (j <= num9)
                        Dim str2 As String
                        If Me.Interrotto Then
                            Me.StatusLab.Text = "Caricamento interrotto"
                            Me.StatusLab.Image = Resources.cancel_16
                            Return
                        End If
                        Dim item5 As New ListViewItem
                        Dim item As New ListViewSubItem
                        Dim item7 As New ListViewSubItem
                        item5.Name = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).FullName
                        item.ForeColor = Color.Gray
                        item7.ForeColor = Color.Gray
                        item.Text = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Extension
                        Dim length As Short = CShort(MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Name.Length)
                        Dim name As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Name
                        Dim startIndex As Short = CShort(MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Name.LastIndexOfAny(Conversions.ToCharArrayRankOne(".")))
                        If (startIndex >= 1) Then
                            str2 = name.Remove(startIndex, CShort((length - startIndex)))
                        Else
                            str2 = name
                            item.Text = ""
                        End If
                        item5.Text = str2
                        item5.ImageIndex = MySettingsProperty.Settings.UnkonwnFileIcon
                        Dim extension As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Extension
                        If (extension = ".exe") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ExeIcon
                        ElseIf (extension = ".EXE") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ExeIcon
                        ElseIf (extension = ".bat") Then
                            item5.ImageIndex = MySettingsProperty.Settings.BatIcon
                        ElseIf (extension = ".BAT") Then
                            item5.ImageIndex = MySettingsProperty.Settings.BatIcon
                        ElseIf (extension = ".cab") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".CAB") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".gzip") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".GZIP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".rar") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".RAR") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".tar") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".TAR") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".zip") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".ZIP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ArchiveIcon
                        ElseIf (extension = ".aac") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".AAC") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".aiff") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".AIFF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".wmf") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".WMF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".ico") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".ICO") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".ape") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".APE") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".flac") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".FLAC") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".mid") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".MID") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".midi") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".MIDI") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".kar") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".KAR") Then
                            item5.ImageIndex = MySettingsProperty.Settings.MidiIcon
                        ElseIf (extension = ".mp3") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".MP3") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".mpc") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".MPC") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".ogg") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".OGG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".wav") Then
                            item5.ImageIndex = MySettingsProperty.Settings.WavIcon
                        ElseIf (extension = ".WAV") Then
                            item5.ImageIndex = MySettingsProperty.Settings.WavIcon
                        ElseIf (extension = ".wave") Then
                            item5.ImageIndex = MySettingsProperty.Settings.WavIcon
                        ElseIf (extension = ".WAVE") Then
                            item5.ImageIndex = MySettingsProperty.Settings.WavIcon
                        ElseIf (extension = ".wma") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".WMA") Then
                            item5.ImageIndex = MySettingsProperty.Settings.SoundIcon
                        ElseIf (extension = ".doc") Then
                            item5.ImageIndex = MySettingsProperty.Settings.DocIcon
                        ElseIf (extension = ".DOC") Then
                            item5.ImageIndex = MySettingsProperty.Settings.DocIcon
                        ElseIf (extension = ".docx") Then
                            item5.ImageIndex = MySettingsProperty.Settings.DocIcon
                        ElseIf (extension = ".DOCX") Then
                            item5.ImageIndex = MySettingsProperty.Settings.DocIcon
                        ElseIf (extension = ".html") Then
                            item5.ImageIndex = MySettingsProperty.Settings.HtmlIcon
                        ElseIf (extension = ".HTML") Then
                            item5.ImageIndex = MySettingsProperty.Settings.HtmlIcon
                        ElseIf (extension = ".htm") Then
                            item5.ImageIndex = MySettingsProperty.Settings.HtmlIcon
                        ElseIf (extension = ".HTM") Then
                            item5.ImageIndex = MySettingsProperty.Settings.HtmlIcon
                        ElseIf (extension = ".PHP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.PhpIcon
                        ElseIf (extension = ".php") Then
                            item5.ImageIndex = MySettingsProperty.Settings.PhpIcon
                        ElseIf (extension = ".CSS") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CssIcon
                        ElseIf (extension = ".css") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CssIcon
                        ElseIf (extension = ".js") Then
                            item5.ImageIndex = MySettingsProperty.Settings.JavaIcon
                        ElseIf (extension = ".JS") Then
                            item5.ImageIndex = MySettingsProperty.Settings.JavaIcon
                        ElseIf (extension = ".cpp") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CppIcon
                        ElseIf (extension = ".CPP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CppIcon
                        ElseIf (extension = ".C") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CIcon
                        ElseIf (extension = ".c") Then
                            item5.ImageIndex = MySettingsProperty.Settings.CIcon
                        ElseIf (extension = ".pdf") Then
                            item5.ImageIndex = MySettingsProperty.Settings.PdfIcon
                        ElseIf (extension = ".PDF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.PdfIcon
                        ElseIf (extension = ".rtf") Then
                            item5.ImageIndex = MySettingsProperty.Settings.RtfIcon
                        ElseIf (extension = ".RTF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.RtfIcon
                        ElseIf (extension = ".txt") Then
                            item5.ImageIndex = MySettingsProperty.Settings.TxtIcon
                        ElseIf (extension = ".TXT") Then
                            item5.ImageIndex = MySettingsProperty.Settings.TxtIcon
                        ElseIf (extension = ".ini") Then
                            item5.ImageIndex = MySettingsProperty.Settings.TxtIcon
                        ElseIf (extension = ".INI") Then
                            item5.ImageIndex = MySettingsProperty.Settings.TxtIcon
                        ElseIf (extension = ".wpd") Then
                            item5.ImageIndex = MySettingsProperty.Settings.RtfIcon
                        ElseIf (extension = ".WPD") Then
                            item5.ImageIndex = MySettingsProperty.Settings.RtfIcon
                        ElseIf (extension = ".xhtml") Then
                            item5.ImageIndex = &H18
                        ElseIf (extension = ".XHTML") Then
                            item5.ImageIndex = &H18
                        ElseIf (extension = ".bmp") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".BMP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".gif") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".GIF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".jpg") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".JPG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".jpeg") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".JPEG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".png") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".PNG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".psd") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".PSD") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".tga") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".TGA") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".tiff") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".TIFF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.ImageIcon
                        ElseIf (extension = ".asp") Then
                            item5.ImageIndex = &H20
                        ElseIf (extension = ".ASP") Then
                            item5.ImageIndex = &H20
                        ElseIf (extension = ".cgi") Then
                            item5.ImageIndex = &H21
                        ElseIf (extension = ".CGI") Then
                            item5.ImageIndex = &H21
                        ElseIf (extension = ".css") Then
                            item5.ImageIndex = &H22
                        ElseIf (extension = ".CSS") Then
                            item5.ImageIndex = &H22
                        ElseIf (extension = ".js") Then
                            item5.ImageIndex = &H23
                        ElseIf (extension = ".JS") Then
                            item5.ImageIndex = &H23
                        ElseIf (extension = ".php") Then
                            item5.ImageIndex = &H24
                        ElseIf (extension = ".PHP") Then
                            item5.ImageIndex = &H24
                        ElseIf (extension = ".pl") Then
                            item5.ImageIndex = &H25
                        ElseIf (extension = ".PL") Then
                            item5.ImageIndex = &H25
                        ElseIf (extension = ".xml") Then
                            item5.ImageIndex = &H26
                        ElseIf (extension = ".XML") Then
                            item5.ImageIndex = &H26
                        ElseIf (extension = ".3gp") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".3GP") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".asf") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".ASF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".avi") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".AVI") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".mov") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".MOV") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".mp4") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".MP4") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".mpeg4") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".MPEG4") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".mpg") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".MPG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".MPEG") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".mpeg") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".rm") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".RM") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".swf") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".SWF") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".wmv") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".WMV") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".vob") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".VOB") Then
                            item5.ImageIndex = MySettingsProperty.Settings.VideoIcon
                        ElseIf (extension = ".lnk") Then
                            item5.ImageIndex = MySettingsProperty.Settings.LinkIcon
                        ElseIf (extension = ".LNK") Then
                            item5.ImageIndex = MySettingsProperty.Settings.LinkIcon
                        End If
                        item7.Text = Me.ConvertLength(MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Percorso)(CInt(j))).Length)
                        item5.SubItems.Add(item)
                        item5.SubItems.Add(item7)
                        Me.ContentView.Items.Add(item5)
                        Me.NumeroFileLab.Text = Conversions.ToString(CDbl((Conversions.ToDouble(Me.NumeroFileLab.Text) + 1)))
                        Me.CaricamentoProg.Value += 1
                        Me.StatusLab.Text = "Caricamento completato."
                        Me.StatusLab.Image = Resources.ok_32
                        j = (j + 1)
                    Loop
                End If
            End If
        End Sub

        Private Sub HomeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(MySettingsProperty.Settings.Home, True)
        End Sub

        Private Sub ImportaEsportaImpostazioniToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.IOSettings.Show
        End Sub

        Private Sub IncollaTastoD_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Paste
        End Sub

        Private Sub IncollaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Paste
        End Sub

        Private Sub InformazioniSuPowerExplorerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.About.Show
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Main))
            Me.BottomToolStripPanel = New ToolStripPanel
            Me.TopToolStripPanel = New ToolStripPanel
            Me.RightToolStripPanel = New ToolStripPanel
            Me.LeftToolStripPanel = New ToolStripPanel
            Me.ContentPanel = New ToolStripContentPanel
            Me.MainStrip = New ToolStrip
            Me.ToolStripSplitButton2 = New ToolStripSplitButton
            Me.OneToolStripMenuItem = New ToolStripMenuItem
            Me.TwoToolStripMenuItem = New ToolStripMenuItem
            Me.ThreeToolStripMenuItem = New ToolStripMenuItem
            Me.FourToolStripMenuItem = New ToolStripMenuItem
            Me.FiveToolStripMenuItem = New ToolStripMenuItem
            Me.SixToolStripMenuItem = New ToolStripMenuItem
            Me.SevenToolStripMenuItem = New ToolStripMenuItem
            Me.EightToolStripMenuItem = New ToolStripMenuItem
            Me.NineToolStripMenuItem = New ToolStripMenuItem
            Me.TenToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripButton1 = New ToolStripButton
            Me.ToolStripButton4 = New ToolStripButton
            Me.DirectoryText = New ToolStripTextBox
            Me.ToolStripSplitButton1 = New ToolStripSplitButton
            Me.InQuestaCartellaToolStripMenuItem = New ToolStripMenuItem
            Me.InQuestaCartellaESottocartelleToolStripMenuItem = New ToolStripMenuItem
            Me.OvunqueToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripTextBox1 = New ToolStripTextBox
            Me.ToolStripButton2 = New ToolStripButton
            Me.StopButt = New ToolStripButton
            Me.MainMenu = New MenuStrip
            Me.FileToolStripMenuItem1 = New ToolStripMenuItem
            Me.EliminaToolStripMenuItem1 = New ToolStripMenuItem
            Me.EsciToolStripMenuItem1 = New ToolStripMenuItem
            Me.ModificaToolStripMenuItem = New ToolStripMenuItem
            Me.CopiaToolStripMenuItem = New ToolStripMenuItem
            Me.TagliaToolStripMenuItem = New ToolStripMenuItem
            Me.IncollaToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem5 = New ToolStripSeparator
            Me.SelezionaTuttoToolStripMenuItem = New ToolStripMenuItem
            Me.NavigazioneToolStripMenuItem = New ToolStripMenuItem
            Me.LivelloSuperioreToolStripMenuItem = New ToolStripMenuItem
            Me.HomeToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem7 = New ToolStripSeparator
            Me.AggiornaToolStripMenuItem = New ToolStripMenuItem
            Me.AnnullaCaricamentoToolStripMenuItem = New ToolStripMenuItem
            Me.StrumentiToolStripMenuItem = New ToolStripMenuItem
            Me.OpzioniToolStripMenuItem = New ToolStripMenuItem
            Me.ImportaEsportaImpostazioniToolStripMenuItem = New ToolStripMenuItem
            Me.CronologiaToolStripMenuItem = New ToolStripMenuItem
            Me.PreferitiToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem9 = New ToolStripMenuItem
            Me.CercaToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem1 = New ToolStripMenuItem
            Me.SitoWebUfficialeToolStripMenuItem = New ToolStripMenuItem
            Me.CercaAggiornamentiToolStripMenuItem = New ToolStripMenuItem
            Me.InformazioniSuPowerExplorerToolStripMenuItem = New ToolStripMenuItem
            Me.LeftLinkList = New ListBox
            Me.LeftImgList = New ImageList(Me.components)
            Me.LeftFavouritesList = New ListBox
            Me.LeftRightClick = New ContextMenuStrip(Me.components)
            Me.OrganizzaPreferitiToolStripMenuItem = New ToolStripMenuItem
            Me.ContentView = New ListView
            Me.ColumnHeader1 = New ColumnHeader
            Me.ColumnHeader2 = New ColumnHeader
            Me.ColumnHeader3 = New ColumnHeader
            Me.ContentRightClick = New ContextMenuStrip(Me.components)
            Me.OpenRightClick = New ToolStripMenuItem
            Me.OpenWithRightClick = New ToolStripMenuItem
            Me.NewRightClick = New ToolStripMenuItem
            Me.FolderRightClick = New ToolStripMenuItem
            Me.SeparatoreTastoD = New ToolStripSeparator
            Me.FileRightClick = New ToolStripMenuItem
            Me.RightDiv1 = New ToolStripSeparator
            Me.AntivirRightClick = New ToolStripMenuItem
            Me.CompressRightClick = New ToolStripMenuItem
            Me.DecompressRightClick = New ToolStripMenuItem
            Me.DecompressSubFolderRightClick = New ToolStripMenuItem
            Me.RightDiv2 = New ToolStripSeparator
            Me.CopyRightClick = New ToolStripMenuItem
            Me.CutRightClick = New ToolStripMenuItem
            Me.PasteRightClick = New ToolStripMenuItem
            Me.RightDiv3 = New ToolStripSeparator
            Me.RenameRightClick = New ToolStripMenuItem
            Me.DeleteRightClick = New ToolStripMenuItem
            Me.PropertiesRightClick = New ToolStripMenuItem
            Me.ContentImgList = New ImageList(Me.components)
            Me.MainStatus = New StatusStrip
            Me.StatusLab = New ToolStripStatusLabel
            Me.Separatore1Lab = New ToolStripStatusLabel
            Me.DimensioniLab = New ToolStripStatusLabel
            Me.Separatore2Lab = New ToolStripStatusLabel
            Me.NumeroFileLab = New ToolStripStatusLabel
            Me.NumeroCartelleLab = New ToolStripStatusLabel
            Me.Separatore3Lab = New ToolStripStatusLabel
            Me.UnitàLab = New ToolStripStatusLabel
            Me.CaricamentoProg = New ToolStripProgressBar
            Me.PreviewText = New TextBox
            Me.AnteprimaGroup = New GroupBox
            Me.PreviewVideoPan = New SplitContainer
            Me.PreviewDisplayPan = New Panel
            Me.AnteprimaVidStopButt = New Button
            Me.AnteprimaVidPlayButt = New Button
            Me.PreviewHtm = New WebBrowser
            Me.PreviewPicture = New PictureBox
            Me.PreviewAudioPan = New Panel
            Me.Label1 = New Label
            Me.AnteprimaStopBut = New Button
            Me.AnteprimaPlayBut = New Button
            Me.FileSystemWatcher = New FileSystemWatcher
            Me.MainTimer = New Timer(Me.components)
            Me.MessageLab = New Label
            Me.Message2Lab = New Label
            Me.OpenWithDial = New OpenFileDialog
            Me.MessagePict = New PictureBox
            Me.FavouritesButt = New Button
            Me.StatoButt = New Button
            Me.MainStrip.SuspendLayout
            Me.MainMenu.SuspendLayout
            Me.LeftRightClick.SuspendLayout
            Me.ContentRightClick.SuspendLayout
            Me.MainStatus.SuspendLayout
            Me.AnteprimaGroup.SuspendLayout
            Me.PreviewVideoPan.Panel1.SuspendLayout
            Me.PreviewVideoPan.Panel2.SuspendLayout
            Me.PreviewVideoPan.SuspendLayout
            DirectCast(Me.PreviewPicture, ISupportInitialize).BeginInit
            Me.PreviewAudioPan.SuspendLayout
            Me.FileSystemWatcher.BeginInit
            DirectCast(Me.MessagePict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Dim point As New Point(0, 0)
            Me.BottomToolStripPanel.Location = point
            Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
            Me.BottomToolStripPanel.Orientation = Orientation.Horizontal
            Dim padding As New Padding(3, 0, 0, 0)
            Me.BottomToolStripPanel.RowMargin = padding
            Dim size As New Size(0, 0)
            Me.BottomToolStripPanel.Size = size
            point = New Point(0, 0)
            Me.TopToolStripPanel.Location = point
            Me.TopToolStripPanel.Name = "TopToolStripPanel"
            Me.TopToolStripPanel.Orientation = Orientation.Horizontal
            padding = New Padding(3, 0, 0, 0)
            Me.TopToolStripPanel.RowMargin = padding
            size = New Size(0, 0)
            Me.TopToolStripPanel.Size = size
            point = New Point(0, 0)
            Me.RightToolStripPanel.Location = point
            Me.RightToolStripPanel.Name = "RightToolStripPanel"
            Me.RightToolStripPanel.Orientation = Orientation.Horizontal
            padding = New Padding(3, 0, 0, 0)
            Me.RightToolStripPanel.RowMargin = padding
            size = New Size(0, 0)
            Me.RightToolStripPanel.Size = size
            point = New Point(0, 0)
            Me.LeftToolStripPanel.Location = point
            Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
            Me.LeftToolStripPanel.Orientation = Orientation.Horizontal
            padding = New Padding(3, 0, 0, 0)
            Me.LeftToolStripPanel.RowMargin = padding
            size = New Size(0, 0)
            Me.LeftToolStripPanel.Size = size
            size = New Size(&H2A1, &H1B7)
            Me.ContentPanel.Size = size
            Me.MainStrip.GripStyle = ToolStripGripStyle.Hidden
            size = New Size(&H18, &H18)
            Me.MainStrip.ImageScalingSize = size
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.ToolStripSplitButton2, Me.ToolStripButton1, Me.ToolStripButton4, Me.DirectoryText, Me.ToolStripSplitButton1, Me.ToolStripTextBox1, Me.ToolStripButton2, Me.StopButt }
            Me.MainStrip.Items.AddRange(toolStripItems)
            point = New Point(0, &H18)
            Me.MainStrip.Location = point
            Me.MainStrip.Name = "MainStrip"
            Me.MainStrip.RenderMode = ToolStripRenderMode.System
            size = New Size(&H318, &H1F)
            Me.MainStrip.Size = size
            Me.MainStrip.TabIndex = 14
            Me.MainStrip.Text = "ToolStrip1"
            Me.ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
            toolStripItems = New ToolStripItem() { Me.OneToolStripMenuItem, Me.TwoToolStripMenuItem, Me.ThreeToolStripMenuItem, Me.FourToolStripMenuItem, Me.FiveToolStripMenuItem, Me.SixToolStripMenuItem, Me.SevenToolStripMenuItem, Me.EightToolStripMenuItem, Me.NineToolStripMenuItem }
            toolStripItems(9) = Me.TenToolStripMenuItem
            Me.ToolStripSplitButton2.DropDownItems.AddRange(toolStripItems)
            Me.ToolStripSplitButton2.Image = DirectCast(manager.GetObject("ToolStripSplitButton2.Image"), Image)
            Me.ToolStripSplitButton2.ImageTransparentColor = Color.Magenta
            Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
            size = New Size(40, &H1C)
            Me.ToolStripSplitButton2.Size = size
            Me.ToolStripSplitButton2.Text = "Indietro"
            Me.OneToolStripMenuItem.Name = "OneToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.OneToolStripMenuItem.Size = size
            Me.OneToolStripMenuItem.Text = "One"
            Me.TwoToolStripMenuItem.Name = "TwoToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.TwoToolStripMenuItem.Size = size
            Me.TwoToolStripMenuItem.Text = "Two"
            Me.ThreeToolStripMenuItem.Name = "ThreeToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.ThreeToolStripMenuItem.Size = size
            Me.ThreeToolStripMenuItem.Text = "Three"
            Me.FourToolStripMenuItem.Name = "FourToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.FourToolStripMenuItem.Size = size
            Me.FourToolStripMenuItem.Text = "Four"
            Me.FiveToolStripMenuItem.Name = "FiveToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.FiveToolStripMenuItem.Size = size
            Me.FiveToolStripMenuItem.Text = "Five"
            Me.SixToolStripMenuItem.Name = "SixToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.SixToolStripMenuItem.Size = size
            Me.SixToolStripMenuItem.Text = "Six"
            Me.SevenToolStripMenuItem.Name = "SevenToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.SevenToolStripMenuItem.Size = size
            Me.SevenToolStripMenuItem.Text = "Seven"
            Me.EightToolStripMenuItem.Name = "EightToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.EightToolStripMenuItem.Size = size
            Me.EightToolStripMenuItem.Text = "Eight"
            Me.NineToolStripMenuItem.Name = "NineToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.NineToolStripMenuItem.Size = size
            Me.NineToolStripMenuItem.Text = "Nine"
            Me.TenToolStripMenuItem.Name = "TenToolStripMenuItem"
            size = New Size(&H73, &H16)
            Me.TenToolStripMenuItem.Size = size
            Me.TenToolStripMenuItem.Text = "Ten"
            Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Image = Resources.up_32
            Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton1.Size = size
            Me.ToolStripButton1.Text = "Livello superiore"
            Me.ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton4.Image = Resources.home_32
            Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton4.Name = "ToolStripButton4"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton4.Size = size
            Me.ToolStripButton4.Text = "Home"
            Me.DirectoryText.Name = "DirectoryText"
            size = New Size(400, &H1F)
            Me.DirectoryText.Size = size
            Me.ToolStripSplitButton1.Alignment = ToolStripItemAlignment.Right
            Me.ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
            toolStripItems = New ToolStripItem() { Me.InQuestaCartellaToolStripMenuItem, Me.InQuestaCartellaESottocartelleToolStripMenuItem, Me.OvunqueToolStripMenuItem }
            Me.ToolStripSplitButton1.DropDownItems.AddRange(toolStripItems)
            Me.ToolStripSplitButton1.Image = Resources.search_32
            Me.ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
            Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
            size = New Size(40, &H1C)
            Me.ToolStripSplitButton1.Size = size
            Me.ToolStripSplitButton1.Text = "Cerca"
            Me.InQuestaCartellaToolStripMenuItem.Checked = True
            Me.InQuestaCartellaToolStripMenuItem.CheckState = CheckState.Checked
            Me.InQuestaCartellaToolStripMenuItem.Name = "InQuestaCartellaToolStripMenuItem"
            size = New Size(&H10A, &H16)
            Me.InQuestaCartellaToolStripMenuItem.Size = size
            Me.InQuestaCartellaToolStripMenuItem.Text = "In questa &cartella"
            Me.InQuestaCartellaESottocartelleToolStripMenuItem.Name = "InQuestaCartellaESottocartelleToolStripMenuItem"
            size = New Size(&H10A, &H16)
            Me.InQuestaCartellaESottocartelleToolStripMenuItem.Size = size
            Me.InQuestaCartellaESottocartelleToolStripMenuItem.Text = "In questa cartella e nelle &sottocartelle"
            Me.OvunqueToolStripMenuItem.Name = "OvunqueToolStripMenuItem"
            size = New Size(&H10A, &H16)
            Me.OvunqueToolStripMenuItem.Size = size
            Me.OvunqueToolStripMenuItem.Text = "&Ovunque"
            Me.ToolStripTextBox1.Alignment = ToolStripItemAlignment.Right
            Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
            size = New Size(100, &H1F)
            Me.ToolStripTextBox1.Size = size
            Me.ToolStripTextBox1.Text = "Cerca"
            Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton2.Image = Resources.play_32
            Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton2.Size = size
            Me.ToolStripButton2.Text = "Aggiorna"
            Me.StopButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.StopButt.Image = Resources.stop_32
            Me.StopButt.ImageTransparentColor = Color.Magenta
            Me.StopButt.Name = "StopButt"
            size = New Size(&H1C, &H1C)
            Me.StopButt.Size = size
            Me.StopButt.Text = "Annulla caricamento"
            size = New Size(&H18, &H18)
            Me.MainMenu.ImageScalingSize = size
            toolStripItems = New ToolStripItem() { Me.FileToolStripMenuItem1, Me.ModificaToolStripMenuItem, Me.NavigazioneToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.ToolStripMenuItem1 }
            Me.MainMenu.Items.AddRange(toolStripItems)
            point = New Point(0, 0)
            Me.MainMenu.Location = point
            Me.MainMenu.Name = "MainMenu"
            Me.MainMenu.RenderMode = ToolStripRenderMode.System
            size = New Size(&H318, &H18)
            Me.MainMenu.Size = size
            Me.MainMenu.TabIndex = 15
            toolStripItems = New ToolStripItem() { Me.EliminaToolStripMenuItem1, Me.EsciToolStripMenuItem1 }
            Me.FileToolStripMenuItem1.DropDownItems.AddRange(toolStripItems)
            Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
            size = New Size(&H23, 20)
            Me.FileToolStripMenuItem1.Size = size
            Me.FileToolStripMenuItem1.Text = "&File"
            Me.EliminaToolStripMenuItem1.Name = "EliminaToolStripMenuItem1"
            Me.EliminaToolStripMenuItem1.ShortcutKeys = Keys.Delete
            size = New Size(&H98, &H16)
            Me.EliminaToolStripMenuItem1.Size = size
            Me.EliminaToolStripMenuItem1.Text = "Elimina"
            Me.EliminaToolStripMenuItem1.Visible = False
            Me.EsciToolStripMenuItem1.Image = Resources.exit_32
            Me.EsciToolStripMenuItem1.Name = "EsciToolStripMenuItem1"
            size = New Size(&H98, &H16)
            Me.EsciToolStripMenuItem1.Size = size
            Me.EsciToolStripMenuItem1.Text = "&Esci"
            toolStripItems = New ToolStripItem() { Me.CopiaToolStripMenuItem, Me.TagliaToolStripMenuItem, Me.IncollaToolStripMenuItem, Me.ToolStripMenuItem5, Me.SelezionaTuttoToolStripMenuItem }
            Me.ModificaToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
            size = New Size(&H3A, 20)
            Me.ModificaToolStripMenuItem.Size = size
            Me.ModificaToolStripMenuItem.Text = "&Modifica"
            Me.CopiaToolStripMenuItem.Image = Resources.copy_32
            Me.CopiaToolStripMenuItem.Name = "CopiaToolStripMenuItem"
            Me.CopiaToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.C)
            size = New Size(&HCC, &H16)
            Me.CopiaToolStripMenuItem.Size = size
            Me.CopiaToolStripMenuItem.Text = "&Copia"
            Me.TagliaToolStripMenuItem.Image = Resources.cut_32
            Me.TagliaToolStripMenuItem.Name = "TagliaToolStripMenuItem"
            Me.TagliaToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.X)
            size = New Size(&HCC, &H16)
            Me.TagliaToolStripMenuItem.Size = size
            Me.TagliaToolStripMenuItem.Text = "&Taglia"
            Me.IncollaToolStripMenuItem.Image = Resources.paste_48
            Me.IncollaToolStripMenuItem.Name = "IncollaToolStripMenuItem"
            Me.IncollaToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.V)
            size = New Size(&HCC, &H16)
            Me.IncollaToolStripMenuItem.Size = size
            Me.IncollaToolStripMenuItem.Text = "&Incolla"
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            size = New Size(&HC9, 6)
            Me.ToolStripMenuItem5.Size = size
            Me.SelezionaTuttoToolStripMenuItem.Name = "SelezionaTuttoToolStripMenuItem"
            Me.SelezionaTuttoToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.A)
            size = New Size(&HCC, &H16)
            Me.SelezionaTuttoToolStripMenuItem.Size = size
            Me.SelezionaTuttoToolStripMenuItem.Text = "&Seleziona tutto"
            toolStripItems = New ToolStripItem() { Me.LivelloSuperioreToolStripMenuItem, Me.HomeToolStripMenuItem, Me.ToolStripMenuItem7, Me.AggiornaToolStripMenuItem, Me.AnnullaCaricamentoToolStripMenuItem }
            Me.NavigazioneToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.NavigazioneToolStripMenuItem.Name = "NavigazioneToolStripMenuItem"
            size = New Size(&H4D, 20)
            Me.NavigazioneToolStripMenuItem.Size = size
            Me.NavigazioneToolStripMenuItem.Text = "&Navigazione"
            Me.LivelloSuperioreToolStripMenuItem.Image = Resources.up_32
            Me.LivelloSuperioreToolStripMenuItem.Name = "LivelloSuperioreToolStripMenuItem"
            size = New Size(&HB5, &H16)
            Me.LivelloSuperioreToolStripMenuItem.Size = size
            Me.LivelloSuperioreToolStripMenuItem.Text = "&Livello superiore"
            Me.HomeToolStripMenuItem.Image = Resources.home_32
            Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
            size = New Size(&HB5, &H16)
            Me.HomeToolStripMenuItem.Size = size
            Me.HomeToolStripMenuItem.Text = "&Home"
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            size = New Size(&HB2, 6)
            Me.ToolStripMenuItem7.Size = size
            Me.AggiornaToolStripMenuItem.Image = Resources.play_32
            Me.AggiornaToolStripMenuItem.Name = "AggiornaToolStripMenuItem"
            Me.AggiornaToolStripMenuItem.ShortcutKeys = Keys.F5
            size = New Size(&HB5, &H16)
            Me.AggiornaToolStripMenuItem.Size = size
            Me.AggiornaToolStripMenuItem.Text = "&Aggiorna"
            Me.AnnullaCaricamentoToolStripMenuItem.Image = Resources.stop_32
            Me.AnnullaCaricamentoToolStripMenuItem.Name = "AnnullaCaricamentoToolStripMenuItem"
            size = New Size(&HB5, &H16)
            Me.AnnullaCaricamentoToolStripMenuItem.Size = size
            Me.AnnullaCaricamentoToolStripMenuItem.Text = "A&nnulla caricamento"
            toolStripItems = New ToolStripItem() { Me.OpzioniToolStripMenuItem, Me.ImportaEsportaImpostazioniToolStripMenuItem, Me.CronologiaToolStripMenuItem, Me.PreferitiToolStripMenuItem, Me.ToolStripMenuItem9, Me.CercaToolStripMenuItem }
            Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
            size = New Size(&H41, 20)
            Me.StrumentiToolStripMenuItem.Size = size
            Me.StrumentiToolStripMenuItem.Text = "&Strumenti"
            Me.OpzioniToolStripMenuItem.Image = Resources.configure
            Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
            size = New Size(&HEF, 30)
            Me.OpzioniToolStripMenuItem.Size = size
            Me.OpzioniToolStripMenuItem.Text = "&Opzioni"
            Me.ImportaEsportaImpostazioniToolStripMenuItem.Image = Resources.redo
            Me.ImportaEsportaImpostazioniToolStripMenuItem.Name = "ImportaEsportaImpostazioniToolStripMenuItem"
            size = New Size(&HEF, 30)
            Me.ImportaEsportaImpostazioniToolStripMenuItem.Size = size
            Me.ImportaEsportaImpostazioniToolStripMenuItem.Text = "&Importa / Esporta impostazioni"
            Me.CronologiaToolStripMenuItem.Image = Resources.history_32
            Me.CronologiaToolStripMenuItem.Name = "CronologiaToolStripMenuItem"
            size = New Size(&HEF, 30)
            Me.CronologiaToolStripMenuItem.Size = size
            Me.CronologiaToolStripMenuItem.Text = "&Cronologia"
            Me.PreferitiToolStripMenuItem.Image = Resources.favourites_32
            Me.PreferitiToolStripMenuItem.Name = "PreferitiToolStripMenuItem"
            Me.PreferitiToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.B)
            size = New Size(&HEF, 30)
            Me.PreferitiToolStripMenuItem.Size = size
            Me.PreferitiToolStripMenuItem.Text = "&Preferiti"
            Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
            size = New Size(&HEF, 30)
            Me.ToolStripMenuItem9.Size = size
            Me.ToolStripMenuItem9.Text = "&Utilità di lavoro multifile"
            Me.CercaToolStripMenuItem.Image = Resources.search_32
            Me.CercaToolStripMenuItem.Name = "CercaToolStripMenuItem"
            Me.CercaToolStripMenuItem.ShortcutKeys = (Keys.Control Or Keys.F)
            size = New Size(&HEF, 30)
            Me.CercaToolStripMenuItem.Size = size
            Me.CercaToolStripMenuItem.Text = "C&erca"
            toolStripItems = New ToolStripItem() { Me.SitoWebUfficialeToolStripMenuItem, Me.CercaAggiornamentiToolStripMenuItem, Me.InformazioniSuPowerExplorerToolStripMenuItem }
            Me.ToolStripMenuItem1.DropDownItems.AddRange(toolStripItems)
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            size = New Size(&H18, 20)
            Me.ToolStripMenuItem1.Size = size
            Me.ToolStripMenuItem1.Text = "&?"
            Me.SitoWebUfficialeToolStripMenuItem.Image = Resources.www_32
            Me.SitoWebUfficialeToolStripMenuItem.Name = "SitoWebUfficialeToolStripMenuItem"
            size = New Size(&HF2, 30)
            Me.SitoWebUfficialeToolStripMenuItem.Size = size
            Me.SitoWebUfficialeToolStripMenuItem.Text = "&Sito web ufficiale"
            Me.CercaAggiornamentiToolStripMenuItem.Image = Resources.download_128
            Me.CercaAggiornamentiToolStripMenuItem.Name = "CercaAggiornamentiToolStripMenuItem"
            size = New Size(&HF2, 30)
            Me.CercaAggiornamentiToolStripMenuItem.Size = size
            Me.CercaAggiornamentiToolStripMenuItem.Text = "&Cerca aggiornamenti"
            Me.InformazioniSuPowerExplorerToolStripMenuItem.Image = Resources.info_48
            Me.InformazioniSuPowerExplorerToolStripMenuItem.Name = "InformazioniSuPowerExplorerToolStripMenuItem"
            size = New Size(&HF2, 30)
            Me.InformazioniSuPowerExplorerToolStripMenuItem.Size = size
            Me.InformazioniSuPowerExplorerToolStripMenuItem.Text = "&Informazioni su Power Explorer"
            Me.LeftLinkList.Anchor = (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top))
            Me.LeftLinkList.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.LeftLinkList.FormattingEnabled = True
            Me.LeftLinkList.ItemHeight = &H10
            Dim items As Object() = New Object() { "Computer", "Desktop", "Documenti", "Immagini", "Musica", "Programmi" }
            Me.LeftLinkList.Items.AddRange(items)
            point = New Point(12, &H57)
            Me.LeftLinkList.Location = point
            Me.LeftLinkList.Name = "LeftLinkList"
            size = New Size(120, 260)
            Me.LeftLinkList.Size = size
            Me.LeftLinkList.Sorted = True
            Me.LeftLinkList.TabIndex = &H15
            Me.LeftLinkList.Visible = False
            Me.LeftImgList.ImageStream = DirectCast(manager.GetObject("LeftImgList.ImageStream"), ImageListStreamer)
            Me.LeftImgList.TransparentColor = Color.Transparent
            Me.LeftImgList.Images.SetKeyName(0, "folder_yellow.png")
            Me.LeftImgList.Images.SetKeyName(1, "services.png")
            Me.LeftFavouritesList.Anchor = (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top))
            Me.LeftFavouritesList.ContextMenuStrip = Me.LeftRightClick
            Me.LeftFavouritesList.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.LeftFavouritesList.FormattingEnabled = True
            Me.LeftFavouritesList.ItemHeight = &H10
            point = New Point(12, &H57)
            Me.LeftFavouritesList.Location = point
            Me.LeftFavouritesList.Name = "LeftFavouritesList"
            size = New Size(120, 260)
            Me.LeftFavouritesList.Size = size
            Me.LeftFavouritesList.TabIndex = &H12
            toolStripItems = New ToolStripItem() { Me.OrganizzaPreferitiToolStripMenuItem }
            Me.LeftRightClick.Items.AddRange(toolStripItems)
            Me.LeftRightClick.Name = "LeftRightClick"
            Me.LeftRightClick.RenderMode = ToolStripRenderMode.System
            size = New Size(&HAF, &H1A)
            Me.LeftRightClick.Size = size
            Me.OrganizzaPreferitiToolStripMenuItem.Image = Resources.favourites_32
            Me.OrganizzaPreferitiToolStripMenuItem.Name = "OrganizzaPreferitiToolStripMenuItem"
            size = New Size(&HAE, &H16)
            Me.OrganizzaPreferitiToolStripMenuItem.Size = size
            Me.OrganizzaPreferitiToolStripMenuItem.Text = "&Organizza preferiti"
            Me.ContentView.AllowColumnReorder = True
            Me.ContentView.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Dim values As ColumnHeader() = New ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3 }
            Me.ContentView.Columns.AddRange(values)
            Me.ContentView.ContextMenuStrip = Me.ContentRightClick
            Me.ContentView.FullRowSelect = True
            Me.ContentView.HideSelection = False
            Me.ContentView.LargeImageList = Me.ContentImgList
            point = New Point(&H8A, &H37)
            Me.ContentView.Location = point
            Me.ContentView.Name = "ContentView"
            Me.ContentView.ShowGroups = False
            size = New Size(&H28E, &H1B5)
            Me.ContentView.Size = size
            Me.ContentView.SmallImageList = Me.ContentImgList
            Me.ContentView.StateImageList = Me.ContentImgList
            Me.ContentView.TabIndex = &H16
            size = New Size(200, &H38)
            Me.ContentView.TileSize = size
            Me.ContentView.UseCompatibleStateImageBehavior = False
            Me.ContentView.View = View.Tile
            toolStripItems = New ToolStripItem() { Me.OpenRightClick, Me.OpenWithRightClick, Me.NewRightClick, Me.RightDiv1, Me.AntivirRightClick, Me.CompressRightClick, Me.DecompressRightClick, Me.DecompressSubFolderRightClick, Me.RightDiv2 }
            toolStripItems(9) = Me.CopyRightClick
            toolStripItems(10) = Me.CutRightClick
            toolStripItems(11) = Me.PasteRightClick
            toolStripItems(12) = Me.RightDiv3
            toolStripItems(13) = Me.RenameRightClick
            toolStripItems(14) = Me.DeleteRightClick
            toolStripItems(15) = Me.PropertiesRightClick
            Me.ContentRightClick.Items.AddRange(toolStripItems)
            Me.ContentRightClick.Name = "ContextMenuStrip1"
            Me.ContentRightClick.RenderMode = ToolStripRenderMode.System
            size = New Size(&HD6, &H134)
            Me.ContentRightClick.Size = size
            Me.OpenRightClick.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.OpenRightClick.Name = "OpenRightClick"
            size = New Size(&HD5, &H16)
            Me.OpenRightClick.Size = size
            Me.OpenRightClick.Text = "&Apri"
            Me.OpenWithRightClick.Name = "OpenWithRightClick"
            size = New Size(&HD5, &H16)
            Me.OpenWithRightClick.Size = size
            Me.OpenWithRightClick.Text = "Apri con..."
            toolStripItems = New ToolStripItem() { Me.FolderRightClick, Me.SeparatoreTastoD, Me.FileRightClick }
            Me.NewRightClick.DropDownItems.AddRange(toolStripItems)
            Me.NewRightClick.Name = "NewRightClick"
            size = New Size(&HD5, &H16)
            Me.NewRightClick.Size = size
            Me.NewRightClick.Text = "&Nuovo"
            Me.FolderRightClick.Image = Resources.folder_16
            Me.FolderRightClick.Name = "FolderRightClick"
            size = New Size(&H7A, &H16)
            Me.FolderRightClick.Size = size
            Me.FolderRightClick.Text = "&Cartella"
            Me.SeparatoreTastoD.Name = "SeparatoreTastoD"
            size = New Size(&H77, 6)
            Me.SeparatoreTastoD.Size = size
            Me.FileRightClick.Name = "FileRightClick"
            size = New Size(&H7A, &H16)
            Me.FileRightClick.Size = size
            Me.FileRightClick.Text = "&File..."
            Me.RightDiv1.Name = "RightDiv1"
            size = New Size(210, 6)
            Me.RightDiv1.Size = size
            Me.AntivirRightClick.Image = Resources.clanbomber
            Me.AntivirRightClick.Name = "AntivirRightClick"
            size = New Size(&HD5, &H16)
            Me.AntivirRightClick.Size = size
            Me.AntivirRightClick.Text = "&Scansione antivirus"
            Me.CompressRightClick.Image = DirectCast(manager.GetObject("CompressRightClick.Image"), Image)
            Me.CompressRightClick.Name = "CompressRightClick"
            size = New Size(&HD5, &H16)
            Me.CompressRightClick.Size = size
            Me.CompressRightClick.Text = "Comprimi in un archivio..."
            Me.DecompressRightClick.Image = Resources.archive_16
            Me.DecompressRightClick.Name = "DecompressRightClick"
            size = New Size(&HD5, &H16)
            Me.DecompressRightClick.Size = size
            Me.DecompressRightClick.Text = "Decomprimi archivio"
            Me.DecompressSubFolderRightClick.Image = Resources.decompress_folder_16
            Me.DecompressSubFolderRightClick.Name = "DecompressSubFolderRightClick"
            size = New Size(&HD5, &H16)
            Me.DecompressSubFolderRightClick.Size = size
            Me.DecompressSubFolderRightClick.Text = "Decomprimi in sottocartella"
            Me.RightDiv2.Name = "RightDiv2"
            size = New Size(210, 6)
            Me.RightDiv2.Size = size
            Me.CopyRightClick.Image = Resources.copy_16
            Me.CopyRightClick.Name = "CopyRightClick"
            size = New Size(&HD5, &H16)
            Me.CopyRightClick.Size = size
            Me.CopyRightClick.Text = "&Copia"
            Me.CutRightClick.Image = Resources.cut_16
            Me.CutRightClick.Name = "CutRightClick"
            size = New Size(&HD5, &H16)
            Me.CutRightClick.Size = size
            Me.CutRightClick.Text = "&Taglia"
            Me.PasteRightClick.Image = Resources.paste_16
            Me.PasteRightClick.Name = "PasteRightClick"
            size = New Size(&HD5, &H16)
            Me.PasteRightClick.Size = size
            Me.PasteRightClick.Text = "&Incolla"
            Me.RightDiv3.Name = "RightDiv3"
            size = New Size(210, 6)
            Me.RightDiv3.Size = size
            Me.RenameRightClick.Image = Resources.font_32
            Me.RenameRightClick.Name = "RenameRightClick"
            size = New Size(&HD5, &H16)
            Me.RenameRightClick.Size = size
            Me.RenameRightClick.Text = "&Rinomina"
            Me.DeleteRightClick.Image = Resources.critical_48
            Me.DeleteRightClick.Name = "DeleteRightClick"
            size = New Size(&HD5, &H16)
            Me.DeleteRightClick.Size = size
            Me.DeleteRightClick.Text = "&Elimina"
            Me.PropertiesRightClick.Name = "PropertiesRightClick"
            size = New Size(&HD5, &H16)
            Me.PropertiesRightClick.Size = size
            Me.PropertiesRightClick.Text = "&Proprietà"
            Me.ContentImgList.ImageStream = DirectCast(manager.GetObject("ContentImgList.ImageStream"), ImageListStreamer)
            Me.ContentImgList.TransparentColor = Color.Transparent
            Me.ContentImgList.Images.SetKeyName(0, "")
            Me.ContentImgList.Images.SetKeyName(1, "kblackbox.png")
            Me.ContentImgList.Images.SetKeyName(2, "")
            Me.ContentImgList.Images.SetKeyName(3, "hdd_unmount.png")
            Me.ContentImgList.Images.SetKeyName(4, "")
            Me.ContentImgList.Images.SetKeyName(5, "")
            Me.ContentImgList.Images.SetKeyName(6, "html.png")
            Me.ContentImgList.Images.SetKeyName(7, "image.png")
            Me.ContentImgList.Images.SetKeyName(8, "krec_fileplay.png")
            Me.ContentImgList.Images.SetKeyName(9, "kword_kwd.png")
            Me.ContentImgList.Images.SetKeyName(10, "message.png")
            Me.ContentImgList.Images.SetKeyName(11, "metafont.png")
            Me.ContentImgList.Images.SetKeyName(12, "midi.png")
            Me.ContentImgList.Images.SetKeyName(13, "pdf.png")
            Me.ContentImgList.Images.SetKeyName(14, "shellscript.png")
            Me.ContentImgList.Images.SetKeyName(15, "sound.png")
            Me.ContentImgList.Images.SetKeyName(&H10, "source_c.png")
            Me.ContentImgList.Images.SetKeyName(&H11, "source_cpp.png")
            Me.ContentImgList.Images.SetKeyName(&H12, "source_css.png")
            Me.ContentImgList.Images.SetKeyName(&H13, "source_java.png")
            Me.ContentImgList.Images.SetKeyName(20, "source_php.png")
            Me.ContentImgList.Images.SetKeyName(&H15, "spreadsheet.png")
            Me.ContentImgList.Images.SetKeyName(&H16, "tar.png")
            Me.ContentImgList.Images.SetKeyName(&H17, "txt.png")
            Me.ContentImgList.Images.SetKeyName(&H18, "unknown.png")
            Me.ContentImgList.Images.SetKeyName(&H19, "video.png")
            Me.ContentImgList.Images.SetKeyName(&H1A, "wordprocessing.png")
            Me.ContentImgList.Images.SetKeyName(&H1B, "kcmkwm.png")
            Me.ContentImgList.Images.SetKeyName(&H1C, "link.png")
            Me.ContentImgList.Images.SetKeyName(&H1D, "folder_yellow.png")
            Me.ContentImgList.Images.SetKeyName(30, "folder_blue.png")
            Me.ContentImgList.Images.SetKeyName(&H1F, "folder_blue_open.png")
            Me.ContentImgList.Images.SetKeyName(&H20, "folder_cyan.png")
            Me.ContentImgList.Images.SetKeyName(&H21, "folder_cyan_open.png")
            Me.ContentImgList.Images.SetKeyName(&H22, "folder_green.png")
            Me.ContentImgList.Images.SetKeyName(&H23, "folder_green_open.png")
            Me.ContentImgList.Images.SetKeyName(&H24, "folder_grey.png")
            Me.ContentImgList.Images.SetKeyName(&H25, "folder_grey_open.png")
            Me.ContentImgList.Images.SetKeyName(&H26, "folder_orange.png")
            Me.ContentImgList.Images.SetKeyName(&H27, "folder_orange_open.png")
            Me.ContentImgList.Images.SetKeyName(40, "folder_red.png")
            Me.ContentImgList.Images.SetKeyName(&H29, "folder_red_open.png")
            Me.ContentImgList.Images.SetKeyName(&H2A, "folder_violet.png")
            Me.ContentImgList.Images.SetKeyName(&H2B, "folder_violet_open.png")
            Me.ContentImgList.Images.SetKeyName(&H2C, "3floppy_unmount.png")
            toolStripItems = New ToolStripItem() { Me.StatusLab, Me.Separatore1Lab, Me.DimensioniLab, Me.Separatore2Lab, Me.NumeroFileLab, Me.NumeroCartelleLab, Me.Separatore3Lab, Me.UnitàLab, Me.CaricamentoProg }
            Me.MainStatus.Items.AddRange(toolStripItems)
            point = New Point(0, &H1EB)
            Me.MainStatus.Location = point
            Me.MainStatus.Name = "MainStatus"
            size = New Size(&H318, &H19)
            Me.MainStatus.Size = size
            Me.MainStatus.TabIndex = &H17
            Me.MainStatus.Text = "Barra di stato"
            Me.StatusLab.AutoSize = False
            Me.StatusLab.Image = Resources.ok_32
            Me.StatusLab.ImageAlign = ContentAlignment.MiddleLeft
            Me.StatusLab.Name = "StatusLab"
            size = New Size(300, 20)
            Me.StatusLab.Size = size
            Me.StatusLab.Text = "Pronto."
            Me.StatusLab.TextAlign = ContentAlignment.MiddleLeft
            Me.StatusLab.TextDirection = ToolStripTextDirection.Horizontal
            Me.Separatore1Lab.Name = "Separatore1Lab"
            size = New Size(11, 20)
            Me.Separatore1Lab.Size = size
            Me.Separatore1Lab.Text = "|"
            Me.DimensioniLab.Name = "DimensioniLab"
            size = New Size(&H1C, 20)
            Me.DimensioniLab.Size = size
            Me.DimensioniLab.Text = "0 KB"
            Me.DimensioniLab.TextAlign = ContentAlignment.MiddleLeft
            Me.Separatore2Lab.Name = "Separatore2Lab"
            size = New Size(11, 20)
            Me.Separatore2Lab.Size = size
            Me.Separatore2Lab.Text = "|"
            Me.NumeroFileLab.Image = Resources.empty_16
            Me.NumeroFileLab.ImageAlign = ContentAlignment.MiddleLeft
            Me.NumeroFileLab.Name = "NumeroFileLab"
            size = New Size(&H1D, 20)
            Me.NumeroFileLab.Size = size
            Me.NumeroFileLab.Text = "0"
            Me.NumeroCartelleLab.Image = Resources.folder_16
            Me.NumeroCartelleLab.ImageAlign = ContentAlignment.MiddleLeft
            Me.NumeroCartelleLab.Name = "NumeroCartelleLab"
            size = New Size(&H1D, 20)
            Me.NumeroCartelleLab.Size = size
            Me.NumeroCartelleLab.Text = "0"
            Me.Separatore3Lab.Name = "Separatore3Lab"
            size = New Size(11, 20)
            Me.Separatore3Lab.Size = size
            Me.Separatore3Lab.Text = "|"
            Me.UnitàLab.Image = Resources.hd_blu_16
            Me.UnitàLab.ImageAlign = ContentAlignment.MiddleLeft
            Me.UnitàLab.Name = "UnitàLab"
            size = New Size(&H4A, 20)
            Me.UnitàLab.Size = size
            Me.UnitàLab.Text = "C:\ (NTFS)"
            Me.CaricamentoProg.Alignment = ToolStripItemAlignment.Right
            Me.CaricamentoProg.AutoSize = False
            Me.CaricamentoProg.Name = "CaricamentoProg"
            size = New Size(150, &H13)
            Me.CaricamentoProg.Size = size
            Me.CaricamentoProg.Step = 1
            Me.CaricamentoProg.Style = ProgressBarStyle.Continuous
            Me.CaricamentoProg.ToolTipText = "Caricamento"
            Me.PreviewText.AcceptsReturn = True
            Me.PreviewText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.PreviewText.BackColor = SystemColors.Window
            point = New Point(6, &H13)
            Me.PreviewText.Location = point
            Me.PreviewText.Multiline = True
            Me.PreviewText.Name = "PreviewText"
            Me.PreviewText.ReadOnly = True
            Me.PreviewText.ScrollBars = ScrollBars.Both
            size = New Size(&H6C, &H6C)
            Me.PreviewText.Size = size
            Me.PreviewText.TabIndex = &H18
            Me.PreviewText.Text = "Nessun file selezionato."
            Me.PreviewText.Visible = False
            Me.AnteprimaGroup.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            Me.AnteprimaGroup.Controls.Add(Me.PreviewVideoPan)
            Me.AnteprimaGroup.Controls.Add(Me.PreviewHtm)
            Me.AnteprimaGroup.Controls.Add(Me.PreviewPicture)
            Me.AnteprimaGroup.Controls.Add(Me.PreviewText)
            Me.AnteprimaGroup.Controls.Add(Me.PreviewAudioPan)
            point = New Point(12, &H163)
            Me.AnteprimaGroup.Location = point
            Me.AnteprimaGroup.Name = "AnteprimaGroup"
            size = New Size(120, &H85)
            Me.AnteprimaGroup.Size = size
            Me.AnteprimaGroup.TabIndex = &H19
            Me.AnteprimaGroup.TabStop = False
            Me.AnteprimaGroup.Text = "Anteprima"
            point = New Point(6, &H13)
            Me.PreviewVideoPan.Location = point
            Me.PreviewVideoPan.Name = "PreviewVideoPan"
            Me.PreviewVideoPan.Orientation = Orientation.Horizontal
            Me.PreviewVideoPan.Panel1.Controls.Add(Me.PreviewDisplayPan)
            Me.PreviewVideoPan.Panel1MinSize = &H4F
            Me.PreviewVideoPan.Panel2.Controls.Add(Me.AnteprimaVidStopButt)
            Me.PreviewVideoPan.Panel2.Controls.Add(Me.AnteprimaVidPlayButt)
            size = New Size(&H6C, &H6C)
            Me.PreviewVideoPan.Size = size
            Me.PreviewVideoPan.SplitterDistance = &H4F
            Me.PreviewVideoPan.TabIndex = &H20
            Me.PreviewVideoPan.Visible = False
            Me.PreviewDisplayPan.BackColor = Color.Black
            Me.PreviewDisplayPan.Dock = DockStyle.Fill
            point = New Point(0, 0)
            Me.PreviewDisplayPan.Location = point
            Me.PreviewDisplayPan.Name = "PreviewDisplayPan"
            size = New Size(&H6C, &H4F)
            Me.PreviewDisplayPan.Size = size
            Me.PreviewDisplayPan.TabIndex = &H1F
            Me.AnteprimaVidStopButt.Enabled = False
            point = New Point(&H3B, 2)
            Me.AnteprimaVidStopButt.Location = point
            Me.AnteprimaVidStopButt.Name = "AnteprimaVidStopButt"
            size = New Size(&H2E, &H17)
            Me.AnteprimaVidStopButt.Size = size
            Me.AnteprimaVidStopButt.TabIndex = 30
            Me.AnteprimaVidStopButt.Text = "&Stop"
            Me.AnteprimaVidStopButt.UseVisualStyleBackColor = True
            point = New Point(3, 2)
            Me.AnteprimaVidPlayButt.Location = point
            Me.AnteprimaVidPlayButt.Name = "AnteprimaVidPlayButt"
            size = New Size(50, &H17)
            Me.AnteprimaVidPlayButt.Size = size
            Me.AnteprimaVidPlayButt.TabIndex = &H1D
            Me.AnteprimaVidPlayButt.Text = "&Play"
            Me.AnteprimaVidPlayButt.UseVisualStyleBackColor = True
            Me.PreviewHtm.AllowNavigation = False
            point = New Point(6, &H13)
            Me.PreviewHtm.Location = point
            size = New Size(20, 20)
            Me.PreviewHtm.MinimumSize = size
            Me.PreviewHtm.Name = "PreviewHtm"
            size = New Size(&H6C, &H6C)
            Me.PreviewHtm.Size = size
            Me.PreviewHtm.TabIndex = &H1A
            Me.PreviewHtm.Visible = False
            Me.PreviewPicture.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.PreviewPicture.ErrorImage = Resources.file_locked
            Me.PreviewPicture.InitialImage = Resources.clock_128
            point = New Point(6, &H13)
            Me.PreviewPicture.Location = point
            Me.PreviewPicture.Name = "PreviewPicture"
            size = New Size(&H6C, &H6C)
            Me.PreviewPicture.Size = size
            Me.PreviewPicture.SizeMode = PictureBoxSizeMode.Zoom
            Me.PreviewPicture.TabIndex = &H1A
            Me.PreviewPicture.TabStop = False
            Me.PreviewPicture.Visible = False
            Me.PreviewAudioPan.Controls.Add(Me.Label1)
            Me.PreviewAudioPan.Controls.Add(Me.AnteprimaStopBut)
            Me.PreviewAudioPan.Controls.Add(Me.AnteprimaPlayBut)
            point = New Point(6, &H13)
            Me.PreviewAudioPan.Location = point
            Me.PreviewAudioPan.Name = "PreviewAudioPan"
            size = New Size(&H6C, &H6C)
            Me.PreviewAudioPan.Size = size
            Me.PreviewAudioPan.TabIndex = &H1A
            Me.PreviewAudioPan.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H13, 12)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H3E, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = &H1A
            Me.Label1.Text = "File audio"
            Me.AnteprimaStopBut.Enabled = False
            point = New Point(15, &H3E)
            Me.AnteprimaStopBut.Location = point
            Me.AnteprimaStopBut.Name = "AnteprimaStopBut"
            size = New Size(&H4A, &H17)
            Me.AnteprimaStopBut.Size = size
            Me.AnteprimaStopBut.TabIndex = &H1C
            Me.AnteprimaStopBut.Text = "&Stop"
            Me.AnteprimaStopBut.UseVisualStyleBackColor = True
            point = New Point(15, &H21)
            Me.AnteprimaPlayBut.Location = point
            Me.AnteprimaPlayBut.Name = "AnteprimaPlayBut"
            size = New Size(&H4A, &H17)
            Me.AnteprimaPlayBut.Size = size
            Me.AnteprimaPlayBut.TabIndex = &H1A
            Me.AnteprimaPlayBut.Text = "&Play"
            Me.AnteprimaPlayBut.UseVisualStyleBackColor = True
            Me.FileSystemWatcher.EnableRaisingEvents = True
            Me.FileSystemWatcher.SynchronizingObject = Me
            Me.MessageLab.AutoSize = True
            Me.MessageLab.BackColor = Color.White
            Me.MessageLab.Font = New Font("Microsoft Sans Serif", 15.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&HE2, &H47)
            Me.MessageLab.Location = point
            Me.MessageLab.Name = "MessageLab"
            size = New Size(&H7E, &H19)
            Me.MessageLab.Size = size
            Me.MessageLab.TabIndex = &H1B
            Me.MessageLab.Text = "Messaggio"
            Me.MessageLab.Visible = False
            Me.Message2Lab.AutoSize = True
            Me.Message2Lab.BackColor = Color.White
            point = New Point(&HE4, &H69)
            Me.Message2Lab.Location = point
            size = New Size(400, 0)
            Me.Message2Lab.MaximumSize = size
            Me.Message2Lab.Name = "Message2Lab"
            size = New Size(&H3E, 13)
            Me.Message2Lab.Size = size
            Me.Message2Lab.TabIndex = &H1C
            Me.Message2Lab.Text = "Descrizione"
            Me.Message2Lab.Visible = False
            Me.OpenWithDial.Filter = "Programmi|*.exe"
            Me.MessagePict.BackColor = Color.White
            Me.MessagePict.Image = Resources.empty_128
            point = New Point(&H9C, &H47)
            Me.MessagePict.Location = point
            Me.MessagePict.Name = "MessagePict"
            size = New Size(&H40, &H40)
            Me.MessagePict.Size = size
            Me.MessagePict.SizeMode = PictureBoxSizeMode.Zoom
            Me.MessagePict.TabIndex = &H1D
            Me.MessagePict.TabStop = False
            Me.MessagePict.Visible = False
            Me.FavouritesButt.BackgroundImage = Resources.add_48
            Me.FavouritesButt.BackgroundImageLayout = ImageLayout.Zoom
            Me.FavouritesButt.FlatStyle = FlatStyle.Flat
            point = New Point(&H6D, &H3A)
            Me.FavouritesButt.Location = point
            Me.FavouritesButt.Name = "FavouritesButt"
            size = New Size(&H17, &H17)
            Me.FavouritesButt.Size = size
            Me.FavouritesButt.TabIndex = &H1A
            Me.FavouritesButt.TextAlign = ContentAlignment.MiddleRight
            Me.FavouritesButt.TextImageRelation = TextImageRelation.ImageAboveText
            Me.FavouritesButt.UseVisualStyleBackColor = True
            Me.StatoButt.BackgroundImageLayout = ImageLayout.Zoom
            Me.StatoButt.FlatStyle = FlatStyle.Flat
            Me.StatoButt.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.StatoButt.ImageAlign = ContentAlignment.TopLeft
            Me.StatoButt.ImageIndex = 1
            Me.StatoButt.ImageList = Me.LeftImgList
            point = New Point(12, &H3A)
            Me.StatoButt.Location = point
            Me.StatoButt.Name = "StatoButt"
            size = New Size(120, &H17)
            Me.StatoButt.Size = size
            Me.StatoButt.TabIndex = &H13
            Me.StatoButt.Text = "Preferiti"
            Me.StatoButt.TextImageRelation = TextImageRelation.ImageBeforeText
            Me.StatoButt.UseVisualStyleBackColor = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H318, &H204)
            Me.ClientSize = size
            Me.Controls.Add(Me.MessagePict)
            Me.Controls.Add(Me.Message2Lab)
            Me.Controls.Add(Me.MessageLab)
            Me.Controls.Add(Me.FavouritesButt)
            Me.Controls.Add(Me.MainStatus)
            Me.Controls.Add(Me.StatoButt)
            Me.Controls.Add(Me.LeftFavouritesList)
            Me.Controls.Add(Me.MainStrip)
            Me.Controls.Add(Me.MainMenu)
            Me.Controls.Add(Me.ContentView)
            Me.Controls.Add(Me.LeftLinkList)
            Me.Controls.Add(Me.AnteprimaGroup)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            size = New Size(600, 400)
            Me.MinimumSize = size
            Me.Name = "Main"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Computer - Power Explorer"
            Me.MainStrip.ResumeLayout(False)
            Me.MainStrip.PerformLayout
            Me.MainMenu.ResumeLayout(False)
            Me.MainMenu.PerformLayout
            Me.LeftRightClick.ResumeLayout(False)
            Me.ContentRightClick.ResumeLayout(False)
            Me.MainStatus.ResumeLayout(False)
            Me.MainStatus.PerformLayout
            Me.AnteprimaGroup.ResumeLayout(False)
            Me.AnteprimaGroup.PerformLayout
            Me.PreviewVideoPan.Panel1.ResumeLayout(False)
            Me.PreviewVideoPan.Panel2.ResumeLayout(False)
            Me.PreviewVideoPan.ResumeLayout(False)
            DirectCast(Me.PreviewPicture, ISupportInitialize).EndInit
            Me.PreviewAudioPan.ResumeLayout(False)
            Me.PreviewAudioPan.PerformLayout
            Me.FileSystemWatcher.EndInit
            DirectCast(Me.MessagePict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub LivelloSuperioreToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Superiore
        End Sub

        Public Sub LoadFavourites()
            If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Favourites.txt")) Then
                Me.LeftFavouritesList.Items.Clear
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim num3 As Single = Conversions.ToSingle(reader.ReadLine)
                Dim i As Single = 1!
                Do While (i <= num3)
                    Dim str As String = reader.ReadLine
                    Dim count As Short = CShort((str.LastIndexOf("|") + 1))
                    Me.LeftFavouritesList.Items.Add(str.Remove(0, count))
                    i += 1
                Loop
                reader.Close
            End If
        End Sub

        Public Sub LoadItems()
        End Sub

        Private Sub MainTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Sub NewBlankFile()
        End Sub

        Private Sub OpenWithDial_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Process.Start(Me.OpenWithDial.FileName, Me.ContentView.SelectedItems(0).Name)
        End Sub

        Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Settings.Show
        End Sub

        Private Sub OrganizzaPreferitiToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Favourites.Show
        End Sub

        Public Sub Paste()
            MyProject.Forms.CopyForm.Set2(Me.Directory)
            MyProject.Forms.CopyForm.Show
        End Sub

        Private Sub PercorsoLab_Validated(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(Me.DirectoryText.Text, True)
        End Sub

        Private Sub PreferitiToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Favourites.Show
        End Sub

        Private Sub Principale_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadFavourites
            Me.Go(MySettingsProperty.Settings.Home, True)
            If MySettingsProperty.Settings.Updates Then
                Process.Start((Application.StartupPath & "Update.exe"))
                MySettingsProperty.Settings.Updates = False
                Application.Exit
            ElseIf MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "Update.exe")) Then
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "Update.exe"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
            If MySettingsProperty.Settings.AutoUpdate Then
                If (MySettingsProperty.Settings.LastUpdate.Year < MyProject.Computer.Clock.LocalTime.Year) Then
                    MyProject.Forms.Updates.Show
                ElseIf (MySettingsProperty.Settings.LastUpdate.Month < MyProject.Computer.Clock.LocalTime.Month) Then
                    MyProject.Forms.Updates.Show
                ElseIf (Decimal.Compare(Decimal.Add(New Decimal(MySettingsProperty.Settings.LastUpdate.Day), MySettingsProperty.Settings.DaysUpdate), New Decimal(MyProject.Computer.Clock.LocalTime.Day)) <= 0) Then
                    MyProject.Forms.Updates.Show
                End If
            End If
        End Sub

        Private Sub ProprietàToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.VisualizzaProprietà
        End Sub

        Private Sub ProprietàToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.VisualizzaProprietà
        End Sub

        Private Sub RenameRightClick_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rinomina
        End Sub

        Public Sub Right0()
            Me.OpenRightClick.Visible = False
            Me.OpenWithRightClick.Visible = False
            Me.AntivirRightClick.Visible = False
            Me.CompressRightClick.Visible = False
            Me.DecompressRightClick.Visible = False
            Me.DecompressSubFolderRightClick.Visible = False
            Me.CopyRightClick.Enabled = False
            Me.CutRightClick.Enabled = False
            Me.RenameRightClick.Visible = False
            Me.DeleteRightClick.Visible = False
            Me.RightDiv2.Visible = False
        End Sub

        Public Sub RightArchive()
            Me.NewRightClick.Visible = False
            Me.AntivirRightClick.Visible = True
            Me.CompressRightClick.Visible = False
            Me.DecompressRightClick.Enabled = True
            Me.DecompressSubFolderRightClick.Enabled = True
            Me.CopyRightClick.Visible = True
            Me.CutRightClick.Visible = True
            Me.PasteRightClick.Visible = True
            Me.RenameRightClick.Visible = True
            Me.DeleteRightClick.Visible = True
            Me.PropertiesRightClick.Visible = True
        End Sub

        Public Sub RightDefault()
            Me.OpenRightClick.Visible = True
            Me.OpenRightClick.Enabled = True
            Me.OpenWithRightClick.Visible = True
            Me.OpenWithRightClick.Enabled = True
            Me.NewRightClick.Visible = True
            Me.NewRightClick.Enabled = True
            Me.AntivirRightClick.Visible = True
            Me.AntivirRightClick.Enabled = True
            Me.CompressRightClick.Visible = True
            Me.CompressRightClick.Enabled = True
            Me.DecompressRightClick.Visible = True
            Me.DecompressRightClick.Enabled = True
            Me.DecompressSubFolderRightClick.Visible = True
            Me.DecompressSubFolderRightClick.Enabled = True
            Me.CopyRightClick.Visible = True
            Me.CopyRightClick.Enabled = True
            Me.CutRightClick.Visible = True
            Me.CutRightClick.Enabled = True
            Me.PasteRightClick.Visible = True
            Me.PasteRightClick.Enabled = True
            Me.RenameRightClick.Visible = True
            Me.RenameRightClick.Enabled = True
            Me.DeleteRightClick.Visible = True
            Me.DeleteRightClick.Enabled = True
            Me.PropertiesRightClick.Visible = True
            Me.PropertiesRightClick.Enabled = True
            Me.RightDiv1.Visible = True
            Me.RightDiv2.Visible = True
            Me.RightDiv3.Visible = True
        End Sub

        Public Sub RightDrive()
            Me.OpenWithRightClick.Visible = False
            Me.NewRightClick.Visible = False
            Me.CompressRightClick.Visible = False
            Me.DecompressRightClick.Visible = False
            Me.DecompressSubFolderRightClick.Visible = False
            Me.CopyRightClick.Visible = False
            Me.CutRightClick.Visible = False
            Me.PasteRightClick.Visible = False
            Me.RenameRightClick.Visible = False
            Me.DeleteRightClick.Visible = False
            Me.RightDiv2.Visible = False
        End Sub

        Public Sub RightFolder()
            Me.OpenRightClick.Visible = True
            Me.OpenWithRightClick.Visible = False
            Me.NewRightClick.Visible = False
            Me.AntivirRightClick.Visible = True
            Me.CompressRightClick.Visible = True
            Me.DecompressRightClick.Visible = False
            Me.DecompressSubFolderRightClick.Visible = False
            Me.CopyRightClick.Visible = True
            Me.CutRightClick.Visible = True
            Me.PasteRightClick.Visible = False
            Me.RenameRightClick.Visible = True
            Me.DeleteRightClick.Visible = True
            Me.PropertiesRightClick.Visible = True
        End Sub

        Public Sub RightGeneric()
            Me.NewRightClick.Visible = False
            Me.CompressRightClick.Visible = True
            Me.DecompressRightClick.Visible = False
            Me.DecompressSubFolderRightClick.Visible = False
            Me.CopyRightClick.Visible = True
            Me.CutRightClick.Visible = True
            Me.PasteRightClick.Visible = True
            Me.RenameRightClick.Visible = True
            Me.DeleteRightClick.Visible = True
            Me.PropertiesRightClick.Visible = True
        End Sub

        Public Sub Rinomina()
            If (Me.ContentView.SelectedItems(0).ImageIndex = MySettingsProperty.Settings.FolderIcon) Then
                MyProject.Forms.Rename.LoadInfo((Me.DirectoryText.Text & "\" & Me.ContentView.SelectedItems(0).Text), True)
            Else
                MyProject.Forms.Rename.LoadInfo((Me.DirectoryText.Text & "\" & Me.ContentView.SelectedItems(0).Text & Me.ContentView.SelectedItems(0).SubItems(1).Text), False)
            End If
            MyProject.Forms.Rename.Show
        End Sub

        Private Sub RinominaToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.Rinomina
        End Sub

        Private Sub SelezionaTuttoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Short = CShort((Me.ContentView.Items.Count - 1))
            Dim i As Short = 0
            Do While (i <= num2)
                Me.ContentView.Items(i).Selected = True
                i = CShort((i + 1))
            Loop
        End Sub

        Private Sub SinistraList_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
            reader.ReadLine
            Dim num2 As Short = CShort((Me.LeftFavouritesList.SelectedIndex - 1))
            Dim i As Short = 0
            Do While (i <= num2)
                reader.ReadLine
                i = CShort((i + 1))
            Loop
            Dim str As String = reader.ReadLine
            reader.Close
            Me.Go(str.Remove(str.LastIndexOf("|"), (str.Length - str.LastIndexOf("|"))), True)
        End Sub

        Private Sub SinistraList3_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(Conversions.ToString(Me.LeftLinkList.Items(Me.LeftLinkList.SelectedIndex)), True)
        End Sub

        Private Sub SitoWebUfficialeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://powersoftware.altervista.org/")
        End Sub

        Private Sub StatoButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Select Case Me.Stato
                Case 0
                    Me.Stato = 1
                    Me.StatoButt.Text = "Collegamenti"
                    Me.StatoButt.ImageIndex = 0
                    Me.LeftFavouritesList.Visible = False
                    Me.LeftLinkList.Visible = True
                    Me.FavouritesButt.Visible = False
                    Exit Select
                Case 1
                    Me.Stato = 0
                    Me.StatoButt.Text = "Preferiti"
                    Me.StatoButt.ImageIndex = 1
                    Me.LeftFavouritesList.Visible = True
                    Me.LeftLinkList.Visible = False
                    Me.FavouritesButt.Visible = True
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub StopButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Interrotto = True
        End Sub

        Public Sub Superiore()
            Me.PreviewPicture.Visible = False
            Me.PreviewText.Visible = False
            Me.PreviewAudioPan.Visible = False
            Me.PreviewVideoPan.Visible = False
            Me.PreviewHtm.Visible = False
            Me.PreviewPicture.Image = Me.PreviewPicture.InitialImage
            Me.PreviewText.Text = ""
            Me.PreviewHtm.Url = New Uri("about:blank")
            Try 
                Me.SoundFile.Stop
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                ProjectData.ClearProjectError
            End Try
            Try 
                Me.VideoFile.Stop
            Catch exception3 As Exception
                Dim ex As Exception = exception3
                ProjectData.SetProjectError(ex)
                Dim exception2 As Exception = ex
                ProjectData.ClearProjectError
            End Try
            Me.AnteprimaStopBut.Enabled = False
            Me.DimensioniLab.Text = "0 KB"
            Dim directory As String = Me.Directory
            If (((directory <> "Computer") AndAlso (directory <> "about:blank")) AndAlso (directory <> "Error")) Then
                If (Me.Directory.Length < 5) Then
                    Me.Go("Computer", True)
                Else
                    Me.Go(MyProject.Computer.FileSystem.GetDirectoryInfo(Me.Directory).Parent.FullName, True)
                End If
            End If
        End Sub

        Private Sub TagliaTastoD_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Cut
        End Sub

        Private Sub TagliaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Cut
        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Superiore
        End Sub

        Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(Me.DirectoryText.Text, True)
        End Sub

        Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Go(MySettingsProperty.Settings.Home, True)
        End Sub

        Private Sub ToolStripMenuItem9_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.MultiFile.Show
        End Sub

        Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub ToolStripSplitButton2_ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Chronology.txt")) Then
                Dim reader As New StreamReader((Application.StartupPath & "\Chronology.txt"))
                reader.ReadLine
                Dim str As String = reader.ReadLine
                reader.Close
                Me.Go(str.Remove(str.LastIndexOf("|"), (str.Length - str.LastIndexOf("|"))), False)
            End If
        End Sub

        Private Sub UnitàLab_Click(ByVal sender As Object, ByVal e As EventArgs)
            If ((Me.Directory <> "") AndAlso (Me.Directory <> "Computer")) Then
                Me.Go(Me.Directory.Remove(3, (Me.Directory.Length - 3)), True)
            End If
        End Sub

        Public Sub VisualizzaProprietà()
            Dim count As Integer = Me.ContentView.SelectedItems.Count
            If (count = 0) Then
                If (Me.Directory <> "Computer") Then
                    If (Me.Directory.Length < 5) Then
                        MyProject.Forms.Proprietes.LoadDrive(Me.Directory.Remove(3, (Me.Directory.Length - 3)))
                        MyProject.Forms.Proprietes.Show
                    Else
                        MyProject.Forms.Proprietes.LoadDirectory(Me.Directory)
                        MyProject.Forms.Proprietes.Show
                    End If
                End If
            ElseIf (count <> 1) Then
                If (count > 1) Then
                End If
            Else
                Dim imageIndex As Integer = Me.ContentView.SelectedItems(0).ImageIndex
                If (imageIndex = MySettingsProperty.Settings.FolderIcon) Then
                    MyProject.Forms.Proprietes.LoadDirectory(Me.ContentView.SelectedItems(0).Name)
                    MyProject.Forms.Proprietes.Show
                ElseIf (imageIndex = MySettingsProperty.Settings.HardDiskIcon) Then
                    MyProject.Forms.Proprietes.LoadDrive(Me.ContentView.SelectedItems(0).Name)
                    MyProject.Forms.Proprietes.Show
                ElseIf (imageIndex = MySettingsProperty.Settings.CDIcon) Then
                    MyProject.Forms.Proprietes.LoadDrive(Me.ContentView.SelectedItems(0).Name)
                    MyProject.Forms.Proprietes.Show
                ElseIf (imageIndex = MySettingsProperty.Settings.USBIcon) Then
                    MyProject.Forms.Proprietes.LoadDrive(Me.ContentView.SelectedItems(0).Name)
                    MyProject.Forms.Proprietes.Show
                ElseIf (imageIndex = MySettingsProperty.Settings.FloppyIcon) Then
                    MyProject.Forms.Proprietes.LoadDrive(Me.ContentView.SelectedItems(0).Name)
                    MyProject.Forms.Proprietes.Show
                Else
                    MyProject.Forms.Proprietes.LoadFile(Me.ContentView.SelectedItems(0).Name, CShort(Me.ContentView.SelectedItems(0).ImageIndex))
                    MyProject.Forms.Proprietes.Show
                End If
            End If
        End Sub


        ' Properties
        Friend Overridable Property MainStrip As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MainStrip
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._MainStrip = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripSplitButton2 As ToolStripSplitButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripSplitButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSplitButton)
                If (Not Me._ToolStripSplitButton2 Is Nothing) Then
                    RemoveHandler Me._ToolStripSplitButton2.ButtonClick, New EventHandler(AddressOf Me.ToolStripSplitButton2_ButtonClick)
                End If
                Me._ToolStripSplitButton2 = WithEventsValue
                If (Not Me._ToolStripSplitButton2 Is Nothing) Then
                    AddHandler Me._ToolStripSplitButton2.ButtonClick, New EventHandler(AddressOf Me.ToolStripSplitButton2_ButtonClick)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton1 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click)
                End If
                Me._ToolStripButton1 = WithEventsValue
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    AddHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton4 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton4 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton4.Click, New EventHandler(AddressOf Me.ToolStripButton4_Click)
                End If
                Me._ToolStripButton4 = WithEventsValue
                If (Not Me._ToolStripButton4 Is Nothing) Then
                    AddHandler Me._ToolStripButton4.Click, New EventHandler(AddressOf Me.ToolStripButton4_Click)
                End If
            End Set
        End Property

        Friend Overridable Property DirectoryText As ToolStripTextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DirectoryText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripTextBox)
                If (Not Me._DirectoryText Is Nothing) Then
                    RemoveHandler Me._DirectoryText.Validated, New EventHandler(AddressOf Me.PercorsoLab_Validated)
                End If
                Me._DirectoryText = WithEventsValue
                If (Not Me._DirectoryText Is Nothing) Then
                    AddHandler Me._DirectoryText.Validated, New EventHandler(AddressOf Me.PercorsoLab_Validated)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripSplitButton1 As ToolStripSplitButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripSplitButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSplitButton)
                If (Not Me._ToolStripSplitButton1 Is Nothing) Then
                    RemoveHandler Me._ToolStripSplitButton1.ButtonClick, New EventHandler(AddressOf Me.ToolStripSplitButton1_ButtonClick)
                End If
                Me._ToolStripSplitButton1 = WithEventsValue
                If (Not Me._ToolStripSplitButton1 Is Nothing) Then
                    AddHandler Me._ToolStripSplitButton1.ButtonClick, New EventHandler(AddressOf Me.ToolStripSplitButton1_ButtonClick)
                End If
            End Set
        End Property

        Friend Overridable Property InQuestaCartellaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._InQuestaCartellaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._InQuestaCartellaToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InQuestaCartellaESottocartelleToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._InQuestaCartellaESottocartelleToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._InQuestaCartellaESottocartelleToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OvunqueToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OvunqueToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._OvunqueToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripTextBox1 As ToolStripTextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripTextBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripTextBox)
                Me._ToolStripTextBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripButton2 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton2 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton2.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
                Me._ToolStripButton2 = WithEventsValue
                If (Not Me._ToolStripButton2 Is Nothing) Then
                    AddHandler Me._ToolStripButton2.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property StopButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._StopButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._StopButt Is Nothing) Then
                    RemoveHandler Me._StopButt.Click, New EventHandler(AddressOf Me.StopButt_Click)
                End If
                Me._StopButt = WithEventsValue
                If (Not Me._StopButt Is Nothing) Then
                    AddHandler Me._StopButt.Click, New EventHandler(AddressOf Me.StopButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property MainMenu As MenuStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MainMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As MenuStrip)
                Me._MainMenu = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ModificaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ModificaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._ModificaToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CopiaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CopiaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CopiaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._CopiaToolStripMenuItem.Click, New EventHandler(AddressOf Me.CopiaToolStripMenuItem_Click)
                End If
                Me._CopiaToolStripMenuItem = WithEventsValue
                If (Not Me._CopiaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._CopiaToolStripMenuItem.Click, New EventHandler(AddressOf Me.CopiaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property TagliaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._TagliaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._TagliaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._TagliaToolStripMenuItem.Click, New EventHandler(AddressOf Me.TagliaToolStripMenuItem_Click)
                End If
                Me._TagliaToolStripMenuItem = WithEventsValue
                If (Not Me._TagliaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._TagliaToolStripMenuItem.Click, New EventHandler(AddressOf Me.TagliaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property IncollaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._IncollaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._IncollaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._IncollaToolStripMenuItem.Click, New EventHandler(AddressOf Me.IncollaToolStripMenuItem_Click)
                End If
                Me._IncollaToolStripMenuItem = WithEventsValue
                If (Not Me._IncollaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._IncollaToolStripMenuItem.Click, New EventHandler(AddressOf Me.IncollaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property StrumentiToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._StrumentiToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._StrumentiToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OpzioniToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OpzioniToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OpzioniToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._OpzioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.OpzioniToolStripMenuItem_Click)
                End If
                Me._OpzioniToolStripMenuItem = WithEventsValue
                If (Not Me._OpzioniToolStripMenuItem Is Nothing) Then
                    AddHandler Me._OpzioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.OpzioniToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._ToolStripMenuItem1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InformazioniSuPowerExplorerToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._InformazioniSuPowerExplorerToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._InformazioniSuPowerExplorerToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._InformazioniSuPowerExplorerToolStripMenuItem.Click, New EventHandler(AddressOf Me.InformazioniSuPowerExplorerToolStripMenuItem_Click)
                End If
                Me._InformazioniSuPowerExplorerToolStripMenuItem = WithEventsValue
                If (Not Me._InformazioniSuPowerExplorerToolStripMenuItem Is Nothing) Then
                    AddHandler Me._InformazioniSuPowerExplorerToolStripMenuItem.Click, New EventHandler(AddressOf Me.InformazioniSuPowerExplorerToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property BottomToolStripPanel As ToolStripPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._BottomToolStripPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripPanel)
                Me._BottomToolStripPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TopToolStripPanel As ToolStripPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._TopToolStripPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripPanel)
                Me._TopToolStripPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RightToolStripPanel As ToolStripPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._RightToolStripPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripPanel)
                Me._RightToolStripPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LeftToolStripPanel As ToolStripPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._LeftToolStripPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripPanel)
                Me._LeftToolStripPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ContentPanel As ToolStripContentPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._ContentPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripContentPanel)
                Me._ContentPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LeftLinkList As ListBox
            <DebuggerNonUserCode> _
            Get
                Return Me._LeftLinkList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListBox)
                If (Not Me._LeftLinkList Is Nothing) Then
                    RemoveHandler Me._LeftLinkList.DoubleClick, New EventHandler(AddressOf Me.SinistraList3_DoubleClick)
                End If
                Me._LeftLinkList = WithEventsValue
                If (Not Me._LeftLinkList Is Nothing) Then
                    AddHandler Me._LeftLinkList.DoubleClick, New EventHandler(AddressOf Me.SinistraList3_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property StatoButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._StatoButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._StatoButt Is Nothing) Then
                    RemoveHandler Me._StatoButt.Click, New EventHandler(AddressOf Me.StatoButt_Click)
                End If
                Me._StatoButt = WithEventsValue
                If (Not Me._StatoButt Is Nothing) Then
                    AddHandler Me._StatoButt.Click, New EventHandler(AddressOf Me.StatoButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property LeftFavouritesList As ListBox
            <DebuggerNonUserCode> _
            Get
                Return Me._LeftFavouritesList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListBox)
                If (Not Me._LeftFavouritesList Is Nothing) Then
                    RemoveHandler Me._LeftFavouritesList.DoubleClick, New EventHandler(AddressOf Me.SinistraList_DoubleClick)
                End If
                Me._LeftFavouritesList = WithEventsValue
                If (Not Me._LeftFavouritesList Is Nothing) Then
                    AddHandler Me._LeftFavouritesList.DoubleClick, New EventHandler(AddressOf Me.SinistraList_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property ContentView As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._ContentView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._ContentView Is Nothing) Then
                    RemoveHandler Me._ContentView.SelectedIndexChanged, New EventHandler(AddressOf Me.ContenutoWiev_SelectedIndexChanged)
                    RemoveHandler Me._ContentView.ItemDrag, New ItemDragEventHandler(AddressOf Me.ContentView_ItemDrag)
                    RemoveHandler Me._ContentView.DoubleClick, New EventHandler(AddressOf Me.ContenutoWiev_DoubleClick)
                End If
                Me._ContentView = WithEventsValue
                If (Not Me._ContentView Is Nothing) Then
                    AddHandler Me._ContentView.SelectedIndexChanged, New EventHandler(AddressOf Me.ContenutoWiev_SelectedIndexChanged)
                    AddHandler Me._ContentView.ItemDrag, New ItemDragEventHandler(AddressOf Me.ContentView_ItemDrag)
                    AddHandler Me._ContentView.DoubleClick, New EventHandler(AddressOf Me.ContenutoWiev_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property ColumnHeader1 As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._ColumnHeader1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._ColumnHeader1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ColumnHeader2 As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._ColumnHeader2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._ColumnHeader2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MainStatus As StatusStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MainStatus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As StatusStrip)
                Me._MainStatus = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LeftImgList As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._LeftImgList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._LeftImgList = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StatusLab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._StatusLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._StatusLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NavigazioneToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._NavigazioneToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._NavigazioneToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LivelloSuperioreToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._LivelloSuperioreToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._LivelloSuperioreToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._LivelloSuperioreToolStripMenuItem.Click, New EventHandler(AddressOf Me.LivelloSuperioreToolStripMenuItem_Click)
                End If
                Me._LivelloSuperioreToolStripMenuItem = WithEventsValue
                If (Not Me._LivelloSuperioreToolStripMenuItem Is Nothing) Then
                    AddHandler Me._LivelloSuperioreToolStripMenuItem.Click, New EventHandler(AddressOf Me.LivelloSuperioreToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property HomeToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._HomeToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._HomeToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._HomeToolStripMenuItem.Click, New EventHandler(AddressOf Me.HomeToolStripMenuItem_Click)
                End If
                Me._HomeToolStripMenuItem = WithEventsValue
                If (Not Me._HomeToolStripMenuItem Is Nothing) Then
                    AddHandler Me._HomeToolStripMenuItem.Click, New EventHandler(AddressOf Me.HomeToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ContentImgList As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._ContentImgList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._ContentImgList = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CaricamentoProg As ToolStripProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._CaricamentoProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripProgressBar)
                Me._CaricamentoProg = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ContentRightClick As ContextMenuStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._ContentRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ContextMenuStrip)
                If (Not Me._ContentRightClick Is Nothing) Then
                    RemoveHandler Me._ContentRightClick.Opened, New EventHandler(AddressOf Me.ContentRightClick_Opened)
                    RemoveHandler Me._ContentRightClick.Opening, New CancelEventHandler(AddressOf Me.ContentRightClick_Opening)
                End If
                Me._ContentRightClick = WithEventsValue
                If (Not Me._ContentRightClick Is Nothing) Then
                    AddHandler Me._ContentRightClick.Opened, New EventHandler(AddressOf Me.ContentRightClick_Opened)
                    AddHandler Me._ContentRightClick.Opening, New CancelEventHandler(AddressOf Me.ContentRightClick_Opening)
                End If
            End Set
        End Property

        Friend Overridable Property OpenRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OpenRightClick Is Nothing) Then
                    RemoveHandler Me._OpenRightClick.Click, New EventHandler(AddressOf Me.ApriToolStripMenuItem_Click)
                End If
                Me._OpenRightClick = WithEventsValue
                If (Not Me._OpenRightClick Is Nothing) Then
                    AddHandler Me._OpenRightClick.Click, New EventHandler(AddressOf Me.ApriToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RightDiv2 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._RightDiv2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._RightDiv2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CopyRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CopyRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CopyRightClick Is Nothing) Then
                    RemoveHandler Me._CopyRightClick.Click, New EventHandler(AddressOf Me.CopiatastoD_Click)
                End If
                Me._CopyRightClick = WithEventsValue
                If (Not Me._CopyRightClick Is Nothing) Then
                    AddHandler Me._CopyRightClick.Click, New EventHandler(AddressOf Me.CopiatastoD_Click)
                End If
            End Set
        End Property

        Friend Overridable Property CutRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CutRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CutRightClick Is Nothing) Then
                    RemoveHandler Me._CutRightClick.Click, New EventHandler(AddressOf Me.TagliaTastoD_Click)
                End If
                Me._CutRightClick = WithEventsValue
                If (Not Me._CutRightClick Is Nothing) Then
                    AddHandler Me._CutRightClick.Click, New EventHandler(AddressOf Me.TagliaTastoD_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PasteRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._PasteRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._PasteRightClick Is Nothing) Then
                    RemoveHandler Me._PasteRightClick.Click, New EventHandler(AddressOf Me.IncollaTastoD_Click)
                End If
                Me._PasteRightClick = WithEventsValue
                If (Not Me._PasteRightClick Is Nothing) Then
                    AddHandler Me._PasteRightClick.Click, New EventHandler(AddressOf Me.IncollaTastoD_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RightDiv3 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._RightDiv3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._RightDiv3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._DeleteRightClick Is Nothing) Then
                    RemoveHandler Me._DeleteRightClick.Click, New EventHandler(AddressOf Me.EliminaToolStripMenuItem1_Click)
                End If
                Me._DeleteRightClick = WithEventsValue
                If (Not Me._DeleteRightClick Is Nothing) Then
                    AddHandler Me._DeleteRightClick.Click, New EventHandler(AddressOf Me.EliminaToolStripMenuItem1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PropertiesRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._PropertiesRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._PropertiesRightClick Is Nothing) Then
                    RemoveHandler Me._PropertiesRightClick.Click, New EventHandler(AddressOf Me.ProprietàToolStripMenuItem1_Click)
                End If
                Me._PropertiesRightClick = WithEventsValue
                If (Not Me._PropertiesRightClick Is Nothing) Then
                    AddHandler Me._PropertiesRightClick.Click, New EventHandler(AddressOf Me.ProprietàToolStripMenuItem1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem5 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripMenuItem5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SelezionaTuttoToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SelezionaTuttoToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._SelezionaTuttoToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._SelezionaTuttoToolStripMenuItem.Click, New EventHandler(AddressOf Me.SelezionaTuttoToolStripMenuItem_Click)
                End If
                Me._SelezionaTuttoToolStripMenuItem = WithEventsValue
                If (Not Me._SelezionaTuttoToolStripMenuItem Is Nothing) Then
                    AddHandler Me._SelezionaTuttoToolStripMenuItem.Click, New EventHandler(AddressOf Me.SelezionaTuttoToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property UnitàLab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._UnitàLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                If (Not Me._UnitàLab Is Nothing) Then
                    RemoveHandler Me._UnitàLab.Click, New EventHandler(AddressOf Me.UnitàLab_Click)
                End If
                Me._UnitàLab = WithEventsValue
                If (Not Me._UnitàLab Is Nothing) Then
                    AddHandler Me._UnitàLab.Click, New EventHandler(AddressOf Me.UnitàLab_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Separatore1Lab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._Separatore1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._Separatore1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DimensioniLab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._DimensioniLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._DimensioniLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Separatore2Lab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._Separatore2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._Separatore2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NumeroFileLab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._NumeroFileLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._NumeroFileLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NumeroCartelleLab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._NumeroCartelleLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._NumeroCartelleLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Separatore3Lab As ToolStripStatusLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._Separatore3Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripStatusLabel)
                Me._Separatore3Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AggiornaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._AggiornaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._AggiornaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._AggiornaToolStripMenuItem.Click, New EventHandler(AddressOf Me.AggiornaToolStripMenuItem_Click)
                End If
                Me._AggiornaToolStripMenuItem = WithEventsValue
                If (Not Me._AggiornaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._AggiornaToolStripMenuItem.Click, New EventHandler(AddressOf Me.AggiornaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AnnullaCaricamentoToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._AnnullaCaricamentoToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._AnnullaCaricamentoToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._AnnullaCaricamentoToolStripMenuItem.Click, New EventHandler(AddressOf Me.AnnullaCaricamentoToolStripMenuItem_Click)
                End If
                Me._AnnullaCaricamentoToolStripMenuItem = WithEventsValue
                If (Not Me._AnnullaCaricamentoToolStripMenuItem Is Nothing) Then
                    AddHandler Me._AnnullaCaricamentoToolStripMenuItem.Click, New EventHandler(AddressOf Me.AnnullaCaricamentoToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem7 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripMenuItem7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NewRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._NewRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._NewRightClick = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FolderRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FolderRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._FolderRightClick Is Nothing) Then
                    RemoveHandler Me._FolderRightClick.Click, New EventHandler(AddressOf Me.FolderRightClick_Click)
                End If
                Me._FolderRightClick = WithEventsValue
                If (Not Me._FolderRightClick Is Nothing) Then
                    AddHandler Me._FolderRightClick.Click, New EventHandler(AddressOf Me.FolderRightClick_Click)
                End If
            End Set
        End Property

        Friend Overridable Property SeparatoreTastoD As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._SeparatoreTastoD
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._SeparatoreTastoD = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CercaAggiornamentiToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CercaAggiornamentiToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CercaAggiornamentiToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._CercaAggiornamentiToolStripMenuItem.Click, New EventHandler(AddressOf Me.CercaAggiornamentiToolStripMenuItem_Click)
                End If
                Me._CercaAggiornamentiToolStripMenuItem = WithEventsValue
                If (Not Me._CercaAggiornamentiToolStripMenuItem Is Nothing) Then
                    AddHandler Me._CercaAggiornamentiToolStripMenuItem.Click, New EventHandler(AddressOf Me.CercaAggiornamentiToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PreviewText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._PreviewText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AnteprimaGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AnteprimaGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._AnteprimaGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewPicture As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewPicture
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PreviewPicture = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewAudioPan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewAudioPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._PreviewAudioPan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AnteprimaStopBut As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnteprimaStopBut
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnteprimaStopBut Is Nothing) Then
                    RemoveHandler Me._AnteprimaStopBut.Click, New EventHandler(AddressOf Me.AnteprimaStopBut_Click)
                End If
                Me._AnteprimaStopBut = WithEventsValue
                If (Not Me._AnteprimaStopBut Is Nothing) Then
                    AddHandler Me._AnteprimaStopBut.Click, New EventHandler(AddressOf Me.AnteprimaStopBut_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AnteprimaPlayBut As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnteprimaPlayBut
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnteprimaPlayBut Is Nothing) Then
                    RemoveHandler Me._AnteprimaPlayBut.Click, New EventHandler(AddressOf Me.AnteprimaPlayBut_Click)
                End If
                Me._AnteprimaPlayBut = WithEventsValue
                If (Not Me._AnteprimaPlayBut Is Nothing) Then
                    AddHandler Me._AnteprimaPlayBut.Click, New EventHandler(AddressOf Me.AnteprimaPlayBut_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PreviewHtm As WebBrowser
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewHtm
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As WebBrowser)
                Me._PreviewHtm = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FileRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FileRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._FileRightClick Is Nothing) Then
                    RemoveHandler Me._FileRightClick.Click, New EventHandler(AddressOf Me.FileRightClick_Click)
                End If
                Me._FileRightClick = WithEventsValue
                If (Not Me._FileRightClick Is Nothing) Then
                    AddHandler Me._FileRightClick.Click, New EventHandler(AddressOf Me.FileRightClick_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem9 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ToolStripMenuItem9 Is Nothing) Then
                    RemoveHandler Me._ToolStripMenuItem9.Click, New EventHandler(AddressOf Me.ToolStripMenuItem9_Click)
                End If
                Me._ToolStripMenuItem9 = WithEventsValue
                If (Not Me._ToolStripMenuItem9 Is Nothing) Then
                    AddHandler Me._ToolStripMenuItem9.Click, New EventHandler(AddressOf Me.ToolStripMenuItem9_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ColumnHeader3 As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._ColumnHeader3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._ColumnHeader3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FileSystemWatcher As FileSystemWatcher
            <DebuggerNonUserCode> _
            Get
                Return Me._FileSystemWatcher
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FileSystemWatcher)
                If (Not Me._FileSystemWatcher Is Nothing) Then
                    RemoveHandler Me._FileSystemWatcher.Renamed, New RenamedEventHandler(AddressOf Me.FileSystemWatcher_Renamed)
                    RemoveHandler Me._FileSystemWatcher.Created, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                    RemoveHandler Me._FileSystemWatcher.Deleted, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                    RemoveHandler Me._FileSystemWatcher.Changed, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                End If
                Me._FileSystemWatcher = WithEventsValue
                If (Not Me._FileSystemWatcher Is Nothing) Then
                    AddHandler Me._FileSystemWatcher.Renamed, New RenamedEventHandler(AddressOf Me.FileSystemWatcher_Renamed)
                    AddHandler Me._FileSystemWatcher.Created, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                    AddHandler Me._FileSystemWatcher.Deleted, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                    AddHandler Me._FileSystemWatcher.Changed, New FileSystemEventHandler(AddressOf Me.FileSystemWatcher_Changed)
                End If
            End Set
        End Property

        Friend Overridable Property SitoWebUfficialeToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SitoWebUfficialeToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._SitoWebUfficialeToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._SitoWebUfficialeToolStripMenuItem.Click, New EventHandler(AddressOf Me.SitoWebUfficialeToolStripMenuItem_Click)
                End If
                Me._SitoWebUfficialeToolStripMenuItem = WithEventsValue
                If (Not Me._SitoWebUfficialeToolStripMenuItem Is Nothing) Then
                    AddHandler Me._SitoWebUfficialeToolStripMenuItem.Click, New EventHandler(AddressOf Me.SitoWebUfficialeToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property FavouritesButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._FavouritesButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._FavouritesButt Is Nothing) Then
                    RemoveHandler Me._FavouritesButt.Click, New EventHandler(AddressOf Me.FavouritesButt_Click)
                End If
                Me._FavouritesButt = WithEventsValue
                If (Not Me._FavouritesButt Is Nothing) Then
                    AddHandler Me._FavouritesButt.Click, New EventHandler(AddressOf Me.FavouritesButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PreferitiToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._PreferitiToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._PreferitiToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._PreferitiToolStripMenuItem.Click, New EventHandler(AddressOf Me.PreferitiToolStripMenuItem_Click_1)
                End If
                Me._PreferitiToolStripMenuItem = WithEventsValue
                If (Not Me._PreferitiToolStripMenuItem Is Nothing) Then
                    AddHandler Me._PreferitiToolStripMenuItem.Click, New EventHandler(AddressOf Me.PreferitiToolStripMenuItem_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property MainTimer As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTimer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._MainTimer Is Nothing) Then
                    RemoveHandler Me._MainTimer.Tick, New EventHandler(AddressOf Me.MainTimer_Tick)
                End If
                Me._MainTimer = WithEventsValue
                If (Not Me._MainTimer Is Nothing) Then
                    AddHandler Me._MainTimer.Tick, New EventHandler(AddressOf Me.MainTimer_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property MessageLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._MessageLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._MessageLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Message2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Message2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Message2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MessagePict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._MessagePict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._MessagePict = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CronologiaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CronologiaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CronologiaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._CronologiaToolStripMenuItem.Click, New EventHandler(AddressOf Me.CronologiaToolStripMenuItem_Click)
                End If
                Me._CronologiaToolStripMenuItem = WithEventsValue
                If (Not Me._CronologiaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._CronologiaToolStripMenuItem.Click, New EventHandler(AddressOf Me.CronologiaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OneToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OneToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._OneToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TwoToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._TwoToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._TwoToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ThreeToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ThreeToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._ThreeToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FourToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FourToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._FourToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FiveToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FiveToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._FiveToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SixToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SixToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._SixToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SevenToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SevenToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._SevenToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property EightToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._EightToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._EightToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NineToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._NineToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._NineToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TenToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._TenToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._TenToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AntivirRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._AntivirRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._AntivirRightClick Is Nothing) Then
                    RemoveHandler Me._AntivirRightClick.Click, New EventHandler(AddressOf Me.AntivirRightClick_Click)
                End If
                Me._AntivirRightClick = WithEventsValue
                If (Not Me._AntivirRightClick Is Nothing) Then
                    AddHandler Me._AntivirRightClick.Click, New EventHandler(AddressOf Me.AntivirRightClick_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RightDiv1 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._RightDiv1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._RightDiv1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CompressRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CompressRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._CompressRightClick Is Nothing) Then
                    RemoveHandler Me._CompressRightClick.Click, New EventHandler(AddressOf Me.CompressRightClick_Click)
                End If
                Me._CompressRightClick = WithEventsValue
                If (Not Me._CompressRightClick Is Nothing) Then
                    AddHandler Me._CompressRightClick.Click, New EventHandler(AddressOf Me.CompressRightClick_Click)
                End If
            End Set
        End Property

        Friend Overridable Property DecompressRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._DecompressRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._DecompressRightClick = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DecompressSubFolderRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._DecompressSubFolderRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._DecompressSubFolderRightClick = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenameRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._RenameRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._RenameRightClick Is Nothing) Then
                    RemoveHandler Me._RenameRightClick.Click, New EventHandler(AddressOf Me.RenameRightClick_Click)
                End If
                Me._RenameRightClick = WithEventsValue
                If (Not Me._RenameRightClick Is Nothing) Then
                    AddHandler Me._RenameRightClick.Click, New EventHandler(AddressOf Me.RenameRightClick_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImportaEsportaImpostazioniToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportaEsportaImpostazioniToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ImportaEsportaImpostazioniToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._ImportaEsportaImpostazioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.ImportaEsportaImpostazioniToolStripMenuItem_Click)
                End If
                Me._ImportaEsportaImpostazioniToolStripMenuItem = WithEventsValue
                If (Not Me._ImportaEsportaImpostazioniToolStripMenuItem Is Nothing) Then
                    AddHandler Me._ImportaEsportaImpostazioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.ImportaEsportaImpostazioniToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewDisplayPan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewDisplayPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._PreviewDisplayPan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AnteprimaVidStopButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnteprimaVidStopButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnteprimaVidStopButt Is Nothing) Then
                    RemoveHandler Me._AnteprimaVidStopButt.Click, New EventHandler(AddressOf Me.AnteprimaVidStopButt_Click)
                End If
                Me._AnteprimaVidStopButt = WithEventsValue
                If (Not Me._AnteprimaVidStopButt Is Nothing) Then
                    AddHandler Me._AnteprimaVidStopButt.Click, New EventHandler(AddressOf Me.AnteprimaVidStopButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AnteprimaVidPlayButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnteprimaVidPlayButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnteprimaVidPlayButt Is Nothing) Then
                    RemoveHandler Me._AnteprimaVidPlayButt.Click, New EventHandler(AddressOf Me.AnteprimaVidPlayButt_Click)
                End If
                Me._AnteprimaVidPlayButt = WithEventsValue
                If (Not Me._AnteprimaVidPlayButt Is Nothing) Then
                    AddHandler Me._AnteprimaVidPlayButt.Click, New EventHandler(AddressOf Me.AnteprimaVidPlayButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PreviewVideoPan As SplitContainer
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewVideoPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As SplitContainer)
                Me._PreviewVideoPan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FileToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FileToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._FileToolStripMenuItem1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property EliminaToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._EliminaToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._EliminaToolStripMenuItem1 Is Nothing) Then
                    RemoveHandler Me._EliminaToolStripMenuItem1.Click, New EventHandler(AddressOf Me.EliminaToolStripMenuItem1_Click_1)
                End If
                Me._EliminaToolStripMenuItem1 = WithEventsValue
                If (Not Me._EliminaToolStripMenuItem1 Is Nothing) Then
                    AddHandler Me._EliminaToolStripMenuItem1.Click, New EventHandler(AddressOf Me.EliminaToolStripMenuItem1_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property EsciToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._EsciToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._EsciToolStripMenuItem1 Is Nothing) Then
                    RemoveHandler Me._EsciToolStripMenuItem1.Click, New EventHandler(AddressOf Me.EsciToolStripMenuItem1_Click)
                End If
                Me._EsciToolStripMenuItem1 = WithEventsValue
                If (Not Me._EsciToolStripMenuItem1 Is Nothing) Then
                    AddHandler Me._EsciToolStripMenuItem1.Click, New EventHandler(AddressOf Me.EsciToolStripMenuItem1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OpenWithRightClick As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenWithRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OpenWithRightClick Is Nothing) Then
                    RemoveHandler Me._OpenWithRightClick.Click, New EventHandler(AddressOf Me.ApriConToolStripMenuItem_Click)
                End If
                Me._OpenWithRightClick = WithEventsValue
                If (Not Me._OpenWithRightClick Is Nothing) Then
                    AddHandler Me._OpenWithRightClick.Click, New EventHandler(AddressOf Me.ApriConToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OpenWithDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenWithDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                If (Not Me._OpenWithDial Is Nothing) Then
                    RemoveHandler Me._OpenWithDial.FileOk, New CancelEventHandler(AddressOf Me.OpenWithDial_FileOk)
                End If
                Me._OpenWithDial = WithEventsValue
                If (Not Me._OpenWithDial Is Nothing) Then
                    AddHandler Me._OpenWithDial.FileOk, New CancelEventHandler(AddressOf Me.OpenWithDial_FileOk)
                End If
            End Set
        End Property

        Friend Overridable Property CercaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._CercaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._CercaToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LeftRightClick As ContextMenuStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._LeftRightClick
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ContextMenuStrip)
                Me._LeftRightClick = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OrganizzaPreferitiToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OrganizzaPreferitiToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OrganizzaPreferitiToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._OrganizzaPreferitiToolStripMenuItem.Click, New EventHandler(AddressOf Me.OrganizzaPreferitiToolStripMenuItem_Click)
                End If
                Me._OrganizzaPreferitiToolStripMenuItem = WithEventsValue
                If (Not Me._OrganizzaPreferitiToolStripMenuItem Is Nothing) Then
                    AddHandler Me._OrganizzaPreferitiToolStripMenuItem.Click, New EventHandler(AddressOf Me.OrganizzaPreferitiToolStripMenuItem_Click)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("MainStrip")> _
        Private _MainStrip As ToolStrip
        <AccessedThroughProperty("ToolStripSplitButton2")> _
        Private _ToolStripSplitButton2 As ToolStripSplitButton
        <AccessedThroughProperty("ToolStripButton1")> _
        Private _ToolStripButton1 As ToolStripButton
        <AccessedThroughProperty("ToolStripButton4")> _
        Private _ToolStripButton4 As ToolStripButton
        <AccessedThroughProperty("DirectoryText")> _
        Private _DirectoryText As ToolStripTextBox
        <AccessedThroughProperty("ToolStripSplitButton1")> _
        Private _ToolStripSplitButton1 As ToolStripSplitButton
        <AccessedThroughProperty("InQuestaCartellaToolStripMenuItem")> _
        Private _InQuestaCartellaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("InQuestaCartellaESottocartelleToolStripMenuItem")> _
        Private _InQuestaCartellaESottocartelleToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("OvunqueToolStripMenuItem")> _
        Private _OvunqueToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripTextBox1")> _
        Private _ToolStripTextBox1 As ToolStripTextBox
        <AccessedThroughProperty("ToolStripButton2")> _
        Private _ToolStripButton2 As ToolStripButton
        <AccessedThroughProperty("StopButt")> _
        Private _StopButt As ToolStripButton
        <AccessedThroughProperty("MainMenu")> _
        Private _MainMenu As MenuStrip
        <AccessedThroughProperty("ModificaToolStripMenuItem")> _
        Private _ModificaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("CopiaToolStripMenuItem")> _
        Private _CopiaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("TagliaToolStripMenuItem")> _
        Private _TagliaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("IncollaToolStripMenuItem")> _
        Private _IncollaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("StrumentiToolStripMenuItem")> _
        Private _StrumentiToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("OpzioniToolStripMenuItem")> _
        Private _OpzioniToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem1")> _
        Private _ToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("InformazioniSuPowerExplorerToolStripMenuItem")> _
        Private _InformazioniSuPowerExplorerToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("BottomToolStripPanel")> _
        Private _BottomToolStripPanel As ToolStripPanel
        <AccessedThroughProperty("TopToolStripPanel")> _
        Private _TopToolStripPanel As ToolStripPanel
        <AccessedThroughProperty("RightToolStripPanel")> _
        Private _RightToolStripPanel As ToolStripPanel
        <AccessedThroughProperty("LeftToolStripPanel")> _
        Private _LeftToolStripPanel As ToolStripPanel
        <AccessedThroughProperty("ContentPanel")> _
        Private _ContentPanel As ToolStripContentPanel
        <AccessedThroughProperty("LeftLinkList")> _
        Private _LeftLinkList As ListBox
        <AccessedThroughProperty("StatoButt")> _
        Private _StatoButt As Button
        <AccessedThroughProperty("LeftFavouritesList")> _
        Private _LeftFavouritesList As ListBox
        <AccessedThroughProperty("ContentView")> _
        Private _ContentView As ListView
        <AccessedThroughProperty("ColumnHeader1")> _
        Private _ColumnHeader1 As ColumnHeader
        <AccessedThroughProperty("ColumnHeader2")> _
        Private _ColumnHeader2 As ColumnHeader
        <AccessedThroughProperty("MainStatus")> _
        Private _MainStatus As StatusStrip
        <AccessedThroughProperty("LeftImgList")> _
        Private _LeftImgList As ImageList
        <AccessedThroughProperty("StatusLab")> _
        Private _StatusLab As ToolStripStatusLabel
        <AccessedThroughProperty("NavigazioneToolStripMenuItem")> _
        Private _NavigazioneToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("LivelloSuperioreToolStripMenuItem")> _
        Private _LivelloSuperioreToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("HomeToolStripMenuItem")> _
        Private _HomeToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ContentImgList")> _
        Private _ContentImgList As ImageList
        <AccessedThroughProperty("CaricamentoProg")> _
        Private _CaricamentoProg As ToolStripProgressBar
        <AccessedThroughProperty("ContentRightClick")> _
        Private _ContentRightClick As ContextMenuStrip
        <AccessedThroughProperty("OpenRightClick")> _
        Private _OpenRightClick As ToolStripMenuItem
        <AccessedThroughProperty("RightDiv2")> _
        Private _RightDiv2 As ToolStripSeparator
        <AccessedThroughProperty("CopyRightClick")> _
        Private _CopyRightClick As ToolStripMenuItem
        <AccessedThroughProperty("CutRightClick")> _
        Private _CutRightClick As ToolStripMenuItem
        <AccessedThroughProperty("PasteRightClick")> _
        Private _PasteRightClick As ToolStripMenuItem
        <AccessedThroughProperty("RightDiv3")> _
        Private _RightDiv3 As ToolStripSeparator
        <AccessedThroughProperty("DeleteRightClick")> _
        Private _DeleteRightClick As ToolStripMenuItem
        <AccessedThroughProperty("PropertiesRightClick")> _
        Private _PropertiesRightClick As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem5")> _
        Private _ToolStripMenuItem5 As ToolStripSeparator
        <AccessedThroughProperty("SelezionaTuttoToolStripMenuItem")> _
        Private _SelezionaTuttoToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("UnitàLab")> _
        Private _UnitàLab As ToolStripStatusLabel
        <AccessedThroughProperty("Separatore1Lab")> _
        Private _Separatore1Lab As ToolStripStatusLabel
        <AccessedThroughProperty("DimensioniLab")> _
        Private _DimensioniLab As ToolStripStatusLabel
        <AccessedThroughProperty("Separatore2Lab")> _
        Private _Separatore2Lab As ToolStripStatusLabel
        <AccessedThroughProperty("NumeroFileLab")> _
        Private _NumeroFileLab As ToolStripStatusLabel
        <AccessedThroughProperty("NumeroCartelleLab")> _
        Private _NumeroCartelleLab As ToolStripStatusLabel
        <AccessedThroughProperty("Separatore3Lab")> _
        Private _Separatore3Lab As ToolStripStatusLabel
        <AccessedThroughProperty("AggiornaToolStripMenuItem")> _
        Private _AggiornaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("AnnullaCaricamentoToolStripMenuItem")> _
        Private _AnnullaCaricamentoToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem7")> _
        Private _ToolStripMenuItem7 As ToolStripSeparator
        <AccessedThroughProperty("NewRightClick")> _
        Private _NewRightClick As ToolStripMenuItem
        <AccessedThroughProperty("FolderRightClick")> _
        Private _FolderRightClick As ToolStripMenuItem
        <AccessedThroughProperty("SeparatoreTastoD")> _
        Private _SeparatoreTastoD As ToolStripSeparator
        <AccessedThroughProperty("CercaAggiornamentiToolStripMenuItem")> _
        Private _CercaAggiornamentiToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("PreviewText")> _
        Private _PreviewText As TextBox
        <AccessedThroughProperty("AnteprimaGroup")> _
        Private _AnteprimaGroup As GroupBox
        <AccessedThroughProperty("PreviewPicture")> _
        Private _PreviewPicture As PictureBox
        <AccessedThroughProperty("PreviewAudioPan")> _
        Private _PreviewAudioPan As Panel
        <AccessedThroughProperty("AnteprimaStopBut")> _
        Private _AnteprimaStopBut As Button
        <AccessedThroughProperty("AnteprimaPlayBut")> _
        Private _AnteprimaPlayBut As Button
        <AccessedThroughProperty("PreviewHtm")> _
        Private _PreviewHtm As WebBrowser
        <AccessedThroughProperty("FileRightClick")> _
        Private _FileRightClick As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem9")> _
        Private _ToolStripMenuItem9 As ToolStripMenuItem
        <AccessedThroughProperty("ColumnHeader3")> _
        Private _ColumnHeader3 As ColumnHeader
        <AccessedThroughProperty("FileSystemWatcher")> _
        Private _FileSystemWatcher As FileSystemWatcher
        <AccessedThroughProperty("SitoWebUfficialeToolStripMenuItem")> _
        Private _SitoWebUfficialeToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("FavouritesButt")> _
        Private _FavouritesButt As Button
        <AccessedThroughProperty("PreferitiToolStripMenuItem")> _
        Private _PreferitiToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("MainTimer")> _
        Private _MainTimer As Timer
        <AccessedThroughProperty("MessageLab")> _
        Private _MessageLab As Label
        <AccessedThroughProperty("Message2Lab")> _
        Private _Message2Lab As Label
        <AccessedThroughProperty("MessagePict")> _
        Private _MessagePict As PictureBox
        <AccessedThroughProperty("CronologiaToolStripMenuItem")> _
        Private _CronologiaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("OneToolStripMenuItem")> _
        Private _OneToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("TwoToolStripMenuItem")> _
        Private _TwoToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ThreeToolStripMenuItem")> _
        Private _ThreeToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("FourToolStripMenuItem")> _
        Private _FourToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("FiveToolStripMenuItem")> _
        Private _FiveToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("SixToolStripMenuItem")> _
        Private _SixToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("SevenToolStripMenuItem")> _
        Private _SevenToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("EightToolStripMenuItem")> _
        Private _EightToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("NineToolStripMenuItem")> _
        Private _NineToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("TenToolStripMenuItem")> _
        Private _TenToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("AntivirRightClick")> _
        Private _AntivirRightClick As ToolStripMenuItem
        <AccessedThroughProperty("RightDiv1")> _
        Private _RightDiv1 As ToolStripSeparator
        <AccessedThroughProperty("CompressRightClick")> _
        Private _CompressRightClick As ToolStripMenuItem
        <AccessedThroughProperty("DecompressRightClick")> _
        Private _DecompressRightClick As ToolStripMenuItem
        <AccessedThroughProperty("DecompressSubFolderRightClick")> _
        Private _DecompressSubFolderRightClick As ToolStripMenuItem
        <AccessedThroughProperty("RenameRightClick")> _
        Private _RenameRightClick As ToolStripMenuItem
        <AccessedThroughProperty("ImportaEsportaImpostazioniToolStripMenuItem")> _
        Private _ImportaEsportaImpostazioniToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("PreviewDisplayPan")> _
        Private _PreviewDisplayPan As Panel
        <AccessedThroughProperty("AnteprimaVidStopButt")> _
        Private _AnteprimaVidStopButt As Button
        <AccessedThroughProperty("AnteprimaVidPlayButt")> _
        Private _AnteprimaVidPlayButt As Button
        <AccessedThroughProperty("PreviewVideoPan")> _
        Private _PreviewVideoPan As SplitContainer
        <AccessedThroughProperty("FileToolStripMenuItem1")> _
        Private _FileToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("EliminaToolStripMenuItem1")> _
        Private _EliminaToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("EsciToolStripMenuItem1")> _
        Private _EsciToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("OpenWithRightClick")> _
        Private _OpenWithRightClick As ToolStripMenuItem
        <AccessedThroughProperty("OpenWithDial")> _
        Private _OpenWithDial As OpenFileDialog
        <AccessedThroughProperty("CercaToolStripMenuItem")> _
        Private _CercaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("LeftRightClick")> _
        Private _LeftRightClick As ContextMenuStrip
        <AccessedThroughProperty("OrganizzaPreferitiToolStripMenuItem")> _
        Private _OrganizzaPreferitiToolStripMenuItem As ToolStripMenuItem
        Private Stato As Byte
        Private Directory As String
        Private Interrotto As Boolean
        Private SoundFile As Audio
        Private VideoFile As Video
    End Class
End Namespace

