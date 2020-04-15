Imports ZXing
Imports ZXing.QrCode
Imports System.ComponentModel

' This control class displays a QR code on the screen
Public Class QrDisplay
    Inherits Control

    Private m_bBackBuffer As Bitmap

    Private m_bwBarcode As BarcodeWriter

    <Description("The QR code data to display on this control.")>
    <DefaultValue("")>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value

            Call UpdateDisplay()
        End Set
    End Property

    ' Windows magic to give this control a system-drawn border
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cpParams As CreateParams

            cpParams = MyBase.CreateParams
            cpParams.ExStyle = cpParams.ExStyle Or &H10000I
            cpParams.ExStyle = cpParams.ExStyle And (Not &H200I)
            cpParams.Style = cpParams.Style Or &H800000I

            Return cpParams
        End Get
    End Property

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)

        m_bwBarcode = New BarcodeWriter
        m_bwBarcode.Format = BarcodeFormat.QR_CODE
        m_bwBarcode.Options = New QrCodeEncodingOptions With {.DisableECI = True, .CharacterSet = "UTF-8"}

        Call UpdateDisplay()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Call UpdateDisplay()
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        ' Do nothing
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If m_bBackBuffer IsNot Nothing Then
            ' We have a valid backbuffer
            ' Draw it to the screen
            e.Graphics.DrawImageUnscaled(m_bBackBuffer, 0, 0)
        Else
            ' We don't have a valid backbuffer
            ' Draw a white screen
            e.Graphics.Clear(Color.White)
        End If
    End Sub

    ' Manage the backbuffer, and update the QR code displayed on screen
    Private Sub UpdateDisplay()
        ' Release the backbuffer, as we will recreate it below
        If m_bBackBuffer IsNot Nothing Then
            m_bBackBuffer.Dispose()
            m_bBackBuffer = Nothing
        End If

        ' Regenerate the backbuffer
        ' If control state is not valid, then don't create the backbuffer
        If m_bwBarcode IsNot Nothing AndAlso Not String.IsNullOrEmpty(MyBase.Text) Then
            ' Control state is valid
            ' Generate the QR code backbuffer
            m_bwBarcode.Options.Width = ClientSize.Width
            m_bwBarcode.Options.Height = ClientSize.Height

            If m_bwBarcode.Options.Width > 1000 Then
                m_bwBarcode.Options.Width = 1000
            End If

            If m_bwBarcode.Options.Height > 1000 Then
                m_bwBarcode.Options.Height = 1000
            End If

            m_bBackBuffer = m_bwBarcode.Write(MyBase.Text)
        End If

        ' Tell the control to redraw its surface
        Invalidate()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If m_bBackBuffer IsNot Nothing Then
                m_bBackBuffer.Dispose()
                m_bBackBuffer = Nothing
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub
End Class
