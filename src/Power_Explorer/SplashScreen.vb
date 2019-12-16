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
    Public NotInheritable Class SplashScreen
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.SplashScreen_Load)
            Me.InitializeComponent
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
            Me.ApplicationTitle = New Label
            Me.Label1 = New Label
            Me.Version = New Label
            Me.PictureBox1 = New PictureBox
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.ApplicationTitle.Anchor = AnchorStyles.None
            Me.ApplicationTitle.BackColor = Color.Transparent
            Me.ApplicationTitle.Font = New Font("Microsoft Sans Serif", 20.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.ApplicationTitle.ForeColor = Color.Red
            Dim point As New Point(&HF6, &H23)
            Me.ApplicationTitle.Location = point
            Me.ApplicationTitle.Name = "ApplicationTitle"
            Dim size As New Size(&HEE, 180)
            Me.ApplicationTitle.Size = size
            Me.ApplicationTitle.TabIndex = 3
            Me.ApplicationTitle.Text = "Titolo applicazione"
            Me.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
            Me.Label1.Anchor = AnchorStyles.None
            Me.Label1.BackColor = Color.Transparent
            Me.Label1.Font = New Font("Arial", 14.25!, (FontStyle.Italic Or FontStyle.Bold), GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = SystemColors.ActiveCaption
            point = New Point(&HF6, 3)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&HF4, &H20)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "Power"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            Me.Version.Anchor = AnchorStyles.None
            Me.Version.BackColor = Color.Transparent
            Me.Version.Font = New Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.Version.ForeColor = Color.FromArgb(0, &HC0, 0)
            point = New Point(&HFB, &HE1)
            Me.Version.Location = point
            Me.Version.Name = "Version"
            size = New Size(&HE9, &H45)
            Me.Version.Size = size
            Me.Version.TabIndex = 7
            Me.Version.Text = "Versione {0}.{1:00}"
            Me.PictureBox1.Image = Resources.power_explorer_splash
            point = New Point(3, 3)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(&HED, &H129)
            Me.PictureBox1.Size = size
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 5
            Me.PictureBox1.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.White
            size = New Size(&H1F0, &H12F)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.Version)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ApplicationTitle)
            Me.Controls.Add(Me.PictureBox1)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SplashScreen"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApplicationTitle.Text = MyProject.Application.Info.Title
            Me.Version.Text = ("Versione " & Application.ProductVersion)
        End Sub


        ' Properties
        Friend Overridable Property ApplicationTitle As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._ApplicationTitle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._ApplicationTitle = WithEventsValue
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

        Friend Overridable Property Version As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Version
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Version = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ApplicationTitle")> _
        Private _ApplicationTitle As Label
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Version")> _
        Private _Version As Label
    End Class
End Namespace

