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
Imports System.Threading
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class Updates
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.FormClosed, New FormClosedEventHandler(AddressOf Me.Updates_FormClosed)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Update_Load)
            Me.Downloaded1 = False
            Me.Downloaded2 = False
            Me.VerifyUpdate = "http://powersoftware.altervista.org/software/powerexplorer.txt"
            Me.InitializeComponent
        End Sub

        Private Sub CloseLaterButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MySettingsProperty.Settings.Updates = True
            Me.Close
        End Sub

        Private Sub CloseNowButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start((Application.StartupPath & "Update.exe"))
            Application.Exit
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub Download1()
            MyProject.Computer.Network.DownloadFile(Me.VerifyUpdate, (Application.StartupPath & "Update.txt"), "", "", False, Conversions.ToInteger("100000"), True, UICancelOption.DoNothing)
            Me.Downloaded1 = True
        End Sub

        Public Sub Download2()
            MyProject.Computer.Network.DownloadFile(Me.Installer, (Application.StartupPath & "Update.exe"), "", "", False, Conversions.ToInteger("100000"), True, UICancelOption.DoNothing)
            Me.Downloaded2 = True
        End Sub

        Private Sub ExitButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Updates))
            Me.ExitButt = New Button
            Me.UpdateButt = New Button
            Me.StatusLab = New Label
            Me.DownloadProgress = New ProgressBar
            Me.PictureBox1 = New PictureBox
            Me.VersionLab1 = New Label
            Me.LastVersionLab1 = New Label
            Me.VersionLab2 = New Label
            Me.LastVersionLab2 = New Label
            Me.UpdatePan = New Panel
            Me.Timer1 = New Timer(Me.components)
            Me.Timer2 = New Timer(Me.components)
            Me.RestartPan = New Panel
            Me.CloseLaterButt = New Button
            Me.CloseNowButt = New Button
            Me.RestartLab = New Label
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.UpdatePan.SuspendLayout
            Me.RestartPan.SuspendLayout
            Me.SuspendLayout
            Dim point As New Point(&H163, &HFB)
            Me.ExitButt.Location = point
            Me.ExitButt.Name = "ExitButt"
            Dim size As New Size(&H4B, &H17)
            Me.ExitButt.Size = size
            Me.ExitButt.TabIndex = 0
            Me.ExitButt.Text = "&Esci"
            Me.ExitButt.UseVisualStyleBackColor = True
            point = New Point(6, &H20)
            Me.UpdateButt.Location = point
            Me.UpdateButt.Name = "UpdateButt"
            size = New Size(&HB1, &H17)
            Me.UpdateButt.Size = size
            Me.UpdateButt.TabIndex = 1
            Me.UpdateButt.Text = "Aggiorna all'ultima versione"
            Me.UpdateButt.UseVisualStyleBackColor = True
            Me.StatusLab.AutoSize = True
            Me.StatusLab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H8A, 12)
            Me.StatusLab.Location = point
            Me.StatusLab.Name = "StatusLab"
            size = New Size(&HD1, 13)
            Me.StatusLab.Size = size
            Me.StatusLab.TabIndex = 2
            Me.StatusLab.Text = "Ricerca di aggiornamenti in corso..."
            point = New Point(&H8A, &HDE)
            Me.DownloadProgress.Location = point
            Me.DownloadProgress.Name = "DownloadProgress"
            size = New Size(&H124, &H17)
            Me.DownloadProgress.Size = size
            Me.DownloadProgress.Style = ProgressBarStyle.Marquee
            Me.DownloadProgress.TabIndex = 3
            Me.PictureBox1.Image = Resources.power_explorer
            point = New Point(12, 12)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(120, &H106)
            Me.PictureBox1.Size = size
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 6
            Me.PictureBox1.TabStop = False
            Me.VersionLab1.AutoSize = True
            point = New Point(3, 3)
            Me.VersionLab1.Location = point
            Me.VersionLab1.Name = "VersionLab1"
            size = New Size(&H56, 13)
            Me.VersionLab1.Size = size
            Me.VersionLab1.TabIndex = 7
            Me.VersionLab1.Text = "Versione attuale:"
            Me.LastVersionLab1.AutoSize = True
            point = New Point(3, &H10)
            Me.LastVersionLab1.Location = point
            Me.LastVersionLab1.Name = "LastVersionLab1"
            size = New Size(&H86, 13)
            Me.LastVersionLab1.Size = size
            Me.LastVersionLab1.TabIndex = 8
            Me.LastVersionLab1.Text = "Ultima versione disponibile:"
            Me.VersionLab2.AutoSize = True
            point = New Point(&H8F, 3)
            Me.VersionLab2.Location = point
            Me.VersionLab2.Name = "VersionLab2"
            size = New Size(40, 13)
            Me.VersionLab2.Size = size
            Me.VersionLab2.TabIndex = 9
            Me.VersionLab2.Text = "1.0.0.0"
            Me.LastVersionLab2.AutoSize = True
            point = New Point(&H8F, &H10)
            Me.LastVersionLab2.Location = point
            Me.LastVersionLab2.Name = "LastVersionLab2"
            size = New Size(40, 13)
            Me.LastVersionLab2.Size = size
            Me.LastVersionLab2.TabIndex = 10
            Me.LastVersionLab2.Text = "1.0.0.0"
            Me.UpdatePan.Controls.Add(Me.VersionLab1)
            Me.UpdatePan.Controls.Add(Me.LastVersionLab2)
            Me.UpdatePan.Controls.Add(Me.UpdateButt)
            Me.UpdatePan.Controls.Add(Me.VersionLab2)
            Me.UpdatePan.Controls.Add(Me.LastVersionLab1)
            point = New Point(&HBD, &H31)
            Me.UpdatePan.Location = point
            Me.UpdatePan.Name = "UpdatePan"
            size = New Size(&HBB, &H3B)
            Me.UpdatePan.Size = size
            Me.UpdatePan.TabIndex = 11
            Me.UpdatePan.Visible = False
            Me.Timer1.Interval = 500
            Me.Timer2.Interval = 500
            Me.RestartPan.Controls.Add(Me.CloseLaterButt)
            Me.RestartPan.Controls.Add(Me.CloseNowButt)
            Me.RestartPan.Controls.Add(Me.RestartLab)
            point = New Point(160, &H31)
            Me.RestartPan.Location = point
            Me.RestartPan.Name = "RestartPan"
            size = New Size(&H102, &H4B)
            Me.RestartPan.Size = size
            Me.RestartPan.TabIndex = 12
            Me.RestartPan.Visible = False
            point = New Point(&H6B, &H31)
            Me.CloseLaterButt.Location = point
            Me.CloseLaterButt.Name = "CloseLaterButt"
            size = New Size(&H94, &H17)
            Me.CloseLaterButt.Size = size
            Me.CloseLaterButt.TabIndex = 2
            Me.CloseLaterButt.Text = "Installa al prossimo avvio"
            Me.CloseLaterButt.UseVisualStyleBackColor = True
            point = New Point(6, &H31)
            Me.CloseNowButt.Location = point
            Me.CloseNowButt.Name = "CloseNowButt"
            size = New Size(&H5F, &H17)
            Me.CloseNowButt.Size = size
            Me.CloseNowButt.TabIndex = 1
            Me.CloseNowButt.Text = "Chiudi adesso"
            Me.CloseNowButt.UseVisualStyleBackColor = True
            Me.RestartLab.AutoSize = True
            point = New Point(3, 1)
            Me.RestartLab.Location = point
            size = New Size(250, 0)
            Me.RestartLab.MaximumSize = size
            Me.RestartLab.Name = "RestartLab"
            size = New Size(250, &H27)
            Me.RestartLab.Size = size
            Me.RestartLab.TabIndex = 0
            Me.RestartLab.Text = "Per installare gli aggiornamenti è necessario chiudere il programma. Chiuderlo adesso o installare gli aggiornamenti al prossimo avvio del programma?"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1BA, &H11E)
            Me.ClientSize = size
            Me.Controls.Add(Me.RestartPan)
            Me.Controls.Add(Me.UpdatePan)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.DownloadProgress)
            Me.Controls.Add(Me.StatusLab)
            Me.Controls.Add(Me.ExitButt)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.Name = "Updates"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "Ricerca aggiornamenti"
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.UpdatePan.ResumeLayout(False)
            Me.UpdatePan.PerformLayout
            Me.RestartPan.ResumeLayout(False)
            Me.RestartPan.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub Start()
            If Not MyProject.Computer.Network.IsAvailable Then
                MessageBox.Show("Per controllare gli aggiornamenti è necessario disporre di una connessione ad Internet attiva.", "Impossibile controllare gli aggiornamenti", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Close
            Else
                Me.VersionLab2.Text = Application.ProductVersion
                If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "Update.txt")) Then
                    MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "Update.txt"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
                End If
                New Thread(New ThreadStart(AddressOf Me.Download1)).Start
                Me.Timer1.Enabled = True
            End If
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Downloaded1 Then
                Dim reader As New StreamReader((Application.StartupPath & "Update.txt"))
                Dim str As String = reader.ReadLine
                If (str <> "") Then
                    Me.VerifyUpdate = str
                    Me.Start
                Else
                    Dim right As String = reader.ReadLine
                    If (Operators.CompareString(Application.ProductVersion, right, False) >= 0) Then
                        Me.StatusLab.Text = "Non sono state trovate versioni più aggiornate."
                        Me.DownloadProgress.Visible = False
                    Else
                        Me.StatusLab.Text = "È stata trovata una nuova versione!"
                        Me.UpdatePan.Visible = True
                        Me.LastVersionLab2.Text = right
                        Me.DownloadProgress.Visible = False
                    End If
                    Me.Installer = reader.ReadLine
                    reader.Close
                    MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "Update.txt"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing)
                    Me.Timer1.Enabled = False
                End If
            End If
        End Sub

        Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Downloaded2 Then
                Me.Timer2.Enabled = False
                Me.StatusLab.Text = "Download degli aggiornamenti completato."
                Me.RestartPan.Visible = True
                Me.DownloadProgress.Visible = False
            End If
        End Sub

        Private Sub Update_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Start
        End Sub

        Private Sub UpdateButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            New Thread(New ThreadStart(AddressOf Me.Download2)).Start
            Me.Timer2.Enabled = True
            Me.DownloadProgress.Visible = True
            Me.StatusLab.Text = "Download degli aggiornamenti in corso..."
            Me.UpdatePan.Visible = False
        End Sub

        Private Sub Updates_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            MySettingsProperty.Settings.LastUpdate = MyProject.Computer.Clock.LocalTime
        End Sub


        ' Properties
        Friend Overridable Property ExitButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ExitButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ExitButt Is Nothing) Then
                    RemoveHandler Me._ExitButt.Click, New EventHandler(AddressOf Me.ExitButt_Click)
                End If
                Me._ExitButt = WithEventsValue
                If (Not Me._ExitButt Is Nothing) Then
                    AddHandler Me._ExitButt.Click, New EventHandler(AddressOf Me.ExitButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property UpdateButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._UpdateButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._UpdateButt Is Nothing) Then
                    RemoveHandler Me._UpdateButt.Click, New EventHandler(AddressOf Me.UpdateButt_Click)
                End If
                Me._UpdateButt = WithEventsValue
                If (Not Me._UpdateButt Is Nothing) Then
                    AddHandler Me._UpdateButt.Click, New EventHandler(AddressOf Me.UpdateButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property StatusLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._StatusLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._StatusLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DownloadProgress As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._DownloadProgress
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._DownloadProgress = WithEventsValue
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

        Friend Overridable Property VersionLab1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._VersionLab1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._VersionLab1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LastVersionLab1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._LastVersionLab1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._LastVersionLab1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VersionLab2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._VersionLab2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._VersionLab2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LastVersionLab2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._LastVersionLab2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._LastVersionLab2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property UpdatePan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._UpdatePan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._UpdatePan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._Timer1 Is Nothing) Then
                    RemoveHandler Me._Timer1.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
                Me._Timer1 = WithEventsValue
                If (Not Me._Timer1 Is Nothing) Then
                    AddHandler Me._Timer1.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property Timer2 As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._Timer2 Is Nothing) Then
                    RemoveHandler Me._Timer2.Tick, New EventHandler(AddressOf Me.Timer2_Tick)
                End If
                Me._Timer2 = WithEventsValue
                If (Not Me._Timer2 Is Nothing) Then
                    AddHandler Me._Timer2.Tick, New EventHandler(AddressOf Me.Timer2_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property RestartPan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._RestartPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._RestartPan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CloseLaterButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CloseLaterButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CloseLaterButt Is Nothing) Then
                    RemoveHandler Me._CloseLaterButt.Click, New EventHandler(AddressOf Me.CloseLaterButt_Click)
                End If
                Me._CloseLaterButt = WithEventsValue
                If (Not Me._CloseLaterButt Is Nothing) Then
                    AddHandler Me._CloseLaterButt.Click, New EventHandler(AddressOf Me.CloseLaterButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property CloseNowButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CloseNowButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CloseNowButt Is Nothing) Then
                    RemoveHandler Me._CloseNowButt.Click, New EventHandler(AddressOf Me.CloseNowButt_Click)
                End If
                Me._CloseNowButt = WithEventsValue
                If (Not Me._CloseNowButt Is Nothing) Then
                    AddHandler Me._CloseNowButt.Click, New EventHandler(AddressOf Me.CloseNowButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RestartLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._RestartLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._RestartLab = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ExitButt")> _
        Private _ExitButt As Button
        <AccessedThroughProperty("UpdateButt")> _
        Private _UpdateButt As Button
        <AccessedThroughProperty("StatusLab")> _
        Private _StatusLab As Label
        <AccessedThroughProperty("DownloadProgress")> _
        Private _DownloadProgress As ProgressBar
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("VersionLab1")> _
        Private _VersionLab1 As Label
        <AccessedThroughProperty("LastVersionLab1")> _
        Private _LastVersionLab1 As Label
        <AccessedThroughProperty("VersionLab2")> _
        Private _VersionLab2 As Label
        <AccessedThroughProperty("LastVersionLab2")> _
        Private _LastVersionLab2 As Label
        <AccessedThroughProperty("UpdatePan")> _
        Private _UpdatePan As Panel
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        <AccessedThroughProperty("Timer2")> _
        Private _Timer2 As Timer
        <AccessedThroughProperty("RestartPan")> _
        Private _RestartPan As Panel
        <AccessedThroughProperty("CloseLaterButt")> _
        Private _CloseLaterButt As Button
        <AccessedThroughProperty("CloseNowButt")> _
        Private _CloseNowButt As Button
        <AccessedThroughProperty("RestartLab")> _
        Private _RestartLab As Label
        Private Downloaded1 As Boolean
        Private Downloaded2 As Boolean
        Private Installer As String
        Private VerifyUpdate As String
    End Class
End Namespace

