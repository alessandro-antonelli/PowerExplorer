Imports Microsoft.VisualBasic.CompilerServices
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
    Public Class IOSettings
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub ExportButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ImpExpProg.Value = 0
            Me.ExportBrowser.ShowDialog
            MyProject.Computer.FileSystem.CreateDirectory((Me.ExportBrowser.SelectedPath & "\Settings"))
            If Me.HistoryCheck.Checked Then
                MyProject.Computer.FileSystem.CopyFile((Application.StartupPath & "\Chronology.txt"), (Me.ExportBrowser.SelectedPath & "\Settings\Chronology.txt"))
                Me.ImpExpProg.Value = 1
            End If
            If Me.FavouritesCheck.Checked Then
                MyProject.Computer.FileSystem.CopyFile((Application.StartupPath & "\Favourites.txt"), (Me.ExportBrowser.SelectedPath & "\Settings\Favourites.txt"))
                Me.ImpExpProg.Value = 2
            End If
            If Me.SettingsCheck.Checked Then
                Dim writer As New StreamWriter((Me.ExportBrowser.SelectedPath & "\Settings\Settings.txt"))
                writer.Write(MySettingsProperty.Settings.Antivirus)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.AutoUpdate)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.DaysUpdate)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.Home)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.LastUpdate)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.PreviewAudio)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.PreviewHtml)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.PreviewImages)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.PreviewText)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.PreviewVideo)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.Updates)
                writer.Close
                Me.ImpExpProg.Value = 3
            End If
        End Sub

        Private Sub FavouritesCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExportButt.Enabled = True
            Me.ImportButt.Enabled = True
            If (Not Me.FavouritesCheck.Checked AndAlso (Not Me.SettingsCheck.Checked AndAlso Not Me.HistoryCheck.Checked)) Then
                Me.ExportButt.Enabled = False
                Me.ImportButt.Enabled = False
            End If
        End Sub

        Private Sub HistoryCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExportButt.Enabled = True
            Me.ImportButt.Enabled = True
            If (Not Me.HistoryCheck.Checked AndAlso (Not Me.SettingsCheck.Checked AndAlso Not Me.FavouritesCheck.Checked)) Then
                Me.ExportButt.Enabled = False
                Me.ImportButt.Enabled = False
            End If
        End Sub

        Private Sub ImportButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ImpExpProg.Value = 0
            Me.ImportBrowser.ShowDialog
            If Me.HistoryCheck.Checked Then
                If Not MyProject.Computer.FileSystem.FileExists((Me.ImportBrowser.SelectedPath & "\Chronology.txt")) Then
                    MessageBox.Show("Impossibile caricare la cronologia, il salvataggio è danneggiato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                    Return
                End If
                If (MessageBox.Show("La cronologia attuale andrà persa. Proseguire?", "Proseguire?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No) Then
                    Return
                End If
                If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Chronology.txt")) Then
                    MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Chronology.txt"))
                End If
                MyProject.Computer.FileSystem.CopyFile((Me.ImportBrowser.SelectedPath & "\Chronology.txt"), (Application.StartupPath & "\Chronology.txt"))
                Me.ImpExpProg.Value = 1
            End If
            If Me.FavouritesCheck.Checked Then
                If Not MyProject.Computer.FileSystem.FileExists((Me.ImportBrowser.SelectedPath & "\Favourites.txt")) Then
                    MessageBox.Show("Impossibile caricare i preferiti, il salvataggio è danneggiato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                    Return
                End If
                If (MessageBox.Show("I preferiti attualmente impostati andranno persi. Proseguire?", "Proseguire?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No) Then
                    Return
                End If
                If MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "\Favourites.txt")) Then
                    MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "\Favourites.txt"))
                End If
                MyProject.Computer.FileSystem.CopyFile((Me.ImportBrowser.SelectedPath & "\Favourites.txt"), (Application.StartupPath & "\Favourites.txt"))
                Me.ImpExpProg.Value = 2
            End If
            If Me.SettingsCheck.Checked Then
                If Not MyProject.Computer.FileSystem.FileExists((Me.ImportBrowser.SelectedPath & "\Settings.txt")) Then
                    MessageBox.Show("Impossibile caricare le impostazioni, il salvataggio è danneggiato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                Else
                    Dim reader As New StreamReader((Me.ImportBrowser.SelectedPath & "\Settings.txt"))
                    MySettingsProperty.Settings.Antivirus = reader.ReadLine
                    MySettingsProperty.Settings.AutoUpdate = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.DaysUpdate = Conversions.ToDecimal(reader.ReadLine)
                    MySettingsProperty.Settings.Home = reader.ReadLine
                    MySettingsProperty.Settings.LastUpdate = Conversions.ToDate(reader.ReadLine)
                    MySettingsProperty.Settings.PreviewAudio = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.PreviewHtml = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.PreviewImages = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.PreviewText = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.PreviewVideo = Conversions.ToBoolean(reader.ReadLine)
                    MySettingsProperty.Settings.Updates = Conversions.ToBoolean(reader.ReadLine)
                    reader.Close
                    Me.ImpExpProg.Value = 3
                End If
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.CancelButt = New Button
            Me.HistoryCheck = New CheckBox
            Me.SettingsCheck = New CheckBox
            Me.FavouritesCheck = New CheckBox
            Me.ItemsGroup = New GroupBox
            Me.ImportBrowser = New FolderBrowserDialog
            Me.ExportBrowser = New FolderBrowserDialog
            Me.ImportButt = New Button
            Me.ExportButt = New Button
            Me.ImpExpProg = New ProgressBar
            Me.ItemsGroup.SuspendLayout
            Me.SuspendLayout
            Dim point As New Point(&HB6, &HA3)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            Dim size As New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 1
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.HistoryCheck.AutoSize = True
            Me.HistoryCheck.Checked = True
            Me.HistoryCheck.CheckState = CheckState.Checked
            point = New Point(6, &H13)
            Me.HistoryCheck.Location = point
            Me.HistoryCheck.Name = "HistoryCheck"
            size = New Size(&H4C, &H11)
            Me.HistoryCheck.Size = size
            Me.HistoryCheck.TabIndex = 2
            Me.HistoryCheck.Text = "Cronologia"
            Me.HistoryCheck.UseVisualStyleBackColor = True
            Me.SettingsCheck.AutoSize = True
            Me.SettingsCheck.Checked = True
            Me.SettingsCheck.CheckState = CheckState.Checked
            point = New Point(6, &H2A)
            Me.SettingsCheck.Location = point
            Me.SettingsCheck.Name = "SettingsCheck"
            size = New Size(&H54, &H11)
            Me.SettingsCheck.Size = size
            Me.SettingsCheck.TabIndex = 3
            Me.SettingsCheck.Text = "Impostazioni"
            Me.SettingsCheck.UseVisualStyleBackColor = True
            Me.FavouritesCheck.AutoSize = True
            Me.FavouritesCheck.Checked = True
            Me.FavouritesCheck.CheckState = CheckState.Checked
            point = New Point(&H5D, &H13)
            Me.FavouritesCheck.Location = point
            Me.FavouritesCheck.Name = "FavouritesCheck"
            size = New Size(&H3D, &H11)
            Me.FavouritesCheck.Size = size
            Me.FavouritesCheck.TabIndex = 4
            Me.FavouritesCheck.Text = "Preferiti"
            Me.FavouritesCheck.UseVisualStyleBackColor = True
            Me.ItemsGroup.Controls.Add(Me.HistoryCheck)
            Me.ItemsGroup.Controls.Add(Me.SettingsCheck)
            Me.ItemsGroup.Controls.Add(Me.FavouritesCheck)
            point = New Point(12, 12)
            Me.ItemsGroup.Location = point
            Me.ItemsGroup.Name = "ItemsGroup"
            size = New Size(&HF5, &H44)
            Me.ItemsGroup.Size = size
            Me.ItemsGroup.TabIndex = 6
            Me.ItemsGroup.TabStop = False
            Me.ItemsGroup.Text = "Seleziona gli elementi da importare / esportare:"
            Me.ImportBrowser.Description = "Seleziona la cartella dove sono salvate le impostazioni"
            Me.ExportBrowser.Description = "Seleziona la cartella dove vuoi esportare le impostazioni"
            point = New Point(12, &HA3)
            Me.ImportButt.Location = point
            Me.ImportButt.Name = "ImportButt"
            size = New Size(&H4B, &H17)
            Me.ImportButt.Size = size
            Me.ImportButt.TabIndex = 8
            Me.ImportButt.Text = "&Importa"
            Me.ImportButt.UseVisualStyleBackColor = True
            point = New Point(&H5D, &HA3)
            Me.ExportButt.Location = point
            Me.ExportButt.Name = "ExportButt"
            size = New Size(&H4B, &H17)
            Me.ExportButt.Size = size
            Me.ExportButt.TabIndex = 9
            Me.ExportButt.Text = "&Esporta"
            Me.ExportButt.UseVisualStyleBackColor = True
            Me.ImpExpProg.Anchor = (AnchorStyles.Right Or AnchorStyles.Left)
            point = New Point(12, &H89)
            Me.ImpExpProg.Location = point
            Me.ImpExpProg.Maximum = 3
            Me.ImpExpProg.Name = "ImpExpProg"
            size = New Size(&HF5, 20)
            Me.ImpExpProg.Size = size
            Me.ImpExpProg.Step = 1
            Me.ImpExpProg.Style = ProgressBarStyle.Continuous
            Me.ImpExpProg.TabIndex = 10
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H10D, &HC6)
            Me.ClientSize = size
            Me.Controls.Add(Me.ImpExpProg)
            Me.Controls.Add(Me.ExportButt)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.ImportButt)
            Me.Controls.Add(Me.ItemsGroup)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "IOSettings"
            Me.ShowIcon = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Importa / esporta impostazioni"
            Me.ItemsGroup.ResumeLayout(False)
            Me.ItemsGroup.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Private Sub SettingsCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ExportButt.Enabled = True
            Me.ImportButt.Enabled = True
            If (Not Me.SettingsCheck.Checked AndAlso (Not Me.FavouritesCheck.Checked AndAlso Not Me.HistoryCheck.Checked)) Then
                Me.ExportButt.Enabled = False
                Me.ImportButt.Enabled = False
            End If
        End Sub


        ' Properties
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

        Friend Overridable Property HistoryCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._HistoryCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._HistoryCheck Is Nothing) Then
                    RemoveHandler Me._HistoryCheck.CheckedChanged, New EventHandler(AddressOf Me.HistoryCheck_CheckedChanged)
                End If
                Me._HistoryCheck = WithEventsValue
                If (Not Me._HistoryCheck Is Nothing) Then
                    AddHandler Me._HistoryCheck.CheckedChanged, New EventHandler(AddressOf Me.HistoryCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property SettingsCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SettingsCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._SettingsCheck Is Nothing) Then
                    RemoveHandler Me._SettingsCheck.CheckedChanged, New EventHandler(AddressOf Me.SettingsCheck_CheckedChanged)
                End If
                Me._SettingsCheck = WithEventsValue
                If (Not Me._SettingsCheck Is Nothing) Then
                    AddHandler Me._SettingsCheck.CheckedChanged, New EventHandler(AddressOf Me.SettingsCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property FavouritesCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._FavouritesCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._FavouritesCheck Is Nothing) Then
                    RemoveHandler Me._FavouritesCheck.CheckedChanged, New EventHandler(AddressOf Me.FavouritesCheck_CheckedChanged)
                End If
                Me._FavouritesCheck = WithEventsValue
                If (Not Me._FavouritesCheck Is Nothing) Then
                    AddHandler Me._FavouritesCheck.CheckedChanged, New EventHandler(AddressOf Me.FavouritesCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property ItemsGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ItemsGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._ItemsGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImportBrowser As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportBrowser
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._ImportBrowser = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExportBrowser As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ExportBrowser
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._ExportBrowser = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImportButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ImportButt Is Nothing) Then
                    RemoveHandler Me._ImportButt.Click, New EventHandler(AddressOf Me.ImportButt_Click)
                End If
                Me._ImportButt = WithEventsValue
                If (Not Me._ImportButt Is Nothing) Then
                    AddHandler Me._ImportButt.Click, New EventHandler(AddressOf Me.ImportButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ExportButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ExportButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ExportButt Is Nothing) Then
                    RemoveHandler Me._ExportButt.Click, New EventHandler(AddressOf Me.ExportButt_Click)
                End If
                Me._ExportButt = WithEventsValue
                If (Not Me._ExportButt Is Nothing) Then
                    AddHandler Me._ExportButt.Click, New EventHandler(AddressOf Me.ExportButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImpExpProg As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._ImpExpProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._ImpExpProg = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("HistoryCheck")> _
        Private _HistoryCheck As CheckBox
        <AccessedThroughProperty("SettingsCheck")> _
        Private _SettingsCheck As CheckBox
        <AccessedThroughProperty("FavouritesCheck")> _
        Private _FavouritesCheck As CheckBox
        <AccessedThroughProperty("ItemsGroup")> _
        Private _ItemsGroup As GroupBox
        <AccessedThroughProperty("ImportBrowser")> _
        Private _ImportBrowser As FolderBrowserDialog
        <AccessedThroughProperty("ExportBrowser")> _
        Private _ExportBrowser As FolderBrowserDialog
        <AccessedThroughProperty("ImportButt")> _
        Private _ImportButt As Button
        <AccessedThroughProperty("ExportButt")> _
        Private _ExportButt As Button
        <AccessedThroughProperty("ImpExpProg")> _
        Private _ImpExpProg As ProgressBar
    End Class
End Namespace

