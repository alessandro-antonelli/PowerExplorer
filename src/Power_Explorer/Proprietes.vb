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
    Public Class Proprietes
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Select Case Me.Mode
                Case 1
                    If (MyProject.Computer.FileSystem.GetFileInfo(Me.Path).Name <> (Me.A1Lab.Text & Me.NomeText.Text & Me.EstensioneText.Text)) Then
                        MyProject.Computer.FileSystem.RenameFile(Me.Path, (Me.NomeText.Text & Me.EstensioneText.Text))
                    End If
                    Exit Select
                Case Else
                    Exit Select
            End Select
            Me.Close
        End Sub

        Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
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
            Dim manager As New ComponentResourceManager(GetType(Proprietes))
            Me.TabControl1 = New TabControl
            Me.TabPage1 = New TabPage
            Me.PercentLab = New Label
            Me.TableLayoutPanel1 = New TableLayoutPanel
            Me.I1Lab = New Label
            Me.I2Lab = New Label
            Me.H1Lab = New Label
            Me.H2Lab = New Label
            Me.G1Lab = New Label
            Me.G2Lab = New Label
            Me.A1Lab = New Label
            Me.B1Lab = New Label
            Me.F2Lab = New Label
            Me.B2Lab = New Label
            Me.F1Lab = New Label
            Me.E2Lab = New Label
            Me.C1Lab = New Label
            Me.D2Lab = New Label
            Me.C2Lab = New Label
            Me.D1Lab = New Label
            Me.E1Lab = New Label
            Me.A2Lab = New Label
            Me.UsedSpaceLab = New Label
            Me.UsedSpaceProg = New ProgressBar
            Me.AttributesGroup = New GroupBox
            Me.SolaLetturaChek = New CheckBox
            Me.SystemCheck = New CheckBox
            Me.NascostoChek = New CheckBox
            Me.CompressoCheck = New CheckBox
            Me.ArchiveCheck = New CheckBox
            Me.EstensioneText = New TextBox
            Me.IconPict = New PictureBox
            Me.NomeText = New TextBox
            Me.TabPage2 = New TabPage
            Me.MetaProp = New PropertyGrid
            Me.Button1 = New Button
            Me.Button3 = New Button
            Me.Button4 = New Button
            Me.TabControl1.SuspendLayout
            Me.TabPage1.SuspendLayout
            Me.TableLayoutPanel1.SuspendLayout
            Me.AttributesGroup.SuspendLayout
            DirectCast(Me.IconPict, ISupportInitialize).BeginInit
            Me.TabPage2.SuspendLayout
            Me.SuspendLayout
            Me.TabControl1.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Dim point As New Point(12, 12)
            Me.TabControl1.Location = point
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Dim size As New Size(&H13E, &H199)
            Me.TabControl1.Size = size
            Me.TabControl1.TabIndex = 0
            Me.TabPage1.Controls.Add(Me.PercentLab)
            Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
            Me.TabPage1.Controls.Add(Me.UsedSpaceLab)
            Me.TabPage1.Controls.Add(Me.UsedSpaceProg)
            Me.TabPage1.Controls.Add(Me.AttributesGroup)
            Me.TabPage1.Controls.Add(Me.EstensioneText)
            Me.TabPage1.Controls.Add(Me.IconPict)
            Me.TabPage1.Controls.Add(Me.NomeText)
            point = New Point(4, &H16)
            Me.TabPage1.Location = point
            Me.TabPage1.Name = "TabPage1"
            Dim padding As New Padding(3)
            Me.TabPage1.Padding = padding
            size = New Size(310, &H17F)
            Me.TabPage1.Size = size
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Generale"
            Me.TabPage1.UseVisualStyleBackColor = True
            Me.PercentLab.AutoSize = True
            point = New Point(260, &H109)
            Me.PercentLab.Location = point
            size = New Size(50, 13)
            Me.PercentLab.MaximumSize = size
            Me.PercentLab.Name = "PercentLab"
            size = New Size(&H2A, 13)
            Me.PercentLab.Size = size
            Me.PercentLab.TabIndex = &H2E
            Me.PercentLab.Text = "80,52%"
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.Controls.Add(Me.I1Lab, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.I2Lab, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.H1Lab, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.H2Lab, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.G1Lab, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.G2Lab, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.A1Lab, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.B1Lab, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.F2Lab, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.B2Lab, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.F1Lab, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.E2Lab, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.C1Lab, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.D2Lab, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.C2Lab, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.D1Lab, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.E1Lab, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.A2Lab, 1, 0)
            point = New Point(6, &H5B)
            Me.TableLayoutPanel1.Location = point
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 9
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            size = New Size(&H12A, &H8A)
            Me.TableLayoutPanel1.Size = size
            Me.TableLayoutPanel1.TabIndex = &H2D
            Me.I1Lab.AutoSize = True
            point = New Point(3, &H68)
            Me.I1Lab.Location = point
            Me.I1Lab.Name = "I1Lab"
            size = New Size(&H10, 13)
            Me.I1Lab.Size = size
            Me.I1Lab.TabIndex = &H34
            Me.I1Lab.Text = "I1"
            Me.I2Lab.AutoSize = True
            point = New Point(30, &H68)
            Me.I2Lab.Location = point
            Me.I2Lab.Name = "I2Lab"
            size = New Size(&H10, 13)
            Me.I2Lab.Size = size
            Me.I2Lab.TabIndex = &H33
            Me.I2Lab.Text = "I2"
            Me.H1Lab.AutoSize = True
            point = New Point(3, &H5B)
            Me.H1Lab.Location = point
            Me.H1Lab.Name = "H1Lab"
            size = New Size(&H15, 13)
            Me.H1Lab.Size = size
            Me.H1Lab.TabIndex = 50
            Me.H1Lab.Text = "H1"
            Me.H2Lab.AutoSize = True
            point = New Point(30, &H5B)
            Me.H2Lab.Location = point
            Me.H2Lab.Name = "H2Lab"
            size = New Size(&H15, 13)
            Me.H2Lab.Size = size
            Me.H2Lab.TabIndex = &H31
            Me.H2Lab.Text = "H2"
            Me.G1Lab.AutoSize = True
            point = New Point(3, &H4E)
            Me.G1Lab.Location = point
            Me.G1Lab.Name = "G1Lab"
            size = New Size(&H15, 13)
            Me.G1Lab.Size = size
            Me.G1Lab.TabIndex = &H30
            Me.G1Lab.Text = "G1"
            Me.G2Lab.AutoSize = True
            point = New Point(30, &H4E)
            Me.G2Lab.Location = point
            Me.G2Lab.Name = "G2Lab"
            size = New Size(&H15, 13)
            Me.G2Lab.Size = size
            Me.G2Lab.TabIndex = &H2F
            Me.G2Lab.Text = "G2"
            Me.A1Lab.AutoSize = True
            point = New Point(3, 0)
            Me.A1Lab.Location = point
            Me.A1Lab.Name = "A1Lab"
            size = New Size(20, 13)
            Me.A1Lab.Size = size
            Me.A1Lab.TabIndex = &H12
            Me.A1Lab.Text = "A1"
            Me.B1Lab.AutoSize = True
            point = New Point(3, 13)
            Me.B1Lab.Location = point
            Me.B1Lab.Name = "B1Lab"
            size = New Size(20, 13)
            Me.B1Lab.Size = size
            Me.B1Lab.TabIndex = &H15
            Me.B1Lab.Text = "B1"
            Me.F2Lab.AutoSize = True
            point = New Point(30, &H41)
            Me.F2Lab.Location = point
            Me.F2Lab.Name = "F2Lab"
            size = New Size(&H13, 13)
            Me.F2Lab.Size = size
            Me.F2Lab.TabIndex = &H2B
            Me.F2Lab.Text = "F2"
            Me.B2Lab.AutoSize = True
            point = New Point(30, 13)
            Me.B2Lab.Location = point
            size = New Size(180, 13)
            Me.B2Lab.MaximumSize = size
            Me.B2Lab.Name = "B2Lab"
            size = New Size(20, 13)
            Me.B2Lab.Size = size
            Me.B2Lab.TabIndex = &H16
            Me.B2Lab.Text = "B2"
            Me.F1Lab.AutoSize = True
            point = New Point(3, &H41)
            Me.F1Lab.Location = point
            Me.F1Lab.Name = "F1Lab"
            size = New Size(&H13, 13)
            Me.F1Lab.Size = size
            Me.F1Lab.TabIndex = &H2A
            Me.F1Lab.Text = "F1"
            Me.E2Lab.AutoSize = True
            point = New Point(30, &H34)
            Me.E2Lab.Location = point
            Me.E2Lab.Name = "E2Lab"
            size = New Size(20, 13)
            Me.E2Lab.Size = size
            Me.E2Lab.TabIndex = 30
            Me.E2Lab.Text = "E2"
            Me.C1Lab.AutoSize = True
            point = New Point(3, &H1A)
            Me.C1Lab.Location = point
            Me.C1Lab.Name = "C1Lab"
            size = New Size(20, 13)
            Me.C1Lab.Size = size
            Me.C1Lab.TabIndex = &H17
            Me.C1Lab.Text = "C1"
            Me.D2Lab.AutoSize = True
            point = New Point(30, &H27)
            Me.D2Lab.Location = point
            Me.D2Lab.Name = "D2Lab"
            size = New Size(&H15, 13)
            Me.D2Lab.Size = size
            Me.D2Lab.TabIndex = &H1C
            Me.D2Lab.Text = "D2"
            Me.C2Lab.AutoSize = True
            point = New Point(30, &H1A)
            Me.C2Lab.Location = point
            Me.C2Lab.Name = "C2Lab"
            size = New Size(20, 13)
            Me.C2Lab.Size = size
            Me.C2Lab.TabIndex = &H18
            Me.C2Lab.Text = "C2"
            Me.D1Lab.AutoSize = True
            point = New Point(3, &H27)
            Me.D1Lab.Location = point
            Me.D1Lab.Name = "D1Lab"
            size = New Size(&H15, 13)
            Me.D1Lab.Size = size
            Me.D1Lab.TabIndex = &H1B
            Me.D1Lab.Text = "D1"
            Me.E1Lab.AutoSize = True
            point = New Point(3, &H34)
            Me.E1Lab.Location = point
            Me.E1Lab.Name = "E1Lab"
            size = New Size(20, 13)
            Me.E1Lab.Size = size
            Me.E1Lab.TabIndex = &H1D
            Me.E1Lab.Text = "E1"
            Me.A2Lab.AutoSize = True
            point = New Point(30, 0)
            Me.A2Lab.Location = point
            size = New Size(180, &H27)
            Me.A2Lab.MaximumSize = size
            Me.A2Lab.Name = "A2Lab"
            size = New Size(20, 13)
            Me.A2Lab.Size = size
            Me.A2Lab.TabIndex = 20
            Me.A2Lab.Text = "A2"
            Me.UsedSpaceLab.AutoSize = True
            point = New Point(3, &H109)
            Me.UsedSpaceLab.Location = point
            Me.UsedSpaceLab.Name = "UsedSpaceLab"
            size = New Size(&H52, 13)
            Me.UsedSpaceLab.Size = size
            Me.UsedSpaceLab.TabIndex = &H2C
            Me.UsedSpaceLab.Text = "Spazio utilizzato"
            Me.UsedSpaceLab.Visible = False
            point = New Point(6, &H119)
            Me.UsedSpaceProg.Location = point
            Me.UsedSpaceProg.Name = "UsedSpaceProg"
            size = New Size(&H12A, &H17)
            Me.UsedSpaceProg.Size = size
            Me.UsedSpaceProg.TabIndex = 0
            Me.UsedSpaceProg.Visible = False
            Me.AttributesGroup.Controls.Add(Me.SolaLetturaChek)
            Me.AttributesGroup.Controls.Add(Me.SystemCheck)
            Me.AttributesGroup.Controls.Add(Me.NascostoChek)
            Me.AttributesGroup.Controls.Add(Me.CompressoCheck)
            Me.AttributesGroup.Controls.Add(Me.ArchiveCheck)
            point = New Point(6, &H139)
            Me.AttributesGroup.Location = point
            Me.AttributesGroup.Name = "AttributesGroup"
            size = New Size(&H12A, &H40)
            Me.AttributesGroup.Size = size
            Me.AttributesGroup.TabIndex = &H29
            Me.AttributesGroup.TabStop = False
            Me.AttributesGroup.Text = "Attributi"
            Me.SolaLetturaChek.AutoSize = True
            point = New Point(6, &H12)
            Me.SolaLetturaChek.Location = point
            Me.SolaLetturaChek.Name = "SolaLetturaChek"
            size = New Size(&H4F, &H11)
            Me.SolaLetturaChek.Size = size
            Me.SolaLetturaChek.TabIndex = &H20
            Me.SolaLetturaChek.Text = "Sola lettura"
            Me.SolaLetturaChek.UseVisualStyleBackColor = True
            Me.SystemCheck.AutoSize = True
            point = New Point(&HAF, &H13)
            Me.SystemCheck.Location = point
            Me.SystemCheck.Name = "SystemCheck"
            size = New Size(&H4A, &H11)
            Me.SystemCheck.Size = size
            Me.SystemCheck.TabIndex = &H27
            Me.SystemCheck.Text = "Di sistema"
            Me.SystemCheck.UseVisualStyleBackColor = True
            Me.NascostoChek.AutoSize = True
            point = New Point(&H5B, &H12)
            Me.NascostoChek.Location = point
            Me.NascostoChek.Name = "NascostoChek"
            size = New Size(&H47, &H11)
            Me.NascostoChek.Size = size
            Me.NascostoChek.TabIndex = &H22
            Me.NascostoChek.Text = "Nascosto"
            Me.NascostoChek.UseVisualStyleBackColor = True
            Me.CompressoCheck.AutoSize = True
            point = New Point(&H5B, &H29)
            Me.CompressoCheck.Location = point
            Me.CompressoCheck.Name = "CompressoCheck"
            size = New Size(&H4E, &H11)
            Me.CompressoCheck.Size = size
            Me.CompressoCheck.TabIndex = &H25
            Me.CompressoCheck.Text = "Compresso"
            Me.CompressoCheck.UseVisualStyleBackColor = True
            Me.ArchiveCheck.AutoSize = True
            point = New Point(6, &H29)
            Me.ArchiveCheck.Location = point
            Me.ArchiveCheck.Name = "ArchiveCheck"
            size = New Size(&H40, &H11)
            Me.ArchiveCheck.Size = size
            Me.ArchiveCheck.TabIndex = &H26
            Me.ArchiveCheck.Text = "Archivio"
            Me.ArchiveCheck.UseVisualStyleBackColor = True
            point = New Point(&H4C, &H20)
            Me.EstensioneText.Location = point
            Me.EstensioneText.Name = "EstensioneText"
            size = New Size(100, 20)
            Me.EstensioneText.Size = size
            Me.EstensioneText.TabIndex = &H1A
            Me.EstensioneText.Text = ".estensione"
            Me.IconPict.Image = Resources.empty_128
            point = New Point(6, 6)
            Me.IconPict.Location = point
            Me.IconPict.Name = "IconPict"
            size = New Size(&H40, &H40)
            Me.IconPict.Size = size
            Me.IconPict.SizeMode = PictureBoxSizeMode.Zoom
            Me.IconPict.TabIndex = &H19
            Me.IconPict.TabStop = False
            Me.NomeText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H4C, 6)
            Me.NomeText.Location = point
            Me.NomeText.Name = "NomeText"
            size = New Size(&HE4, 20)
            Me.NomeText.Size = size
            Me.NomeText.TabIndex = &H13
            Me.NomeText.Text = "Nome del file"
            Me.TabPage2.Controls.Add(Me.MetaProp)
            point = New Point(4, &H16)
            Me.TabPage2.Location = point
            Me.TabPage2.Name = "TabPage2"
            padding = New Padding(3)
            Me.TabPage2.Padding = padding
            size = New Size(310, &H17F)
            Me.TabPage2.Size = size
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Meta tag"
            Me.TabPage2.UseVisualStyleBackColor = True
            point = New Point(6, 6)
            Me.MetaProp.Location = point
            Me.MetaProp.Name = "MetaProp"
            size = New Size(&H12A, &H173)
            Me.MetaProp.Size = size
            Me.MetaProp.TabIndex = 0
            Me.Button1.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&HFF, &H1AF)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            size = New Size(&H4B, &H17)
            Me.Button1.Size = size
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "&OK"
            Me.Button1.UseVisualStyleBackColor = True
            Me.Button3.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H5C, &H1AF)
            Me.Button3.Location = point
            Me.Button3.Name = "Button3"
            size = New Size(&H4B, &H17)
            Me.Button3.Size = size
            Me.Button3.TabIndex = 3
            Me.Button3.Text = "&Annulla"
            Me.Button3.UseVisualStyleBackColor = True
            Me.Button4.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&HAE, &H1AF)
            Me.Button4.Location = point
            Me.Button4.Name = "Button4"
            size = New Size(&H4B, &H17)
            Me.Button4.Size = size
            Me.Button4.TabIndex = 4
            Me.Button4.Text = "A&pplica"
            Me.Button4.UseVisualStyleBackColor = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H156, &H1D2)
            Me.ClientSize = size
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TabControl1)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.Name = "Proprietes"
            Me.Text = "Proprietà"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout
            Me.AttributesGroup.ResumeLayout(False)
            Me.AttributesGroup.PerformLayout
            DirectCast(Me.IconPict, ISupportInitialize).EndInit
            Me.TabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadDirectory(ByVal Directory As String)
            Me.Mode = 2
            Me.Path = Directory
            Me.A1Lab.Text = "Percorso:"
            Me.B1Lab.Text = "Dimensioni:"
            Me.C1Lab.Text = "Sottocartelle contenute:"
            Me.D1Lab.Text = "Files contenuti:"
            Me.E1Lab.Text = "Creata il:"
            Me.EstensioneText.Visible = False
            Me.PercentLab.Visible = False
            Me.NomeText.Text = MyProject.Computer.FileSystem.GetDirectoryInfo(Directory).Name
            Me.A2Lab.Text = MyProject.Computer.FileSystem.GetDirectoryInfo(Directory).FullName
            Me.C2Lab.Text = "..."
            Me.D2Lab.Text = "..."
            Me.E2Lab.Text = Strings.Format(MyProject.Computer.FileSystem.GetDirectoryInfo(Directory).CreationTime, "dd/MM/yyyy HH:mm:ss")
            Me.SolaLetturaChek.Visible = False
            Me.NascostoChek.Visible = False
            Me.IconPict.Image = Resources.folder_full_128
            Me.Text = MyProject.Computer.FileSystem.GetDirectoryInfo(Directory).Name
            Me.F1Lab.Visible = False
            Me.F2Lab.Visible = False
            Me.G1Lab.Visible = False
            Me.G2Lab.Visible = False
            Me.H1Lab.Visible = False
            Me.H2Lab.Visible = False
            Me.I1Lab.Visible = False
            Me.I2Lab.Visible = False
        End Sub

        Public Sub LoadDrive(ByVal Drive As String)
            Me.Mode = 3
            Me.Path = Drive
            Me.A1Lab.Text = "Percorso:"
            Me.B1Lab.Text = "Tipo:"
            Me.C1Lab.Text = "File system:"
            Me.D1Lab.Text = "Capacità:"
            Me.E1Lab.Text = "Spazio occupato:"
            Me.F1Lab.Text = "Spazio libero:"
            Me.EstensioneText.Visible = False
            Me.PercentLab.Visible = True
            Me.NomeText.Text = MyProject.Computer.FileSystem.GetDriveInfo(Drive).VolumeLabel
            Me.A2Lab.Text = MyProject.Computer.FileSystem.GetDriveInfo(Drive).Name
            Me.C2Lab.Text = MyProject.Computer.FileSystem.GetDriveInfo(Drive).DriveFormat
            Me.UsedSpaceProg.Visible = True
            Me.UsedSpaceLab.Visible = True
            Me.UsedSpaceProg.Maximum = CInt(Math.Round(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1000))))
            Me.UsedSpaceProg.Value = CInt(Math.Round(CDbl((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1000))))
            Dim str As String = Conversions.ToString(CDbl((((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1000) / (CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1000)) * 100)))
            Me.PercentLab.Text = (str.Remove(5, (str.Length - 5)) & "%")
            Dim totalSize As Long = MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize
            If (totalSize < &H400) Then
                Me.D2Lab.Text = (Conversions.ToString(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) & " B")
            ElseIf (totalSize < &H100000) Then
                Me.D2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1024))) & " KB")
            ElseIf (totalSize < &H40000000) Then
                Me.D2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1048576))) & " MB")
            ElseIf (totalSize < &H10000000000) Then
                Me.D2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1073741824))) & " GB")
            ElseIf (totalSize < &H4000000000000) Then
                Me.D2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize) / 1099511627776))) & " TB")
            End If
            Dim num2 As Long = (MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)
            If (num2 < &H400) Then
                Me.E2Lab.Text = (Conversions.ToString(CLng((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace))) & " B")
            ElseIf (num2 < &H100000) Then
                Me.E2Lab.Text = (Conversions.ToString(CDbl((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1024))) & " KB")
            ElseIf (num2 < &H40000000) Then
                Me.E2Lab.Text = (Conversions.ToString(CDbl((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1048576))) & " MB")
            ElseIf (num2 < &H10000000000) Then
                Me.E2Lab.Text = (Conversions.ToString(CDbl((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1073741824))) & " GB")
            ElseIf (num2 < &H4000000000000) Then
                Me.E2Lab.Text = (Conversions.ToString(CDbl((CDbl((MyProject.Computer.FileSystem.GetDriveInfo(Drive).TotalSize - MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace)) / 1099511627776))) & " TB")
            End If
            Dim availableFreeSpace As Long = MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace
            If (availableFreeSpace < &H400) Then
                Me.F2Lab.Text = (Conversions.ToString(MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace) & " B")
            ElseIf (availableFreeSpace < &H100000) Then
                Me.F2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace) / 1024))) & " KB")
            ElseIf (availableFreeSpace < &H40000000) Then
                Me.F2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace) / 1048576))) & " MB")
            ElseIf (availableFreeSpace < &H10000000000) Then
                Me.F2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace) / 1073741824))) & " GB")
            ElseIf (availableFreeSpace < &H4000000000000) Then
                Me.F2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetDriveInfo(Drive).AvailableFreeSpace) / 1099511627776))) & " TB")
            End If
            Select Case MyProject.Computer.FileSystem.GetDriveInfo(Drive).DriveType
                Case DriveType.Removable
                    Me.IconPict.Image = Resources.usb_128
                    Me.B2Lab.Text = "Unità disco rimovibile"
                    If (Drive = "A:\") Then
                        Me.IconPict.Image = Resources.floppy_128
                        Me.B2Lab.Text = "Unità disco floppy"
                    End If
                    If (Drive = "B:\") Then
                        Me.IconPict.Image = Resources.floppy_128
                        Me.B2Lab.Text = "Unità disco floppy"
                    End If
                    Exit Select
                Case DriveType.Fixed
                    Me.IconPict.Image = Resources.hd_blu_128
                    Me.B2Lab.Text = "Unità disco rigido"
                    Exit Select
                Case DriveType.Network
                    Me.IconPict.Image = Resources.folder_cyan_open
                    Me.B2Lab.Text = "Unità network"
                    Exit Select
                Case DriveType.CDRom
                    Me.IconPict.Image = Resources.cd_128
                    Me.B2Lab.Text = "Unità CD / DVD"
                    Exit Select
                Case Else
                    Exit Select
            End Select
            Me.Text = Drive
            Me.G1Lab.Visible = False
            Me.G2Lab.Visible = False
            Me.H1Lab.Visible = False
            Me.H2Lab.Visible = False
            Me.I1Lab.Visible = False
            Me.I2Lab.Visible = False
        End Sub

        Public Sub LoadFile(ByVal SelectedFile As String, ByVal Index As Short)
            Me.Mode = 1
            Me.Path = SelectedFile
            Me.A1Lab.Text = "Percorso:"
            Me.B1Lab.Text = "Dimensioni:"
            Me.C1Lab.Text = "Creato il:"
            Me.D1Lab.Text = "Ultima modifica:"
            Me.E1Lab.Text = "Ultimo accesso:"
            Dim startIndex As Short = CShort(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name.LastIndexOfAny(Conversions.ToCharArrayRankOne(".")))
            Me.NomeText.Text = If((startIndex >= 1), MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name.Remove(startIndex, (MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name.Length - startIndex)), MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name)
            Me.EstensioneText.Text = MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Extension
            Me.PercentLab.Visible = False
            Me.A2Lab.Text = MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).DirectoryName
            Dim length As Long = MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Length
            If (length < &H400) Then
                Me.B2Lab.Text = (Conversions.ToString(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Length) & " B")
            ElseIf (length < &H100000) Then
                Me.B2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Length) / 1024))) & " KB")
            ElseIf (length < &H40000000) Then
                Me.B2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Length) / 1048576))) & " MB")
            ElseIf (length < &H10000000000) Then
                Me.B2Lab.Text = (Conversions.ToString(CDbl((CDbl(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Length) / 1073741824))) & " GB")
            End If
            Me.C2Lab.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).CreationTime, "dd/MM/yyyy HH:mm:ss")
            Me.D2Lab.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).LastWriteTime, "dd/MM/yyyy HH:mm:ss")
            Me.E2Lab.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).LastAccessTime, "dd/MM/yyyy HH:mm:ss")
            Me.SolaLetturaChek.Checked = MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).IsReadOnly
            Me.CompressoCheck.Enabled = (MyProject.Computer.FileSystem.GetDriveInfo(SelectedFile.Remove(3, (MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name.Length - 3))).DriveFormat = "NTFS")
            Dim num3 As Short = Index
            If (num3 = MySettingsProperty.Settings.ArchiveIcon) Then
                Me.IconPict.Image = Resources.archive_128
            ElseIf (num3 = MySettingsProperty.Settings.DocIcon) Then
                Me.IconPict.Image = Resources.doc_128
            ElseIf (num3 = MySettingsProperty.Settings.ExeIcon) Then
                Me.IconPict.Image = Resources.exe_128
            ElseIf (num3 = MySettingsProperty.Settings.HtmlIcon) Then
                Me.IconPict.Image = Resources.htm_128
            ElseIf (num3 = MySettingsProperty.Settings.ImageIcon) Then
                Me.IconPict.Image = Resources.image_128
            ElseIf (num3 = MySettingsProperty.Settings.LinkIcon) Then
                Me.IconPict.Image = Resources.lnk_128
            ElseIf (num3 = MySettingsProperty.Settings.MidiIcon) Then
                Me.IconPict.Image = Resources.midi
            ElseIf (num3 = MySettingsProperty.Settings.PdfIcon) Then
                Me.IconPict.Image = Resources.pdf_128
            ElseIf (num3 = MySettingsProperty.Settings.RtfIcon) Then
                Me.IconPict.Image = Resources.rtf_128
            ElseIf (num3 = MySettingsProperty.Settings.SoundIcon) Then
                Me.IconPict.Image = Resources.sound_128
            ElseIf (num3 = MySettingsProperty.Settings.TxtIcon) Then
                Me.IconPict.Image = Resources.txt_128
            ElseIf (num3 = MySettingsProperty.Settings.VideoIcon) Then
                Me.IconPict.Image = Resources.video_128
            ElseIf (num3 = MySettingsProperty.Settings.WavIcon) Then
                Me.IconPict.Image = Resources.wav_128
            End If
            Me.Text = MyProject.Computer.FileSystem.GetFileInfo(SelectedFile).Name
            Me.F1Lab.Visible = False
            Me.F2Lab.Visible = False
            Me.G1Lab.Visible = False
            Me.G2Lab.Visible = False
            Me.H1Lab.Visible = False
            Me.H2Lab.Visible = False
            Me.I1Lab.Visible = False
            Me.I2Lab.Visible = False
        End Sub


        ' Properties
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

        Friend Overridable Property TabPage1 As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._TabPage1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._TabPage1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NascostoChek As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._NascostoChek
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._NascostoChek = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SolaLetturaChek As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SolaLetturaChek
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._SolaLetturaChek = WithEventsValue
            End Set
        End Property

        Friend Overridable Property E2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._E2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._E2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property E1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._E1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._E1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property D2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._D2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._D2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property D1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._D1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._D1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property EstensioneText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._EstensioneText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._EstensioneText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property IconPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._IconPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._IconPict = WithEventsValue
            End Set
        End Property

        Friend Overridable Property C2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._C2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._C2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property C1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._C1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._C1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property B2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._B2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._B2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property B1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._B1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._B1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property A2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._A2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._A2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NomeText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._NomeText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._NomeText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property A1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._A1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._A1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TabPage2 As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._TabPage2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._TabPage2 = WithEventsValue
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

        Friend Overridable Property Button3 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button3 Is Nothing) Then
                    RemoveHandler Me._Button3.Click, New EventHandler(AddressOf Me.Button3_Click)
                End If
                Me._Button3 = WithEventsValue
                If (Not Me._Button3 Is Nothing) Then
                    AddHandler Me._Button3.Click, New EventHandler(AddressOf Me.Button3_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Button4 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._Button4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MetaProp As PropertyGrid
            <DebuggerNonUserCode> _
            Get
                Return Me._MetaProp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PropertyGrid)
                Me._MetaProp = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SystemCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SystemCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._SystemCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ArchiveCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ArchiveCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ArchiveCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CompressoCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CompressoCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CompressoCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AttributesGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AttributesGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._AttributesGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property F2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._F2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._F2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property F1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._F1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._F1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property UsedSpaceLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._UsedSpaceLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._UsedSpaceLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property UsedSpaceProg As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._UsedSpaceProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._UsedSpaceProg = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel1 As TableLayoutPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._TableLayoutPanel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TableLayoutPanel)
                Me._TableLayoutPanel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property I1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._I1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._I1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property I2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._I2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._I2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property H1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._H1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._H1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property H2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._H2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._H2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property G1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._G1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._G1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property G2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._G2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._G2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PercentLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PercentLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PercentLab = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("TabControl1")> _
        Private _TabControl1 As TabControl
        <AccessedThroughProperty("TabPage1")> _
        Private _TabPage1 As TabPage
        <AccessedThroughProperty("NascostoChek")> _
        Private _NascostoChek As CheckBox
        <AccessedThroughProperty("SolaLetturaChek")> _
        Private _SolaLetturaChek As CheckBox
        <AccessedThroughProperty("E2Lab")> _
        Private _E2Lab As Label
        <AccessedThroughProperty("E1Lab")> _
        Private _E1Lab As Label
        <AccessedThroughProperty("D2Lab")> _
        Private _D2Lab As Label
        <AccessedThroughProperty("D1Lab")> _
        Private _D1Lab As Label
        <AccessedThroughProperty("EstensioneText")> _
        Private _EstensioneText As TextBox
        <AccessedThroughProperty("IconPict")> _
        Private _IconPict As PictureBox
        <AccessedThroughProperty("C2Lab")> _
        Private _C2Lab As Label
        <AccessedThroughProperty("C1Lab")> _
        Private _C1Lab As Label
        <AccessedThroughProperty("B2Lab")> _
        Private _B2Lab As Label
        <AccessedThroughProperty("B1Lab")> _
        Private _B1Lab As Label
        <AccessedThroughProperty("A2Lab")> _
        Private _A2Lab As Label
        <AccessedThroughProperty("NomeText")> _
        Private _NomeText As TextBox
        <AccessedThroughProperty("A1Lab")> _
        Private _A1Lab As Label
        <AccessedThroughProperty("TabPage2")> _
        Private _TabPage2 As TabPage
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("Button3")> _
        Private _Button3 As Button
        <AccessedThroughProperty("Button4")> _
        Private _Button4 As Button
        <AccessedThroughProperty("MetaProp")> _
        Private _MetaProp As PropertyGrid
        <AccessedThroughProperty("SystemCheck")> _
        Private _SystemCheck As CheckBox
        <AccessedThroughProperty("ArchiveCheck")> _
        Private _ArchiveCheck As CheckBox
        <AccessedThroughProperty("CompressoCheck")> _
        Private _CompressoCheck As CheckBox
        <AccessedThroughProperty("AttributesGroup")> _
        Private _AttributesGroup As GroupBox
        <AccessedThroughProperty("F2Lab")> _
        Private _F2Lab As Label
        <AccessedThroughProperty("F1Lab")> _
        Private _F1Lab As Label
        <AccessedThroughProperty("UsedSpaceLab")> _
        Private _UsedSpaceLab As Label
        <AccessedThroughProperty("UsedSpaceProg")> _
        Private _UsedSpaceProg As ProgressBar
        <AccessedThroughProperty("TableLayoutPanel1")> _
        Private _TableLayoutPanel1 As TableLayoutPanel
        <AccessedThroughProperty("I1Lab")> _
        Private _I1Lab As Label
        <AccessedThroughProperty("I2Lab")> _
        Private _I2Lab As Label
        <AccessedThroughProperty("H1Lab")> _
        Private _H1Lab As Label
        <AccessedThroughProperty("H2Lab")> _
        Private _H2Lab As Label
        <AccessedThroughProperty("G1Lab")> _
        Private _G1Lab As Label
        <AccessedThroughProperty("G2Lab")> _
        Private _G2Lab As Label
        <AccessedThroughProperty("PercentLab")> _
        Private _PercentLab As Label
        Private Path As String
        Private Mode As Byte
    End Class
End Namespace

