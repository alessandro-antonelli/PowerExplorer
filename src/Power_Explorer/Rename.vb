Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Explorer.My
Imports Power_Explorer.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Rename
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub AnnullaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EstensioneText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.NameChanged
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(Rename))
            Me.NameText = New TextBox
            Me.EstensioneText = New TextBox
            Me.OldNameLab1 = New Label
            Me.OKButt = New Button
            Me.CancelButt = New Button
            Me.RenameLab = New Label
            Me.Mess1Lab = New Label
            Me.Mess2Lab = New Label
            Me.OldNameText = New TextBox
            Me.MessPict = New PictureBox
            Me.RenamePict = New PictureBox
            DirectCast(Me.MessPict, ISupportInitialize).BeginInit
            DirectCast(Me.RenamePict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.NameText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Dim point As New Point(&H52, &H1C)
            Me.NameText.Location = point
            Me.NameText.Name = "NameText"
            Dim size As New Size(350, 20)
            Me.NameText.Size = size
            Me.NameText.TabIndex = 0
            Me.EstensioneText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&H52, &H36)
            Me.EstensioneText.Location = point
            Me.EstensioneText.Name = "EstensioneText"
            size = New Size(&HAF, 20)
            Me.EstensioneText.Size = size
            Me.EstensioneText.TabIndex = 1
            Me.OldNameLab1.AutoSize = True
            Me.OldNameLab1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(9, &H4F)
            Me.OldNameLab1.Location = point
            Me.OldNameLab1.Name = "OldNameLab1"
            size = New Size(&H56, 13)
            Me.OldNameLab1.Size = size
            Me.OldNameLab1.TabIndex = 2
            Me.OldNameLab1.Text = "Nome attuale:"
            Me.OKButt.DialogResult = DialogResult.Cancel
            point = New Point(&H165, &H71)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 5
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.CancelButt.DialogResult = DialogResult.Cancel
            point = New Point(&H114, &H71)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 6
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.RenameLab.AutoSize = True
            point = New Point(&H52, 12)
            Me.RenameLab.Location = point
            Me.RenameLab.Name = "RenameLab"
            size = New Size(&HA3, 13)
            Me.RenameLab.Size = size
            Me.RenameLab.TabIndex = 7
            Me.RenameLab.Text = "Inserire qui il nuovo nome del file:"
            Me.Mess1Lab.AutoSize = True
            Me.Mess1Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H1A, &H6D)
            Me.Mess1Lab.Location = point
            Me.Mess1Lab.Name = "Mess1Lab"
            size = New Size(&HCF, 13)
            Me.Mess1Lab.Size = size
            Me.Mess1Lab.TabIndex = 9
            Me.Mess1Lab.Text = "Impossibile assegnare questo nome"
            Me.Mess1Lab.Visible = False
            Me.Mess2Lab.AutoSize = True
            point = New Point(&H1A, &H7E)
            Me.Mess2Lab.Location = point
            size = New Size(420, 13)
            Me.Mess2Lab.MaximumSize = size
            Me.Mess2Lab.Name = "Mess2Lab"
            size = New Size(50, 13)
            Me.Mess2Lab.Size = size
            Me.Mess2Lab.TabIndex = 10
            Me.Mess2Lab.Text = "Message"
            Me.Mess2Lab.Visible = False
            Me.OldNameText.Anchor = (AnchorStyles.Right Or AnchorStyles.Left)
            Me.OldNameText.BackColor = SystemColors.Control
            Me.OldNameText.BorderStyle = BorderStyle.None
            point = New Point(&H5F, &H4F)
            Me.OldNameText.Location = point
            Me.OldNameText.Multiline = True
            Me.OldNameText.Name = "OldNameText"
            Me.OldNameText.ReadOnly = True
            size = New Size(&H151, &H1A)
            Me.OldNameText.Size = size
            Me.OldNameText.TabIndex = 11
            Me.OldNameText.Text = "Lorem.ipsum"
            Me.MessPict.Image = Resources.cancel_16
            point = New Point(10, &H6B)
            Me.MessPict.Location = point
            Me.MessPict.Name = "MessPict"
            size = New Size(&H10, &H10)
            Me.MessPict.Size = size
            Me.MessPict.SizeMode = PictureBoxSizeMode.Zoom
            Me.MessPict.TabIndex = 8
            Me.MessPict.TabStop = False
            Me.MessPict.Visible = False
            Me.RenamePict.Image = Resources.font_128
            point = New Point(12, 12)
            Me.RenamePict.Location = point
            Me.RenamePict.Name = "RenamePict"
            size = New Size(&H40, &H40)
            Me.RenamePict.Size = size
            Me.RenamePict.SizeMode = PictureBoxSizeMode.Zoom
            Me.RenamePict.TabIndex = 3
            Me.RenamePict.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1BC, &H94)
            Me.ClientSize = size
            Me.Controls.Add(Me.OldNameText)
            Me.Controls.Add(Me.Mess2Lab)
            Me.Controls.Add(Me.Mess1Lab)
            Me.Controls.Add(Me.MessPict)
            Me.Controls.Add(Me.RenameLab)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.RenamePict)
            Me.Controls.Add(Me.OldNameLab1)
            Me.Controls.Add(Me.EstensioneText)
            Me.Controls.Add(Me.NameText)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Rename"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Rinomina"
            Me.TopMost = True
            DirectCast(Me.MessPict, ISupportInitialize).EndInit
            DirectCast(Me.RenamePict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub LoadInfo(ByVal Percorso As String, ByVal Folder As Boolean)
            Me.Path = Percorso.Remove(Percorso.LastIndexOfAny(Conversions.ToCharArrayRankOne("\")), (Percorso.Length - Percorso.LastIndexOfAny(Conversions.ToCharArrayRankOne("\"))))
            Me.IsFolder = Folder
            Me.OldNameText.Text = Percorso.Remove(0, (Percorso.LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
            If Me.IsFolder Then
                Me.RenameLab.Text = "Inserire qui il nuovo nome della cartella:"
                Me.EstensioneText.Visible = False
                Me.NameText.Text = MyProject.Computer.FileSystem.GetDirectoryInfo(Percorso).Name
            Else
                Me.RenameLab.Text = "Inserire qui il nuovo nome del file:"
                Me.EstensioneText.Visible = True
                Dim str As String = Percorso.Remove(0, (Percorso.LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                Me.NameText.Text = MyProject.Computer.FileSystem.GetFileInfo(Percorso).Name.Remove(str.LastIndexOf("."), (str.Length - str.LastIndexOf(".")))
                Me.EstensioneText.Text = MyProject.Computer.FileSystem.GetFileInfo(Percorso).Extension
            End If
        End Sub

        Public Sub NameChanged()
            Me.NameText.BackColor = Color.White
            Me.EstensioneText.BackColor = Color.White
            Me.Mess1Lab.ForeColor = Color.Black
            Me.Mess1Lab.Visible = False
            Me.Mess2Lab.Visible = False
            Me.MessPict.Visible = False
            If ((Me.NameText.Text & Me.EstensioneText.Text) <> Me.OldNameText.Text) Then
                If Me.IsFolder Then
                    If MyProject.Computer.FileSystem.DirectoryExists((Me.Path & "\" & Me.NameText.Text)) Then
                        Me.NameText.BackColor = Color.LightSalmon
                        Me.Mess2Lab.Text = "Il nome specificato è già utilizzato da un'altra cartella."
                        Me.Mess1Lab.Visible = True
                        Me.Mess2Lab.Visible = True
                        Me.MessPict.Visible = True
                    End If
                ElseIf MyProject.Computer.FileSystem.FileExists((Me.Path & "\" & Me.NameText.Text & Me.EstensioneText.Text)) Then
                    Me.NameText.BackColor = Color.LightSalmon
                    Me.EstensioneText.BackColor = Color.LightSalmon
                    Me.Mess2Lab.Text = "Il nome specificato è già utilizzato da un altro file."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("|") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("\") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("/") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains(":") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("*") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("?") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("""") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains("<") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
                If (Me.NameText.Text & Me.EstensioneText.Text).Contains(">") Then
                    Me.NameText.BackColor = Color.Orange
                    Me.EstensioneText.BackColor = Color.Orange
                    Me.Mess2Lab.Text = "È stato utilizzato un carattere non utilizzabile."
                    Me.Mess1Lab.Visible = True
                    Me.Mess2Lab.Visible = True
                    Me.MessPict.Visible = True
                End If
            End If
        End Sub

        Private Sub NameText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.NameChanged
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.NameText.BackColor = Color.White) Then
                Me.Rename
            Else
                Me.Mess1Lab.ForeColor = Color.Red
            End If
        End Sub

        Public Sub Rename()
            If Not Me.IsFolder Then
                MyProject.Computer.FileSystem.RenameFile((Me.Path & "\" & Me.OldNameText.Text), (Me.NameText.Text & Me.EstensioneText.Text))
            Else
                MyProject.Computer.FileSystem.RenameDirectory((Me.Path & "\" & Me.OldNameText.Text), Me.NameText.Text)
            End If
            Me.Close
        End Sub


        ' Properties
        Friend Overridable Property NameText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._NameText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._NameText Is Nothing) Then
                    RemoveHandler Me._NameText.TextChanged, New EventHandler(AddressOf Me.NameText_TextChanged)
                End If
                Me._NameText = WithEventsValue
                If (Not Me._NameText Is Nothing) Then
                    AddHandler Me._NameText.TextChanged, New EventHandler(AddressOf Me.NameText_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property EstensioneText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._EstensioneText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._EstensioneText Is Nothing) Then
                    RemoveHandler Me._EstensioneText.TextChanged, New EventHandler(AddressOf Me.EstensioneText_TextChanged)
                End If
                Me._EstensioneText = WithEventsValue
                If (Not Me._EstensioneText Is Nothing) Then
                    AddHandler Me._EstensioneText.TextChanged, New EventHandler(AddressOf Me.EstensioneText_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property OldNameLab1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._OldNameLab1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._OldNameLab1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenamePict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenamePict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._RenamePict = WithEventsValue
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
                    RemoveHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
                Me._CancelButt = WithEventsValue
                If (Not Me._CancelButt Is Nothing) Then
                    AddHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RenameLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._RenameLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._RenameLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MessPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._MessPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._MessPict = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Mess1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Mess1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Mess1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Mess2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Mess2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Mess2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OldNameText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._OldNameText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._OldNameText = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("NameText")> _
        Private _NameText As TextBox
        <AccessedThroughProperty("EstensioneText")> _
        Private _EstensioneText As TextBox
        <AccessedThroughProperty("OldNameLab1")> _
        Private _OldNameLab1 As Label
        <AccessedThroughProperty("RenamePict")> _
        Private _RenamePict As PictureBox
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("RenameLab")> _
        Private _RenameLab As Label
        <AccessedThroughProperty("MessPict")> _
        Private _MessPict As PictureBox
        <AccessedThroughProperty("Mess1Lab")> _
        Private _Mess1Lab As Label
        <AccessedThroughProperty("Mess2Lab")> _
        Private _Mess2Lab As Label
        <AccessedThroughProperty("OldNameText")> _
        Private _OldNameText As TextBox
        Private Path As String
        Private IsFolder As Boolean
    End Class
End Namespace

