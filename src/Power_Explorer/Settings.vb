Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
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
    Public Class Settings
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Settings_Load)
            Me.InitializeComponent
        End Sub

        Public Sub Apply()
            MySettingsProperty.Settings.Home = If(Not Me.SpecialPathRadio.Checked, Me.CustomText.Text, Me.SpecialPathCombo.Text)
            If Me.BlueRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H1F
                MySettingsProperty.Settings.FolderFullIcon = 30
            End If
            If Me.CyanRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H21
                MySettingsProperty.Settings.FolderFullIcon = &H20
            End If
            If Me.GreenRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H23
                MySettingsProperty.Settings.FolderFullIcon = &H22
            End If
            If Me.GreyRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H25
                MySettingsProperty.Settings.FolderFullIcon = &H24
            End If
            If Me.OrangeRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H27
                MySettingsProperty.Settings.FolderFullIcon = &H26
            End If
            If Me.YellowRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = 5
                MySettingsProperty.Settings.FolderFullIcon = &H1D
            End If
            If Me.RedRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H29
                MySettingsProperty.Settings.FolderFullIcon = 40
            End If
            If Me.VioletRadio.Checked Then
                MySettingsProperty.Settings.FolderIcon = &H2B
                MySettingsProperty.Settings.FolderFullIcon = &H2A
            End If
            MyProject.Forms.Main.Go(MyProject.Forms.Main.DirectoryText.Text, True)
            MySettingsProperty.Settings.Save
            MyProject.Forms.Main.LoadFavourites
        End Sub

        Private Sub ApplyButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apply
        End Sub

        Private Sub AutoUpdateCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.AutoUpdateUpDown.Enabled = Me.AutoUpdateCheck.Checked
        End Sub

        Private Sub BlueRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.BlueRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_blue_open
            End If
        End Sub

        Private Sub BrowseAntivirButt_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.AntivirDial.ShowDialog
            If (Me.AntivirDial.FileName <> "") Then
                Me.AntivirPathText.Text = Me.AntivirDial.FileName
            End If
        End Sub

        Private Sub BrowseButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.BrowseDial.ShowDialog
            Me.CustomText.Text = Me.BrowseDial.SelectedPath
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.OpenDial.InitialDirectory = Me.OpenCombo.Text
            Me.OpenDial.ShowDialog
            If (Me.OpenDial.FileName <> "") Then
                Me.OpenCombo.Items.Clear
                Me.OpenCombo.Text = Me.OpenDial.FileName
                Me.OpenCombo.Items.Add("Applicazione predefinita")
                Me.OpenCombo.Items.Add(Me.OpenDial.FileName)
            End If
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim writer As New StreamWriter((Application.StartupPath & "\Extension.txt"), True)
            writer.WriteLine
            writer.Write((Interaction.InputBox("Inserire l'estensione da aggiungere:", "Estensione", ".", -1, -1) & "|" & Interaction.InputBox("Inserire il percorso dell'applicazione da usare per aprire l'estensione:" & ChrW(13) & "(per l'applicazione predefinita, scrivere Default)", "Applicazione", "Default", -1, -1)))
            writer.Close
            Me.LoadSettings
        End Sub

        Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.IconDial.ShowDialog
            If (Me.IconDial.FileName <> "") Then
                Me.IconText.Text = Me.IconDial.FileName
            End If
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub CustomRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.CustomRadio.Checked Then
                Me.CustomText.Enabled = False
                Me.BrowseButt.Enabled = False
            Else
                Me.CustomText.Enabled = True
                Me.BrowseButt.Enabled = True
            End If
        End Sub

        Private Sub CyanRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.CyanRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_cyan_open
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub GreenRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.GreenRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_green_open
            End If
        End Sub

        Private Sub GreyRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.GreyRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_grey_open
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(Settings))
            Me.TabControl1 = New TabControl
            Me.MainTab = New TabPage
            Me.GroupBox2 = New GroupBox
            Me.SpecialPathRadio = New RadioButton
            Me.BrowseButt = New Button
            Me.SpecialPathCombo = New ComboBox
            Me.CustomText = New TextBox
            Me.CustomRadio = New RadioButton
            Me.PreviewGroup = New GroupBox
            Me.PreiewLab = New Label
            Me.LookTab = New TabPage
            Me.GroupBox1 = New GroupBox
            Me.YellowRadio = New RadioButton
            Me.BlueRadio = New RadioButton
            Me.VioletRadio = New RadioButton
            Me.CyanRadio = New RadioButton
            Me.RedRadio = New RadioButton
            Me.GreenRadio = New RadioButton
            Me.OrangeRadio = New RadioButton
            Me.GreyRadio = New RadioButton
            Me.ExtensionTab = New TabPage
            Me.Button1 = New Button
            Me.IconText = New TextBox
            Me.ExtensionText = New TextBox
            Me.OpenLab = New Label
            Me.IconLab = New Label
            Me.ExtensionLab = New Label
            Me.Button4 = New Button
            Me.OpenCombo = New ComboBox
            Me.Button3 = New Button
            Me.Button2 = New Button
            Me.ExtensionList = New ListBox
            Me.SecurityLab = New TabPage
            Me.GroupBox3 = New GroupBox
            Me.CheckBox3 = New CheckBox
            Me.BrowseAntivirButt = New Button
            Me.CheckBox2 = New CheckBox
            Me.Label1 = New Label
            Me.CheckBox1 = New CheckBox
            Me.OKButt = New Button
            Me.ApplyButt = New Button
            Me.CancelButt = New Button
            Me.ResetButt = New Button
            Me.BrowseDial = New FolderBrowserDialog
            Me.IconDial = New OpenFileDialog
            Me.AntivirDial = New OpenFileDialog
            Me.OpenDial = New OpenFileDialog
            Me.AutoUpdateUpDown = New NumericUpDown
            Me.AutoUpdateCheck = New CheckBox
            Me.PreviewVideoCheck = New CheckBox
            Me.PreviewImagesCheck = New CheckBox
            Me.PreviewAudioCheck = New CheckBox
            Me.PreviewTextCheck = New CheckBox
            Me.PreviewHtmlCheck = New CheckBox
            Me.AntivirPathText = New TextBox
            Me.PreviewPict = New PictureBox
            Me.ExtensionPict = New PictureBox
            Me.TabControl1.SuspendLayout
            Me.MainTab.SuspendLayout
            Me.GroupBox2.SuspendLayout
            Me.PreviewGroup.SuspendLayout
            Me.LookTab.SuspendLayout
            Me.GroupBox1.SuspendLayout
            Me.ExtensionTab.SuspendLayout
            Me.SecurityLab.SuspendLayout
            Me.GroupBox3.SuspendLayout
            Me.AutoUpdateUpDown.BeginInit
            DirectCast(Me.PreviewPict, ISupportInitialize).BeginInit
            DirectCast(Me.ExtensionPict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.TabControl1.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.TabControl1.Controls.Add(Me.MainTab)
            Me.TabControl1.Controls.Add(Me.LookTab)
            Me.TabControl1.Controls.Add(Me.ExtensionTab)
            Me.TabControl1.Controls.Add(Me.SecurityLab)
            Dim point As New Point(12, 12)
            Me.TabControl1.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim size As New Size(&H1D4, &H139)
            Me.TabControl1.Size = size
            Me.TabControl1.TabIndex = 0
            Me.MainTab.Controls.Add(Me.AutoUpdateUpDown)
            Me.MainTab.Controls.Add(Me.AutoUpdateCheck)
            Me.MainTab.Controls.Add(Me.GroupBox2)
            Me.MainTab.Controls.Add(Me.PreviewGroup)
            point = New Point(4, &H16)
            Me.MainTab.Location = point
            Me.MainTab.Name = "MainTab"
            Dim padding As New Padding(3)
            Me.MainTab.Padding = padding
            size = New Size(460, &H11F)
            Me.MainTab.Size = size
            Me.MainTab.TabIndex = 0
            Me.MainTab.Text = "Generale"
            Me.MainTab.UseVisualStyleBackColor = True
            Me.GroupBox2.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.GroupBox2.Controls.Add(Me.SpecialPathRadio)
            Me.GroupBox2.Controls.Add(Me.BrowseButt)
            Me.GroupBox2.Controls.Add(Me.SpecialPathCombo)
            Me.GroupBox2.Controls.Add(Me.CustomText)
            Me.GroupBox2.Controls.Add(Me.CustomRadio)
            point = New Point(6, 6)
            Me.GroupBox2.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            size = New Size(&H128, &H7D)
            Me.GroupBox2.Size = size
            Me.GroupBox2.TabIndex = &H11
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Home"
            Me.SpecialPathRadio.AutoSize = True
            Me.SpecialPathRadio.Checked = True
            point = New Point(6, &H13)
            Me.SpecialPathRadio.Location = point
            Me.SpecialPathRadio.Name = "SpecialPathRadio"
            size = New Size(&H70, &H11)
            Me.SpecialPathRadio.Size = size
            Me.SpecialPathRadio.TabIndex = 13
            Me.SpecialPathRadio.TabStop = True
            Me.SpecialPathRadio.Text = "Percorso speciale:"
            Me.SpecialPathRadio.UseVisualStyleBackColor = True
            Me.BrowseButt.Enabled = False
            point = New Point(&HDD, &H55)
            Me.BrowseButt.Location = point
            Me.BrowseButt.Name = "BrowseButt"
            size = New Size(&H45, &H17)
            Me.BrowseButt.Size = size
            Me.BrowseButt.TabIndex = &H10
            Me.BrowseButt.Text = "Sfoglia..."
            Me.BrowseButt.UseVisualStyleBackColor = True
            Me.SpecialPathCombo.FormattingEnabled = True
            Dim items As Object() = New Object() { "Computer", "Documenti", "Immagini", "Musica", "Programmi", "Desktop" }
            Me.SpecialPathCombo.Items.AddRange(items)
            point = New Point(&H18, &H25)
            Me.SpecialPathCombo.Location = point
            Me.SpecialPathCombo.Name = "SpecialPathCombo"
            size = New Size(&H10A, &H15)
            Me.SpecialPathCombo.Size = size
            Me.SpecialPathCombo.TabIndex = 4
            Me.SpecialPathCombo.Text = "Computer"
            Me.CustomText.Enabled = False
            point = New Point(&H18, &H57)
            Me.CustomText.Location = point
            Me.CustomText.Name = "CustomText"
            size = New Size(&HBF, 20)
            Me.CustomText.Size = size
            Me.CustomText.TabIndex = 15
            Me.CustomRadio.AutoSize = True
            point = New Point(6, &H40)
            Me.CustomRadio.Location = point
            Me.CustomRadio.Name = "CustomRadio"
            size = New Size(140, &H11)
            Me.CustomRadio.Size = size
            Me.CustomRadio.TabIndex = 14
            Me.CustomRadio.Text = "Percorso personalizzato:"
            Me.CustomRadio.UseVisualStyleBackColor = True
            Me.PreviewGroup.Anchor = (AnchorStyles.Right Or AnchorStyles.Top)
            Me.PreviewGroup.Controls.Add(Me.PreiewLab)
            Me.PreviewGroup.Controls.Add(Me.PreviewVideoCheck)
            Me.PreviewGroup.Controls.Add(Me.PreviewImagesCheck)
            Me.PreviewGroup.Controls.Add(Me.PreviewAudioCheck)
            Me.PreviewGroup.Controls.Add(Me.PreviewTextCheck)
            Me.PreviewGroup.Controls.Add(Me.PreviewHtmlCheck)
            point = New Point(&H134, 6)
            Me.PreviewGroup.Location = point
            Me.PreviewGroup.Name = "PreviewGroup"
            size = New Size(&H92, 130)
            Me.PreviewGroup.Size = size
            Me.PreviewGroup.TabIndex = 12
            Me.PreviewGroup.TabStop = False
            Me.PreviewGroup.Text = "Anteprima"
            Me.PreiewLab.AutoSize = True
            point = New Point(6, &H10)
            Me.PreiewLab.Location = point
            Me.PreiewLab.Name = "PreiewLab"
            size = New Size(&H7B, 13)
            Me.PreiewLab.Size = size
            Me.PreiewLab.TabIndex = 6
            Me.PreiewLab.Text = "Visualizza anteprima per:"
            Me.LookTab.Controls.Add(Me.GroupBox1)
            point = New Point(4, &H16)
            Me.LookTab.Location = point
            Me.LookTab.Name = "LookTab"
            padding = New Padding(3)
            Me.LookTab.Padding = padding
            size = New Size(460, &H11F)
            Me.LookTab.Size = size
            Me.LookTab.TabIndex = 1
            Me.LookTab.Text = "Aspetto"
            Me.LookTab.UseVisualStyleBackColor = True
            Me.GroupBox1.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.GroupBox1.Controls.Add(Me.PreviewPict)
            Me.GroupBox1.Controls.Add(Me.YellowRadio)
            Me.GroupBox1.Controls.Add(Me.BlueRadio)
            Me.GroupBox1.Controls.Add(Me.VioletRadio)
            Me.GroupBox1.Controls.Add(Me.CyanRadio)
            Me.GroupBox1.Controls.Add(Me.RedRadio)
            Me.GroupBox1.Controls.Add(Me.GreenRadio)
            Me.GroupBox1.Controls.Add(Me.OrangeRadio)
            Me.GroupBox1.Controls.Add(Me.GreyRadio)
            point = New Point(6, 6)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&H1C0, &H5B)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Colore dell'icona delle cartelle"
            Me.YellowRadio.AutoSize = True
            point = New Point(&HAC, &H13)
            Me.YellowRadio.Location = point
            Me.YellowRadio.Name = "YellowRadio"
            size = New Size(&H33, &H11)
            Me.YellowRadio.Size = size
            Me.YellowRadio.TabIndex = 8
            Me.YellowRadio.Text = "Giallo"
            Me.YellowRadio.UseVisualStyleBackColor = True
            Me.BlueRadio.AutoSize = True
            point = New Point(&H4C, &H13)
            Me.BlueRadio.Location = point
            Me.BlueRadio.Name = "BlueRadio"
            size = New Size(40, &H11)
            Me.BlueRadio.Size = size
            Me.BlueRadio.TabIndex = 1
            Me.BlueRadio.Text = "Blu"
            Me.BlueRadio.UseVisualStyleBackColor = True
            Me.VioletRadio.AutoSize = True
            point = New Point(&HFB, &H13)
            Me.VioletRadio.Location = point
            Me.VioletRadio.Name = "VioletRadio"
            size = New Size(&H30, &H11)
            Me.VioletRadio.Size = size
            Me.VioletRadio.TabIndex = 7
            Me.VioletRadio.Text = "Viola"
            Me.VioletRadio.UseVisualStyleBackColor = True
            Me.CyanRadio.AutoSize = True
            point = New Point(&H4C, &H2A)
            Me.CyanRadio.Location = point
            Me.CyanRadio.Name = "CyanRadio"
            size = New Size(&H31, &H11)
            Me.CyanRadio.Size = size
            Me.CyanRadio.TabIndex = 2
            Me.CyanRadio.Text = "Cyan"
            Me.CyanRadio.UseVisualStyleBackColor = True
            Me.RedRadio.AutoSize = True
            point = New Point(&HAC, &H41)
            Me.RedRadio.Location = point
            Me.RedRadio.Name = "RedRadio"
            size = New Size(&H37, &H11)
            Me.RedRadio.Size = size
            Me.RedRadio.TabIndex = 6
            Me.RedRadio.Text = "Rosso"
            Me.RedRadio.UseVisualStyleBackColor = True
            Me.GreenRadio.AutoSize = True
            Me.GreenRadio.Checked = True
            point = New Point(&H4C, &H41)
            Me.GreenRadio.Location = point
            Me.GreenRadio.Name = "GreenRadio"
            size = New Size(&H35, &H11)
            Me.GreenRadio.Size = size
            Me.GreenRadio.TabIndex = 3
            Me.GreenRadio.TabStop = True
            Me.GreenRadio.Text = "Verde"
            Me.GreenRadio.UseVisualStyleBackColor = True
            Me.OrangeRadio.AutoSize = True
            point = New Point(&HAC, &H2A)
            Me.OrangeRadio.Location = point
            Me.OrangeRadio.Name = "OrangeRadio"
            size = New Size(&H49, &H11)
            Me.OrangeRadio.Size = size
            Me.OrangeRadio.TabIndex = 5
            Me.OrangeRadio.Text = "Arancione"
            Me.OrangeRadio.UseVisualStyleBackColor = True
            Me.GreyRadio.AutoSize = True
            point = New Point(&HFB, &H2A)
            Me.GreyRadio.Location = point
            Me.GreyRadio.Name = "GreyRadio"
            size = New Size(&H34, &H11)
            Me.GreyRadio.Size = size
            Me.GreyRadio.TabIndex = 4
            Me.GreyRadio.Text = "Grigio"
            Me.GreyRadio.UseVisualStyleBackColor = True
            Me.ExtensionTab.Controls.Add(Me.Button1)
            Me.ExtensionTab.Controls.Add(Me.IconText)
            Me.ExtensionTab.Controls.Add(Me.ExtensionText)
            Me.ExtensionTab.Controls.Add(Me.OpenLab)
            Me.ExtensionTab.Controls.Add(Me.IconLab)
            Me.ExtensionTab.Controls.Add(Me.ExtensionLab)
            Me.ExtensionTab.Controls.Add(Me.Button4)
            Me.ExtensionTab.Controls.Add(Me.ExtensionPict)
            Me.ExtensionTab.Controls.Add(Me.OpenCombo)
            Me.ExtensionTab.Controls.Add(Me.Button3)
            Me.ExtensionTab.Controls.Add(Me.Button2)
            Me.ExtensionTab.Controls.Add(Me.ExtensionList)
            point = New Point(4, &H16)
            Me.ExtensionTab.Location = point
            Me.ExtensionTab.Name = "ExtensionTab"
            padding = New Padding(3)
            Me.ExtensionTab.Padding = padding
            size = New Size(460, &H11F)
            Me.ExtensionTab.Size = size
            Me.ExtensionTab.TabIndex = 2
            Me.ExtensionTab.Text = "Estenzioni"
            Me.ExtensionTab.UseVisualStyleBackColor = True
            Me.Button1.Anchor = (AnchorStyles.Right Or AnchorStyles.Top)
            point = New Point(&H17B, &H7D)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            size = New Size(&H4B, &H17)
            Me.Button1.Size = size
            Me.Button1.TabIndex = &H34
            Me.Button1.Text = "Seleziona..."
            Me.Button1.UseVisualStyleBackColor = True
            Me.IconText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            point = New Point(&HC5, &H66)
            Me.IconText.Location = point
            Me.IconText.Name = "IconText"
            size = New Size(&HB0, 20)
            Me.IconText.Size = size
            Me.IconText.TabIndex = &H33
            Me.ExtensionText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            point = New Point(&HC5, &H4C)
            Me.ExtensionText.Location = point
            Me.ExtensionText.Name = "ExtensionText"
            size = New Size(&H101, 20)
            Me.ExtensionText.Size = size
            Me.ExtensionText.TabIndex = 50
            Me.OpenLab.AutoSize = True
            point = New Point(&H84, &H83)
            Me.OpenLab.Location = point
            Me.OpenLab.Name = "OpenLab"
            size = New Size(&H2E, 13)
            Me.OpenLab.Size = size
            Me.OpenLab.TabIndex = &H31
            Me.OpenLab.Text = "Apri con"
            Me.IconLab.AutoSize = True
            point = New Point(&H84, &H69)
            Me.IconLab.Location = point
            Me.IconLab.Name = "IconLab"
            size = New Size(&H22, 13)
            Me.IconLab.Size = size
            Me.IconLab.TabIndex = &H30
            Me.IconLab.Text = "Icona"
            Me.ExtensionLab.AutoSize = True
            point = New Point(&H84, &H4F)
            Me.ExtensionLab.Location = point
            Me.ExtensionLab.Name = "ExtensionLab"
            size = New Size(&H3B, 13)
            Me.ExtensionLab.Size = size
            Me.ExtensionLab.TabIndex = &H2F
            Me.ExtensionLab.Text = "Estenzione"
            Me.Button4.Anchor = (AnchorStyles.Right Or AnchorStyles.Top)
            point = New Point(&H17B, &H63)
            Me.Button4.Location = point
            Me.Button4.Name = "Button4"
            size = New Size(&H4B, &H17)
            Me.Button4.Size = size
            Me.Button4.TabIndex = &H2E
            Me.Button4.Text = "Seleziona..."
            Me.Button4.UseVisualStyleBackColor = True
            Me.OpenCombo.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.OpenCombo.FormattingEnabled = True
            items = New Object() { "Applicazione predefinita" }
            Me.OpenCombo.Items.AddRange(items)
            point = New Point(&HC5, &H7E)
            Me.OpenCombo.Location = point
            Me.OpenCombo.Name = "OpenCombo"
            size = New Size(&HB0, &H15)
            Me.OpenCombo.Size = size
            Me.OpenCombo.TabIndex = 9
            Me.OpenCombo.Text = "Applicazione predefinita"
            Me.Button3.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            point = New Point(&HD5, &H102)
            Me.Button3.Location = point
            Me.Button3.Name = "Button3"
            size = New Size(&H4B, &H17)
            Me.Button3.Size = size
            Me.Button3.TabIndex = 6
            Me.Button3.Text = "Elimina"
            Me.Button3.UseVisualStyleBackColor = True
            Me.Button2.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            Me.Button2.ImageAlign = ContentAlignment.MiddleLeft
            point = New Point(&H84, &H102)
            Me.Button2.Location = point
            Me.Button2.Name = "Button2"
            size = New Size(&H4B, &H17)
            Me.Button2.Size = size
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "Aggiungi"
            Me.Button2.UseVisualStyleBackColor = True
            Me.ExtensionList.Anchor = (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top))
            Me.ExtensionList.FormattingEnabled = True
            point = New Point(6, 6)
            Me.ExtensionList.Location = point
            Me.ExtensionList.Name = "ExtensionList"
            Me.ExtensionList.ScrollAlwaysVisible = True
            size = New Size(120, &H115)
            Me.ExtensionList.Size = size
            Me.ExtensionList.TabIndex = 0
            Me.SecurityLab.Controls.Add(Me.GroupBox3)
            point = New Point(4, &H16)
            Me.SecurityLab.Location = point
            Me.SecurityLab.Name = "SecurityLab"
            padding = New Padding(3)
            Me.SecurityLab.Padding = padding
            size = New Size(460, &H11F)
            Me.SecurityLab.Size = size
            Me.SecurityLab.TabIndex = 3
            Me.SecurityLab.Text = "Sicurezza"
            Me.SecurityLab.UseVisualStyleBackColor = True
            Me.GroupBox3.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.GroupBox3.Controls.Add(Me.CheckBox3)
            Me.GroupBox3.Controls.Add(Me.BrowseAntivirButt)
            Me.GroupBox3.Controls.Add(Me.CheckBox2)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Controls.Add(Me.CheckBox1)
            Me.GroupBox3.Controls.Add(Me.AntivirPathText)
            point = New Point(6, 6)
            Me.GroupBox3.Location = point
            Me.GroupBox3.Name = "GroupBox3"
            size = New Size(&H1C0, &H4F)
            Me.GroupBox3.Size = size
            Me.GroupBox3.TabIndex = 3
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Antivirus"
            Me.CheckBox3.AutoSize = True
            point = New Point(180, &H3A)
            Me.CheckBox3.Location = point
            Me.CheckBox3.Name = "CheckBox3"
            size = New Size(&H51, &H11)
            Me.CheckBox3.Size = size
            Me.CheckBox3.TabIndex = 6
            Me.CheckBox3.Text = "CheckBox3"
            Me.CheckBox3.UseVisualStyleBackColor = True
            point = New Point(&H16F, 30)
            Me.BrowseAntivirButt.Location = point
            Me.BrowseAntivirButt.Name = "BrowseAntivirButt"
            size = New Size(&H4B, &H17)
            Me.BrowseAntivirButt.Size = size
            Me.BrowseAntivirButt.TabIndex = 4
            Me.BrowseAntivirButt.Text = "&Sfoglia..."
            Me.BrowseAntivirButt.UseVisualStyleBackColor = True
            Me.CheckBox2.AutoSize = True
            point = New Point(&H5D, &H3A)
            Me.CheckBox2.Location = point
            Me.CheckBox2.Name = "CheckBox2"
            size = New Size(&H51, &H11)
            Me.CheckBox2.Size = size
            Me.CheckBox2.TabIndex = 5
            Me.CheckBox2.Text = "CheckBox2"
            Me.CheckBox2.UseVisualStyleBackColor = True
            Me.Label1.AutoSize = True
            point = New Point(6, &H10)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H175, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Inserire il percorso dell'antivirus presente nel computer (se se ne dispone uno):"
            Me.CheckBox1.AutoSize = True
            point = New Point(6, &H3A)
            Me.CheckBox1.Location = point
            Me.CheckBox1.Name = "CheckBox1"
            size = New Size(&H51, &H11)
            Me.CheckBox1.Size = size
            Me.CheckBox1.TabIndex = 4
            Me.CheckBox1.Text = "CheckBox1"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Me.OKButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H195, &H14B)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 1
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.ApplyButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H144, &H14B)
            Me.ApplyButt.Location = point
            Me.ApplyButt.Name = "ApplyButt"
            size = New Size(&H4B, &H17)
            Me.ApplyButt.Size = size
            Me.ApplyButt.TabIndex = 2
            Me.ApplyButt.Text = "A&pplica"
            Me.ApplyButt.UseVisualStyleBackColor = True
            Me.CancelButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&HF3, &H14B)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 3
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.ResetButt.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            point = New Point(12, &H14B)
            Me.ResetButt.Location = point
            Me.ResetButt.Name = "ResetButt"
            size = New Size(&H4B, &H17)
            Me.ResetButt.Size = size
            Me.ResetButt.TabIndex = 4
            Me.ResetButt.Text = "&Reimposta"
            Me.ResetButt.UseVisualStyleBackColor = True
            Me.BrowseDial.RootFolder = SpecialFolder.MyComputer
            Me.IconDial.Filter = "File icona|*.ico"
            Me.IconDial.Title = "Seleziona l'icona da utilizzare"
            Me.AntivirDial.InitialDirectory = "C:\Programmi\"
            Me.AntivirDial.RestoreDirectory = True
            Me.AutoUpdateUpDown.DataBindings.Add(New Binding("Value", MySettings.Default, "DaysUpdate", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(&H11E, &H8E)
            Me.AutoUpdateUpDown.Location = point
            Dim num As New Decimal(New Integer() { 30, 0, 0, 0 })
            Me.AutoUpdateUpDown.Maximum = num
            num = New Decimal(New Integer() { 1, 0, 0, 0 })
            Me.AutoUpdateUpDown.Minimum = num
            Me.AutoUpdateUpDown.Name = "AutoUpdateUpDown"
            size = New Size(&H29, 20)
            Me.AutoUpdateUpDown.Size = size
            Me.AutoUpdateUpDown.TabIndex = &H13
            Me.AutoUpdateUpDown.Value = MySettings.Default.DaysUpdate
            Me.AutoUpdateCheck.AutoSize = True
            Me.AutoUpdateCheck.Checked = MySettings.Default.AutoUpdate
            Me.AutoUpdateCheck.CheckState = CheckState.Checked
            Me.AutoUpdateCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "AutoUpdate", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H8F)
            Me.AutoUpdateCheck.Location = point
            Me.AutoUpdateCheck.Name = "AutoUpdateCheck"
            size = New Size(&H112, &H11)
            Me.AutoUpdateCheck.Size = size
            Me.AutoUpdateCheck.TabIndex = &H12
            Me.AutoUpdateCheck.Text = "Cerca automaticamente gli aggiornamenti ogni giorni:"
            Me.AutoUpdateCheck.UseVisualStyleBackColor = True
            Me.PreviewVideoCheck.AutoSize = True
            Me.PreviewVideoCheck.Checked = MySettings.Default.PreviewVideo
            Me.PreviewVideoCheck.CheckState = CheckState.Checked
            Me.PreviewVideoCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "PreviewVideo", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H6C)
            Me.PreviewVideoCheck.Location = point
            Me.PreviewVideoCheck.Name = "PreviewVideoCheck"
            size = New Size(&H47, &H11)
            Me.PreviewVideoCheck.Size = size
            Me.PreviewVideoCheck.TabIndex = 11
            Me.PreviewVideoCheck.Text = "File video"
            Me.PreviewVideoCheck.UseVisualStyleBackColor = True
            Me.PreviewImagesCheck.AutoSize = True
            Me.PreviewImagesCheck.Checked = MySettings.Default.PreviewImages
            Me.PreviewImagesCheck.CheckState = CheckState.Checked
            Me.PreviewImagesCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "PreviewImages", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H20)
            Me.PreviewImagesCheck.Location = point
            Me.PreviewImagesCheck.Name = "PreviewImagesCheck"
            size = New Size(&H43, &H11)
            Me.PreviewImagesCheck.Size = size
            Me.PreviewImagesCheck.TabIndex = 7
            Me.PreviewImagesCheck.Text = "Immagini"
            Me.PreviewImagesCheck.UseVisualStyleBackColor = True
            Me.PreviewAudioCheck.AutoSize = True
            Me.PreviewAudioCheck.Checked = MySettings.Default.PreviewAudio
            Me.PreviewAudioCheck.CheckState = CheckState.Checked
            Me.PreviewAudioCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "PreviewAudio", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H59)
            Me.PreviewAudioCheck.Location = point
            Me.PreviewAudioCheck.Name = "PreviewAudioCheck"
            size = New Size(&H47, &H11)
            Me.PreviewAudioCheck.Size = size
            Me.PreviewAudioCheck.TabIndex = 10
            Me.PreviewAudioCheck.Text = "File audio"
            Me.PreviewAudioCheck.UseVisualStyleBackColor = True
            Me.PreviewTextCheck.AutoSize = True
            Me.PreviewTextCheck.Checked = MySettings.Default.PreviewText
            Me.PreviewTextCheck.CheckState = CheckState.Checked
            Me.PreviewTextCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "PreviewText", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H33)
            Me.PreviewTextCheck.Location = point
            Me.PreviewTextCheck.Name = "PreviewTextCheck"
            size = New Size(&H4F, &H11)
            Me.PreviewTextCheck.Size = size
            Me.PreviewTextCheck.TabIndex = 8
            Me.PreviewTextCheck.Text = "File di testo"
            Me.PreviewTextCheck.UseVisualStyleBackColor = True
            Me.PreviewHtmlCheck.AutoSize = True
            Me.PreviewHtmlCheck.Checked = MySettings.Default.PreviewHtml
            Me.PreviewHtmlCheck.CheckState = CheckState.Checked
            Me.PreviewHtmlCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "PreviewHtml", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, 70)
            Me.PreviewHtmlCheck.Location = point
            Me.PreviewHtmlCheck.Name = "PreviewHtmlCheck"
            size = New Size(&H5C, &H11)
            Me.PreviewHtmlCheck.Size = size
            Me.PreviewHtmlCheck.TabIndex = 9
            Me.PreviewHtmlCheck.Text = "Pagine HTML"
            Me.PreviewHtmlCheck.UseVisualStyleBackColor = True
            Me.AntivirPathText.DataBindings.Add(New Binding("Text", MySettings.Default, "Antivirus", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H20)
            Me.AntivirPathText.Location = point
            Me.AntivirPathText.Name = "AntivirPathText"
            size = New Size(&H163, 20)
            Me.AntivirPathText.Size = size
            Me.AntivirPathText.TabIndex = 0
            Me.AntivirPathText.Text = MySettings.Default.Antivirus
            Me.PreviewPict.Image = Resources.folder_green_open
            point = New Point(6, &H13)
            Me.PreviewPict.Location = point
            Me.PreviewPict.Name = "PreviewPict"
            size = New Size(&H40, &H40)
            Me.PreviewPict.Size = size
            Me.PreviewPict.SizeMode = PictureBoxSizeMode.Zoom
            Me.PreviewPict.TabIndex = 0
            Me.PreviewPict.TabStop = False
            Me.ExtensionPict.Image = Resources.dvd_128
            point = New Point(&H84, 6)
            Me.ExtensionPict.Location = point
            Me.ExtensionPict.Name = "ExtensionPict"
            size = New Size(&H40, &H40)
            Me.ExtensionPict.Size = size
            Me.ExtensionPict.SizeMode = PictureBoxSizeMode.Zoom
            Me.ExtensionPict.TabIndex = 11
            Me.ExtensionPict.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1EC, &H16E)
            Me.ClientSize = size
            Me.Controls.Add(Me.ResetButt)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.ApplyButt)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.TabControl1)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "Settings"
            Me.Text = "Opzioni"
            Me.TabControl1.ResumeLayout(False)
            Me.MainTab.ResumeLayout(False)
            Me.MainTab.PerformLayout
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout
            Me.PreviewGroup.ResumeLayout(False)
            Me.PreviewGroup.PerformLayout
            Me.LookTab.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            Me.ExtensionTab.ResumeLayout(False)
            Me.ExtensionTab.PerformLayout
            Me.SecurityLab.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout
            Me.AutoUpdateUpDown.EndInit
            DirectCast(Me.PreviewPict, ISupportInitialize).EndInit
            DirectCast(Me.ExtensionPict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExtensionText.Text = Conversions.ToString(Me.ExtensionList.SelectedItem)
            Dim item As String = "Default"
            Dim reader As New StreamReader((Application.StartupPath & "\Extension.txt"))
            Dim num3 As Short = CShort((Me.ExtensionList.SelectedIndex - 1))
            Dim i As Short = 0
            Do While (i <= num3)
                reader.ReadLine
                i = CShort((i + 1))
            Loop
            Dim str As String = reader.ReadLine
            item = str.Remove(0, CShort((str.LastIndexOf("|") + 1)))
            reader.Close
            If (item = "Default") Then
                Me.OpenCombo.Items.Clear
                Me.OpenCombo.Text = "Applicazione predefinita"
                Me.OpenCombo.Items.Add("Applicazione predefinita")
            Else
                Me.OpenCombo.Items.Clear
                Me.OpenCombo.Text = item
                Me.OpenCombo.Items.Add("Applicazione predefinita")
                Me.OpenCombo.Items.Add(item)
            End If
        End Sub

        Public Sub LoadSettings()
            Select Case MySettingsProperty.Settings.FolderIcon
                Case 5
                    Me.YellowRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_128
                    Exit Select
                Case &H1F
                    Me.BlueRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_blue_open
                    Exit Select
                Case &H21
                    Me.CyanRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_cyan_open
                    Exit Select
                Case &H23
                    Me.GreenRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_green_open
                    Exit Select
                Case &H25
                    Me.GreyRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_grey_open
                    Exit Select
                Case &H27
                    Me.OrangeRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_orange_open
                    Exit Select
                Case &H29
                    Me.RedRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_red_open
                    Exit Select
                Case &H2B
                    Me.VioletRadio.Checked = True
                    Me.PreviewPict.Image = Resources.folder_violet
                    Exit Select
                Case Else
                    Exit Select
            End Select
            Me.ExtensionList.Items.Clear
            If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Extension.txt")) Then
                Dim reader As New StreamReader((Application.StartupPath & "\Extension.txt"))
                Do While True
                    If reader.EndOfStream Then
                        reader.Close
                        Exit Do
                    End If
                    Dim str As String = reader.ReadLine
                    Dim startIndex As Short = CShort((str.LastIndexOf("|") + 1))
                    Me.ExtensionList.Items.Add(str.Remove(startIndex, (str.Length - startIndex)))
                Loop
            End If
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apply
            Me.Close
        End Sub

        Private Sub OrangeRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.OrangeRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_orange_open
            End If
        End Sub

        Private Sub RedRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RedRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_red_open
            End If
        End Sub

        Private Sub ResetButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MessageBox.Show("Vuoi davvero ripristinare le impostazioni ai loro valori di default? Le impostazioni attuali saranno perse.", "Reimpostare le opzioni?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No) Then
                MySettingsProperty.Settings.Reset
                Me.LoadSettings
                MyProject.Forms.Main.Go(MyProject.Forms.Main.DirectoryText.Text, True)
            End If
        End Sub

        Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadSettings
        End Sub

        Private Sub SpecialPathRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SpecialPathCombo.Enabled = Me.SpecialPathRadio.Checked
        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub VioletRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.VioletRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_violet
            End If
        End Sub

        Public Sub WriteExtensions()
            Dim writer As New StreamWriter((Application.StartupPath & "\Extension.txt"), False)
            Dim count As Short = CShort(Me.ExtensionList.Items.Count)
            Dim i As Short = 0
            Do While (i <= count)
                writer.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.ExtensionList.Items(i), "|"), "v"))
                i = CShort((i + 1))
            Loop
            writer.Close
        End Sub

        Private Sub YellowRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.YellowRadio.Checked Then
                Me.PreviewPict.Image = Resources.folder_128
            End If
        End Sub


        ' Properties
        Friend Overridable Property TabControl1 As TabControl
            <DebuggerNonUserCode> _
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabControl)
                If (Not Me._TabControl1 Is Nothing) Then
                    RemoveHandler Me._TabControl1.SelectedIndexChanged, New EventHandler(AddressOf Me.TabControl1_SelectedIndexChanged)
                End If
                Me._TabControl1 = WithEventsValue
                If (Not Me._TabControl1 Is Nothing) Then
                    AddHandler Me._TabControl1.SelectedIndexChanged, New EventHandler(AddressOf Me.TabControl1_SelectedIndexChanged)
                End If
            End Set
        End Property

        Friend Overridable Property MainTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._MainTab = WithEventsValue
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

        Friend Overridable Property ApplyButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ApplyButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ApplyButt Is Nothing) Then
                    RemoveHandler Me._ApplyButt.Click, New EventHandler(AddressOf Me.ApplyButt_Click)
                End If
                Me._ApplyButt = WithEventsValue
                If (Not Me._ApplyButt Is Nothing) Then
                    AddHandler Me._ApplyButt.Click, New EventHandler(AddressOf Me.ApplyButt_Click)
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

        Friend Overridable Property SpecialPathCombo As ComboBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SpecialPathCombo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._SpecialPathCombo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ResetButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ResetButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ResetButt Is Nothing) Then
                    RemoveHandler Me._ResetButt.Click, New EventHandler(AddressOf Me.ResetButt_Click)
                End If
                Me._ResetButt = WithEventsValue
                If (Not Me._ResetButt Is Nothing) Then
                    AddHandler Me._ResetButt.Click, New EventHandler(AddressOf Me.ResetButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PreiewLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PreiewLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PreiewLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewVideoCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewVideoCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._PreviewVideoCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewAudioCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewAudioCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._PreviewAudioCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewHtmlCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewHtmlCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._PreviewHtmlCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewTextCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewTextCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._PreviewTextCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewImagesCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewImagesCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._PreviewImagesCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._PreviewGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LookTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._LookTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._LookTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RedRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RedRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RedRadio Is Nothing) Then
                    RemoveHandler Me._RedRadio.CheckedChanged, New EventHandler(AddressOf Me.RedRadio_CheckedChanged)
                End If
                Me._RedRadio = WithEventsValue
                If (Not Me._RedRadio Is Nothing) Then
                    AddHandler Me._RedRadio.CheckedChanged, New EventHandler(AddressOf Me.RedRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property OrangeRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._OrangeRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._OrangeRadio Is Nothing) Then
                    RemoveHandler Me._OrangeRadio.CheckedChanged, New EventHandler(AddressOf Me.OrangeRadio_CheckedChanged)
                End If
                Me._OrangeRadio = WithEventsValue
                If (Not Me._OrangeRadio Is Nothing) Then
                    AddHandler Me._OrangeRadio.CheckedChanged, New EventHandler(AddressOf Me.OrangeRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property GreyRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._GreyRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._GreyRadio Is Nothing) Then
                    RemoveHandler Me._GreyRadio.CheckedChanged, New EventHandler(AddressOf Me.GreyRadio_CheckedChanged)
                End If
                Me._GreyRadio = WithEventsValue
                If (Not Me._GreyRadio Is Nothing) Then
                    AddHandler Me._GreyRadio.CheckedChanged, New EventHandler(AddressOf Me.GreyRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property GreenRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._GreenRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._GreenRadio Is Nothing) Then
                    RemoveHandler Me._GreenRadio.CheckedChanged, New EventHandler(AddressOf Me.GreenRadio_CheckedChanged)
                End If
                Me._GreenRadio = WithEventsValue
                If (Not Me._GreenRadio Is Nothing) Then
                    AddHandler Me._GreenRadio.CheckedChanged, New EventHandler(AddressOf Me.GreenRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property CyanRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._CyanRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._CyanRadio Is Nothing) Then
                    RemoveHandler Me._CyanRadio.CheckedChanged, New EventHandler(AddressOf Me.CyanRadio_CheckedChanged)
                End If
                Me._CyanRadio = WithEventsValue
                If (Not Me._CyanRadio Is Nothing) Then
                    AddHandler Me._CyanRadio.CheckedChanged, New EventHandler(AddressOf Me.CyanRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property BlueRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._BlueRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._BlueRadio Is Nothing) Then
                    RemoveHandler Me._BlueRadio.CheckedChanged, New EventHandler(AddressOf Me.BlueRadio_CheckedChanged)
                End If
                Me._BlueRadio = WithEventsValue
                If (Not Me._BlueRadio Is Nothing) Then
                    AddHandler Me._BlueRadio.CheckedChanged, New EventHandler(AddressOf Me.BlueRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property PreviewPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PreviewPict = WithEventsValue
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

        Friend Overridable Property CustomText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CustomText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._CustomText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CustomRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._CustomRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._CustomRadio Is Nothing) Then
                    RemoveHandler Me._CustomRadio.CheckedChanged, New EventHandler(AddressOf Me.CustomRadio_CheckedChanged)
                End If
                Me._CustomRadio = WithEventsValue
                If (Not Me._CustomRadio Is Nothing) Then
                    AddHandler Me._CustomRadio.CheckedChanged, New EventHandler(AddressOf Me.CustomRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property SpecialPathRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._SpecialPathRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._SpecialPathRadio Is Nothing) Then
                    RemoveHandler Me._SpecialPathRadio.CheckedChanged, New EventHandler(AddressOf Me.SpecialPathRadio_CheckedChanged)
                End If
                Me._SpecialPathRadio = WithEventsValue
                If (Not Me._SpecialPathRadio Is Nothing) Then
                    AddHandler Me._SpecialPathRadio.CheckedChanged, New EventHandler(AddressOf Me.SpecialPathRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property BrowseDial As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._BrowseDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._BrowseDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExtensionTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._ExtensionTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._ExtensionTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExtensionList As ListBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ExtensionList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListBox)
                If (Not Me._ExtensionList Is Nothing) Then
                    RemoveHandler Me._ExtensionList.SelectedIndexChanged, New EventHandler(AddressOf Me.ListBox1_SelectedIndexChanged)
                End If
                Me._ExtensionList = WithEventsValue
                If (Not Me._ExtensionList Is Nothing) Then
                    AddHandler Me._ExtensionList.SelectedIndexChanged, New EventHandler(AddressOf Me.ListBox1_SelectedIndexChanged)
                End If
            End Set
        End Property

        Friend Overridable Property OpenCombo As ComboBox
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenCombo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._OpenCombo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Button3 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._Button3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Button2 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button2 Is Nothing) Then
                    RemoveHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
                Me._Button2 = WithEventsValue
                If (Not Me._Button2 Is Nothing) Then
                    AddHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ExtensionPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ExtensionPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._ExtensionPict = WithEventsValue
            End Set
        End Property

        Friend Overridable Property YellowRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._YellowRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._YellowRadio Is Nothing) Then
                    RemoveHandler Me._YellowRadio.CheckedChanged, New EventHandler(AddressOf Me.YellowRadio_CheckedChanged)
                End If
                Me._YellowRadio = WithEventsValue
                If (Not Me._YellowRadio Is Nothing) Then
                    AddHandler Me._YellowRadio.CheckedChanged, New EventHandler(AddressOf Me.YellowRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property VioletRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._VioletRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._VioletRadio Is Nothing) Then
                    RemoveHandler Me._VioletRadio.CheckedChanged, New EventHandler(AddressOf Me.VioletRadio_CheckedChanged)
                End If
                Me._VioletRadio = WithEventsValue
                If (Not Me._VioletRadio Is Nothing) Then
                    AddHandler Me._VioletRadio.CheckedChanged, New EventHandler(AddressOf Me.VioletRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupBox2 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property IconDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._IconDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._IconDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SecurityLab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._SecurityLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._SecurityLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupBox3 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AntivirPathText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AntivirPathText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._AntivirPathText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AntivirDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._AntivirDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._AntivirDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BrowseAntivirButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._BrowseAntivirButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._BrowseAntivirButt Is Nothing) Then
                    RemoveHandler Me._BrowseAntivirButt.Click, New EventHandler(AddressOf Me.BrowseAntivirButt_Click_1)
                End If
                Me._BrowseAntivirButt = WithEventsValue
                If (Not Me._BrowseAntivirButt Is Nothing) Then
                    AddHandler Me._BrowseAntivirButt.Click, New EventHandler(AddressOf Me.BrowseAntivirButt_Click_1)
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

        Friend Overridable Property IconText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._IconText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._IconText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExtensionText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ExtensionText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._ExtensionText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OpenLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._OpenLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property IconLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._IconLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._IconLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExtensionLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._ExtensionLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._ExtensionLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Button4 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button4 Is Nothing) Then
                    RemoveHandler Me._Button4.Click, New EventHandler(AddressOf Me.Button4_Click)
                End If
                Me._Button4 = WithEventsValue
                If (Not Me._Button4 Is Nothing) Then
                    AddHandler Me._Button4.Click, New EventHandler(AddressOf Me.Button4_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Button1 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button1 Is Nothing) Then
                    RemoveHandler Me._Button1.Click, New EventHandler(AddressOf Me.Button1_Click)
                End If
                Me._Button1 = WithEventsValue
                If (Not Me._Button1 Is Nothing) Then
                    AddHandler Me._Button1.Click, New EventHandler(AddressOf Me.Button1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OpenDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._OpenDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._OpenDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox3 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox2 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox1 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AutoUpdateUpDown As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._AutoUpdateUpDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._AutoUpdateUpDown = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AutoUpdateCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AutoUpdateCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._AutoUpdateCheck Is Nothing) Then
                    RemoveHandler Me._AutoUpdateCheck.CheckedChanged, New EventHandler(AddressOf Me.AutoUpdateCheck_CheckedChanged)
                End If
                Me._AutoUpdateCheck = WithEventsValue
                If (Not Me._AutoUpdateCheck Is Nothing) Then
                    AddHandler Me._AutoUpdateCheck.CheckedChanged, New EventHandler(AddressOf Me.AutoUpdateCheck_CheckedChanged)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("MainTab")> _
        Private _MainTab As TabPage
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("ApplyButt")> _
        Private _ApplyButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("SpecialPathCombo")> _
        Private _SpecialPathCombo As ComboBox
        <AccessedThroughProperty("ResetButt")> _
        Private _ResetButt As Button
        <AccessedThroughProperty("PreiewLab")> _
        Private _PreiewLab As Label
        <AccessedThroughProperty("PreviewVideoCheck")> _
        Private _PreviewVideoCheck As CheckBox
        <AccessedThroughProperty("PreviewAudioCheck")> _
        Private _PreviewAudioCheck As CheckBox
        <AccessedThroughProperty("PreviewHtmlCheck")> _
        Private _PreviewHtmlCheck As CheckBox
        <AccessedThroughProperty("PreviewTextCheck")> _
        Private _PreviewTextCheck As CheckBox
        <AccessedThroughProperty("PreviewImagesCheck")> _
        Private _PreviewImagesCheck As CheckBox
        <AccessedThroughProperty("PreviewGroup")> _
        Private _PreviewGroup As GroupBox
        <AccessedThroughProperty("LookTab")> _
        Private _LookTab As TabPage
        <AccessedThroughProperty("RedRadio")> _
        Private _RedRadio As RadioButton
        <AccessedThroughProperty("OrangeRadio")> _
        Private _OrangeRadio As RadioButton
        <AccessedThroughProperty("GreyRadio")> _
        Private _GreyRadio As RadioButton
        <AccessedThroughProperty("GreenRadio")> _
        Private _GreenRadio As RadioButton
        <AccessedThroughProperty("CyanRadio")> _
        Private _CyanRadio As RadioButton
        <AccessedThroughProperty("BlueRadio")> _
        Private _BlueRadio As RadioButton
        <AccessedThroughProperty("PreviewPict")> _
        Private _PreviewPict As PictureBox
        <AccessedThroughProperty("BrowseButt")> _
        Private _BrowseButt As Button
        <AccessedThroughProperty("CustomText")> _
        Private _CustomText As TextBox
        <AccessedThroughProperty("CustomRadio")> _
        Private _CustomRadio As RadioButton
        <AccessedThroughProperty("SpecialPathRadio")> _
        Private _SpecialPathRadio As RadioButton
        <AccessedThroughProperty("BrowseDial")> _
        Private _BrowseDial As FolderBrowserDialog
        <AccessedThroughProperty("ExtensionTab")> _
        Private _ExtensionTab As TabPage
        <AccessedThroughProperty("ExtensionList")> _
        Private _ExtensionList As ListBox
        <AccessedThroughProperty("OpenCombo")> _
        Private _OpenCombo As ComboBox
        <AccessedThroughProperty("Button3")> _
        Private _Button3 As Button
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button
        <AccessedThroughProperty("ExtensionPict")> _
        Private _ExtensionPict As PictureBox
        <AccessedThroughProperty("YellowRadio")> _
        Private _YellowRadio As RadioButton
        <AccessedThroughProperty("VioletRadio")> _
        Private _VioletRadio As RadioButton
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox
        <AccessedThroughProperty("IconDial")> _
        Private _IconDial As OpenFileDialog
        <AccessedThroughProperty("SecurityLab")> _
        Private _SecurityLab As TabPage
        <AccessedThroughProperty("GroupBox3")> _
        Private _GroupBox3 As GroupBox
        <AccessedThroughProperty("AntivirPathText")> _
        Private _AntivirPathText As TextBox
        <AccessedThroughProperty("AntivirDial")> _
        Private _AntivirDial As OpenFileDialog
        <AccessedThroughProperty("BrowseAntivirButt")> _
        Private _BrowseAntivirButt As Button
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("IconText")> _
        Private _IconText As TextBox
        <AccessedThroughProperty("ExtensionText")> _
        Private _ExtensionText As TextBox
        <AccessedThroughProperty("OpenLab")> _
        Private _OpenLab As Label
        <AccessedThroughProperty("IconLab")> _
        Private _IconLab As Label
        <AccessedThroughProperty("ExtensionLab")> _
        Private _ExtensionLab As Label
        <AccessedThroughProperty("Button4")> _
        Private _Button4 As Button
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("OpenDial")> _
        Private _OpenDial As OpenFileDialog
        <AccessedThroughProperty("CheckBox3")> _
        Private _CheckBox3 As CheckBox
        <AccessedThroughProperty("CheckBox2")> _
        Private _CheckBox2 As CheckBox
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox
        <AccessedThroughProperty("AutoUpdateUpDown")> _
        Private _AutoUpdateUpDown As NumericUpDown
        <AccessedThroughProperty("AutoUpdateCheck")> _
        Private _AutoUpdateCheck As CheckBox
    End Class
End Namespace

