Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Explorer
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Power_Explorer.My
    <GeneratedCode("MyTemplate", "8.0.0.0"), StandardModule, HideModuleName> _
    Friend NotInheritable Class MyProject
        ' Properties
        <HelpKeyword("My.Computer")> _
        Friend Shared ReadOnly Property Computer As MyComputer
            <DebuggerHidden> _
            Get
                Return MyProject.m_ComputerObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Application")> _
        Friend Shared ReadOnly Property Application As MyApplication
            <DebuggerHidden> _
            Get
                Return MyProject.m_AppObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.User")> _
        Friend Shared ReadOnly Property User As User
            <DebuggerHidden> _
            Get
                Return MyProject.m_UserObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Forms")> _
        Friend Shared ReadOnly Property Forms As MyForms
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyFormsObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.WebServices")> _
        Friend Shared ReadOnly Property WebServices As MyWebServices
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyWebServicesObjectProvider.GetInstance
            End Get
        End Property


        ' Fields
        Private Shared ReadOnly m_ComputerObjectProvider As ThreadSafeObjectProvider(Of MyComputer) = New ThreadSafeObjectProvider(Of MyComputer)
        Private Shared ReadOnly m_AppObjectProvider As ThreadSafeObjectProvider(Of MyApplication) = New ThreadSafeObjectProvider(Of MyApplication)
        Private Shared ReadOnly m_UserObjectProvider As ThreadSafeObjectProvider(Of User) = New ThreadSafeObjectProvider(Of User)
        Private Shared m_MyFormsObjectProvider As ThreadSafeObjectProvider(Of MyForms) = New ThreadSafeObjectProvider(Of MyForms)
        Private Shared ReadOnly m_MyWebServicesObjectProvider As ThreadSafeObjectProvider(Of MyWebServices) = New ThreadSafeObjectProvider(Of MyWebServices)

        ' Nested Types
        <MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class MyForms
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As { Form, New })(ByVal Instance As T) As T
                Dim local As T
                Dim exception As TargetInvocationException
                Dim flag1 As Boolean
                If ((Not Instance Is Nothing) AndAlso Not Instance.IsDisposed) Then
                    Return Instance
                End If
                If (MyForms.m_FormBeingCreated Is Nothing) Then
                    MyForms.m_FormBeingCreated = New Hashtable
                ElseIf MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
                    Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(0  - 1) {}))
                End If
                MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
                Try 
                    local = Activator.CreateInstance(Of T)
                Catch exception1 As TargetInvocationException When ((Function() // NOTE: To create compilable code, filter at IL offset 0074 was represented using lambda expression.
                    ProjectData.SetProjectError(exception = exception1)
                    flag1 = Not Object.ReferenceEquals(exception.InnerException, Nothing)
                    Return DirectCast(flag1, T)
                End Function)())
                    Dim args As String() = New String() { exception.InnerException.Message }
                    Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException)
                Finally
                    MyForms.m_FormBeingCreated.Remove(GetType(T))
                End Try
                Return local
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
                instance.Dispose
                Dim local As T = CType(Nothing, T)
                instance = local
            End Sub

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(o)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Friend Function [GetType]() As Type
                Return GetType(MyForms)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function


            ' Properties
            Public Property About As About
                <DebuggerNonUserCode> _
                Get
                    Me.m_About = MyForms.Create__Instance__(Of About)(Me.m_About)
                    Return Me.m_About
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As About)
                    If Not Object.ReferenceEquals(Value, Me.m_About) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of About)(Me.m_About)
                    End If
                End Set
            End Property

            Public Property Compress As Compress
                <DebuggerNonUserCode> _
                Get
                    Me.m_Compress = MyForms.Create__Instance__(Of Compress)(Me.m_Compress)
                    Return Me.m_Compress
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Compress)
                    If Not Object.ReferenceEquals(Value, Me.m_Compress) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Compress)(Me.m_Compress)
                    End If
                End Set
            End Property

            Public Property CopyForm As CopyForm
                <DebuggerNonUserCode> _
                Get
                    Me.m_CopyForm = MyForms.Create__Instance__(Of CopyForm)(Me.m_CopyForm)
                    Return Me.m_CopyForm
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As CopyForm)
                    If Not Object.ReferenceEquals(Value, Me.m_CopyForm) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of CopyForm)(Me.m_CopyForm)
                    End If
                End Set
            End Property

            Public Property Delete As Delete
                <DebuggerNonUserCode> _
                Get
                    Me.m_Delete = MyForms.Create__Instance__(Of Delete)(Me.m_Delete)
                    Return Me.m_Delete
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Delete)
                    If Not Object.ReferenceEquals(Value, Me.m_Delete) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Delete)(Me.m_Delete)
                    End If
                End Set
            End Property

            Public Property Favourites As Favourites
                <DebuggerNonUserCode> _
                Get
                    Me.m_Favourites = MyForms.Create__Instance__(Of Favourites)(Me.m_Favourites)
                    Return Me.m_Favourites
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Favourites)
                    If Not Object.ReferenceEquals(Value, Me.m_Favourites) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Favourites)(Me.m_Favourites)
                    End If
                End Set
            End Property

            Public Property History As History
                <DebuggerNonUserCode> _
                Get
                    Me.m_History = MyForms.Create__Instance__(Of History)(Me.m_History)
                    Return Me.m_History
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As History)
                    If Not Object.ReferenceEquals(Value, Me.m_History) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of History)(Me.m_History)
                    End If
                End Set
            End Property

            Public Property IOSettings As IOSettings
                <DebuggerNonUserCode> _
                Get
                    Me.m_IOSettings = MyForms.Create__Instance__(Of IOSettings)(Me.m_IOSettings)
                    Return Me.m_IOSettings
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As IOSettings)
                    If Not Object.ReferenceEquals(Value, Me.m_IOSettings) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of IOSettings)(Me.m_IOSettings)
                    End If
                End Set
            End Property

            Public Property Main As Main
                <DebuggerNonUserCode> _
                Get
                    Me.m_Main = MyForms.Create__Instance__(Of Main)(Me.m_Main)
                    Return Me.m_Main
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Main)
                    If Not Object.ReferenceEquals(Value, Me.m_Main) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Main)(Me.m_Main)
                    End If
                End Set
            End Property

            Public Property MultiFile As MultiFile
                <DebuggerNonUserCode> _
                Get
                    Me.m_MultiFile = MyForms.Create__Instance__(Of MultiFile)(Me.m_MultiFile)
                    Return Me.m_MultiFile
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As MultiFile)
                    If Not Object.ReferenceEquals(Value, Me.m_MultiFile) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of MultiFile)(Me.m_MultiFile)
                    End If
                End Set
            End Property

            Public Property NewFile As NewFile
                <DebuggerNonUserCode> _
                Get
                    Me.m_NewFile = MyForms.Create__Instance__(Of NewFile)(Me.m_NewFile)
                    Return Me.m_NewFile
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As NewFile)
                    If Not Object.ReferenceEquals(Value, Me.m_NewFile) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of NewFile)(Me.m_NewFile)
                    End If
                End Set
            End Property

            Public Property Proprietes As Proprietes
                <DebuggerNonUserCode> _
                Get
                    Me.m_Proprietes = MyForms.Create__Instance__(Of Proprietes)(Me.m_Proprietes)
                    Return Me.m_Proprietes
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Proprietes)
                    If Not Object.ReferenceEquals(Value, Me.m_Proprietes) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Proprietes)(Me.m_Proprietes)
                    End If
                End Set
            End Property

            Public Property Rename As Rename
                <DebuggerNonUserCode> _
                Get
                    Me.m_Rename = MyForms.Create__Instance__(Of Rename)(Me.m_Rename)
                    Return Me.m_Rename
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Rename)
                    If Not Object.ReferenceEquals(Value, Me.m_Rename) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Rename)(Me.m_Rename)
                    End If
                End Set
            End Property

            Public Property Settings As Settings
                <DebuggerNonUserCode> _
                Get
                    Me.m_Settings = MyForms.Create__Instance__(Of Settings)(Me.m_Settings)
                    Return Me.m_Settings
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Settings)
                    If Not Object.ReferenceEquals(Value, Me.m_Settings) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Settings)(Me.m_Settings)
                    End If
                End Set
            End Property

            Public Property SplashScreen As SplashScreen
                <DebuggerNonUserCode> _
                Get
                    Me.m_SplashScreen = MyForms.Create__Instance__(Of SplashScreen)(Me.m_SplashScreen)
                    Return Me.m_SplashScreen
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As SplashScreen)
                    If Not Object.ReferenceEquals(Value, Me.m_SplashScreen) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of SplashScreen)(Me.m_SplashScreen)
                    End If
                End Set
            End Property

            Public Property Updates As Updates
                <DebuggerNonUserCode> _
                Get
                    Me.m_Updates = MyForms.Create__Instance__(Of Updates)(Me.m_Updates)
                    Return Me.m_Updates
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Updates)
                    If Not Object.ReferenceEquals(Value, Me.m_Updates) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Updates)(Me.m_Updates)
                    End If
                End Set
            End Property


            ' Fields
            Public m_About As About
            Public m_Compress As Compress
            Public m_CopyForm As CopyForm
            Public m_Delete As Delete
            Public m_Favourites As Favourites
            Public m_History As History
            Public m_IOSettings As IOSettings
            Public m_Main As Main
            Public m_MultiFile As MultiFile
            Public m_NewFile As NewFile
            Public m_Proprietes As Proprietes
            Public m_Rename As Rename
            Public m_Settings As Settings
            Public m_SplashScreen As SplashScreen
            Public m_Updates As Updates
            <ThreadStatic> _
            Private Shared m_FormBeingCreated As Hashtable
        End Class

        <MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class MyWebServices
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As New)(ByVal instance As T) As T
                Return If((Not instance Is Nothing), instance, Activator.CreateInstance(Of T))
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
                Dim local As T = CType(Nothing, T)
                instance = local
            End Sub

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(o)
            End Function

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Friend Function [GetType]() As Type
                Return GetType(MyWebServices)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function

        End Class

        <ComVisible(False), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
            ' Properties
            Friend ReadOnly Property GetInstance As T
                <DebuggerHidden> _
                Get
                    If (ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing) Then
                        ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)
                    End If
                    Return ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
                End Get
            End Property


            ' Fields
            <ThreadStatic, CompilerGenerated> _
            Private Shared m_ThreadStaticValue As T
        End Class
    End Class
End Namespace

