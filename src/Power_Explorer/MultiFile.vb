Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports Power_Explorer.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Explorer
    <DesignerGenerated> _
    Public Class MultiFile
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.MultiRename_Load)
            Me.InitializeComponent
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SelectFolder.ShowDialog
            If (Me.SelectFolder.SelectedPath <> "") Then
                Me.FolderText.Text = Me.SelectFolder.SelectedPath
            End If
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Work
        End Sub

        Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SelectFiles.ShowDialog
        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.DelName1.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName2.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName3.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName4.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName5.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName6.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName7.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName8.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName9.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName10.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName11.Enabled = Me.DeleteNameCheck.Checked
            Me.DelName12.Enabled = Me.DeleteNameCheck.Checked
        End Sub

        Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.BiggerLenghtUpDown.Enabled = Me.BiggerLenghtCheck.Checked
            Me.BiggerLenghtCombo.Enabled = Me.BiggerLenghtCheck.Checked
        End Sub

        Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SmallerLenghtUpDown.Enabled = Me.SmallerLenghtCheck.Checked
            Me.SmallerLenghtCombo.Enabled = Me.SmallerLenghtCheck.Checked
        End Sub

        Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.DelExtension1.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension2.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension3.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension4.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension5.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension6.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension7.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension8.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension9.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension10.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension11.Enabled = Me.DeleteExtensionCheck.Checked
            Me.DelExtension12.Enabled = Me.DeleteExtensionCheck.Checked
        End Sub

        Private Sub DeleteCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.RenDelete1.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete2.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete3.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete4.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete5.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete6.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete7.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete8.Enabled = Me.DeleteCheck.Checked
            Me.RenDelete9.Enabled = Me.DeleteCheck.Checked
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
            Me.FolderText = New TextBox
            Me.BrowseButt = New Button
            Me.OKButt = New Button
            Me.CancelButt = New Button
            Me.FileCheck = New CheckBox
            Me.FoldersCheck = New CheckBox
            Me.SubfoldersCheck = New CheckBox
            Me.SelectFolder = New FolderBrowserDialog
            Me.FolderLab = New Label
            Me.AllElementsRadio = New RadioButton
            Me.SelectedElementsRadio = New RadioButton
            Me.SelectFilesButt = New Button
            Me.SelectFiles = New OpenFileDialog
            Me.PreviewButt = New Button
            Me.TabControl1 = New TabControl
            Me.MainTabPage = New TabPage
            Me.RenameTabPage = New TabPage
            Me.FormattazioneGroup = New GroupBox
            Me.RadioButton5 = New RadioButton
            Me.RadioButton6 = New RadioButton
            Me.FormattingPreview1 = New Label
            Me.FormattingPreview2 = New Label
            Me.RadioButton3 = New RadioButton
            Me.RadioButton4 = New RadioButton
            Me.RadioButton2 = New RadioButton
            Me.RadioButton1 = New RadioButton
            Me.FormattazioneCheck = New CheckBox
            Me.ReplaceGroup = New GroupBox
            Me.PictureBox1 = New PictureBox
            Me.Replace6A = New TextBox
            Me.Replace5A = New TextBox
            Me.Replace4A = New TextBox
            Me.Replace6B = New TextBox
            Me.Replace5B = New TextBox
            Me.Replace4B = New TextBox
            Me.WithLab6 = New Label
            Me.WithLab5 = New Label
            Me.WithLab4 = New Label
            Me.Replace3A = New TextBox
            Me.Replace2A = New TextBox
            Me.Replace1A = New TextBox
            Me.Replace3B = New TextBox
            Me.Replace2B = New TextBox
            Me.Replace1B = New TextBox
            Me.ReplaceCheck = New CheckBox
            Me.WithLab3 = New Label
            Me.WithLab2 = New Label
            Me.WithLab1 = New Label
            Me.DeleteGroup = New GroupBox
            Me.DeleteCheck = New CheckBox
            Me.RenDelete9 = New TextBox
            Me.RenDelete8 = New TextBox
            Me.RenDelete7 = New TextBox
            Me.RenDelete6 = New TextBox
            Me.RenDelete5 = New TextBox
            Me.RenDelete4 = New TextBox
            Me.RenDelete3 = New TextBox
            Me.RenDelete2 = New TextBox
            Me.RenDelete1 = New TextBox
            Me.DeleteTabPage = New TabPage
            Me.SmallerLenghtCombo = New ComboBox
            Me.SmallerLenghtUpDown = New NumericUpDown
            Me.SmallerLenghtCheck = New CheckBox
            Me.BiggerLenghtCombo = New ComboBox
            Me.BiggerLenghtUpDown = New NumericUpDown
            Me.BiggerLenghtCheck = New CheckBox
            Me.GroupBox2 = New GroupBox
            Me.PictureBox6 = New PictureBox
            Me.PictureBox5 = New PictureBox
            Me.PictureBox4 = New PictureBox
            Me.DelExtension9 = New TextBox
            Me.DelExtension8 = New TextBox
            Me.DelExtension7 = New TextBox
            Me.DelExtension12 = New TextBox
            Me.DelExtension11 = New TextBox
            Me.DelExtension10 = New TextBox
            Me.DelExtension3 = New TextBox
            Me.DelExtension2 = New TextBox
            Me.DelExtension1 = New TextBox
            Me.DelExtension6 = New TextBox
            Me.DelExtension5 = New TextBox
            Me.DelExtension4 = New TextBox
            Me.DeleteExtensionCheck = New CheckBox
            Me.GroupBox1 = New GroupBox
            Me.PictureBox7 = New PictureBox
            Me.PictureBox3 = New PictureBox
            Me.PictureBox8 = New PictureBox
            Me.DelName9 = New TextBox
            Me.DelName8 = New TextBox
            Me.DelName7 = New TextBox
            Me.DelName12 = New TextBox
            Me.DelName11 = New TextBox
            Me.DelName10 = New TextBox
            Me.DelName3 = New TextBox
            Me.DelName2 = New TextBox
            Me.DelName1 = New TextBox
            Me.DelName6 = New TextBox
            Me.DelName5 = New TextBox
            Me.DelName4 = New TextBox
            Me.DeleteNameCheck = New CheckBox
            Me.TabPage4 = New TabPage
            Me.TabPage5 = New TabPage
            Me.TabPage6 = New TabPage
            Me.WorkProg = New ProgressBar
            Me.CheckBox1 = New CheckBox
            Me.PictureBox2 = New PictureBox
            Me.TextBox2 = New TextBox
            Me.TextBox3 = New TextBox
            Me.TextBox4 = New TextBox
            Me.TextBox5 = New TextBox
            Me.TextBox6 = New TextBox
            Me.TextBox7 = New TextBox
            Me.Label1 = New Label
            Me.Label2 = New Label
            Me.Label3 = New Label
            Me.TextBox8 = New TextBox
            Me.TextBox9 = New TextBox
            Me.TextBox10 = New TextBox
            Me.TextBox11 = New TextBox
            Me.TextBox12 = New TextBox
            Me.TextBox13 = New TextBox
            Me.Label4 = New Label
            Me.Label5 = New Label
            Me.Label6 = New Label
            Me.TabControl1.SuspendLayout
            Me.MainTabPage.SuspendLayout
            Me.RenameTabPage.SuspendLayout
            Me.FormattazioneGroup.SuspendLayout
            Me.ReplaceGroup.SuspendLayout
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.DeleteGroup.SuspendLayout
            Me.DeleteTabPage.SuspendLayout
            Me.SmallerLenghtUpDown.BeginInit
            Me.BiggerLenghtUpDown.BeginInit
            Me.GroupBox2.SuspendLayout
            DirectCast(Me.PictureBox6, ISupportInitialize).BeginInit
            DirectCast(Me.PictureBox5, ISupportInitialize).BeginInit
            DirectCast(Me.PictureBox4, ISupportInitialize).BeginInit
            Me.GroupBox1.SuspendLayout
            DirectCast(Me.PictureBox7, ISupportInitialize).BeginInit
            DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit
            DirectCast(Me.PictureBox8, ISupportInitialize).BeginInit
            DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Dim point As New Point(&H1D, &H29)
            Me.FolderText.Location = point
            Me.FolderText.Name = "FolderText"
            Dim size As New Size(&H1BC, 20)
            Me.FolderText.Size = size
            Me.FolderText.TabIndex = 0
            point = New Point(&H1DF, &H27)
            Me.BrowseButt.Location = point
            Me.BrowseButt.Name = "BrowseButt"
            size = New Size(&H4B, &H17)
            Me.BrowseButt.Size = size
            Me.BrowseButt.TabIndex = 1
            Me.BrowseButt.Text = "Sfoglia..."
            Me.BrowseButt.UseVisualStyleBackColor = True
            point = New Point(&H1F9, &H1AF)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 2
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            point = New Point(&H157, &H1AF)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 3
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.FileCheck.AutoSize = True
            Me.FileCheck.Checked = True
            Me.FileCheck.CheckState = CheckState.Checked
            point = New Point(&H1D, 90)
            Me.FileCheck.Location = point
            Me.FileCheck.Name = "FileCheck"
            size = New Size(&H2A, &H11)
            Me.FileCheck.Size = size
            Me.FileCheck.TabIndex = 6
            Me.FileCheck.Text = "File"
            Me.FileCheck.UseVisualStyleBackColor = True
            Me.FoldersCheck.AutoSize = True
            point = New Point(&H1D, &H43)
            Me.FoldersCheck.Location = point
            Me.FoldersCheck.Name = "FoldersCheck"
            size = New Size(&H3D, &H11)
            Me.FoldersCheck.Size = size
            Me.FoldersCheck.TabIndex = 7
            Me.FoldersCheck.Text = "Cartelle"
            Me.FoldersCheck.UseVisualStyleBackColor = True
            Me.SubfoldersCheck.AutoSize = True
            point = New Point(&H60, &H43)
            Me.SubfoldersCheck.Location = point
            Me.SubfoldersCheck.Name = "SubfoldersCheck"
            size = New Size(&H80, &H11)
            Me.SubfoldersCheck.Size = size
            Me.SubfoldersCheck.TabIndex = 8
            Me.SubfoldersCheck.Text = "Includi le sottocartelle"
            Me.SubfoldersCheck.UseVisualStyleBackColor = True
            Me.FolderLab.AutoSize = True
            point = New Point(&H1A, &H1A)
            Me.FolderLab.Location = point
            Me.FolderLab.Name = "FolderLab"
            size = New Size(&H2D, 13)
            Me.FolderLab.Size = size
            Me.FolderLab.TabIndex = 9
            Me.FolderLab.Text = "Cartella:"
            Me.AllElementsRadio.AutoSize = True
            Me.AllElementsRadio.Checked = True
            point = New Point(6, 6)
            Me.AllElementsRadio.Location = point
            Me.AllElementsRadio.Name = "AllElementsRadio"
            size = New Size(&HD8, &H11)
            Me.AllElementsRadio.Size = size
            Me.AllElementsRadio.TabIndex = 11
            Me.AllElementsRadio.TabStop = True
            Me.AllElementsRadio.Text = "Rinomina tutti gli elementi di una cartella:"
            Me.AllElementsRadio.UseVisualStyleBackColor = True
            Me.SelectedElementsRadio.AutoSize = True
            point = New Point(6, &H71)
            Me.SelectedElementsRadio.Location = point
            Me.SelectedElementsRadio.Name = "SelectedElementsRadio"
            size = New Size(&HC7, &H11)
            Me.SelectedElementsRadio.Size = size
            Me.SelectedElementsRadio.TabIndex = 12
            Me.SelectedElementsRadio.Text = "Rinomina tutti gli elementi selezionati:"
            Me.SelectedElementsRadio.UseVisualStyleBackColor = True
            Me.SelectFilesButt.Enabled = False
            point = New Point(&H1D, &H88)
            Me.SelectFilesButt.Location = point
            Me.SelectFilesButt.Name = "SelectFilesButt"
            size = New Size(&H66, &H17)
            Me.SelectFilesButt.Size = size
            Me.SelectFilesButt.TabIndex = 13
            Me.SelectFilesButt.Text = "Seleziona file..."
            Me.SelectFilesButt.UseVisualStyleBackColor = True
            Me.SelectFiles.Filter = "File e cartelle|*.*"
            Me.SelectFiles.Multiselect = True
            point = New Point(&H1A8, &H1AF)
            Me.PreviewButt.Location = point
            Me.PreviewButt.Name = "PreviewButt"
            size = New Size(&H4B, &H17)
            Me.PreviewButt.Size = size
            Me.PreviewButt.TabIndex = &H10
            Me.PreviewButt.Text = "Ant&eprima"
            Me.PreviewButt.UseVisualStyleBackColor = True
            Me.TabControl1.Controls.Add(Me.MainTabPage)
            Me.TabControl1.Controls.Add(Me.RenameTabPage)
            Me.TabControl1.Controls.Add(Me.DeleteTabPage)
            Me.TabControl1.Controls.Add(Me.TabPage4)
            Me.TabControl1.Controls.Add(Me.TabPage5)
            Me.TabControl1.Controls.Add(Me.TabPage6)
            point = New Point(12, 12)
            Me.TabControl1.Location = point
            Me.TabControl1.Multiline = True
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            size = New Size(&H238, &H19D)
            Me.TabControl1.Size = size
            Me.TabControl1.TabIndex = &H11
            Me.MainTabPage.Controls.Add(Me.AllElementsRadio)
            Me.MainTabPage.Controls.Add(Me.FolderText)
            Me.MainTabPage.Controls.Add(Me.BrowseButt)
            Me.MainTabPage.Controls.Add(Me.SubfoldersCheck)
            Me.MainTabPage.Controls.Add(Me.FoldersCheck)
            Me.MainTabPage.Controls.Add(Me.FileCheck)
            Me.MainTabPage.Controls.Add(Me.SelectFilesButt)
            Me.MainTabPage.Controls.Add(Me.FolderLab)
            Me.MainTabPage.Controls.Add(Me.SelectedElementsRadio)
            point = New Point(4, &H16)
            Me.MainTabPage.Location = point
            Me.MainTabPage.Name = "MainTabPage"
            Dim padding As New Padding(3)
            Me.MainTabPage.Padding = padding
            size = New Size(560, &H183)
            Me.MainTabPage.Size = size
            Me.MainTabPage.TabIndex = 0
            Me.MainTabPage.Text = "Generale"
            Me.MainTabPage.UseVisualStyleBackColor = True
            Me.RenameTabPage.Controls.Add(Me.FormattazioneGroup)
            Me.RenameTabPage.Controls.Add(Me.ReplaceGroup)
            Me.RenameTabPage.Controls.Add(Me.DeleteGroup)
            point = New Point(4, &H16)
            Me.RenameTabPage.Location = point
            Me.RenameTabPage.Name = "RenameTabPage"
            padding = New Padding(3)
            Me.RenameTabPage.Padding = padding
            size = New Size(560, &H183)
            Me.RenameTabPage.Size = size
            Me.RenameTabPage.TabIndex = 1
            Me.RenameTabPage.Text = "Rinomina"
            Me.RenameTabPage.UseVisualStyleBackColor = True
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton5)
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton6)
            Me.FormattazioneGroup.Controls.Add(Me.FormattingPreview1)
            Me.FormattazioneGroup.Controls.Add(Me.FormattingPreview2)
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton3)
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton4)
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton2)
            Me.FormattazioneGroup.Controls.Add(Me.RadioButton1)
            Me.FormattazioneGroup.Controls.Add(Me.FormattazioneCheck)
            point = New Point(6, &HD8)
            Me.FormattazioneGroup.Location = point
            Me.FormattazioneGroup.Name = "FormattazioneGroup"
            size = New Size(&H224, &H40)
            Me.FormattazioneGroup.Size = size
            Me.FormattazioneGroup.TabIndex = &H11
            Me.FormattazioneGroup.TabStop = False
            Me.RadioButton5.AutoSize = True
            point = New Point(&H15A, &H2A)
            Me.RadioButton5.Location = point
            Me.RadioButton5.Name = "RadioButton5"
            size = New Size(&H22, &H11)
            Me.RadioButton5.Size = size
            Me.RadioButton5.TabIndex = &H1B
            Me.RadioButton5.TabStop = True
            Me.RadioButton5.Text = "..."
            Me.RadioButton5.UseVisualStyleBackColor = True
            Me.RadioButton6.AutoSize = True
            point = New Point(&H15A, &H13)
            Me.RadioButton6.Location = point
            Me.RadioButton6.Name = "RadioButton6"
            size = New Size(100, &H11)
            Me.RadioButton6.Size = size
            Me.RadioButton6.TabIndex = &H1A
            Me.RadioButton6.TabStop = True
            Me.RadioButton6.Text = "Tutto maiuscolo"
            Me.RadioButton6.UseVisualStyleBackColor = True
            Me.FormattingPreview1.AutoSize = True
            Me.FormattingPreview1.Font = New Font("Courier New", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H1C0, &H13)
            Me.FormattingPreview1.Location = point
            Me.FormattingPreview1.Name = "FormattingPreview1"
            size = New Size(&H60, &H10)
            Me.FormattingPreview1.Size = size
            Me.FormattingPreview1.TabIndex = &H19
            Me.FormattingPreview1.Text = "Abc DEF ghi"
            Me.FormattingPreview2.AutoSize = True
            Me.FormattingPreview2.Font = New Font("Courier New", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H1C0, &H23)
            Me.FormattingPreview2.Location = point
            Me.FormattingPreview2.Name = "FormattingPreview2"
            size = New Size(&H60, &H10)
            Me.FormattingPreview2.Size = size
            Me.FormattingPreview2.TabIndex = &H18
            Me.FormattingPreview2.Text = "Abc DEF ghi"
            Me.RadioButton3.AutoSize = True
            point = New Point(6, &H2A)
            Me.RadioButton3.Location = point
            Me.RadioButton3.Name = "RadioButton3"
            size = New Size(&H6B, &H11)
            Me.RadioButton3.Size = size
            Me.RadioButton3.TabIndex = &H17
            Me.RadioButton3.TabStop = True
            Me.RadioButton3.Text = "Iniziale maiuscola"
            Me.RadioButton3.UseVisualStyleBackColor = True
            Me.RadioButton4.AutoSize = True
            point = New Point(6, &H13)
            Me.RadioButton4.Location = point
            Me.RadioButton4.Name = "RadioButton4"
            size = New Size(&H9C, &H11)
            Me.RadioButton4.Size = size
            Me.RadioButton4.TabIndex = &H16
            Me.RadioButton4.TabStop = True
            Me.RadioButton4.Text = "Inverti maiuscole/minuscole"
            Me.RadioButton4.UseVisualStyleBackColor = True
            Me.RadioButton2.AutoSize = True
            point = New Point(&HA9, &H29)
            Me.RadioButton2.Location = point
            Me.RadioButton2.Name = "RadioButton2"
            size = New Size(100, &H11)
            Me.RadioButton2.Size = size
            Me.RadioButton2.TabIndex = &H15
            Me.RadioButton2.TabStop = True
            Me.RadioButton2.Text = "Tutto minuscolo"
            Me.RadioButton2.UseVisualStyleBackColor = True
            Me.RadioButton1.AutoSize = True
            point = New Point(&HA9, &H12)
            Me.RadioButton1.Location = point
            Me.RadioButton1.Name = "RadioButton1"
            size = New Size(&HAB, &H11)
            Me.RadioButton1.Size = size
            Me.RadioButton1.TabIndex = 20
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Iniziale maiuscola a ogni parola"
            Me.RadioButton1.UseVisualStyleBackColor = True
            Me.FormattazioneCheck.AutoSize = True
            Me.FormattazioneCheck.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.FormattazioneCheck.Location = point
            Me.FormattazioneCheck.Name = "FormattazioneCheck"
            size = New Size(&H5C, &H11)
            Me.FormattazioneCheck.Size = size
            Me.FormattazioneCheck.TabIndex = 15
            Me.FormattazioneCheck.Text = "Formattazione"
            Me.FormattazioneCheck.UseVisualStyleBackColor = True
            Me.ReplaceGroup.Controls.Add(Me.PictureBox1)
            Me.ReplaceGroup.Controls.Add(Me.Replace6A)
            Me.ReplaceGroup.Controls.Add(Me.Replace5A)
            Me.ReplaceGroup.Controls.Add(Me.Replace4A)
            Me.ReplaceGroup.Controls.Add(Me.Replace6B)
            Me.ReplaceGroup.Controls.Add(Me.Replace5B)
            Me.ReplaceGroup.Controls.Add(Me.Replace4B)
            Me.ReplaceGroup.Controls.Add(Me.WithLab6)
            Me.ReplaceGroup.Controls.Add(Me.WithLab5)
            Me.ReplaceGroup.Controls.Add(Me.WithLab4)
            Me.ReplaceGroup.Controls.Add(Me.Replace3A)
            Me.ReplaceGroup.Controls.Add(Me.Replace2A)
            Me.ReplaceGroup.Controls.Add(Me.Replace1A)
            Me.ReplaceGroup.Controls.Add(Me.Replace3B)
            Me.ReplaceGroup.Controls.Add(Me.Replace2B)
            Me.ReplaceGroup.Controls.Add(Me.Replace1B)
            Me.ReplaceGroup.Controls.Add(Me.ReplaceCheck)
            Me.ReplaceGroup.Controls.Add(Me.WithLab3)
            Me.ReplaceGroup.Controls.Add(Me.WithLab2)
            Me.ReplaceGroup.Controls.Add(Me.WithLab1)
            point = New Point(6, 6)
            Me.ReplaceGroup.Location = point
            Me.ReplaceGroup.Name = "ReplaceGroup"
            size = New Size(&H224, 100)
            Me.ReplaceGroup.Size = size
            Me.ReplaceGroup.TabIndex = 15
            Me.ReplaceGroup.TabStop = False
            Me.PictureBox1.BackColor = Color.Black
            point = New Point(&H10B, &H11)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(1, &H4D)
            Me.PictureBox1.Size = size
            Me.PictureBox1.TabIndex = &H1C
            Me.PictureBox1.TabStop = False
            Me.Replace6A.Enabled = False
            point = New Point(&H128, &H47)
            Me.Replace6A.Location = point
            Me.Replace6A.Name = "Replace6A"
            size = New Size(100, 20)
            Me.Replace6A.Size = size
            Me.Replace6A.TabIndex = &H1B
            Me.Replace5A.Enabled = False
            point = New Point(&H128, &H2D)
            Me.Replace5A.Location = point
            Me.Replace5A.Name = "Replace5A"
            size = New Size(100, 20)
            Me.Replace5A.Size = size
            Me.Replace5A.TabIndex = &H1A
            Me.Replace4A.Enabled = False
            point = New Point(&H128, &H13)
            Me.Replace4A.Location = point
            Me.Replace4A.Name = "Replace4A"
            size = New Size(100, 20)
            Me.Replace4A.Size = size
            Me.Replace4A.TabIndex = &H19
            Me.Replace6B.Enabled = False
            point = New Point(&H1B1, &H47)
            Me.Replace6B.Location = point
            Me.Replace6B.Name = "Replace6B"
            size = New Size(100, 20)
            Me.Replace6B.Size = size
            Me.Replace6B.TabIndex = &H18
            Me.Replace5B.Enabled = False
            point = New Point(&H1B1, &H2D)
            Me.Replace5B.Location = point
            Me.Replace5B.Name = "Replace5B"
            size = New Size(100, 20)
            Me.Replace5B.Size = size
            Me.Replace5B.TabIndex = &H17
            Me.Replace4B.Enabled = False
            point = New Point(&H1B1, &H13)
            Me.Replace4B.Location = point
            Me.Replace4B.Name = "Replace4B"
            size = New Size(100, 20)
            Me.Replace4B.Size = size
            Me.Replace4B.TabIndex = &H16
            Me.WithLab6.AutoSize = True
            point = New Point(&H192, &H4A)
            Me.WithLab6.Location = point
            Me.WithLab6.Name = "WithLab6"
            size = New Size(&H19, 13)
            Me.WithLab6.Size = size
            Me.WithLab6.TabIndex = &H15
            Me.WithLab6.Text = "con"
            Me.WithLab5.AutoSize = True
            point = New Point(&H192, &H30)
            Me.WithLab5.Location = point
            Me.WithLab5.Name = "WithLab5"
            size = New Size(&H19, 13)
            Me.WithLab5.Size = size
            Me.WithLab5.TabIndex = 20
            Me.WithLab5.Text = "con"
            Me.WithLab4.AutoSize = True
            point = New Point(&H192, &H16)
            Me.WithLab4.Location = point
            Me.WithLab4.Name = "WithLab4"
            size = New Size(&H19, 13)
            Me.WithLab4.Size = size
            Me.WithLab4.TabIndex = &H13
            Me.WithLab4.Text = "con"
            Me.Replace3A.Enabled = False
            point = New Point(6, &H47)
            Me.Replace3A.Location = point
            Me.Replace3A.Name = "Replace3A"
            size = New Size(100, 20)
            Me.Replace3A.Size = size
            Me.Replace3A.TabIndex = &H12
            Me.Replace2A.Enabled = False
            point = New Point(6, &H2D)
            Me.Replace2A.Location = point
            Me.Replace2A.Name = "Replace2A"
            size = New Size(100, 20)
            Me.Replace2A.Size = size
            Me.Replace2A.TabIndex = &H11
            Me.Replace1A.Enabled = False
            point = New Point(6, &H13)
            Me.Replace1A.Location = point
            Me.Replace1A.Name = "Replace1A"
            size = New Size(100, 20)
            Me.Replace1A.Size = size
            Me.Replace1A.TabIndex = &H10
            Me.Replace3B.Enabled = False
            point = New Point(&H8F, &H47)
            Me.Replace3B.Location = point
            Me.Replace3B.Name = "Replace3B"
            size = New Size(100, 20)
            Me.Replace3B.Size = size
            Me.Replace3B.TabIndex = 15
            Me.Replace2B.Enabled = False
            point = New Point(&H8F, &H2D)
            Me.Replace2B.Location = point
            Me.Replace2B.Name = "Replace2B"
            size = New Size(100, 20)
            Me.Replace2B.Size = size
            Me.Replace2B.TabIndex = 14
            Me.Replace1B.Enabled = False
            point = New Point(&H8F, &H13)
            Me.Replace1B.Location = point
            Me.Replace1B.Name = "Replace1B"
            size = New Size(100, 20)
            Me.Replace1B.Size = size
            Me.Replace1B.TabIndex = 13
            Me.ReplaceCheck.AutoSize = True
            Me.ReplaceCheck.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.ReplaceCheck.Location = point
            Me.ReplaceCheck.Name = "ReplaceCheck"
            size = New Size(&H77, &H11)
            Me.ReplaceCheck.Size = size
            Me.ReplaceCheck.TabIndex = 4
            Me.ReplaceCheck.Text = "Sostituisci nel nome"
            Me.ReplaceCheck.UseVisualStyleBackColor = True
            Me.WithLab3.AutoSize = True
            point = New Point(&H70, &H4A)
            Me.WithLab3.Location = point
            Me.WithLab3.Name = "WithLab3"
            size = New Size(&H19, 13)
            Me.WithLab3.Size = size
            Me.WithLab3.TabIndex = 12
            Me.WithLab3.Text = "con"
            Me.WithLab2.AutoSize = True
            point = New Point(&H70, &H30)
            Me.WithLab2.Location = point
            Me.WithLab2.Name = "WithLab2"
            size = New Size(&H19, 13)
            Me.WithLab2.Size = size
            Me.WithLab2.TabIndex = 9
            Me.WithLab2.Text = "con"
            Me.WithLab1.AutoSize = True
            point = New Point(&H70, &H16)
            Me.WithLab1.Location = point
            Me.WithLab1.Name = "WithLab1"
            size = New Size(&H19, 13)
            Me.WithLab1.Size = size
            Me.WithLab1.TabIndex = 6
            Me.WithLab1.Text = "con"
            Me.DeleteGroup.Controls.Add(Me.DeleteCheck)
            Me.DeleteGroup.Controls.Add(Me.RenDelete9)
            Me.DeleteGroup.Controls.Add(Me.RenDelete8)
            Me.DeleteGroup.Controls.Add(Me.RenDelete7)
            Me.DeleteGroup.Controls.Add(Me.RenDelete6)
            Me.DeleteGroup.Controls.Add(Me.RenDelete5)
            Me.DeleteGroup.Controls.Add(Me.RenDelete4)
            Me.DeleteGroup.Controls.Add(Me.RenDelete3)
            Me.DeleteGroup.Controls.Add(Me.RenDelete2)
            Me.DeleteGroup.Controls.Add(Me.RenDelete1)
            point = New Point(6, &H70)
            Me.DeleteGroup.Location = point
            Me.DeleteGroup.Name = "DeleteGroup"
            size = New Size(&H224, &H62)
            Me.DeleteGroup.Size = size
            Me.DeleteGroup.TabIndex = &H10
            Me.DeleteGroup.TabStop = False
            Me.DeleteCheck.AutoSize = True
            Me.DeleteCheck.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.DeleteCheck.Location = point
            Me.DeleteCheck.Name = "DeleteCheck"
            size = New Size(&HD6, &H11)
            Me.DeleteCheck.Size = size
            Me.DeleteCheck.TabIndex = 11
            Me.DeleteCheck.Text = "Elimina nel nome le seguenti espressioni"
            Me.DeleteCheck.UseVisualStyleBackColor = True
            Me.RenDelete9.Enabled = False
            point = New Point(&H167, &H47)
            Me.RenDelete9.Location = point
            Me.RenDelete9.Name = "RenDelete9"
            size = New Size(&HB7, 20)
            Me.RenDelete9.Size = size
            Me.RenDelete9.TabIndex = 20
            Me.RenDelete8.Enabled = False
            point = New Point(&HBA, &H47)
            Me.RenDelete8.Location = point
            Me.RenDelete8.Name = "RenDelete8"
            size = New Size(&HA7, 20)
            Me.RenDelete8.Size = size
            Me.RenDelete8.TabIndex = &H13
            Me.RenDelete7.Enabled = False
            point = New Point(6, &H47)
            Me.RenDelete7.Location = point
            Me.RenDelete7.Name = "RenDelete7"
            size = New Size(&HB0, 20)
            Me.RenDelete7.Size = size
            Me.RenDelete7.TabIndex = &H12
            Me.RenDelete6.Enabled = False
            point = New Point(&H167, &H2D)
            Me.RenDelete6.Location = point
            Me.RenDelete6.Name = "RenDelete6"
            size = New Size(&HB7, 20)
            Me.RenDelete6.Size = size
            Me.RenDelete6.TabIndex = &H11
            Me.RenDelete5.Enabled = False
            point = New Point(&H167, &H13)
            Me.RenDelete5.Location = point
            Me.RenDelete5.Name = "RenDelete5"
            size = New Size(&HB7, 20)
            Me.RenDelete5.Size = size
            Me.RenDelete5.TabIndex = &H10
            Me.RenDelete4.Enabled = False
            point = New Point(&HBA, &H2D)
            Me.RenDelete4.Location = point
            Me.RenDelete4.Name = "RenDelete4"
            size = New Size(&HA7, 20)
            Me.RenDelete4.Size = size
            Me.RenDelete4.TabIndex = 15
            Me.RenDelete3.Enabled = False
            point = New Point(&HBA, &H13)
            Me.RenDelete3.Location = point
            Me.RenDelete3.Name = "RenDelete3"
            size = New Size(&HA7, 20)
            Me.RenDelete3.Size = size
            Me.RenDelete3.TabIndex = 14
            Me.RenDelete2.Enabled = False
            point = New Point(6, &H2D)
            Me.RenDelete2.Location = point
            Me.RenDelete2.Name = "RenDelete2"
            size = New Size(&HB0, 20)
            Me.RenDelete2.Size = size
            Me.RenDelete2.TabIndex = 13
            Me.RenDelete1.Enabled = False
            point = New Point(6, &H13)
            Me.RenDelete1.Location = point
            Me.RenDelete1.Name = "RenDelete1"
            size = New Size(&HAE, 20)
            Me.RenDelete1.Size = size
            Me.RenDelete1.TabIndex = 12
            Me.DeleteTabPage.Controls.Add(Me.SmallerLenghtCombo)
            Me.DeleteTabPage.Controls.Add(Me.SmallerLenghtUpDown)
            Me.DeleteTabPage.Controls.Add(Me.SmallerLenghtCheck)
            Me.DeleteTabPage.Controls.Add(Me.BiggerLenghtCombo)
            Me.DeleteTabPage.Controls.Add(Me.BiggerLenghtUpDown)
            Me.DeleteTabPage.Controls.Add(Me.BiggerLenghtCheck)
            Me.DeleteTabPage.Controls.Add(Me.GroupBox2)
            Me.DeleteTabPage.Controls.Add(Me.GroupBox1)
            point = New Point(4, &H16)
            Me.DeleteTabPage.Location = point
            Me.DeleteTabPage.Name = "DeleteTabPage"
            padding = New Padding(3)
            Me.DeleteTabPage.Padding = padding
            size = New Size(560, &H183)
            Me.DeleteTabPage.Size = size
            Me.DeleteTabPage.TabIndex = 2
            Me.DeleteTabPage.Text = "Elimina"
            Me.DeleteTabPage.UseVisualStyleBackColor = True
            Me.SmallerLenghtCombo.Enabled = False
            Me.SmallerLenghtCombo.FormattingEnabled = True
            Dim items As Object() = New Object() { "B", "KB", "MB", "GB", "TB" }
            Me.SmallerLenghtCombo.Items.AddRange(items)
            point = New Point(&HD6, &HF2)
            Me.SmallerLenghtCombo.Location = point
            Me.SmallerLenghtCombo.Name = "SmallerLenghtCombo"
            size = New Size(&H2C, &H15)
            Me.SmallerLenghtCombo.Size = size
            Me.SmallerLenghtCombo.TabIndex = &H23
            Me.SmallerLenghtCombo.Text = "MB"
            Me.SmallerLenghtUpDown.Enabled = False
            point = New Point(&H95, &HF3)
            Me.SmallerLenghtUpDown.Location = point
            Dim num As New Decimal(New Integer() { &H400, 0, 0, 0 })
            Me.SmallerLenghtUpDown.Maximum = num
            Me.SmallerLenghtUpDown.Name = "SmallerLenghtUpDown"
            size = New Size(&H3B, 20)
            Me.SmallerLenghtUpDown.Size = size
            Me.SmallerLenghtUpDown.TabIndex = &H22
            Me.SmallerLenghtCheck.AutoSize = True
            point = New Point(6, &HF4)
            Me.SmallerLenghtCheck.Location = point
            Me.SmallerLenghtCheck.Name = "SmallerLenghtCheck"
            size = New Size(&H8D, &H11)
            Me.SmallerLenghtCheck.Size = size
            Me.SmallerLenghtCheck.TabIndex = &H21
            Me.SmallerLenghtCheck.Text = "Elimina files più piccoli di"
            Me.SmallerLenghtCheck.UseVisualStyleBackColor = True
            Me.BiggerLenghtCombo.Enabled = False
            Me.BiggerLenghtCombo.FormattingEnabled = True
            items = New Object() { "B", "KB", "MB", "GB", "TB" }
            Me.BiggerLenghtCombo.Items.AddRange(items)
            point = New Point(&HD6, &HD8)
            Me.BiggerLenghtCombo.Location = point
            Me.BiggerLenghtCombo.Name = "BiggerLenghtCombo"
            size = New Size(&H2C, &H15)
            Me.BiggerLenghtCombo.Size = size
            Me.BiggerLenghtCombo.TabIndex = &H20
            Me.BiggerLenghtCombo.Text = "MB"
            Me.BiggerLenghtUpDown.Enabled = False
            point = New Point(&H95, &HD9)
            Me.BiggerLenghtUpDown.Location = point
            num = New Decimal(New Integer() { &H400, 0, 0, 0 })
            Me.BiggerLenghtUpDown.Maximum = num
            Me.BiggerLenghtUpDown.Name = "BiggerLenghtUpDown"
            size = New Size(&H3B, 20)
            Me.BiggerLenghtUpDown.Size = size
            Me.BiggerLenghtUpDown.TabIndex = &H1F
            Me.BiggerLenghtCheck.AutoSize = True
            point = New Point(6, &HDA)
            Me.BiggerLenghtCheck.Location = point
            Me.BiggerLenghtCheck.Name = "BiggerLenghtCheck"
            size = New Size(140, &H11)
            Me.BiggerLenghtCheck.Size = size
            Me.BiggerLenghtCheck.TabIndex = 30
            Me.BiggerLenghtCheck.Text = "Elimina files più grandi di"
            Me.BiggerLenghtCheck.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.PictureBox6)
            Me.GroupBox2.Controls.Add(Me.PictureBox5)
            Me.GroupBox2.Controls.Add(Me.PictureBox4)
            Me.GroupBox2.Controls.Add(Me.DelExtension9)
            Me.GroupBox2.Controls.Add(Me.DelExtension8)
            Me.GroupBox2.Controls.Add(Me.DelExtension7)
            Me.GroupBox2.Controls.Add(Me.DelExtension12)
            Me.GroupBox2.Controls.Add(Me.DelExtension11)
            Me.GroupBox2.Controls.Add(Me.DelExtension10)
            Me.GroupBox2.Controls.Add(Me.DelExtension3)
            Me.GroupBox2.Controls.Add(Me.DelExtension2)
            Me.GroupBox2.Controls.Add(Me.DelExtension1)
            Me.GroupBox2.Controls.Add(Me.DelExtension6)
            Me.GroupBox2.Controls.Add(Me.DelExtension5)
            Me.GroupBox2.Controls.Add(Me.DelExtension4)
            Me.GroupBox2.Controls.Add(Me.DeleteExtensionCheck)
            point = New Point(6, &H70)
            Me.GroupBox2.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            size = New Size(&H224, 100)
            Me.GroupBox2.Size = size
            Me.GroupBox2.TabIndex = &H1D
            Me.GroupBox2.TabStop = False
            Me.PictureBox6.BackColor = Color.Black
            point = New Point(&H7C, &H11)
            Me.PictureBox6.Location = point
            Me.PictureBox6.Name = "PictureBox6"
            size = New Size(1, &H4D)
            Me.PictureBox6.Size = size
            Me.PictureBox6.TabIndex = 30
            Me.PictureBox6.TabStop = False
            Me.PictureBox5.BackColor = Color.Black
            point = New Point(&H19F, &H11)
            Me.PictureBox5.Location = point
            Me.PictureBox5.Name = "PictureBox5"
            size = New Size(1, &H4D)
            Me.PictureBox5.Size = size
            Me.PictureBox5.TabIndex = &H1D
            Me.PictureBox5.TabStop = False
            Me.PictureBox4.BackColor = Color.Black
            point = New Point(&H10B, &H11)
            Me.PictureBox4.Location = point
            Me.PictureBox4.Name = "PictureBox4"
            size = New Size(1, &H4D)
            Me.PictureBox4.Size = size
            Me.PictureBox4.TabIndex = &H1C
            Me.PictureBox4.TabStop = False
            Me.DelExtension9.Enabled = False
            point = New Point(&H128, &H47)
            Me.DelExtension9.Location = point
            Me.DelExtension9.Name = "DelExtension9"
            size = New Size(100, 20)
            Me.DelExtension9.Size = size
            Me.DelExtension9.TabIndex = &H1B
            Me.DelExtension8.Enabled = False
            point = New Point(&H128, &H2D)
            Me.DelExtension8.Location = point
            Me.DelExtension8.Name = "DelExtension8"
            size = New Size(100, 20)
            Me.DelExtension8.Size = size
            Me.DelExtension8.TabIndex = &H1A
            Me.DelExtension7.Enabled = False
            point = New Point(&H128, &H13)
            Me.DelExtension7.Location = point
            Me.DelExtension7.Name = "DelExtension7"
            size = New Size(100, 20)
            Me.DelExtension7.Size = size
            Me.DelExtension7.TabIndex = &H19
            Me.DelExtension12.Enabled = False
            point = New Point(&H1B1, &H47)
            Me.DelExtension12.Location = point
            Me.DelExtension12.Name = "DelExtension12"
            size = New Size(100, 20)
            Me.DelExtension12.Size = size
            Me.DelExtension12.TabIndex = &H18
            Me.DelExtension11.Enabled = False
            point = New Point(&H1B1, &H2D)
            Me.DelExtension11.Location = point
            Me.DelExtension11.Name = "DelExtension11"
            size = New Size(100, 20)
            Me.DelExtension11.Size = size
            Me.DelExtension11.TabIndex = &H17
            Me.DelExtension10.Enabled = False
            point = New Point(&H1B1, &H13)
            Me.DelExtension10.Location = point
            Me.DelExtension10.Name = "DelExtension10"
            size = New Size(100, 20)
            Me.DelExtension10.Size = size
            Me.DelExtension10.TabIndex = &H16
            Me.DelExtension3.Enabled = False
            point = New Point(6, &H47)
            Me.DelExtension3.Location = point
            Me.DelExtension3.Name = "DelExtension3"
            size = New Size(100, 20)
            Me.DelExtension3.Size = size
            Me.DelExtension3.TabIndex = &H12
            Me.DelExtension2.Enabled = False
            point = New Point(6, &H2D)
            Me.DelExtension2.Location = point
            Me.DelExtension2.Name = "DelExtension2"
            size = New Size(100, 20)
            Me.DelExtension2.Size = size
            Me.DelExtension2.TabIndex = &H11
            Me.DelExtension1.Enabled = False
            point = New Point(6, &H13)
            Me.DelExtension1.Location = point
            Me.DelExtension1.Name = "DelExtension1"
            size = New Size(100, 20)
            Me.DelExtension1.Size = size
            Me.DelExtension1.TabIndex = &H10
            Me.DelExtension6.Enabled = False
            point = New Point(&H8F, &H47)
            Me.DelExtension6.Location = point
            Me.DelExtension6.Name = "DelExtension6"
            size = New Size(100, 20)
            Me.DelExtension6.Size = size
            Me.DelExtension6.TabIndex = 15
            Me.DelExtension5.Enabled = False
            point = New Point(&H8F, &H2D)
            Me.DelExtension5.Location = point
            Me.DelExtension5.Name = "DelExtension5"
            size = New Size(100, 20)
            Me.DelExtension5.Size = size
            Me.DelExtension5.TabIndex = 14
            Me.DelExtension4.Enabled = False
            point = New Point(&H8F, &H13)
            Me.DelExtension4.Location = point
            Me.DelExtension4.Name = "DelExtension4"
            size = New Size(100, 20)
            Me.DelExtension4.Size = size
            Me.DelExtension4.TabIndex = 13
            Me.DeleteExtensionCheck.AutoSize = True
            Me.DeleteExtensionCheck.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.DeleteExtensionCheck.Location = point
            Me.DeleteExtensionCheck.Name = "DeleteExtensionCheck"
            size = New Size(200, &H11)
            Me.DeleteExtensionCheck.Size = size
            Me.DeleteExtensionCheck.TabIndex = 4
            Me.DeleteExtensionCheck.Text = "Elimina file con le seguenti estensioni"
            Me.DeleteExtensionCheck.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.PictureBox7)
            Me.GroupBox1.Controls.Add(Me.PictureBox3)
            Me.GroupBox1.Controls.Add(Me.PictureBox8)
            Me.GroupBox1.Controls.Add(Me.DelName9)
            Me.GroupBox1.Controls.Add(Me.DelName8)
            Me.GroupBox1.Controls.Add(Me.DelName7)
            Me.GroupBox1.Controls.Add(Me.DelName12)
            Me.GroupBox1.Controls.Add(Me.DelName11)
            Me.GroupBox1.Controls.Add(Me.DelName10)
            Me.GroupBox1.Controls.Add(Me.DelName3)
            Me.GroupBox1.Controls.Add(Me.DelName2)
            Me.GroupBox1.Controls.Add(Me.DelName1)
            Me.GroupBox1.Controls.Add(Me.DelName6)
            Me.GroupBox1.Controls.Add(Me.DelName5)
            Me.GroupBox1.Controls.Add(Me.DelName4)
            Me.GroupBox1.Controls.Add(Me.DeleteNameCheck)
            point = New Point(6, 6)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&H224, 100)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = &H10
            Me.GroupBox1.TabStop = False
            Me.PictureBox7.BackColor = Color.Black
            point = New Point(&H7C, &H11)
            Me.PictureBox7.Location = point
            Me.PictureBox7.Name = "PictureBox7"
            size = New Size(1, &H4D)
            Me.PictureBox7.Size = size
            Me.PictureBox7.TabIndex = &H20
            Me.PictureBox7.TabStop = False
            Me.PictureBox3.BackColor = Color.Black
            point = New Point(&H10B, &H11)
            Me.PictureBox3.Location = point
            Me.PictureBox3.Name = "PictureBox3"
            size = New Size(1, &H4D)
            Me.PictureBox3.Size = size
            Me.PictureBox3.TabIndex = &H1C
            Me.PictureBox3.TabStop = False
            Me.PictureBox8.BackColor = Color.Black
            point = New Point(&H19F, &H11)
            Me.PictureBox8.Location = point
            Me.PictureBox8.Name = "PictureBox8"
            size = New Size(1, &H4D)
            Me.PictureBox8.Size = size
            Me.PictureBox8.TabIndex = &H1F
            Me.PictureBox8.TabStop = False
            Me.DelName9.Enabled = False
            point = New Point(&H128, &H47)
            Me.DelName9.Location = point
            Me.DelName9.Name = "DelName9"
            size = New Size(100, 20)
            Me.DelName9.Size = size
            Me.DelName9.TabIndex = &H1B
            Me.DelName8.Enabled = False
            point = New Point(&H128, &H2D)
            Me.DelName8.Location = point
            Me.DelName8.Name = "DelName8"
            size = New Size(100, 20)
            Me.DelName8.Size = size
            Me.DelName8.TabIndex = &H1A
            Me.DelName7.Enabled = False
            point = New Point(&H128, &H13)
            Me.DelName7.Location = point
            Me.DelName7.Name = "DelName7"
            size = New Size(100, 20)
            Me.DelName7.Size = size
            Me.DelName7.TabIndex = &H19
            Me.DelName12.Enabled = False
            point = New Point(&H1B1, &H47)
            Me.DelName12.Location = point
            Me.DelName12.Name = "DelName12"
            size = New Size(100, 20)
            Me.DelName12.Size = size
            Me.DelName12.TabIndex = &H18
            Me.DelName11.Enabled = False
            point = New Point(&H1B1, &H2D)
            Me.DelName11.Location = point
            Me.DelName11.Name = "DelName11"
            size = New Size(100, 20)
            Me.DelName11.Size = size
            Me.DelName11.TabIndex = &H17
            Me.DelName10.Enabled = False
            point = New Point(&H1B1, &H13)
            Me.DelName10.Location = point
            Me.DelName10.Name = "DelName10"
            size = New Size(100, 20)
            Me.DelName10.Size = size
            Me.DelName10.TabIndex = &H16
            Me.DelName3.Enabled = False
            point = New Point(6, &H47)
            Me.DelName3.Location = point
            Me.DelName3.Name = "DelName3"
            size = New Size(100, 20)
            Me.DelName3.Size = size
            Me.DelName3.TabIndex = &H12
            Me.DelName2.Enabled = False
            point = New Point(6, &H2D)
            Me.DelName2.Location = point
            Me.DelName2.Name = "DelName2"
            size = New Size(100, 20)
            Me.DelName2.Size = size
            Me.DelName2.TabIndex = &H11
            Me.DelName1.Enabled = False
            point = New Point(6, &H13)
            Me.DelName1.Location = point
            Me.DelName1.Name = "DelName1"
            size = New Size(100, 20)
            Me.DelName1.Size = size
            Me.DelName1.TabIndex = &H10
            Me.DelName6.Enabled = False
            point = New Point(&H8F, &H47)
            Me.DelName6.Location = point
            Me.DelName6.Name = "DelName6"
            size = New Size(100, 20)
            Me.DelName6.Size = size
            Me.DelName6.TabIndex = 15
            Me.DelName5.Enabled = False
            point = New Point(&H8F, &H2D)
            Me.DelName5.Location = point
            Me.DelName5.Name = "DelName5"
            size = New Size(100, 20)
            Me.DelName5.Size = size
            Me.DelName5.TabIndex = 14
            Me.DelName4.Enabled = False
            point = New Point(&H8F, &H13)
            Me.DelName4.Location = point
            Me.DelName4.Name = "DelName4"
            size = New Size(100, 20)
            Me.DelName4.Size = size
            Me.DelName4.TabIndex = 13
            Me.DeleteNameCheck.AutoSize = True
            Me.DeleteNameCheck.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.DeleteNameCheck.Location = point
            Me.DeleteNameCheck.Name = "DeleteNameCheck"
            size = New Size(&H117, &H11)
            Me.DeleteNameCheck.Size = size
            Me.DeleteNameCheck.TabIndex = 4
            Me.DeleteNameCheck.Text = "Elimina files e cartelle con le seguenti parole nel nome"
            Me.DeleteNameCheck.UseVisualStyleBackColor = True
            point = New Point(4, &H16)
            Me.TabPage4.Location = point
            Me.TabPage4.Name = "TabPage4"
            padding = New Padding(3)
            Me.TabPage4.Padding = padding
            size = New Size(560, &H183)
            Me.TabPage4.Size = size
            Me.TabPage4.TabIndex = 3
            Me.TabPage4.Text = "TabPage4"
            Me.TabPage4.UseVisualStyleBackColor = True
            point = New Point(4, &H16)
            Me.TabPage5.Location = point
            Me.TabPage5.Name = "TabPage5"
            padding = New Padding(3)
            Me.TabPage5.Padding = padding
            size = New Size(560, &H183)
            Me.TabPage5.Size = size
            Me.TabPage5.TabIndex = 4
            Me.TabPage5.Text = "TabPage5"
            Me.TabPage5.UseVisualStyleBackColor = True
            point = New Point(4, &H16)
            Me.TabPage6.Location = point
            Me.TabPage6.Name = "TabPage6"
            padding = New Padding(3)
            Me.TabPage6.Padding = padding
            size = New Size(560, &H183)
            Me.TabPage6.Size = size
            Me.TabPage6.TabIndex = 5
            Me.TabPage6.Text = "TabPage6"
            Me.TabPage6.UseVisualStyleBackColor = True
            point = New Point(12, &H1B2)
            Me.WorkProg.Location = point
            Me.WorkProg.Name = "WorkProg"
            size = New Size(&H9F, 20)
            Me.WorkProg.Size = size
            Me.WorkProg.TabIndex = &H12
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.ForeColor = SystemColors.ActiveCaption
            point = New Point(6, 0)
            Me.CheckBox1.Location = point
            Me.CheckBox1.Name = "CheckBox1"
            size = New Size(&H77, &H11)
            Me.CheckBox1.Size = size
            Me.CheckBox1.TabIndex = 4
            Me.CheckBox1.Text = "Sostituisci nel nome"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Me.PictureBox2.BackColor = Color.Black
            point = New Point(&H10A, &H11)
            Me.PictureBox2.Location = point
            Me.PictureBox2.Name = "PictureBox2"
            size = New Size(2, &H4D)
            Me.PictureBox2.Size = size
            Me.PictureBox2.TabIndex = &H1C
            Me.PictureBox2.TabStop = False
            Me.TextBox2.Enabled = False
            point = New Point(&H128, &H47)
            Me.TextBox2.Location = point
            Me.TextBox2.Name = "TextBox2"
            size = New Size(100, 20)
            Me.TextBox2.Size = size
            Me.TextBox2.TabIndex = &H1B
            Me.TextBox3.Enabled = False
            point = New Point(&H128, &H2D)
            Me.TextBox3.Location = point
            Me.TextBox3.Name = "TextBox3"
            size = New Size(100, 20)
            Me.TextBox3.Size = size
            Me.TextBox3.TabIndex = &H1A
            Me.TextBox4.Enabled = False
            point = New Point(&H128, &H13)
            Me.TextBox4.Location = point
            Me.TextBox4.Name = "TextBox4"
            size = New Size(100, 20)
            Me.TextBox4.Size = size
            Me.TextBox4.TabIndex = &H19
            Me.TextBox5.Enabled = False
            point = New Point(&H1B1, &H47)
            Me.TextBox5.Location = point
            Me.TextBox5.Name = "TextBox5"
            size = New Size(100, 20)
            Me.TextBox5.Size = size
            Me.TextBox5.TabIndex = &H18
            Me.TextBox6.Enabled = False
            point = New Point(&H1B1, &H2D)
            Me.TextBox6.Location = point
            Me.TextBox6.Name = "TextBox6"
            size = New Size(100, 20)
            Me.TextBox6.Size = size
            Me.TextBox6.TabIndex = &H17
            Me.TextBox7.Enabled = False
            point = New Point(&H1B1, &H13)
            Me.TextBox7.Location = point
            Me.TextBox7.Name = "TextBox7"
            size = New Size(100, 20)
            Me.TextBox7.Size = size
            Me.TextBox7.TabIndex = &H16
            Me.Label1.AutoSize = True
            point = New Point(&H192, &H4A)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H19, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = &H15
            Me.Label1.Text = "con"
            Me.Label2.AutoSize = True
            point = New Point(&H192, &H30)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H19, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 20
            Me.Label2.Text = "con"
            Me.Label3.AutoSize = True
            point = New Point(&H192, &H16)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H19, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = &H13
            Me.Label3.Text = "con"
            Me.TextBox8.Enabled = False
            point = New Point(6, &H47)
            Me.TextBox8.Location = point
            Me.TextBox8.Name = "TextBox8"
            size = New Size(100, 20)
            Me.TextBox8.Size = size
            Me.TextBox8.TabIndex = &H12
            Me.TextBox9.Enabled = False
            point = New Point(6, &H2D)
            Me.TextBox9.Location = point
            Me.TextBox9.Name = "TextBox9"
            size = New Size(100, 20)
            Me.TextBox9.Size = size
            Me.TextBox9.TabIndex = &H11
            Me.TextBox10.Enabled = False
            point = New Point(6, &H13)
            Me.TextBox10.Location = point
            Me.TextBox10.Name = "TextBox10"
            size = New Size(100, 20)
            Me.TextBox10.Size = size
            Me.TextBox10.TabIndex = &H10
            Me.TextBox11.Enabled = False
            point = New Point(&H8F, &H47)
            Me.TextBox11.Location = point
            Me.TextBox11.Name = "TextBox11"
            size = New Size(100, 20)
            Me.TextBox11.Size = size
            Me.TextBox11.TabIndex = 15
            Me.TextBox12.Enabled = False
            point = New Point(&H8F, &H2D)
            Me.TextBox12.Location = point
            Me.TextBox12.Name = "TextBox12"
            size = New Size(100, 20)
            Me.TextBox12.Size = size
            Me.TextBox12.TabIndex = 14
            Me.TextBox13.Enabled = False
            point = New Point(&H8F, &H13)
            Me.TextBox13.Location = point
            Me.TextBox13.Name = "TextBox13"
            size = New Size(100, 20)
            Me.TextBox13.Size = size
            Me.TextBox13.TabIndex = 13
            Me.Label4.AutoSize = True
            point = New Point(&H70, &H4A)
            Me.Label4.Location = point
            Me.Label4.Name = "Label4"
            size = New Size(&H19, 13)
            Me.Label4.Size = size
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "con"
            Me.Label5.AutoSize = True
            point = New Point(&H70, &H30)
            Me.Label5.Location = point
            Me.Label5.Name = "Label5"
            size = New Size(&H19, 13)
            Me.Label5.Size = size
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "con"
            Me.Label6.AutoSize = True
            point = New Point(&H70, &H16)
            Me.Label6.Location = point
            Me.Label6.Name = "Label6"
            size = New Size(&H19, 13)
            Me.Label6.Size = size
            Me.Label6.TabIndex = 6
            Me.Label6.Text = "con"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H250, &H1D2)
            Me.ClientSize = size
            Me.Controls.Add(Me.WorkProg)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.PreviewButt)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.OKButt)
            Me.MaximizeBox = False
            Me.Name = "MultiFile"
            Me.Text = "Utilità di lavoro multifile"
            Me.TabControl1.ResumeLayout(False)
            Me.MainTabPage.ResumeLayout(False)
            Me.MainTabPage.PerformLayout
            Me.RenameTabPage.ResumeLayout(False)
            Me.FormattazioneGroup.ResumeLayout(False)
            Me.FormattazioneGroup.PerformLayout
            Me.ReplaceGroup.ResumeLayout(False)
            Me.ReplaceGroup.PerformLayout
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.DeleteGroup.ResumeLayout(False)
            Me.DeleteGroup.PerformLayout
            Me.DeleteTabPage.ResumeLayout(False)
            Me.DeleteTabPage.PerformLayout
            Me.SmallerLenghtUpDown.EndInit
            Me.BiggerLenghtUpDown.EndInit
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout
            DirectCast(Me.PictureBox6, ISupportInitialize).EndInit
            DirectCast(Me.PictureBox5, ISupportInitialize).EndInit
            DirectCast(Me.PictureBox4, ISupportInitialize).EndInit
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            DirectCast(Me.PictureBox7, ISupportInitialize).EndInit
            DirectCast(Me.PictureBox3, ISupportInitialize).EndInit
            DirectCast(Me.PictureBox8, ISupportInitialize).EndInit
            DirectCast(Me.PictureBox2, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Private Sub MultiRename_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.FolderText.Text = MyProject.Forms.Main.DirectoryText.Text
            Me.SelectFiles.InitialDirectory = MyProject.Forms.Main.DirectoryText.Text
            Me.SelectFolder.SelectedPath = MyProject.Forms.Main.DirectoryText.Text
        End Sub

        Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.FolderLab.Enabled = Me.AllElementsRadio.Checked
            Me.FolderText.Enabled = Me.AllElementsRadio.Checked
            Me.BrowseButt.Enabled = Me.AllElementsRadio.Checked
            Me.SubfoldersCheck.Enabled = Me.AllElementsRadio.Checked
            Me.FileCheck.Enabled = Me.AllElementsRadio.Checked
            Me.FoldersCheck.Enabled = Me.AllElementsRadio.Checked
        End Sub

        Private Sub RadioButton1_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RadioButton1.Checked Then
                Me.FormattingPreview2.Text = "Abc DEF Ghi"
            End If
        End Sub

        Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.SelectFilesButt.Enabled = Me.SelectedElementsRadio.Enabled
        End Sub

        Private Sub RadioButton2_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RadioButton2.Checked Then
                Me.FormattingPreview2.Text = "acb def ghi"
            End If
        End Sub

        Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RadioButton3.Checked Then
                Me.FormattingPreview2.Text = "Abc DEF ghi"
            End If
        End Sub

        Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RadioButton4.Checked Then
                Me.FormattingPreview2.Text = "aBC def GHI"
            End If
        End Sub

        Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RadioButton6.Checked Then
                Me.FormattingPreview2.Text = "ABC DEF GHI"
            End If
        End Sub

        Private Sub ReplaceCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Replace1A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace1B.Enabled = Me.ReplaceCheck.Checked
            Me.Replace2A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace2B.Enabled = Me.ReplaceCheck.Checked
            Me.Replace3A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace3B.Enabled = Me.ReplaceCheck.Checked
            Me.Replace4A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace4B.Enabled = Me.ReplaceCheck.Checked
            Me.Replace5A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace5B.Enabled = Me.ReplaceCheck.Checked
            Me.Replace6A.Enabled = Me.ReplaceCheck.Checked
            Me.Replace6B.Enabled = Me.ReplaceCheck.Checked
        End Sub

        Public Sub Work()
            MyProject.Forms.Main.FileSystemWatcher.EnableRaisingEvents = False
            Dim list As New List(Of String)
            If Not Me.AllElementsRadio.Checked Then
                Dim num19 As Integer = (Me.SelectFiles.FileNames.Length - 1)
                Dim i As Integer = 0
                Do While (i <= num19)
                    list.Add(Conversions.ToString(Me.SelectFiles.FileNames.GetValue(i)))
                    i += 1
                Loop
            ElseIf Not Me.SubfoldersCheck.Checked Then
                Dim num17 As Integer = (MyProject.Computer.FileSystem.GetFiles(Me.SelectFolder.SelectedPath).Count - 1)
                Dim i As Integer = 0
                Do While (i <= num17)
                    list.Add(MyProject.Computer.FileSystem.GetFiles(Me.SelectFolder.SelectedPath, 2, New String(0  - 1) {})(i))
                    i += 1
                Loop
            Else
                Dim num18 As Integer = (MyProject.Computer.FileSystem.GetFiles(Me.SelectFolder.SelectedPath, SearchOption.SearchAllSubDirectories, New String(0  - 1) {}).Count - 1)
                Dim i As Integer = 0
                Do While (i <= num18)
                    list.Add(MyProject.Computer.FileSystem.GetFiles(Me.SelectFolder.SelectedPath, 3, New String(0  - 1) {})(i))
                    i += 1
                Loop
            End If
            If Me.ReplaceCheck.Checked Then
                Dim num20 As Integer = (list.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num20)
                    Dim newName As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    Dim str As String = Conversions.ToString(CInt((list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1)))
                    Dim str3 As String = list(i).Remove(Conversions.ToInteger(str), CInt(Math.Round(CDbl((list(i).Length - Conversions.ToDouble(str))))))
                    If (Me.Replace1A.Text <> "") Then
                        newName = newName.Replace(Me.Replace1A.Text, Me.Replace1B.Text)
                    End If
                    If (Me.Replace2A.Text <> "") Then
                        newName = newName.Replace(Me.Replace2A.Text, Me.Replace2B.Text)
                    End If
                    If (Me.Replace3A.Text <> "") Then
                        newName = newName.Replace(Me.Replace3A.Text, Me.Replace3B.Text)
                    End If
                    If (Me.Replace4A.Text <> "") Then
                        newName = newName.Replace(Me.Replace4A.Text, Me.Replace4B.Text)
                    End If
                    If (Me.Replace5A.Text <> "") Then
                        newName = newName.Replace(Me.Replace5A.Text, Me.Replace5B.Text)
                    End If
                    If (Me.Replace6A.Text <> "") Then
                        newName = newName.Replace(Me.Replace6A.Text, Me.Replace6B.Text)
                    End If
                    If ((str3 & "\" & newName) <> list(i)) Then
                        If Not MyProject.Computer.FileSystem.FileExists((str3 & "\" & newName)) Then
                            MyProject.Computer.FileSystem.RenameFile(list(i), newName)
                            list(i) = (str3 & newName)
                        ElseIf (MessageBox.Show(("Impossibile rinominare il file " & newName & ". Proseguire comunque?"), "Errore nella rinominazione di un file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.No) Then
                            MyProject.Forms.Main.FileSystemWatcher.EnableRaisingEvents = True
                            Return
                        End If
                    End If
                    i += 1
                Loop
            End If
            If Me.DeleteCheck.Checked Then
                Dim num21 As Integer = (list.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num21)
                    Dim newName As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    Dim str4 As String = Conversions.ToString(CInt((list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1)))
                    Dim str6 As String = list(i).Remove(Conversions.ToInteger(str4), CInt(Math.Round(CDbl((list(i).Length - Conversions.ToDouble(str4))))))
                    If (Me.RenDelete1.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete1.Text, "")
                    End If
                    If (Me.RenDelete2.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete2.Text, "")
                    End If
                    If (Me.RenDelete3.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete3.Text, "")
                    End If
                    If (Me.RenDelete4.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete4.Text, "")
                    End If
                    If (Me.RenDelete5.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete5.Text, "")
                    End If
                    If (Me.RenDelete6.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete6.Text, "")
                    End If
                    If (Me.RenDelete7.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete7.Text, "")
                    End If
                    If (Me.RenDelete8.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete8.Text, "")
                    End If
                    If (Me.RenDelete9.Text <> "") Then
                        newName = newName.Replace(Me.RenDelete9.Text, "")
                    End If
                    If ((str6 & "\" & newName) <> list(i)) Then
                        If Not MyProject.Computer.FileSystem.FileExists((str6 & "\" & newName)) Then
                            MyProject.Computer.FileSystem.RenameFile(list(i), newName)
                            list(i) = (str6 & newName)
                        ElseIf (MessageBox.Show(("Impossibile rinominare il file " & newName & ". Proseguire comunque?"), "Errore nella rinominazione di un file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.No) Then
                            MyProject.Forms.Main.FileSystemWatcher.EnableRaisingEvents = True
                            Return
                        End If
                    End If
                    i += 1
                Loop
            End If
            If Me.FormattazioneCheck.Checked Then
                Dim num22 As Integer = (list.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num22)
                    Dim newName As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    Dim str7 As String = Conversions.ToString(CInt((list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1)))
                    Dim str9 As String = list(i).Remove(Conversions.ToInteger(str7), CInt(Math.Round(CDbl((list(i).Length - Conversions.ToDouble(str7))))))
                    If Me.RadioButton4.Checked Then
                        newName = newName
                    End If
                    If Me.RadioButton3.Checked Then
                        newName = (Conversions.ToString(Char.ToUpper(newName(0))) & newName.Remove(1, (newName.Length - 1)))
                    End If
                    If Me.RadioButton1.Checked Then
                        newName = newName.ToUpperInvariant
                    End If
                    If Me.RadioButton2.Checked Then
                        newName = newName.ToLower
                    End If
                    If Me.RadioButton6.Checked Then
                        newName = newName.ToUpper
                    End If
                    If ((str9 & "\" & newName) <> list(i)) Then
                        If Not MyProject.Computer.FileSystem.FileExists((str9 & "\" & newName)) Then
                            MyProject.Computer.FileSystem.RenameFile(list(i), newName)
                            list(i) = (str9 & newName)
                        ElseIf (MessageBox.Show(("Impossibile rinominare il file " & newName & ". Proseguire comunque?"), "Errore nella rinominazione di un file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.No) Then
                            MyProject.Forms.Main.FileSystemWatcher.EnableRaisingEvents = True
                            Return
                        End If
                    End If
                    i += 1
                Loop
            End If
            If Me.DeleteNameCheck.Checked Then
                Dim num7 As Short = CShort((list.Count - 1))
                Dim num23 As Integer = num7
                Dim i As Integer = 0
                Do While (((i <= num23) AndAlso (i <> num7)) AndAlso (i <= num7))
                    Dim str10 As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    If ((Me.DelName1.Text <> "") AndAlso str10.Contains(Me.DelName1.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName2.Text <> "") AndAlso str10.Contains(Me.DelName2.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName3.Text <> "") AndAlso str10.Contains(Me.DelName3.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName4.Text <> "") AndAlso str10.Contains(Me.DelName4.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName5.Text <> "") AndAlso str10.Contains(Me.DelName5.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName6.Text <> "") AndAlso str10.Contains(Me.DelName6.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName7.Text <> "") AndAlso str10.Contains(Me.DelName7.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName8.Text <> "") AndAlso str10.Contains(Me.DelName8.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName9.Text <> "") AndAlso str10.Contains(Me.DelName9.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName10.Text <> "") AndAlso str10.Contains(Me.DelName10.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName11.Text <> "") AndAlso str10.Contains(Me.DelName11.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    If ((Me.DelName12.Text <> "") AndAlso str10.Contains(Me.DelName12.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num7 = CShort((num7 - 1))
                    End If
                    i += 1
                Loop
            End If
            If Me.DeleteExtensionCheck.Checked Then
                Dim num9 As Short = CShort((list.Count - 1))
                Dim num24 As Integer = num9
                Dim i As Integer = 0
                Do While (((i <= num24) AndAlso (i <> num9)) AndAlso (i <= num9))
                    Dim extension As String = MyProject.Computer.FileSystem.GetFileInfo(list(i)).Extension
                    If ((Me.DelExtension1.Text <> "") AndAlso (extension = Me.DelExtension1.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension2.Text <> "") AndAlso (extension = Me.DelExtension2.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension3.Text <> "") AndAlso (extension = Me.DelExtension3.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension4.Text <> "") AndAlso (extension = Me.DelExtension4.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension5.Text <> "") AndAlso (extension = Me.DelExtension5.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension6.Text <> "") AndAlso (extension = Me.DelExtension6.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension7.Text <> "") AndAlso (extension = Me.DelExtension7.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension8.Text <> "") AndAlso (extension = Me.DelExtension8.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension9.Text <> "") AndAlso (extension = Me.DelExtension9.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension10.Text <> "") AndAlso (extension = Me.DelExtension10.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension11.Text <> "") AndAlso (extension = Me.DelExtension11.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    If ((Me.DelExtension12.Text <> "") AndAlso (extension = Me.DelExtension12.Text)) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num9 = CShort((num9 - 1))
                    End If
                    i += 1
                Loop
            End If
            If Me.BiggerLenghtCheck.Checked Then
                Dim num11 As Short = CShort((list.Count - 1))
                Dim num25 As Integer = num11
                Dim i As Integer = 0
                Do While (((i <= num25) AndAlso (i <> num11)) AndAlso (i <= num11))
                    Dim num13 As Long
                    Dim str13 As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    Dim str12 As String = Conversions.ToString(CInt((list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1)))
                    Dim str14 As String = list(i).Remove(Conversions.ToInteger(str12), CInt(Math.Round(CDbl((list(i).Length - Conversions.ToDouble(str12))))))
                    Dim text As String = Me.BiggerLenghtCombo.Text
                    If ([text] = "B") Then
                        num13 = Convert.ToInt64(Me.BiggerLenghtUpDown.Value)
                    ElseIf ([text] = "KB") Then
                        num13 = Convert.ToInt64(Decimal.Multiply(Me.BiggerLenghtUpDown.Value, 1024))
                    ElseIf ([text] = "MB") Then
                        num13 = Convert.ToInt64(Decimal.Multiply(Me.BiggerLenghtUpDown.Value, 1048576))
                    ElseIf ([text] = "GB") Then
                        num13 = Convert.ToInt64(Decimal.Multiply(Me.BiggerLenghtUpDown.Value, 1073741824))
                    ElseIf ([text] = "TB") Then
                        num13 = Convert.ToInt64(Decimal.Multiply(Me.BiggerLenghtUpDown.Value, 1099511627776))
                    End If
                    If (MyProject.Computer.FileSystem.GetFileInfo(list(i)).Length > num13) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num11 = CShort((num11 - 1))
                    End If
                    i += 1
                Loop
            End If
            If Me.SmallerLenghtCheck.Checked Then
                Dim num14 As Short = CShort((list.Count - 1))
                Dim num26 As Integer = num14
                Dim i As Integer = 0
                Do While ((i <= num26) AndAlso ((i <> num14) AndAlso (i <= num14)))
                    Dim num16 As Long
                    Dim str16 As String = list(i).Remove(0, (list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1))
                    Dim str15 As String = Conversions.ToString(CInt((list(i).LastIndexOfAny(Conversions.ToCharArrayRankOne("\")) + 1)))
                    Dim str17 As String = list(i).Remove(Conversions.ToInteger(str15), CInt(Math.Round(CDbl((list(i).Length - Conversions.ToDouble(str15))))))
                    Dim text As String = Me.SmallerLenghtCombo.Text
                    If ([text] = "B") Then
                        num16 = Convert.ToInt64(Me.SmallerLenghtUpDown.Value)
                    ElseIf ([text] = "KB") Then
                        num16 = Convert.ToInt64(Decimal.Multiply(Me.SmallerLenghtUpDown.Value, 1024))
                    ElseIf ([text] = "MB") Then
                        num16 = Convert.ToInt64(Decimal.Multiply(Me.SmallerLenghtUpDown.Value, 1048576))
                    ElseIf ([text] = "GB") Then
                        num16 = Convert.ToInt64(Decimal.Multiply(Me.SmallerLenghtUpDown.Value, 1073741824))
                    ElseIf ([text] = "TB") Then
                        num16 = Convert.ToInt64(Decimal.Multiply(Me.SmallerLenghtUpDown.Value, 1099511627776))
                    End If
                    If (MyProject.Computer.FileSystem.GetFileInfo(list(i)).Length < num16) Then
                        MyProject.Computer.FileSystem.DeleteFile(list(i))
                        list.RemoveAt(i)
                        num14 = CShort((num14 - 1))
                    End If
                    i += 1
                Loop
            End If
            MyProject.Forms.Main.FileSystemWatcher.EnableRaisingEvents = True
            MyProject.Forms.Main.Go(MyProject.Forms.Main.DirectoryText.Text, True)
        End Sub


        ' Properties
        Friend Overridable Property FolderText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FolderText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._FolderText = WithEventsValue
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
                    RemoveHandler Me._BrowseButt.Click, New EventHandler(AddressOf Me.Button1_Click)
                End If
                Me._BrowseButt = WithEventsValue
                If (Not Me._BrowseButt Is Nothing) Then
                    AddHandler Me._BrowseButt.Click, New EventHandler(AddressOf Me.Button1_Click)
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
                    RemoveHandler Me._OKButt.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
                Me._OKButt = WithEventsValue
                If (Not Me._OKButt Is Nothing) Then
                    AddHandler Me._OKButt.Click, New EventHandler(AddressOf Me.Button2_Click)
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
                    RemoveHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.Button3_Click)
                End If
                Me._CancelButt = WithEventsValue
                If (Not Me._CancelButt Is Nothing) Then
                    AddHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.Button3_Click)
                End If
            End Set
        End Property

        Friend Overridable Property FileCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FileCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._FileCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SubfoldersCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SubfoldersCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._SubfoldersCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SelectFolder As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._SelectFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._SelectFolder = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FolderLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FolderLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FolderLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AllElementsRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._AllElementsRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._AllElementsRadio Is Nothing) Then
                    RemoveHandler Me._AllElementsRadio.CheckedChanged, New EventHandler(AddressOf Me.RadioButton1_CheckedChanged)
                End If
                Me._AllElementsRadio = WithEventsValue
                If (Not Me._AllElementsRadio Is Nothing) Then
                    AddHandler Me._AllElementsRadio.CheckedChanged, New EventHandler(AddressOf Me.RadioButton1_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property SelectedElementsRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._SelectedElementsRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._SelectedElementsRadio Is Nothing) Then
                    RemoveHandler Me._SelectedElementsRadio.CheckedChanged, New EventHandler(AddressOf Me.RadioButton2_CheckedChanged)
                End If
                Me._SelectedElementsRadio = WithEventsValue
                If (Not Me._SelectedElementsRadio Is Nothing) Then
                    AddHandler Me._SelectedElementsRadio.CheckedChanged, New EventHandler(AddressOf Me.RadioButton2_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property SelectFilesButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._SelectFilesButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._SelectFilesButt Is Nothing) Then
                    RemoveHandler Me._SelectFilesButt.Click, New EventHandler(AddressOf Me.Button4_Click)
                End If
                Me._SelectFilesButt = WithEventsValue
                If (Not Me._SelectFilesButt Is Nothing) Then
                    AddHandler Me._SelectFilesButt.Click, New EventHandler(AddressOf Me.Button4_Click)
                End If
            End Set
        End Property

        Friend Overridable Property SelectFiles As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._SelectFiles
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._SelectFiles = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviewButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviewButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._PreviewButt = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FoldersCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FoldersCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._FoldersCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabControl1 As TabControl
            <DebuggerNonUserCode> _
            Get
                Return Me._TabControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabControl)
                Me._TabControl1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MainTabPage As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTabPage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._MainTabPage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenameTabPage As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._RenameTabPage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._RenameTabPage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FormattazioneGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FormattazioneGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._FormattazioneGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FormattazioneCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FormattazioneCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._FormattazioneCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ReplaceGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ReplaceGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._ReplaceGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ReplaceCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ReplaceCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._ReplaceCheck Is Nothing) Then
                    RemoveHandler Me._ReplaceCheck.CheckedChanged, New EventHandler(AddressOf Me.ReplaceCheck_CheckedChanged)
                End If
                Me._ReplaceCheck = WithEventsValue
                If (Not Me._ReplaceCheck Is Nothing) Then
                    AddHandler Me._ReplaceCheck.CheckedChanged, New EventHandler(AddressOf Me.ReplaceCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property WithLab3 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WithLab2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WithLab1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._DeleteGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._DeleteCheck Is Nothing) Then
                    RemoveHandler Me._DeleteCheck.CheckedChanged, New EventHandler(AddressOf Me.DeleteCheck_CheckedChanged)
                End If
                Me._DeleteCheck = WithEventsValue
                If (Not Me._DeleteCheck Is Nothing) Then
                    AddHandler Me._DeleteCheck.CheckedChanged, New EventHandler(AddressOf Me.DeleteCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property RenDelete2 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete1 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteTabPage As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteTabPage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._DeleteTabPage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabPage4 As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._TabPage4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._TabPage4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabPage5 As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._TabPage5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._TabPage5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabPage6 As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._TabPage6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._TabPage6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton2 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RadioButton2 Is Nothing) Then
                    RemoveHandler Me._RadioButton2.CheckedChanged, New EventHandler(AddressOf Me.RadioButton2_CheckedChanged_1)
                End If
                Me._RadioButton2 = WithEventsValue
                If (Not Me._RadioButton2 Is Nothing) Then
                    AddHandler Me._RadioButton2.CheckedChanged, New EventHandler(AddressOf Me.RadioButton2_CheckedChanged_1)
                End If
            End Set
        End Property

        Friend Overridable Property RadioButton1 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RadioButton1 Is Nothing) Then
                    RemoveHandler Me._RadioButton1.CheckedChanged, New EventHandler(AddressOf Me.RadioButton1_CheckedChanged_1)
                End If
                Me._RadioButton1 = WithEventsValue
                If (Not Me._RadioButton1 Is Nothing) Then
                    AddHandler Me._RadioButton1.CheckedChanged, New EventHandler(AddressOf Me.RadioButton1_CheckedChanged_1)
                End If
            End Set
        End Property

        Friend Overridable Property FormattingPreview1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FormattingPreview1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FormattingPreview1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FormattingPreview2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FormattingPreview2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FormattingPreview2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton3 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RadioButton3 Is Nothing) Then
                    RemoveHandler Me._RadioButton3.CheckedChanged, New EventHandler(AddressOf Me.RadioButton3_CheckedChanged)
                End If
                Me._RadioButton3 = WithEventsValue
                If (Not Me._RadioButton3 Is Nothing) Then
                    AddHandler Me._RadioButton3.CheckedChanged, New EventHandler(AddressOf Me.RadioButton3_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property RadioButton4 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RadioButton4 Is Nothing) Then
                    RemoveHandler Me._RadioButton4.CheckedChanged, New EventHandler(AddressOf Me.RadioButton4_CheckedChanged)
                End If
                Me._RadioButton4 = WithEventsValue
                If (Not Me._RadioButton4 Is Nothing) Then
                    AddHandler Me._RadioButton4.CheckedChanged, New EventHandler(AddressOf Me.RadioButton4_CheckedChanged)
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

        Friend Overridable Property Replace6A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace6A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace6A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace5A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace5A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace5A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace4A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace4A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace4A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace6B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace6B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace6B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace5B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace5B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace5B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace4B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace4B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace4B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WithLab6 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WithLab5 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WithLab4 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._WithLab4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._WithLab4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace3A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace3A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace3A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace2A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace2A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace2A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace1A As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace1A
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace1A = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace3B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace3B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace3B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace2B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace2B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace2B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Replace1B As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Replace1B
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._Replace1B = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete6 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete5 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete4 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete3 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property WorkProg As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._WorkProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._WorkProg = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton5 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._RadioButton5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton6 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RadioButton6 Is Nothing) Then
                    RemoveHandler Me._RadioButton6.CheckedChanged, New EventHandler(AddressOf Me.RadioButton6_CheckedChanged)
                End If
                Me._RadioButton6 = WithEventsValue
                If (Not Me._RadioButton6 Is Nothing) Then
                    AddHandler Me._RadioButton6.CheckedChanged, New EventHandler(AddressOf Me.RadioButton6_CheckedChanged)
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

        Friend Overridable Property PictureBox3 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName9 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName9 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName8 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName8 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName7 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName12 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName12 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName11 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName11 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName10 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName10 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName3 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName2 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName1 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName6 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName5 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelName4 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelName4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelName4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteNameCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteNameCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._DeleteNameCheck Is Nothing) Then
                    RemoveHandler Me._DeleteNameCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox2_CheckedChanged)
                End If
                Me._DeleteNameCheck = WithEventsValue
                If (Not Me._DeleteNameCheck Is Nothing) Then
                    AddHandler Me._DeleteNameCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox2_CheckedChanged)
                End If
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

        Friend Overridable Property PictureBox2 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox2 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox3 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox4 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox5 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox6 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox7 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox7 = WithEventsValue
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

        Friend Overridable Property TextBox8 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox8 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox9 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox9 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox10 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox10 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox11 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox11 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox12 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox12 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox13 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TextBox13
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox13 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label4 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label5 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label6 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SmallerLenghtCombo As ComboBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SmallerLenghtCombo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._SmallerLenghtCombo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SmallerLenghtUpDown As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._SmallerLenghtUpDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._SmallerLenghtUpDown = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SmallerLenghtCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SmallerLenghtCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._SmallerLenghtCheck Is Nothing) Then
                    RemoveHandler Me._SmallerLenghtCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox4_CheckedChanged)
                End If
                Me._SmallerLenghtCheck = WithEventsValue
                If (Not Me._SmallerLenghtCheck Is Nothing) Then
                    AddHandler Me._SmallerLenghtCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox4_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property BiggerLenghtCombo As ComboBox
            <DebuggerNonUserCode> _
            Get
                Return Me._BiggerLenghtCombo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._BiggerLenghtCombo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BiggerLenghtUpDown As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._BiggerLenghtUpDown
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._BiggerLenghtUpDown = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BiggerLenghtCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._BiggerLenghtCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._BiggerLenghtCheck Is Nothing) Then
                    RemoveHandler Me._BiggerLenghtCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox3_CheckedChanged)
                End If
                Me._BiggerLenghtCheck = WithEventsValue
                If (Not Me._BiggerLenghtCheck Is Nothing) Then
                    AddHandler Me._BiggerLenghtCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox3_CheckedChanged)
                End If
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

        Friend Overridable Property PictureBox6 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PictureBox5 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PictureBox4 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension9 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension9 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension8 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension8 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension7 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension12 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension12
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension12 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension11 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension11
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension11 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension10 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension10
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension10 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension3 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension2 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension1 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension6 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension5 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DelExtension4 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DelExtension4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._DelExtension4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DeleteExtensionCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DeleteExtensionCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._DeleteExtensionCheck Is Nothing) Then
                    RemoveHandler Me._DeleteExtensionCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox5_CheckedChanged)
                End If
                Me._DeleteExtensionCheck = WithEventsValue
                If (Not Me._DeleteExtensionCheck Is Nothing) Then
                    AddHandler Me._DeleteExtensionCheck.CheckedChanged, New EventHandler(AddressOf Me.CheckBox5_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property RenDelete9 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete9
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete9 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete8 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete8 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RenDelete7 As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._RenDelete7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._RenDelete7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PictureBox7 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox7 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PictureBox8 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox8 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("FolderText")> _
        Private _FolderText As TextBox
        <AccessedThroughProperty("BrowseButt")> _
        Private _BrowseButt As Button
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("FileCheck")> _
        Private _FileCheck As CheckBox
        <AccessedThroughProperty("SubfoldersCheck")> _
        Private _SubfoldersCheck As CheckBox
        <AccessedThroughProperty("SelectFolder")> _
        Private _SelectFolder As FolderBrowserDialog
        <AccessedThroughProperty("FolderLab")> _
        Private _FolderLab As Label
        <AccessedThroughProperty("AllElementsRadio")> _
        Private _AllElementsRadio As RadioButton
        <AccessedThroughProperty("SelectedElementsRadio")> _
        Private _SelectedElementsRadio As RadioButton
        <AccessedThroughProperty("SelectFilesButt")> _
        Private _SelectFilesButt As Button
        <AccessedThroughProperty("SelectFiles")> _
        Private _SelectFiles As OpenFileDialog
        <AccessedThroughProperty("PreviewButt")> _
        Private _PreviewButt As Button
        <AccessedThroughProperty("FoldersCheck")> _
        Private _FoldersCheck As CheckBox
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("MainTabPage")> _
        Private _MainTabPage As TabPage
        <AccessedThroughProperty("RenameTabPage")> _
        Private _RenameTabPage As TabPage
        <AccessedThroughProperty("FormattazioneGroup")> _
        Private _FormattazioneGroup As GroupBox
        <AccessedThroughProperty("FormattazioneCheck")> _
        Private _FormattazioneCheck As CheckBox
        <AccessedThroughProperty("ReplaceGroup")> _
        Private _ReplaceGroup As GroupBox
        <AccessedThroughProperty("ReplaceCheck")> _
        Private _ReplaceCheck As CheckBox
        <AccessedThroughProperty("WithLab3")> _
        Private _WithLab3 As Label
        <AccessedThroughProperty("WithLab2")> _
        Private _WithLab2 As Label
        <AccessedThroughProperty("WithLab1")> _
        Private _WithLab1 As Label
        <AccessedThroughProperty("DeleteGroup")> _
        Private _DeleteGroup As GroupBox
        <AccessedThroughProperty("DeleteCheck")> _
        Private _DeleteCheck As CheckBox
        <AccessedThroughProperty("RenDelete2")> _
        Private _RenDelete2 As TextBox
        <AccessedThroughProperty("RenDelete1")> _
        Private _RenDelete1 As TextBox
        <AccessedThroughProperty("DeleteTabPage")> _
        Private _DeleteTabPage As TabPage
        <AccessedThroughProperty("TabPage4")> _
        Private _TabPage4 As TabPage
        <AccessedThroughProperty("TabPage5")> _
        Private _TabPage5 As TabPage
        <AccessedThroughProperty("TabPage6")> _
        Private _TabPage6 As TabPage
        <AccessedThroughProperty("RadioButton2")> _
        Private _RadioButton2 As RadioButton
        <AccessedThroughProperty("RadioButton1")> _
        Private _RadioButton1 As RadioButton
        <AccessedThroughProperty("FormattingPreview1")> _
        Private _FormattingPreview1 As Label
        <AccessedThroughProperty("FormattingPreview2")> _
        Private _FormattingPreview2 As Label
        <AccessedThroughProperty("RadioButton3")> _
        Private _RadioButton3 As RadioButton
        <AccessedThroughProperty("RadioButton4")> _
        Private _RadioButton4 As RadioButton
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("Replace6A")> _
        Private _Replace6A As TextBox
        <AccessedThroughProperty("Replace5A")> _
        Private _Replace5A As TextBox
        <AccessedThroughProperty("Replace4A")> _
        Private _Replace4A As TextBox
        <AccessedThroughProperty("Replace6B")> _
        Private _Replace6B As TextBox
        <AccessedThroughProperty("Replace5B")> _
        Private _Replace5B As TextBox
        <AccessedThroughProperty("Replace4B")> _
        Private _Replace4B As TextBox
        <AccessedThroughProperty("WithLab6")> _
        Private _WithLab6 As Label
        <AccessedThroughProperty("WithLab5")> _
        Private _WithLab5 As Label
        <AccessedThroughProperty("WithLab4")> _
        Private _WithLab4 As Label
        <AccessedThroughProperty("Replace3A")> _
        Private _Replace3A As TextBox
        <AccessedThroughProperty("Replace2A")> _
        Private _Replace2A As TextBox
        <AccessedThroughProperty("Replace1A")> _
        Private _Replace1A As TextBox
        <AccessedThroughProperty("Replace3B")> _
        Private _Replace3B As TextBox
        <AccessedThroughProperty("Replace2B")> _
        Private _Replace2B As TextBox
        <AccessedThroughProperty("Replace1B")> _
        Private _Replace1B As TextBox
        <AccessedThroughProperty("RenDelete6")> _
        Private _RenDelete6 As TextBox
        <AccessedThroughProperty("RenDelete5")> _
        Private _RenDelete5 As TextBox
        <AccessedThroughProperty("RenDelete4")> _
        Private _RenDelete4 As TextBox
        <AccessedThroughProperty("RenDelete3")> _
        Private _RenDelete3 As TextBox
        <AccessedThroughProperty("WorkProg")> _
        Private _WorkProg As ProgressBar
        <AccessedThroughProperty("RadioButton5")> _
        Private _RadioButton5 As RadioButton
        <AccessedThroughProperty("RadioButton6")> _
        Private _RadioButton6 As RadioButton
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("PictureBox3")> _
        Private _PictureBox3 As PictureBox
        <AccessedThroughProperty("DelName9")> _
        Private _DelName9 As TextBox
        <AccessedThroughProperty("DelName8")> _
        Private _DelName8 As TextBox
        <AccessedThroughProperty("DelName7")> _
        Private _DelName7 As TextBox
        <AccessedThroughProperty("DelName12")> _
        Private _DelName12 As TextBox
        <AccessedThroughProperty("DelName11")> _
        Private _DelName11 As TextBox
        <AccessedThroughProperty("DelName10")> _
        Private _DelName10 As TextBox
        <AccessedThroughProperty("DelName3")> _
        Private _DelName3 As TextBox
        <AccessedThroughProperty("DelName2")> _
        Private _DelName2 As TextBox
        <AccessedThroughProperty("DelName1")> _
        Private _DelName1 As TextBox
        <AccessedThroughProperty("DelName6")> _
        Private _DelName6 As TextBox
        <AccessedThroughProperty("DelName5")> _
        Private _DelName5 As TextBox
        <AccessedThroughProperty("DelName4")> _
        Private _DelName4 As TextBox
        <AccessedThroughProperty("DeleteNameCheck")> _
        Private _DeleteNameCheck As CheckBox
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox
        <AccessedThroughProperty("PictureBox2")> _
        Private _PictureBox2 As PictureBox
        <AccessedThroughProperty("TextBox2")> _
        Private _TextBox2 As TextBox
        <AccessedThroughProperty("TextBox3")> _
        Private _TextBox3 As TextBox
        <AccessedThroughProperty("TextBox4")> _
        Private _TextBox4 As TextBox
        <AccessedThroughProperty("TextBox5")> _
        Private _TextBox5 As TextBox
        <AccessedThroughProperty("TextBox6")> _
        Private _TextBox6 As TextBox
        <AccessedThroughProperty("TextBox7")> _
        Private _TextBox7 As TextBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("TextBox8")> _
        Private _TextBox8 As TextBox
        <AccessedThroughProperty("TextBox9")> _
        Private _TextBox9 As TextBox
        <AccessedThroughProperty("TextBox10")> _
        Private _TextBox10 As TextBox
        <AccessedThroughProperty("TextBox11")> _
        Private _TextBox11 As TextBox
        <AccessedThroughProperty("TextBox12")> _
        Private _TextBox12 As TextBox
        <AccessedThroughProperty("TextBox13")> _
        Private _TextBox13 As TextBox
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
        <AccessedThroughProperty("Label5")> _
        Private _Label5 As Label
        <AccessedThroughProperty("Label6")> _
        Private _Label6 As Label
        <AccessedThroughProperty("SmallerLenghtCombo")> _
        Private _SmallerLenghtCombo As ComboBox
        <AccessedThroughProperty("SmallerLenghtUpDown")> _
        Private _SmallerLenghtUpDown As NumericUpDown
        <AccessedThroughProperty("SmallerLenghtCheck")> _
        Private _SmallerLenghtCheck As CheckBox
        <AccessedThroughProperty("BiggerLenghtCombo")> _
        Private _BiggerLenghtCombo As ComboBox
        <AccessedThroughProperty("BiggerLenghtUpDown")> _
        Private _BiggerLenghtUpDown As NumericUpDown
        <AccessedThroughProperty("BiggerLenghtCheck")> _
        Private _BiggerLenghtCheck As CheckBox
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox
        <AccessedThroughProperty("PictureBox6")> _
        Private _PictureBox6 As PictureBox
        <AccessedThroughProperty("PictureBox5")> _
        Private _PictureBox5 As PictureBox
        <AccessedThroughProperty("PictureBox4")> _
        Private _PictureBox4 As PictureBox
        <AccessedThroughProperty("DelExtension9")> _
        Private _DelExtension9 As TextBox
        <AccessedThroughProperty("DelExtension8")> _
        Private _DelExtension8 As TextBox
        <AccessedThroughProperty("DelExtension7")> _
        Private _DelExtension7 As TextBox
        <AccessedThroughProperty("DelExtension12")> _
        Private _DelExtension12 As TextBox
        <AccessedThroughProperty("DelExtension11")> _
        Private _DelExtension11 As TextBox
        <AccessedThroughProperty("DelExtension10")> _
        Private _DelExtension10 As TextBox
        <AccessedThroughProperty("DelExtension3")> _
        Private _DelExtension3 As TextBox
        <AccessedThroughProperty("DelExtension2")> _
        Private _DelExtension2 As TextBox
        <AccessedThroughProperty("DelExtension1")> _
        Private _DelExtension1 As TextBox
        <AccessedThroughProperty("DelExtension6")> _
        Private _DelExtension6 As TextBox
        <AccessedThroughProperty("DelExtension5")> _
        Private _DelExtension5 As TextBox
        <AccessedThroughProperty("DelExtension4")> _
        Private _DelExtension4 As TextBox
        <AccessedThroughProperty("DeleteExtensionCheck")> _
        Private _DeleteExtensionCheck As CheckBox
        <AccessedThroughProperty("RenDelete9")> _
        Private _RenDelete9 As TextBox
        <AccessedThroughProperty("RenDelete8")> _
        Private _RenDelete8 As TextBox
        <AccessedThroughProperty("RenDelete7")> _
        Private _RenDelete7 As TextBox
        <AccessedThroughProperty("PictureBox7")> _
        Private _PictureBox7 As PictureBox
        <AccessedThroughProperty("PictureBox8")> _
        Private _PictureBox8 As PictureBox
    End Class
End Namespace

