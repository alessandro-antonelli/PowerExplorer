Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
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
    Public Class History
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.FormClosing, New FormClosingEventHandler(AddressOf Me.History_FormClosing)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Chronology_Load)
            Me.InitializeComponent
        End Sub

        Private Sub Chronology_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadChronology
            Me.ChronologyWatcher.EnableRaisingEvents = True
            Me.ChronologyWatcher.Path = Application.StartupPath
        End Sub

        Private Sub ChronologyView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.ChronologyView.SelectedItems.Count <> 0) Then
                MyProject.Forms.Main.Go(Me.ChronologyView.SelectedItems(0).Text, True)
                MyProject.Forms.Main.Focus
            End If
        End Sub

        Private Sub ChronologyWatcher_Changed(ByVal sender As Object, ByVal e As FileSystemEventArgs)
            Me.LoadChronology
        End Sub

        Private Sub DeleteButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Chronology.txt")) AndAlso (MessageBox.Show("Vuoi davvero cancellare la cronologia? In seguito, non sarà più possibile recuperare questi dati.", "Cancellare?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No)) Then
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Chronology.txt"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                Me.LoadChronology
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub History_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Me.ChronologyWatcher.EnableRaisingEvents = False
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(History))
            Me.DeleteButt = New Button
            Me.OKButt = New Button
            Me.ChronologyView = New ListView
            Me.PathCol = New ColumnHeader
            Me.DateCol = New ColumnHeader
            Me.ChronologyWatcher = New FileSystemWatcher
            Me.ChronologyWatcher.BeginInit
            Me.SuspendLayout
            Me.DeleteButt.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            Dim point As New Point(12, &HE7)
            Me.DeleteButt.Location = point
            Me.DeleteButt.Name = "DeleteButt"
            Dim size As New Size(&H7F, &H17)
            Me.DeleteButt.Size = size
            Me.DeleteButt.TabIndex = 3
            Me.DeleteButt.Text = "Cancella la cronologia"
            Me.DeleteButt.UseVisualStyleBackColor = True
            Me.OKButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H163, &HE7)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 5
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.ChronologyView.AllowColumnReorder = True
            Me.ChronologyView.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Dim values As ColumnHeader() = New ColumnHeader() { Me.PathCol, Me.DateCol }
            Me.ChronologyView.Columns.AddRange(values)
            Me.ChronologyView.FullRowSelect = True
            point = New Point(12, 12)
            Me.ChronologyView.Location = point
            Me.ChronologyView.Name = "ChronologyView"
            size = New Size(&H1A2, &HD5)
            Me.ChronologyView.Size = size
            Me.ChronologyView.TabIndex = 7
            Me.ChronologyView.UseCompatibleStateImageBehavior = False
            Me.ChronologyView.View = View.Details
            Me.PathCol.Text = "Percorso"
            Me.PathCol.Width = 300
            Me.DateCol.Text = "Data"
            Me.DateCol.Width = 100
            Me.ChronologyWatcher.EnableRaisingEvents = True
            Me.ChronologyWatcher.Filter = "Chronology.txt"
            Me.ChronologyWatcher.NotifyFilter = NotifyFilters.LastWrite
            Me.ChronologyWatcher.SynchronizingObject = Me
            Me.AcceptButton = Me.OKButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1BA, &H10A)
            Me.ClientSize = size
            Me.Controls.Add(Me.ChronologyView)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.DeleteButt)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "History"
            Me.Text = "Cronologia"
            Me.ChronologyWatcher.EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadChronology()
            Me.ChronologyView.Items.Clear
            If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Chronology.txt")) Then
                Dim reader As New StreamReader((Application.StartupPath & "\Chronology.txt"))
                Do While True
                    Dim str As String = reader.ReadLine
                    Dim item2 As New ListViewItem
                    Dim item As New ListViewSubItem
                    item2.Text = str.Remove(str.LastIndexOf("|"), (str.Length - str.LastIndexOf("|")))
                    item.Text = str.Remove(0, (str.LastIndexOf("|") + 1))
                    item2.SubItems.Add(item)
                    Me.ChronologyView.Items.Add(item2)
                    If reader.EndOfStream Then
                        reader.Close
                        Return
                    End If
                Loop
            End If
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub


        ' Properties
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

        Friend Overridable Property OKButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._OKButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._OKButt Is Nothing) Then
                    RemoveHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
                Me._OKButt = WithEventsValue
                If (Not Me._OKButt Is Nothing) Then
                    AddHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ChronologyView As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._ChronologyView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._ChronologyView Is Nothing) Then
                    RemoveHandler Me._ChronologyView.DoubleClick, New EventHandler(AddressOf Me.ChronologyView_DoubleClick)
                End If
                Me._ChronologyView = WithEventsValue
                If (Not Me._ChronologyView Is Nothing) Then
                    AddHandler Me._ChronologyView.DoubleClick, New EventHandler(AddressOf Me.ChronologyView_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property PathCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._PathCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._PathCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DateCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._DateCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._DateCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ChronologyWatcher As FileSystemWatcher
            <DebuggerNonUserCode> _
            Get
                Return Me._ChronologyWatcher
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FileSystemWatcher)
                If (Not Me._ChronologyWatcher Is Nothing) Then
                    RemoveHandler Me._ChronologyWatcher.Changed, New FileSystemEventHandler(AddressOf Me.ChronologyWatcher_Changed)
                End If
                Me._ChronologyWatcher = WithEventsValue
                If (Not Me._ChronologyWatcher Is Nothing) Then
                    AddHandler Me._ChronologyWatcher.Changed, New FileSystemEventHandler(AddressOf Me.ChronologyWatcher_Changed)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("DeleteButt")> _
        Private _DeleteButt As Button
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("ChronologyView")> _
        Private _ChronologyView As ListView
        <AccessedThroughProperty("PathCol")> _
        Private _PathCol As ColumnHeader
        <AccessedThroughProperty("DateCol")> _
        Private _DateCol As ColumnHeader
        <AccessedThroughProperty("ChronologyWatcher")> _
        Private _ChronologyWatcher As FileSystemWatcher
    End Class
End Namespace

