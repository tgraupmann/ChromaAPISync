Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace ChromaSDK

    Public Class Keyboard
    
        REM //! Definitions of keys.
        Public Enum RZKEY
            RZKEY_ESC = &H1                 REM /*!< Esc (VK_ESCAPE) */
            RZKEY_F1 = &H3                  REM /*!< F1 (VK_F1) */
            RZKEY_F2 = &H4                  REM /*!< F2 (VK_F2) */
            RZKEY_F3 = &H5                  REM /*!< F3 (VK_F3) */
            RZKEY_F4 = &H6                  REM /*!< F4 (VK_F4) */
            RZKEY_F5 = &H7                  REM /*!< F5 (VK_F5) */
            RZKEY_F6 = &H8                  REM /*!< F6 (VK_F6) */
            RZKEY_F7 = &H9                  REM /*!< F7 (VK_F7) */
            RZKEY_F8 = &HA                  REM /*!< F8 (VK_F8) */
            RZKEY_F9 = &HB                  REM /*!< F9 (VK_F9) */
            RZKEY_F10 = &HC                 REM /*!< F10 (VK_F10) */
            RZKEY_F11 = &HD                 REM /*!< F11 (VK_F11) */
            RZKEY_F12 = &HE                 REM /*!< F12 (VK_F12) */
            RZKEY_1 = &H102                   REM /*!< 1 (VK_1) */
            RZKEY_2 = &H103                   REM /*!< 2 (VK_2) */
            RZKEY_3 = &H104                   REM /*!< 3 (VK_3) */
            RZKEY_4 = &H105                   REM /*!< 4 (VK_4) */
            RZKEY_5 = &H106                   REM /*!< 5 (VK_5) */
            RZKEY_6 = &H107                   REM /*!< 6 (VK_6) */
            RZKEY_7 = &H108                   REM /*!< 7 (VK_7) */
            RZKEY_8 = &H109                   REM /*!< 8 (VK_8) */
            RZKEY_9 = &H10A                   REM /*!< 9 (VK_9) */
            RZKEY_0 = &H10B                   REM /*!< 0 (VK_0) */
            RZKEY_A = &H302                   REM /*!< A (VK_A) */
            RZKEY_B = &H407                   REM /*!< B (VK_B) */
            RZKEY_C = &H405                   REM /*!< C (VK_C) */
            RZKEY_D = &H304                   REM /*!< D (VK_D) */
            RZKEY_E = &H204                   REM /*!< E (VK_E) */
            RZKEY_F = &H305                   REM /*!< F (VK_F) */
            RZKEY_G = &H306                   REM /*!< G (VK_G) */
            RZKEY_H = &H307                   REM /*!< H (VK_H) */
            RZKEY_I = &H209                   REM /*!< I (VK_I) */
            RZKEY_J = &H308                   REM /*!< J (VK_J) */
            RZKEY_K = &H309                   REM /*!< K (VK_K) */
            RZKEY_L = &H30A                   REM /*!< L (VK_L) */
            RZKEY_M = &H409                   REM /*!< M (VK_M) */
            RZKEY_N = &H408                   REM /*!< N (VK_N) */
            RZKEY_O = &H20A                   REM /*!< O (VK_O) */
            RZKEY_P = &H20B                   REM /*!< P (VK_P) */
            RZKEY_Q = &H202                   REM /*!< Q (VK_Q) */
            RZKEY_R = &H205                   REM /*!< R (VK_R) */
            RZKEY_S = &H303                   REM /*!< S (VK_S) */
            RZKEY_T = &H206                   REM /*!< T (VK_T) */
            RZKEY_U = &H208                   REM /*!< U (VK_U) */
            RZKEY_V = &H406                   REM /*!< V (VK_V) */
            RZKEY_W = &H203                   REM /*!< W (VK_W) */
            RZKEY_X = &H404                   REM /*!< X (VK_X) */
            RZKEY_Y = &H207                   REM /*!< Y (VK_Y) */
            RZKEY_Z = &H403                   REM /*!< Z (VK_Z) */
            RZKEY_NUMLOCK = &H112             REM /*!< Numlock (VK_NUMLOCK) */
            RZKEY_NUMPAD0 = &H513             REM /*!< Numpad 0 (VK_NUMPAD0) */
            RZKEY_NUMPAD1 = &H412             REM /*!< Numpad 1 (VK_NUMPAD1) */
            RZKEY_NUMPAD2 = &H413             REM /*!< Numpad 2 (VK_NUMPAD2) */
            RZKEY_NUMPAD3 = &H414             REM /*!< Numpad 3 (VK_NUMPAD3) */
            RZKEY_NUMPAD4 = &H312             REM /*!< Numpad 4 (VK_NUMPAD4) */
            RZKEY_NUMPAD5 = &H313             REM /*!< Numpad 5 (VK_NUMPAD5) */
            RZKEY_NUMPAD6 = &H314             REM /*!< Numpad 6 (VK_NUMPAD6) */
            RZKEY_NUMPAD7 = &H212             REM /*!< Numpad 7 (VK_NUMPAD7) */
            RZKEY_NUMPAD8 = &H213             REM /*!< Numpad 8 (VK_NUMPAD8) */
            RZKEY_NUMPAD9 = &H214             REM /*!< Numpad 9 (VK_ NUMPAD9*/
            RZKEY_NUMPAD_DIVIDE = &H113       REM /*!< Divide (VK_DIVIDE) */
            RZKEY_NUMPAD_MULTIPLY = &H114     REM /*!< Multiply (VK_MULTIPLY) */
            RZKEY_NUMPAD_SUBTRACT = &H115     REM /*!< Subtract (VK_SUBTRACT) */
            RZKEY_NUMPAD_ADD = &H215          REM /*!< Add (VK_ADD) */
            RZKEY_NUMPAD_ENTER = &H415        REM /*!< Enter (VK_RETURN - Extended) */
            RZKEY_NUMPAD_DECIMAL = &H514      REM /*!< Decimal (VK_DECIMAL) */
            RZKEY_PRINTSCREEN = &HF         REM /*!< Print Screen (VK_PRINT) */
            RZKEY_SCROLL = &H10              REM /*!< Scroll Lock (VK_SCROLL) */
            RZKEY_PAUSE = &H11               REM /*!< Pause (VK_PAUSE) */
            RZKEY_INSERT = &H10F              REM /*!< Insert (VK_INSERT) */
            RZKEY_HOME = &H110                REM /*!< Home (VK_HOME) */
            RZKEY_PAGEUP = &H111              REM /*!< Page Up (VK_PRIOR) */
            RZKEY_DELETE = &H20F              REM /*!< Delete (VK_DELETE) */
            RZKEY_END = &H210                 REM /*!< End (VK_END) */
            RZKEY_PAGEDOWN = &H211            REM /*!< Page Down (VK_NEXT) */
            RZKEY_UP = &H410                  REM /*!< Up (VK_UP) */
            RZKEY_LEFT = &H50F                REM /*!< Left (VK_LEFT) */
            RZKEY_DOWN = &H510                REM /*!< Down (VK_DOWN) */
            RZKEY_RIGHT = &H511               REM /*!< Right (VK_RIGHT) */
            RZKEY_TAB = &H201                 REM /*!< Tab (VK_TAB) */
            RZKEY_CAPSLOCK = &H301            REM /*!< Caps Lock(VK_CAPITAL) */
            RZKEY_BACKSPACE = &H10E           REM /*!< Backspace (VK_BACK) */
            RZKEY_ENTER = &H30E               REM /*!< Enter (VK_RETURN) */
            RZKEY_LCTRL = &H501               REM /*!< Left Control(VK_LCONTROL) */
            RZKEY_LWIN = &H502                REM /*!< Left Window (VK_LWIN) */
            RZKEY_LALT = &H503                REM /*!< Left Alt (VK_LMENU) */
            RZKEY_SPACE = &H507               REM /*!< Spacebar (VK_SPACE) */
            RZKEY_RALT = &H50B                REM /*!< Right Alt (VK_RMENU) */
            RZKEY_FN = &H50C                  REM /*!< Function key. */
            RZKEY_RMENU = &H50D               REM /*!< Right Menu (VK_APPS) */
            RZKEY_RCTRL = &H50E               REM /*!< Right Control (VK_RCONTROL) */
            RZKEY_LSHIFT = &H401              REM /*!< Left Shift (VK_LSHIFT) */
            RZKEY_RSHIFT = &H40E              REM /*!< Right Shift (VK_RSHIFT) */
            RZKEY_MACRO1 = &H100              REM /*!< Macro Key 1 */
            RZKEY_MACRO2 = &H200              REM /*!< Macro Key 2 */
            RZKEY_MACRO3 = &H300              REM /*!< Macro Key 3 */
            RZKEY_MACRO4 = &H400              REM /*!< Macro Key 4 */
            RZKEY_MACRO5 = &H500              REM /*!< Macro Key 5 */
            RZKEY_OEM_1 = &H101               REM /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
            RZKEY_OEM_2 = &H10C               REM /*!< -- (minus) (VK_OEM_MINUS) */
            RZKEY_OEM_3 = &H10D               REM /*!< = (equal) (VK_OEM_PLUS) */
            RZKEY_OEM_4 = &H20C               REM /*!< [ (left sqaure bracket) (VK_OEM_4) */
            RZKEY_OEM_5 = &H20D               REM /*!< ] (right square bracket) (VK_OEM_6) */
            RZKEY_OEM_6 = &H20E               REM /*!< \ (backslash) (VK_OEM_5) */
            RZKEY_OEM_7 = &H30B               REM /*!< ; (semi-colon) (VK_OEM_1) */
            RZKEY_OEM_8 = &H30C               REM /*!< ' (apostrophe) (VK_OEM_7) */
            RZKEY_OEM_9 = &H40A               REM /*!< , (comma) (VK_OEM_COMMA) */
            RZKEY_OEM_10 = &H40B              REM /*!< . (period) (VK_OEM_PERIOD) */
            RZKEY_OEM_11 = &H40C              REM /*!< / (forward slash) (VK_OEM_2) */
            RZKEY_EUR_1 = &H30D               REM /*!< "#" (VK_OEM_5) */
            RZKEY_EUR_2 = &H402               REM /*!< \ (VK_OEM_102) */
            RZKEY_JPN_1 = &H15                REM /*!< ¥ (&HFF) */
            RZKEY_JPN_2 = &H40D               REM /*!< \ (&HC1) */
            RZKEY_JPN_3 = &H504               REM /*!< 無変換 (VK_OEM_PA1) */
            RZKEY_JPN_4 = &H509               REM /*!< 変換 (&HFF) */
            RZKEY_JPN_5 = &H50A               REM /*!< ひらがな/カタカナ (&HFF) */
            RZKEY_KOR_1 = &H15                REM /*!< | (&HFF) */
            RZKEY_KOR_2 = &H30D               REM /*!< (VK_OEM_5) */
            RZKEY_KOR_3 = &H402               REM /*!< (VK_OEM_102) */
            RZKEY_KOR_4 = &H40D               REM /*!< (&HC1) */
            RZKEY_KOR_5 = &H504               REM /*!< (VK_OEM_PA1) */
            RZKEY_KOR_6 = &H509               REM /*!< 한/영 (&HFF) */
            RZKEY_KOR_7 = &H50A               REM /*!< (&HFF) */
            RZKEY_INVALID = &HFFFF            REM /*!< Invalid keys. */
        End Enum

        REM //! Definition of LEDs.
        Public Enum RZLED
            RZLED_LOGO = &HE0014                 REM /*!< Razer logo */
        End Enum
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
	Public Structure APPINFOTYPE
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Title As String REM //TCHAR Title[256];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 1024)>
		Public Description As String REM //TCHAR Description[1024];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Author_Name As String REM //TCHAR Name[256];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Author_Contact As String REM //TCHAR Contact[256];

		Public SupportedDevice As UInt32 REM //DWORD SupportedDevice;

		Public Category As UInt32 REM //DWORD Category;
	End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure FChromaSDKGuid
        Public Data As Guid
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DEVICE_INFO_TYPE
        Public DeviceType As Integer
        Public Connected As UInteger
    End Structure

    Public Enum EFFECT_TYPE
        CHROMA_NONE = 0            REM //!< No effect.
        CHROMA_WAVE                REM //!< Wave effect (This effect type has deprecated and should not be used).
        CHROMA_SPECTRUMCYCLING     REM //!< Spectrum cycling effect (This effect type has deprecated and should not be used).
        CHROMA_BREATHING           REM //!< Breathing effect (This effect type has deprecated and should not be used).
        CHROMA_BLINKING            REM //!< Blinking effect (This effect type has deprecated and should not be used).
        CHROMA_REACTIVE            REM //!< Reactive effect (This effect type has deprecated and should not be used).
        CHROMA_STATIC              REM //!< Static effect.
        CHROMA_CUSTOM              REM //!< Custom effect. For mice, please see Mouse::CHROMA_CUSTOM2.
        CHROMA_RESERVED            REM //!< Reserved
        CHROMA_INVALID             REM //!< Invalid effect.
    End Enum

    Namespace Stream

        Public Enum StreamStatusType
            READY = 0                  REM // ready for commands
            AUTHORIZING = 1            REM // the session is being authorized
            BROADCASTING = 2           REM // the session is being broadcast
            WATCHING = 3               REM // A stream is being watched
            NOT_AUTHORIZED = 4         REM // The session is not authorized
            BROADCAST_DUPLICATE = 5    REM // The session has duplicate broadcasters
            SERVICE_OFFLINE = 6        REM // The service is offline
        End Enum

        Public Class _Default
            Const LENGTH_SHORTCODE As UInteger = 6
            Const LENGTH_STREAM_ID As UInteger = 48
            Const LENGTH_STREAM_KEY As UInteger = 48
            Const LENGTH_STREAM_FOCUS As UInteger = 48

            Public Shared Function GetDefaultString(length As UInteger) As String
                Dim result As String = String.Empty
                For i As UInteger = 0 To length Step 1
                    result += " "
                Next
                Return result
            End Function

            Public Shared ReadOnly Shortcode As String = GetDefaultString(LENGTH_SHORTCODE)
            Public Shared ReadOnly StreamId As String = GetDefaultString(LENGTH_STREAM_ID)
            Public Shared ReadOnly StreamKey As String = GetDefaultString(LENGTH_STREAM_KEY)
            Public Shared ReadOnly StreamFocus As String = GetDefaultString(LENGTH_STREAM_FOCUS)
        End Class
    End Namespace

    Module ChromaAnimationAPI

#If X64 Then
        Const DLL_NAME As String = "CChromaEditorLibrary64"
#Else
        Const DLL_NAME As String = "CChromaEditorLibrary"
#End If

#Region "Data Structures"

        Public Enum DeviceType
            Invalid = -1
            DE_1D = 0
            DE_2D = 1
            MAX = 2
        End Enum

        Public Enum Device
            Invalid = -1
            ChromaLink = 0
            Headset = 1
            Keyboard = 2
            Keypad = 3
            Mouse = 4
            Mousepad = 5
            MAX = 6
        End Enum

        Public Enum Device1D
            Invalid = -1
            ChromaLink = 0
            Headset = 1
            Mousepad = 2
            MAX = 3
        End Enum

        Public Enum Device2D
            Invalid = -1
            Keyboard = 0
            Keypad = 1
            Mouse = 2
            MAX = 3
        End Enum

        Public Class FChromaSDKDeviceFrameIndex
            REM // Index corresponds to EChromaSDKDeviceEnum
            Public _mFrameIndex() As Integer = New Integer() {0, 0, 0, 0, 0, 0}

            Public Function FChromaSDKDeviceFrameIndex()
                _mFrameIndex(Device.ChromaLink) = 0
                _mFrameIndex(Device.Headset) = 0
                _mFrameIndex(Device.Keyboard) = 0
                _mFrameIndex(Device.Keypad) = 0
                _mFrameIndex(Device.Mouse) = 0
                _mFrameIndex(Device.Mousepad) = 0
                Return Nothing
            End Function
        End Class

		Public Enum EChromaSDKSceneBlend
			SB_None
			SB_Invert
			SB_Threshold
			SB_Lerp
		End Enum

		Public Enum EChromaSDKSceneMode
			SM_Replace
			SM_Max
			SM_Min
			SM_Average
			SM_Multiply
			SM_Add
			SM_Subtract
		End Enum

        Public Class FChromaSDKSceneEffect
            Public _mAnimation As String = ""
            Public _mState As Boolean = False
            Public _mPrimaryColor As Integer = 0
            Public _mSecondaryColor As Integer = 0
            Public _mSpeed As Integer = 1
            Public _mBlend As EChromaSDKSceneBlend = EChromaSDKSceneBlend.SB_None
            Public _mMode As EChromaSDKSceneMode = EChromaSDKSceneMode.SM_Replace

            Public _mFrameIndex As FChromaSDKDeviceFrameIndex = New FChromaSDKDeviceFrameIndex()
        End Class

		Public Class FChromaSDKScene
			Public _mEffects As List(Of FChromaSDKSceneEffect) = New List(Of FChromaSDKSceneEffect)
		End Class

#End Region

#Region "Helpers (handle path conversions)"

    REM /// <summary>
    REM /// Helper to convert path string to IntPtr
    REM /// </summary>
    REM /// <param name="path"></param>
    REM /// <returns></returns>
    Private Function GetPathIntPtr(path As String) As IntPtr
        If (String.IsNullOrEmpty(path)) Then
            Return IntPtr.Zero
        End If
        Dim fi As FileInfo = New FileInfo(path)
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(fi.FullName + ControlChars.NullChar)
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to Ascii path string to IntPtr
    REM /// </summary>
    REM /// <param name="str"></param>
    REM /// <returns></returns>
    Private Function GetAsciiIntPtr(str As String) As IntPtr
        If (String.IsNullOrEmpty(str)) Then
            Return IntPtr.Zero
        End If
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(str + ControlChars.NullChar)
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to Unicode path string to IntPtr
    REM /// </summary>
    REM /// <param name="str"></param>
    REM /// <returns></returns>
    Private Function GetUnicodeIntPtr(str As String) As IntPtr
        If (String.IsNullOrEmpty(str)) Then
            Return IntPtr.Zero
        End If
        Dim array As Byte() = UnicodeEncoding.Unicode.GetBytes(str + ControlChars.NullChar)
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to recycle the IntPtr
    REM /// </summary>
    REM /// <param name="lpData"></param>
    Private Function FreeIntPtr(lpData As IntPtr)
        If (lpData <> IntPtr.Zero) Then
            Marshal.FreeHGlobal(lpData)
        End If
        Return Nothing
    End Function

    Public Function UninitAPI() As Integer
        UnloadLibrarySDK()
        UnloadLibraryStreamingPlugin()
        Return 0
    End Function

#End Region

		#Region "Public API Methods"
		REM /// <summary>
		REM /// Return the sum of colors
		REM /// </summary>
		Public Function AddColor(color1 As Integer, color2 As Integer) As Integer
			Dim result As Integer = PluginAddColor(color1, color2)
			Return result
		End Function

		REM /// <summary>
		REM /// Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		REM /// The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		REM /// The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		REM /// the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		REM /// size should be `MAX ROW` times `MAX COLUMN`. Returns the animation id upon 
		REM /// success. Returns negative one upon failure.
		REM /// </summary>
		Public Function AddFrame(animationId As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
			Dim result As Integer = PluginAddFrame(animationId, duration, colors, length)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for frame id, reference 
		REM /// source and target by id.
		REM /// </summary>
		Public Function AddNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginAddNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames, reference 
		REM /// source and target by id.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginAddNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames, reference 
		REM /// source and target by name.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames starting 
		REM /// at offset for the length of the source, reference source and target by 
		REM /// id.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginAddNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames starting 
		REM /// at offset for the length of the source, reference source and target by 
		REM /// name.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for frame id, reference 
		REM /// source and target by name.
		REM /// </summary>
		Public Function AddNonZeroAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for the source frame 
		REM /// and target offset frame, reference source and target by id.
		REM /// </summary>
		Public Function AddNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginAddNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for the source frame 
		REM /// and target offset frame, reference source and target by name.
		REM /// </summary>
		Public Function AddNonZeroAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames, 
		REM /// reference source and target by id.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginAddNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames, 
		REM /// reference source and target by name.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames 
		REM /// starting at offset for the length of the source, reference source and target 
		REM /// by id.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginAddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames 
		REM /// starting at offset for the length of the source, reference source and target 
		REM /// by name.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Add source color to target where target color is not blank from the source 
		REM /// frame to the target offset frame, reference source and target by id.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginAddNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Add source color to target where target color is not blank from the source 
		REM /// frame to the target offset frame, reference source and target by name. 
		REM ///
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAddNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AddNonZeroTargetAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAddNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Append all source frames to the target animation, reference source and target 
		REM /// by id.
		REM /// </summary>
		Public Function AppendAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginAppendAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Append all source frames to the target animation, reference source and target 
		REM /// by name.
		REM /// </summary>
		Public Function AppendAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginAppendAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function AppendAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginAppendAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginClearAll` will issue a `CLEAR` effect for all devices.
		REM /// </summary>
		Public Function ClearAll()
			PluginClearAll()
			Return Nothing
		End Function

		REM /// <summary>
		REM /// `PluginClearAnimationType` will issue a `CLEAR` effect for the given device. 
		REM ///
		REM /// </summary>
		Public Function ClearAnimationType(deviceType As Integer, device As Integer)
			PluginClearAnimationType(deviceType, device)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// `PluginCloseAll` closes all open animations so they can be reloaded from 
		REM /// disk. The set of animations will be stopped if playing.
		REM /// </summary>
		Public Function CloseAll()
			PluginCloseAll()
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Closes the `Chroma` animation to free up resources referenced by id. Returns 
		REM /// the animation id upon success. Returns negative one upon failure. This 
		REM /// might be used while authoring effects if there was a change necessitating 
		REM /// re-opening the animation. The animation id can no longer be used once closed. 
		REM ///
		REM /// </summary>
		Public Function CloseAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginCloseAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CloseAnimationD(animationId As Double) As Double
			Dim result As Double = PluginCloseAnimationD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Closes the `Chroma` animation referenced by name so that the animation can 
		REM /// be reloaded from disk.
		REM /// </summary>
		Public Function CloseAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginCloseAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CloseAnimationNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginCloseAnimationNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginCloseComposite` closes a set of animations so they can be reloaded 
		REM /// from disk. The set of animations will be stopped if playing.
		REM /// </summary>
		Public Function CloseComposite(name As String)
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			PluginCloseComposite(lp_Name)
			FreeIntPtr(lp_Name)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CloseCompositeD(name As String) As Double
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Double = PluginCloseCompositeD(lp_Name)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// </summary>
		Public Function CopyAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginCopyAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// </summary>
		Public Function CopyAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation to named target animation in memory. If target animation 
		REM /// exists, close first. Source is referenced by id.
		REM /// </summary>
		Public Function CopyAnimation(sourceAnimationId As Integer, targetAnimation As String) As Integer
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Integer = PluginCopyAnimation(sourceAnimationId, lp_TargetAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation to named target animation in memory. If target animation 
		REM /// exists, close first. Source is referenced by name.
		REM /// </summary>
		Public Function CopyAnimationName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyAnimationName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyAnimationNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyAnimationNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by id.
		REM /// </summary>
		Public Function CopyBlueChannelAllFrames(animationId As Integer, redIntensity As Single, greenIntensity As Single)
			PluginCopyBlueChannelAllFrames(animationId, redIntensity, greenIntensity)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by name.
		REM /// </summary>
		Public Function CopyBlueChannelAllFramesName(path As String, redIntensity As Single, greenIntensity As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginCopyBlueChannelAllFramesName(lp_Path, redIntensity, greenIntensity)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyBlueChannelAllFramesNameD(path As String, redIntensity As Double, greenIntensity As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginCopyBlueChannelAllFramesNameD(lp_Path, redIntensity, greenIntensity)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by id.
		REM /// </summary>
		Public Function CopyGreenChannelAllFrames(animationId As Integer, redIntensity As Single, blueIntensity As Single)
			PluginCopyGreenChannelAllFrames(animationId, redIntensity, blueIntensity)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by name.
		REM /// </summary>
		Public Function CopyGreenChannelAllFramesName(path As String, redIntensity As Single, blueIntensity As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginCopyGreenChannelAllFramesName(lp_Path, redIntensity, blueIntensity)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyGreenChannelAllFramesNameD(path As String, redIntensity As Double, blueIntensity As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginCopyGreenChannelAllFramesNameD(lp_Path, redIntensity, blueIntensity)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame. Reference the source and target by id.
		REM /// </summary>
		Public Function CopyKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer)
			PluginCopyKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames. Reference the source and target by id.
		REM /// </summary>
		Public Function CopyKeyColorAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer, rzkey As Integer)
			PluginCopyKeyColorAllFrames(sourceAnimationId, targetAnimationId, rzkey)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames. Reference the source and target by name.
		REM /// </summary>
		Public Function CopyKeyColorAllFramesName(sourceAnimation As String, targetAnimation As String, rzkey As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeyColorAllFramesName(lp_SourceAnimation, lp_TargetAnimation, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyKeyColorAllFramesNameD(sourceAnimation As String, targetAnimation As String, rzkey As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyKeyColorAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames, starting at the offset for the length of the source animation. 
		REM /// Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyKeyColorAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, rzkey As Integer, offset As Integer)
			PluginCopyKeyColorAllFramesOffset(sourceAnimationId, targetAnimationId, rzkey, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames, starting at the offset for the length of the source animation. 
		REM /// Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyKeyColorAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, rzkey As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeyColorAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, rzkey, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyKeyColorAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, rzkey As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyKeyColorAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, rzkey, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame.
		REM /// </summary>
		Public Function CopyKeyColorName(sourceAnimation As String, targetAnimation As String, frameId As Integer, rzkey As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyKeyColorNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, rzkey As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for the given frame. Reference the source and target by 
		REM /// id.
		REM /// </summary>
		Public Function CopyKeysColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, keys As Integer(), size As Integer)
			PluginCopyKeysColor(sourceAnimationId, targetAnimationId, frameId, keys, size)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for all frames. Reference the source and target by id. 
		REM ///
		REM /// </summary>
		Public Function CopyKeysColorAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer, keys As Integer(), size As Integer)
			PluginCopyKeysColorAllFrames(sourceAnimationId, targetAnimationId, keys, size)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for all frames. Reference the source and target by name. 
		REM ///
		REM /// </summary>
		Public Function CopyKeysColorAllFramesName(sourceAnimation As String, targetAnimation As String, keys As Integer(), size As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeysColorAllFramesName(lp_SourceAnimation, lp_TargetAnimation, keys, size)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for the given frame. Reference the source and target by 
		REM /// name.
		REM /// </summary>
		Public Function CopyKeysColorName(sourceAnimation As String, targetAnimation As String, frameId As Integer, keys As Integer(), size As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeysColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, keys, size)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation from the source frame to the target frame. Reference the 
		REM /// source and target by id.
		REM /// </summary>
		Public Function CopyKeysColorOffset(sourceAnimationId As Integer, targetAnimationId As Integer, sourceFrameId As Integer, targetFrameId As Integer, keys As Integer(), size As Integer)
			PluginCopyKeysColorOffset(sourceAnimationId, targetAnimationId, sourceFrameId, targetFrameId, keys, size)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation from the source frame to the target frame. Reference the 
		REM /// source and target by name.
		REM /// </summary>
		Public Function CopyKeysColorOffsetName(sourceAnimation As String, targetAnimation As String, sourceFrameId As Integer, targetFrameId As Integer, keys As Integer(), size As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyKeysColorOffsetName(lp_SourceAnimation, lp_TargetAnimation, sourceFrameId, targetFrameId, keys, size)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// </summary>
		Public Function CopyNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginCopyNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames. Reference source and target by id.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginCopyNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames. Reference source and target by name.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames starting at the offset for the length of the source animation. The 
		REM /// source and target are referenced by id.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginCopyNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames starting at the offset for the length of the source animation. The 
		REM /// source and target are referenced by name.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysNameD(sourceAnimation As String, targetAnimation As String, frameId As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroAllKeysNameD(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation from 
		REM /// the source frame to the target offset frame. Source and target are referenced 
		REM /// by id.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginCopyNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation from 
		REM /// the source frame to the target offset frame. Source and target are referenced 
		REM /// by name.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame where color is not zero.
		REM /// </summary>
		Public Function CopyNonZeroKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer)
			PluginCopyNonZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame where color is not zero.
		REM /// </summary>
		Public Function CopyNonZeroKeyColorName(sourceAnimation As String, targetAnimation As String, frameId As Integer, rzkey As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroKeyColorNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, rzkey As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified frame. Source and target 
		REM /// are referenced by id.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginCopyNonZeroTargetAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by id.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginCopyNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginCopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames starting at the target offset 
		REM /// for the length of the source animation. Source and target animations are 
		REM /// referenced by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified frame. The source and target 
		REM /// are referenced by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroTargetAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysNameD(sourceAnimation As String, targetAnimation As String, frameId As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroTargetAllKeysNameD(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified source frame and target offset 
		REM /// frame. The source and target are referenced by id.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginCopyNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified source frame and target offset 
		REM /// frame. The source and target are referenced by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroTargetAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is zero for all frames. Source and target are referenced 
		REM /// by id.
		REM /// </summary>
		Public Function CopyNonZeroTargetZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginCopyNonZeroTargetZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is zero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// </summary>
		Public Function CopyNonZeroTargetZeroAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyNonZeroTargetZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyNonZeroTargetZeroAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy red channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by id.
		REM /// </summary>
		Public Function CopyRedChannelAllFrames(animationId As Integer, greenIntensity As Single, blueIntensity As Single)
			PluginCopyRedChannelAllFrames(animationId, greenIntensity, blueIntensity)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by name.
		REM /// </summary>
		Public Function CopyRedChannelAllFramesName(path As String, greenIntensity As Single, blueIntensity As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginCopyRedChannelAllFramesName(lp_Path, greenIntensity, blueIntensity)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyRedChannelAllFramesNameD(path As String, greenIntensity As Double, blueIntensity As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginCopyRedChannelAllFramesNameD(lp_Path, greenIntensity, blueIntensity)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame. 
		REM /// Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginCopyZeroAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames. 
		REM /// Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginCopyZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames. 
		REM /// Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames 
		REM /// starting at the target offset for the length of the source animation. Source 
		REM /// and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginCopyZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames 
		REM /// starting at the target offset for the length of the source animation. Source 
		REM /// and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyZeroAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame. 
		REM /// Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame 
		REM /// id starting at the target offset for the length of the source animation. 
		REM /// Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginCopyZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame 
		REM /// id starting at the target offset for the length of the source animation. 
		REM /// Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero key color from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer)
			PluginCopyZeroKeyColor(sourceAnimationId, targetAnimationId, frameId, rzkey)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy zero key color from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroKeyColorName(sourceAnimation As String, targetAnimation As String, frameId As Integer, rzkey As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroKeyColorName(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyZeroKeyColorNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, rzkey As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyZeroKeyColorNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, rzkey)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for the frame. Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroTargetAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginCopyZeroTargetAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for all frames. Source and target are referenced by id.
		REM /// </summary>
		Public Function CopyZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginCopyZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for all frames. Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroTargetAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function CopyZeroTargetAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginCopyZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for the frame. Source and target are referenced by name.
		REM /// </summary>
		Public Function CopyZeroTargetAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginCopyZeroTargetAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateChromaLinkEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateChromaLinkEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateEffect(deviceId As Guid, effect As EFFECT_TYPE, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateEffect(deviceId, effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateHeadsetEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateHeadsetEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateKeyboardEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateKeyboardEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateKeypadEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateKeypadEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateMouseEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateMouseEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreCreateMousepadEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
			Dim result As Integer = PluginCoreCreateMousepadEffect(effect, pParam, pEffectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreDeleteEffect(effectId As Guid) As Integer
			Dim result As Integer = PluginCoreDeleteEffect(effectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreInit() As Integer
			Dim result As Integer = PluginCoreInit()
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreInitSDK(ByRef appInfo As ChromaSDK.APPINFOTYPE) As Integer
			Dim result As Integer = PluginCoreInitSDK(appInfo)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreQueryDevice(deviceId As Guid, ByRef deviceInfo As DEVICE_INFO_TYPE) As Integer
			Dim result As Integer = PluginCoreQueryDevice(deviceId, deviceInfo)
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreSetEffect(effectId As Guid) As Integer
			Dim result As Integer = PluginCoreSetEffect(effectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Begin broadcasting Chroma RGB data using the stored stream key as the endpoint. 
		REM /// Intended for Cloud Gaming Platforms,  restore the streaming key when the 
		REM /// game instance is launched to continue streaming.  streamId is a null terminated 
		REM /// string  streamKey is a null terminated string  StreamGetStatus() should 
		REM /// return the READY status to use this method.
		REM /// </summary>
		Public Function CoreStreamBroadcast(streamId As String, streamKey As String) As Boolean
			Dim str_StreamId As String = streamId
			Dim lp_StreamId As IntPtr = GetAsciiIntPtr(str_StreamId)
			Dim str_StreamKey As String = streamKey
			Dim lp_StreamKey As IntPtr = GetAsciiIntPtr(str_StreamKey)
			Dim result As Boolean = PluginCoreStreamBroadcast(lp_StreamId, lp_StreamKey)
			FreeIntPtr(lp_StreamId)
			FreeIntPtr(lp_StreamKey)
			Return result
		End Function

		REM /// <summary>
		REM /// End broadcasting Chroma RGB data.  StreamGetStatus() should return the BROADCASTING 
		REM /// status to use this method.
		REM /// </summary>
		Public Function CoreStreamBroadcastEnd() As Boolean
			Dim result As Boolean = PluginCoreStreamBroadcastEnd()
			Return result
		End Function

		REM /// <summary>
		REM /// shortcode: Pass the address of a preallocated character buffer to get the 
		REM /// streaming auth code. The buffer should have a minimum length of 6.  length: 
		REM /// Length will return as zero if the streaming auth code could not be obtained. 
		REM /// If length is greater than zero, it will be the length of the returned streaming 
		REM /// auth code.  Once you have the shortcode, it should be shown to the user 
		REM /// so they can associate the stream with their Razer ID  StreamGetStatus() 
		REM /// should return the READY status before invoking this method. platform: is 
		REM /// the null terminated string that identifies the source of the stream: { 
		REM /// GEFORCE_NOW, LUNA, STADIA, GAME_PASS } title: is the null terminated string 
		REM /// that identifies the application or game.
		REM /// </summary>
		Public Function CoreStreamGetAuthShortcode(ByRef shortcode As String, ByRef length As byte, platform As String, title As String)
			Dim str_Shortcode As String = shortcode
			Dim lp_Shortcode as IntPtr = GetAsciiIntPtr(str_Shortcode)
			Dim str_Platform As String = platform
			Dim lp_Platform As IntPtr = GetUnicodeIntPtr(str_Platform)
			Dim str_Title As String = title
			Dim lp_Title As IntPtr = GetUnicodeIntPtr(str_Title)
			PluginCoreStreamGetAuthShortcode(lp_Shortcode, length, lp_Platform, lp_Title)
			If (lp_Shortcode <> IntPtr.Zero) Then
				shortcode = Marshal.PtrToStringAnsi(lp_Shortcode)
			End If
			FreeIntPtr(lp_Shortcode)
			FreeIntPtr(lp_Platform)
			FreeIntPtr(lp_Title)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// focus: Pass the address of a preallocated character buffer to get the stream 
		REM /// focus. The buffer should have a length of 48  length: Length will return 
		REM /// as zero if the stream focus could not be obtained. If length is greater 
		REM /// than zero, it will be the length of the returned stream focus.
		REM /// </summary>
		Public Function CoreStreamGetFocus(ByRef focus As String, ByRef length As byte) As Boolean
			Dim str_Focus As String = focus
			Dim lp_Focus as IntPtr = GetAsciiIntPtr(str_Focus)
			Dim result As Boolean = PluginCoreStreamGetFocus(lp_Focus, length)
			If (lp_Focus <> IntPtr.Zero) Then
				focus = Marshal.PtrToStringAnsi(lp_Focus)
			End If
			FreeIntPtr(lp_Focus)
			Return result
		End Function

		REM /// <summary>
		REM /// Intended for Cloud Gaming Platforms, store the stream id to persist in user 
		REM /// preferences to continue streaming if the game is suspended or closed. shortcode: 
		REM /// The shortcode is a null terminated string. Use the shortcode that authorized 
		REM /// the stream to obtain the stream id.  streamId should be a preallocated 
		REM /// buffer to get the stream key. The buffer should have a length of 48.  length: 
		REM /// Length will return zero if the key could not be obtained. If the length 
		REM /// is greater than zero, it will be the length of the returned streaming id. 
		REM /// Retrieve the stream id after authorizing the shortcode. The authorization 
		REM /// window will expire in 5 minutes. Be sure to save the stream key before 
		REM /// the window expires. StreamGetStatus() should return the READY status to 
		REM /// use this method.
		REM /// </summary>
		Public Function CoreStreamGetId(shortcode As String, ByRef streamId As String, ByRef length As byte)
			Dim str_Shortcode As String = shortcode
			Dim lp_Shortcode As IntPtr = GetAsciiIntPtr(str_Shortcode)
			Dim str_StreamId As String = streamId
			Dim lp_StreamId as IntPtr = GetAsciiIntPtr(str_StreamId)
			PluginCoreStreamGetId(lp_Shortcode, lp_StreamId, length)
			FreeIntPtr(lp_Shortcode)
			If (lp_StreamId <> IntPtr.Zero) Then
				streamId = Marshal.PtrToStringAnsi(lp_StreamId)
			End If
			FreeIntPtr(lp_StreamId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Intended for Cloud Gaming Platforms, store the streaming key to persist 
		REM /// in user preferences to continue streaming if the game is suspended or closed. 
		REM /// shortcode: The shortcode is a null terminated string. Use the shortcode 
		REM /// that authorized the stream to obtain the stream key.  If the status is 
		REM /// in the BROADCASTING or WATCHING state, passing a NULL shortcode will return 
		REM /// the active streamId.  streamKey should be a preallocated buffer to get 
		REM /// the stream key. The buffer should have a length of 48.  length: Length 
		REM /// will return zero if the key could not be obtained. If the length is greater 
		REM /// than zero, it will be the length of the returned streaming key.  Retrieve 
		REM /// the stream key after authorizing the shortcode. The authorization window 
		REM /// will expire in 5 minutes. Be sure to save the stream key before the window 
		REM /// expires.  StreamGetStatus() should return the READY status to use this 
		REM /// method.
		REM /// </summary>
		Public Function CoreStreamGetKey(shortcode As String, ByRef streamKey As String, ByRef length As byte)
			Dim str_Shortcode As String = shortcode
			Dim lp_Shortcode As IntPtr = GetAsciiIntPtr(str_Shortcode)
			Dim str_StreamKey As String = streamKey
			Dim lp_StreamKey as IntPtr = GetAsciiIntPtr(str_StreamKey)
			PluginCoreStreamGetKey(lp_Shortcode, lp_StreamKey, length)
			FreeIntPtr(lp_Shortcode)
			If (lp_StreamKey <> IntPtr.Zero) Then
				streamKey = Marshal.PtrToStringAnsi(lp_StreamKey)
			End If
			FreeIntPtr(lp_StreamKey)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Returns StreamStatus, the current status of the service
		REM /// </summary>
		Public Function CoreStreamGetStatus() As ChromaSDK.Stream.StreamStatusType
			Dim result As ChromaSDK.Stream.StreamStatusType = PluginCoreStreamGetStatus()
			Return result
		End Function

		REM /// <summary>
		REM /// Convert StreamStatusType to a printable string
		REM /// </summary>
		Public Function CoreStreamGetStatusString(status As ChromaSDK.Stream.StreamStatusType) As String
			Dim result As String = Marshal.PtrToStringAnsi(PluginCoreStreamGetStatusString(status))
			Return result
		End Function

		REM /// <summary>
		REM /// This prevents the stream id and stream key from being obtained through the 
		REM /// shortcode. This closes the auth window.  shortcode is a null terminated 
		REM /// string.  StreamGetStatus() should return the READY status to use this method. 
		REM /// returns success when shortcode has been released
		REM /// </summary>
		Public Function CoreStreamReleaseShortcode(shortcode As String) As Boolean
			Dim str_Shortcode As String = shortcode
			Dim lp_Shortcode As IntPtr = GetAsciiIntPtr(str_Shortcode)
			Dim result As Boolean = PluginCoreStreamReleaseShortcode(lp_Shortcode)
			FreeIntPtr(lp_Shortcode)
			Return result
		End Function

		REM /// <summary>
		REM /// The focus is a null terminated string. Set the focus identifer for the application 
		REM /// designated to automatically change the streaming state.  Returns true on 
		REM /// success.
		REM /// </summary>
		Public Function CoreStreamSetFocus(focus As String) As Boolean
			Dim str_Focus As String = focus
			Dim lp_Focus As IntPtr = GetAsciiIntPtr(str_Focus)
			Dim result As Boolean = PluginCoreStreamSetFocus(lp_Focus)
			FreeIntPtr(lp_Focus)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns true if the Chroma streaming is supported. If false is returned, 
		REM /// avoid calling stream methods.
		REM /// </summary>
		Public Function CoreStreamSupportsStreaming() As Boolean
			Dim result As Boolean = PluginCoreStreamSupportsStreaming()
			Return result
		End Function

		REM /// <summary>
		REM /// Begin watching the Chroma RGB data using streamID parameter.  streamId is 
		REM /// a null terminated string.  StreamGetStatus() should return the READY status 
		REM /// to use this method.
		REM /// </summary>
		Public Function CoreStreamWatch(streamId As String, timestamp As ulong) As Boolean
			Dim str_StreamId As String = streamId
			Dim lp_StreamId As IntPtr = GetAsciiIntPtr(str_StreamId)
			Dim result As Boolean = PluginCoreStreamWatch(lp_StreamId, timestamp)
			FreeIntPtr(lp_StreamId)
			Return result
		End Function

		REM /// <summary>
		REM /// End watching Chroma RGB data stream.  StreamGetStatus() should return the 
		REM /// WATCHING status to use this method.
		REM /// </summary>
		Public Function CoreStreamWatchEnd() As Boolean
			Dim result As Boolean = PluginCoreStreamWatchEnd()
			Return result
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// </summary>
		Public Function CoreUnInit() As Integer
			Dim result As Integer = PluginCoreUnInit()
			Return result
		End Function

		REM /// <summary>
		REM /// Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		REM /// uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		REM /// `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		REM /// to the `deviceType`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		REM /// at the given path. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function CreateAnimation(path As String, deviceType As Integer, device As Integer) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginCreateAnimation(lp_Path, deviceType, device)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		REM /// parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		REM /// uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		REM /// respective to the `deviceType`. Returns the animation id upon success. 
		REM /// Returns negative one upon failure. Returns the animation id upon success. 
		REM /// Returns negative one upon failure.
		REM /// </summary>
		Public Function CreateAnimationInMemory(deviceType As Integer, device As Integer) As Integer
			Dim result As Integer = PluginCreateAnimationInMemory(deviceType, device)
			Return result
		End Function

		REM /// <summary>
		REM /// Create a device specific effect.
		REM /// </summary>
		Public Function CreateEffect(deviceId As Guid, effect As EFFECT_TYPE, colors As Integer(), size As Integer, ByRef effectId As FChromaSDKGuid) As Integer
			Dim result As Integer = PluginCreateEffect(deviceId, effect, colors, size, effectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Delete an effect given the effect id.
		REM /// </summary>
		Public Function DeleteEffect(effectId As Guid) As Integer
			Dim result As Integer = PluginDeleteEffect(effectId)
			Return result
		End Function

		REM /// <summary>
		REM /// Duplicate the first animation frame so that the animation length matches 
		REM /// the frame count. Animation is referenced by id.
		REM /// </summary>
		Public Function DuplicateFirstFrame(animationId As Integer, frameCount As Integer)
			PluginDuplicateFirstFrame(animationId, frameCount)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Duplicate the first animation frame so that the animation length matches 
		REM /// the frame count. Animation is referenced by name.
		REM /// </summary>
		Public Function DuplicateFirstFrameName(path As String, frameCount As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginDuplicateFirstFrameName(lp_Path, frameCount)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function DuplicateFirstFrameNameD(path As String, frameCount As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginDuplicateFirstFrameNameD(lp_Path, frameCount)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Duplicate all the frames of the animation to double the animation length. 
		REM /// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		REM /// The animation is referenced by id.
		REM /// </summary>
		Public Function DuplicateFrames(animationId As Integer)
			PluginDuplicateFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Duplicate all the frames of the animation to double the animation length. 
		REM /// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		REM /// The animation is referenced by name.
		REM /// </summary>
		Public Function DuplicateFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginDuplicateFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function DuplicateFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginDuplicateFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Duplicate all the animation frames in reverse so that the animation plays 
		REM /// forwards and backwards. Animation is referenced by id.
		REM /// </summary>
		Public Function DuplicateMirrorFrames(animationId As Integer)
			PluginDuplicateMirrorFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Duplicate all the animation frames in reverse so that the animation plays 
		REM /// forwards and backwards. Animation is referenced by name.
		REM /// </summary>
		Public Function DuplicateMirrorFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginDuplicateMirrorFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function DuplicateMirrorFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginDuplicateMirrorFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fade the animation to black starting at the fade frame index to the end 
		REM /// of the animation. Animation is referenced by id.
		REM /// </summary>
		Public Function FadeEndFrames(animationId As Integer, fade As Integer)
			PluginFadeEndFrames(animationId, fade)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fade the animation to black starting at the fade frame index to the end 
		REM /// of the animation. Animation is referenced by name.
		REM /// </summary>
		Public Function FadeEndFramesName(path As String, fade As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFadeEndFramesName(lp_Path, fade)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FadeEndFramesNameD(path As String, fade As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFadeEndFramesNameD(lp_Path, fade)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fade the animation from black to full color starting at 0 to the fade frame 
		REM /// index. Animation is referenced by id.
		REM /// </summary>
		Public Function FadeStartFrames(animationId As Integer, fade As Integer)
			PluginFadeStartFrames(animationId, fade)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fade the animation from black to full color starting at 0 to the fade frame 
		REM /// index. Animation is referenced by name.
		REM /// </summary>
		Public Function FadeStartFramesName(path As String, fade As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFadeStartFramesName(lp_Path, fade)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FadeStartFramesNameD(path As String, fade As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFadeStartFramesNameD(lp_Path, fade)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function FillColor(animationId As Integer, frameId As Integer, color As Integer)
			PluginFillColor(animationId, frameId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function FillColorAllFrames(animationId As Integer, color As Integer)
			PluginFillColorAllFrames(animationId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function FillColorAllFramesName(path As String, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillColorAllFramesName(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillColorAllFramesNameD(path As String, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillColorAllFramesNameD(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		REM /// for red, green, and blue parameters. Animation is referenced by id.
		REM /// </summary>
		Public Function FillColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillColorAllFramesRGB(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		REM /// for red, green, and blue parameters. Animation is referenced by name.
		REM /// </summary>
		Public Function FillColorAllFramesRGBName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillColorAllFramesRGBName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillColorAllFramesRGBNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillColorAllFramesRGBNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function FillColorName(path As String, frameId As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillColorName(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillColorNameD(path As String, frameId As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillColorNameD(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function FillColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillColorRGB(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function FillColorRGBName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillColorRGBName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillColorRGBNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillColorRGBNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Animation is referenced by id.
		REM /// </summary>
		Public Function FillNonZeroColor(animationId As Integer, frameId As Integer, color As Integer)
			PluginFillNonZeroColor(animationId, frameId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Animation is referenced by id.
		REM /// </summary>
		Public Function FillNonZeroColorAllFrames(animationId As Integer, color As Integer)
			PluginFillNonZeroColorAllFrames(animationId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Animation is referenced by name.
		REM /// </summary>
		Public Function FillNonZeroColorAllFramesName(path As String, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillNonZeroColorAllFramesName(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillNonZeroColorAllFramesNameD(path As String, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillNonZeroColorAllFramesNameD(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function FillNonZeroColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillNonZeroColorAllFramesRGB(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function FillNonZeroColorAllFramesRGBName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillNonZeroColorAllFramesRGBName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillNonZeroColorAllFramesRGBNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillNonZeroColorAllFramesRGBNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Animation is referenced by name.
		REM /// </summary>
		Public Function FillNonZeroColorName(path As String, frameId As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillNonZeroColorName(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillNonZeroColorNameD(path As String, frameId As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillNonZeroColorNameD(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function FillNonZeroColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillNonZeroColorRGB(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function FillNonZeroColorRGBName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillNonZeroColorRGBName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillNonZeroColorRGBNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillNonZeroColorRGBNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for the given frame. Animation is 
		REM /// referenced by id.
		REM /// </summary>
		Public Function FillRandomColors(animationId As Integer, frameId As Integer)
			PluginFillRandomColors(animationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for all frames. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function FillRandomColorsAllFrames(animationId As Integer)
			PluginFillRandomColorsAllFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for all frames. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function FillRandomColorsAllFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillRandomColorsAllFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillRandomColorsAllFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillRandomColorsAllFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for the specified frame. 
		REM /// Animation is referenced by id.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhite(animationId As Integer, frameId As Integer)
			PluginFillRandomColorsBlackAndWhite(animationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for all frames. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhiteAllFrames(animationId As Integer)
			PluginFillRandomColorsBlackAndWhiteAllFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for all frames. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhiteAllFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillRandomColorsBlackAndWhiteAllFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhiteAllFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillRandomColorsBlackAndWhiteAllFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for the specified frame. 
		REM /// Animation is referenced by name.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhiteName(path As String, frameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillRandomColorsBlackAndWhiteName(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillRandomColorsBlackAndWhiteNameD(path As String, frameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillRandomColorsBlackAndWhiteNameD(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for the given frame. Animation is 
		REM /// referenced by name.
		REM /// </summary>
		Public Function FillRandomColorsName(path As String, frameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillRandomColorsName(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillRandomColorsNameD(path As String, frameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillRandomColorsNameD(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColors(animationId As Integer, frameId As Integer, threshold As Integer, color As Integer)
			PluginFillThresholdColors(animationId, frameId, threshold, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColorsAllFrames(animationId As Integer, threshold As Integer, color As Integer)
			PluginFillThresholdColorsAllFrames(animationId, threshold, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsAllFramesName(path As String, threshold As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsAllFramesName(lp_Path, threshold, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsAllFramesNameD(path As String, threshold As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsAllFramesNameD(lp_Path, threshold, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColorsAllFramesRGB(animationId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillThresholdColorsAllFramesRGB(animationId, threshold, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsAllFramesRGBName(path As String, threshold As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsAllFramesRGBName(lp_Path, threshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsAllFramesRGBNameD(path As String, threshold As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsAllFramesRGBNameD(lp_Path, threshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill all frames with the min RGB color where the animation color is less 
		REM /// than the min threshold AND with the max RGB color where the animation is 
		REM /// more than the max threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxAllFramesRGB(animationId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			PluginFillThresholdColorsMinMaxAllFramesRGB(animationId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with the min RGB color where the animation color is less 
		REM /// than the min threshold AND with the max RGB color where the animation is 
		REM /// more than the max threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxAllFramesRGBName(path As String, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsMinMaxAllFramesRGBName(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxAllFramesRGBNameD(path As String, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsMinMaxAllFramesRGBNameD(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with the min RGB color where the animation color 
		REM /// is less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxRGB(animationId As Integer, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			PluginFillThresholdColorsMinMaxRGB(animationId, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with the min RGB color where the animation color 
		REM /// is less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxRGBName(path As String, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsMinMaxRGBName(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsMinMaxRGBNameD(path As String, frameId As Double, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsMinMaxRGBNameD(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsName(path As String, frameId As Integer, threshold As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsName(lp_Path, frameId, threshold, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsNameD(path As String, frameId As Double, threshold As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsNameD(lp_Path, frameId, threshold, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdColorsRGB(animationId As Integer, frameId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillThresholdColorsRGB(animationId, frameId, threshold, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdColorsRGBName(path As String, frameId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdColorsRGBName(lp_Path, frameId, threshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdColorsRGBNameD(path As String, frameId As Double, threshold As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdColorsRGBNameD(lp_Path, frameId, threshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdRGBColorsAllFramesRGB(animationId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillThresholdRGBColorsAllFramesRGB(animationId, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdRGBColorsAllFramesRGBName(path As String, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdRGBColorsAllFramesRGBName(lp_Path, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdRGBColorsAllFramesRGBNameD(path As String, redThreshold As Double, greenThreshold As Double, blueThreshold As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdRGBColorsAllFramesRGBNameD(lp_Path, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function FillThresholdRGBColorsRGB(animationId As Integer, frameId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillThresholdRGBColorsRGB(animationId, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function FillThresholdRGBColorsRGBName(path As String, frameId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillThresholdRGBColorsRGBName(lp_Path, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillThresholdRGBColorsRGBNameD(path As String, frameId As Double, redThreshold As Double, greenThreshold As Double, blueThreshold As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillThresholdRGBColorsRGBNameD(lp_Path, frameId, redThreshold, greenThreshold, blueThreshold, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by id.
		REM /// </summary>
		Public Function FillZeroColor(animationId As Integer, frameId As Integer, color As Integer)
			PluginFillZeroColor(animationId, frameId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function FillZeroColorAllFrames(animationId As Integer, color As Integer)
			PluginFillZeroColorAllFrames(animationId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function FillZeroColorAllFramesName(path As String, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillZeroColorAllFramesName(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillZeroColorAllFramesNameD(path As String, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillZeroColorAllFramesNameD(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function FillZeroColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillZeroColorAllFramesRGB(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function FillZeroColorAllFramesRGBName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillZeroColorAllFramesRGBName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillZeroColorAllFramesRGBNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillZeroColorAllFramesRGBNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by name.
		REM /// </summary>
		Public Function FillZeroColorName(path As String, frameId As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillZeroColorName(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillZeroColorNameD(path As String, frameId As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillZeroColorNameD(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by id.
		REM /// </summary>
		Public Function FillZeroColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginFillZeroColorRGB(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by name.
		REM /// </summary>
		Public Function FillZeroColorRGBName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginFillZeroColorRGBName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function FillZeroColorRGBNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginFillZeroColorRGBNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		REM /// referenced by id.
		REM /// </summary>
		Public Function Get1DColor(animationId As Integer, frameId As Integer, led As Integer) As Integer
			Dim result As Integer = PluginGet1DColor(animationId, frameId, led)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		REM /// referenced by name.
		REM /// </summary>
		Public Function Get1DColorName(path As String, frameId As Integer, led As Integer) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGet1DColorName(lp_Path, frameId, led)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function Get1DColorNameD(path As String, frameId As Double, led As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGet1DColorNameD(lp_Path, frameId, led)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// Animation is referenced by id.
		REM /// </summary>
		Public Function Get2DColor(animationId As Integer, frameId As Integer, row As Integer, column As Integer) As Integer
			Dim result As Integer = PluginGet2DColor(animationId, frameId, row, column)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// Animation is referenced by name.
		REM /// </summary>
		Public Function Get2DColorName(path As String, frameId As Integer, row As Integer, column As Integer) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGet2DColorName(lp_Path, frameId, row, column)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function Get2DColorNameD(path As String, frameId As Double, row As Double, column As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGet2DColorNameD(lp_Path, frameId, row, column)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the animation id for the named animation.
		REM /// </summary>
		Public Function GetAnimation(name As String) As Integer
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Integer = PluginGetAnimation(lp_Name)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationCount` will return the number of loaded animations.
		REM /// </summary>
		Public Function GetAnimationCount() As Integer
			Dim result As Integer = PluginGetAnimationCount()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetAnimationD(name As String) As Double
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Double = PluginGetAnimationD(lp_Name)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationId` will return the `animationId` given the `index` of 
		REM /// the loaded animation. The `index` is zero-based and less than the number 
		REM /// returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		REM /// get the name of the animation.
		REM /// </summary>
		Public Function GetAnimationId(index As Integer) As Integer
			Dim result As Integer = PluginGetAnimationId(index)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationName` takes an `animationId` and returns the name of 
		REM /// the animation of the `.chroma` animation file. If a name is not available 
		REM /// then an empty string will be returned.
		REM /// </summary>
		Public Function GetAnimationName(animationId As Integer) As String
			Dim result As String = Marshal.PtrToStringAnsi(PluginGetAnimationName(animationId))
			Return result
		End Function

		REM /// <summary>
		REM /// Get the current frame of the animation referenced by id.
		REM /// </summary>
		Public Function GetCurrentFrame(animationId As Integer) As Integer
			Dim result As Integer = PluginGetCurrentFrame(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the current frame of the animation referenced by name.
		REM /// </summary>
		Public Function GetCurrentFrameName(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGetCurrentFrameName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetCurrentFrameNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGetCurrentFrameNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		REM /// animation respective to the `deviceType`, as an integer upon success. Returns 
		REM /// negative one upon failure.
		REM /// </summary>
		Public Function GetDevice(animationId As Integer) As Integer
			Dim result As Integer = PluginGetDevice(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		REM /// animation respective to the `deviceType`, as an integer upon success. Returns 
		REM /// negative one upon failure.
		REM /// </summary>
		Public Function GetDeviceName(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGetDeviceName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetDeviceNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGetDeviceNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function GetDeviceType(animationId As Integer) As Integer
			Dim result As Integer = PluginGetDeviceType(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function GetDeviceTypeName(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGetDeviceTypeName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetDeviceTypeNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGetDeviceTypeNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		REM /// The `color` is expected to be an array of the expected dimensions for the 
		REM /// `deviceType/device`. The `length` parameter is the size of the `color` 
		REM /// array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		REM /// For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		REM /// COLUMN`. Returns the animation id upon success. Returns negative one upon 
		REM /// failure.
		REM /// </summary>
		Public Function GetFrame(animationId As Integer, frameIndex As Integer, ByRef duration As Single, colors As Integer(), length As Integer) As Integer
			Dim result As Integer = PluginGetFrame(animationId, frameIndex, duration, colors, length)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function GetFrameCount(animationId As Integer) As Integer
			Dim result As Integer = PluginGetFrameCount(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function GetFrameCountName(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGetFrameCountName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetFrameCountNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGetFrameCountNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the color of an animation key for the given frame referenced by id. 
		REM ///
		REM /// </summary>
		Public Function GetKeyColor(animationId As Integer, frameId As Integer, rzkey As Integer) As Integer
			Dim result As Integer = PluginGetKeyColor(animationId, frameId, rzkey)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetKeyColorD(path As String, frameId As Double, rzkey As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginGetKeyColorD(lp_Path, frameId, rzkey)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the color of an animation key for the given frame referenced by name. 
		REM ///
		REM /// </summary>
		Public Function GetKeyColorName(path As String, frameId As Integer, rzkey As Integer) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginGetKeyColorName(lp_Path, frameId, rzkey)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns `RZRESULT_SUCCESS` if the plugin has been initialized successfully. 
		REM /// Returns `RZRESULT_DLL_NOT_FOUND` if core Chroma library is not found. Returns 
		REM /// `RZRESULT_DLL_INVALID_SIGNATURE` if core Chroma library has an invalid 
		REM /// signature.
		REM /// </summary>
		Public Function GetLibraryLoadedState() As Integer
			Dim result As Integer = PluginGetLibraryLoadedState()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetLibraryLoadedStateD() As Double
			Dim result As Double = PluginGetLibraryLoadedStateD()
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		REM /// integer upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function GetMaxColumn(device As Device2D) As Integer
			Dim result As Integer = PluginGetMaxColumn(device)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetMaxColumnD(device As Double) As Double
			Dim result As Double = PluginGetMaxColumnD(device)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function GetMaxLeds(device As Device1D) As Integer
			Dim result As Integer = PluginGetMaxLeds(device)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetMaxLedsD(device As Double) As Double
			Dim result As Double = PluginGetMaxLedsD(device)
			Return result
		End Function

		REM /// <summary>
		REM /// Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function GetMaxRow(device As Device2D) As Integer
			Dim result As Integer = PluginGetMaxRow(device)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetMaxRowD(device As Double) As Double
			Dim result As Double = PluginGetMaxRowD(device)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginGetPlayingAnimationCount` will return the number of playing animations. 
		REM ///
		REM /// </summary>
		Public Function GetPlayingAnimationCount() As Integer
			Dim result As Integer = PluginGetPlayingAnimationCount()
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		REM /// of the playing animation. The `index` is zero-based and less than the number 
		REM /// returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		REM /// to get the name of the animation.
		REM /// </summary>
		Public Function GetPlayingAnimationId(index As Integer) As Integer
			Dim result As Integer = PluginGetPlayingAnimationId(index)
			Return result
		End Function

		REM /// <summary>
		REM /// Get the RGB color given red, green, and blue.
		REM /// </summary>
		Public Function GetRGB(red As Integer, green As Integer, blue As Integer) As Integer
			Dim result As Integer = PluginGetRGB(red, green, blue)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function GetRGBD(red As Double, green As Double, blue As Double) As Double
			Dim result As Double = PluginGetRGBD(red, green, blue)
			Return result
		End Function

		REM /// <summary>
		REM /// Check if the animation has loop enabled referenced by id.
		REM /// </summary>
		Public Function HasAnimationLoop(animationId As Integer) As Boolean
			Dim result As Boolean = PluginHasAnimationLoop(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Check if the animation has loop enabled referenced by name.
		REM /// </summary>
		Public Function HasAnimationLoopName(path As String) As Boolean
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Boolean = PluginHasAnimationLoopName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function HasAnimationLoopNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginHasAnimationLoopNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		REM /// API methods auto initialize the ChromaSDK if not already initialized.
		REM /// </summary>
		Public Function Init() As Integer
			Dim result As Integer = PluginInit()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function InitD() As Double
			Dim result As Double = PluginInitD()
			Return result
		End Function

		REM /// <summary>
		REM /// Initialize the ChromaSDK. AppInfo populates the details in Synapse. Zero 
		REM /// indicates  success, otherwise failure. Many API methods auto initialize 
		REM /// the ChromaSDK if not already initialized.
		REM /// </summary>
		Public Function InitSDK(ByRef appInfo As ChromaSDK.APPINFOTYPE) As Integer
			Dim result As Integer = PluginInitSDK(appInfo)
			Return result
		End Function

		REM /// <summary>
		REM /// Insert an animation delay by duplicating the frame by the delay number of 
		REM /// times. Animation is referenced by id.
		REM /// </summary>
		Public Function InsertDelay(animationId As Integer, frameId As Integer, delay As Integer)
			PluginInsertDelay(animationId, frameId, delay)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Insert an animation delay by duplicating the frame by the delay number of 
		REM /// times. Animation is referenced by name.
		REM /// </summary>
		Public Function InsertDelayName(path As String, frameId As Integer, delay As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginInsertDelayName(lp_Path, frameId, delay)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function InsertDelayNameD(path As String, frameId As Double, delay As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginInsertDelayNameD(lp_Path, frameId, delay)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Duplicate the source frame index at the target frame index. Animation is 
		REM /// referenced by id.
		REM /// </summary>
		Public Function InsertFrame(animationId As Integer, sourceFrame As Integer, targetFrame As Integer)
			PluginInsertFrame(animationId, sourceFrame, targetFrame)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Duplicate the source frame index at the target frame index. Animation is 
		REM /// referenced by name.
		REM /// </summary>
		Public Function InsertFrameName(path As String, sourceFrame As Integer, targetFrame As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginInsertFrameName(lp_Path, sourceFrame, targetFrame)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function InsertFrameNameD(path As String, sourceFrame As Double, targetFrame As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginInsertFrameNameD(lp_Path, sourceFrame, targetFrame)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Invert all the colors at the specified frame. Animation is referenced by 
		REM /// id.
		REM /// </summary>
		Public Function InvertColors(animationId As Integer, frameId As Integer)
			PluginInvertColors(animationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Invert all the colors for all frames. Animation is referenced by id.
		REM /// </summary>
		Public Function InvertColorsAllFrames(animationId As Integer)
			PluginInvertColorsAllFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Invert all the colors for all frames. Animation is referenced by name.
		REM /// </summary>
		Public Function InvertColorsAllFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginInvertColorsAllFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function InvertColorsAllFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginInvertColorsAllFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Invert all the colors at the specified frame. Animation is referenced by 
		REM /// name.
		REM /// </summary>
		Public Function InvertColorsName(path As String, frameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginInvertColorsName(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function InvertColorsNameD(path As String, frameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginInvertColorsNameD(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Check if the animation is paused referenced by id.
		REM /// </summary>
		Public Function IsAnimationPaused(animationId As Integer) As Boolean
			Dim result As Boolean = PluginIsAnimationPaused(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Check if the animation is paused referenced by name.
		REM /// </summary>
		Public Function IsAnimationPausedName(path As String) As Boolean
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Boolean = PluginIsAnimationPausedName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsAnimationPausedNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginIsAnimationPausedNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// The editor dialog is a non-blocking modal window, this method returns true 
		REM /// if the modal window is open, otherwise false.
		REM /// </summary>
		Public Function IsDialogOpen() As Boolean
			Dim result As Boolean = PluginIsDialogOpen()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsDialogOpenD() As Double
			Dim result As Double = PluginIsDialogOpenD()
			Return result
		End Function

		REM /// <summary>
		REM /// Returns true if the plugin has been initialized. Returns false if the plugin 
		REM /// is uninitialized.
		REM /// </summary>
		Public Function IsInitialized() As Boolean
			Dim result As Boolean = PluginIsInitialized()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsInitializedD() As Double
			Dim result As Double = PluginIsInitializedD()
			Return result
		End Function

		REM /// <summary>
		REM /// If the method can be invoked the method returns true.
		REM /// </summary>
		Public Function IsPlatformSupported() As Boolean
			Dim result As Boolean = PluginIsPlatformSupported()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsPlatformSupportedD() As Double
			Dim result As Double = PluginIsPlatformSupportedD()
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The method 
		REM /// will return whether the animation is playing or not. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function IsPlaying(animationId As Integer) As Boolean
			Dim result As Boolean = PluginIsPlaying(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsPlayingD(animationId As Double) As Double
			Dim result As Double = PluginIsPlayingD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The method 
		REM /// will return whether the animation is playing or not. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function IsPlayingName(path As String) As Boolean
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Boolean = PluginIsPlayingName(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsPlayingNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginIsPlayingNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		REM /// If any animation is playing for the `deviceType` and `device` combination, 
		REM /// the method will return true, otherwise false.
		REM /// </summary>
		Public Function IsPlayingType(deviceType As Integer, device As Integer) As Boolean
			Dim result As Boolean = PluginIsPlayingType(deviceType, device)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function IsPlayingTypeD(deviceType As Double, device As Double) As Double
			Dim result As Double = PluginIsPlayingTypeD(deviceType, device)
			Return result
		End Function

		REM /// <summary>
		REM /// Do a lerp math operation on a float.
		REM /// </summary>
		Public Function Lerp(start As Single, renamed_end As Single, amt As Single) As Single
			Dim result As Single = PluginLerp(start, renamed_end, amt)
			Return result
		End Function

		REM /// <summary>
		REM /// Lerp from one color to another given t in the range 0.0 to 1.0.
		REM /// </summary>
		Public Function LerpColor(from As Integer, renamed_to As Integer, t As Single) As Integer
			Dim result As Integer = PluginLerpColor(from, renamed_to, t)
			Return result
		End Function

		REM /// <summary>
		REM /// Loads `Chroma` effects so that the animation can be played immediately. 
		REM /// Returns the animation id upon success. Returns negative one upon failure. 
		REM ///
		REM /// </summary>
		Public Function LoadAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginLoadAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function LoadAnimationD(animationId As Double) As Double
			Dim result As Double = PluginLoadAnimationD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Load the named animation.
		REM /// </summary>
		Public Function LoadAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginLoadAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Load a composite set of animations.
		REM /// </summary>
		Public Function LoadComposite(name As String)
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			PluginLoadComposite(lp_Name)
			FreeIntPtr(lp_Name)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function MakeBlankFrames(animationId As Integer, frameCount As Integer, duration As Single, color As Integer)
			PluginMakeBlankFrames(animationId, frameCount, duration, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function MakeBlankFramesName(path As String, frameCount As Integer, duration As Single, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMakeBlankFramesName(lp_Path, frameCount, duration, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MakeBlankFramesNameD(path As String, frameCount As Double, duration As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMakeBlankFramesNameD(lp_Path, frameCount, duration, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MakeBlankFramesRandom(animationId As Integer, frameCount As Integer, duration As Single)
			PluginMakeBlankFramesRandom(animationId, frameCount, duration)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random black and white. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function MakeBlankFramesRandomBlackAndWhite(animationId As Integer, frameCount As Integer, duration As Single)
			PluginMakeBlankFramesRandomBlackAndWhite(animationId, frameCount, duration)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random black and white. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function MakeBlankFramesRandomBlackAndWhiteName(path As String, frameCount As Integer, duration As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMakeBlankFramesRandomBlackAndWhiteName(lp_Path, frameCount, duration)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MakeBlankFramesRandomBlackAndWhiteNameD(path As String, frameCount As Double, duration As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMakeBlankFramesRandomBlackAndWhiteNameD(lp_Path, frameCount, duration)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MakeBlankFramesRandomName(path As String, frameCount As Integer, duration As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMakeBlankFramesRandomName(lp_Path, frameCount, duration)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MakeBlankFramesRandomNameD(path As String, frameCount As Double, duration As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMakeBlankFramesRandomNameD(lp_Path, frameCount, duration)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function MakeBlankFramesRGB(animationId As Integer, frameCount As Integer, duration As Single, red As Integer, green As Integer, blue As Integer)
			PluginMakeBlankFramesRGB(animationId, frameCount, duration, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function MakeBlankFramesRGBName(path As String, frameCount As Integer, duration As Single, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMakeBlankFramesRGBName(lp_Path, frameCount, duration, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MakeBlankFramesRGBNameD(path As String, frameCount As Double, duration As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMakeBlankFramesRGBNameD(lp_Path, frameCount, duration, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		REM /// the animation id upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function MirrorHorizontally(animationId As Integer) As Integer
			Dim result As Integer = PluginMirrorHorizontally(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Flips the color grid vertically for all `Chroma` animation frames. This 
		REM /// method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		REM /// animation id upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function MirrorVertically(animationId As Integer) As Integer
			Dim result As Integer = PluginMirrorVertically(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the color intensity with the lerp result from color 1 to color 
		REM /// 2 using the frame index divided by the frame count for the `t` parameter. 
		REM /// Animation is referenced in id.
		REM /// </summary>
		Public Function MultiplyColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer)
			PluginMultiplyColorLerpAllFrames(animationId, color1, color2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply the color intensity with the lerp result from color 1 to color 
		REM /// 2 using the frame index divided by the frame count for the `t` parameter. 
		REM /// Animation is referenced in name.
		REM /// </summary>
		Public Function MultiplyColorLerpAllFramesName(path As String, color1 As Integer, color2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyColorLerpAllFramesName(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyColorLerpAllFramesNameD(path As String, color1 As Double, color2 As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyColorLerpAllFramesNameD(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply all the colors in the frame by the intensity value. The valid the 
		REM /// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		REM /// An intensity of 0.5 would half the color value. Black colors in the frame 
		REM /// will not be affected by this method.
		REM /// </summary>
		Public Function MultiplyIntensity(animationId As Integer, frameId As Integer, intensity As Single)
			PluginMultiplyIntensity(animationId, frameId, intensity)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all the colors for all frames by the intensity value. The valid 
		REM /// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		REM /// equally. An intensity of 0.5 would half the color value. Black colors in 
		REM /// the frame will not be affected by this method.
		REM /// </summary>
		Public Function MultiplyIntensityAllFrames(animationId As Integer, intensity As Single)
			PluginMultiplyIntensityAllFrames(animationId, intensity)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all the colors for all frames by the intensity value. The valid 
		REM /// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		REM /// equally. An intensity of 0.5 would half the color value. Black colors in 
		REM /// the frame will not be affected by this method.
		REM /// </summary>
		Public Function MultiplyIntensityAllFramesName(path As String, intensity As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityAllFramesName(lp_Path, intensity)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityAllFramesNameD(path As String, intensity As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityAllFramesNameD(lp_Path, intensity)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyIntensityAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginMultiplyIntensityAllFramesRGB(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MultiplyIntensityAllFramesRGBName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityAllFramesRGBName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityAllFramesRGBNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityAllFramesRGBNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyIntensityColor(animationId As Integer, frameId As Integer, color As Integer)
			PluginMultiplyIntensityColor(animationId, frameId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyIntensityColorAllFrames(animationId As Integer, color As Integer)
			PluginMultiplyIntensityColorAllFrames(animationId, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MultiplyIntensityColorAllFramesName(path As String, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityColorAllFramesName(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityColorAllFramesNameD(path As String, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityColorAllFramesNameD(lp_Path, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MultiplyIntensityColorName(path As String, frameId As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityColorName(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityColorNameD(path As String, frameId As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityColorNameD(lp_Path, frameId, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply all the colors in the frame by the intensity value. The valid the 
		REM /// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		REM /// An intensity of 0.5 would half the color value. Black colors in the frame 
		REM /// will not be affected by this method.
		REM /// </summary>
		Public Function MultiplyIntensityName(path As String, frameId As Integer, intensity As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityName(lp_Path, frameId, intensity)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityNameD(path As String, frameId As Double, intensity As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityNameD(lp_Path, frameId, intensity)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyIntensityRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginMultiplyIntensityRGB(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MultiplyIntensityRGBName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyIntensityRGBName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyIntensityRGBNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyIntensityRGBNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerp(animationId As Integer, frameId As Integer, color1 As Integer, color2 As Integer)
			PluginMultiplyNonZeroTargetColorLerp(animationId, frameId, color1, color2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by id. 
		REM ///
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer)
			PluginMultiplyNonZeroTargetColorLerpAllFrames(animationId, color1, color2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by name. 
		REM ///
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFramesName(path As String, color1 As Integer, color2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyNonZeroTargetColorLerpAllFramesName(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFramesNameD(path As String, color1 As Double, color2 As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		REM /// using the frame color value as the `t` value. Animation is referenced by 
		REM /// id.
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFramesRGB(animationId As Integer, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer)
			PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		REM /// using the frame color value as the `t` value. Animation is referenced by 
		REM /// name.
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFramesRGBName(path As String, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(lp_Path, red1, green1, blue1, red2, green2, blue2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyNonZeroTargetColorLerpAllFramesRGBNameD(path As String, red1 As Double, green1 As Double, blue1 As Double, red2 As Double, green2 As Double, blue2 As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(lp_Path, red1, green1, blue1, red2, green2, blue2)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function MultiplyTargetColorLerp(animationId As Integer, frameId As Integer, color1 As Integer, color2 As Integer)
			PluginMultiplyTargetColorLerp(animationId, frameId, color1, color2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by id. 
		REM ///
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer)
			PluginMultiplyTargetColorLerpAllFrames(animationId, color1, color2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by name. 
		REM ///
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFramesName(path As String, color1 As Integer, color2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyTargetColorLerpAllFramesName(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFramesNameD(path As String, color1 As Double, color2 As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyTargetColorLerpAllFramesNameD(lp_Path, color1, color2)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		REM /// frame color value as the `t` value. Animation is referenced by id.
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFramesRGB(animationId As Integer, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer)
			PluginMultiplyTargetColorLerpAllFramesRGB(animationId, red1, green1, blue1, red2, green2, blue2)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		REM /// frame color value as the `t` value. Animation is referenced by name.
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFramesRGBName(path As String, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyTargetColorLerpAllFramesRGBName(lp_Path, red1, green1, blue1, red2, green2, blue2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function MultiplyTargetColorLerpAllFramesRGBNameD(path As String, red1 As Double, green1 As Double, blue1 As Double, red2 As Double, green2 As Double, blue2 As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginMultiplyTargetColorLerpAllFramesRGBNameD(lp_Path, red1, green1, blue1, red2, green2, blue2)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function MultiplyTargetColorLerpName(path As String, frameId As Integer, color1 As Integer, color2 As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginMultiplyTargetColorLerpName(lp_Path, frameId, color1, color2)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Offset all colors in the frame using the RGB offset. Use the range of -255 
		REM /// to 255 for red, green, and blue parameters. Negative values remove color. 
		REM /// Positive values add color.
		REM /// </summary>
		Public Function OffsetColors(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginOffsetColors(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Offset all colors for all frames using the RGB offset. Use the range of 
		REM /// -255 to 255 for red, green, and blue parameters. Negative values remove 
		REM /// color. Positive values add color.
		REM /// </summary>
		Public Function OffsetColorsAllFrames(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginOffsetColorsAllFrames(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Offset all colors for all frames using the RGB offset. Use the range of 
		REM /// -255 to 255 for red, green, and blue parameters. Negative values remove 
		REM /// color. Positive values add color.
		REM /// </summary>
		Public Function OffsetColorsAllFramesName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginOffsetColorsAllFramesName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OffsetColorsAllFramesNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOffsetColorsAllFramesNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Offset all colors in the frame using the RGB offset. Use the range of -255 
		REM /// to 255 for red, green, and blue parameters. Negative values remove color. 
		REM /// Positive values add color.
		REM /// </summary>
		Public Function OffsetColorsName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginOffsetColorsName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OffsetColorsNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOffsetColorsNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors in the frame using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// </summary>
		Public Function OffsetNonZeroColors(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginOffsetNonZeroColors(animationId, frameId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors for all frames using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// </summary>
		Public Function OffsetNonZeroColorsAllFrames(animationId As Integer, red As Integer, green As Integer, blue As Integer)
			PluginOffsetNonZeroColorsAllFrames(animationId, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors for all frames using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// </summary>
		Public Function OffsetNonZeroColorsAllFramesName(path As String, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginOffsetNonZeroColorsAllFramesName(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OffsetNonZeroColorsAllFramesNameD(path As String, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOffsetNonZeroColorsAllFramesNameD(lp_Path, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors in the frame using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// </summary>
		Public Function OffsetNonZeroColorsName(path As String, frameId As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginOffsetNonZeroColorsName(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OffsetNonZeroColorsNameD(path As String, frameId As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOffsetNonZeroColorsNameD(lp_Path, frameId, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation file so that it can be played. Returns an animation 
		REM /// id >= 0 upon success. Returns negative one if there was a failure. The 
		REM /// animation id is used in most of the API methods.
		REM /// </summary>
		Public Function OpenAnimation(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginOpenAnimation(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OpenAnimationD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOpenAnimationD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation data from memory so that it can be played. `Data` 
		REM /// is a pointer to BYTE array of the loaded animation in memory. `Name` will 
		REM /// be assigned to the animation when loaded. Returns an animation id >= 0 
		REM /// upon success. Returns negative one if there was a failure. The animation 
		REM /// id is used in most of the API methods.
		REM /// </summary>
		Public Function OpenAnimationFromMemory(data As Byte(), name As String) As Integer
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Integer = PluginOpenAnimationFromMemory(data, lp_Name)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		REM /// upon success. Returns negative one if there was a failure.
		REM /// </summary>
		Public Function OpenEditorDialog(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginOpenEditorDialog(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Open the named animation in the editor dialog and play the animation at 
		REM /// start.
		REM /// </summary>
		Public Function OpenEditorDialogAndPlay(path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginOpenEditorDialogAndPlay(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OpenEditorDialogAndPlayD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOpenEditorDialogAndPlayD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OpenEditorDialogD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginOpenEditorDialogD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		REM /// parameter. Returns the animation id upon success. Returns negative one 
		REM /// upon failure.
		REM /// </summary>
		Public Function OverrideFrameDuration(animationId As Integer, duration As Single) As Integer
			Dim result As Integer = PluginOverrideFrameDuration(animationId, duration)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function OverrideFrameDurationD(animationId As Double, duration As Double) As Double
			Dim result As Double = PluginOverrideFrameDurationD(animationId, duration)
			Return result
		End Function

		REM /// <summary>
		REM /// Override the duration of all frames with the `duration` value. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function OverrideFrameDurationName(path As String, duration As Single)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginOverrideFrameDurationName(lp_Path, duration)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Pause the current animation referenced by id.
		REM /// </summary>
		Public Function PauseAnimation(animationId As Integer)
			PluginPauseAnimation(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Pause the current animation referenced by name.
		REM /// </summary>
		Public Function PauseAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginPauseAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PauseAnimationNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginPauseAnimationNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Plays the `Chroma` animation. This will load the animation, if not loaded 
		REM /// previously. Returns the animation id upon success. Returns negative one 
		REM /// upon failure.
		REM /// </summary>
		Public Function PlayAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginPlayAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PlayAnimationD(animationId As Double) As Double
			Dim result As Double = PluginPlayAnimationD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		REM /// The method will play the animation given the `animationId` with looping 
		REM /// `on` or `off` starting at the `frameId`.
		REM /// </summary>
		Public Function PlayAnimationFrame(animationId As Integer, frameId As Integer, renamed_loop As Boolean)
			PluginPlayAnimationFrame(animationId, frameId, renamed_loop)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will play with looping `on` or `off` starting at the `frameId`.
		REM /// </summary>
		Public Function PlayAnimationFrameName(path As String, frameId As Integer, renamed_loop As Boolean)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginPlayAnimationFrameName(lp_Path, frameId, renamed_loop)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PlayAnimationFrameNameD(path As String, frameId As Double, renamed_loop As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginPlayAnimationFrameNameD(lp_Path, frameId, renamed_loop)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		REM /// The method will play the animation given the `animationId` with looping 
		REM /// `on` or `off`.
		REM /// </summary>
		Public Function PlayAnimationLoop(animationId As Integer, renamed_loop As Boolean)
			PluginPlayAnimationLoop(animationId, renamed_loop)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will play with looping `on` or `off`.
		REM /// </summary>
		Public Function PlayAnimationName(path As String, renamed_loop As Boolean)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginPlayAnimationName(lp_Path, renamed_loop)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PlayAnimationNameD(path As String, renamed_loop As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginPlayAnimationNameD(lp_Path, renamed_loop)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		REM /// The named animation files for the `.chroma` set will be automatically opened. 
		REM /// The set of animations will play with looping `on` or `off`.
		REM /// </summary>
		Public Function PlayComposite(name As String, renamed_loop As Boolean)
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			PluginPlayComposite(lp_Name, renamed_loop)
			FreeIntPtr(lp_Name)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PlayCompositeD(name As String, renamed_loop As Double) As Double
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Double = PluginPlayCompositeD(lp_Name, renamed_loop)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		REM /// Returns the animation id upon success. Returns negative one upon failure. 
		REM ///
		REM /// </summary>
		Public Function PreviewFrame(animationId As Integer, frameIndex As Integer) As Integer
			Dim result As Integer = PluginPreviewFrame(animationId, frameIndex)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function PreviewFrameD(animationId As Double, frameIndex As Double) As Double
			Dim result As Double = PluginPreviewFrameD(animationId, frameIndex)
			Return result
		End Function

		REM /// <summary>
		REM /// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		REM /// Animaton is referenced by name.
		REM /// </summary>
		Public Function PreviewFrameName(path As String, frameIndex As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginPreviewFrameName(lp_Path, frameIndex)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Reduce the frames of the animation by removing every nth element. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function ReduceFrames(animationId As Integer, n As Integer)
			PluginReduceFrames(animationId, n)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Reduce the frames of the animation by removing every nth element. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function ReduceFramesName(path As String, n As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginReduceFramesName(lp_Path, n)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function ReduceFramesNameD(path As String, n As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginReduceFramesNameD(lp_Path, n)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		REM /// upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function ResetAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginResetAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Resume the animation with loop `ON` or `OFF` referenced by id.
		REM /// </summary>
		Public Function ResumeAnimation(animationId As Integer, renamed_loop As Boolean)
			PluginResumeAnimation(animationId, renamed_loop)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Resume the animation with loop `ON` or `OFF` referenced by name.
		REM /// </summary>
		Public Function ResumeAnimationName(path As String, renamed_loop As Boolean)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginResumeAnimationName(lp_Path, renamed_loop)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function ResumeAnimationNameD(path As String, renamed_loop As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginResumeAnimationNameD(lp_Path, renamed_loop)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Returns the 
		REM /// animation id upon success. Returns negative one upon failure. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function Reverse(animationId As Integer) As Integer
			Dim result As Integer = PluginReverse(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Animation is 
		REM /// referenced by id.
		REM /// </summary>
		Public Function ReverseAllFrames(animationId As Integer)
			PluginReverseAllFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Animation is 
		REM /// referenced by name.
		REM /// </summary>
		Public Function ReverseAllFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginReverseAllFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function ReverseAllFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginReverseAllFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Save the animation referenced by id to the path specified.
		REM /// </summary>
		Public Function SaveAnimation(animationId As Integer, path As String) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginSaveAnimation(animationId, lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Save the named animation to the target path specified.
		REM /// </summary>
		Public Function SaveAnimationName(sourceAnimation As String, targetAnimation As String) As Integer
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Integer = PluginSaveAnimationName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function Set1DColor(animationId As Integer, frameId As Integer, led As Integer, color As Integer)
			PluginSet1DColor(animationId, frameId, led, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function Set1DColorName(path As String, frameId As Integer, led As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSet1DColorName(lp_Path, frameId, led, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function Set1DColorNameD(path As String, frameId As Double, led As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSet1DColorNameD(lp_Path, frameId, led, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// The animation is referenced by id.
		REM /// </summary>
		Public Function Set2DColor(animationId As Integer, frameId As Integer, row As Integer, column As Integer, color As Integer)
			PluginSet2DColor(animationId, frameId, row, column, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// The animation is referenced by name.
		REM /// </summary>
		Public Function Set2DColorName(path As String, frameId As Integer, row As Integer, column As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSet2DColorName(lp_Path, frameId, row, column, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function Set2DColorNameD(path As String, frameId As Double, rowColumnIndex As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSet2DColorNameD(lp_Path, frameId, rowColumnIndex, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// When custom color is set, the custom key mode will be used. The animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetChromaCustomColorAllFrames(animationId As Integer)
			PluginSetChromaCustomColorAllFrames(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// When custom color is set, the custom key mode will be used. The animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetChromaCustomColorAllFramesName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetChromaCustomColorAllFramesName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetChromaCustomColorAllFramesNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetChromaCustomColorAllFramesNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		REM /// from grid to key. `True` changes the layout from key to grid. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetChromaCustomFlag(animationId As Integer, flag As Boolean)
			PluginSetChromaCustomFlag(animationId, flag)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		REM /// from grid to key. `True` changes the layout from key to grid. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetChromaCustomFlagName(path As String, flag As Boolean)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetChromaCustomFlagName(lp_Path, flag)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetChromaCustomFlagNameD(path As String, flag As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetChromaCustomFlagNameD(lp_Path, flag)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the current frame of the animation referenced by id.
		REM /// </summary>
		Public Function SetCurrentFrame(animationId As Integer, frameId As Integer)
			PluginSetCurrentFrame(animationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the current frame of the animation referenced by name.
		REM /// </summary>
		Public Function SetCurrentFrameName(path As String, frameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetCurrentFrameName(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetCurrentFrameNameD(path As String, frameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetCurrentFrameNameD(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the custom alpha flag on the color array
		REM /// </summary>
		Public Function SetCustomColorFlag2D(device As Integer, colors As Integer()) As Integer
			Dim result As Integer = PluginSetCustomColorFlag2D(device, colors)
			Return result
		End Function

		REM /// <summary>
		REM /// Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		REM /// is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		REM /// the animation id upon success. Returns negative one upon failure.
		REM /// </summary>
		Public Function SetDevice(animationId As Integer, deviceType As Integer, device As Integer) As Integer
			Dim result As Integer = PluginSetDevice(animationId, deviceType, device)
			Return result
		End Function

		REM /// <summary>
		REM /// SetEffect will display the referenced effect id.
		REM /// </summary>
		Public Function SetEffect(effectId As Guid) As Integer
			Dim result As Integer = PluginSetEffect(effectId)
			Return result
		End Function

		REM /// <summary>
		REM /// SetEffectCustom1D will display the referenced colors immediately
		REM /// </summary>
		Public Function SetEffectCustom1D(device As Integer, colors As Integer()) As Integer
			Dim result As Integer = PluginSetEffectCustom1D(device, colors)
			Return result
		End Function

		REM /// <summary>
		REM /// SetEffectCustom2D will display the referenced colors immediately
		REM /// </summary>
		Public Function SetEffectCustom2D(device As Integer, colors As Integer()) As Integer
			Dim result As Integer = PluginSetEffectCustom2D(device, colors)
			Return result
		End Function

		REM /// <summary>
		REM /// SetEffectKeyboardCustom2D will display the referenced custom keyboard colors 
		REM /// immediately
		REM /// </summary>
		Public Function SetEffectKeyboardCustom2D(device As Integer, colors As Integer()) As Integer
			Dim result As Integer = PluginSetEffectKeyboardCustom2D(device, colors)
			Return result
		End Function

		REM /// <summary>
		REM /// When the idle animation is used, the named animation will play when no other 
		REM /// animations are playing. Reference the animation by id.
		REM /// </summary>
		Public Function SetIdleAnimation(animationId As Integer)
			PluginSetIdleAnimation(animationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// When the idle animation is used, the named animation will play when no other 
		REM /// animations are playing. Reference the animation by name.
		REM /// </summary>
		Public Function SetIdleAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetIdleAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame.
		REM /// </summary>
		Public Function SetKeyColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer)
			PluginSetKeyColor(animationId, frameId, rzkey, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function SetKeyColorAllFrames(animationId As Integer, rzkey As Integer, color As Integer)
			PluginSetKeyColorAllFrames(animationId, rzkey, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function SetKeyColorAllFramesName(path As String, rzkey As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyColorAllFramesName(lp_Path, rzkey, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyColorAllFramesNameD(path As String, rzkey As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyColorAllFramesNameD(lp_Path, rzkey, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by id.
		REM /// </summary>
		Public Function SetKeyColorAllFramesRGB(animationId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeyColorAllFramesRGB(animationId, rzkey, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by name.
		REM /// </summary>
		Public Function SetKeyColorAllFramesRGBName(path As String, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyColorAllFramesRGBName(lp_Path, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyColorAllFramesRGBNameD(path As String, rzkey As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyColorAllFramesRGBNameD(lp_Path, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame.
		REM /// </summary>
		Public Function SetKeyColorName(path As String, frameId As Integer, rzkey As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyColorName(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyColorNameD(path As String, frameId As Double, rzkey As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyColorNameD(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetKeyColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeyColorRGB(animationId, frameId, rzkey, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetKeyColorRGBName(path As String, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyColorRGBName(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyColorRGBNameD(path As String, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame if the existing 
		REM /// color is not already black.
		REM /// </summary>
		Public Function SetKeyNonZeroColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer)
			PluginSetKeyNonZeroColor(animationId, frameId, rzkey, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame if the existing 
		REM /// color is not already black.
		REM /// </summary>
		Public Function SetKeyNonZeroColorName(path As String, frameId As Integer, rzkey As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyNonZeroColorName(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyNonZeroColorNameD(path As String, frameId As Double, rzkey As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyNonZeroColorNameD(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame where color 
		REM /// is not black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeyNonZeroColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeyNonZeroColorRGB(animationId, frameId, rzkey, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame where color 
		REM /// is not black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeyNonZeroColorRGBName(path As String, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyNonZeroColorRGBName(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyNonZeroColorRGBNameD(path As String, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyNonZeroColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set animation key by row and column to a static color for the given frame. 
		REM ///
		REM /// </summary>
		Public Function SetKeyRowColumnColorName(path As String, frameId As Integer, row As Integer, column As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyRowColumnColorName(lp_Path, frameId, row, column, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetKeysColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysColor(animationId, frameId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetKeysColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysColorAllFrames(animationId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetKeysColorAllFramesName(path As String, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysColorAllFramesName(lp_Path, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetKeysColorAllFramesRGB(animationId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeysColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetKeysColorAllFramesRGBName(path As String, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysColorAllFramesRGBName(lp_Path, rzkeys, keyCount, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame.
		REM /// </summary>
		Public Function SetKeysColorName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysColorName(lp_Path, frameId, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by id.
		REM /// </summary>
		Public Function SetKeysColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeysColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by name.
		REM /// </summary>
		Public Function SetKeysColorRGBName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame if 
		REM /// the existing color is not already black.
		REM /// </summary>
		Public Function SetKeysNonZeroColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysNonZeroColor(animationId, frameId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysNonZeroColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysNonZeroColorAllFrames(animationId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames if the existing 
		REM /// color is not already black. Reference animation by name.
		REM /// </summary>
		Public Function SetKeysNonZeroColorAllFramesName(path As String, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysNonZeroColorAllFramesName(lp_Path, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame if 
		REM /// the existing color is not already black. Reference animation by name.
		REM /// </summary>
		Public Function SetKeysNonZeroColorName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysNonZeroColorName(lp_Path, frameId, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysNonZeroColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeysNonZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeysNonZeroColorRGBName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysNonZeroColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysZeroColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysZeroColor(animationId, frameId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysZeroColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			PluginSetKeysZeroColorAllFrames(animationId, rzkeys, keyCount, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeysZeroColorAllFramesName(path As String, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysZeroColorAllFramesName(lp_Path, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysZeroColorAllFramesRGB(animationId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeysZeroColorAllFramesRGB(animationId, rzkeys, keyCount, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeysZeroColorAllFramesRGBName(path As String, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysZeroColorAllFramesRGBName(lp_Path, rzkeys, keyCount, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeysZeroColorName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysZeroColorName(lp_Path, frameId, rzkeys, keyCount, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeysZeroColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeysZeroColorRGB(animationId, frameId, rzkeys, keyCount, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeysZeroColorRGBName(path As String, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeysZeroColorRGBName(lp_Path, frameId, rzkeys, keyCount, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeyZeroColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer)
			PluginSetKeyZeroColor(animationId, frameId, rzkey, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeyZeroColorName(path As String, frameId As Integer, rzkey As Integer, color As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyZeroColorName(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyZeroColorNameD(path As String, frameId As Double, rzkey As Double, color As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyZeroColorNameD(lp_Path, frameId, rzkey, color)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by id.
		REM /// </summary>
		Public Function SetKeyZeroColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			PluginSetKeyZeroColorRGB(animationId, frameId, rzkey, red, green, blue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by name.
		REM /// </summary>
		Public Function SetKeyZeroColorRGBName(path As String, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSetKeyZeroColorRGBName(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SetKeyZeroColorRGBNameD(path As String, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSetKeyZeroColorRGBNameD(lp_Path, frameId, rzkey, red, green, blue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Invokes the setup for a debug logging callback so that `stdout` is redirected 
		REM /// to the callback. This is used by `Unity` so that debug messages can appear 
		REM /// in the console window.
		REM /// </summary>
		Public Function SetLogDelegate(fp As IntPtr)
			PluginSetLogDelegate(fp)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Sets the target device to the static color.
		REM /// </summary>
		Public Function SetStaticColor(deviceType As Integer, device As Integer, color As Integer)
			PluginSetStaticColor(deviceType, device, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Sets all devices to the static color.
		REM /// </summary>
		Public Function SetStaticColorAll(color As Integer)
			PluginSetStaticColorAll(color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Sets the target device to the static color.
		REM /// </summary>
		Public Function StaticColor(deviceType As Integer, device As Integer, color As Integer)
			PluginStaticColor(deviceType, device, color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Sets all devices to the static color.
		REM /// </summary>
		Public Function StaticColorAll(color As Integer)
			PluginStaticColorAll(color)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function StaticColorD(deviceType As Double, device As Double, color As Double) As Double
			Dim result As Double = PluginStaticColorD(deviceType, device, color)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginStopAll` will automatically stop all animations that are playing. 
		REM ///
		REM /// </summary>
		Public Function StopAll()
			PluginStopAll()
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Stops animation playback if in progress. Returns the animation id upon success. 
		REM /// Returns negative one upon failure.
		REM /// </summary>
		Public Function StopAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginStopAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function StopAnimationD(animationId As Double) As Double
			Dim result As Double = PluginStopAnimationD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will stop if playing.
		REM /// </summary>
		Public Function StopAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginStopAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function StopAnimationNameD(path As String) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginStopAnimationNameD(lp_Path)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		REM /// If any animation is playing for the `deviceType` and `device` combination, 
		REM /// it will be stopped.
		REM /// </summary>
		Public Function StopAnimationType(deviceType As Integer, device As Integer)
			PluginStopAnimationType(deviceType, device)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function StopAnimationTypeD(deviceType As Double, device As Double) As Double
			Dim result As Double = PluginStopAnimationTypeD(deviceType, device)
			Return result
		End Function

		REM /// <summary>
		REM /// `PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		REM /// The named animation files for the `.chroma` set will be automatically opened. 
		REM /// The set of animations will be stopped if playing.
		REM /// </summary>
		Public Function StopComposite(name As String)
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			PluginStopComposite(lp_Name)
			FreeIntPtr(lp_Name)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function StopCompositeD(name As String) As Double
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			Dim result As Double = PluginStopCompositeD(lp_Name)
			FreeIntPtr(lp_Name)
			Return result
		End Function

		REM /// <summary>
		REM /// Return color1 - color2
		REM /// </summary>
		Public Function SubtractColor(color1 As Integer, color2 As Integer) As Integer
			Dim result As Integer = PluginSubtractColor(color1, color2)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for the frame where the 
		REM /// target color is not black. Source and target are referenced by id.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer)
			PluginSubtractNonZeroAllKeys(sourceAnimationId, targetAnimationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black. Source and target are referenced by id.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginSubtractNonZeroAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black. Source and target are referenced by name.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black starting at offset for the length of the source. 
		REM /// Source and target are referenced by id.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginSubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black starting at offset for the length of the source. 
		REM /// Source and target are referenced by name.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for the frame where the 
		REM /// target color is not black. Source and target are referenced by name.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysName(sourceAnimation As String, targetAnimation As String, frameId As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroAllKeysName(lp_SourceAnimation, lp_TargetAnimation, frameId)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target where color is not black for the 
		REM /// source frame and target offset frame, reference source and target by id. 
		REM ///
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginSubtractNonZeroAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target where color is not black for the 
		REM /// source frame and target offset frame, reference source and target by name. 
		REM ///
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames. Reference source and target by id.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer)
			PluginSubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId, targetAnimationId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames. Reference source and target by name.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFramesName(sourceAnimation As String, targetAnimation As String)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroTargetAllKeysAllFramesName(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As String, targetAnimation As String) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroTargetAllKeysAllFramesNameD(lp_SourceAnimation, lp_TargetAnimation)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames starting at the target offset for the length of 
		REM /// the source. Reference source and target by id.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer)
			PluginSubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId, targetAnimationId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames starting at the target offset for the length of 
		REM /// the source. Reference source and target by name.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As String, targetAnimation As String, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As String, targetAnimation As String, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black from the source frame to the target offset frame. Reference source 
		REM /// and target by id.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer)
			PluginSubtractNonZeroTargetAllKeysOffset(sourceAnimationId, targetAnimationId, frameId, offset)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black from the source frame to the target offset frame. Reference source 
		REM /// and target by name.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysOffsetName(sourceAnimation As String, targetAnimation As String, frameId As Integer, offset As Integer)
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			PluginSubtractNonZeroTargetAllKeysOffsetName(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractNonZeroTargetAllKeysOffsetNameD(sourceAnimation As String, targetAnimation As String, frameId As Double, offset As Double) As Double
			Dim str_SourceAnimation As String = sourceAnimation
			Dim lp_SourceAnimation As IntPtr = GetPathIntPtr(str_SourceAnimation)
			Dim str_TargetAnimation As String = targetAnimation
			Dim lp_TargetAnimation As IntPtr = GetPathIntPtr(str_TargetAnimation)
			Dim result As Double = PluginSubtractNonZeroTargetAllKeysOffsetNameD(lp_SourceAnimation, lp_TargetAnimation, frameId, offset)
			FreeIntPtr(lp_SourceAnimation)
			FreeIntPtr(lp_TargetAnimation)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract all frames with the min RGB color where the animation color is 
		REM /// less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by id.
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxAllFramesRGB(animationId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			PluginSubtractThresholdColorsMinMaxAllFramesRGB(animationId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract all frames with the min RGB color where the animation color is 
		REM /// less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by name.
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxAllFramesRGBName(path As String, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSubtractThresholdColorsMinMaxAllFramesRGBName(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxAllFramesRGBNameD(path As String, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(lp_Path, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Subtract the specified frame with the min RGB color where the animation 
		REM /// color is less than the min threshold AND with the max RGB color where the 
		REM /// animation is more than the max threshold. Animation is referenced by id. 
		REM ///
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxRGB(animationId As Integer, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			PluginSubtractThresholdColorsMinMaxRGB(animationId, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Subtract the specified frame with the min RGB color where the animation 
		REM /// color is less than the min threshold AND with the max RGB color where the 
		REM /// animation is more than the max threshold. Animation is referenced by name. 
		REM ///
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxRGBName(path As String, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginSubtractThresholdColorsMinMaxRGBName(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function SubtractThresholdColorsMinMaxRGBNameD(path As String, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginSubtractThresholdColorsMinMaxRGBNameD(lp_Path, frameId, minThreshold, minRed, minGreen, minBlue, maxThreshold, maxRed, maxGreen, maxBlue)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Trim the end of the animation. The length of the animation will be the lastFrameId 
		REM /// plus one. Reference the animation by id.
		REM /// </summary>
		Public Function TrimEndFrames(animationId As Integer, lastFrameId As Integer)
			PluginTrimEndFrames(animationId, lastFrameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Trim the end of the animation. The length of the animation will be the lastFrameId 
		REM /// plus one. Reference the animation by name.
		REM /// </summary>
		Public Function TrimEndFramesName(path As String, lastFrameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginTrimEndFramesName(lp_Path, lastFrameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function TrimEndFramesNameD(path As String, lastFrameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginTrimEndFramesNameD(lp_Path, lastFrameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Remove the frame from the animation. Reference animation by id.
		REM /// </summary>
		Public Function TrimFrame(animationId As Integer, frameId As Integer)
			PluginTrimFrame(animationId, frameId)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Remove the frame from the animation. Reference animation by name.
		REM /// </summary>
		Public Function TrimFrameName(path As String, frameId As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginTrimFrameName(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function TrimFrameNameD(path As String, frameId As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginTrimFrameNameD(lp_Path, frameId)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Trim the start of the animation starting at frame 0 for the number of frames. 
		REM /// Reference the animation by id.
		REM /// </summary>
		Public Function TrimStartFrames(animationId As Integer, numberOfFrames As Integer)
			PluginTrimStartFrames(animationId, numberOfFrames)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Trim the start of the animation starting at frame 0 for the number of frames. 
		REM /// Reference the animation by name.
		REM /// </summary>
		Public Function TrimStartFramesName(path As String, numberOfFrames As Integer)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginTrimStartFramesName(lp_Path, numberOfFrames)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function TrimStartFramesNameD(path As String, numberOfFrames As Double) As Double
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Double = PluginTrimStartFramesNameD(lp_Path, numberOfFrames)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function Uninit() As Integer
			Dim result As Integer = PluginUninit()
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function UninitD() As Double
			Dim result As Double = PluginUninitD()
			Return result
		End Function

		REM /// <summary>
		REM /// Unloads `Chroma` effects to free up resources. Returns the animation id 
		REM /// upon success. Returns negative one upon failure. Reference the animation 
		REM /// by id.
		REM /// </summary>
		Public Function UnloadAnimation(animationId As Integer) As Integer
			Dim result As Integer = PluginUnloadAnimation(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// </summary>
		Public Function UnloadAnimationD(animationId As Double) As Double
			Dim result As Double = PluginUnloadAnimationD(animationId)
			Return result
		End Function

		REM /// <summary>
		REM /// Unload the animation effects. Reference the animation by name.
		REM /// </summary>
		Public Function UnloadAnimationName(path As String)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginUnloadAnimationName(lp_Path)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Unload the the composite set of animation effects. Reference the animation 
		REM /// by name.
		REM /// </summary>
		Public Function UnloadComposite(name As String)
			Dim str_Name As String = name
			Dim lp_Name As IntPtr = GetPathIntPtr(str_Name)
			PluginUnloadComposite(lp_Name)
			FreeIntPtr(lp_Name)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Unload the Razer Chroma SDK Library before exiting the application.
		REM /// </summary>
		Public Function UnloadLibrarySDK()
			PluginUnloadLibrarySDK()
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Unload the Razer Chroma Streaming Plugin Library before exiting the application. 
		REM ///
		REM /// </summary>
		Public Function UnloadLibraryStreamingPlugin()
			PluginUnloadLibraryStreamingPlugin()
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		REM /// (in seconds). The `color` is expected to be an array of the dimensions 
		REM /// for the `deviceType/device`. The `length` parameter is the size of the 
		REM /// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		REM /// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		REM /// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function UpdateFrame(animationId As Integer, frameIndex As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
			Dim result As Integer = PluginUpdateFrame(animationId, frameIndex, duration, colors, length)
			Return result
		End Function

		REM /// <summary>
		REM /// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		REM /// (in seconds). The `color` is expected to be an array of the dimensions 
		REM /// for the `deviceType/device`. The `length` parameter is the size of the 
		REM /// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		REM /// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		REM /// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// </summary>
		Public Function UpdateFrameName(path As String, frameIndex As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			Dim result As Integer = PluginUpdateFrameName(lp_Path, frameIndex, duration, colors, length)
			FreeIntPtr(lp_Path)
			Return result
		End Function

		REM /// <summary>
		REM /// When the idle animation flag is true, when no other animations are playing, 
		REM /// the idle animation will be used. The idle animation will not be affected 
		REM /// by the API calls to PluginIsPlaying, PluginStopAnimationType, PluginGetPlayingAnimationId, 
		REM /// and PluginGetPlayingAnimationCount. Then the idle animation flag is false, 
		REM /// the idle animation is disabled. `Device` uses `EChromaSDKDeviceEnum` enums. 
		REM ///
		REM /// </summary>
		Public Function UseIdleAnimation(device As Integer, flag As Boolean)
			PluginUseIdleAnimation(device, flag)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set idle animation flag for all devices.
		REM /// </summary>
		Public Function UseIdleAnimations(flag As Boolean)
			PluginUseIdleAnimations(flag)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set preloading animation flag, which is set to true by default. Reference 
		REM /// animation by id.
		REM /// </summary>
		Public Function UsePreloading(animationId As Integer, flag As Boolean)
			PluginUsePreloading(animationId, flag)
			Return Nothing
		End Function

		REM /// <summary>
		REM /// Set preloading animation flag, which is set to true by default. Reference 
		REM /// animation by name.
		REM /// </summary>
		Public Function UsePreloadingName(path As String, flag As Boolean)
			Dim str_Path As String = path
			Dim lp_Path As IntPtr = GetPathIntPtr(str_Path)
			PluginUsePreloadingName(lp_Path, flag)
			FreeIntPtr(lp_Path)
			Return Nothing
		End Function

		#End Region

		#Region "Private DLL Hooks"
		REM /// <summary>
		REM /// Return the sum of colors
		REM /// EXPORT_API int PluginAddColor(const int color1, const int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddColor(color1 As Integer, color2 As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Adds a frame to the `Chroma` animation and sets the `duration` (in seconds). 
		REM /// The `color` is expected to be an array of the dimensions for the `deviceType/device`. 
		REM /// The `length` parameter is the size of the `color` array. For `EChromaSDKDevice1DEnum` 
		REM /// the array size should be `MAX LEDS`. For `EChromaSDKDevice2DEnum` the array 
		REM /// size should be `MAX ROW` times `MAX COLUMN`. Returns the animation id upon 
		REM /// success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginAddFrame(int animationId, float duration, int* colors, int length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddFrame(animationId As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for frame id, reference 
		REM /// source and target by id.
		REM /// EXPORT_API void PluginAddNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames, reference 
		REM /// source and target by id.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames, reference 
		REM /// source and target by name.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames starting 
		REM /// at offset for the length of the source, reference source and target by 
		REM /// id.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for all frames starting 
		REM /// at offset for the length of the source, reference source and target by 
		REM /// name.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for frame id, reference 
		REM /// source and target by name.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for the source frame 
		REM /// and target offset frame, reference source and target by id.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where color is not black for the source frame 
		REM /// and target offset frame, reference source and target by name.
		REM /// EXPORT_API void PluginAddNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames, 
		REM /// reference source and target by id.
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames, 
		REM /// reference source and target by name.
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames 
		REM /// starting at offset for the length of the source, reference source and target 
		REM /// by id.
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where the target color is not black for all frames 
		REM /// starting at offset for the length of the source, reference source and target 
		REM /// by name.
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Add source color to target where target color is not blank from the source 
		REM /// frame to the target offset frame, reference source and target by id.
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Add source color to target where target color is not blank from the source 
		REM /// frame to the target offset frame, reference source and target by name. 
		REM ///
		REM /// EXPORT_API void PluginAddNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAddNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAddNonZeroTargetAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Append all source frames to the target animation, reference source and target 
		REM /// by id.
		REM /// EXPORT_API void PluginAppendAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAppendAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Append all source frames to the target animation, reference source and target 
		REM /// by name.
		REM /// EXPORT_API void PluginAppendAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAppendAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginAppendAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginAppendAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// `PluginClearAll` will issue a `CLEAR` effect for all devices.
		REM /// EXPORT_API void PluginClearAll();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginClearAll() As Boolean
		End Function

		REM /// <summary>
		REM /// `PluginClearAnimationType` will issue a `CLEAR` effect for the given device. 
		REM ///
		REM /// EXPORT_API void PluginClearAnimationType(int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginClearAnimationType(deviceType As Integer, device As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// `PluginCloseAll` closes all open animations so they can be reloaded from 
		REM /// disk. The set of animations will be stopped if playing.
		REM /// EXPORT_API void PluginCloseAll();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseAll() As Boolean
		End Function

		REM /// <summary>
		REM /// Closes the `Chroma` animation to free up resources referenced by id. Returns 
		REM /// the animation id upon success. Returns negative one upon failure. This 
		REM /// might be used while authoring effects if there was a change necessitating 
		REM /// re-opening the animation. The animation id can no longer be used once closed. 
		REM ///
		REM /// EXPORT_API int PluginCloseAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCloseAnimationD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseAnimationD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Closes the `Chroma` animation referenced by name so that the animation can 
		REM /// be reloaded from disk.
		REM /// EXPORT_API void PluginCloseAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCloseAnimationNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseAnimationNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// `PluginCloseComposite` closes a set of animations so they can be reloaded 
		REM /// from disk. The set of animations will be stopped if playing.
		REM /// EXPORT_API void PluginCloseComposite(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseComposite(name As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCloseCompositeD(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCloseCompositeD(name As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// EXPORT_API void PluginCopyAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// EXPORT_API void PluginCopyAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation to named target animation in memory. If target animation 
		REM /// exists, close first. Source is referenced by id.
		REM /// EXPORT_API int PluginCopyAnimation(int sourceAnimationId, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyAnimation(sourceAnimationId As Integer, targetAnimation As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// Copy animation to named target animation in memory. If target animation 
		REM /// exists, close first. Source is referenced by name.
		REM /// EXPORT_API void PluginCopyAnimationName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyAnimationName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyAnimationNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyAnimationNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by id.
		REM /// EXPORT_API void PluginCopyBlueChannelAllFrames(int animationId, float redIntensity, float greenIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyBlueChannelAllFrames(animationId As Integer, redIntensity As Single, greenIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy blue channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by name.
		REM /// EXPORT_API void PluginCopyBlueChannelAllFramesName(const char* path, float redIntensity, float greenIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyBlueChannelAllFramesName(path As IntPtr, redIntensity As Single, greenIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyBlueChannelAllFramesNameD(const char* path, double redIntensity, double greenIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyBlueChannelAllFramesNameD(path As IntPtr, redIntensity As Double, greenIntensity As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by id.
		REM /// EXPORT_API void PluginCopyGreenChannelAllFrames(int animationId, float redIntensity, float blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyGreenChannelAllFrames(animationId As Integer, redIntensity As Single, blueIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by name.
		REM /// EXPORT_API void PluginCopyGreenChannelAllFramesName(const char* path, float redIntensity, float blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyGreenChannelAllFramesName(path As IntPtr, redIntensity As Single, blueIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyGreenChannelAllFramesNameD(const char* path, double redIntensity, double blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyGreenChannelAllFramesNameD(path As IntPtr, redIntensity As Double, blueIntensity As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame. Reference the source and target by id.
		REM /// EXPORT_API void PluginCopyKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames. Reference the source and target by id.
		REM /// EXPORT_API void PluginCopyKeyColorAllFrames(int sourceAnimationId, int targetAnimationId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames. Reference the source and target by name.
		REM /// EXPORT_API void PluginCopyKeyColorAllFramesName(const char* sourceAnimation, const char* targetAnimation, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyKeyColorAllFramesNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, rzkey As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames, starting at the offset for the length of the source animation. 
		REM /// Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyKeyColorAllFramesOffset(int sourceAnimationId, int targetAnimationId, int rzkey, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, rzkey As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for all frames, starting at the offset for the length of the source animation. 
		REM /// Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyKeyColorAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int rzkey, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, rzkey As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyKeyColorAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double rzkey, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, rzkey As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame.
		REM /// EXPORT_API void PluginCopyKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeyColorNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, rzkey As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for the given frame. Reference the source and target by 
		REM /// id.
		REM /// EXPORT_API void PluginCopyKeysColor(int sourceAnimationId, int targetAnimationId, int frameId, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for all frames. Reference the source and target by id. 
		REM ///
		REM /// EXPORT_API void PluginCopyKeysColorAllFrames(int sourceAnimationId, int targetAnimationId, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColorAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for all frames. Reference the source and target by name. 
		REM ///
		REM /// EXPORT_API void PluginCopyKeysColorAllFramesName(const char* sourceAnimation, const char* targetAnimation, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColorAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation for the given frame. Reference the source and target by 
		REM /// name.
		REM /// EXPORT_API void PluginCopyKeysColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColorName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation from the source frame to the target frame. Reference the 
		REM /// source and target by id.
		REM /// EXPORT_API void PluginCopyKeysColorOffset(int sourceAnimationId, int targetAnimationId, int sourceFrameId, int targetFrameId, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColorOffset(sourceAnimationId As Integer, targetAnimationId As Integer, sourceFrameId As Integer, targetFrameId As Integer, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation color for a set of keys from the source animation to the 
		REM /// target animation from the source frame to the target frame. Reference the 
		REM /// source and target by name.
		REM /// EXPORT_API void PluginCopyKeysColorOffsetName(const char* sourceAnimation, const char* targetAnimation, int sourceFrameId, int targetFrameId, const int* keys, int size);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyKeysColorOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, sourceFrameId As Integer, targetFrameId As Integer, keys As Integer(), size As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy source animation to target animation for the given frame. Source and 
		REM /// target are referenced by id.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames. Reference source and target by id.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames. Reference source and target by name.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames starting at the offset for the length of the source animation. The 
		REM /// source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from a source animation to a target animation for all 
		REM /// frames starting at the offset for the length of the source animation. The 
		REM /// source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation from 
		REM /// the source frame to the target offset frame. Source and target are referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation from 
		REM /// the source frame to the target offset frame. Source and target are referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginCopyNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame where color is not zero.
		REM /// EXPORT_API void PluginCopyNonZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy animation key color from the source animation to the target animation 
		REM /// for the given frame where color is not zero.
		REM /// EXPORT_API void PluginCopyNonZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroKeyColorName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroKeyColorNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, rzkey As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified frame. Source and target 
		REM /// are referenced by id.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for all frames starting at the target offset 
		REM /// for the length of the source animation. Source and target animations are 
		REM /// referenced by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified frame. The source and target 
		REM /// are referenced by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroTargetAllKeysNameD(const char* sourceAnimation, const char* targetAnimation, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified source frame and target offset 
		REM /// frame. The source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is nonzero for the specified source frame and target offset 
		REM /// frame. The source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is zero for all frames. Source and target are referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginCopyNonZeroTargetZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero colors from the source animation to the target animation where 
		REM /// the target color is zero for all frames. Source and target are referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginCopyNonZeroTargetZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetZeroAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyNonZeroTargetZeroAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy red channel to other channels for all frames. Intensity range is 0.0 
		REM /// to 1.0. Reference the animation by id.
		REM /// EXPORT_API void PluginCopyRedChannelAllFrames(int animationId, float greenIntensity, float blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyRedChannelAllFrames(animationId As Integer, greenIntensity As Single, blueIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy green channel to other channels for all frames. Intensity range is 
		REM /// 0.0 to 1.0. Reference the animation by name.
		REM /// EXPORT_API void PluginCopyRedChannelAllFramesName(const char* path, float greenIntensity, float blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyRedChannelAllFramesName(path As IntPtr, greenIntensity As Single, blueIntensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyRedChannelAllFramesNameD(const char* path, double greenIntensity, double blueIntensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyRedChannelAllFramesNameD(path As IntPtr, greenIntensity As Double, blueIntensity As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame. 
		REM /// Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames. 
		REM /// Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames. 
		REM /// Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames 
		REM /// starting at the target offset for the length of the source animation. Source 
		REM /// and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for all frames 
		REM /// starting at the target offset for the length of the source animation. Source 
		REM /// and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame. 
		REM /// Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame 
		REM /// id starting at the target offset for the length of the source animation. 
		REM /// Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero colors from source animation to target animation for the frame 
		REM /// id starting at the target offset for the length of the source animation. 
		REM /// Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero key color from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroKeyColor(int sourceAnimationId, int targetAnimationId, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroKeyColor(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy zero key color from source animation to target animation for the specified 
		REM /// frame. Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroKeyColorName(const char* sourceAnimation, const char* targetAnimation, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroKeyColorName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, rzkey As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyZeroKeyColorNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroKeyColorNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, rzkey As Double) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for the frame. Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroTargetAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroTargetAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for all frames. Source and target are referenced by id.
		REM /// EXPORT_API void PluginCopyZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for all frames. Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroTargetAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginCopyZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroTargetAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Copy nonzero color from source animation to target animation where target 
		REM /// is zero for the frame. Source and target are referenced by name.
		REM /// EXPORT_API void PluginCopyZeroTargetAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCopyZeroTargetAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateChromaLinkEffect(ChromaSDK::ChromaLink::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateChromaLinkEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateEffect(RZDEVICEID DeviceId, ChromaSDK::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateEffect(deviceId As Guid, effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateHeadsetEffect(ChromaSDK::Headset::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateHeadsetEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateKeyboardEffect(ChromaSDK::Keyboard::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateKeyboardEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateKeypadEffect(ChromaSDK::Keypad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateKeypadEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateMouseEffect(ChromaSDK::Mouse::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateMouseEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreCreateMousepadEffect(ChromaSDK::Mousepad::EFFECT_TYPE Effect, PRZPARAM pParam, RZEFFECTID* pEffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreCreateMousepadEffect(effect As Integer, pParam As IntPtr, ByRef pEffectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreDeleteEffect(RZEFFECTID EffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreDeleteEffect(effectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreInit();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreInit() As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreInitSDK(ChromaSDK::APPINFOTYPE* AppInfo);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreInitSDK(ByRef appInfo As ChromaSDK.APPINFOTYPE) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreQueryDevice(RZDEVICEID DeviceId, ChromaSDK::DEVICE_INFO_TYPE& DeviceInfo);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreQueryDevice(deviceId As Guid, ByRef deviceInfo As DEVICE_INFO_TYPE) As Integer
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreSetEffect(RZEFFECTID EffectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreSetEffect(effectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Begin broadcasting Chroma RGB data using the stored stream key as the endpoint. 
		REM /// Intended for Cloud Gaming Platforms,  restore the streaming key when the 
		REM /// game instance is launched to continue streaming.  streamId is a null terminated 
		REM /// string  streamKey is a null terminated string  StreamGetStatus() should 
		REM /// return the READY status to use this method.
		REM /// EXPORT_API bool PluginCoreStreamBroadcast(const char* streamId, const char* streamKey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamBroadcast(streamId As IntPtr, streamKey As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// End broadcasting Chroma RGB data.  StreamGetStatus() should return the BROADCASTING 
		REM /// status to use this method.
		REM /// EXPORT_API bool PluginCoreStreamBroadcastEnd();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamBroadcastEnd() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// shortcode: Pass the address of a preallocated character buffer to get the 
		REM /// streaming auth code. The buffer should have a minimum length of 6.  length: 
		REM /// Length will return as zero if the streaming auth code could not be obtained. 
		REM /// If length is greater than zero, it will be the length of the returned streaming 
		REM /// auth code.  Once you have the shortcode, it should be shown to the user 
		REM /// so they can associate the stream with their Razer ID  StreamGetStatus() 
		REM /// should return the READY status before invoking this method. platform: is 
		REM /// the null terminated string that identifies the source of the stream: { 
		REM /// GEFORCE_NOW, LUNA, STADIA, GAME_PASS } title: is the null terminated string 
		REM /// that identifies the application or game.
		REM /// EXPORT_API void PluginCoreStreamGetAuthShortcode(char* shortcode, unsigned char* length, const wchar_t* platform, const wchar_t* title);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetAuthShortcode(shortcode As IntPtr, ByRef length As byte, platform As IntPtr, title As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// focus: Pass the address of a preallocated character buffer to get the stream 
		REM /// focus. The buffer should have a length of 48  length: Length will return 
		REM /// as zero if the stream focus could not be obtained. If length is greater 
		REM /// than zero, it will be the length of the returned stream focus.
		REM /// EXPORT_API bool PluginCoreStreamGetFocus(char* focus, unsigned char* length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetFocus(focus As IntPtr, ByRef length As byte) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Intended for Cloud Gaming Platforms, store the stream id to persist in user 
		REM /// preferences to continue streaming if the game is suspended or closed. shortcode: 
		REM /// The shortcode is a null terminated string. Use the shortcode that authorized 
		REM /// the stream to obtain the stream id.  streamId should be a preallocated 
		REM /// buffer to get the stream key. The buffer should have a length of 48.  length: 
		REM /// Length will return zero if the key could not be obtained. If the length 
		REM /// is greater than zero, it will be the length of the returned streaming id. 
		REM /// Retrieve the stream id after authorizing the shortcode. The authorization 
		REM /// window will expire in 5 minutes. Be sure to save the stream key before 
		REM /// the window expires. StreamGetStatus() should return the READY status to 
		REM /// use this method.
		REM /// EXPORT_API void PluginCoreStreamGetId(const char* shortcode, char* streamId, unsigned char* length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetId(shortcode As IntPtr, streamId As IntPtr, ByRef length As byte) As Boolean
		End Function

		REM /// <summary>
		REM /// Intended for Cloud Gaming Platforms, store the streaming key to persist 
		REM /// in user preferences to continue streaming if the game is suspended or closed. 
		REM /// shortcode: The shortcode is a null terminated string. Use the shortcode 
		REM /// that authorized the stream to obtain the stream key.  If the status is 
		REM /// in the BROADCASTING or WATCHING state, passing a NULL shortcode will return 
		REM /// the active streamId.  streamKey should be a preallocated buffer to get 
		REM /// the stream key. The buffer should have a length of 48.  length: Length 
		REM /// will return zero if the key could not be obtained. If the length is greater 
		REM /// than zero, it will be the length of the returned streaming key.  Retrieve 
		REM /// the stream key after authorizing the shortcode. The authorization window 
		REM /// will expire in 5 minutes. Be sure to save the stream key before the window 
		REM /// expires.  StreamGetStatus() should return the READY status to use this 
		REM /// method.
		REM /// EXPORT_API void PluginCoreStreamGetKey(const char* shortcode, char* streamKey, unsigned char* length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetKey(shortcode As IntPtr, streamKey As IntPtr, ByRef length As byte) As Boolean
		End Function

		REM /// <summary>
		REM /// Returns StreamStatus, the current status of the service
		REM /// EXPORT_API ChromaSDK::Stream::StreamStatusType PluginCoreStreamGetStatus();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetStatus() As ChromaSDK.Stream.StreamStatusType
		End Function

		REM /// <summary>
		REM /// Convert StreamStatusType to a printable string
		REM /// EXPORT_API const char* PluginCoreStreamGetStatusString(ChromaSDK::Stream::StreamStatusType status);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamGetStatusString(status As ChromaSDK.Stream.StreamStatusType) As IntPtr
		End Function

		REM /// <summary>
		REM /// This prevents the stream id and stream key from being obtained through the 
		REM /// shortcode. This closes the auth window.  shortcode is a null terminated 
		REM /// string.  StreamGetStatus() should return the READY status to use this method. 
		REM /// returns success when shortcode has been released
		REM /// EXPORT_API bool PluginCoreStreamReleaseShortcode(const char* shortcode);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamReleaseShortcode(shortcode As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// The focus is a null terminated string. Set the focus identifer for the application 
		REM /// designated to automatically change the streaming state.  Returns true on 
		REM /// success.
		REM /// EXPORT_API bool PluginCoreStreamSetFocus(const char* focus);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamSetFocus(focus As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Returns true if the Chroma streaming is supported. If false is returned, 
		REM /// avoid calling stream methods.
		REM /// EXPORT_API bool PluginCoreStreamSupportsStreaming();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamSupportsStreaming() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Begin watching the Chroma RGB data using streamID parameter.  streamId is 
		REM /// a null terminated string.  StreamGetStatus() should return the READY status 
		REM /// to use this method.
		REM /// EXPORT_API bool PluginCoreStreamWatch(const char* streamId, unsigned long long timestamp);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamWatch(streamId As IntPtr, timestamp As ulong) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// End watching Chroma RGB data stream.  StreamGetStatus() should return the 
		REM /// WATCHING status to use this method.
		REM /// EXPORT_API bool PluginCoreStreamWatchEnd();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreStreamWatchEnd() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Direct access to low level API.
		REM /// EXPORT_API RZRESULT PluginCoreUnInit();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCoreUnInit() As Integer
		End Function

		REM /// <summary>
		REM /// Creates a `Chroma` animation at the given path. The `deviceType` parameter 
		REM /// uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter uses 
		REM /// `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, respective 
		REM /// to the `deviceType`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure. Saves a `Chroma` animation file with the `.chroma` extension 
		REM /// at the given path. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API int PluginCreateAnimation(const char* path, int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCreateAnimation(path As IntPtr, deviceType As Integer, device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Creates a `Chroma` animation in memory without creating a file. The `deviceType` 
		REM /// parameter uses `EChromaSDKDeviceTypeEnum` as an integer. The `device` parameter 
		REM /// uses `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` as an integer, 
		REM /// respective to the `deviceType`. Returns the animation id upon success. 
		REM /// Returns negative one upon failure. Returns the animation id upon success. 
		REM /// Returns negative one upon failure.
		REM /// EXPORT_API int PluginCreateAnimationInMemory(int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCreateAnimationInMemory(deviceType As Integer, device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Create a device specific effect.
		REM /// EXPORT_API RZRESULT PluginCreateEffect(RZDEVICEID deviceId, ChromaSDK::EFFECT_TYPE effect, int* colors, int size, ChromaSDK::FChromaSDKGuid* effectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginCreateEffect(deviceId As Guid, effect As Integer, colors As Integer(), size As Integer, ByRef effectId As FChromaSDKGuid) As Integer
		End Function

		REM /// <summary>
		REM /// Delete an effect given the effect id.
		REM /// EXPORT_API RZRESULT PluginDeleteEffect(const ChromaSDK::FChromaSDKGuid& effectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDeleteEffect(effectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// Duplicate the first animation frame so that the animation length matches 
		REM /// the frame count. Animation is referenced by id.
		REM /// EXPORT_API void PluginDuplicateFirstFrame(int animationId, int frameCount);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFirstFrame(animationId As Integer, frameCount As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Duplicate the first animation frame so that the animation length matches 
		REM /// the frame count. Animation is referenced by name.
		REM /// EXPORT_API void PluginDuplicateFirstFrameName(const char* path, int frameCount);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFirstFrameName(path As IntPtr, frameCount As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginDuplicateFirstFrameNameD(const char* path, double frameCount);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFirstFrameNameD(path As IntPtr, frameCount As Double) As Double
		End Function

		REM /// <summary>
		REM /// Duplicate all the frames of the animation to double the animation length. 
		REM /// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		REM /// The animation is referenced by id.
		REM /// EXPORT_API void PluginDuplicateFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Duplicate all the frames of the animation to double the animation length. 
		REM /// Frame 1 becomes frame 1 and 2. Frame 2 becomes frame 3 and 4. And so on. 
		REM /// The animation is referenced by name.
		REM /// EXPORT_API void PluginDuplicateFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginDuplicateFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Duplicate all the animation frames in reverse so that the animation plays 
		REM /// forwards and backwards. Animation is referenced by id.
		REM /// EXPORT_API void PluginDuplicateMirrorFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateMirrorFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Duplicate all the animation frames in reverse so that the animation plays 
		REM /// forwards and backwards. Animation is referenced by name.
		REM /// EXPORT_API void PluginDuplicateMirrorFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateMirrorFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginDuplicateMirrorFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginDuplicateMirrorFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Fade the animation to black starting at the fade frame index to the end 
		REM /// of the animation. Animation is referenced by id.
		REM /// EXPORT_API void PluginFadeEndFrames(int animationId, int fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeEndFrames(animationId As Integer, fade As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fade the animation to black starting at the fade frame index to the end 
		REM /// of the animation. Animation is referenced by name.
		REM /// EXPORT_API void PluginFadeEndFramesName(const char* path, int fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeEndFramesName(path As IntPtr, fade As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFadeEndFramesNameD(const char* path, double fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeEndFramesNameD(path As IntPtr, fade As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fade the animation from black to full color starting at 0 to the fade frame 
		REM /// index. Animation is referenced by id.
		REM /// EXPORT_API void PluginFadeStartFrames(int animationId, int fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeStartFrames(animationId As Integer, fade As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fade the animation from black to full color starting at 0 to the fade frame 
		REM /// index. Animation is referenced by name.
		REM /// EXPORT_API void PluginFadeStartFramesName(const char* path, int fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeStartFramesName(path As IntPtr, fade As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFadeStartFramesNameD(const char* path, double fade);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFadeStartFramesNameD(path As IntPtr, fade As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginFillColor(int animationId, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColor(animationId As Integer, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginFillColorAllFrames(int animationId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFrames(animationId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginFillColorAllFramesName(const char* path, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFramesName(path As IntPtr, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillColorAllFramesNameD(const char* path, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFramesNameD(path As IntPtr, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		REM /// for red, green, and blue parameters. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillColorAllFramesRGB(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors for all frames. Use the range of 0 to 255 
		REM /// for red, green, and blue parameters. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillColorAllFramesRGBName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFramesRGBName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorAllFramesRGBNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginFillColorName(const char* path, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorName(path As IntPtr, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillColorNameD(const char* path, double frameId, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorNameD(path As IntPtr, frameId As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginFillColorRGB(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the RGB value for all colors in the specified frame. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginFillColorRGBName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorRGBName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillColorRGBNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillNonZeroColor(int animationId, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColor(animationId As Integer, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Animation is referenced by id.
		REM /// EXPORT_API void PluginFillNonZeroColorAllFrames(int animationId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFrames(animationId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Animation is referenced by name.
		REM /// EXPORT_API void PluginFillNonZeroColorAllFramesName(const char* path, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFramesName(path As IntPtr, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillNonZeroColorAllFramesNameD(const char* path, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFramesNameD(path As IntPtr, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginFillNonZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors for all frames. 
		REM /// Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginFillNonZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFramesRGBName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillNonZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorAllFramesRGBNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillNonZeroColorName(const char* path, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorName(path As IntPtr, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillNonZeroColorNameD(const char* path, double frameId, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorNameD(path As IntPtr, frameId As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginFillNonZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Set the RGB value for a subset of colors in the specified 
		REM /// frame. Use the range of 0 to 255 for red, green, and blue parameters. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginFillNonZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorRGBName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillNonZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillNonZeroColorRGBNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for the given frame. Animation is 
		REM /// referenced by id.
		REM /// EXPORT_API void PluginFillRandomColors(int animationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColors(animationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for all frames. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginFillRandomColorsAllFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsAllFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for all frames. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginFillRandomColorsAllFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsAllFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillRandomColorsAllFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsAllFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for the specified frame. 
		REM /// Animation is referenced by id.
		REM /// EXPORT_API void PluginFillRandomColorsBlackAndWhite(int animationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhite(animationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for all frames. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhiteAllFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for all frames. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginFillRandomColorsBlackAndWhiteAllFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhiteAllFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillRandomColorsBlackAndWhiteAllFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhiteAllFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Fill the frame with random black and white values for the specified frame. 
		REM /// Animation is referenced by name.
		REM /// EXPORT_API void PluginFillRandomColorsBlackAndWhiteName(const char* path, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhiteName(path As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillRandomColorsBlackAndWhiteNameD(const char* path, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsBlackAndWhiteNameD(path As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the frame with random RGB values for the given frame. Animation is 
		REM /// referenced by name.
		REM /// EXPORT_API void PluginFillRandomColorsName(const char* path, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsName(path As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillRandomColorsNameD(const char* path, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillRandomColorsNameD(path As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColors(int animationId, int frameId, int threshold, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColors(animationId As Integer, frameId As Integer, threshold As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColorsAllFrames(int animationId, int threshold, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFrames(animationId As Integer, threshold As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsAllFramesName(const char* path, int threshold, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFramesName(path As IntPtr, threshold As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsAllFramesNameD(const char* path, double threshold, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFramesNameD(path As IntPtr, threshold As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColorsAllFramesRGB(int animationId, int threshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFramesRGB(animationId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsAllFramesRGBName(const char* path, int threshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFramesRGBName(path As IntPtr, threshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsAllFramesRGBNameD(const char* path, double threshold, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsAllFramesRGBNameD(path As IntPtr, threshold As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill all frames with the min RGB color where the animation color is less 
		REM /// than the min threshold AND with the max RGB color where the animation is 
		REM /// more than the max threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGB(int animationId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxAllFramesRGB(animationId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with the min RGB color where the animation color is less 
		REM /// than the min threshold AND with the max RGB color where the animation is 
		REM /// more than the max threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsMinMaxAllFramesRGBName(const char* path, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxAllFramesRGBName(path As IntPtr, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsMinMaxAllFramesRGBNameD(const char* path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxAllFramesRGBNameD(path As IntPtr, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with the min RGB color where the animation color 
		REM /// is less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColorsMinMaxRGB(int animationId, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxRGB(animationId As Integer, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with the min RGB color where the animation color 
		REM /// is less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsMinMaxRGBName(const char* path, int frameId, int minThreshold, int minRed, int minGreen, int minBlue, int maxThreshold, int maxRed, int maxGreen, int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxRGBName(path As IntPtr, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsMinMaxRGBNameD(const char* path, double frameId, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsMinMaxRGBNameD(path As IntPtr, frameId As Double, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsName(const char* path, int frameId, int threshold, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsName(path As IntPtr, frameId As Integer, threshold As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsNameD(const char* path, double frameId, double threshold, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsNameD(path As IntPtr, frameId As Double, threshold As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdColorsRGB(int animationId, int frameId, int threshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsRGB(animationId As Integer, frameId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdColorsRGBName(const char* path, int frameId, int threshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsRGBName(path As IntPtr, frameId As Integer, threshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdColorsRGBNameD(const char* path, double frameId, double threshold, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdColorsRGBNameD(path As IntPtr, frameId As Double, threshold As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGB(int animationId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsAllFramesRGB(animationId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is less than the 
		REM /// RGB threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdRGBColorsAllFramesRGBName(const char* path, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsAllFramesRGBName(path As IntPtr, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdRGBColorsAllFramesRGBNameD(const char* path, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsAllFramesRGBNameD(path As IntPtr, redThreshold As Double, greenThreshold As Double, blueThreshold As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginFillThresholdRGBColorsRGB(int animationId, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsRGB(animationId As Integer, frameId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is less 
		REM /// than the RGB threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginFillThresholdRGBColorsRGBName(const char* path, int frameId, int redThreshold, int greenThreshold, int blueThreshold, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsRGBName(path As IntPtr, frameId As Integer, redThreshold As Integer, greenThreshold As Integer, blueThreshold As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillThresholdRGBColorsRGBNameD(const char* path, double frameId, double redThreshold, double greenThreshold, double blueThreshold, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillThresholdRGBColorsRGBNameD(path As IntPtr, frameId As Double, redThreshold As Double, greenThreshold As Double, blueThreshold As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by id.
		REM /// EXPORT_API void PluginFillZeroColor(int animationId, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColor(animationId As Integer, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginFillZeroColorAllFrames(int animationId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFrames(animationId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginFillZeroColorAllFramesName(const char* path, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFramesName(path As IntPtr, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillZeroColorAllFramesNameD(const char* path, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFramesNameD(path As IntPtr, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginFillZeroColorAllFramesRGB(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill all frames with RGB color where the animation color is zero. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginFillZeroColorAllFramesRGBName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFramesRGBName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillZeroColorAllFramesRGBNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorAllFramesRGBNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by name.
		REM /// EXPORT_API void PluginFillZeroColorName(const char* path, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorName(path As IntPtr, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillZeroColorNameD(const char* path, double frameId, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorNameD(path As IntPtr, frameId As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by id.
		REM /// EXPORT_API void PluginFillZeroColorRGB(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Fill the specified frame with RGB color where the animation color is zero. 
		REM /// Animation is referenced by name.
		REM /// EXPORT_API void PluginFillZeroColorRGBName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorRGBName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginFillZeroColorRGBNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginFillZeroColorRGBNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		REM /// referenced by id.
		REM /// EXPORT_API int PluginGet1DColor(int animationId, int frameId, int led);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet1DColor(animationId As Integer, frameId As Integer, led As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. Animation is 
		REM /// referenced by name.
		REM /// EXPORT_API int PluginGet1DColorName(const char* path, int frameId, int led);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet1DColorName(path As IntPtr, frameId As Integer, led As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGet1DColorNameD(const char* path, double frameId, double led);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet1DColorNameD(path As IntPtr, frameId As Double, led As Double) As Double
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// Animation is referenced by id.
		REM /// EXPORT_API int PluginGet2DColor(int animationId, int frameId, int row, int column);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet2DColor(animationId As Integer, frameId As Integer, row As Integer, column As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Get the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// Animation is referenced by name.
		REM /// EXPORT_API int PluginGet2DColorName(const char* path, int frameId, int row, int column);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet2DColorName(path As IntPtr, frameId As Integer, row As Integer, column As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGet2DColorNameD(const char* path, double frameId, double row, double column);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGet2DColorNameD(path As IntPtr, frameId As Double, row As Double, column As Double) As Double
		End Function

		REM /// <summary>
		REM /// Get the animation id for the named animation.
		REM /// EXPORT_API int PluginGetAnimation(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetAnimation(name As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationCount` will return the number of loaded animations.
		REM /// EXPORT_API int PluginGetAnimationCount();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetAnimationCount() As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetAnimationD(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetAnimationD(name As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationId` will return the `animationId` given the `index` of 
		REM /// the loaded animation. The `index` is zero-based and less than the number 
		REM /// returned by `PluginGetAnimationCount`. Use `PluginGetAnimationName` to 
		REM /// get the name of the animation.
		REM /// EXPORT_API int PluginGetAnimationId(int index);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetAnimationId(index As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// `PluginGetAnimationName` takes an `animationId` and returns the name of 
		REM /// the animation of the `.chroma` animation file. If a name is not available 
		REM /// then an empty string will be returned.
		REM /// EXPORT_API const char* PluginGetAnimationName(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetAnimationName(animationId As Integer) As IntPtr
		End Function

		REM /// <summary>
		REM /// Get the current frame of the animation referenced by id.
		REM /// EXPORT_API int PluginGetCurrentFrame(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetCurrentFrame(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Get the current frame of the animation referenced by name.
		REM /// EXPORT_API int PluginGetCurrentFrameName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetCurrentFrameName(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetCurrentFrameNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetCurrentFrameNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		REM /// animation respective to the `deviceType`, as an integer upon success. Returns 
		REM /// negative one upon failure.
		REM /// EXPORT_API int PluginGetDevice(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDevice(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDevice1DEnum` or `EChromaSDKDevice2DEnum` of a `Chroma` 
		REM /// animation respective to the `deviceType`, as an integer upon success. Returns 
		REM /// negative one upon failure.
		REM /// EXPORT_API int PluginGetDeviceName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDeviceName(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetDeviceNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDeviceNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginGetDeviceType(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDeviceType(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Returns the `EChromaSDKDeviceTypeEnum` of a `Chroma` animation as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginGetDeviceTypeName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDeviceTypeName(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetDeviceTypeNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetDeviceTypeNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Gets the frame colors and duration (in seconds) for a `Chroma` animation. 
		REM /// The `color` is expected to be an array of the expected dimensions for the 
		REM /// `deviceType/device`. The `length` parameter is the size of the `color` 
		REM /// array. For `EChromaSDKDevice1DEnum` the array size should be `MAX LEDS`. 
		REM /// For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` * `MAX 
		REM /// COLUMN`. Returns the animation id upon success. Returns negative one upon 
		REM /// failure.
		REM /// EXPORT_API int PluginGetFrame(int animationId, int frameIndex, float* duration, int* colors, int length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetFrame(animationId As Integer, frameIndex As Integer, ByRef duration As Single, colors As Integer(), length As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API int PluginGetFrameCount(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetFrameCount(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Returns the frame count of a `Chroma` animation upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API int PluginGetFrameCountName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetFrameCountName(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetFrameCountNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetFrameCountNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Get the color of an animation key for the given frame referenced by id. 
		REM ///
		REM /// EXPORT_API int PluginGetKeyColor(int animationId, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetKeyColor(animationId As Integer, frameId As Integer, rzkey As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetKeyColorD(const char* path, double frameId, double rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetKeyColorD(path As IntPtr, frameId As Double, rzkey As Double) As Double
		End Function

		REM /// <summary>
		REM /// Get the color of an animation key for the given frame referenced by name. 
		REM ///
		REM /// EXPORT_API int PluginGetKeyColorName(const char* path, int frameId, int rzkey);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetKeyColorName(path As IntPtr, frameId As Integer, rzkey As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Returns `RZRESULT_SUCCESS` if the plugin has been initialized successfully. 
		REM /// Returns `RZRESULT_DLL_NOT_FOUND` if core Chroma library is not found. Returns 
		REM /// `RZRESULT_DLL_INVALID_SIGNATURE` if core Chroma library has an invalid 
		REM /// signature.
		REM /// EXPORT_API RZRESULT PluginGetLibraryLoadedState();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetLibraryLoadedState() As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetLibraryLoadedStateD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetLibraryLoadedStateD() As Double
		End Function

		REM /// <summary>
		REM /// Returns the `MAX COLUMN` given the `EChromaSDKDevice2DEnum` device as an 
		REM /// integer upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginGetMaxColumn(int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxColumn(device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetMaxColumnD(double device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxColumnD(device As Double) As Double
		End Function

		REM /// <summary>
		REM /// Returns the MAX LEDS given the `EChromaSDKDevice1DEnum` device as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginGetMaxLeds(int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxLeds(device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetMaxLedsD(double device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxLedsD(device As Double) As Double
		End Function

		REM /// <summary>
		REM /// Returns the `MAX ROW` given the `EChromaSDKDevice2DEnum` device as an integer 
		REM /// upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginGetMaxRow(int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxRow(device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetMaxRowD(double device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetMaxRowD(device As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginGetPlayingAnimationCount` will return the number of playing animations. 
		REM ///
		REM /// EXPORT_API int PluginGetPlayingAnimationCount();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetPlayingAnimationCount() As Integer
		End Function

		REM /// <summary>
		REM /// `PluginGetPlayingAnimationId` will return the `animationId` given the `index` 
		REM /// of the playing animation. The `index` is zero-based and less than the number 
		REM /// returned by `PluginGetPlayingAnimationCount`. Use `PluginGetAnimationName` 
		REM /// to get the name of the animation.
		REM /// EXPORT_API int PluginGetPlayingAnimationId(int index);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetPlayingAnimationId(index As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Get the RGB color given red, green, and blue.
		REM /// EXPORT_API int PluginGetRGB(int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetRGB(red As Integer, green As Integer, blue As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginGetRGBD(double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginGetRGBD(red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Check if the animation has loop enabled referenced by id.
		REM /// EXPORT_API bool PluginHasAnimationLoop(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginHasAnimationLoop(animationId As Integer) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Check if the animation has loop enabled referenced by name.
		REM /// EXPORT_API bool PluginHasAnimationLoopName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginHasAnimationLoopName(path As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginHasAnimationLoopNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginHasAnimationLoopNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Initialize the ChromaSDK. Zero indicates  success, otherwise failure. Many 
		REM /// API methods auto initialize the ChromaSDK if not already initialized.
		REM /// EXPORT_API RZRESULT PluginInit();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInit() As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginInitD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInitD() As Double
		End Function

		REM /// <summary>
		REM /// Initialize the ChromaSDK. AppInfo populates the details in Synapse. Zero 
		REM /// indicates  success, otherwise failure. Many API methods auto initialize 
		REM /// the ChromaSDK if not already initialized.
		REM /// EXPORT_API RZRESULT PluginInitSDK(ChromaSDK::APPINFOTYPE* AppInfo);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInitSDK(ByRef appInfo As ChromaSDK.APPINFOTYPE) As Integer
		End Function

		REM /// <summary>
		REM /// Insert an animation delay by duplicating the frame by the delay number of 
		REM /// times. Animation is referenced by id.
		REM /// EXPORT_API void PluginInsertDelay(int animationId, int frameId, int delay);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertDelay(animationId As Integer, frameId As Integer, delay As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Insert an animation delay by duplicating the frame by the delay number of 
		REM /// times. Animation is referenced by name.
		REM /// EXPORT_API void PluginInsertDelayName(const char* path, int frameId, int delay);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertDelayName(path As IntPtr, frameId As Integer, delay As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginInsertDelayNameD(const char* path, double frameId, double delay);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertDelayNameD(path As IntPtr, frameId As Double, delay As Double) As Double
		End Function

		REM /// <summary>
		REM /// Duplicate the source frame index at the target frame index. Animation is 
		REM /// referenced by id.
		REM /// EXPORT_API void PluginInsertFrame(int animationId, int sourceFrame, int targetFrame);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertFrame(animationId As Integer, sourceFrame As Integer, targetFrame As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Duplicate the source frame index at the target frame index. Animation is 
		REM /// referenced by name.
		REM /// EXPORT_API void PluginInsertFrameName(const char* path, int sourceFrame, int targetFrame);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertFrameName(path As IntPtr, sourceFrame As Integer, targetFrame As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginInsertFrameNameD(const char* path, double sourceFrame, double targetFrame);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInsertFrameNameD(path As IntPtr, sourceFrame As Double, targetFrame As Double) As Double
		End Function

		REM /// <summary>
		REM /// Invert all the colors at the specified frame. Animation is referenced by 
		REM /// id.
		REM /// EXPORT_API void PluginInvertColors(int animationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColors(animationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Invert all the colors for all frames. Animation is referenced by id.
		REM /// EXPORT_API void PluginInvertColorsAllFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColorsAllFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Invert all the colors for all frames. Animation is referenced by name.
		REM /// EXPORT_API void PluginInvertColorsAllFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColorsAllFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginInvertColorsAllFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColorsAllFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Invert all the colors at the specified frame. Animation is referenced by 
		REM /// name.
		REM /// EXPORT_API void PluginInvertColorsName(const char* path, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColorsName(path As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginInvertColorsNameD(const char* path, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginInvertColorsNameD(path As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Check if the animation is paused referenced by id.
		REM /// EXPORT_API bool PluginIsAnimationPaused(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsAnimationPaused(animationId As Integer) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// Check if the animation is paused referenced by name.
		REM /// EXPORT_API bool PluginIsAnimationPausedName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsAnimationPausedName(path As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsAnimationPausedNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsAnimationPausedNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// The editor dialog is a non-blocking modal window, this method returns true 
		REM /// if the modal window is open, otherwise false.
		REM /// EXPORT_API bool PluginIsDialogOpen();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsDialogOpen() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsDialogOpenD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsDialogOpenD() As Double
		End Function

		REM /// <summary>
		REM /// Returns true if the plugin has been initialized. Returns false if the plugin 
		REM /// is uninitialized.
		REM /// EXPORT_API bool PluginIsInitialized();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsInitialized() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsInitializedD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsInitializedD() As Double
		End Function

		REM /// <summary>
		REM /// If the method can be invoked the method returns true.
		REM /// EXPORT_API bool PluginIsPlatformSupported();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlatformSupported() As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsPlatformSupportedD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlatformSupportedD() As Double
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The method 
		REM /// will return whether the animation is playing or not. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API bool PluginIsPlaying(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlaying(animationId As Integer) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsPlayingD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlayingD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The method 
		REM /// will return whether the animation is playing or not. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API bool PluginIsPlayingName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlayingName(path As IntPtr) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsPlayingNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlayingNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// `PluginIsPlayingType` automatically handles initializing the `ChromaSDK`. 
		REM /// If any animation is playing for the `deviceType` and `device` combination, 
		REM /// the method will return true, otherwise false.
		REM /// EXPORT_API bool PluginIsPlayingType(int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlayingType(deviceType As Integer, device As Integer) As <MarshalAs(UnmanagedType.I1)> Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginIsPlayingTypeD(double deviceType, double device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginIsPlayingTypeD(deviceType As Double, device As Double) As Double
		End Function

		REM /// <summary>
		REM /// Do a lerp math operation on a float.
		REM /// EXPORT_API float PluginLerp(float start, float end, float amt);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLerp(start As Single, renamed_end As Single, amt As Single) As Single
		End Function

		REM /// <summary>
		REM /// Lerp from one color to another given t in the range 0.0 to 1.0.
		REM /// EXPORT_API int PluginLerpColor(int from, int to, float t);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLerpColor(from As Integer, renamed_to As Integer, t As Single) As Integer
		End Function

		REM /// <summary>
		REM /// Loads `Chroma` effects so that the animation can be played immediately. 
		REM /// Returns the animation id upon success. Returns negative one upon failure. 
		REM ///
		REM /// EXPORT_API int PluginLoadAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLoadAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginLoadAnimationD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLoadAnimationD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Load the named animation.
		REM /// EXPORT_API void PluginLoadAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLoadAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Load a composite set of animations.
		REM /// EXPORT_API void PluginLoadComposite(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginLoadComposite(name As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginMakeBlankFrames(int animationId, int frameCount, float duration, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFrames(animationId As Integer, frameCount As Integer, duration As Single, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginMakeBlankFramesName(const char* path, int frameCount, float duration, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesName(path As IntPtr, frameCount As Integer, duration As Single, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMakeBlankFramesNameD(const char* path, double frameCount, double duration, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesNameD(path As IntPtr, frameCount As Double, duration As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMakeBlankFramesRandom(int animationId, int frameCount, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandom(animationId As Integer, frameCount As Integer, duration As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random black and white. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhite(int animationId, int frameCount, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandomBlackAndWhite(animationId As Integer, frameCount As Integer, duration As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random black and white. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginMakeBlankFramesRandomBlackAndWhiteName(const char* path, int frameCount, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandomBlackAndWhiteName(path As IntPtr, frameCount As Integer, duration As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMakeBlankFramesRandomBlackAndWhiteNameD(const char* path, double frameCount, double duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandomBlackAndWhiteNameD(path As IntPtr, frameCount As Double, duration As Double) As Double
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color is random. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMakeBlankFramesRandomName(const char* path, int frameCount, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandomName(path As IntPtr, frameCount As Integer, duration As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMakeBlankFramesRandomNameD(const char* path, double frameCount, double duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRandomNameD(path As IntPtr, frameCount As Double, duration As Double) As Double
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginMakeBlankFramesRGB(int animationId, int frameCount, float duration, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRGB(animationId As Integer, frameCount As Integer, duration As Single, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Make a blank animation for the length of the frame count. Frame duration 
		REM /// defaults to the duration. The frame color defaults to color. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginMakeBlankFramesRGBName(const char* path, int frameCount, float duration, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRGBName(path As IntPtr, frameCount As Integer, duration As Single, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMakeBlankFramesRGBNameD(const char* path, double frameCount, double duration, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMakeBlankFramesRGBNameD(path As IntPtr, frameCount As Double, duration As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Flips the color grid horizontally for all `Chroma` animation frames. Returns 
		REM /// the animation id upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginMirrorHorizontally(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMirrorHorizontally(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Flips the color grid vertically for all `Chroma` animation frames. This 
		REM /// method has no effect for `EChromaSDKDevice1DEnum` devices. Returns the 
		REM /// animation id upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginMirrorVertically(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMirrorVertically(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Multiply the color intensity with the lerp result from color 1 to color 
		REM /// 2 using the frame index divided by the frame count for the `t` parameter. 
		REM /// Animation is referenced in id.
		REM /// EXPORT_API void PluginMultiplyColorLerpAllFrames(int animationId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply the color intensity with the lerp result from color 1 to color 
		REM /// 2 using the frame index divided by the frame count for the `t` parameter. 
		REM /// Animation is referenced in name.
		REM /// EXPORT_API void PluginMultiplyColorLerpAllFramesName(const char* path, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyColorLerpAllFramesName(path As IntPtr, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyColorLerpAllFramesNameD(const char* path, double color1, double color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyColorLerpAllFramesNameD(path As IntPtr, color1 As Double, color2 As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply all the colors in the frame by the intensity value. The valid the 
		REM /// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		REM /// An intensity of 0.5 would half the color value. Black colors in the frame 
		REM /// will not be affected by this method.
		REM /// EXPORT_API void PluginMultiplyIntensity(int animationId, int frameId, float intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensity(animationId As Integer, frameId As Integer, intensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all the colors for all frames by the intensity value. The valid 
		REM /// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		REM /// equally. An intensity of 0.5 would half the color value. Black colors in 
		REM /// the frame will not be affected by this method.
		REM /// EXPORT_API void PluginMultiplyIntensityAllFrames(int animationId, float intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFrames(animationId As Integer, intensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all the colors for all frames by the intensity value. The valid 
		REM /// the intensity range is from 0.0 to 255.0. RGB components are multiplied 
		REM /// equally. An intensity of 0.5 would half the color value. Black colors in 
		REM /// the frame will not be affected by this method.
		REM /// EXPORT_API void PluginMultiplyIntensityAllFramesName(const char* path, float intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFramesName(path As IntPtr, intensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityAllFramesNameD(const char* path, double intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFramesNameD(path As IntPtr, intensity As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyIntensityAllFramesRGB(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFramesRGB(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMultiplyIntensityAllFramesRGBName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFramesRGBName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityAllFramesRGBNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityAllFramesRGBNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyIntensityColor(int animationId, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColor(animationId As Integer, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyIntensityColorAllFrames(int animationId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColorAllFrames(animationId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMultiplyIntensityColorAllFramesName(const char* path, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColorAllFramesName(path As IntPtr, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityColorAllFramesNameD(const char* path, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColorAllFramesNameD(path As IntPtr, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMultiplyIntensityColorName(const char* path, int frameId, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColorName(path As IntPtr, frameId As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityColorNameD(const char* path, double frameId, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityColorNameD(path As IntPtr, frameId As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply all the colors in the frame by the intensity value. The valid the 
		REM /// intensity range is from 0.0 to 255.0. RGB components are multiplied equally. 
		REM /// An intensity of 0.5 would half the color value. Black colors in the frame 
		REM /// will not be affected by this method.
		REM /// EXPORT_API void PluginMultiplyIntensityName(const char* path, int frameId, float intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityName(path As IntPtr, frameId As Integer, intensity As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityNameD(const char* path, double frameId, double intensity);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityNameD(path As IntPtr, frameId As Double, intensity As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyIntensityRGB(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityRGB(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the RBG color intensity. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMultiplyIntensityRGBName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityRGBName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyIntensityRGBNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyIntensityRGBNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyNonZeroTargetColorLerp(int animationId, int frameId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerp(animationId As Integer, frameId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by id. 
		REM ///
		REM /// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFrames(int animationId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by name. 
		REM ///
		REM /// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesName(const char* path, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFramesName(path As IntPtr, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFramesNameD(path As IntPtr, color1 As Double, color2 As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		REM /// using the frame color value as the `t` value. Animation is referenced by 
		REM /// id.
		REM /// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFramesRGB(animationId As Integer, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between RGB 1 and 2 
		REM /// using the frame color value as the `t` value. Animation is referenced by 
		REM /// name.
		REM /// EXPORT_API void PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFramesRGBName(path As IntPtr, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyNonZeroTargetColorLerpAllFramesRGBNameD(path As IntPtr, red1 As Double, green1 As Double, blue1 As Double, red2 As Double, green2 As Double, blue2 As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginMultiplyTargetColorLerp(int animationId, int frameId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerp(animationId As Integer, frameId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by id. 
		REM ///
		REM /// EXPORT_API void PluginMultiplyTargetColorLerpAllFrames(int animationId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFrames(animationId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between color 1 and 2 using 
		REM /// the frame color value as the `t` value. Animation is referenced by name. 
		REM ///
		REM /// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesName(const char* path, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFramesName(path As IntPtr, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyTargetColorLerpAllFramesNameD(const char* path, double color1, double color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFramesNameD(path As IntPtr, color1 As Double, color2 As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		REM /// frame color value as the `t` value. Animation is referenced by id.
		REM /// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGB(int animationId, int red1, int green1, int blue1, int red2, int green2, int blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFramesRGB(animationId As Integer, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Multiply all frames by the color lerp result between RGB 1 and 2 using the 
		REM /// frame color value as the `t` value. Animation is referenced by name.
		REM /// EXPORT_API void PluginMultiplyTargetColorLerpAllFramesRGBName(const char* path, int red1, int green1, int blue1, int red2, int green2, int blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFramesRGBName(path As IntPtr, red1 As Integer, green1 As Integer, blue1 As Integer, red2 As Integer, green2 As Integer, blue2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginMultiplyTargetColorLerpAllFramesRGBNameD(const char* path, double red1, double green1, double blue1, double red2, double green2, double blue2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpAllFramesRGBNameD(path As IntPtr, red1 As Double, green1 As Double, blue1 As Double, red2 As Double, green2 As Double, blue2 As Double) As Double
		End Function

		REM /// <summary>
		REM /// Multiply the specific frame by the color lerp result between color 1 and 
		REM /// 2 using the frame color value as the `t` value. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginMultiplyTargetColorLerpName(const char* path, int frameId, int color1, int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginMultiplyTargetColorLerpName(path As IntPtr, frameId As Integer, color1 As Integer, color2 As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Offset all colors in the frame using the RGB offset. Use the range of -255 
		REM /// to 255 for red, green, and blue parameters. Negative values remove color. 
		REM /// Positive values add color.
		REM /// EXPORT_API void PluginOffsetColors(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColors(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Offset all colors for all frames using the RGB offset. Use the range of 
		REM /// -255 to 255 for red, green, and blue parameters. Negative values remove 
		REM /// color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetColorsAllFrames(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColorsAllFrames(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Offset all colors for all frames using the RGB offset. Use the range of 
		REM /// -255 to 255 for red, green, and blue parameters. Negative values remove 
		REM /// color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetColorsAllFramesName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColorsAllFramesName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOffsetColorsAllFramesNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColorsAllFramesNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Offset all colors in the frame using the RGB offset. Use the range of -255 
		REM /// to 255 for red, green, and blue parameters. Negative values remove color. 
		REM /// Positive values add color.
		REM /// EXPORT_API void PluginOffsetColorsName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColorsName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOffsetColorsNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetColorsNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors in the frame using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetNonZeroColors(int animationId, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColors(animationId As Integer, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors for all frames using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetNonZeroColorsAllFrames(int animationId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColorsAllFrames(animationId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors for all frames using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetNonZeroColorsAllFramesName(const char* path, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColorsAllFramesName(path As IntPtr, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOffsetNonZeroColorsAllFramesNameD(const char* path, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColorsAllFramesNameD(path As IntPtr, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// This method will only update colors in the animation that are not already 
		REM /// set to black. Offset a subset of colors in the frame using the RGB offset. 
		REM /// Use the range of -255 to 255 for red, green, and blue parameters. Negative 
		REM /// values remove color. Positive values add color.
		REM /// EXPORT_API void PluginOffsetNonZeroColorsName(const char* path, int frameId, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColorsName(path As IntPtr, frameId As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOffsetNonZeroColorsNameD(const char* path, double frameId, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOffsetNonZeroColorsNameD(path As IntPtr, frameId As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation file so that it can be played. Returns an animation 
		REM /// id >= 0 upon success. Returns negative one if there was a failure. The 
		REM /// animation id is used in most of the API methods.
		REM /// EXPORT_API int PluginOpenAnimation(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenAnimation(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOpenAnimationD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenAnimationD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation data from memory so that it can be played. `Data` 
		REM /// is a pointer to BYTE array of the loaded animation in memory. `Name` will 
		REM /// be assigned to the animation when loaded. Returns an animation id >= 0 
		REM /// upon success. Returns negative one if there was a failure. The animation 
		REM /// id is used in most of the API methods.
		REM /// EXPORT_API int PluginOpenAnimationFromMemory(const BYTE* data, const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenAnimationFromMemory(data As Byte(), name As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// Opens a `Chroma` animation file with the `.chroma` extension. Returns zero 
		REM /// upon success. Returns negative one if there was a failure.
		REM /// EXPORT_API int PluginOpenEditorDialog(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenEditorDialog(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// Open the named animation in the editor dialog and play the animation at 
		REM /// start.
		REM /// EXPORT_API int PluginOpenEditorDialogAndPlay(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenEditorDialogAndPlay(path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOpenEditorDialogAndPlayD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenEditorDialogAndPlayD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOpenEditorDialogD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOpenEditorDialogD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Sets the `duration` for all grames in the `Chroma` animation to the `duration` 
		REM /// parameter. Returns the animation id upon success. Returns negative one 
		REM /// upon failure.
		REM /// EXPORT_API int PluginOverrideFrameDuration(int animationId, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOverrideFrameDuration(animationId As Integer, duration As Single) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginOverrideFrameDurationD(double animationId, double duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOverrideFrameDurationD(animationId As Double, duration As Double) As Double
		End Function

		REM /// <summary>
		REM /// Override the duration of all frames with the `duration` value. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginOverrideFrameDurationName(const char* path, float duration);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginOverrideFrameDurationName(path As IntPtr, duration As Single) As Boolean
		End Function

		REM /// <summary>
		REM /// Pause the current animation referenced by id.
		REM /// EXPORT_API void PluginPauseAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPauseAnimation(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Pause the current animation referenced by name.
		REM /// EXPORT_API void PluginPauseAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPauseAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPauseAnimationNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPauseAnimationNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Plays the `Chroma` animation. This will load the animation, if not loaded 
		REM /// previously. Returns the animation id upon success. Returns negative one 
		REM /// upon failure.
		REM /// EXPORT_API int PluginPlayAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPlayAnimationD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationFrame` automatically handles initializing the `ChromaSDK`. 
		REM /// The method will play the animation given the `animationId` with looping 
		REM /// `on` or `off` starting at the `frameId`.
		REM /// EXPORT_API void PluginPlayAnimationFrame(int animationId, int frameId, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationFrame(animationId As Integer, frameId As Integer, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationFrameName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will play with looping `on` or `off` starting at the `frameId`.
		REM /// EXPORT_API void PluginPlayAnimationFrameName(const char* path, int frameId, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationFrameName(path As IntPtr, frameId As Integer, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPlayAnimationFrameNameD(const char* path, double frameId, double loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationFrameNameD(path As IntPtr, frameId As Double, renamed_loop As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationLoop` automatically handles initializing the `ChromaSDK`. 
		REM /// The method will play the animation given the `animationId` with looping 
		REM /// `on` or `off`.
		REM /// EXPORT_API void PluginPlayAnimationLoop(int animationId, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationLoop(animationId As Integer, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// `PluginPlayAnimationName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will play with looping `on` or `off`.
		REM /// EXPORT_API void PluginPlayAnimationName(const char* path, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationName(path As IntPtr, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPlayAnimationNameD(const char* path, double loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayAnimationNameD(path As IntPtr, renamed_loop As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginPlayComposite` automatically handles initializing the `ChromaSDK`. 
		REM /// The named animation files for the `.chroma` set will be automatically opened. 
		REM /// The set of animations will play with looping `on` or `off`.
		REM /// EXPORT_API void PluginPlayComposite(const char* name, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayComposite(name As IntPtr, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPlayCompositeD(const char* name, double loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPlayCompositeD(name As IntPtr, renamed_loop As Double) As Double
		End Function

		REM /// <summary>
		REM /// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		REM /// Returns the animation id upon success. Returns negative one upon failure. 
		REM ///
		REM /// EXPORT_API int PluginPreviewFrame(int animationId, int frameIndex);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPreviewFrame(animationId As Integer, frameIndex As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginPreviewFrameD(double animationId, double frameIndex);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPreviewFrameD(animationId As Double, frameIndex As Double) As Double
		End Function

		REM /// <summary>
		REM /// Displays the `Chroma` animation frame on `Chroma` hardware given the `frameIndex`. 
		REM /// Animaton is referenced by name.
		REM /// EXPORT_API void PluginPreviewFrameName(const char* path, int frameIndex);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginPreviewFrameName(path As IntPtr, frameIndex As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Reduce the frames of the animation by removing every nth element. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginReduceFrames(int animationId, int n);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReduceFrames(animationId As Integer, n As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Reduce the frames of the animation by removing every nth element. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginReduceFramesName(const char* path, int n);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReduceFramesName(path As IntPtr, n As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginReduceFramesNameD(const char* path, double n);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReduceFramesNameD(path As IntPtr, n As Double) As Double
		End Function

		REM /// <summary>
		REM /// Resets the `Chroma` animation to 1 blank frame. Returns the animation id 
		REM /// upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginResetAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginResetAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Resume the animation with loop `ON` or `OFF` referenced by id.
		REM /// EXPORT_API void PluginResumeAnimation(int animationId, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginResumeAnimation(animationId As Integer, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// Resume the animation with loop `ON` or `OFF` referenced by name.
		REM /// EXPORT_API void PluginResumeAnimationName(const char* path, bool loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginResumeAnimationName(path As IntPtr, renamed_loop As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginResumeAnimationNameD(const char* path, double loop);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginResumeAnimationNameD(path As IntPtr, renamed_loop As Double) As Double
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Returns the 
		REM /// animation id upon success. Returns negative one upon failure. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API int PluginReverse(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReverse(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Animation is 
		REM /// referenced by id.
		REM /// EXPORT_API void PluginReverseAllFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReverseAllFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Reverse the animation frame order of the `Chroma` animation. Animation is 
		REM /// referenced by name.
		REM /// EXPORT_API void PluginReverseAllFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReverseAllFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginReverseAllFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginReverseAllFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Save the animation referenced by id to the path specified.
		REM /// EXPORT_API int PluginSaveAnimation(int animationId, const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSaveAnimation(animationId As Integer, path As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// Save the named animation to the target path specified.
		REM /// EXPORT_API int PluginSaveAnimationName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSaveAnimationName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Integer
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSet1DColor(int animationId, int frameId, int led, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet1DColor(animationId As Integer, frameId As Integer, led As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `1D` `led`. The `led` should 
		REM /// be greater than or equal to 0 and less than the `MaxLeds`. The animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSet1DColorName(const char* path, int frameId, int led, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet1DColorName(path As IntPtr, frameId As Integer, led As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSet1DColorNameD(const char* path, double frameId, double led, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet1DColorNameD(path As IntPtr, frameId As Double, led As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// The animation is referenced by id.
		REM /// EXPORT_API void PluginSet2DColor(int animationId, int frameId, int row, int column, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet2DColor(animationId As Integer, frameId As Integer, row As Integer, column As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the animation color for a frame given the `2D` `row` and `column`. The 
		REM /// `row` should be greater than or equal to 0 and less than the `MaxRow`. 
		REM /// The `column` should be greater than or equal to 0 and less than the `MaxColumn`. 
		REM /// The animation is referenced by name.
		REM /// EXPORT_API void PluginSet2DColorName(const char* path, int frameId, int row, int column, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet2DColorName(path As IntPtr, frameId As Integer, row As Integer, column As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSet2DColorNameD(const char* path, double frameId, double rowColumnIndex, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSet2DColorNameD(path As IntPtr, frameId As Double, rowColumnIndex As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// When custom color is set, the custom key mode will be used. The animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetChromaCustomColorAllFrames(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomColorAllFrames(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// When custom color is set, the custom key mode will be used. The animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetChromaCustomColorAllFramesName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomColorAllFramesName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetChromaCustomColorAllFramesNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomColorAllFramesNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		REM /// from grid to key. `True` changes the layout from key to grid. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetChromaCustomFlag(int animationId, bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomFlag(animationId As Integer, flag As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the Chroma custom key color flag on all frames. `True` changes the layout 
		REM /// from grid to key. `True` changes the layout from key to grid. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetChromaCustomFlagName(const char* path, bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomFlagName(path As IntPtr, flag As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetChromaCustomFlagNameD(const char* path, double flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetChromaCustomFlagNameD(path As IntPtr, flag As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the current frame of the animation referenced by id.
		REM /// EXPORT_API void PluginSetCurrentFrame(int animationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetCurrentFrame(animationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the current frame of the animation referenced by name.
		REM /// EXPORT_API void PluginSetCurrentFrameName(const char* path, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetCurrentFrameName(path As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetCurrentFrameNameD(const char* path, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetCurrentFrameNameD(path As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the custom alpha flag on the color array
		REM /// EXPORT_API RZRESULT PluginSetCustomColorFlag2D(int device, int* colors);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetCustomColorFlag2D(device As Integer, colors As Integer()) As Integer
		End Function

		REM /// <summary>
		REM /// Changes the `deviceType` and `device` of a `Chroma` animation. If the device 
		REM /// is changed, the `Chroma` animation will be reset with 1 blank frame. Returns 
		REM /// the animation id upon success. Returns negative one upon failure.
		REM /// EXPORT_API int PluginSetDevice(int animationId, int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetDevice(animationId As Integer, deviceType As Integer, device As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// SetEffect will display the referenced effect id.
		REM /// EXPORT_API RZRESULT PluginSetEffect(const ChromaSDK::FChromaSDKGuid& effectId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetEffect(effectId As Guid) As Integer
		End Function

		REM /// <summary>
		REM /// SetEffectCustom1D will display the referenced colors immediately
		REM /// EXPORT_API RZRESULT PluginSetEffectCustom1D(const int device, const int* colors);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetEffectCustom1D(device As Integer, colors As Integer()) As Integer
		End Function

		REM /// <summary>
		REM /// SetEffectCustom2D will display the referenced colors immediately
		REM /// EXPORT_API RZRESULT PluginSetEffectCustom2D(const int device, const int* colors);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetEffectCustom2D(device As Integer, colors As Integer()) As Integer
		End Function

		REM /// <summary>
		REM /// SetEffectKeyboardCustom2D will display the referenced custom keyboard colors 
		REM /// immediately
		REM /// EXPORT_API RZRESULT PluginSetEffectKeyboardCustom2D(const int device, const int* colors);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetEffectKeyboardCustom2D(device As Integer, colors As Integer()) As Integer
		End Function

		REM /// <summary>
		REM /// When the idle animation is used, the named animation will play when no other 
		REM /// animations are playing. Reference the animation by id.
		REM /// EXPORT_API void PluginSetIdleAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetIdleAnimation(animationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// When the idle animation is used, the named animation will play when no other 
		REM /// animations are playing. Reference the animation by name.
		REM /// EXPORT_API void PluginSetIdleAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetIdleAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame.
		REM /// EXPORT_API void PluginSetKeyColor(int animationId, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginSetKeyColorAllFrames(int animationId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFrames(animationId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginSetKeyColorAllFramesName(const char* path, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFramesName(path As IntPtr, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyColorAllFramesNameD(const char* path, double rzkey, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFramesNameD(path As IntPtr, rzkey As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by id.
		REM /// EXPORT_API void PluginSetKeyColorAllFramesRGB(int animationId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFramesRGB(animationId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for all frames. Animation is referenced 
		REM /// by name.
		REM /// EXPORT_API void PluginSetKeyColorAllFramesRGBName(const char* path, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFramesRGBName(path As IntPtr, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyColorAllFramesRGBNameD(const char* path, double rzkey, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorAllFramesRGBNameD(path As IntPtr, rzkey As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame.
		REM /// EXPORT_API void PluginSetKeyColorName(const char* path, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorName(path As IntPtr, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyColorNameD(const char* path, double frameId, double rzkey, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorNameD(path As IntPtr, frameId As Double, rzkey As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetKeyColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetKeyColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorRGBName(path As IntPtr, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyColorRGBNameD(path As IntPtr, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame if the existing 
		REM /// color is not already black.
		REM /// EXPORT_API void PluginSetKeyNonZeroColor(int animationId, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame if the existing 
		REM /// color is not already black.
		REM /// EXPORT_API void PluginSetKeyNonZeroColorName(const char* path, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColorName(path As IntPtr, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyNonZeroColorNameD(const char* path, double frameId, double rzkey, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColorNameD(path As IntPtr, frameId As Double, rzkey As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame where color 
		REM /// is not black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeyNonZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set the key to the specified key color for the specified frame where color 
		REM /// is not black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeyNonZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColorRGBName(path As IntPtr, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyNonZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyNonZeroColorRGBNameD(path As IntPtr, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set animation key by row and column to a static color for the given frame. 
		REM ///
		REM /// EXPORT_API void PluginSetKeyRowColumnColorName(const char* path, int frameId, int row, int column, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyRowColumnColorName(path As IntPtr, frameId As Integer, row As Integer, column As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetKeysColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetKeysColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetKeysColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorAllFramesName(path As IntPtr, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetKeysColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorAllFramesRGB(animationId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetKeysColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorAllFramesRGBName(path As IntPtr, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame.
		REM /// EXPORT_API void PluginSetKeysColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by id.
		REM /// EXPORT_API void PluginSetKeysColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame. Animation 
		REM /// is referenced by name.
		REM /// EXPORT_API void PluginSetKeysColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysColorRGBName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame if 
		REM /// the existing color is not already black.
		REM /// EXPORT_API void PluginSetKeysNonZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysNonZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames if the existing 
		REM /// color is not already black. Reference animation by name.
		REM /// EXPORT_API void PluginSetKeysNonZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColorAllFramesName(path As IntPtr, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame if 
		REM /// the existing color is not already black. Reference animation by name.
		REM /// EXPORT_API void PluginSetKeysNonZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColorName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysNonZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is not black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeysNonZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysNonZeroColorRGBName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysZeroColor(int animationId, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColor(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysZeroColorAllFrames(int animationId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorAllFrames(animationId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeysZeroColorAllFramesName(const char* path, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorAllFramesName(path As IntPtr, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysZeroColorAllFramesRGB(int animationId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorAllFramesRGB(animationId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for all frames where the 
		REM /// color is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeysZeroColorAllFramesRGBName(const char* path, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorAllFramesRGBName(path As IntPtr, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeysZeroColorName(const char* path, int frameId, const int* rzkeys, int keyCount, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeysZeroColorRGB(int animationId, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorRGB(animationId As Integer, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set an array of animation keys to a static color for the given frame where 
		REM /// the color is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeysZeroColorRGBName(const char* path, int frameId, const int* rzkeys, int keyCount, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeysZeroColorRGBName(path As IntPtr, frameId As Integer, rzkeys As Integer(), keyCount As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeyZeroColor(int animationId, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColor(animationId As Integer, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeyZeroColorName(const char* path, int frameId, int rzkey, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColorName(path As IntPtr, frameId As Integer, rzkey As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyZeroColorNameD(const char* path, double frameId, double rzkey, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColorNameD(path As IntPtr, frameId As Double, rzkey As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by id.
		REM /// EXPORT_API void PluginSetKeyZeroColorRGB(int animationId, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColorRGB(animationId As Integer, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Set animation key to a static color for the given frame where the color 
		REM /// is black. Animation is referenced by name.
		REM /// EXPORT_API void PluginSetKeyZeroColorRGBName(const char* path, int frameId, int rzkey, int red, int green, int blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColorRGBName(path As IntPtr, frameId As Integer, rzkey As Integer, red As Integer, green As Integer, blue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSetKeyZeroColorRGBNameD(const char* path, double frameId, double rzkey, double red, double green, double blue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetKeyZeroColorRGBNameD(path As IntPtr, frameId As Double, rzkey As Double, red As Double, green As Double, blue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Invokes the setup for a debug logging callback so that `stdout` is redirected 
		REM /// to the callback. This is used by `Unity` so that debug messages can appear 
		REM /// in the console window.
		REM /// EXPORT_API void PluginSetLogDelegate(DebugLogPtr fp);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetLogDelegate(fp As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Sets the target device to the static color.
		REM /// EXPORT_API void PluginSetStaticColor(int deviceType, int device, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetStaticColor(deviceType As Integer, device As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Sets all devices to the static color.
		REM /// EXPORT_API void PluginSetStaticColorAll(int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSetStaticColorAll(color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Sets the target device to the static color.
		REM /// EXPORT_API void PluginStaticColor(int deviceType, int device, int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStaticColor(deviceType As Integer, device As Integer, color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Sets all devices to the static color.
		REM /// EXPORT_API void PluginStaticColorAll(int color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStaticColorAll(color As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginStaticColorD(double deviceType, double device, double color);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStaticColorD(deviceType As Double, device As Double, color As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginStopAll` will automatically stop all animations that are playing. 
		REM ///
		REM /// EXPORT_API void PluginStopAll();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAll() As Boolean
		End Function

		REM /// <summary>
		REM /// Stops animation playback if in progress. Returns the animation id upon success. 
		REM /// Returns negative one upon failure.
		REM /// EXPORT_API int PluginStopAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginStopAnimationD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimationD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginStopAnimationName` automatically handles initializing the `ChromaSDK`. 
		REM /// The named `.chroma` animation file will be automatically opened. The animation 
		REM /// will stop if playing.
		REM /// EXPORT_API void PluginStopAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginStopAnimationNameD(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimationNameD(path As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// `PluginStopAnimationType` automatically handles initializing the `ChromaSDK`. 
		REM /// If any animation is playing for the `deviceType` and `device` combination, 
		REM /// it will be stopped.
		REM /// EXPORT_API void PluginStopAnimationType(int deviceType, int device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimationType(deviceType As Integer, device As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginStopAnimationTypeD(double deviceType, double device);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopAnimationTypeD(deviceType As Double, device As Double) As Double
		End Function

		REM /// <summary>
		REM /// `PluginStopComposite` automatically handles initializing the `ChromaSDK`. 
		REM /// The named animation files for the `.chroma` set will be automatically opened. 
		REM /// The set of animations will be stopped if playing.
		REM /// EXPORT_API void PluginStopComposite(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopComposite(name As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginStopCompositeD(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginStopCompositeD(name As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Return color1 - color2
		REM /// EXPORT_API int PluginSubtractColor(const int color1, const int color2);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractColor(color1 As Integer, color2 As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for the frame where the 
		REM /// target color is not black. Source and target are referenced by id.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeys(int sourceAnimationId, int targetAnimationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeys(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black. Source and target are referenced by id.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black. Source and target are referenced by name.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black starting at offset for the length of the source. 
		REM /// Source and target are referenced by id.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for all frames where the 
		REM /// target color is not black starting at offset for the length of the source. 
		REM /// Source and target are referenced by name.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color for the frame where the 
		REM /// target color is not black. Source and target are referenced by name.
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysName(const char* sourceAnimation, const char* targetAnimation, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target where color is not black for the 
		REM /// source frame and target offset frame, reference source and target by id. 
		REM ///
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target where color is not black for the 
		REM /// source frame and target offset frame, reference source and target by name. 
		REM ///
		REM /// EXPORT_API void PluginSubtractNonZeroAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames. Reference source and target by id.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFrames(int sourceAnimationId, int targetAnimationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFrames(sourceAnimationId As Integer, targetAnimationId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames. Reference source and target by name.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesName(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFramesName(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesNameD(const char* sourceAnimation, const char* targetAnimation);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFramesNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames starting at the target offset for the length of 
		REM /// the source. Reference source and target by id.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffset(int sourceAnimationId, int targetAnimationId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFramesOffset(sourceAnimationId As Integer, targetAnimationId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black for all frames starting at the target offset for the length of 
		REM /// the source. Reference source and target by name.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(const char* sourceAnimation, const char* targetAnimation, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFramesOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysAllFramesOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black from the source frame to the target offset frame. Reference source 
		REM /// and target by id.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffset(int sourceAnimationId, int targetAnimationId, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysOffset(sourceAnimationId As Integer, targetAnimationId As Integer, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the source color from the target color where the target color is 
		REM /// not black from the source frame to the target offset frame. Reference source 
		REM /// and target by name.
		REM /// EXPORT_API void PluginSubtractNonZeroTargetAllKeysOffsetName(const char* sourceAnimation, const char* targetAnimation, int frameId, int offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysOffsetName(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Integer, offset As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractNonZeroTargetAllKeysOffsetNameD(const char* sourceAnimation, const char* targetAnimation, double frameId, double offset);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractNonZeroTargetAllKeysOffsetNameD(sourceAnimation As IntPtr, targetAnimation As IntPtr, frameId As Double, offset As Double) As Double
		End Function

		REM /// <summary>
		REM /// Subtract all frames with the min RGB color where the animation color is 
		REM /// less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by id.
		REM /// EXPORT_API void PluginSubtractThresholdColorsMinMaxAllFramesRGB(const int animationId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxAllFramesRGB(animationId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract all frames with the min RGB color where the animation color is 
		REM /// less than the min threshold AND with the max RGB color where the animation 
		REM /// is more than the max threshold. Animation is referenced by name.
		REM /// EXPORT_API void PluginSubtractThresholdColorsMinMaxAllFramesRGBName(const char* path, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxAllFramesRGBName(path As IntPtr, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(const char* path, double minThreshold, double minRed, double minGreen, double minBlue, double maxThreshold, double maxRed, double maxGreen, double maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxAllFramesRGBNameD(path As IntPtr, minThreshold As Double, minRed As Double, minGreen As Double, minBlue As Double, maxThreshold As Double, maxRed As Double, maxGreen As Double, maxBlue As Double) As Double
		End Function

		REM /// <summary>
		REM /// Subtract the specified frame with the min RGB color where the animation 
		REM /// color is less than the min threshold AND with the max RGB color where the 
		REM /// animation is more than the max threshold. Animation is referenced by id. 
		REM ///
		REM /// EXPORT_API void PluginSubtractThresholdColorsMinMaxRGB(const int animationId, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxRGB(animationId As Integer, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Subtract the specified frame with the min RGB color where the animation 
		REM /// color is less than the min threshold AND with the max RGB color where the 
		REM /// animation is more than the max threshold. Animation is referenced by name. 
		REM ///
		REM /// EXPORT_API void PluginSubtractThresholdColorsMinMaxRGBName(const char* path, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxRGBName(path As IntPtr, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginSubtractThresholdColorsMinMaxRGBNameD(const char* path, const int frameId, const int minThreshold, const int minRed, const int minGreen, const int minBlue, const int maxThreshold, const int maxRed, const int maxGreen, const int maxBlue);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginSubtractThresholdColorsMinMaxRGBNameD(path As IntPtr, frameId As Integer, minThreshold As Integer, minRed As Integer, minGreen As Integer, minBlue As Integer, maxThreshold As Integer, maxRed As Integer, maxGreen As Integer, maxBlue As Integer) As Double
		End Function

		REM /// <summary>
		REM /// Trim the end of the animation. The length of the animation will be the lastFrameId 
		REM /// plus one. Reference the animation by id.
		REM /// EXPORT_API void PluginTrimEndFrames(int animationId, int lastFrameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimEndFrames(animationId As Integer, lastFrameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Trim the end of the animation. The length of the animation will be the lastFrameId 
		REM /// plus one. Reference the animation by name.
		REM /// EXPORT_API void PluginTrimEndFramesName(const char* path, int lastFrameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimEndFramesName(path As IntPtr, lastFrameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginTrimEndFramesNameD(const char* path, double lastFrameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimEndFramesNameD(path As IntPtr, lastFrameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Remove the frame from the animation. Reference animation by id.
		REM /// EXPORT_API void PluginTrimFrame(int animationId, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimFrame(animationId As Integer, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Remove the frame from the animation. Reference animation by name.
		REM /// EXPORT_API void PluginTrimFrameName(const char* path, int frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimFrameName(path As IntPtr, frameId As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginTrimFrameNameD(const char* path, double frameId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimFrameNameD(path As IntPtr, frameId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Trim the start of the animation starting at frame 0 for the number of frames. 
		REM /// Reference the animation by id.
		REM /// EXPORT_API void PluginTrimStartFrames(int animationId, int numberOfFrames);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimStartFrames(animationId As Integer, numberOfFrames As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// Trim the start of the animation starting at frame 0 for the number of frames. 
		REM /// Reference the animation by name.
		REM /// EXPORT_API void PluginTrimStartFramesName(const char* path, int numberOfFrames);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimStartFramesName(path As IntPtr, numberOfFrames As Integer) As Boolean
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginTrimStartFramesNameD(const char* path, double numberOfFrames);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginTrimStartFramesNameD(path As IntPtr, numberOfFrames As Double) As Double
		End Function

		REM /// <summary>
		REM /// Uninitializes the `ChromaSDK`. Returns 0 upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API RZRESULT PluginUninit();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUninit() As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginUninitD();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUninitD() As Double
		End Function

		REM /// <summary>
		REM /// Unloads `Chroma` effects to free up resources. Returns the animation id 
		REM /// upon success. Returns negative one upon failure. Reference the animation 
		REM /// by id.
		REM /// EXPORT_API int PluginUnloadAnimation(int animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadAnimation(animationId As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// D suffix for limited data types.
		REM /// EXPORT_API double PluginUnloadAnimationD(double animationId);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadAnimationD(animationId As Double) As Double
		End Function

		REM /// <summary>
		REM /// Unload the animation effects. Reference the animation by name.
		REM /// EXPORT_API void PluginUnloadAnimationName(const char* path);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadAnimationName(path As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Unload the the composite set of animation effects. Reference the animation 
		REM /// by name.
		REM /// EXPORT_API void PluginUnloadComposite(const char* name);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadComposite(name As IntPtr) As Boolean
		End Function

		REM /// <summary>
		REM /// Unload the Razer Chroma SDK Library before exiting the application.
		REM /// EXPORT_API void PluginUnloadLibrarySDK();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadLibrarySDK() As Boolean
		End Function

		REM /// <summary>
		REM /// Unload the Razer Chroma Streaming Plugin Library before exiting the application. 
		REM ///
		REM /// EXPORT_API void PluginUnloadLibraryStreamingPlugin();
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUnloadLibraryStreamingPlugin() As Boolean
		End Function

		REM /// <summary>
		REM /// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		REM /// (in seconds). The `color` is expected to be an array of the dimensions 
		REM /// for the `deviceType/device`. The `length` parameter is the size of the 
		REM /// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		REM /// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		REM /// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API int PluginUpdateFrame(int animationId, int frameIndex, float duration, int* colors, int length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUpdateFrame(animationId As Integer, frameIndex As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// Updates the `frameIndex` of the `Chroma` animation and sets the `duration` 
		REM /// (in seconds). The `color` is expected to be an array of the dimensions 
		REM /// for the `deviceType/device`. The `length` parameter is the size of the 
		REM /// `color` array. For `EChromaSDKDevice1DEnum` the array size should be `MAX 
		REM /// LEDS`. For `EChromaSDKDevice2DEnum` the array size should be `MAX ROW` 
		REM /// times `MAX COLUMN`. Returns the animation id upon success. Returns negative 
		REM /// one upon failure.
		REM /// EXPORT_API int PluginUpdateFrameName(const char* path, int frameIndex, float duration, int* colors, int length);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUpdateFrameName(path As IntPtr, frameIndex As Integer, duration As Single, colors As Integer(), length As Integer) As Integer
		End Function

		REM /// <summary>
		REM /// When the idle animation flag is true, when no other animations are playing, 
		REM /// the idle animation will be used. The idle animation will not be affected 
		REM /// by the API calls to PluginIsPlaying, PluginStopAnimationType, PluginGetPlayingAnimationId, 
		REM /// and PluginGetPlayingAnimationCount. Then the idle animation flag is false, 
		REM /// the idle animation is disabled. `Device` uses `EChromaSDKDeviceEnum` enums. 
		REM ///
		REM /// EXPORT_API void PluginUseIdleAnimation(int device, bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUseIdleAnimation(device As Integer, flag As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// Set idle animation flag for all devices.
		REM /// EXPORT_API void PluginUseIdleAnimations(bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUseIdleAnimations(flag As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// Set preloading animation flag, which is set to true by default. Reference 
		REM /// animation by id.
		REM /// EXPORT_API void PluginUsePreloading(int animationId, bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUsePreloading(animationId As Integer, flag As Boolean) As Boolean
		End Function

		REM /// <summary>
		REM /// Set preloading animation flag, which is set to true by default. Reference 
		REM /// animation by name.
		REM /// EXPORT_API void PluginUsePreloadingName(const char* path, bool flag);
		REM /// </summary>
		<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>
		Private Function PluginUsePreloadingName(path As IntPtr, flag As Boolean) As Boolean
		End Function

		#End Region
  End Module
End Namespace

