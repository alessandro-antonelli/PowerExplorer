Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Compress
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub BrowseButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.BrowseDial.InitialDirectory = Me.PathText.Text
            Me.BrowseDial.DefaultExt = If(Not Me.ZipRadio.Checked, "Archivio rar|.rar", "Archivio zip|.zip")
            Me.BrowseDial.ShowDialog
        End Sub

        Private Sub BrowseDial_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.PathText.Text = Me.BrowseDial.FileName
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Public Sub Compress()
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.PathText = New TextBox
            Me.BrowseButt = New Button
            Me.ZipRadio = New RadioButton
            Me.RarRadio = New RadioButton
            Me.OKButt = New Button
            Me.CancelButt = New Button
            Me.FormatLab = New Label
            Me.PathLab = New Label
            Me.BrowseDial = New SaveFileDialog
            Me.NameLab = New Label
            Me.NameText = New TextBox
            Me.SuspendLayout
            Dim point As New Point(12, &H19)
            Me.PathText.Location = point
            Me.PathText.Name = "PathText"
            Dim size As New Size(&HEF, 20)
            Me.PathText.Size = size
            Me.PathText.TabIndex = 0
            point = New Point(&H101, &H17)
            Me.BrowseButt.Location = point
            Me.BrowseButt.Name = "BrowseButt"
            size = New Size(&H4B, &H17)
            Me.BrowseButt.Size = size
            Me.BrowseButt.TabIndex = 1
            Me.BrowseButt.Text = "&Sfoglia..."
            Me.BrowseButt.UseVisualStyleBackColor = True
            Me.ZipRadio.AutoSize = True
            point = New Point(&H42, &H55)
            Me.ZipRadio.Location = point
            Me.ZipRadio.Name = "ZipRadio"
            size = New Size(&H2A, &H11)
            Me.ZipRadio.Size = size
            Me.ZipRadio.TabIndex = 2
            Me.ZipRadio.Text = "ZIP"
            Me.ZipRadio.UseVisualStyleBackColor = True
            Me.RarRadio.AutoSize = True
            Me.RarRadio.Checked = True
            point = New Point(&H42, &H6C)
            Me.RarRadio.Location = point
            Me.RarRadio.Name = "RarRadio"
            size = New Size(&H30, &H11)
            Me.RarRadio.Size = size
            Me.RarRadio.TabIndex = 3
            Me.RarRadio.TabStop = True
            Me.RarRadio.Text = "RAR"
            Me.RarRadio.UseVisualStyleBackColor = True
            point = New Point(&H101, &H85)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 4
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.CancelButt.DialogResult = DialogResult.Cancel
            point = New Point(&HB0, &H85)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 5
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.FormatLab.AutoSize = True
            point = New Point(12, &H57)
            Me.FormatLab.Location = point
            Me.FormatLab.Name = "FormatLab"
            size = New Size(&H30, 13)
            Me.FormatLab.Size = size
            Me.FormatLab.TabIndex = 7
            Me.FormatLab.Text = "Formato:"
            Me.PathLab.AutoSize = True
            point = New Point(12, 9)
            Me.PathLab.Location = point
            Me.PathLab.Name = "PathLab"
            size = New Size(&H56, 13)
            Me.PathLab.Size = size
            Me.PathLab.TabIndex = 8
            Me.PathLab.Text = "Comprimi il file in:"
            Me.NameLab.AutoSize = True
            point = New Point(12, &H30)
            Me.NameLab.Location = point
            Me.NameLab.Name = "NameLab"
            size = New Size(&H47, 13)
            Me.NameLab.Size = size
            Me.NameLab.TabIndex = 10
            Me.NameLab.Text = "Nome del file:"
            point = New Point(12, &H40)
            Me.NameText.Location = point
            Me.NameText.Name = "NameText"
            size = New Size(320, 20)
            Me.NameText.Size = size
            Me.NameText.TabIndex = 9
            Me.AcceptButton = Me.OKButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.CancelButt
            size = New Size(&H158, &HA8)
            Me.ClientSize = size
            Me.Controls.Add(Me.NameLab)
            Me.Controls.Add(Me.NameText)
            Me.Controls.Add(Me.PathLab)
            Me.Controls.Add(Me.FormatLab)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.RarRadio)
            Me.Controls.Add(Me.ZipRadio)
            Me.Controls.Add(Me.BrowseButt)
            Me.Controls.Add(Me.PathText)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Compress"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Comprimi file"
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub LoadInfo(ByVal ToCompress As String, ByVal Path As String)
            Me.File = ToCompress
            Me.PathText.Text = Path
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Compress
        End Sub


        ' Properties
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

        Friend Overridable Property BrowseButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._BrowseButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._BrowseButt Is Nothing) Then
                    RemoveHandler Me._BrowseButt.Click, New EventHandler(AddressOf Me.BrowseButt_Click)
                End If
                Me._BrowseButt = WithEventsValue
                If (Not Me._BrowseButt Is Nothing) Then
                    AddHandler Me._BrowseButt.Click, New EventHandler(AddressOf Me.BrowseButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ZipRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ZipRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._ZipRadio = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RarRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RarRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._RarRadio = WithEventsValue
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

        Friend Overridable Property CancelButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CancelButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CancelButt Is Nothing) Then
                    RemoveHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
                Me._CancelButt = WithEventsValue
                If (Not Me._CancelButt Is Nothing) Then
                    AddHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property FormatLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FormatLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FormatLab = WithEventsValue
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

        Friend Overridable Property BrowseDial As SaveFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._BrowseDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As SaveFileDialog)
                If (Not Me._BrowseDial Is Nothing) Then
                    RemoveHandler Me._BrowseDial.FileOk, New CancelEventHandler(AddressOf Me.BrowseDial_FileOk)
                End If
                Me._BrowseDial = WithEventsValue
                If (Not Me._BrowseDial Is Nothing) Then
                    AddHandler Me._BrowseDial.FileOk, New CancelEventHandler(AddressOf Me.BrowseDial_FileOk)
                End If
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


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("PathText")> _
        Private _PathText As TextBox
        <AccessedThroughProperty("BrowseButt")> _
        Private _BrowseButt As Button
        <AccessedThroughProperty("ZipRadio")> _
        Private _ZipRadio As RadioButton
        <AccessedThroughProperty("RarRadio")> _
        Private _RarRadio As RadioButton
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("FormatLab")> _
        Private _FormatLab As Label
        <AccessedThroughProperty("PathLab")> _
        Private _PathLab As Label
        <AccessedThroughProperty("BrowseDial")> _
        Private _BrowseDial As SaveFileDialog
        <AccessedThroughProperty("NameLab")> _
        Private _NameLab As Label
        <AccessedThroughProperty("NameText")> _
        Private _NameText As TextBox
        Private File As String
    End Class
End Namespace

