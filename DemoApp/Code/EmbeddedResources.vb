Imports System.IO
Imports System.Reflection

Public NotInheritable Class EmbeddedResources
    Private Sub New()
    End Sub

    Public Shared Function GetTemplateFile(strFileName As String) As Byte()
        Dim strFilePath As String

        strFilePath = Assembly.GetExecutingAssembly.GetName().Name.Replace(" ", "_") & "." & strFileName

        If DoesResourceExist(strFilePath) Then
            Using msOutput As New MemoryStream()
                Using sTranslator As Stream = Assembly.GetExecutingAssembly.GetManifestResourceStream(strFilePath)
                    sTranslator.CopyTo(msOutput)
                    sTranslator.Close()
                End Using

                Return msOutput.ToArray()
            End Using
        Else
            Return Nothing
        End If
    End Function

    Private Shared Function DoesResourceExist(strFullResourceName As String) As Boolean
        For Each strResource As String In Assembly.GetExecutingAssembly().GetManifestResourceNames()
            If strResource.Equals(strFullResourceName, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        Return False
    End Function
End Class
