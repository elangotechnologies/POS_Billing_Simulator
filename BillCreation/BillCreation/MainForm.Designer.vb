<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbEntityGrid = New System.Windows.Forms.GroupBox()
        Me.dgvEntities = New System.Windows.Forms.DataGridView()
        Me.entityId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.building = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.state = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taxPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distanceFromHotel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distanceFromOffice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEntityStreet = New System.Windows.Forms.TextBox()
        Me.txtEntityCity = New System.Windows.Forms.TextBox()
        Me.txtEntityState = New System.Windows.Forms.TextBox()
        Me.txtEntityCountry = New System.Windows.Forms.TextBox()
        Me.txtEntityPin = New System.Windows.Forms.TextBox()
        Me.txtEntityBillHeight = New System.Windows.Forms.TextBox()
        Me.txtEntityBillWidth = New System.Windows.Forms.TextBox()
        Me.txtEntityTaxPercent = New System.Windows.Forms.TextBox()
        Me.txtEntityBuilding = New System.Windows.Forms.TextBox()
        Me.btnEntityAdd = New System.Windows.Forms.Button()
        Me.btnEntityDelete = New System.Windows.Forms.Button()
        Me.btnEntityUpdate = New System.Windows.Forms.Button()
        Me.cmbEntityList = New System.Windows.Forms.ComboBox()
        Me.cmbEntityTypeList = New System.Windows.Forms.ComboBox()
        Me.btnEntityClear = New System.Windows.Forms.Button()
        Me.gbEntities = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEntityDistanceFromOffice = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEntityDistanceFromHotel = New System.Windows.Forms.TextBox()
        Me.gbItems = New System.Windows.Forms.GroupBox()
        Me.cmbItemCategoryList = New System.Windows.Forms.ComboBox()
        Me.btnItemClear = New System.Windows.Forms.Button()
        Me.gbItemGrid = New System.Windows.Forms.GroupBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.itemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbItemList = New System.Windows.Forms.ComboBox()
        Me.btnItemUpdate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnItemDelete = New System.Windows.Forms.Button()
        Me.btnItemAdd = New System.Windows.Forms.Button()
        Me.gbItemsPrice = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbItemPriceIdList = New System.Windows.Forms.ComboBox()
        Me.cmbItemPriceItemCategoryList = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtItemPricePrice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbItemPriceItemList = New System.Windows.Forms.ComboBox()
        Me.btnItemPriceClear = New System.Windows.Forms.Button()
        Me.gbItemPrice = New System.Windows.Forms.GroupBox()
        Me.dgvItemPrice = New System.Windows.Forms.DataGridView()
        Me.itemPriceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceIdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceEntityId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceEntityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceItemCategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPricePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbItemPriceEntityList = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnItemPriceUpdate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnItemPriceDelete = New System.Windows.Forms.Button()
        Me.btnItemPriceAdd = New System.Windows.Forms.Button()
        Me.tvBillsBillItems = New System.Windows.Forms.TreeView()
        Me.gbBillSelectionItems = New System.Windows.Forms.GroupBox()
        Me.gbBills = New System.Windows.Forms.GroupBox()
        Me.gbItemsQty = New System.Windows.Forms.GroupBox()
        Me.dgvBillsItemsQty = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsItemQtyItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsItemQtyItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsItemQtyQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBillsTaxPercent = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtBillsPlaceCameFrom = New System.Windows.Forms.TextBox()
        Me.txtBillsItemPriceIds = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtBillsRemarks = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtBillsFinalBillAmount = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtBillsTaxAmount = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtBillsItemTotalPrice = New System.Windows.Forms.TextBox()
        Me.cmbBillsBillIdList = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBillsDisplayBillId = New System.Windows.Forms.TextBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.btnBillsUpdate = New System.Windows.Forms.Button()
        Me.btnBillsDelete = New System.Windows.Forms.Button()
        Me.btnBillsAdd = New System.Windows.Forms.Button()
        Me.dtpBillsBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbBillsEntityList = New System.Windows.Forms.ComboBox()
        Me.gbBillsBills = New System.Windows.Forms.GroupBox()
        Me.dgvBillsBillGrid = New System.Windows.Forms.DataGridView()
        Me.billsEntity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsBillName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsBillId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsDisplayBillId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsItemPriceIds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsItemsTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsTaxAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsBillAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillsPlaceCameFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.crvBillReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gbBillReport = New System.Windows.Forms.GroupBox()
        Me.gbEntityGrid.SuspendLayout()
        CType(Me.dgvEntities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEntities.SuspendLayout()
        Me.gbItems.SuspendLayout()
        Me.gbItemGrid.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemsPrice.SuspendLayout()
        Me.gbItemPrice.SuspendLayout()
        CType(Me.dgvItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBillSelectionItems.SuspendLayout()
        Me.gbBills.SuspendLayout()
        Me.gbItemsQty.SuspendLayout()
        CType(Me.dgvBillsItemsQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBillsBills.SuspendLayout()
        CType(Me.dgvBillsBillGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBillReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEntityGrid
        '
        Me.gbEntityGrid.Controls.Add(Me.dgvEntities)
        Me.gbEntityGrid.Location = New System.Drawing.Point(8, 192)
        Me.gbEntityGrid.Name = "gbEntityGrid"
        Me.gbEntityGrid.Size = New System.Drawing.Size(786, 191)
        Me.gbEntityGrid.TabIndex = 14
        Me.gbEntityGrid.TabStop = False
        '
        'dgvEntities
        '
        Me.dgvEntities.AllowUserToAddRows = False
        Me.dgvEntities.AllowUserToDeleteRows = False
        Me.dgvEntities.AllowUserToResizeRows = False
        Me.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntities.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.entityId, Me.entityName, Me.building, Me.street, Me.city, Me.state, Me.country, Me.pin, Me.type, Me.billHeight, Me.billWidth, Me.taxPercent, Me.distanceFromHotel, Me.distanceFromOffice})
        Me.dgvEntities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntities.Location = New System.Drawing.Point(3, 16)
        Me.dgvEntities.Name = "dgvEntities"
        Me.dgvEntities.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEntities.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntities.Size = New System.Drawing.Size(780, 172)
        Me.dgvEntities.TabIndex = 0
        '
        'entityId
        '
        Me.entityId.DataPropertyName = "id"
        Me.entityId.Frozen = True
        Me.entityId.HeaderText = "id"
        Me.entityId.Name = "entityId"
        Me.entityId.Width = 50
        '
        'entityName
        '
        Me.entityName.DataPropertyName = "name"
        Me.entityName.HeaderText = "name"
        Me.entityName.Name = "entityName"
        '
        'building
        '
        Me.building.DataPropertyName = "building"
        Me.building.HeaderText = "building"
        Me.building.Name = "building"
        '
        'street
        '
        Me.street.DataPropertyName = "street"
        Me.street.HeaderText = "street"
        Me.street.Name = "street"
        '
        'city
        '
        Me.city.DataPropertyName = "city"
        Me.city.HeaderText = "city"
        Me.city.Name = "city"
        '
        'state
        '
        Me.state.DataPropertyName = "state"
        Me.state.HeaderText = "state"
        Me.state.Name = "state"
        '
        'country
        '
        Me.country.DataPropertyName = "country"
        Me.country.HeaderText = "country"
        Me.country.Name = "country"
        '
        'pin
        '
        Me.pin.DataPropertyName = "pin"
        Me.pin.HeaderText = "pin"
        Me.pin.Name = "pin"
        '
        'type
        '
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "type"
        Me.type.Name = "type"
        '
        'billHeight
        '
        Me.billHeight.DataPropertyName = "billHeight"
        Me.billHeight.HeaderText = "billHeight"
        Me.billHeight.Name = "billHeight"
        '
        'billWidth
        '
        Me.billWidth.DataPropertyName = "billWidth"
        Me.billWidth.HeaderText = "billWidth"
        Me.billWidth.Name = "billWidth"
        '
        'taxPercent
        '
        Me.taxPercent.DataPropertyName = "taxPercent"
        Me.taxPercent.HeaderText = "taxPercent"
        Me.taxPercent.Name = "taxPercent"
        '
        'distanceFromHotel
        '
        Me.distanceFromHotel.DataPropertyName = "distanceFromHotel"
        Me.distanceFromHotel.HeaderText = "distanceFromHotel"
        Me.distanceFromHotel.Name = "distanceFromHotel"
        '
        'distanceFromOffice
        '
        Me.distanceFromOffice.DataPropertyName = "distanceFromOffice"
        Me.distanceFromOffice.HeaderText = "distanceFromOffice"
        Me.distanceFromOffice.Name = "distanceFromOffice"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(53, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "building"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "street"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "city"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "state"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "pin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(375, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "billHeight"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(375, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "billWidth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(375, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "taxPercent"
        '
        'txtEntityStreet
        '
        Me.txtEntityStreet.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityStreet.Location = New System.Drawing.Point(130, 59)
        Me.txtEntityStreet.Name = "txtEntityStreet"
        Me.txtEntityStreet.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityStreet.TabIndex = 2
        '
        'txtEntityCity
        '
        Me.txtEntityCity.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityCity.Location = New System.Drawing.Point(130, 78)
        Me.txtEntityCity.Name = "txtEntityCity"
        Me.txtEntityCity.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityCity.TabIndex = 3
        '
        'txtEntityState
        '
        Me.txtEntityState.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityState.Location = New System.Drawing.Point(130, 97)
        Me.txtEntityState.Name = "txtEntityState"
        Me.txtEntityState.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityState.TabIndex = 4
        '
        'txtEntityCountry
        '
        Me.txtEntityCountry.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityCountry.Location = New System.Drawing.Point(130, 116)
        Me.txtEntityCountry.Name = "txtEntityCountry"
        Me.txtEntityCountry.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityCountry.TabIndex = 5
        '
        'txtEntityPin
        '
        Me.txtEntityPin.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityPin.Location = New System.Drawing.Point(490, 18)
        Me.txtEntityPin.Name = "txtEntityPin"
        Me.txtEntityPin.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityPin.TabIndex = 6
        '
        'txtEntityBillHeight
        '
        Me.txtEntityBillHeight.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityBillHeight.Location = New System.Drawing.Point(490, 58)
        Me.txtEntityBillHeight.Name = "txtEntityBillHeight"
        Me.txtEntityBillHeight.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityBillHeight.TabIndex = 8
        '
        'txtEntityBillWidth
        '
        Me.txtEntityBillWidth.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityBillWidth.Location = New System.Drawing.Point(490, 77)
        Me.txtEntityBillWidth.Name = "txtEntityBillWidth"
        Me.txtEntityBillWidth.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityBillWidth.TabIndex = 9
        '
        'txtEntityTaxPercent
        '
        Me.txtEntityTaxPercent.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityTaxPercent.Location = New System.Drawing.Point(490, 96)
        Me.txtEntityTaxPercent.Name = "txtEntityTaxPercent"
        Me.txtEntityTaxPercent.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityTaxPercent.TabIndex = 10
        '
        'txtEntityBuilding
        '
        Me.txtEntityBuilding.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityBuilding.Location = New System.Drawing.Point(130, 40)
        Me.txtEntityBuilding.Name = "txtEntityBuilding"
        Me.txtEntityBuilding.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityBuilding.TabIndex = 1
        '
        'btnEntityAdd
        '
        Me.btnEntityAdd.Location = New System.Drawing.Point(203, 165)
        Me.btnEntityAdd.Name = "btnEntityAdd"
        Me.btnEntityAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnEntityAdd.TabIndex = 11
        Me.btnEntityAdd.Text = "Add"
        Me.btnEntityAdd.UseVisualStyleBackColor = True
        '
        'btnEntityDelete
        '
        Me.btnEntityDelete.Location = New System.Drawing.Point(366, 165)
        Me.btnEntityDelete.Name = "btnEntityDelete"
        Me.btnEntityDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnEntityDelete.TabIndex = 13
        Me.btnEntityDelete.Text = "Delete"
        Me.btnEntityDelete.UseVisualStyleBackColor = True
        '
        'btnEntityUpdate
        '
        Me.btnEntityUpdate.Location = New System.Drawing.Point(285, 165)
        Me.btnEntityUpdate.Name = "btnEntityUpdate"
        Me.btnEntityUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnEntityUpdate.TabIndex = 12
        Me.btnEntityUpdate.Text = "Update"
        Me.btnEntityUpdate.UseVisualStyleBackColor = True
        '
        'cmbEntityList
        '
        Me.cmbEntityList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEntityList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEntityList.DisplayMember = "name"
        Me.cmbEntityList.FormattingEnabled = True
        Me.cmbEntityList.Location = New System.Drawing.Point(130, 18)
        Me.cmbEntityList.Name = "cmbEntityList"
        Me.cmbEntityList.Size = New System.Drawing.Size(209, 21)
        Me.cmbEntityList.TabIndex = 0
        Me.cmbEntityList.ValueMember = "id"
        '
        'cmbEntityTypeList
        '
        Me.cmbEntityTypeList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEntityTypeList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEntityTypeList.DisplayMember = "name"
        Me.cmbEntityTypeList.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.cmbEntityTypeList.FormattingEnabled = True
        Me.cmbEntityTypeList.Location = New System.Drawing.Point(490, 37)
        Me.cmbEntityTypeList.Name = "cmbEntityTypeList"
        Me.cmbEntityTypeList.Size = New System.Drawing.Size(209, 20)
        Me.cmbEntityTypeList.TabIndex = 7
        Me.cmbEntityTypeList.Text = " Restaurant"
        Me.cmbEntityTypeList.ValueMember = "id"
        '
        'btnEntityClear
        '
        Me.btnEntityClear.Location = New System.Drawing.Point(452, 165)
        Me.btnEntityClear.Name = "btnEntityClear"
        Me.btnEntityClear.Size = New System.Drawing.Size(75, 23)
        Me.btnEntityClear.TabIndex = 15
        Me.btnEntityClear.Text = "Clear"
        Me.btnEntityClear.UseVisualStyleBackColor = True
        '
        'gbEntities
        '
        Me.gbEntities.Controls.Add(Me.Label24)
        Me.gbEntities.Controls.Add(Me.Label25)
        Me.gbEntities.Controls.Add(Me.txtEntityDistanceFromOffice)
        Me.gbEntities.Controls.Add(Me.Label23)
        Me.gbEntities.Controls.Add(Me.Label22)
        Me.gbEntities.Controls.Add(Me.txtEntityDistanceFromHotel)
        Me.gbEntities.Controls.Add(Me.btnEntityClear)
        Me.gbEntities.Controls.Add(Me.txtEntityStreet)
        Me.gbEntities.Controls.Add(Me.cmbEntityTypeList)
        Me.gbEntities.Controls.Add(Me.gbEntityGrid)
        Me.gbEntities.Controls.Add(Me.cmbEntityList)
        Me.gbEntities.Controls.Add(Me.lblName)
        Me.gbEntities.Controls.Add(Me.btnEntityUpdate)
        Me.gbEntities.Controls.Add(Me.Label1)
        Me.gbEntities.Controls.Add(Me.btnEntityDelete)
        Me.gbEntities.Controls.Add(Me.Label2)
        Me.gbEntities.Controls.Add(Me.btnEntityAdd)
        Me.gbEntities.Controls.Add(Me.Label3)
        Me.gbEntities.Controls.Add(Me.txtEntityBuilding)
        Me.gbEntities.Controls.Add(Me.Label4)
        Me.gbEntities.Controls.Add(Me.txtEntityTaxPercent)
        Me.gbEntities.Controls.Add(Me.Label5)
        Me.gbEntities.Controls.Add(Me.txtEntityBillWidth)
        Me.gbEntities.Controls.Add(Me.Label6)
        Me.gbEntities.Controls.Add(Me.txtEntityBillHeight)
        Me.gbEntities.Controls.Add(Me.Label7)
        Me.gbEntities.Controls.Add(Me.txtEntityPin)
        Me.gbEntities.Controls.Add(Me.Label8)
        Me.gbEntities.Controls.Add(Me.txtEntityCountry)
        Me.gbEntities.Controls.Add(Me.Label9)
        Me.gbEntities.Controls.Add(Me.txtEntityState)
        Me.gbEntities.Controls.Add(Me.Label10)
        Me.gbEntities.Controls.Add(Me.txtEntityCity)
        Me.gbEntities.Location = New System.Drawing.Point(12, 12)
        Me.gbEntities.Name = "gbEntities"
        Me.gbEntities.Size = New System.Drawing.Size(810, 394)
        Me.gbEntities.TabIndex = 16
        Me.gbEntities.TabStop = False
        Me.gbEntities.Text = "Entities"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(699, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "miles"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(375, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 13)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "distanceFromOffice"
        '
        'txtEntityDistanceFromOffice
        '
        Me.txtEntityDistanceFromOffice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityDistanceFromOffice.Location = New System.Drawing.Point(490, 134)
        Me.txtEntityDistanceFromOffice.Name = "txtEntityDistanceFromOffice"
        Me.txtEntityDistanceFromOffice.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityDistanceFromOffice.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(699, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "miles"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(375, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "distanceFromHotel"
        '
        'txtEntityDistanceFromHotel
        '
        Me.txtEntityDistanceFromHotel.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntityDistanceFromHotel.Location = New System.Drawing.Point(490, 115)
        Me.txtEntityDistanceFromHotel.Name = "txtEntityDistanceFromHotel"
        Me.txtEntityDistanceFromHotel.Size = New System.Drawing.Size(209, 18)
        Me.txtEntityDistanceFromHotel.TabIndex = 16
        '
        'gbItems
        '
        Me.gbItems.Controls.Add(Me.cmbItemCategoryList)
        Me.gbItems.Controls.Add(Me.btnItemClear)
        Me.gbItems.Controls.Add(Me.gbItemGrid)
        Me.gbItems.Controls.Add(Me.cmbItemList)
        Me.gbItems.Controls.Add(Me.btnItemUpdate)
        Me.gbItems.Controls.Add(Me.Label11)
        Me.gbItems.Controls.Add(Me.Label12)
        Me.gbItems.Controls.Add(Me.btnItemDelete)
        Me.gbItems.Controls.Add(Me.btnItemAdd)
        Me.gbItems.Location = New System.Drawing.Point(835, 12)
        Me.gbItems.Name = "gbItems"
        Me.gbItems.Size = New System.Drawing.Size(350, 394)
        Me.gbItems.TabIndex = 17
        Me.gbItems.TabStop = False
        Me.gbItems.Text = "Items"
        '
        'cmbItemCategoryList
        '
        Me.cmbItemCategoryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemCategoryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemCategoryList.DisplayMember = "name"
        Me.cmbItemCategoryList.FormattingEnabled = True
        Me.cmbItemCategoryList.Location = New System.Drawing.Point(88, 38)
        Me.cmbItemCategoryList.Name = "cmbItemCategoryList"
        Me.cmbItemCategoryList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemCategoryList.TabIndex = 1
        Me.cmbItemCategoryList.ValueMember = "id"
        '
        'btnItemClear
        '
        Me.btnItemClear.Location = New System.Drawing.Point(260, 115)
        Me.btnItemClear.Name = "btnItemClear"
        Me.btnItemClear.Size = New System.Drawing.Size(75, 23)
        Me.btnItemClear.TabIndex = 5
        Me.btnItemClear.Text = "Clear"
        Me.btnItemClear.UseVisualStyleBackColor = True
        '
        'gbItemGrid
        '
        Me.gbItemGrid.Controls.Add(Me.dgvItems)
        Me.gbItemGrid.Location = New System.Drawing.Point(12, 187)
        Me.gbItemGrid.Name = "gbItemGrid"
        Me.gbItemGrid.Size = New System.Drawing.Size(323, 191)
        Me.gbItemGrid.TabIndex = 6
        Me.gbItemGrid.TabStop = False
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemId, Me.itemName, Me.categoryName, Me.categoryId})
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.Location = New System.Drawing.Point(3, 16)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(317, 172)
        Me.dgvItems.TabIndex = 0
        '
        'itemId
        '
        Me.itemId.DataPropertyName = "id"
        Me.itemId.Frozen = True
        Me.itemId.HeaderText = "id"
        Me.itemId.Name = "itemId"
        Me.itemId.Width = 50
        '
        'itemName
        '
        Me.itemName.DataPropertyName = "name"
        Me.itemName.HeaderText = "name"
        Me.itemName.Name = "itemName"
        '
        'categoryName
        '
        Me.categoryName.DataPropertyName = "categoryName"
        Me.categoryName.HeaderText = "category"
        Me.categoryName.Name = "categoryName"
        '
        'categoryId
        '
        Me.categoryId.DataPropertyName = "categoryId"
        Me.categoryId.HeaderText = "categoryId"
        Me.categoryId.Name = "categoryId"
        Me.categoryId.Visible = False
        '
        'cmbItemList
        '
        Me.cmbItemList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemList.DisplayMember = "name"
        Me.cmbItemList.FormattingEnabled = True
        Me.cmbItemList.Location = New System.Drawing.Point(88, 66)
        Me.cmbItemList.Name = "cmbItemList"
        Me.cmbItemList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemList.TabIndex = 0
        Me.cmbItemList.ValueMember = "id"
        '
        'btnItemUpdate
        '
        Me.btnItemUpdate.Location = New System.Drawing.Point(93, 115)
        Me.btnItemUpdate.Name = "btnItemUpdate"
        Me.btnItemUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnItemUpdate.TabIndex = 3
        Me.btnItemUpdate.Text = "Update"
        Me.btnItemUpdate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "category"
        '
        'btnItemDelete
        '
        Me.btnItemDelete.Location = New System.Drawing.Point(174, 115)
        Me.btnItemDelete.Name = "btnItemDelete"
        Me.btnItemDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnItemDelete.TabIndex = 4
        Me.btnItemDelete.Text = "Delete"
        Me.btnItemDelete.UseVisualStyleBackColor = True
        '
        'btnItemAdd
        '
        Me.btnItemAdd.Location = New System.Drawing.Point(11, 115)
        Me.btnItemAdd.Name = "btnItemAdd"
        Me.btnItemAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnItemAdd.TabIndex = 2
        Me.btnItemAdd.Text = "Add"
        Me.btnItemAdd.UseVisualStyleBackColor = True
        '
        'gbItemsPrice
        '
        Me.gbItemsPrice.Controls.Add(Me.Label18)
        Me.gbItemsPrice.Controls.Add(Me.cmbItemPriceIdList)
        Me.gbItemsPrice.Controls.Add(Me.cmbItemPriceItemCategoryList)
        Me.gbItemsPrice.Controls.Add(Me.Label16)
        Me.gbItemsPrice.Controls.Add(Me.Label17)
        Me.gbItemsPrice.Controls.Add(Me.txtItemPricePrice)
        Me.gbItemsPrice.Controls.Add(Me.Label15)
        Me.gbItemsPrice.Controls.Add(Me.cmbItemPriceItemList)
        Me.gbItemsPrice.Controls.Add(Me.btnItemPriceClear)
        Me.gbItemsPrice.Controls.Add(Me.gbItemPrice)
        Me.gbItemsPrice.Controls.Add(Me.cmbItemPriceEntityList)
        Me.gbItemsPrice.Controls.Add(Me.Label13)
        Me.gbItemsPrice.Controls.Add(Me.btnItemPriceUpdate)
        Me.gbItemsPrice.Controls.Add(Me.Label14)
        Me.gbItemsPrice.Controls.Add(Me.btnItemPriceDelete)
        Me.gbItemsPrice.Controls.Add(Me.btnItemPriceAdd)
        Me.gbItemsPrice.Location = New System.Drawing.Point(1203, 12)
        Me.gbItemsPrice.Name = "gbItemsPrice"
        Me.gbItemsPrice.Size = New System.Drawing.Size(389, 394)
        Me.gbItemsPrice.TabIndex = 0
        Me.gbItemsPrice.TabStop = False
        Me.gbItemsPrice.Text = "Items Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(306, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 12)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Auto Generated"
        '
        'cmbItemPriceIdList
        '
        Me.cmbItemPriceIdList.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.cmbItemPriceIdList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemPriceIdList.DisplayMember = "name"
        Me.cmbItemPriceIdList.FormattingEnabled = True
        Me.cmbItemPriceIdList.Location = New System.Drawing.Point(93, 44)
        Me.cmbItemPriceIdList.Name = "cmbItemPriceIdList"
        Me.cmbItemPriceIdList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemPriceIdList.TabIndex = 1
        Me.cmbItemPriceIdList.ValueMember = "id"
        '
        'cmbItemPriceItemCategoryList
        '
        Me.cmbItemPriceItemCategoryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemPriceItemCategoryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemPriceItemCategoryList.DisplayMember = "name"
        Me.cmbItemPriceItemCategoryList.FormattingEnabled = True
        Me.cmbItemPriceItemCategoryList.Location = New System.Drawing.Point(93, 71)
        Me.cmbItemPriceItemCategoryList.Name = "cmbItemPriceItemCategoryList"
        Me.cmbItemPriceItemCategoryList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemPriceItemCategoryList.TabIndex = 2
        Me.cmbItemPriceItemCategoryList.ValueMember = "id"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "category"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "ItemPrice Id"
        '
        'txtItemPricePrice
        '
        Me.txtItemPricePrice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPricePrice.Location = New System.Drawing.Point(93, 121)
        Me.txtItemPricePrice.Name = "txtItemPricePrice"
        Me.txtItemPricePrice.Size = New System.Drawing.Size(209, 18)
        Me.txtItemPricePrice.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "price"
        '
        'cmbItemPriceItemList
        '
        Me.cmbItemPriceItemList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemPriceItemList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemPriceItemList.DisplayMember = "name"
        Me.cmbItemPriceItemList.FormattingEnabled = True
        Me.cmbItemPriceItemList.Location = New System.Drawing.Point(93, 96)
        Me.cmbItemPriceItemList.Name = "cmbItemPriceItemList"
        Me.cmbItemPriceItemList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemPriceItemList.TabIndex = 3
        Me.cmbItemPriceItemList.ValueMember = "id"
        '
        'btnItemPriceClear
        '
        Me.btnItemPriceClear.Location = New System.Drawing.Point(275, 154)
        Me.btnItemPriceClear.Name = "btnItemPriceClear"
        Me.btnItemPriceClear.Size = New System.Drawing.Size(75, 23)
        Me.btnItemPriceClear.TabIndex = 8
        Me.btnItemPriceClear.Text = "Clear"
        Me.btnItemPriceClear.UseVisualStyleBackColor = True
        '
        'gbItemPrice
        '
        Me.gbItemPrice.Controls.Add(Me.dgvItemPrice)
        Me.gbItemPrice.Location = New System.Drawing.Point(9, 187)
        Me.gbItemPrice.Name = "gbItemPrice"
        Me.gbItemPrice.Size = New System.Drawing.Size(367, 191)
        Me.gbItemPrice.TabIndex = 9
        Me.gbItemPrice.TabStop = False
        '
        'dgvItemPrice
        '
        Me.dgvItemPrice.AllowUserToAddRows = False
        Me.dgvItemPrice.AllowUserToDeleteRows = False
        Me.dgvItemPrice.AllowUserToResizeRows = False
        Me.dgvItemPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemPrice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemPriceId, Me.itemPriceIdName, Me.itemPriceEntityId, Me.itemPriceEntityName, Me.itemPriceItemId, Me.itemPriceItemName, Me.itemPriceItemCategoryName, Me.itemPricePrice})
        Me.dgvItemPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItemPrice.Location = New System.Drawing.Point(3, 16)
        Me.dgvItemPrice.Name = "dgvItemPrice"
        Me.dgvItemPrice.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvItemPrice.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemPrice.Size = New System.Drawing.Size(361, 172)
        Me.dgvItemPrice.TabIndex = 0
        '
        'itemPriceId
        '
        Me.itemPriceId.DataPropertyName = "id"
        Me.itemPriceId.Frozen = True
        Me.itemPriceId.HeaderText = "id"
        Me.itemPriceId.Name = "itemPriceId"
        Me.itemPriceId.Width = 50
        '
        'itemPriceIdName
        '
        Me.itemPriceIdName.DataPropertyName = "name"
        Me.itemPriceIdName.HeaderText = "itemPriceIdName"
        Me.itemPriceIdName.Name = "itemPriceIdName"
        Me.itemPriceIdName.Visible = False
        '
        'itemPriceEntityId
        '
        Me.itemPriceEntityId.DataPropertyName = "entityId"
        Me.itemPriceEntityId.HeaderText = "entityId"
        Me.itemPriceEntityId.Name = "itemPriceEntityId"
        Me.itemPriceEntityId.Visible = False
        '
        'itemPriceEntityName
        '
        Me.itemPriceEntityName.DataPropertyName = "entityName"
        Me.itemPriceEntityName.HeaderText = "entity"
        Me.itemPriceEntityName.Name = "itemPriceEntityName"
        '
        'itemPriceItemId
        '
        Me.itemPriceItemId.DataPropertyName = "itemId"
        Me.itemPriceItemId.HeaderText = "itemId"
        Me.itemPriceItemId.Name = "itemPriceItemId"
        Me.itemPriceItemId.Visible = False
        '
        'itemPriceItemName
        '
        Me.itemPriceItemName.DataPropertyName = "itemName"
        Me.itemPriceItemName.HeaderText = "item"
        Me.itemPriceItemName.Name = "itemPriceItemName"
        '
        'itemPriceItemCategoryName
        '
        Me.itemPriceItemCategoryName.DataPropertyName = "categoryName"
        Me.itemPriceItemCategoryName.HeaderText = "ItemCategory"
        Me.itemPriceItemCategoryName.Name = "itemPriceItemCategoryName"
        '
        'itemPricePrice
        '
        Me.itemPricePrice.DataPropertyName = "price"
        Me.itemPricePrice.HeaderText = "price"
        Me.itemPricePrice.Name = "itemPricePrice"
        '
        'cmbItemPriceEntityList
        '
        Me.cmbItemPriceEntityList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemPriceEntityList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemPriceEntityList.DisplayMember = "name"
        Me.cmbItemPriceEntityList.FormattingEnabled = True
        Me.cmbItemPriceEntityList.Location = New System.Drawing.Point(93, 18)
        Me.cmbItemPriceEntityList.Name = "cmbItemPriceEntityList"
        Me.cmbItemPriceEntityList.Size = New System.Drawing.Size(209, 21)
        Me.cmbItemPriceEntityList.TabIndex = 0
        Me.cmbItemPriceEntityList.ValueMember = "id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "entity"
        '
        'btnItemPriceUpdate
        '
        Me.btnItemPriceUpdate.Location = New System.Drawing.Point(108, 154)
        Me.btnItemPriceUpdate.Name = "btnItemPriceUpdate"
        Me.btnItemPriceUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnItemPriceUpdate.TabIndex = 6
        Me.btnItemPriceUpdate.Text = "Update"
        Me.btnItemPriceUpdate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "item"
        '
        'btnItemPriceDelete
        '
        Me.btnItemPriceDelete.Location = New System.Drawing.Point(189, 154)
        Me.btnItemPriceDelete.Name = "btnItemPriceDelete"
        Me.btnItemPriceDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnItemPriceDelete.TabIndex = 7
        Me.btnItemPriceDelete.Text = "Delete"
        Me.btnItemPriceDelete.UseVisualStyleBackColor = True
        '
        'btnItemPriceAdd
        '
        Me.btnItemPriceAdd.Location = New System.Drawing.Point(26, 154)
        Me.btnItemPriceAdd.Name = "btnItemPriceAdd"
        Me.btnItemPriceAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnItemPriceAdd.TabIndex = 5
        Me.btnItemPriceAdd.Text = "Add"
        Me.btnItemPriceAdd.UseVisualStyleBackColor = True
        '
        'tvBillsBillItems
        '
        Me.tvBillsBillItems.CheckBoxes = True
        Me.tvBillsBillItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvBillsBillItems.Location = New System.Drawing.Point(3, 16)
        Me.tvBillsBillItems.Name = "tvBillsBillItems"
        Me.tvBillsBillItems.Size = New System.Drawing.Size(259, 351)
        Me.tvBillsBillItems.TabIndex = 18
        '
        'gbBillSelectionItems
        '
        Me.gbBillSelectionItems.Controls.Add(Me.tvBillsBillItems)
        Me.gbBillSelectionItems.Location = New System.Drawing.Point(340, 11)
        Me.gbBillSelectionItems.Name = "gbBillSelectionItems"
        Me.gbBillSelectionItems.Size = New System.Drawing.Size(265, 370)
        Me.gbBillSelectionItems.TabIndex = 19
        Me.gbBillSelectionItems.TabStop = False
        Me.gbBillSelectionItems.Text = "Select items to bill"
        '
        'gbBills
        '
        Me.gbBills.Controls.Add(Me.gbItemsQty)
        Me.gbBills.Controls.Add(Me.Label21)
        Me.gbBills.Controls.Add(Me.txtBillsTaxPercent)
        Me.gbBills.Controls.Add(Me.Label33)
        Me.gbBills.Controls.Add(Me.txtBillsPlaceCameFrom)
        Me.gbBills.Controls.Add(Me.txtBillsItemPriceIds)
        Me.gbBills.Controls.Add(Me.Label32)
        Me.gbBills.Controls.Add(Me.txtBillsRemarks)
        Me.gbBills.Controls.Add(Me.Label28)
        Me.gbBills.Controls.Add(Me.Label31)
        Me.gbBills.Controls.Add(Me.txtBillsFinalBillAmount)
        Me.gbBills.Controls.Add(Me.Label30)
        Me.gbBills.Controls.Add(Me.txtBillsTaxAmount)
        Me.gbBills.Controls.Add(Me.Label29)
        Me.gbBills.Controls.Add(Me.txtBillsItemTotalPrice)
        Me.gbBills.Controls.Add(Me.cmbBillsBillIdList)
        Me.gbBills.Controls.Add(Me.Label27)
        Me.gbBills.Controls.Add(Me.Label26)
        Me.gbBills.Controls.Add(Me.txtBillsDisplayBillId)
        Me.gbBills.Controls.Add(Me.Clear)
        Me.gbBills.Controls.Add(Me.btnBillsUpdate)
        Me.gbBills.Controls.Add(Me.btnBillsDelete)
        Me.gbBills.Controls.Add(Me.btnBillsAdd)
        Me.gbBills.Controls.Add(Me.dtpBillsBillDate)
        Me.gbBills.Controls.Add(Me.Label20)
        Me.gbBills.Controls.Add(Me.cmbBillsEntityList)
        Me.gbBills.Controls.Add(Me.gbBillsBills)
        Me.gbBills.Controls.Add(Me.gbBillSelectionItems)
        Me.gbBills.Controls.Add(Me.Label19)
        Me.gbBills.Location = New System.Drawing.Point(12, 412)
        Me.gbBills.Name = "gbBills"
        Me.gbBills.Size = New System.Drawing.Size(1158, 429)
        Me.gbBills.TabIndex = 20
        Me.gbBills.TabStop = False
        Me.gbBills.Text = "Bills"
        '
        'gbItemsQty
        '
        Me.gbItemsQty.Controls.Add(Me.dgvBillsItemsQty)
        Me.gbItemsQty.Location = New System.Drawing.Point(11, 138)
        Me.gbItemsQty.Name = "gbItemsQty"
        Me.gbItemsQty.Size = New System.Drawing.Size(312, 122)
        Me.gbItemsQty.TabIndex = 7
        Me.gbItemsQty.TabStop = False
        Me.gbItemsQty.Text = "Enter Quantity"
        '
        'dgvBillsItemsQty
        '
        Me.dgvBillsItemsQty.AllowUserToAddRows = False
        Me.dgvBillsItemsQty.AllowUserToDeleteRows = False
        Me.dgvBillsItemsQty.AllowUserToResizeRows = False
        Me.dgvBillsItemsQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillsItemsQty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.BillsItemQtyItemName, Me.BillsItemQtyItemPrice, Me.BillsItemQtyQuantity})
        Me.dgvBillsItemsQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillsItemsQty.Location = New System.Drawing.Point(3, 16)
        Me.dgvBillsItemsQty.Name = "dgvBillsItemsQty"
        Me.dgvBillsItemsQty.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBillsItemsQty.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBillsItemsQty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillsItemsQty.Size = New System.Drawing.Size(306, 103)
        Me.dgvBillsItemsQty.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'BillsItemQtyItemName
        '
        Me.BillsItemQtyItemName.DataPropertyName = "itemName"
        Me.BillsItemQtyItemName.HeaderText = "item"
        Me.BillsItemQtyItemName.Name = "BillsItemQtyItemName"
        Me.BillsItemQtyItemName.Width = 150
        '
        'BillsItemQtyItemPrice
        '
        Me.BillsItemQtyItemPrice.DataPropertyName = "itemPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.BillsItemQtyItemPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.BillsItemQtyItemPrice.HeaderText = "price"
        Me.BillsItemQtyItemPrice.Name = "BillsItemQtyItemPrice"
        Me.BillsItemQtyItemPrice.ReadOnly = True
        Me.BillsItemQtyItemPrice.Width = 60
        '
        'BillsItemQtyQuantity
        '
        Me.BillsItemQtyQuantity.DataPropertyName = "qty"
        Me.BillsItemQtyQuantity.HeaderText = "quantity"
        Me.BillsItemQtyQuantity.Name = "BillsItemQtyQuantity"
        Me.BillsItemQtyQuantity.Width = 50
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(139, 292)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "%"
        '
        'txtBillsTaxPercent
        '
        Me.txtBillsTaxPercent.Enabled = False
        Me.txtBillsTaxPercent.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsTaxPercent.Location = New System.Drawing.Point(98, 291)
        Me.txtBillsTaxPercent.Name = "txtBillsTaxPercent"
        Me.txtBillsTaxPercent.ReadOnly = True
        Me.txtBillsTaxPercent.Size = New System.Drawing.Size(35, 18)
        Me.txtBillsTaxPercent.TabIndex = 47
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(13, 366)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 13)
        Me.Label33.TabIndex = 46
        Me.Label33.Text = "place came from"
        '
        'txtBillsPlaceCameFrom
        '
        Me.txtBillsPlaceCameFrom.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsPlaceCameFrom.Location = New System.Drawing.Point(99, 365)
        Me.txtBillsPlaceCameFrom.Name = "txtBillsPlaceCameFrom"
        Me.txtBillsPlaceCameFrom.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsPlaceCameFrom.TabIndex = 45
        '
        'txtBillsItemPriceIds
        '
        Me.txtBillsItemPriceIds.Enabled = False
        Me.txtBillsItemPriceIds.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsItemPriceIds.Location = New System.Drawing.Point(317, -4)
        Me.txtBillsItemPriceIds.Name = "txtBillsItemPriceIds"
        Me.txtBillsItemPriceIds.ReadOnly = True
        Me.txtBillsItemPriceIds.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsItemPriceIds.TabIndex = 35
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(13, 341)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "remarks"
        '
        'txtBillsRemarks
        '
        Me.txtBillsRemarks.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsRemarks.Location = New System.Drawing.Point(99, 340)
        Me.txtBillsRemarks.Name = "txtBillsRemarks"
        Me.txtBillsRemarks.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsRemarks.TabIndex = 43
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(230, -3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 13)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "item price Ids"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 316)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(57, 13)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "bill amount"
        '
        'txtBillsFinalBillAmount
        '
        Me.txtBillsFinalBillAmount.Enabled = False
        Me.txtBillsFinalBillAmount.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsFinalBillAmount.Location = New System.Drawing.Point(98, 315)
        Me.txtBillsFinalBillAmount.Name = "txtBillsFinalBillAmount"
        Me.txtBillsFinalBillAmount.ReadOnly = True
        Me.txtBillsFinalBillAmount.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsFinalBillAmount.TabIndex = 41
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(11, 292)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 13)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "tax amount"
        '
        'txtBillsTaxAmount
        '
        Me.txtBillsTaxAmount.Enabled = False
        Me.txtBillsTaxAmount.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsTaxAmount.Location = New System.Drawing.Point(161, 291)
        Me.txtBillsTaxAmount.Name = "txtBillsTaxAmount"
        Me.txtBillsTaxAmount.ReadOnly = True
        Me.txtBillsTaxAmount.Size = New System.Drawing.Size(146, 18)
        Me.txtBillsTaxAmount.TabIndex = 39
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 267)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "items total price"
        '
        'txtBillsItemTotalPrice
        '
        Me.txtBillsItemTotalPrice.Enabled = False
        Me.txtBillsItemTotalPrice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsItemTotalPrice.Location = New System.Drawing.Point(98, 266)
        Me.txtBillsItemTotalPrice.Name = "txtBillsItemTotalPrice"
        Me.txtBillsItemTotalPrice.ReadOnly = True
        Me.txtBillsItemTotalPrice.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsItemTotalPrice.TabIndex = 37
        '
        'cmbBillsBillIdList
        '
        Me.cmbBillsBillIdList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBillsBillIdList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBillsBillIdList.DisplayMember = "name"
        Me.cmbBillsBillIdList.FormattingEnabled = True
        Me.cmbBillsBillIdList.Location = New System.Drawing.Point(98, 58)
        Me.cmbBillsBillIdList.Name = "cmbBillsBillIdList"
        Me.cmbBillsBillIdList.Size = New System.Drawing.Size(209, 21)
        Me.cmbBillsBillIdList.TabIndex = 33
        Me.cmbBillsBillIdList.ValueMember = "id"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 86)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "display Bill Id"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "bill Id"
        '
        'txtBillsDisplayBillId
        '
        Me.txtBillsDisplayBillId.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillsDisplayBillId.Location = New System.Drawing.Point(98, 85)
        Me.txtBillsDisplayBillId.Name = "txtBillsDisplayBillId"
        Me.txtBillsDisplayBillId.Size = New System.Drawing.Size(209, 18)
        Me.txtBillsDisplayBillId.TabIndex = 22
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(306, 400)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 31
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'btnBillsUpdate
        '
        Me.btnBillsUpdate.Location = New System.Drawing.Point(142, 400)
        Me.btnBillsUpdate.Name = "btnBillsUpdate"
        Me.btnBillsUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnBillsUpdate.TabIndex = 29
        Me.btnBillsUpdate.Text = "Update"
        Me.btnBillsUpdate.UseVisualStyleBackColor = True
        '
        'btnBillsDelete
        '
        Me.btnBillsDelete.Location = New System.Drawing.Point(224, 400)
        Me.btnBillsDelete.Name = "btnBillsDelete"
        Me.btnBillsDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnBillsDelete.TabIndex = 30
        Me.btnBillsDelete.Text = "Delete"
        Me.btnBillsDelete.UseVisualStyleBackColor = True
        '
        'btnBillsAdd
        '
        Me.btnBillsAdd.Location = New System.Drawing.Point(60, 400)
        Me.btnBillsAdd.Name = "btnBillsAdd"
        Me.btnBillsAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnBillsAdd.TabIndex = 28
        Me.btnBillsAdd.Text = "Add"
        Me.btnBillsAdd.UseVisualStyleBackColor = True
        '
        'dtpBillsBillDate
        '
        Me.dtpBillsBillDate.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpBillsBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBillsBillDate.Location = New System.Drawing.Point(98, 111)
        Me.dtpBillsBillDate.Name = "dtpBillsBillDate"
        Me.dtpBillsBillDate.Size = New System.Drawing.Size(209, 20)
        Me.dtpBillsBillDate.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "date time"
        '
        'cmbBillsEntityList
        '
        Me.cmbBillsEntityList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBillsEntityList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBillsEntityList.DisplayMember = "name"
        Me.cmbBillsEntityList.FormattingEnabled = True
        Me.cmbBillsEntityList.Location = New System.Drawing.Point(98, 32)
        Me.cmbBillsEntityList.Name = "cmbBillsEntityList"
        Me.cmbBillsEntityList.Size = New System.Drawing.Size(209, 21)
        Me.cmbBillsEntityList.TabIndex = 21
        Me.cmbBillsEntityList.ValueMember = "id"
        '
        'gbBillsBills
        '
        Me.gbBillsBills.Controls.Add(Me.dgvBillsBillGrid)
        Me.gbBillsBills.Location = New System.Drawing.Point(628, 11)
        Me.gbBillsBills.Name = "gbBillsBills"
        Me.gbBillsBills.Size = New System.Drawing.Size(512, 380)
        Me.gbBillsBills.TabIndex = 10
        Me.gbBillsBills.TabStop = False
        Me.gbBillsBills.Text = "Bills"
        '
        'dgvBillsBillGrid
        '
        Me.dgvBillsBillGrid.AllowUserToAddRows = False
        Me.dgvBillsBillGrid.AllowUserToDeleteRows = False
        Me.dgvBillsBillGrid.AllowUserToResizeRows = False
        Me.dgvBillsBillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillsBillGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.billsEntity, Me.BillsBillName, Me.BillsBillId, Me.BillsDisplayBillId, Me.BillsDateTime, Me.BillsItemPriceIds, Me.BillsItemsTotalPrice, Me.BillsTaxAmount, Me.BillsBillAmount, Me.BillsRemark, Me.BillsPlaceCameFrom})
        Me.dgvBillsBillGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillsBillGrid.Location = New System.Drawing.Point(3, 16)
        Me.dgvBillsBillGrid.Name = "dgvBillsBillGrid"
        Me.dgvBillsBillGrid.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBillsBillGrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBillsBillGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillsBillGrid.Size = New System.Drawing.Size(506, 361)
        Me.dgvBillsBillGrid.TabIndex = 0
        '
        'billsEntity
        '
        Me.billsEntity.DataPropertyName = "entityId"
        Me.billsEntity.HeaderText = "billsEntity"
        Me.billsEntity.Name = "billsEntity"
        Me.billsEntity.Visible = False
        '
        'BillsBillName
        '
        Me.BillsBillName.DataPropertyName = "name"
        Me.BillsBillName.HeaderText = "BillsBillName"
        Me.BillsBillName.Name = "BillsBillName"
        Me.BillsBillName.Visible = False
        '
        'BillsBillId
        '
        Me.BillsBillId.DataPropertyName = "id"
        Me.BillsBillId.HeaderText = "BillsBillId"
        Me.BillsBillId.Name = "BillsBillId"
        '
        'BillsDisplayBillId
        '
        Me.BillsDisplayBillId.DataPropertyName = "displayBillId"
        Me.BillsDisplayBillId.HeaderText = "BillsDisplayBillId"
        Me.BillsDisplayBillId.Name = "BillsDisplayBillId"
        '
        'BillsDateTime
        '
        Me.BillsDateTime.DataPropertyName = "dateTime"
        Me.BillsDateTime.HeaderText = "BillsDateTime"
        Me.BillsDateTime.Name = "BillsDateTime"
        '
        'BillsItemPriceIds
        '
        Me.BillsItemPriceIds.DataPropertyName = "itemPriceIds"
        Me.BillsItemPriceIds.HeaderText = "BillsItemPriceIds"
        Me.BillsItemPriceIds.Name = "BillsItemPriceIds"
        '
        'BillsItemsTotalPrice
        '
        Me.BillsItemsTotalPrice.DataPropertyName = "itemsPriceInTotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "0.00"
        Me.BillsItemsTotalPrice.DefaultCellStyle = DataGridViewCellStyle6
        Me.BillsItemsTotalPrice.HeaderText = "BillsItemsTotalPrice"
        Me.BillsItemsTotalPrice.Name = "BillsItemsTotalPrice"
        '
        'BillsTaxAmount
        '
        Me.BillsTaxAmount.DataPropertyName = "taxAmount"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "0.00"
        Me.BillsTaxAmount.DefaultCellStyle = DataGridViewCellStyle7
        Me.BillsTaxAmount.HeaderText = "BillsTaxAmount"
        Me.BillsTaxAmount.Name = "BillsTaxAmount"
        '
        'BillsBillAmount
        '
        Me.BillsBillAmount.DataPropertyName = "finalBillAmount"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "0.00"
        Me.BillsBillAmount.DefaultCellStyle = DataGridViewCellStyle8
        Me.BillsBillAmount.HeaderText = "BillsBillAmount"
        Me.BillsBillAmount.Name = "BillsBillAmount"
        '
        'BillsRemark
        '
        Me.BillsRemark.DataPropertyName = "remarks"
        Me.BillsRemark.HeaderText = "BillsRemark"
        Me.BillsRemark.Name = "BillsRemark"
        '
        'BillsPlaceCameFrom
        '
        Me.BillsPlaceCameFrom.DataPropertyName = "placeCameFrom"
        Me.BillsPlaceCameFrom.HeaderText = "BillsPlaceCameFrom"
        Me.BillsPlaceCameFrom.Name = "BillsPlaceCameFrom"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "entity"
        '
        'crvBillReport
        '
        Me.crvBillReport.ActiveViewIndex = -1
        Me.crvBillReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBillReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBillReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvBillReport.Location = New System.Drawing.Point(3, 16)
        Me.crvBillReport.Name = "crvBillReport"
        Me.crvBillReport.Size = New System.Drawing.Size(395, 410)
        Me.crvBillReport.TabIndex = 22
        '
        'gbBillReport
        '
        Me.gbBillReport.Controls.Add(Me.crvBillReport)
        Me.gbBillReport.Location = New System.Drawing.Point(1191, 412)
        Me.gbBillReport.Name = "gbBillReport"
        Me.gbBillReport.Size = New System.Drawing.Size(401, 429)
        Me.gbBillReport.TabIndex = 23
        Me.gbBillReport.TabStop = False
        Me.gbBillReport.Text = "Bill Report"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1596, 874)
        Me.Controls.Add(Me.gbItemsPrice)
        Me.Controls.Add(Me.gbItems)
        Me.Controls.Add(Me.gbEntities)
        Me.Controls.Add(Me.gbBills)
        Me.Controls.Add(Me.gbBillReport)
        Me.Name = "MainForm"
        Me.Text = "Elan POS Billing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbEntityGrid.ResumeLayout(False)
        CType(Me.dgvEntities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEntities.ResumeLayout(False)
        Me.gbEntities.PerformLayout()
        Me.gbItems.ResumeLayout(False)
        Me.gbItems.PerformLayout()
        Me.gbItemGrid.ResumeLayout(False)
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemsPrice.ResumeLayout(False)
        Me.gbItemsPrice.PerformLayout()
        Me.gbItemPrice.ResumeLayout(False)
        CType(Me.dgvItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBillSelectionItems.ResumeLayout(False)
        Me.gbBills.ResumeLayout(False)
        Me.gbBills.PerformLayout()
        Me.gbItemsQty.ResumeLayout(False)
        CType(Me.dgvBillsItemsQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBillsBills.ResumeLayout(False)
        CType(Me.dgvBillsBillGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBillReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEntityGrid As GroupBox
    Friend WithEvents dgvEntities As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEntityStreet As TextBox
    Friend WithEvents txtEntityCity As TextBox
    Friend WithEvents txtEntityState As TextBox
    Friend WithEvents txtEntityCountry As TextBox
    Friend WithEvents txtEntityPin As TextBox
    Friend WithEvents txtEntityBillHeight As TextBox
    Friend WithEvents txtEntityBillWidth As TextBox
    Friend WithEvents txtEntityTaxPercent As TextBox
    Friend WithEvents txtEntityBuilding As TextBox
    Friend WithEvents btnEntityAdd As Button
    Friend WithEvents btnEntityDelete As Button
    Friend WithEvents btnEntityUpdate As Button
    Friend WithEvents cmbEntityList As ComboBox
    Friend WithEvents cmbEntityTypeList As ComboBox
    Friend WithEvents btnEntityClear As Button
    Friend WithEvents gbEntities As GroupBox
    Friend WithEvents gbItems As GroupBox
    Friend WithEvents btnItemClear As Button
    Friend WithEvents gbItemGrid As GroupBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents cmbItemList As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnItemUpdate As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnItemDelete As Button
    Friend WithEvents btnItemAdd As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEntityDistanceFromHotel As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtEntityDistanceFromOffice As TextBox
    Friend WithEvents entityId As DataGridViewTextBoxColumn
    Friend WithEvents entityName As DataGridViewTextBoxColumn
    Friend WithEvents building As DataGridViewTextBoxColumn
    Friend WithEvents street As DataGridViewTextBoxColumn
    Friend WithEvents city As DataGridViewTextBoxColumn
    Friend WithEvents state As DataGridViewTextBoxColumn
    Friend WithEvents country As DataGridViewTextBoxColumn
    Friend WithEvents pin As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents billHeight As DataGridViewTextBoxColumn
    Friend WithEvents billWidth As DataGridViewTextBoxColumn
    Friend WithEvents taxPercent As DataGridViewTextBoxColumn
    Friend WithEvents distanceFromHotel As DataGridViewTextBoxColumn
    Friend WithEvents distanceFromOffice As DataGridViewTextBoxColumn
    Friend WithEvents cmbItemCategoryList As ComboBox
    Friend WithEvents itemId As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents categoryName As DataGridViewTextBoxColumn
    Friend WithEvents categoryId As DataGridViewTextBoxColumn
    Friend WithEvents gbItemsPrice As GroupBox
    Friend WithEvents txtItemPricePrice As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbItemPriceItemList As ComboBox
    Friend WithEvents btnItemPriceClear As Button
    Friend WithEvents gbItemPrice As GroupBox
    Friend WithEvents dgvItemPrice As DataGridView
    Friend WithEvents cmbItemPriceEntityList As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnItemPriceUpdate As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnItemPriceDelete As Button
    Friend WithEvents btnItemPriceAdd As Button
    Friend WithEvents cmbItemPriceItemCategoryList As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbItemPriceIdList As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents itemPriceId As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceIdName As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceEntityId As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceEntityName As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceItemId As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceItemName As DataGridViewTextBoxColumn
    Friend WithEvents itemPriceItemCategoryName As DataGridViewTextBoxColumn
    Friend WithEvents itemPricePrice As DataGridViewTextBoxColumn
    Friend WithEvents tvBillsBillItems As TreeView
    Friend WithEvents gbBillSelectionItems As GroupBox
    Friend WithEvents gbBills As GroupBox
    Friend WithEvents cmbBillsEntityList As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents gbBillsBills As GroupBox
    Friend WithEvents dgvBillsBillGrid As DataGridView
    Friend WithEvents dtpBillsBillDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents crvBillReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gbBillReport As GroupBox
    Friend WithEvents Clear As Button
    Friend WithEvents btnBillsUpdate As Button
    Friend WithEvents btnBillsDelete As Button
    Friend WithEvents btnBillsAdd As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBillsItemPriceIds As TextBox
    Friend WithEvents cmbBillsBillIdList As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtBillsDisplayBillId As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtBillsPlaceCameFrom As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtBillsRemarks As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtBillsFinalBillAmount As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtBillsTaxAmount As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtBillsItemTotalPrice As TextBox
    Friend WithEvents txtBillsTaxPercent As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents billsEntity As DataGridViewTextBoxColumn
    Friend WithEvents BillsBillName As DataGridViewTextBoxColumn
    Friend WithEvents BillsBillId As DataGridViewTextBoxColumn
    Friend WithEvents BillsDisplayBillId As DataGridViewTextBoxColumn
    Friend WithEvents BillsDateTime As DataGridViewTextBoxColumn
    Friend WithEvents BillsItemPriceIds As DataGridViewTextBoxColumn
    Friend WithEvents BillsItemsTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents BillsTaxAmount As DataGridViewTextBoxColumn
    Friend WithEvents BillsBillAmount As DataGridViewTextBoxColumn
    Friend WithEvents BillsRemark As DataGridViewTextBoxColumn
    Friend WithEvents BillsPlaceCameFrom As DataGridViewTextBoxColumn
    Friend WithEvents gbItemsQty As GroupBox
    Friend WithEvents dgvBillsItemsQty As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BillsItemQtyItemName As DataGridViewTextBoxColumn
    Friend WithEvents BillsItemQtyItemPrice As DataGridViewTextBoxColumn
    Friend WithEvents BillsItemQtyQuantity As DataGridViewTextBoxColumn
End Class
