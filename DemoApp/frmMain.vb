Imports System.Drawing.Imaging
Imports Loyaltyapp.Api
Imports Loyaltyapp.Layout

Public Class frmMain
    Private Const RECEIPT_WIDTH As Single = 512
    Private Const RECEIPT_STORE_NAME As String = "My Awesome Store"

    Private Settings As SettingsStore

    Private m_laApi As LoyaltyappApi
    Private m_intStorePoints As Integer
    Private m_tLastTransaction As Transaction
    Private m_tSelectedTransaction As Transaction

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dNow As Date

        ' Load app settings
        Settings = SettingsStore.LoadSettings()

        ' Instantiate API
        If Not String.IsNullOrEmpty(Settings.AuthenticationToken) Then
            m_laApi = New LoyaltyappApi(Settings.DeviceID, Settings.AuthenticationToken, Settings.UseStaging)
        Else
            m_laApi = New LoyaltyappApi(Settings.DeviceID)
        End If

        ' Apply app settings
        txtUserEmail.Text = Settings.UserEmail
        txtUserPassword.Text = Settings.UserPassword
        txtUserPin.Text = Settings.UserPIN
        cbUseStaging.Checked = Settings.UseStaging

        ' Some defaults
        cmbTransactionType.SelectedIndex = 0

        dNow = Date.Now
        cmbSearchTransactionType.SelectedIndex = 0
        cmbSearchTransactionStatus.SelectedIndex = 0
        dtpSearchStartDate.Value = dNow.Date
        dtpSearchStartTime.Value = dNow.Date
        dtpSearchEndDate.Value = dNow.Date.AddDays(1)
        dtpSearchEndTime.Value = dNow.Date.AddDays(1)

        Call UpdateEnableState()
    End Sub

#Region " Log in/out "
    Private Async Sub butLogIn_Click(sender As Object, e As EventArgs) Handles butLogIn.Click
        Try
            If String.IsNullOrEmpty(txtUserEmail.Text) Then
                Call ShowError("User E-Mail field is blank.")
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtUserPassword.Text) Then
                Call ShowError("User Password field is blank.")
                Exit Sub
            End If

            If m_laApi.IsSessionOpen Then
                Call UpdateEnableState("Logging out...")

                Await m_laApi.CloseSessionAsync()

                ' Logout successful, update the app settings
                Settings.AuthenticationToken = String.Empty
                Settings.SaveSettings()

                Call UpdateEnableState()
            Else
                Call UpdateEnableState("Logging in...")

                m_laApi.UseStagingServer = cbUseStaging.Checked

                If String.IsNullOrEmpty(txtUserPin.Text) Then
                    m_intStorePoints = Await m_laApi.OpenSessionAsync(txtUserEmail.Text, txtUserPassword.Text)
                Else
                    m_intStorePoints = Await m_laApi.OpenSessionAsync(txtUserEmail.Text, txtUserPassword.Text, txtUserPin.Text)
                End If
                m_intStorePoints = 0
                m_tLastTransaction = Nothing

                ' Login successful, update the app settings
                Settings.AuthenticationToken = m_laApi.AuthenticationToken
                Settings.UserEmail = txtUserEmail.Text
                Settings.UserPassword = txtUserPassword.Text
                Settings.UserPIN = txtUserPin.Text
                Settings.UseStaging = cbUseStaging.Checked
                Settings.SaveSettings()

                Call UpdateEnableState()
            End If
        Catch ex As Exception
            Call HandleException(ex)
        End Try
    End Sub
#End Region

#Region " Verify PIN "
    Private Async Sub butVerifyPin_Click(sender As Object, e As EventArgs) Handles butVerifyPin.Click
        Dim blnValid As Boolean

        Try
            If txtVerifyPinNumber.Text.Length > 0 Then
                Call UpdateEnableState("Verifying PIN...")

                blnValid = Await m_laApi.VerifyPinCodeAsync(txtVerifyPinNumber.Text)

                lblVerifyPinStatus.Text = "Status: " & If(blnValid, "Valid", "Not valid")

                Call UpdateEnableState()
            End If
        Catch ex As Exception
            Call HandleException(ex)
        End Try
    End Sub

#End Region

#Region " Create Transaction "
    Private Sub cmbTransactionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTransactionType.SelectedIndexChanged
        Select Case cmbTransactionType.SelectedIndex
            Case 0 ' Pay with cash
                txtTransactionID.Enabled = False
                txtTransactionAmount.Enabled = True

            Case 1 ' Pay with points
                txtTransactionID.Enabled = False
                txtTransactionAmount.Enabled = True

            Case 2 ' Refund
                txtTransactionID.Enabled = True
                txtTransactionAmount.Enabled = True

            Case 3 ' Cancel
                txtTransactionID.Enabled = True
                txtTransactionAmount.Enabled = False

        End Select
    End Sub

    Private Async Sub butTransactionExecute_Click(sender As Object, e As EventArgs) Handles butTransactionExecute.Click
        Dim intTransactionID As Integer
        Dim decAmount As Decimal

        Try
            Select Case cmbTransactionType.SelectedIndex
                Case 0 ' Pay with cash
                    If Not Decimal.TryParse(txtTransactionAmount.Text, decAmount) Then
                        Call ShowError("Transaction amount is not a valid number.")
                        Exit Sub
                    End If

                    Call UpdateEnableState("Creating pay-with-cash transaction...")
                    lblTransactionStatus.Text = "Status: Processing..."

                    m_tLastTransaction = Await m_laApi.PayWithCashAsync(decAmount)

                    txtTransactionID.Text = m_tLastTransaction.TransactionID
                    qdTransactionQr.Text = m_tLastTransaction.Token
                    pgTransaction.SelectedObject = m_tLastTransaction
                    lblTransactionStatus.Text = "Status: Pay-with-cash successful"
                    Call UpdateEnableState()

                Case 1 ' Pay with points
                    If Not Decimal.TryParse(txtTransactionAmount.Text, decAmount) Then
                        Call ShowError("Transaction amount is not a valid number.")
                        Exit Sub
                    End If

                    Call UpdateEnableState("Creating pay-with-points transaction...")
                    lblTransactionStatus.Text = "Status: Processing..."

                    m_tLastTransaction = Await m_laApi.PayWithPointsAsync(decAmount)

                    txtTransactionID.Text = m_tLastTransaction.TransactionID
                    qdTransactionQr.Text = m_tLastTransaction.Token
                    pgTransaction.SelectedObject = m_tLastTransaction
                    lblTransactionStatus.Text = "Status: Pay-with-points successful"
                    Call UpdateEnableState()

                Case 2 ' Refund
                    If Not Decimal.TryParse(txtTransactionAmount.Text, decAmount) Then
                        Call ShowError("Transaction amount is not a valid number.")
                        Exit Sub
                    End If

                    If Not Decimal.TryParse(txtTransactionID.Text, intTransactionID) Then
                        Call ShowError("Transaction ID is not a valid number.")
                        Exit Sub
                    End If

                    Call UpdateEnableState("Creating refund transaction...")
                    lblTransactionStatus.Text = "Status: Processing..."

                    m_tLastTransaction = Await m_laApi.RefundAsync(decAmount, intTransactionID)

                    txtTransactionID.Text = m_tLastTransaction.TransactionID
                    qdTransactionQr.Text = m_tLastTransaction.Token
                    pgTransaction.SelectedObject = m_tLastTransaction
                    lblTransactionStatus.Text = "Status: Refund successful"
                    Call UpdateEnableState()

                Case 3 ' Cancel
                    If Not Decimal.TryParse(txtTransactionID.Text, intTransactionID) Then
                        Call ShowError("Transaction ID is not a valid number.")
                        Exit Sub
                    End If

                    Call UpdateEnableState("Cancelling transaction...")
                    lblTransactionStatus.Text = "Status: Processing..."

                    Await m_laApi.CancelTransactionAsync(intTransactionID)
                    m_tLastTransaction = Nothing

                    txtTransactionID.Text = String.Empty
                    qdTransactionQr.Text = String.Empty
                    pgTransaction.SelectedObject = m_tLastTransaction
                    lblTransactionStatus.Text = "Status: Cancel successful"
                    Call UpdateEnableState()

            End Select
        Catch ex As Exception
            lblTransactionStatus.Text = "Status: " & ex.Message
            Call HandleException(ex)
        End Try
    End Sub

    Private Sub butTransactionGenerateReceipt_Click(sender As Object, e As EventArgs) Handles butTransactionGenerateReceipt.Click
        Dim abytLayout() As Byte = Nothing
        Dim larlLayout As LoyaltyappReceiptLayout = Nothing
        Dim dicData As Dictionary(Of String, Object)

        Try
            If m_tLastTransaction IsNot Nothing Then
                ' Load the layout template from this project's embedded resources
                Select Case m_tLastTransaction.TransactionType
                    Case TransactionTypeEnum.PayWithCash
                        abytLayout = EmbeddedResources.GetTemplateFile("VoucherEarn.xml")
                        'abytLayout = EmbeddedResources.GetTemplateFile("VoucherEarnEmbedded.xml")

                    Case TransactionTypeEnum.PayWithPoints
                        abytLayout = EmbeddedResources.GetTemplateFile("VoucherSpend.xml")

                    Case TransactionTypeEnum.Refund
                        ' Not supported yet (no receipt template)

                End Select

                If abytLayout IsNot Nothing Then
                    ' Load the receipt layout
                    larlLayout = LoyaltyappReceiptLayout.Load(abytLayout)

                    ' Add a handler to supply the receipt layout with any embedded files it needs
                    AddHandler larlLayout.RequestFile, AddressOf Layout_RequestFile

                    ' Load the data from the current transaction
                    dicData = LoyaltyappReceiptLayout.GetDataFromTransaction(m_tLastTransaction, RECEIPT_STORE_NAME)

                    ' Generate and display the receipt image
                    Call SetReceiptImage(larlLayout.Render(RECEIPT_WIDTH, dicData))

                    tcOperations.SelectedTab = tpReceiptView
                End If
            End If
        Catch ex As Exception
            Call HandleException(ex)
        Finally
            ' Remove the "RequestFile" handler, if there is a receipt layout loaded
            If larlLayout IsNot Nothing Then
                RemoveHandler larlLayout.RequestFile, AddressOf Layout_RequestFile
            End If
        End Try
    End Sub

    Private Async Sub butTransactionCheckStatus_Click(sender As Object, e As EventArgs) Handles butTransactionCheckStatus.Click
        Dim tseTransactionStaus As TransactionStatusEnum

        Try
            If m_tLastTransaction IsNot Nothing Then
                Call UpdateEnableState("Checking transaction status...")

                tseTransactionStaus = Await m_laApi.GetTransactionStausAsync(m_tLastTransaction)

                Call UpdateEnableState()

                MessageBox.Show(Me, "Transaction state is " & tseTransactionStaus.ToString(), "Transaction State", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Call HandleException(ex)
        End Try
    End Sub
#End Region

#Region " Search "
    Private Sub cbSearchStart_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchStart.CheckedChanged
        dtpSearchStartDate.Enabled = cbSearchStart.Checked
        dtpSearchStartTime.Enabled = cbSearchStart.Checked
    End Sub

    Private Sub cbSearchEnd_CheckedChanged(sender As Object, e As EventArgs) Handles cbSearchEnd.CheckedChanged
        dtpSearchEndDate.Enabled = cbSearchEnd.Checked
        dtpSearchEndTime.Enabled = cbSearchEnd.Checked
    End Sub

    Private Async Sub butSearch_Click(sender As Object, e As EventArgs) Handles butSearch.Click
        Dim fFilter As Filter
        Dim lstTransactions As List(Of Transaction)

        Try
            Call UpdateEnableState("Searching transactions...")

            ' Set up search filter
            fFilter = New Filter
            fFilter.TransactionType = [Enum].Parse(GetType(TransactionFilterTypeEnum), cmbSearchTransactionType.Text)
            fFilter.TransactionStatus = [Enum].Parse(GetType(TransactionFilterStatusEnum), cmbSearchTransactionStatus.Text)
            If cbSearchStart.Checked Then
                fFilter.StartTimestampUtc = dtpSearchStartDate.Value.Date + dtpSearchStartTime.Value.TimeOfDay
            End If
            If cbSearchEnd.Checked Then
                fFilter.EndTimestampUtc = dtpSearchEndDate.Value.Date + dtpSearchEndTime.Value.TimeOfDay
            End If

            ' Perform the search
            lstTransactions = Await m_laApi.GetTransactionsAsync(fFilter)

            ' Display the transactions
            dgvTransactions.DataSource = lstTransactions

            Call UpdateEnableState()
        Catch ex As Exception
            Call HandleException(ex)
        End Try
    End Sub

    Private Sub butSearchGenerateReceipt_Click(sender As Object, e As EventArgs) Handles butSearchGenerateReceipt.Click
        Dim abytLayout() As Byte = Nothing
        Dim larlLayout As LoyaltyappReceiptLayout = Nothing
        Dim dicData As Dictionary(Of String, Object)

        Try
            If m_tSelectedTransaction IsNot Nothing Then
                ' Load the layout template from this project's embedded resources
                Select Case m_tSelectedTransaction.TransactionType
                    Case TransactionTypeEnum.PayWithCash
                        abytLayout = EmbeddedResources.GetTemplateFile("VoucherEarn.xml")
                        'abytLayout = EmbeddedResources.GetTemplateFile("VoucherEarnEmbedded.xml")

                    Case TransactionTypeEnum.PayWithPoints
                        abytLayout = EmbeddedResources.GetTemplateFile("VoucherSpend.xml")

                    Case TransactionTypeEnum.Refund
                        ' Not supported yet (no receipt template)

                End Select

                If abytLayout IsNot Nothing Then
                    ' Load the receipt layout
                    larlLayout = LoyaltyappReceiptLayout.Load(abytLayout)

                    ' Add a handler to supply the receipt layout with any embedded files it needs
                    AddHandler larlLayout.RequestFile, AddressOf Layout_RequestFile

                    ' Load the data from the current transaction
                    dicData = LoyaltyappReceiptLayout.GetDataFromTransaction(m_tSelectedTransaction, RECEIPT_STORE_NAME)

                    ' Generate and display the receipt image
                    Call SetReceiptImage(larlLayout.Render(RECEIPT_WIDTH, dicData))

                    tcOperations.SelectedTab = tpReceiptView
                End If
            End If
        Catch ex As Exception
            Call HandleException(ex)
        End Try
    End Sub

    Private Sub dgvTransactions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTransactions.SelectionChanged
        If dgvTransactions.SelectedCells.Count > 0 Then
            m_tSelectedTransaction = DirectCast(dgvTransactions.SelectedCells(0).OwningRow.DataBoundItem, Transaction)
        ElseIf dgvTransactions.SelectedRows.Count > 0 Then
            m_tSelectedTransaction = DirectCast(dgvTransactions.SelectedRows(0).DataBoundItem, Transaction)
        Else
            m_tSelectedTransaction = Nothing
        End If
    End Sub
#End Region

#Region " Receipt "
    Private Sub butReceiptSave_Click(sender As Object, e As EventArgs) Handles butReceiptSave.Click
        If pbReceipt.Image IsNot Nothing Then
            Using sfdSave As New SaveFileDialog
                sfdSave.Title = "Save Receipt Image"
                sfdSave.Filter = "PNG Files|*.png|All Files (*.*)|*.*"
                If sfdSave.ShowDialog(Me) = DialogResult.OK Then
                    pbReceipt.Image.Save(sfdSave.FileName, ImageFormat.Png)
                End If
            End Using
        End If
    End Sub
#End Region

#Region " Receipt file requests "
    ' When processing a template, the template may ask for a file
    ' For example, embedded images are stored as files
    ' Get the file bytes from the embedded resource files in the Templates directory of this project
    Private Sub Layout_RequestFile(sender As Object, e As RequestFileEventArgs)
        e.Bytes = EmbeddedResources.GetTemplateFile(e.FileName)
    End Sub

#End Region

#Region " Form interface functions "
    ' Sets the currently visible receipt image, disposing of any existing image displayed
    Private Sub SetReceiptImage(iImage As Image)
        Dim iOldImage As Image

        iOldImage = pbReceipt.Image
        pbReceipt.Image = iImage
        butReceiptSave.Enabled = iImage IsNot Nothing

        If iOldImage IsNot Nothing Then
            iOldImage.Dispose()
        End If
    End Sub

    ' Updates the enable state of form controls based on the Loyaltyapp API state
    Private Sub UpdateEnableState(Optional strProcessingStatus As String = Nothing)
        Dim blnProcessing As Boolean = strProcessingStatus IsNot Nothing

        tsslStatus.Text = If(m_laApi.IsSessionOpen, If(strProcessingStatus, "Ready"), "Not logged in")
        tsslPoints.Text = m_intStorePoints & " points"

        ' Update the state of the "Open/Close Session" box
        gbOpenSession.Enabled = Not blnProcessing
        txtUserEmail.Enabled = Not m_laApi.IsSessionOpen
        txtUserPassword.Enabled = Not m_laApi.IsSessionOpen
        txtUserPin.Enabled = Not m_laApi.IsSessionOpen
        cbUseStaging.Enabled = Not m_laApi.IsSessionOpen
        butLogIn.Text = If(m_laApi.IsSessionOpen, "Log Out", "Log In")

        ' Update the state of the operations tab control
        tcOperations.Enabled = m_laApi.IsSessionOpen AndAlso Not blnProcessing

        ' Update the "Perform Transaction"'s "Generate Receipt" button
        butTransactionGenerateReceipt.Enabled = m_tLastTransaction IsNot Nothing
        butTransactionCheckStatus.Enabled = m_tLastTransaction IsNot Nothing

        ' Update the "Search Transactions"'s "Generate Receipt" button
        butSearchGenerateReceipt.Enabled = m_tSelectedTransaction IsNot Nothing
    End Sub

    ' Handles different exception types returned from the Loyaltyapp API
    Private Sub HandleException(eException As Exception)
        If TypeOf eException Is LoyaltyappException Then
            Dim leLoyaltyException As LoyaltyappException = DirectCast(eException, LoyaltyappException)
            ' A Loyaltyapp error occurred

            Call ShowError("A Loyaltyapp API error occurred." & vbCrLf &
                           vbCrLf &
                           "Error code: " & leLoyaltyException.ErrorCode & vbCrLf &
                           "Error(s):" & String.Join(vbCrLf, leLoyaltyException.Errors),
                           leLoyaltyException.ErrorCode & ": " & String.Join(";", leLoyaltyException.Errors))
        ElseIf TypeOf eException Is AggregateException Then
            Dim aeAggException As AggregateException = DirectCast(eException, AggregateException)
            ' An aggregate error ocurred
            ' Reprocess only show the first error

            If aeAggException.InnerExceptions.Count > 0 Then
                Call HandleException(aeAggException.InnerExceptions(0))
            Else
                Call HandleException(aeAggException.InnerException)
            End If
        ElseIf TypeOf eException Is Exception Then
            ' A general error occurred
            Call ShowError("A general error occurred." & vbCrLf & vbCrLf & eException.GetType().Name & ": " & eException.Message, eException.Message)
        End If
    End Sub

    ' Shows an error message to the user
    Private Sub ShowError(strError As String, Optional strErrorStatus As String = Nothing)
        MessageBox.Show(Me, strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Call UpdateEnableState(Nothing)
        tsslStatus.Text = If(strErrorStatus, If(m_laApi.IsSessionOpen, "Ready", "Not logged in"))
    End Sub
#End Region
End Class
