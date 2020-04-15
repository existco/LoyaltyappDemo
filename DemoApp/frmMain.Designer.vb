<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbOpenSession = New System.Windows.Forms.GroupBox()
        Me.cbUseStaging = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.butLogIn = New System.Windows.Forms.Button()
        Me.txtUserPin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcOperations = New System.Windows.Forms.TabControl()
        Me.tpVerifyPin = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblVerifyPinStatus = New System.Windows.Forms.Label()
        Me.butVerifyPin = New System.Windows.Forms.Button()
        Me.txtVerifyPinNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpPerformTransaction = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pgTransaction = New System.Windows.Forms.PropertyGrid()
        Me.butTransactionCheckStatus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTransactionStatus = New System.Windows.Forms.Label()
        Me.butTransactionGenerateReceipt = New System.Windows.Forms.Button()
        Me.butTransactionExecute = New System.Windows.Forms.Button()
        Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qdTransactionQr = New LoyaltyappDemo.QrDisplay()
        Me.tpSearchTransactions = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.butSearchGenerateReceipt = New System.Windows.Forms.Button()
        Me.butSearch = New System.Windows.Forms.Button()
        Me.cbSearchEnd = New System.Windows.Forms.CheckBox()
        Me.cbSearchStart = New System.Windows.Forms.CheckBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.dtpSearchEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpSearchEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpSearchStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpSearchStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbSearchTransactionStatus = New System.Windows.Forms.ComboBox()
        Me.cmbSearchTransactionType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpReceiptView = New System.Windows.Forms.TabPage()
        Me.butReceiptSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbReceipt = New System.Windows.Forms.PictureBox()
        Me.ssStatusBar = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPoints = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbOpenSession.SuspendLayout()
        Me.tcOperations.SuspendLayout()
        Me.tpVerifyPin.SuspendLayout()
        Me.tpPerformTransaction.SuspendLayout()
        Me.tpSearchTransactions.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReceiptView.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOpenSession
        '
        Me.gbOpenSession.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbOpenSession.Controls.Add(Me.cbUseStaging)
        Me.gbOpenSession.Controls.Add(Me.Label16)
        Me.gbOpenSession.Controls.Add(Me.butLogIn)
        Me.gbOpenSession.Controls.Add(Me.txtUserPin)
        Me.gbOpenSession.Controls.Add(Me.Label3)
        Me.gbOpenSession.Controls.Add(Me.txtUserPassword)
        Me.gbOpenSession.Controls.Add(Me.Label2)
        Me.gbOpenSession.Controls.Add(Me.txtUserEmail)
        Me.gbOpenSession.Controls.Add(Me.Label1)
        Me.gbOpenSession.Location = New System.Drawing.Point(12, 12)
        Me.gbOpenSession.Name = "gbOpenSession"
        Me.gbOpenSession.Size = New System.Drawing.Size(1068, 149)
        Me.gbOpenSession.TabIndex = 0
        Me.gbOpenSession.TabStop = False
        Me.gbOpenSession.Text = "Open/Close Session"
        '
        'cbUseStaging
        '
        Me.cbUseStaging.Checked = True
        Me.cbUseStaging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseStaging.Location = New System.Drawing.Point(114, 97)
        Me.cbUseStaging.Name = "cbUseStaging"
        Me.cbUseStaging.Size = New System.Drawing.Size(17, 17)
        Me.cbUseStaging.TabIndex = 7
        Me.cbUseStaging.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Use Staging Server:"
        '
        'butLogIn
        '
        Me.butLogIn.Location = New System.Drawing.Point(114, 120)
        Me.butLogIn.Name = "butLogIn"
        Me.butLogIn.Size = New System.Drawing.Size(75, 23)
        Me.butLogIn.TabIndex = 8
        Me.butLogIn.Text = "Log In"
        Me.butLogIn.UseVisualStyleBackColor = True
        '
        'txtUserPin
        '
        Me.txtUserPin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserPin.Location = New System.Drawing.Point(114, 71)
        Me.txtUserPin.Name = "txtUserPin"
        Me.txtUserPin.Size = New System.Drawing.Size(948, 20)
        Me.txtUserPin.TabIndex = 5
        Me.txtUserPin.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User PIN:"
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserPassword.Location = New System.Drawing.Point(114, 45)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(948, 20)
        Me.txtUserPassword.TabIndex = 3
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Password:"
        '
        'txtUserEmail
        '
        Me.txtUserEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserEmail.Location = New System.Drawing.Point(114, 19)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(948, 20)
        Me.txtUserEmail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User E-Mail:"
        '
        'tcOperations
        '
        Me.tcOperations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcOperations.Controls.Add(Me.tpVerifyPin)
        Me.tcOperations.Controls.Add(Me.tpPerformTransaction)
        Me.tcOperations.Controls.Add(Me.tpSearchTransactions)
        Me.tcOperations.Controls.Add(Me.tpReceiptView)
        Me.tcOperations.Location = New System.Drawing.Point(12, 167)
        Me.tcOperations.Name = "tcOperations"
        Me.tcOperations.SelectedIndex = 0
        Me.tcOperations.Size = New System.Drawing.Size(1068, 542)
        Me.tcOperations.TabIndex = 1
        '
        'tpVerifyPin
        '
        Me.tpVerifyPin.Controls.Add(Me.Label8)
        Me.tpVerifyPin.Controls.Add(Me.lblVerifyPinStatus)
        Me.tpVerifyPin.Controls.Add(Me.butVerifyPin)
        Me.tpVerifyPin.Controls.Add(Me.txtVerifyPinNumber)
        Me.tpVerifyPin.Controls.Add(Me.Label7)
        Me.tpVerifyPin.Location = New System.Drawing.Point(4, 22)
        Me.tpVerifyPin.Name = "tpVerifyPin"
        Me.tpVerifyPin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVerifyPin.Size = New System.Drawing.Size(1060, 516)
        Me.tpVerifyPin.TabIndex = 3
        Me.tpVerifyPin.Text = "Verify PIN"
        Me.tpVerifyPin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(6, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1048, 449)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PIN verification is useful to check the person operating the POS is the same pers" &
    "on currently logged in."
        '
        'lblVerifyPinStatus
        '
        Me.lblVerifyPinStatus.AutoSize = True
        Me.lblVerifyPinStatus.Location = New System.Drawing.Point(275, 9)
        Me.lblVerifyPinStatus.Name = "lblVerifyPinStatus"
        Me.lblVerifyPinStatus.Size = New System.Drawing.Size(105, 13)
        Me.lblVerifyPinStatus.TabIndex = 2
        Me.lblVerifyPinStatus.Text = "Status: Not checked"
        '
        'butVerifyPin
        '
        Me.butVerifyPin.Location = New System.Drawing.Point(77, 32)
        Me.butVerifyPin.Name = "butVerifyPin"
        Me.butVerifyPin.Size = New System.Drawing.Size(192, 23)
        Me.butVerifyPin.TabIndex = 3
        Me.butVerifyPin.Text = "Verify PIN"
        Me.butVerifyPin.UseVisualStyleBackColor = True
        '
        'txtVerifyPinNumber
        '
        Me.txtVerifyPinNumber.Location = New System.Drawing.Point(77, 6)
        Me.txtVerifyPinNumber.Name = "txtVerifyPinNumber"
        Me.txtVerifyPinNumber.Size = New System.Drawing.Size(192, 20)
        Me.txtVerifyPinNumber.TabIndex = 1
        Me.txtVerifyPinNumber.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PIN Number:"
        '
        'tpPerformTransaction
        '
        Me.tpPerformTransaction.Controls.Add(Me.Label10)
        Me.tpPerformTransaction.Controls.Add(Me.pgTransaction)
        Me.tpPerformTransaction.Controls.Add(Me.butTransactionCheckStatus)
        Me.tpPerformTransaction.Controls.Add(Me.Label9)
        Me.tpPerformTransaction.Controls.Add(Me.lblTransactionStatus)
        Me.tpPerformTransaction.Controls.Add(Me.butTransactionGenerateReceipt)
        Me.tpPerformTransaction.Controls.Add(Me.butTransactionExecute)
        Me.tpPerformTransaction.Controls.Add(Me.txtTransactionAmount)
        Me.tpPerformTransaction.Controls.Add(Me.Label6)
        Me.tpPerformTransaction.Controls.Add(Me.txtTransactionID)
        Me.tpPerformTransaction.Controls.Add(Me.Label5)
        Me.tpPerformTransaction.Controls.Add(Me.cmbTransactionType)
        Me.tpPerformTransaction.Controls.Add(Me.Label4)
        Me.tpPerformTransaction.Controls.Add(Me.qdTransactionQr)
        Me.tpPerformTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tpPerformTransaction.Name = "tpPerformTransaction"
        Me.tpPerformTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPerformTransaction.Size = New System.Drawing.Size(1060, 516)
        Me.tpPerformTransaction.TabIndex = 0
        Me.tpPerformTransaction.Text = "Perform Transaction"
        Me.tpPerformTransaction.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Generated Transaction:"
        '
        'pgTransaction
        '
        Me.pgTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgTransaction.Location = New System.Drawing.Point(450, 41)
        Me.pgTransaction.Name = "pgTransaction"
        Me.pgTransaction.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.pgTransaction.Size = New System.Drawing.Size(604, 469)
        Me.pgTransaction.TabIndex = 14
        '
        'butTransactionCheckStatus
        '
        Me.butTransactionCheckStatus.Enabled = False
        Me.butTransactionCheckStatus.Location = New System.Drawing.Point(105, 143)
        Me.butTransactionCheckStatus.Name = "butTransactionCheckStatus"
        Me.butTransactionCheckStatus.Size = New System.Drawing.Size(192, 23)
        Me.butTransactionCheckStatus.TabIndex = 12
        Me.butTransactionCheckStatus.Text = "Check Status"
        Me.butTransactionCheckStatus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Location = New System.Drawing.Point(6, 175)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(438, 338)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'lblTransactionStatus
        '
        Me.lblTransactionStatus.AutoSize = True
        Me.lblTransactionStatus.Location = New System.Drawing.Point(303, 6)
        Me.lblTransactionStatus.Name = "lblTransactionStatus"
        Me.lblTransactionStatus.Size = New System.Drawing.Size(107, 13)
        Me.lblTransactionStatus.TabIndex = 10
        Me.lblTransactionStatus.Text = "Status: Not executed"
        '
        'butTransactionGenerateReceipt
        '
        Me.butTransactionGenerateReceipt.Enabled = False
        Me.butTransactionGenerateReceipt.Location = New System.Drawing.Point(105, 114)
        Me.butTransactionGenerateReceipt.Name = "butTransactionGenerateReceipt"
        Me.butTransactionGenerateReceipt.Size = New System.Drawing.Size(192, 23)
        Me.butTransactionGenerateReceipt.TabIndex = 9
        Me.butTransactionGenerateReceipt.Text = "Generate Receipt"
        Me.butTransactionGenerateReceipt.UseVisualStyleBackColor = True
        '
        'butTransactionExecute
        '
        Me.butTransactionExecute.Location = New System.Drawing.Point(105, 85)
        Me.butTransactionExecute.Name = "butTransactionExecute"
        Me.butTransactionExecute.Size = New System.Drawing.Size(192, 23)
        Me.butTransactionExecute.TabIndex = 8
        Me.butTransactionExecute.Text = "Execute"
        Me.butTransactionExecute.UseVisualStyleBackColor = True
        '
        'txtTransactionAmount
        '
        Me.txtTransactionAmount.Enabled = False
        Me.txtTransactionAmount.Location = New System.Drawing.Point(105, 59)
        Me.txtTransactionAmount.Name = "txtTransactionAmount"
        Me.txtTransactionAmount.Size = New System.Drawing.Size(192, 20)
        Me.txtTransactionAmount.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amount ($):"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Enabled = False
        Me.txtTransactionID.Location = New System.Drawing.Point(105, 33)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(192, 20)
        Me.txtTransactionID.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Transaction ID:"
        '
        'cmbTransactionType
        '
        Me.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransactionType.FormattingEnabled = True
        Me.cmbTransactionType.Items.AddRange(New Object() {"Pay with Cash", "Pay with Points", "Refund Transaction", "Cancel Transaction"})
        Me.cmbTransactionType.Location = New System.Drawing.Point(105, 6)
        Me.cmbTransactionType.Name = "cmbTransactionType"
        Me.cmbTransactionType.Size = New System.Drawing.Size(192, 21)
        Me.cmbTransactionType.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Transaction Type:"
        '
        'qdTransactionQr
        '
        Me.qdTransactionQr.Location = New System.Drawing.Point(303, 25)
        Me.qdTransactionQr.Name = "qdTransactionQr"
        Me.qdTransactionQr.Size = New System.Drawing.Size(141, 141)
        Me.qdTransactionQr.TabIndex = 13
        '
        'tpSearchTransactions
        '
        Me.tpSearchTransactions.Controls.Add(Me.Label15)
        Me.tpSearchTransactions.Controls.Add(Me.butSearchGenerateReceipt)
        Me.tpSearchTransactions.Controls.Add(Me.butSearch)
        Me.tpSearchTransactions.Controls.Add(Me.cbSearchEnd)
        Me.tpSearchTransactions.Controls.Add(Me.cbSearchStart)
        Me.tpSearchTransactions.Controls.Add(Me.dgvTransactions)
        Me.tpSearchTransactions.Controls.Add(Me.dtpSearchEndTime)
        Me.tpSearchTransactions.Controls.Add(Me.dtpSearchEndDate)
        Me.tpSearchTransactions.Controls.Add(Me.dtpSearchStartTime)
        Me.tpSearchTransactions.Controls.Add(Me.dtpSearchStartDate)
        Me.tpSearchTransactions.Controls.Add(Me.Label14)
        Me.tpSearchTransactions.Controls.Add(Me.Label13)
        Me.tpSearchTransactions.Controls.Add(Me.Label12)
        Me.tpSearchTransactions.Controls.Add(Me.cmbSearchTransactionStatus)
        Me.tpSearchTransactions.Controls.Add(Me.cmbSearchTransactionType)
        Me.tpSearchTransactions.Controls.Add(Me.Label11)
        Me.tpSearchTransactions.Location = New System.Drawing.Point(4, 22)
        Me.tpSearchTransactions.Name = "tpSearchTransactions"
        Me.tpSearchTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearchTransactions.Size = New System.Drawing.Size(1060, 516)
        Me.tpSearchTransactions.TabIndex = 1
        Me.tpSearchTransactions.Text = "Search Transactions"
        Me.tpSearchTransactions.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Location = New System.Drawing.Point(397, 6)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(657, 161)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Transaction searching allows the POS application to retrieve a list of transactio" &
    "ns, filtering by the transaction type, state, and date range."
        '
        'butSearchGenerateReceipt
        '
        Me.butSearchGenerateReceipt.Enabled = False
        Me.butSearchGenerateReceipt.Location = New System.Drawing.Point(106, 141)
        Me.butSearchGenerateReceipt.Name = "butSearchGenerateReceipt"
        Me.butSearchGenerateReceipt.Size = New System.Drawing.Size(285, 23)
        Me.butSearchGenerateReceipt.TabIndex = 17
        Me.butSearchGenerateReceipt.Text = "Generate Receipt"
        Me.butSearchGenerateReceipt.UseVisualStyleBackColor = True
        '
        'butSearch
        '
        Me.butSearch.Location = New System.Drawing.Point(106, 112)
        Me.butSearch.Name = "butSearch"
        Me.butSearch.Size = New System.Drawing.Size(285, 23)
        Me.butSearch.TabIndex = 16
        Me.butSearch.Text = "Search"
        Me.butSearch.UseVisualStyleBackColor = True
        '
        'cbSearchEnd
        '
        Me.cbSearchEnd.Location = New System.Drawing.Point(106, 88)
        Me.cbSearchEnd.Name = "cbSearchEnd"
        Me.cbSearchEnd.Size = New System.Drawing.Size(17, 17)
        Me.cbSearchEnd.TabIndex = 15
        Me.cbSearchEnd.UseVisualStyleBackColor = True
        '
        'cbSearchStart
        '
        Me.cbSearchStart.Location = New System.Drawing.Point(106, 62)
        Me.cbSearchStart.Name = "cbSearchStart"
        Me.cbSearchStart.Size = New System.Drawing.Size(17, 17)
        Me.cbSearchStart.TabIndex = 14
        Me.cbSearchStart.UseVisualStyleBackColor = True
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions.Location = New System.Drawing.Point(6, 170)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.Size = New System.Drawing.Size(1048, 340)
        Me.dgvTransactions.TabIndex = 13
        '
        'dtpSearchEndTime
        '
        Me.dtpSearchEndTime.Enabled = False
        Me.dtpSearchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSearchEndTime.Location = New System.Drawing.Point(263, 86)
        Me.dtpSearchEndTime.Name = "dtpSearchEndTime"
        Me.dtpSearchEndTime.Size = New System.Drawing.Size(128, 20)
        Me.dtpSearchEndTime.TabIndex = 12
        '
        'dtpSearchEndDate
        '
        Me.dtpSearchEndDate.Enabled = False
        Me.dtpSearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchEndDate.Location = New System.Drawing.Point(129, 86)
        Me.dtpSearchEndDate.Name = "dtpSearchEndDate"
        Me.dtpSearchEndDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpSearchEndDate.TabIndex = 11
        '
        'dtpSearchStartTime
        '
        Me.dtpSearchStartTime.Enabled = False
        Me.dtpSearchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSearchStartTime.Location = New System.Drawing.Point(263, 60)
        Me.dtpSearchStartTime.Name = "dtpSearchStartTime"
        Me.dtpSearchStartTime.Size = New System.Drawing.Size(128, 20)
        Me.dtpSearchStartTime.TabIndex = 10
        '
        'dtpSearchStartDate
        '
        Me.dtpSearchStartDate.Enabled = False
        Me.dtpSearchStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchStartDate.Location = New System.Drawing.Point(129, 60)
        Me.dtpSearchStartDate.Name = "dtpSearchStartDate"
        Me.dtpSearchStartDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpSearchStartDate.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "End Timestamp:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Start Timestamp:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Transaction State:"
        '
        'cmbSearchTransactionStatus
        '
        Me.cmbSearchTransactionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchTransactionStatus.FormattingEnabled = True
        Me.cmbSearchTransactionStatus.Items.AddRange(New Object() {"Any", "Pending", "Complete", "Cancelled"})
        Me.cmbSearchTransactionStatus.Location = New System.Drawing.Point(106, 33)
        Me.cmbSearchTransactionStatus.Name = "cmbSearchTransactionStatus"
        Me.cmbSearchTransactionStatus.Size = New System.Drawing.Size(285, 21)
        Me.cmbSearchTransactionStatus.TabIndex = 5
        '
        'cmbSearchTransactionType
        '
        Me.cmbSearchTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchTransactionType.FormattingEnabled = True
        Me.cmbSearchTransactionType.Items.AddRange(New Object() {"Any", "PayWithCash", "PayWithPoints", "Refund"})
        Me.cmbSearchTransactionType.Location = New System.Drawing.Point(106, 6)
        Me.cmbSearchTransactionType.Name = "cmbSearchTransactionType"
        Me.cmbSearchTransactionType.Size = New System.Drawing.Size(285, 21)
        Me.cmbSearchTransactionType.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Transaction Type:"
        '
        'tpReceiptView
        '
        Me.tpReceiptView.Controls.Add(Me.butReceiptSave)
        Me.tpReceiptView.Controls.Add(Me.Panel1)
        Me.tpReceiptView.Location = New System.Drawing.Point(4, 22)
        Me.tpReceiptView.Name = "tpReceiptView"
        Me.tpReceiptView.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReceiptView.Size = New System.Drawing.Size(1060, 516)
        Me.tpReceiptView.TabIndex = 2
        Me.tpReceiptView.Text = "Receipt View"
        Me.tpReceiptView.UseVisualStyleBackColor = True
        '
        'butReceiptSave
        '
        Me.butReceiptSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butReceiptSave.Enabled = False
        Me.butReceiptSave.Location = New System.Drawing.Point(6, 487)
        Me.butReceiptSave.Name = "butReceiptSave"
        Me.butReceiptSave.Size = New System.Drawing.Size(192, 23)
        Me.butReceiptSave.TabIndex = 13
        Me.butReceiptSave.Text = "Save Image..."
        Me.butReceiptSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pbReceipt)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 475)
        Me.Panel1.TabIndex = 0
        '
        'pbReceipt
        '
        Me.pbReceipt.Location = New System.Drawing.Point(0, 0)
        Me.pbReceipt.Margin = New System.Windows.Forms.Padding(0)
        Me.pbReceipt.Name = "pbReceipt"
        Me.pbReceipt.Size = New System.Drawing.Size(100, 50)
        Me.pbReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbReceipt.TabIndex = 0
        Me.pbReceipt.TabStop = False
        '
        'ssStatusBar
        '
        Me.ssStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslPoints})
        Me.ssStatusBar.Location = New System.Drawing.Point(0, 712)
        Me.ssStatusBar.Name = "ssStatusBar"
        Me.ssStatusBar.Size = New System.Drawing.Size(1092, 22)
        Me.ssStatusBar.TabIndex = 2
        Me.ssStatusBar.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(1028, 17)
        Me.tsslStatus.Spring = True
        Me.tsslStatus.Text = "Not logged in"
        Me.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsslPoints
        '
        Me.tsslPoints.Name = "tsslPoints"
        Me.tsslPoints.Size = New System.Drawing.Size(49, 17)
        Me.tsslPoints.Text = "0 points"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 734)
        Me.Controls.Add(Me.ssStatusBar)
        Me.Controls.Add(Me.tcOperations)
        Me.Controls.Add(Me.gbOpenSession)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Loyaltyapp API Demo"
        Me.gbOpenSession.ResumeLayout(False)
        Me.gbOpenSession.PerformLayout()
        Me.tcOperations.ResumeLayout(False)
        Me.tpVerifyPin.ResumeLayout(False)
        Me.tpVerifyPin.PerformLayout()
        Me.tpPerformTransaction.ResumeLayout(False)
        Me.tpPerformTransaction.PerformLayout()
        Me.tpSearchTransactions.ResumeLayout(False)
        Me.tpSearchTransactions.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReceiptView.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssStatusBar.ResumeLayout(False)
        Me.ssStatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbOpenSession As GroupBox
    Friend WithEvents txtUserPin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents butLogIn As Button
    Friend WithEvents tcOperations As TabControl
    Friend WithEvents tpPerformTransaction As TabPage
    Friend WithEvents tpSearchTransactions As TabPage
    Friend WithEvents ssStatusBar As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tsslPoints As ToolStripStatusLabel
    Friend WithEvents tpReceiptView As TabPage
    Friend WithEvents cmbTransactionType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents txtTransactionAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tpVerifyPin As TabPage
    Friend WithEvents txtVerifyPinNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents butVerifyPin As Button
    Friend WithEvents lblVerifyPinStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents butTransactionGenerateReceipt As Button
    Friend WithEvents butTransactionExecute As Button
    Friend WithEvents lblTransactionStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents butTransactionCheckStatus As Button
    Friend WithEvents qdTransactionQr As QrDisplay
    Friend WithEvents pgTransaction As PropertyGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbReceipt As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbSearchTransactionType As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbSearchTransactionStatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpSearchEndTime As DateTimePicker
    Friend WithEvents dtpSearchEndDate As DateTimePicker
    Friend WithEvents dtpSearchStartTime As DateTimePicker
    Friend WithEvents dtpSearchStartDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents cbSearchEnd As CheckBox
    Friend WithEvents cbSearchStart As CheckBox
    Friend WithEvents butSearch As Button
    Friend WithEvents butSearchGenerateReceipt As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents butReceiptSave As Button
    Friend WithEvents cbUseStaging As CheckBox
    Friend WithEvents Label16 As Label
End Class
