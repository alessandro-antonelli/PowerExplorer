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
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Delete
        Inherits Form
        ' Methods
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub AnnullaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub CestinoButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.IsFolder Then
                MyProject.Computer.FileSystem.DeleteDirectory(Me.Path, DirectCast(5, UIOption), RecycleOption.SendToRecycleBin)
            Else
                MyProject.Computer.FileSystem.DeleteFile(Me.Path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
            End If
            Me.Close
            MyProject.Forms.Main.ContentView.Items.Remove(MyProject.Forms.Main.ContentView.SelectedItems(0))
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EliminaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.IsFolder Then
                MyProject.Computer.FileSystem.DeleteDirectory(Me.Path, DeleteDirectoryOption.DeleteAllContents)
            Else
                MyProject.Computer.FileSystem.DeleteFile(Me.Path, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
            Me.Close
            MyProject.Forms.Main.ContentView.Items.Remove(MyProject.Forms.Main.ContentView.SelectedItems(0))
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.Label1 = New Label
            Me.EliminaButt = New Button
            Me.CestinoButt = New Button
            Me.AnnullaButt = New Button
            Me.PictureBox1 = New PictureBox
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Dim point As New Point(&H52, &H1D)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            Dim size As New Size(300, &H1F)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Vuoi spostare la cartella nel cestino o vuoi eliminarla definitivamente?"
            Me.EliminaButt.Anchor = AnchorStyles.None
            Me.EliminaButt.DialogResult = DialogResult.Cancel
            point = New Point(&HE2, &H53)
            Me.EliminaButt.Location = point
            Me.EliminaButt.Name = "EliminaButt"
            size = New Size(&H4B, &H17)
            Me.EliminaButt.Size = size
            Me.EliminaButt.TabIndex = 2
            Me.EliminaButt.Text = "&Elimina"
            Me.CestinoButt.Anchor = AnchorStyles.None
            point = New Point(&H91, &H53)
            Me.CestinoButt.Location = point
            Me.CestinoButt.Name = "CestinoButt"
            size = New Size(&H4B, &H17)
            Me.CestinoButt.Size = size
            Me.CestinoButt.TabIndex = 1
            Me.CestinoButt.Text = "&Cestino"
            Me.AnnullaButt.Anchor = AnchorStyles.None
            Me.AnnullaButt.DialogResult = DialogResult.Cancel
            point = New Point(&H133, &H53)
            Me.AnnullaButt.Location = point
            Me.AnnullaButt.Name = "AnnullaButt"
            size = New Size(&H4B, &H17)
            Me.AnnullaButt.Size = size
            Me.AnnullaButt.TabIndex = 3
            Me.AnnullaButt.Text = "&Annulla"
            Me.PictureBox1.Image = Resources.trashcan_full_128
            point = New Point(12, 12)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(&H40, &H40)
            Me.PictureBox1.Size = size
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H18A, &H76)
            Me.ClientSize = size
            Me.Controls.Add(Me.EliminaButt)
            Me.Controls.Add(Me.CestinoButt)
            Me.Controls.Add(Me.AnnullaButt)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Delete"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Elimina"
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadInfo(ByVal Percorso As String, ByVal Folder As Boolean)
            Me.Path = Percorso
            Me.IsFolder = Folder
            If (MyProject.Computer.FileSystem.GetDriveInfo((Conversions.ToString(Me.Path(0)) & ":")).DriveType = DriveType.Fixed) Then
                Me.IsFixed = True
                Me.CestinoButt.Visible = True
            Else
                Me.IsFixed = False
                Me.CestinoButt.Visible = False
            End If
            If Me.IsFolder Then
                If Not Me.IsFixed Then
                    Me.Label1.Text = "Vuoi eliminare definitivamente la cartella?"
                    Me.EliminaButt.Text = "&Sì"
                Else
                    Me.Label1.Text = "Vuoi spostare la cartella nel cestino o vuoi eliminarla definitivamente?"
                    Me.EliminaButt.Text = "&Elimina"
                End If
            ElseIf Not Me.IsFixed Then
                Me.Label1.Text = "Vuoi eliminare definitivamente il file?"
                Me.EliminaButt.Text = "&Sì"
            Else
                Me.Label1.Text = "Vuoi spostare il file nel cestino o vuoi eliminarlo definitivamente?"
                Me.EliminaButt.Text = "&Elimina"
            End If
        End Sub


        ' Properties
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

        Friend Overridable Property PictureBox1 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property EliminaButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._EliminaButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._EliminaButt Is Nothing) Then
                    RemoveHandler Me._EliminaButt.Click, New EventHandler(AddressOf Me.EliminaButt_Click)
                End If
                Me._EliminaButt = WithEventsValue
                If (Not Me._EliminaButt Is Nothing) Then
                    AddHandler Me._EliminaButt.Click, New EventHandler(AddressOf Me.EliminaButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property CestinoButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CestinoButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CestinoButt Is Nothing) Then
                    RemoveHandler Me._CestinoButt.Click, New EventHandler(AddressOf Me.CestinoButt_Click)
                End If
                Me._CestinoButt = WithEventsValue
                If (Not Me._CestinoButt Is Nothing) Then
                    AddHandler Me._CestinoButt.Click, New EventHandler(AddressOf Me.CestinoButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AnnullaButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnnullaButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnnullaButt Is Nothing) Then
                    RemoveHandler Me._AnnullaButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
                Me._AnnullaButt = WithEventsValue
                If (Not Me._AnnullaButt Is Nothing) Then
                    AddHandler Me._AnnullaButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("EliminaButt")> _
        Private _EliminaButt As Button
        <AccessedThroughProperty("CestinoButt")> _
        Private _CestinoButt As Button
        <AccessedThroughProperty("AnnullaButt")> _
        Private _AnnullaButt As Button
        Private Path As String
        Private IsFolder As Boolean
        Private IsFixed As Boolean = False
    End Class
End Namespace

