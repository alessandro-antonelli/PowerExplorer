Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Explorer.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Favourites
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Favourites_Load)
            Me.InitializeComponent
        End Sub

        Private Sub AddButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Interaction.InputBox("Inserire il percorso del nuovo preferito:", "Inserire il percorso", "", -1, -1)
            Dim str3 As String = Interaction.InputBox("Inserire il nome da visualizzare:", "Inserire il nome", "", -1, -1)
            If Not MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Favourites.txt")) Then
                Dim writer2 As New StreamWriter((Application.StartupPath & "\Favourites.txt"), False)
                writer2.Write("1")
                writer2.WriteLine
                writer2.Write((str & "|" & str3))
                writer2.Close
                Me.LoadFavourites
                MyProject.Forms.Main.LoadFavourites
            Else
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                reader.Close
                Dim writer As New StreamWriter((Application.StartupPath & "\Favourites.txt"), False)
                writer.Write(CSng((Conversions.ToSingle(reader.ReadLine) + 1!)))
                writer.WriteLine
                writer.Write(reader.ReadToEnd)
                writer.WriteLine
                writer.Write((str & "|" & str3))
                writer.Close
                Me.LoadFavourites
                MyProject.Forms.Main.LoadFavourites
            End If
        End Sub

        Private Sub DeleteButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.FavouritesList.SelectedItems.Count <> Conversions.ToDouble("0")) Then
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim writer As New StreamWriter((Application.StartupPath & "\Temp.txt"), False)
                Dim num As Short = Conversions.ToShort(reader.ReadLine)
                writer.Write(CInt((num - 1)))
                writer.WriteLine
                Dim num3 As Short = CShort((Me.FavouritesList.SelectedIndex - 1))
                Dim i As Short = 0
                Do While (i <= num3)
                    writer.Write(reader.ReadLine)
                    If (i <> (num - 1)) Then
                        writer.WriteLine
                    End If
                    i = CShort((i + 1))
                Loop
                reader.ReadLine
                writer.Write(reader.ReadToEnd)
                reader.Close
                writer.Close
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Favourites.txt"))
                MyProject.Computer.FileSystem.RenameFile((Application.StartupPath & "\Temp.txt"), "Favourites.txt")
                Me.LoadFavourites
                MyProject.Forms.Main.LoadFavourites
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub Favourites_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadFavourites
        End Sub

        Private Sub FavouritesList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                reader.ReadLine
                Dim num2 As Short = CShort((Me.FavouritesList.SelectedIndex - 1))
                Dim num As Short = 0
                Do While True
                    If (num > num2) Then
                        Dim str As String = reader.ReadLine
                        reader.Close
                        Me.NameText.Text = str.Remove(0, (str.LastIndexOf("|") + 1))
                        Me.PathText.Text = str.Remove(str.LastIndexOf("|"), (str.Length - str.LastIndexOf("|")))
                        Exit Do
                    End If
                    reader.ReadLine
                    num = CShort((num + 1))
                Loop
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                Me.NameText.Text = ""
                Me.PathText.Text = ""
                ProjectData.ClearProjectError
            End Try
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Favourites))
            Me.FavouritesList = New ListBox
            Me.InfoGroup = New GroupBox
            Me.SaveButt = New Button
            Me.PathText = New TextBox
            Me.NameText = New TextBox
            Me.PathLab = New Label
            Me.NameLab = New Label
            Me.ButtonsImg = New ImageList(Me.components)
            Me.AddButt = New Button
            Me.DeleteButt = New Button
            Me.MoveDownButt = New Button
            Me.MoveUpButt = New Button
            Me.InfoGroup.SuspendLayout
            Me.SuspendLayout
            Me.FavouritesList.FormattingEnabled = True
            Dim point As New Point(12, 12)
            Me.FavouritesList.Location = point
            Me.FavouritesList.Name = "FavouritesList"
            Dim size As New Size(&H145, &H86)
            Me.FavouritesList.Size = size
            Me.FavouritesList.TabIndex = 0
            Me.InfoGroup.Controls.Add(Me.SaveButt)
            Me.InfoGroup.Controls.Add(Me.PathText)
            Me.InfoGroup.Controls.Add(Me.NameText)
            Me.InfoGroup.Controls.Add(Me.PathLab)
            Me.InfoGroup.Controls.Add(Me.NameLab)
            point = New Point(12, &H9E)
            Me.InfoGroup.Location = point
            Me.InfoGroup.Name = "InfoGroup"
            size = New Size(&H1A2, &H60)
            Me.InfoGroup.Size = size
            Me.InfoGroup.TabIndex = 1
            Me.InfoGroup.TabStop = False
            Me.InfoGroup.Text = "Dettagli"
            point = New Point(&H151, &H43)
            Me.SaveButt.Location = point
            Me.SaveButt.Name = "SaveButt"
            size = New Size(&H4B, &H17)
            Me.SaveButt.Size = size
            Me.SaveButt.TabIndex = 5
            Me.SaveButt.Text = "&Salva"
            Me.SaveButt.UseVisualStyleBackColor = True
            point = New Point(&H3D, &H27)
            Me.PathText.Location = point
            Me.PathText.Name = "PathText"
            size = New Size(&H15F, 20)
            Me.PathText.Size = size
            Me.PathText.TabIndex = 4
            point = New Point(&H3D, 13)
            Me.NameText.Location = point
            Me.NameText.Name = "NameText"
            size = New Size(&H15F, 20)
            Me.NameText.Size = size
            Me.NameText.TabIndex = 3
            Me.PathLab.AutoSize = True
            point = New Point(6, &H2A)
            Me.PathLab.Location = point
            Me.PathLab.Name = "PathLab"
            size = New Size(&H31, 13)
            Me.PathLab.Size = size
            Me.PathLab.TabIndex = 1
            Me.PathLab.Text = "Percorso"
            Me.NameLab.AutoSize = True
            point = New Point(6, &H10)
            Me.NameLab.Location = point
            Me.NameLab.Name = "NameLab"
            size = New Size(&H23, 13)
            Me.NameLab.Size = size
            Me.NameLab.TabIndex = 0
            Me.NameLab.Text = "Nome"
            Me.ButtonsImg.ImageStream = DirectCast(manager.GetObject("ButtonsImg.ImageStream"), ImageListStreamer)
            Me.ButtonsImg.TransparentColor = Color.Transparent
            Me.ButtonsImg.Images.SetKeyName(0, "viewmag-.png")
            Me.ButtonsImg.Images.SetKeyName(1, "down.png")
            Me.ButtonsImg.Images.SetKeyName(2, "up.png")
            Me.ButtonsImg.Images.SetKeyName(3, "viewmag+.png")
            Me.AddButt.ImageAlign = ContentAlignment.MiddleLeft
            Me.AddButt.ImageKey = "viewmag+.png"
            Me.AddButt.ImageList = Me.ButtonsImg
            point = New Point(&H157, &H7B)
            Me.AddButt.Location = point
            Me.AddButt.Name = "AddButt"
            size = New Size(&H57, &H17)
            Me.AddButt.Size = size
            Me.AddButt.TabIndex = 5
            Me.AddButt.Text = "&Aggiungi..."
            Me.AddButt.TextImageRelation = TextImageRelation.ImageBeforeText
            Me.AddButt.UseVisualStyleBackColor = True
            Me.DeleteButt.ImageAlign = ContentAlignment.MiddleLeft
            Me.DeleteButt.ImageKey = "viewmag-.png"
            Me.DeleteButt.ImageList = Me.ButtonsImg
            point = New Point(&H157, 70)
            Me.DeleteButt.Location = point
            Me.DeleteButt.Name = "DeleteButt"
            size = New Size(&H57, &H17)
            Me.DeleteButt.Size = size
            Me.DeleteButt.TabIndex = 4
            Me.DeleteButt.Text = "&Elimina"
            Me.DeleteButt.TextImageRelation = TextImageRelation.ImageBeforeText
            Me.DeleteButt.UseVisualStyleBackColor = True
            Me.MoveDownButt.ImageAlign = ContentAlignment.MiddleLeft
            Me.MoveDownButt.ImageKey = "down.png"
            Me.MoveDownButt.ImageList = Me.ButtonsImg
            point = New Point(&H157, &H29)
            Me.MoveDownButt.Location = point
            Me.MoveDownButt.Name = "MoveDownButt"
            size = New Size(&H57, &H17)
            Me.MoveDownButt.Size = size
            Me.MoveDownButt.TabIndex = 3
            Me.MoveDownButt.Text = "Sposta &giù"
            Me.MoveDownButt.TextImageRelation = TextImageRelation.ImageBeforeText
            Me.MoveDownButt.UseVisualStyleBackColor = True
            Me.MoveUpButt.ImageAlign = ContentAlignment.MiddleLeft
            Me.MoveUpButt.ImageKey = "up.png"
            Me.MoveUpButt.ImageList = Me.ButtonsImg
            point = New Point(&H157, 12)
            Me.MoveUpButt.Location = point
            Me.MoveUpButt.Name = "MoveUpButt"
            size = New Size(&H57, &H17)
            Me.MoveUpButt.Size = size
            Me.MoveUpButt.TabIndex = 2
            Me.MoveUpButt.Text = "Sposta &su"
            Me.MoveUpButt.TextImageRelation = TextImageRelation.ImageBeforeText
            Me.MoveUpButt.UseVisualStyleBackColor = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1BA, &H10A)
            Me.ClientSize = size
            Me.Controls.Add(Me.AddButt)
            Me.Controls.Add(Me.DeleteButt)
            Me.Controls.Add(Me.MoveDownButt)
            Me.Controls.Add(Me.MoveUpButt)
            Me.Controls.Add(Me.InfoGroup)
            Me.Controls.Add(Me.FavouritesList)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.Name = "Favourites"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "Gestione preferiti"
            Me.InfoGroup.ResumeLayout(False)
            Me.InfoGroup.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadFavourites()
            If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Favourites.txt")) Then
                Me.FavouritesList.Items.Clear
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim num3 As Single = Conversions.ToSingle(reader.ReadLine)
                Dim i As Single = 1!
                Do While (i <= num3)
                    Dim str As String = reader.ReadLine
                    Dim count As Short = CShort((str.LastIndexOf("|") + 1))
                    Me.FavouritesList.Items.Add(str.Remove(0, count))
                    i += 1
                Loop
                reader.Close
            End If
        End Sub

        Private Sub MoveDownButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If ((Me.FavouritesList.SelectedItems.Count <> Conversions.ToDouble("0")) AndAlso ((Me.FavouritesList.SelectedIndex + 1) <> Me.FavouritesList.Items.Count)) Then
                Dim selectedIndex As Short = CShort(Me.FavouritesList.SelectedIndex)
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim writer As New StreamWriter((Application.StartupPath & "\Temp.txt"), False)
                writer.Write(CInt(Conversions.ToShort(reader.ReadLine)))
                writer.WriteLine
                Dim num4 As Short = CShort((Me.FavouritesList.SelectedIndex - 1))
                Dim i As Short = 0
                Do While (i <= num4)
                    writer.Write(reader.ReadLine)
                    writer.WriteLine
                    i = CShort((i + 1))
                Loop
                writer.Write(reader.ReadLine)
                writer.WriteLine
                writer.Write(reader.ReadLine)
                If Not reader.EndOfStream Then
                    writer.WriteLine
                End If
                writer.Write(reader.ReadToEnd)
                reader.Close
                writer.Close
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Favourites.txt"))
                MyProject.Computer.FileSystem.RenameFile((Application.StartupPath & "\Temp.txt"), "Favourites.txt")
                Me.LoadFavourites
                Me.FavouritesList.SelectedIndex = (selectedIndex + 1)
                MyProject.Forms.Main.LoadFavourites
            End If
        End Sub

        Private Sub MoveUpButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If ((Me.FavouritesList.SelectedItems.Count <> Conversions.ToDouble("0")) AndAlso (Me.FavouritesList.SelectedIndex <> Conversions.ToDouble("0"))) Then
                Dim selectedIndex As Short = CShort(Me.FavouritesList.SelectedIndex)
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim writer As New StreamWriter((Application.StartupPath & "\Temp.txt"), False)
                writer.Write(CInt(Conversions.ToShort(reader.ReadLine)))
                writer.WriteLine
                Dim num4 As Short = CShort((Me.FavouritesList.SelectedIndex - 2))
                Dim i As Short = 0
                Do While (i <= num4)
                    writer.Write(reader.ReadLine)
                    writer.WriteLine
                    i = CShort((i + 1))
                Loop
                writer.Write((Me.PathText.Text & "|" & Me.NameText.Text))
                writer.WriteLine
                writer.Write(reader.ReadLine)
                reader.ReadLine
                If Not reader.EndOfStream Then
                    writer.WriteLine
                End If
                writer.Write(reader.ReadToEnd)
                reader.Close
                writer.Close
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Favourites.txt"))
                MyProject.Computer.FileSystem.RenameFile((Application.StartupPath & "\Temp.txt"), "Favourites.txt")
                Me.LoadFavourites
                Me.FavouritesList.SelectedIndex = (selectedIndex - 1)
                MyProject.Forms.Main.LoadFavourites
            End If
        End Sub

        Private Sub SaveButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (((Me.FavouritesList.SelectedItems.Count <> Conversions.ToDouble("0")) AndAlso (Me.NameText.Text <> "")) AndAlso (Me.PathText.Text <> "")) Then
                Dim str2 As String
                Dim reader As New StreamReader((Application.StartupPath & "\Favourites.txt"))
                Dim num As Single = Conversions.ToSingle(reader.ReadLine)
                Dim num3 As Short = CShort((Me.FavouritesList.SelectedIndex - 1))
                Dim i As Short = 0
                Do While (i <= num3)
                    str2 = (str2 & reader.ReadLine)
                    i = CShort((i + 1))
                Loop
                reader.ReadLine
                reader.Close
                Dim writer As New StreamWriter((Application.StartupPath & "\Favourites.txt"), False)
                writer.Write(num)
                writer.WriteLine
                writer.Write(str2)
                writer.WriteLine
                writer.Write((Me.PathText.Text & "|" & Me.NameText.Text))
                writer.WriteLine
                writer.Write(reader.ReadToEnd)
                writer.Close
                Me.LoadFavourites
                MyProject.Forms.Main.LoadFavourites
            End If
        End Sub


        ' Properties
        Friend Overridable Property FavouritesList As ListBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FavouritesList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListBox)
                If (Not Me._FavouritesList Is Nothing) Then
                    RemoveHandler Me._FavouritesList.SelectedIndexChanged, New EventHandler(AddressOf Me.FavouritesList_SelectedIndexChanged)
                End If
                Me._FavouritesList = WithEventsValue
                If (Not Me._FavouritesList Is Nothing) Then
                    AddHandler Me._FavouritesList.SelectedIndexChanged, New EventHandler(AddressOf Me.FavouritesList_SelectedIndexChanged)
                End If
            End Set
        End Property

        Friend Overridable Property InfoGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._InfoGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PathText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PathText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._PathText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NameText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._NameText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._NameText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PathLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PathLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PathLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NameLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._NameLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._NameLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MoveUpButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._MoveUpButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._MoveUpButt Is Nothing) Then
                    RemoveHandler Me._MoveUpButt.Click, New EventHandler(AddressOf Me.MoveUpButt_Click)
                End If
                Me._MoveUpButt = WithEventsValue
                If (Not Me._MoveUpButt Is Nothing) Then
                    AddHandler Me._MoveUpButt.Click, New EventHandler(AddressOf Me.MoveUpButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property MoveDownButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._MoveDownButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._MoveDownButt Is Nothing) Then
                    RemoveHandler Me._MoveDownButt.Click, New EventHandler(AddressOf Me.MoveDownButt_Click)
                End If
                Me._MoveDownButt = WithEventsValue
                If (Not Me._MoveDownButt Is Nothing) Then
                    AddHandler Me._MoveDownButt.Click, New EventHandler(AddressOf Me.MoveDownButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property DeleteButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._DeleteButt Is Nothing) Then
                    RemoveHandler Me._DeleteButt.Click, New EventHandler(AddressOf Me.DeleteButt_Click)
                End If
                Me._DeleteButt = WithEventsValue
                If (Not Me._DeleteButt Is Nothing) Then
                    AddHandler Me._DeleteButt.Click, New EventHandler(AddressOf Me.DeleteButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property SaveButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._SaveButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._SaveButt Is Nothing) Then
                    RemoveHandler Me._SaveButt.Click, New EventHandler(AddressOf Me.SaveButt_Click)
                End If
                Me._SaveButt = WithEventsValue
                If (Not Me._SaveButt Is Nothing) Then
                    AddHandler Me._SaveButt.Click, New EventHandler(AddressOf Me.SaveButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ButtonsImg As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._ButtonsImg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._ButtonsImg = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AddButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AddButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AddButt Is Nothing) Then
                    RemoveHandler Me._AddButt.Click, New EventHandler(AddressOf Me.AddButt_Click)
                End If
                Me._AddButt = WithEventsValue
                If (Not Me._AddButt Is Nothing) Then
                    AddHandler Me._AddButt.Click, New EventHandler(AddressOf Me.AddButt_Click)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("FavouritesList")> _
        Private _FavouritesList As ListBox
        <AccessedThroughProperty("InfoGroup")> _
        Private _InfoGroup As GroupBox
        <AccessedThroughProperty("PathText")> _
        Private _PathText As TextBox
        <AccessedThroughProperty("NameText")> _
        Private _NameText As TextBox
        <AccessedThroughProperty("PathLab")> _
        Private _PathLab As Label
        <AccessedThroughProperty("NameLab")> _
        Private _NameLab As Label
        <AccessedThroughProperty("MoveUpButt")> _
        Private _MoveUpButt As Button
        <AccessedThroughProperty("MoveDownButt")> _
        Private _MoveDownButt As Button
        <AccessedThroughProperty("DeleteButt")> _
        Private _DeleteButt As Button
        <AccessedThroughProperty("SaveButt")> _
        Private _SaveButt As Button
        <AccessedThroughProperty("ButtonsImg")> _
        Private _ButtonsImg As ImageList
        <AccessedThroughProperty("AddButt")> _
        Private _AddButt As Button
    End Class
End Namespace

