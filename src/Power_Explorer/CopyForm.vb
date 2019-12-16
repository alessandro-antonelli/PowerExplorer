Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Explorer.My
Imports Power_Explorer.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class CopyForm
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.FormClosed, New FormClosedEventHandler(AddressOf Me.Copia_FormClosed)
            AddHandler MyBase.Shown, New EventHandler(AddressOf Me.CopyForm_Shown)
            Me.CopyThread = New Thread(New ThreadStart(AddressOf Me.Copy))
            Me.InitializeComponent
        End Sub

        Private Sub AnnullaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CopyThread.Suspend
            Me.Close
        End Sub

        Private Sub Copia_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            Me.Timer.Enabled = False
        End Sub

        Public Sub Copy()
            If (MyProject.Computer.FileSystem.GetDriveInfo((Conversions.ToString(Me.To2Lab.Text(0)) & ":")).AvailableFreeSpace < MyProject.Computer.FileSystem.GetFileInfo((Me.From2Lab.Text & "\" & Me.NameLab.Text)).Length) Then
                MessageBox.Show(("Spazio insufficiente nell'unità " & Conversions.ToString(Me.To2Lab.Text(0)) & ":"), "Spazio insufficiente", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            ElseIf (Conversions.ToString(Me.Text(0)) = "C") Then
                MyProject.Computer.FileSystem.CopyFile((Me.From2Lab.Text & "\" & Me.NameLab.Text), (Me.To2Lab.Text & "\" & Me.NameLab.Text), False)
            Else
                MyProject.Computer.FileSystem.MoveFile((Me.From2Lab.Text & "\" & Me.NameLab.Text), (Me.To2Lab.Text & "\" & Me.NameLab.Text), False)
            End If
        End Sub

        Private Sub CopyForm_Shown(ByVal sender As Object, ByVal e As EventArgs)
            Me.Timer.Enabled = True
            Me.CopyThread.Start
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
            Me.components = New Container
            Me.AvanzamentoProg = New ProgressBar
            Me.NameLab = New Label
            Me.From1Lab = New Label
            Me.CancelButt = New Button
            Me.To1Lab = New Label
            Me.From2Lab = New Label
            Me.To2Lab = New Label
            Me.AvanzamentoLab = New Label
            Me.Timer = New Timer(Me.components)
            Me.FromPict = New PictureBox
            Me.ToPict = New PictureBox
            DirectCast(Me.FromPict, ISupportInitialize).BeginInit
            DirectCast(Me.ToPict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Dim point As New Point(12, &H3E)
            Me.AvanzamentoProg.Location = point
            Me.AvanzamentoProg.Name = "AvanzamentoProg"
            Dim size As New Size(&H152, 20)
            Me.AvanzamentoProg.Size = size
            Me.AvanzamentoProg.Style = ProgressBarStyle.Continuous
            Me.AvanzamentoProg.TabIndex = 0
            Me.NameLab.AutoSize = True
            Me.NameLab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(9, 9)
            Me.NameLab.Location = point
            Me.NameLab.Name = "NameLab"
            size = New Size(&H3D, 13)
            Me.NameLab.Size = size
            Me.NameLab.TabIndex = 1
            Me.NameLab.Text = "File name"
            Me.From1Lab.AutoSize = True
            point = New Point(12, 30)
            Me.From1Lab.Location = point
            Me.From1Lab.Name = "From1Lab"
            size = New Size(&H18, 13)
            Me.From1Lab.Size = size
            Me.From1Lab.TabIndex = 2
            Me.From1Lab.Text = "Da:"
            point = New Point(&H131, &H5B)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 5
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.To1Lab.AutoSize = True
            point = New Point(12, &H2B)
            Me.To1Lab.Location = point
            Me.To1Lab.Name = "To1Lab"
            size = New Size(&H11, 13)
            Me.To1Lab.Size = size
            Me.To1Lab.TabIndex = 6
            Me.To1Lab.Text = "A:"
            Me.From2Lab.AutoSize = True
            point = New Point(&H3D, 30)
            Me.From2Lab.Location = point
            Me.From2Lab.Name = "From2Lab"
            size = New Size(&H26, 13)
            Me.From2Lab.Size = size
            Me.From2Lab.TabIndex = 7
            Me.From2Lab.Text = "Path 1"
            Me.To2Lab.AutoSize = True
            point = New Point(&H3D, &H2B)
            Me.To2Lab.Location = point
            Me.To2Lab.Name = "To2Lab"
            size = New Size(&H26, 13)
            Me.To2Lab.Size = size
            Me.To2Lab.TabIndex = 8
            Me.To2Lab.Text = "Path 2"
            Me.AvanzamentoLab.AutoSize = True
            Me.AvanzamentoLab.BackColor = Color.Transparent
            point = New Point(&H164, &H42)
            Me.AvanzamentoLab.Location = point
            Me.AvanzamentoLab.Name = "AvanzamentoLab"
            size = New Size(&H18, 13)
            Me.AvanzamentoLab.Size = size
            Me.AvanzamentoLab.TabIndex = 12
            Me.AvanzamentoLab.Text = "0 %"
            Me.Timer.Interval = 500
            point = New Point(&H2A, 30)
            Me.FromPict.Location = point
            Me.FromPict.Name = "FromPict"
            size = New Size(13, 13)
            Me.FromPict.Size = size
            Me.FromPict.TabIndex = 13
            Me.FromPict.TabStop = False
            point = New Point(&H2A, &H2B)
            Me.ToPict.Location = point
            Me.ToPict.Name = "ToPict"
            size = New Size(13, 13)
            Me.ToPict.Size = size
            Me.ToPict.TabIndex = 14
            Me.ToPict.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H188, &H7C)
            Me.ClientSize = size
            Me.Controls.Add(Me.ToPict)
            Me.Controls.Add(Me.FromPict)
            Me.Controls.Add(Me.AvanzamentoLab)
            Me.Controls.Add(Me.To2Lab)
            Me.Controls.Add(Me.From2Lab)
            Me.Controls.Add(Me.To1Lab)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.From1Lab)
            Me.Controls.Add(Me.NameLab)
            Me.Controls.Add(Me.AvanzamentoProg)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "CopyForm"
            Me.ShowIcon = False
            Me.Text = "Copia"
            DirectCast(Me.FromPict, ISupportInitialize).EndInit
            DirectCast(Me.ToPict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub Set1(ByVal OldPath As String, ByVal Cut As Boolean)
            Me.Text = If(Cut, ("Spostamento di " & MyProject.Computer.FileSystem.GetFileInfo(OldPath).Name), ("Copia di " & MyProject.Computer.FileSystem.GetFileInfo(OldPath).Name))
            Me.From2Lab.Text = MyProject.Computer.FileSystem.GetFileInfo(OldPath).DirectoryName
            Select Case MyProject.Computer.FileSystem.GetDriveInfo(OldPath.Remove(2, (OldPath.Length - 2))).DriveType
                Case DriveType.Removable
                    Me.FromPict.Image = Resources.usb_16
                    If (Conversions.ToString(OldPath(0)) = "A") Then
                        Me.FromPict.Image = Resources.floppy_16
                    End If
                    If (Conversions.ToString(OldPath(0)) = "B") Then
                        Me.FromPict.Image = Resources.floppy_16
                    End If
                    Exit Select
                Case DriveType.Fixed
                    Me.FromPict.Image = Resources.hd_blu_16
                    Exit Select
                Case DriveType.CDRom
                    Me.FromPict.Image = Resources.cd_16
                    Exit Select
                Case Else
                    Exit Select
            End Select
            Me.NameLab.Text = MyProject.Computer.FileSystem.GetFileInfo(OldPath).Name
            Me.AvanzamentoProg.Maximum = CInt(MyProject.Computer.FileSystem.GetFileInfo(OldPath).Length)
            If (Conversions.ToString(Me.To2Lab.Text((Me.To2Lab.Text.Length - 1))) = "\") Then
                Me.To2Lab.Text = Me.To2Lab.Text.Remove((Me.To2Lab.Text.Length - 2), (Me.To2Lab.Text.Length - 1))
            End If
        End Sub

        Public Sub Set2(ByVal NewPath As String)
            Me.To2Lab.Text = NewPath
            Select Case MyProject.Computer.FileSystem.GetDriveInfo(NewPath.Remove(2, (NewPath.Length - 2))).DriveType
                Case DriveType.Removable
                    Me.ToPict.Image = Resources.usb_16
                    If (Conversions.ToString(NewPath(0)) = "A") Then
                        Me.ToPict.Image = Resources.floppy_16
                    End If
                    If (Conversions.ToString(NewPath(0)) = "B") Then
                        Me.ToPict.Image = Resources.floppy_16
                    End If
                    Exit Select
                Case DriveType.Fixed
                    Me.ToPict.Image = Resources.hd_blu_16
                    Exit Select
                Case DriveType.CDRom
                    Me.ToPict.Image = Resources.cd_16
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Not MyProject.Computer.FileSystem.FileExists((Me.To2Lab.Text & "\" & Me.NameLab.Text)) Then
                Me.AvanzamentoProg.Style = ProgressBarStyle.Marquee
            Else
                Me.AvanzamentoProg.Style = ProgressBarStyle.Continuous
                Me.AvanzamentoProg.Value = CInt(MyProject.Computer.FileSystem.GetFileInfo((Me.To2Lab.Text & "\" & Me.NameLab.Text)).Length)
            End If
            If (Me.CopyThread.ThreadState = ThreadState.Stopped) Then
                Me.Close
            End If
        End Sub


        ' Properties
        Friend Overridable Property AvanzamentoProg As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._AvanzamentoProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._AvanzamentoProg = WithEventsValue
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

        Friend Overridable Property From1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._From1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._From1Lab = WithEventsValue
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

        Friend Overridable Property To1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._To1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._To1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property From2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._From2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._From2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property To2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._To2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._To2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AvanzamentoLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._AvanzamentoLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._AvanzamentoLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._Timer Is Nothing) Then
                    RemoveHandler Me._Timer.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
                Me._Timer = WithEventsValue
                If (Not Me._Timer Is Nothing) Then
                    AddHandler Me._Timer.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property FromPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FromPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._FromPict = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ToPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._ToPict = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("AvanzamentoProg")> _
        Private _AvanzamentoProg As ProgressBar
        <AccessedThroughProperty("NameLab")> _
        Private _NameLab As Label
        <AccessedThroughProperty("From1Lab")> _
        Private _From1Lab As Label
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("To1Lab")> _
        Private _To1Lab As Label
        <AccessedThroughProperty("From2Lab")> _
        Private _From2Lab As Label
        <AccessedThroughProperty("To2Lab")> _
        Private _To2Lab As Label
        <AccessedThroughProperty("AvanzamentoLab")> _
        Private _AvanzamentoLab As Label
        <AccessedThroughProperty("Timer")> _
        Private _Timer As Timer
        <AccessedThroughProperty("FromPict")> _
        Private _FromPict As PictureBox
        <AccessedThroughProperty("ToPict")> _
        Private _ToPict As PictureBox
        Private CopyThread As Thread
    End Class
End Namespace

