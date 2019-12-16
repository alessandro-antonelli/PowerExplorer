Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace Power_Explorer.My
    <GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0"), CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced)> _
    Friend NotInheritable Class MySettings
        Inherits ApplicationSettingsBase
        ' Methods
        <DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)> _
        Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Application.SaveMySettingsOnExit Then
                MySettingsProperty.Settings.Save
            End If
        End Sub


        ' Properties
        Public Shared ReadOnly Property [Default] As MySettings
            Get
                If Not MySettings.addedHandler Then
                    Dim addedHandlerLockObject As Object = MySettings.addedHandlerLockObject
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject)
                    SyncLock addedHandlerLockObject
                        If Not MySettings.addedHandler Then
                            AddHandler MyProject.Application.Shutdown, New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
                            MySettings.addedHandler = True
                        End If
                    End SyncLock
                End If
                Return MySettings.defaultInstance
            End Get
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("Computer"), UserScopedSetting> _
        Public Property Home As String
            Get
                Return Conversions.ToString(Me("Home"))
            End Get
            Set(ByVal Value As String)
                Me("Home") = Value
            End Set
        End Property

        <DefaultSettingValue("True"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property PreviewImages As Boolean
            Get
                Return Conversions.ToBoolean(Me("PreviewImages"))
            End Get
            Set(ByVal Value As Boolean)
                Me("PreviewImages") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("True"), DebuggerNonUserCode> _
        Public Property PreviewText As Boolean
            Get
                Return Conversions.ToBoolean(Me("PreviewText"))
            End Get
            Set(ByVal Value As Boolean)
                Me("PreviewText") = Value
            End Set
        End Property

        <DefaultSettingValue("True"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property PreviewHtml As Boolean
            Get
                Return Conversions.ToBoolean(Me("PreviewHtml"))
            End Get
            Set(ByVal Value As Boolean)
                Me("PreviewHtml") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("True")> _
        Public Property PreviewAudio As Boolean
            Get
                Return Conversions.ToBoolean(Me("PreviewAudio"))
            End Get
            Set(ByVal Value As Boolean)
                Me("PreviewAudio") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("True")> _
        Public Property PreviewVideo As Boolean
            Get
                Return Conversions.ToBoolean(Me("PreviewVideo"))
            End Get
            Set(ByVal Value As Boolean)
                Me("PreviewVideo") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("False")> _
        Public Property Updates As Boolean
            Get
                Return Conversions.ToBoolean(Me("Updates"))
            End Get
            Set(ByVal Value As Boolean)
                Me("Updates") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("3")> _
        Public Property HardDiskIcon As Short
            Get
                Return Conversions.ToShort(Me("HardDiskIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("HardDiskIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("2"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property CDIcon As Short
            Get
                Return Conversions.ToShort(Me("CDIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("CDIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("0"), DebuggerNonUserCode> _
        Public Property USBIcon As Short
            Get
                Return Conversions.ToShort(Me("USBIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("USBIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("4"), DebuggerNonUserCode> _
        Public Property NetworkIcon As Short
            Get
                Return Conversions.ToShort(Me("NetworkIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("NetworkIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("1"), DebuggerNonUserCode> _
        Public Property UnknownDriveIcon As Short
            Get
                Return Conversions.ToShort(Me("UnknownDriveIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("UnknownDriveIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("5"), DebuggerNonUserCode> _
        Public Property FolderIcon As Short
            Get
                Return Conversions.ToShort(Me("FolderIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("FolderIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("26"), DebuggerNonUserCode> _
        Public Property DocIcon As Short
            Get
                Return Conversions.ToShort(Me("DocIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("DocIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("24")> _
        Public Property UnkonwnFileIcon As Short
            Get
                Return Conversions.ToShort(Me("UnkonwnFileIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("UnkonwnFileIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("23"), DebuggerNonUserCode> _
        Public Property TxtIcon As Short
            Get
                Return Conversions.ToShort(Me("TxtIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("TxtIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("13"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property PdfIcon As Short
            Get
                Return Conversions.ToShort(Me("PdfIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("PdfIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("12"), DebuggerNonUserCode> _
        Public Property MidiIcon As Short
            Get
                Return Conversions.ToShort(Me("MidiIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("MidiIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("27"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property ExeIcon As Short
            Get
                Return Conversions.ToShort(Me("ExeIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("ExeIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("22"), UserScopedSetting> _
        Public Property ArchiveIcon As Short
            Get
                Return Conversions.ToShort(Me("ArchiveIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("ArchiveIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("15")> _
        Public Property SoundIcon As Short
            Get
                Return Conversions.ToShort(Me("SoundIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("SoundIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("7"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property ImageIcon As Short
            Get
                Return Conversions.ToShort(Me("ImageIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("ImageIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("6")> _
        Public Property HtmlIcon As Short
            Get
                Return Conversions.ToShort(Me("HtmlIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("HtmlIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("25"), UserScopedSetting> _
        Public Property VideoIcon As Short
            Get
                Return Conversions.ToShort(Me("VideoIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("VideoIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("9")> _
        Public Property RtfIcon As Short
            Get
                Return Conversions.ToShort(Me("RtfIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("RtfIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("28"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property LinkIcon As Short
            Get
                Return Conversions.ToShort(Me("LinkIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("LinkIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("8"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property WavIcon As Short
            Get
                Return Conversions.ToShort(Me("WavIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("WavIcon") = Value
            End Set
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("14"), UserScopedSetting> _
        Public Property BatIcon As Short
            Get
                Return Conversions.ToShort(Me("BatIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("BatIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("20"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property PhpIcon As Short
            Get
                Return Conversions.ToShort(Me("PhpIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("PhpIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("16"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property CIcon As Short
            Get
                Return Conversions.ToShort(Me("CIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("CIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("17")> _
        Public Property CppIcon As Short
            Get
                Return Conversions.ToShort(Me("CppIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("CppIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("18"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property CssIcon As Short
            Get
                Return Conversions.ToShort(Me("CssIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("CssIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue("19"), DebuggerNonUserCode> _
        Public Property JavaIcon As Short
            Get
                Return Conversions.ToShort(Me("JavaIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("JavaIcon") = Value
            End Set
        End Property

        <DefaultSettingValue("29"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property FolderFullIcon As Short
            Get
                Return Conversions.ToShort(Me("FolderFullIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("FolderFullIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DefaultSettingValue(""), DebuggerNonUserCode> _
        Public Property Antivirus As String
            Get
                Return Conversions.ToString(Me("Antivirus"))
            End Get
            Set(ByVal Value As String)
                Me("Antivirus") = Value
            End Set
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("44"), UserScopedSetting> _
        Public Property FloppyIcon As Short
            Get
                Return Conversions.ToShort(Me("FloppyIcon"))
            End Get
            Set(ByVal Value As Short)
                Me("FloppyIcon") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("2008-12-01")> _
        Public Property LastUpdate As DateTime
            Get
                Return Conversions.ToDate(Me("LastUpdate"))
            End Get
            Set(ByVal Value As DateTime)
                Me("LastUpdate") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("True")> _
        Public Property AutoUpdate As Boolean
            Get
                Return Conversions.ToBoolean(Me("AutoUpdate"))
            End Get
            Set(ByVal Value As Boolean)
                Me("AutoUpdate") = Value
            End Set
        End Property

        <DefaultSettingValue("7"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property DaysUpdate As Decimal
            Get
                Return Conversions.ToDecimal(Me("DaysUpdate"))
            End Get
            Set(ByVal Value As Decimal)
                Me("DaysUpdate") = Value
            End Set
        End Property


        ' Fields
        Private Shared defaultInstance As MySettings = DirectCast(SettingsBase.Synchronized(New MySettings), MySettings)
        Private Shared addedHandler As Boolean
        Private Shared addedHandlerLockObject As Object = New Object
    End Class
End Namespace

