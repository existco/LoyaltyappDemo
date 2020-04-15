Imports System.IO
Imports System.Xml.Serialization
Imports System.Security.Cryptography
Imports System.Text
Imports System.ComponentModel

' Provides a persistent settings store for storing application data
' Sensitive data like the password and user PIN are encrypted
' This is not a perfect protection, but prevents casual perusal of the credentials
' NOTE: This has nothing to do with the Loyaltyapp API, but allows a more user-friendly use of the demo app
Public Class SettingsStore
    Private Const SETTINGS_PATH As String = "Neiche Living\Loyaltyapp API Demo"
    Private Const CRYPTO_SALT_SIZE As Integer = 32
    Private Const CRYPTO_PASSWORD As String = "LoyaltyappAPIDemo"

    ' These properties are stored in the XML settings file, and are used by the demo app to persist data

    Public Property DeviceID As Guid = Guid.NewGuid()

    Public Property UserEmail As String = String.Empty

    <XmlIgnore()>
    Public Property UserPassword As String = String.Empty

    <XmlIgnore()>
    Public Property UserPIN As String = String.Empty

    <XmlIgnore()>
    Public Property AuthenticationToken As String = String.Empty

    Public Property UseStaging As Boolean = True

    ' The properties below are "proxy" properties, used to modify how the values are stored in the XML file
    ' !!! DO NOT MODIFY THESE PROPERTIES DIRECTLY !!!

    <EditorBrowsable(False)>
    <Browsable(False)>
    Public Property CryptoSalt As Byte() ' This property MUST appear before the proxy properties, in both code, and the XMl settings file

    <XmlElement("UserPassword")>
    Public Property Proxy_UserPassword As Byte()
        Get
            Return Encrypt(CryptoSalt, StringToBytes(UserPassword))
        End Get
        Set(value As Byte())
            UserPassword = BytesToString(Decrypt(CryptoSalt, value))
        End Set
    End Property

    <XmlElement("UserPIN")>
    Public Property Proxy_UserPIN As Byte()
        Get
            Return Encrypt(CryptoSalt, StringToBytes(UserPIN))
        End Get
        Set(value As Byte())
            UserPIN = BytesToString(Decrypt(CryptoSalt, value))
        End Set
    End Property

    <XmlElement("AuthenticationToken")>
    Public Property Proxy_AuthenticationToken As Byte()
        Get
            Return Encrypt(CryptoSalt, StringToBytes(AuthenticationToken))
        End Get
        Set(value As Byte())
            AuthenticationToken = BytesToString(Decrypt(CryptoSalt, value))
        End Set
    End Property

    ' Save persistent settings to disk
    Public Sub SaveSettings()
        Dim xsSerializer As XmlSerializer
        Dim fiFile As FileInfo

        Try
            fiFile = New FileInfo(SettingsFile)

            If Not fiFile.Directory.Exists Then
                fiFile.Directory.Create()
            End If

            CryptoSalt = GenerateSalt()

            Using fsOutput As New FileStream(fiFile.FullName, FileMode.Create)
                xsSerializer = New XmlSerializer(GetType(SettingsStore))

                xsSerializer.Serialize(fsOutput, Me)
                fsOutput.Flush()
                fsOutput.Close()
            End Using
        Catch
            ' Eat any exceptions
        End Try
    End Sub

    ' Load persistent settings from disk
    Public Shared Function LoadSettings() As SettingsStore
        Dim xsSerializer As XmlSerializer
        Dim ssSettings As SettingsStore
        Dim fiFile As FileInfo

        Try
            fiFile = New FileInfo(SettingsFile)

            If Not fiFile.Directory.Exists Then
                fiFile.Directory.Create()
            End If

            If fiFile.Exists Then
                Using fsInput As New FileStream(fiFile.FullName, FileMode.Open)
                    xsSerializer = New XmlSerializer(GetType(SettingsStore))

                    ssSettings = DirectCast(xsSerializer.Deserialize(fsInput), SettingsStore)
                    fsInput.Close()
                End Using
            Else
                ssSettings = New SettingsStore
            End If
        Catch
            ssSettings = New SettingsStore
        End Try

        Return ssSettings
    End Function

    Private Shared ReadOnly Property SettingsFile() As String
        Get
            Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), SETTINGS_PATH, "settings.xml") ' Store under roaming user profile
        End Get
    End Property

#Region " Crypto "
    Private Shared Function StringToBytes(strValue As String) As Byte()
        Return Encoding.UTF8.GetBytes(strValue)
    End Function

    Private Shared Function BytesToString(abytValue() As Byte) As String
        Return Encoding.UTF8.GetString(abytValue)
    End Function

    Private Shared Function GenerateSalt() As Byte()
        Dim abytOutput(CRYPTO_SALT_SIZE - 1) As Byte

        Using rcspProvider As New RNGCryptoServiceProvider
            rcspProvider.GetBytes(abytOutput)
        End Using

        Return abytOutput
    End Function

    Private Shared Function Decrypt(abytSalt() As Byte, abytCipherText() As Byte) As Byte()
        Dim abytKey() As Byte
        Dim abytIV() As Byte
        Dim intReadSize As Integer
        Dim abytBuffer(1023) As Byte

        Using rdbDerive As New Rfc2898DeriveBytes(StringToBytes(CRYPTO_PASSWORD), abytSalt, 1000)
            abytKey = rdbDerive.GetBytes(32)
            abytIV = rdbDerive.GetBytes(16)
        End Using

        Using amCrypto As New AesManaged
            Using ctDecryptor As ICryptoTransform = amCrypto.CreateDecryptor(abytKey, abytIV)
                Using msCipherText As New MemoryStream(abytCipherText)
                    Using csStream As New CryptoStream(msCipherText, ctDecryptor, CryptoStreamMode.Read)
                        Using msPlainText As New MemoryStream
                            Do
                                intReadSize = csStream.Read(abytBuffer, 0, abytBuffer.Length)
                                If intReadSize = 0 Then
                                    Exit Do
                                End If
                                msPlainText.Write(abytBuffer, 0, intReadSize)
                            Loop

                            Return msPlainText.ToArray()
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Shared Function Encrypt(abytSalt() As Byte, abytPlainText() As Byte) As Byte()
        Dim abytKey() As Byte
        Dim abytIV() As Byte

        Using rdbDerive As New Rfc2898DeriveBytes(StringToBytes(CRYPTO_PASSWORD), abytSalt, 1000)
            abytKey = rdbDerive.GetBytes(32)
            abytIV = rdbDerive.GetBytes(16)
        End Using

        Using amCrypto As New AesManaged
            Using ctEncryptor As ICryptoTransform = amCrypto.CreateEncryptor(abytKey, abytIV)
                Using msCipherText As New MemoryStream
                    Using csStream As New CryptoStream(msCipherText, ctEncryptor, CryptoStreamMode.Write)
                        csStream.Write(abytPlainText, 0, abytPlainText.Length)
                    End Using

                    Return msCipherText.ToArray()
                End Using
            End Using
        End Using
    End Function
#End Region
End Class
