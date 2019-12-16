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
    Public NotInheritable Class About
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.InformazioniSu_Load)
            Me.InitializeComponent
        End Sub

        Private Sub ChangeButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.ChangeButt.Text = "»") Then
                Me.Panel1.Visible = False
                Me.Panel2.Visible = True
                Me.ChangeButt.Text = "«"
            Else
                Me.Panel1.Visible = True
                Me.Panel2.Visible = False
                Me.ChangeButt.Text = "»"
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InformazioniSu_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Text = ("Informazioni su " & Application.ProductName)
            Me.NomeLab.Text = Application.ProductName
            Me.VersioneLab.Text = ("Versione " & Application.ProductVersion)
            Me.DataLab.Text = MyProject.Application.Info.Description
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(About))
            Me.OKButt = New Button
            Me.NomeLab = New Label
            Me.VersioneLab = New Label
            Me.SitoLink = New LinkLabel
            Me.PowerLab = New Label
            Me.DataLab = New Label
            Me.PictureBox1 = New PictureBox
            Me.ChangeButt = New Button
            Me.Panel1 = New Panel
            Me.Label1 = New Label
            Me.Panel2 = New Panel
            Me.LinkLabel2 = New LinkLabel
            Me.LinkLabel1 = New LinkLabel
            Me.Label3 = New Label
            Me.Label2 = New Label
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.Panel1.SuspendLayout
            Me.Panel2.SuspendLayout
            Me.SuspendLayout
            Dim point As New Point(&H138, &HFD)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            Dim size As New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 0
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.NomeLab.AutoSize = True
            Me.NomeLab.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H8B, &H16)
            Me.NomeLab.Location = point
            Me.NomeLab.Name = "NomeLab"
            size = New Size(&H71, &H10)
            Me.NomeLab.Size = size
            Me.NomeLab.TabIndex = 1
            Me.NomeLab.Text = "Power Explorer"
            Me.VersioneLab.AutoSize = True
            point = New Point(&H8A, &H2C)
            Me.VersioneLab.Location = point
            Me.VersioneLab.Name = "VersioneLab"
            size = New Size(&H2A, 13)
            Me.VersioneLab.Size = size
            Me.VersioneLab.TabIndex = 2
            Me.VersioneLab.Text = "Version"
            Me.SitoLink.AutoSize = True
            Dim area As New LinkArea(10, 14)
            Me.SitoLink.LinkArea = area
            point = New Point(&H8A, 70)
            Me.SitoLink.Location = point
            Me.SitoLink.Name = "SitoLink"
            size = New Size(&H67, &H11)
            Me.SitoLink.Size = size
            Me.SitoLink.TabIndex = 4
            Me.SitoLink.TabStop = True
            Me.SitoLink.Text = "Visita il sito ufficiale"
            Me.SitoLink.UseCompatibleTextRendering = True
            Me.PowerLab.Anchor = AnchorStyles.None
            Me.PowerLab.BackColor = Color.Transparent
            Me.PowerLab.Font = New Font("Arial", 14.25!, (FontStyle.Italic Or FontStyle.Bold), GraphicsUnit.Point, 0)
            Me.PowerLab.ForeColor = SystemColors.ActiveCaption
            point = New Point(&H8A, 12)
            Me.PowerLab.Location = point
            Me.PowerLab.Name = "PowerLab"
            size = New Size(&HF9, &H20)
            Me.PowerLab.Size = size
            Me.PowerLab.TabIndex = 11
            Me.PowerLab.Text = "Power"
            Me.PowerLab.TextAlign = ContentAlignment.MiddleRight
            Me.DataLab.AutoSize = True
            point = New Point(&H8A, &H39)
            Me.DataLab.Location = point
            Me.DataLab.Name = "DataLab"
            size = New Size(30, 13)
            Me.DataLab.Size = size
            Me.DataLab.TabIndex = 13
            Me.DataLab.Text = "Date"
            Me.PictureBox1.Image = Resources.power_explorer
            point = New Point(12, 12)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(120, &H106)
            Me.PictureBox1.Size = size
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 5
            Me.PictureBox1.TabStop = False
            point = New Point(&H8A, &HFD)
            Me.ChangeButt.Location = point
            Me.ChangeButt.Name = "ChangeButt"
            size = New Size(&H4B, &H17)
            Me.ChangeButt.Size = size
            Me.ChangeButt.TabIndex = 14
            Me.ChangeButt.Text = "»"
            Me.ChangeButt.UseVisualStyleBackColor = True
            Me.Panel1.Controls.Add(Me.Label1)
            point = New Point(&H8A, &H72)
            Me.Panel1.Location = point
            Me.Panel1.Name = "Panel1"
            size = New Size(&HF9, &H85)
            Me.Panel1.Size = size
            Me.Panel1.TabIndex = 15
            point = New Point(8, 9)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&HEE, &H7C)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = manager.GetString("Label1.Text")
            Me.Panel2.Controls.Add(Me.LinkLabel2)
            Me.Panel2.Controls.Add(Me.LinkLabel1)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.Label2)
            point = New Point(&H8A, &H72)
            Me.Panel2.Location = point
            Me.Panel2.Name = "Panel2"
            size = New Size(&HF9, &H85)
            Me.Panel2.Size = size
            Me.Panel2.TabIndex = &H10
            Me.Panel2.Visible = False
            Me.LinkLabel2.AutoSize = True
            point = New Point(&H66, &H16)
            Me.LinkLabel2.Location = point
            Me.LinkLabel2.Name = "LinkLabel2"
            size = New Size(&H66, 13)
            Me.LinkLabel2.Size = size
            Me.LinkLabel2.TabIndex = 4
            Me.LinkLabel2.TabStop = True
            Me.LinkLabel2.Text = "Alessandro Antonelli"
            Me.LinkLabel1.AutoSize = True
            point = New Point(&H66, 9)
            Me.LinkLabel1.Location = point
            Me.LinkLabel1.Name = "LinkLabel1"
            size = New Size(&H49, 13)
            Me.LinkLabel1.Size = size
            Me.LinkLabel1.TabIndex = 3
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "David Vignoni"
            Me.Label3.AutoSize = True
            point = New Point(9, &H16)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H55, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Programmazione"
            Me.Label2.AutoSize = True
            point = New Point(9, 9)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H22, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Icone"
            Me.AcceptButton = Me.OKButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H18F, &H120)
            Me.ClientSize = size
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.ChangeButt)
            Me.Controls.Add(Me.DataLab)
            Me.Controls.Add(Me.NomeLab)
            Me.Controls.Add(Me.PowerLab)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.SitoLink)
            Me.Controls.Add(Me.VersioneLab)
            Me.Controls.Add(Me.OKButt)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "About"
            Dim padding As New Padding(9)
            Me.Padding = padding
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "Informazioni su Power Explorer"
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("http://powersoftware.altervista.org/")
        End Sub

        Private Sub LinkLabel1_LinkClicked_1(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("http://www.icon-king.com/")
        End Sub

        Private Sub LinkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("http://aleantonelli.altervista.org/")
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub


        ' Properties
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

        Friend Overridable Property NomeLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._NomeLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._NomeLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VersioneLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._VersioneLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._VersioneLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SitoLink As LinkLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._SitoLink
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As LinkLabel)
                If (Not Me._SitoLink Is Nothing) Then
                    RemoveHandler Me._SitoLink.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel1_LinkClicked)
                End If
                Me._SitoLink = WithEventsValue
                If (Not Me._SitoLink Is Nothing) Then
                    AddHandler Me._SitoLink.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel1_LinkClicked)
                End If
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

        Friend Overridable Property PowerLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PowerLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PowerLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DataLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._DataLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._DataLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ChangeButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ChangeButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ChangeButt Is Nothing) Then
                    RemoveHandler Me._ChangeButt.Click, New EventHandler(AddressOf Me.ChangeButt_Click)
                End If
                Me._ChangeButt = WithEventsValue
                If (Not Me._ChangeButt Is Nothing) Then
                    AddHandler Me._ChangeButt.Click, New EventHandler(AddressOf Me.ChangeButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Panel1 As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._Panel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._Panel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel2 As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._Panel2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._Panel2 = WithEventsValue
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

        Friend Overridable Property LinkLabel2 As LinkLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._LinkLabel2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As LinkLabel)
                If (Not Me._LinkLabel2 Is Nothing) Then
                    RemoveHandler Me._LinkLabel2.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel2_LinkClicked)
                End If
                Me._LinkLabel2 = WithEventsValue
                If (Not Me._LinkLabel2 Is Nothing) Then
                    AddHandler Me._LinkLabel2.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel2_LinkClicked)
                End If
            End Set
        End Property

        Friend Overridable Property LinkLabel1 As LinkLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._LinkLabel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As LinkLabel)
                If (Not Me._LinkLabel1 Is Nothing) Then
                    RemoveHandler Me._LinkLabel1.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel1_LinkClicked_1)
                End If
                Me._LinkLabel1 = WithEventsValue
                If (Not Me._LinkLabel1 Is Nothing) Then
                    AddHandler Me._LinkLabel1.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.LinkLabel1_LinkClicked_1)
                End If
            End Set
        End Property

        Friend Overridable Property Label3 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label2 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("NomeLab")> _
        Private _NomeLab As Label
        <AccessedThroughProperty("VersioneLab")> _
        Private _VersioneLab As Label
        <AccessedThroughProperty("SitoLink")> _
        Private _SitoLink As LinkLabel
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("PowerLab")> _
        Private _PowerLab As Label
        <AccessedThroughProperty("DataLab")> _
        Private _DataLab As Label
        <AccessedThroughProperty("ChangeButt")> _
        Private _ChangeButt As Button
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
        <AccessedThroughProperty("Panel2")> _
        Private _Panel2 As Panel
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("LinkLabel2")> _
        Private _LinkLabel2 As LinkLabel
        <AccessedThroughProperty("LinkLabel1")> _
        Private _LinkLabel1 As LinkLabel
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
    End Class
End Namespace

