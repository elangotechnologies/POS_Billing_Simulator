Imports System.Data.SqlClient
Imports System.Threading
Imports NLog


Public Class MainForm
    Dim dbConnection As SqlConnection
    Dim log As Logger = LogManager.GetCurrentClassLogger()
    Private gSelectedEntityId As Integer
    Private gSelectedItemId As Integer
    Private gSelectedItemPriceId As Integer
    Private gSelectedBillId As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection = New SqlConnection("server=HIBAIL56209\ELASQLEXPRESS;Database=pos_billing;Integrated Security=true; MultipleActiveResultSets=True;")
        dbConnection.Open()

        gSelectedEntityId = -1
        gSelectedItemId = -1
        gSelectedItemPriceId = -1
        gSelectedBillId = -1

        loadEntityTypeList()
        loadEntityListAndGrid()

        loadItemCategoryList()
    End Sub

    Sub loadEntityTypeList()
        Dim thread As Thread = New Thread(AddressOf loadEntityTypeListInThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Sub loadEntityListAndGrid()
        Dim thread As Thread = New Thread(AddressOf loadEntityListAndGridInThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Sub loadEntityListAndGridInThread()
        Dim entityQuery = New SqlCommand("Select * from Entity", dbConnection)
        Dim entityAdapter = New SqlDataAdapter()
        entityAdapter.SelectCommand = entityQuery
        Dim entityDataSet = New DataSet
        entityAdapter.Fill(entityDataSet, "Entity")
        Dim entityTable As DataTable = entityDataSet.Tables(0)
        Dim entityTableForGrid As DataTable = entityTable.Copy()

        Dim setEntityListInvoker As New setEntityListDelegate(AddressOf Me.setEntityList)
        Me.BeginInvoke(setEntityListInvoker, entityTable)

        Dim setEntityGridInvoker As New setEntityGridDelegate(AddressOf Me.setEntityGrid)
        Me.BeginInvoke(setEntityGridInvoker, entityTableForGrid)
    End Sub

    Delegate Sub setEntityListDelegate(entityTable As DataTable)

    Sub setEntityList(entityTable As DataTable)
        Dim dummyFirstRow As DataRow = entityTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select an Entity..."
        entityTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbEntityList.BindingContext = New BindingContext()
        cmbEntityList.DataSource = entityTable

        cmbItemPriceEntityList.BindingContext = New BindingContext()
        cmbItemPriceEntityList.DataSource = entityTable

        cmbBillsEntityList.BindingContext = New BindingContext()
        cmbBillsEntityList.DataSource = entityTable
    End Sub

    Delegate Sub setEntityGridDelegate(entityTable As DataTable)

    Sub setEntityGrid(entityTable As DataTable)
        dgvEntities.DataSource = entityTable
        If entityTable.Rows.Count > 0 Then
            dgvEntities.FirstDisplayedScrollingRowIndex = entityTable.Rows.Count - 1
        End If
    End Sub

    Private Sub btnEntityAdd_Click(sender As Object, e As EventArgs) Handles btnEntityAdd.Click
        Try
            If cmbEntityList.Text.Trim.Equals("") Or cmbEntityList.Text.Trim.Equals("Select an Entity...") Then
                MessageBox.Show("Enter valid Entity Name")
                cmbEntityList.Focus()
            ElseIf cmbEntityTypeList.Text.Trim.Equals("") Then
                MessageBox.Show("Select a valid entity type")
                cmbEntityTypeList.Focus()
            Else
                Dim query As String = String.Empty
                query &= "INSERT INTO Entity (name, building, street, city, state, country, pin, type, billHeight, billWidth, taxPercent, distanceFromHotel, distanceFromOffice) "
                query &= "VALUES (@name, @building, @street, @city, @state, @country, @pin, @type, @billHeight, @billWidth, @taxPercent, @distanceFromHotel, @distanceFromOffice)"

                Using comm As New SqlCommand()
                    With comm
                        .Connection = dbConnection
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@name", cmbEntityList.Text)
                        .Parameters.AddWithValue("@building", getDBNullValueIfTextBoxNull(txtEntityBuilding))
                        .Parameters.AddWithValue("@street", getDBNullValueIfTextBoxNull(txtEntityStreet))
                        .Parameters.AddWithValue("@city", getDBNullValueIfTextBoxNull(txtEntityCity))
                        .Parameters.AddWithValue("@state", getDBNullValueIfTextBoxNull(txtEntityState))
                        .Parameters.AddWithValue("@country", getDBNullValueIfTextBoxNull(txtEntityCountry))
                        .Parameters.AddWithValue("@pin", getDBNullValueIfTextBoxNull(txtEntityPin))
                        .Parameters.AddWithValue("@type", getDBNullValueIfComboBoxNull(cmbEntityTypeList))
                        .Parameters.AddWithValue("@billHeight", getDBNullValueIfTextBoxNull(txtEntityBillHeight))
                        .Parameters.AddWithValue("@billWidth", getDBNullValueIfTextBoxNull(txtEntityBillWidth))
                        .Parameters.AddWithValue("@taxPercent", getDBNullValueIfTextBoxNull(txtEntityTaxPercent))
                        .Parameters.AddWithValue("@distanceFromHotel", getDBNullValueIfTextBoxNull(txtEntityDistanceFromHotel))
                        .Parameters.AddWithValue("@distanceFromOffice", getDBNullValueIfTextBoxNull(txtEntityDistanceFromOffice))
                    End With
                    comm.ExecuteNonQuery()
                End Using
                MessageBox.Show("Entity successfully added")
                loadEntityListAndGrid()
            End If
        Catch sqlEx As SqlException When sqlEx.Number = 2627
            MsgBox("Duplicate Entity entry. check if any other entity exists with same entity name")
        End Try
    End Sub

    Sub loadEntityTypeListInThread()
        Dim entityTypeQuery = New SqlCommand("Select * from EntityType", dbConnection)
        Dim entityTypeAdapter = New SqlDataAdapter()
        entityTypeAdapter.SelectCommand = entityTypeQuery
        Dim entityTypeDataSet = New DataSet
        entityTypeAdapter.Fill(entityTypeDataSet, "EntityType")
        Dim entityTypeTable As DataTable = entityTypeDataSet.Tables(0)

        Dim setEntityTypeListInvoker As New setEntityTypeListDelegate(AddressOf Me.setEntityTypeList)
        Me.BeginInvoke(setEntityTypeListInvoker, entityTypeTable)
    End Sub

    Delegate Sub setEntityTypeListDelegate(entityTypeTable As DataTable)

    Sub setEntityTypeList(entityTypeTable As DataTable)
        cmbEntityTypeList.BindingContext = New BindingContext()
        cmbEntityTypeList.DataSource = entityTypeTable
    End Sub

    Private Sub dgvEntities_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntities.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim entityId As Integer = dgvEntities.Item("entityId", e.RowIndex).Value
        cmbEntityList.SelectedValue = entityId
    End Sub

    Private Sub cmbEntityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEntityList.SelectedIndexChanged

        If (cmbEntityList.SelectedIndex = -1 Or cmbEntityList.SelectedValue = -1) Then
            emptyEntityScreen()
            Return
        End If

        Dim entityId As Integer = cmbEntityList.SelectedValue
        gSelectedEntityId = entityId

        Dim entitySelectQuery = New SqlCommand("select * from entity where id=" + entityId.ToString, dbConnection)
        Dim entityDataAdapter = New SqlDataAdapter()
        entityDataAdapter.SelectCommand = entitySelectQuery
        Dim entityDataSet = New DataSet
        entityDataAdapter.Fill(entityDataSet, "Entity")
        Dim entityTable = entityDataSet.Tables(0)

        If (entityTable.Rows.Count > 0) Then
            Dim dataRow = entityTable.Rows(0)
            txtEntityBuilding.Text = dataRow.Item("building").ToString
            txtEntityStreet.Text = dataRow.Item("street").ToString
            txtEntityCity.Text = dataRow.Item("city").ToString
            txtEntityState.Text = dataRow.Item("state").ToString
            txtEntityCountry.Text = dataRow.Item("country").ToString
            txtEntityPin.Text = dataRow.Item("pin").ToString
            cmbEntityTypeList.Text = dataRow.Item("type").ToString
            txtEntityBillHeight.Text = dataRow.Item("billHeight").ToString
            txtEntityBillWidth.Text = dataRow.Item("billWidth").ToString
            txtEntityTaxPercent.Text = dataRow.Item("taxPercent").ToString
            txtEntityDistanceFromHotel.Text = dataRow.Item("distanceFromHotel").ToString
            txtEntityDistanceFromOffice.Text = dataRow.Item("distanceFromOffice").ToString
        Else
            MessageBox.Show("No data found for entity: " + entityId + "-" + cmbEntityList.Text)
        End If
    End Sub

    Sub resetEntityScreen()
        resetIndexOfComboBox(cmbEntityList)
    End Sub

    Sub resetIndexOfComboBox(comboBox As ComboBox)
        If (comboBox.Items.Count > 0) Then
            comboBox.SelectedValue = -1
        Else
            comboBox.SelectedIndex = -1
        End If
    End Sub

    Sub emptyEntityScreen()
        txtEntityBuilding.Text = ""
        txtEntityStreet.Text = ""
        txtEntityCity.Text = ""
        txtEntityState.Text = ""
        txtEntityCountry.Text = ""
        txtEntityPin.Text = ""
        cmbEntityTypeList.Text = ""
        txtEntityBillHeight.Text = ""
        txtEntityBillWidth.Text = ""
        txtEntityTaxPercent.Text = ""
        txtEntityDistanceFromHotel.Text = ""
        txtEntityDistanceFromOffice.Text = ""
    End Sub

    Private Sub btnEntityClear_Click(sender As Object, e As EventArgs) Handles btnEntityClear.Click
        resetEntityScreen()
    End Sub

    Private Sub btnEntityUpdate_Click(sender As Object, e As EventArgs) Handles btnEntityUpdate.Click
        If (gSelectedEntityId = -1) Then
            MessageBox.Show("Please select a entity")
            cmbEntityList.Focus()
            Return
        End If

        If cmbEntityList.Text.Trim.Equals("") Then
            MessageBox.Show("Enter valid entity name")
            cmbEntityList.Focus()
        ElseIf cmbEntityTypeList.Text.Trim.Equals("") Or cmbEntityTypeList.Text.Trim.Equals("Select an Entity...") Then
            MessageBox.Show("Select a valid entity type")
            cmbEntityTypeList.Focus()
        Else
            Dim entityId As Integer = gSelectedEntityId
            Dim query As String = String.Empty
            query &= "UPDATE Entity set name=@name, building=@building, street=@street, city=@city, state=@state, country=@country, pin=@pin, type=@type, billHeight=@billHeight, billWidth=@billWidth, taxPercent=@taxPercent, distanceFromHotel=@distanceFromHotel, distanceFromOffice=@distanceFromOffice"
            query &= " where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", entityId.ToString)
                    .Parameters.AddWithValue("@name", cmbEntityList.Text)
                    .Parameters.AddWithValue("@building", getDBNullValueIfTextBoxNull(txtEntityBuilding))
                    .Parameters.AddWithValue("@street", getDBNullValueIfTextBoxNull(txtEntityStreet))
                    .Parameters.AddWithValue("@city", getDBNullValueIfTextBoxNull(txtEntityCity))
                    .Parameters.AddWithValue("@state", getDBNullValueIfTextBoxNull(txtEntityState))
                    .Parameters.AddWithValue("@country", getDBNullValueIfTextBoxNull(txtEntityCountry))
                    .Parameters.AddWithValue("@pin", getDBNullValueIfTextBoxNull(txtEntityPin))
                    .Parameters.AddWithValue("@type", getDBNullValueIfComboBoxNull(cmbEntityTypeList))
                    .Parameters.AddWithValue("@billHeight", getDBNullValueIfTextBoxNull(txtEntityBillHeight))
                    .Parameters.AddWithValue("@billWidth", getDBNullValueIfTextBoxNull(txtEntityBillWidth))
                    .Parameters.AddWithValue("@taxPercent", getDBNullValueIfTextBoxNull(txtEntityTaxPercent))
                    .Parameters.AddWithValue("@distanceFromHotel", getDBNullValueIfTextBoxNull(txtEntityDistanceFromHotel))
                    .Parameters.AddWithValue("@distanceFromOffice", getDBNullValueIfTextBoxNull(txtEntityDistanceFromOffice))
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Entity successfully updated")
            loadEntityListAndGrid()
        End If
    End Sub

    Private Sub btnEntityDelete_Click(sender As Object, e As EventArgs) Handles btnEntityDelete.Click
        If (cmbEntityList.SelectedIndex = -1 Or cmbEntityList.SelectedValue = -1) Then
            MessageBox.Show("Please select a entity")
            cmbEntityList.Focus()
            Return
        End If

        If MessageBox.Show("All bills belongs to this entity will be deleted." + vbNewLine + vbNewLine + "  Do you want to delete this Entity - " & cmbEntityList.Text & " ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim query As String = String.Empty
            query &= "DELETE FROM entity where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", cmbEntityList.SelectedValue)
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Entity successfully deleted")
            loadEntityListAndGrid()
        End If
    End Sub

    Sub loadItemCategoryList()
        Dim thread As Thread = New Thread(AddressOf loadItemCategoryListInThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Sub loadItemListAndGrid(categoryId As Integer)
        Dim thread As Thread = New Thread(AddressOf loadItemListAndGridInThread)
        thread.IsBackground = True
        thread.Start(categoryId)
    End Sub

    Private Sub cmbItemCategoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemCategoryList.SelectedIndexChanged
        If (cmbItemCategoryList.SelectedIndex = -1 Or cmbItemCategoryList.SelectedValue = -1) Then
            resetIndexOfComboBox(cmbItemList)
            Return
        End If

        loadItemListAndGridInThread(cmbItemCategoryList.SelectedValue)
    End Sub

    Function getItemTable(categoryId As Integer) As DataTable
        Dim itemQuery As SqlCommand = New SqlCommand("Select i.id,i.name,i.categoryId,ic.name as categoryName from Item i, 
                                    ItemCategory ic where i.categoryId=ic.id and i.categoryId=" + categoryId.ToString, dbConnection)
        Dim itemAdapter As SqlDataAdapter = New SqlDataAdapter()
        itemAdapter.SelectCommand = itemQuery
        Dim itemDataSet = New DataSet
        itemAdapter.Fill(itemDataSet, "Item")
        Return itemDataSet.Tables(0)
    End Function

    Sub loadItemListAndGridInThread(categoryId As Integer)
        Dim itemTable As DataTable = getItemTable(categoryId)
        Dim itemTableForGrid As DataTable = itemTable.Copy()

        Dim setItemListInvoker As New setItemListDelegate(AddressOf Me.setItemList)
        Me.BeginInvoke(setItemListInvoker, itemTable)

        Dim setItemGridInvoker As New setItemGridDelegate(AddressOf Me.setItemGrid)
        Me.BeginInvoke(setItemGridInvoker, itemTableForGrid)
    End Sub

    Delegate Sub setItemListDelegate(itemTable As DataTable)

    Sub setItemList(itemTable As DataTable)
        Dim dummyFirstRow As DataRow = itemTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select an Item..."
        itemTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbItemList.BindingContext = New BindingContext()
        cmbItemList.DataSource = itemTable
    End Sub

    Delegate Sub setItemGridDelegate(itemTable As DataTable)

    Sub setItemGrid(itemTable As DataTable)
        dgvItems.DataSource = itemTable
        If itemTable.Rows.Count > 0 Then
            dgvItems.FirstDisplayedScrollingRowIndex = itemTable.Rows.Count - 1
        End If
    End Sub

    Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        Try
            If cmbItemList.Text.Trim.Equals("") Or cmbItemList.Text.Trim.Equals("Select an Item...") Then
                MessageBox.Show("Enter valid Item Name")
                cmbItemList.Focus()
            ElseIf cmbItemCategoryList.SelectedValue = -1 Or cmbItemCategoryList.SelectedIndex = -1 Then
                MessageBox.Show("Select a valid item category")
                cmbItemCategoryList.Focus()
            Else
                Dim query As String = String.Empty
                query &= "INSERT INTO Item (name, categoryId) "
                query &= "VALUES (@name, @categoryId)"

                Using comm As New SqlCommand()
                    With comm
                        .Connection = dbConnection
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@name", cmbItemList.Text)
                        .Parameters.AddWithValue("@categoryId", cmbItemCategoryList.SelectedValue)
                    End With
                    comm.ExecuteNonQuery()
                End Using
                MessageBox.Show("Item successfully added")
                loadItemListAndGrid(cmbItemCategoryList.SelectedValue)
            End If
        Catch sqlEx As SqlException When sqlEx.Number = 2627
            MsgBox("Duplicate Item entry. check if any other item exists with same item name")
        End Try
    End Sub

    Sub loadItemCategoryListInThread()
        Dim itemCategoryQuery = New SqlCommand("Select * from ItemCategory", dbConnection)
        Dim itemCategoryAdapter = New SqlDataAdapter()
        itemCategoryAdapter.SelectCommand = itemCategoryQuery
        Dim itemCategoryDataSet = New DataSet
        itemCategoryAdapter.Fill(itemCategoryDataSet, "ItemCategory")
        Dim itemCategoryTable As DataTable = itemCategoryDataSet.Tables(0)

        Dim setItemCategoryListInvoker As New setItemCategoryListDelegate(AddressOf Me.setItemCategoryList)
        Me.BeginInvoke(setItemCategoryListInvoker, itemCategoryTable)
    End Sub

    Delegate Sub setItemCategoryListDelegate(itemCategoryTable As DataTable)

    Sub setItemCategoryList(itemCategoryTable As DataTable)
        Dim dummyFirstRow As DataRow = itemCategoryTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select a category..."
        itemCategoryTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbItemCategoryList.BindingContext = New BindingContext()
        cmbItemCategoryList.DataSource = itemCategoryTable

        cmbItemPriceItemCategoryList.BindingContext = New BindingContext()
        cmbItemPriceItemCategoryList.DataSource = itemCategoryTable
    End Sub

    Private Sub dgvItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim itemId As Integer = dgvItems.Item("itemId", e.RowIndex).Value
        cmbItemList.SelectedValue = itemId
    End Sub

    Private Sub cmbItemList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemList.SelectedIndexChanged

        If (cmbItemList.SelectedIndex = -1 Or cmbItemList.SelectedValue = -1) Then
            emptyItemScreen()
            Return
        End If

        Dim itemId As Integer = cmbItemList.SelectedValue
        gSelectedItemId = itemId

        Dim itemSelectQuery = New SqlCommand("select * from item where id=" + itemId.ToString, dbConnection)
        Dim itemDataAdapter = New SqlDataAdapter()
        itemDataAdapter.SelectCommand = itemSelectQuery
        Dim itemDataSet = New DataSet
        itemDataAdapter.Fill(itemDataSet, "Item")
        Dim itemTable = itemDataSet.Tables(0)

        If (itemTable.Rows.Count > 0) Then
            Dim dataRow = itemTable.Rows(0)
            cmbItemCategoryList.SelectedValue = dataRow.Item("categoryId")
        Else
            MessageBox.Show("No data found for item: " + itemId + "-" + cmbItemList.Text)
        End If
    End Sub

    Sub resetItemScreen()
        resetIndexOfComboBox(cmbItemList)
    End Sub

    Sub emptyItemScreen()
        If (cmbItemList.Items.Count > 0) Then
            cmbItemList.SelectedValue = -1
        Else
            cmbItemList.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnItemClear_Click(sender As Object, e As EventArgs) Handles btnItemClear.Click
        resetItemScreen()
    End Sub

    Private Sub btnItemUpdate_Click(sender As Object, e As EventArgs) Handles btnItemUpdate.Click
        If (gSelectedItemId = -1) Then
            MessageBox.Show("Please select a item")
            cmbItemList.Focus()
            Return
        End If

        If cmbItemList.Text.Trim.Equals("") Then
            MessageBox.Show("Enter valid item name")
            cmbItemList.Focus()
        ElseIf cmbItemCategoryList.Text.Trim.Equals("") Or cmbItemCategoryList.Text.Trim.Equals("Select an Item Category...") Then
            MessageBox.Show("Select a valid item type")
            cmbItemCategoryList.Focus()
        Else
            Dim itemId As Integer = gSelectedItemId
            Dim query As String = String.Empty
            query &= "UPDATE Item set name=@name, categoryId=@categoryId"
            query &= " where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", itemId.ToString)
                    .Parameters.AddWithValue("@name", cmbItemList.Text)
                    .Parameters.AddWithValue("@categoryId", cmbItemCategoryList.SelectedValue)
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item successfully updated")
            loadItemListAndGrid(cmbItemCategoryList.SelectedValue)
        End If
    End Sub

    Private Sub btnItemDelete_Click(sender As Object, e As EventArgs) Handles btnItemDelete.Click
        If (cmbItemList.SelectedIndex = -1 Or cmbItemList.SelectedValue = -1) Then
            MessageBox.Show("Please select a item")
            cmbItemList.Focus()
            Return
        End If

        If MessageBox.Show("Are you sure to delete this Item - " & cmbItemList.Text & " ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim query As String = String.Empty
            query &= "DELETE FROM item where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", cmbItemList.SelectedValue)
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item successfully deleted")
            loadItemListAndGrid(cmbItemCategoryList.SelectedValue)
        End If
    End Sub

    Sub loadItemPriceListAndGrid(entityId As Integer)
        Dim thread As Thread = New Thread(AddressOf loadItemPriceListAndGridInThread)
        thread.IsBackground = True
        thread.Start(entityId)
    End Sub

    Sub loadItemPriceListAndGridInThread(entityId As Integer)
        Dim itemPriceQuery = New SqlCommand("Select ip.id, CONVERT(varchar(5), ip.id) as name, e.name as entityName, i.name as itemName, ic.name as categoryName, ip.price from ItemPriceEntityWise ip, Item i, ItemCategory ic, Entity e where ip.entityId=e.id and ip.itemId = i.id and i.categoryId=ic.id and ip.entityId=" + entityId.ToString(), dbConnection)
        Dim itemPriceAdapter = New SqlDataAdapter()
        itemPriceAdapter.SelectCommand = itemPriceQuery
        Dim itemPriceDataSet = New DataSet
        itemPriceAdapter.Fill(itemPriceDataSet, "ItemPriceEntityWise")
        Dim itemPriceTable As DataTable = itemPriceDataSet.Tables(0)
        Dim itemPriceTableForGrid As DataTable = itemPriceTable.Copy()

        Dim setItemPriceListInvoker As New setItemPriceListDelegate(AddressOf Me.setItemPriceList)
        Me.BeginInvoke(setItemPriceListInvoker, itemPriceTable)

        Dim setItemPriceGridInvoker As New setItemPriceGridDelegate(AddressOf Me.setItemPriceGrid)
        Me.BeginInvoke(setItemPriceGridInvoker, itemPriceTableForGrid)
    End Sub

    Delegate Sub setItemPriceListDelegate(itemPriceTable As DataTable)

    Sub setItemPriceList(itemPriceTable As DataTable)
        Dim dummyFirstRow As DataRow = itemPriceTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select an Item's price id..."
        itemPriceTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbItemPriceIdList.BindingContext = New BindingContext()
        cmbItemPriceIdList.DataSource = itemPriceTable
    End Sub

    Delegate Sub setItemPriceGridDelegate(itemPriceTable As DataTable)

    Sub setItemPriceGrid(itemPriceTable As DataTable)
        dgvItemPrice.DataSource = itemPriceTable
        If itemPriceTable.Rows.Count > 0 Then
            dgvItemPrice.FirstDisplayedScrollingRowIndex = itemPriceTable.Rows.Count - 1
        End If
    End Sub

    Private Sub btnItemPriceAdd_Click(sender As Object, e As EventArgs) Handles btnItemPriceAdd.Click
        Try
            If cmbItemPriceEntityList.SelectedIndex = -1 Or cmbItemPriceEntityList.SelectedValue = -1 Then
                MessageBox.Show("Select a valid entity")
                cmbItemPriceEntityList.Focus()
            ElseIf cmbItemPriceItemCategoryList.SelectedIndex = -1 Or cmbItemPriceItemCategoryList.SelectedValue = -1 Then
                MessageBox.Show("Select a valid item category")
                cmbItemPriceItemCategoryList.Focus()
            ElseIf cmbItemPriceItemList.SelectedIndex = -1 Or cmbItemPriceItemList.SelectedValue = -1 Then
                MessageBox.Show("Select a valid item")
                cmbItemPriceItemList.Focus()
            ElseIf txtItemPricePrice.Text.Trim() = "" Then
                MessageBox.Show("Enter a valid price amount")
                txtItemPricePrice.Focus()
            Else
                Dim query As String = String.Empty
                query &= "INSERT INTO ItemPriceEntityWise (entityId, itemId, price) "
                query &= "VALUES (@entityId, @itemId, @price)"

                Using comm As New SqlCommand()
                    With comm
                        .Connection = dbConnection
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@entityId", cmbItemPriceEntityList.SelectedValue)
                        .Parameters.AddWithValue("@itemId", cmbItemPriceItemList.SelectedValue)
                        .Parameters.AddWithValue("@price", getDBNullValueIfTextBoxNull(txtItemPricePrice))
                    End With
                    comm.ExecuteNonQuery()
                End Using
                MessageBox.Show("ItemPriceEntityWise successfully added")
                loadItemPriceListAndGrid(cmbItemPriceEntityList.SelectedValue)
            End If
        Catch sqlEx As SqlException When sqlEx.Number = 2627
            MsgBox("Duplicate ItemPriceEntityWise entry. check if any other itemPrice exists with same itemPrice name")
        End Try
    End Sub


    Private Sub dgvItemPrice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemPrice.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim itemPriceId As Integer = dgvItemPrice.Item("itemPriceId", e.RowIndex).Value
        cmbItemPriceIdList.SelectedValue = itemPriceId
    End Sub

    Private Sub cmbItemPriceEntityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemPriceEntityList.SelectedIndexChanged
        If (cmbItemPriceEntityList.SelectedIndex = -1 Or cmbItemPriceEntityList.SelectedValue = -1) Then
            resetIndexOfComboBox(cmbItemPriceIdList)
            Return
        End If

        loadItemPriceListAndGrid(cmbItemPriceEntityList.SelectedValue)
    End Sub

    Private Sub cmbItemPriceIdList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemPriceIdList.SelectedIndexChanged

        If (cmbItemPriceIdList.SelectedIndex = -1 Or cmbItemPriceIdList.SelectedValue = -1) Then
            emptyItemPriceScreen()
            Return
        End If

        Dim itemPriceId As Integer = cmbItemPriceIdList.SelectedValue
        gSelectedItemPriceId = itemPriceId

        Dim itemPriceSelectQuery = New SqlCommand("select ip.*,ic.id as categoryId from ItemPriceEntityWise ip, Item i, ItemCategory ic where ip.itemId = i.id and i.categoryId = ic.id and ip.id=" + itemPriceId.ToString, dbConnection)
        Dim itemPriceDataAdapter = New SqlDataAdapter()
        itemPriceDataAdapter.SelectCommand = itemPriceSelectQuery
        Dim itemPriceDataSet = New DataSet
        itemPriceDataAdapter.Fill(itemPriceDataSet, "ItemPriceEntityWise")
        Dim itemPriceTable = itemPriceDataSet.Tables(0)

        If (itemPriceTable.Rows.Count > 0) Then
            Dim dataRow = itemPriceTable.Rows(0)
            cmbItemPriceEntityList.SelectedValue = dataRow.Item("entityId")
            cmbItemPriceItemCategoryList.SelectedValue = dataRow.Item("categoryId")
            cmbItemPriceItemList.SelectedValue = dataRow.Item("itemId")
            txtItemPricePrice.Text = dataRow.Item("price")
        Else
            MessageBox.Show("No data found for itemPrice: " + itemPriceId + "-" + cmbItemPriceIdList.Text)
        End If
    End Sub

    Sub resetItemPriceScreen()
        resetIndexOfComboBox(cmbItemPriceIdList)
    End Sub

    Sub emptyItemPriceScreen()
        If (cmbItemPriceItemCategoryList.Items.Count > 0) Then
            cmbItemPriceItemCategoryList.SelectedValue = -1
        Else
            cmbItemPriceItemCategoryList.SelectedIndex = -1
        End If

        If (cmbItemPriceItemList.Items.Count > 0) Then
            cmbItemPriceItemList.SelectedValue = -1
        Else
            cmbItemPriceItemList.SelectedIndex = -1
        End If

        txtItemPricePrice.Text = ""
    End Sub

    Private Sub btnItemPriceClear_Click(sender As Object, e As EventArgs) Handles btnItemPriceClear.Click
        resetItemPriceScreen()
    End Sub

    Private Sub btnItemPriceUpdate_Click(sender As Object, e As EventArgs) Handles btnItemPriceUpdate.Click
        If (gSelectedItemPriceId = -1) Then
            MessageBox.Show("Please select a item's price id")
            cmbItemPriceIdList.Focus()
            Return
        End If

        If cmbItemPriceIdList.SelectedIndex = -1 Or cmbItemPriceIdList.SelectedValue = -1 Then
            MessageBox.Show("Select a valid item's price id")
            cmbItemPriceIdList.Focus()
        ElseIf cmbItemPriceEntityList.SelectedIndex = -1 Or cmbItemPriceEntityList.SelectedValue = -1 Then
            MessageBox.Show("Select a valid entity")
            cmbItemPriceEntityList.Focus()
        ElseIf cmbItemPriceItemList.SelectedIndex = -1 Or cmbItemPriceItemList.SelectedValue = -1 Then
            MessageBox.Show("Select a valid itemPrice category")
            cmbItemPriceItemList.Focus()
        ElseIf txtItemPricePrice.Text.Trim() = "" Then
            MessageBox.Show("Enter a valid price amount")
            txtItemPricePrice.Focus()
        Else
            Dim itemPriceId As Integer = gSelectedItemPriceId
            Dim query As String = String.Empty
            query &= "UPDATE ItemPriceEntityWise set itemId=@itemId, price=@price"
            query &= " where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", itemPriceId.ToString)
                    .Parameters.AddWithValue("@itemId", cmbItemPriceItemList.SelectedValue)
                    .Parameters.AddWithValue("@price", getDBNullValueIfTextBoxNull(txtItemPricePrice))
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("ItemPriceEntityWise successfully updated")
            loadItemPriceListAndGrid(cmbItemPriceEntityList.SelectedValue)
        End If
    End Sub

    Private Sub btnItemPriceDelete_Click(sender As Object, e As EventArgs) Handles btnItemPriceDelete.Click
        If (cmbItemPriceIdList.SelectedIndex = -1 Or cmbItemPriceIdList.SelectedValue = -1) Then
            MessageBox.Show("Please select a item's price id")
            cmbItemPriceIdList.Focus()
            Return
        End If

        If MessageBox.Show("Are you sure to delete this ItemPriceEntityWise - " & cmbItemPriceIdList.Text & " ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim query As String = String.Empty
            query &= "DELETE FROM itemPrice where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", cmbItemPriceIdList.SelectedValue)
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("ItemPriceEntityWise successfully deleted")
            loadItemPriceListAndGrid(cmbItemPriceEntityList.SelectedValue)
        End If
    End Sub

    Private Sub gbEntities_Enter(sender As Object, e As EventArgs) Handles gbEntities.Enter
        Me.AcceptButton = btnEntityAdd
    End Sub

    Private Sub gbItems_Enter(sender As Object, e As EventArgs) Handles gbItems.Enter
        Me.AcceptButton = btnItemAdd
    End Sub

    Private Sub gbItemsPrice_Enter(sender As Object, e As EventArgs) Handles gbItemsPrice.Enter
        Me.AcceptButton = btnItemPriceAdd
    End Sub

    Sub setItemListInItemPrice(itemTable As DataTable)
        Dim dummyFirstRow As DataRow = itemTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select an Item..."
        itemTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbItemPriceItemList.BindingContext = New BindingContext()
        cmbItemPriceItemList.DataSource = itemTable
    End Sub

    Private Sub cmbItemPriceItemCategoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemPriceItemCategoryList.SelectedIndexChanged
        Dim itemTable As DataTable

        If (cmbItemPriceItemCategoryList.SelectedIndex = -1 Or cmbItemPriceItemCategoryList.SelectedValue = -1) Then
            itemTable = New DataTable
            itemTable.Columns.Add("id", GetType(Integer))
            itemTable.Columns.Add("name", GetType(String))
            setItemListInItemPrice(itemTable)
            Return
        End If

        itemTable = getItemTable(cmbItemPriceItemCategoryList.SelectedValue)
        setItemListInItemPrice(itemTable)
    End Sub

    Private Sub cmbBillsEntityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBillsEntityList.SelectedIndexChanged
        If (cmbBillsEntityList.SelectedIndex = -1 Or cmbBillsEntityList.SelectedValue = -1) Then
            tvBillsBillItems.Nodes.Clear()
            Return
        End If

        loadBillsList(cmbBillsEntityList.SelectedValue)
        loadItemPriceTreeView(cmbBillsEntityList.SelectedValue)
    End Sub

    Sub loadBillsList(entityId As Integer)
        Dim thread As Thread = New Thread(AddressOf loadBillsListAndGridInThread)
        thread.IsBackground = True
        thread.Start(entityId)
    End Sub

    Sub loadBillsListAndGridInThread(entityId As Integer)
        Dim billsQuery = New SqlCommand("Select *,CONVERT(varchar(5), id) as name from bill where entityId=" + entityId.ToString(), dbConnection)
        Dim billsAdapter = New SqlDataAdapter()
        billsAdapter.SelectCommand = billsQuery
        Dim billsDataSet = New DataSet
        billsAdapter.Fill(billsDataSet, "bills")
        Dim billsTable As DataTable = billsDataSet.Tables(0)
        Dim billsTableForGrid As DataTable = billsTable.Copy()

        Dim entityQuery = New SqlCommand("Select * from entity where id=" + entityId.ToString(), dbConnection)
        Dim entityAdapter = New SqlDataAdapter()
        entityAdapter.SelectCommand = entityQuery
        Dim entityDataSet = New DataSet
        entityAdapter.Fill(entityDataSet, "entity")
        Dim entityTable As DataTable = entityDataSet.Tables(0)
        Dim taxPercent As Decimal = 0
        If entityTable.Rows.Count > 0 Then
            Dim dataRow = entityTable.Rows(0)
            taxPercent = dataRow.Item("taxPercent")
        End If

        Dim setTaxPercentInBillScreenInvoker As New setTaxPercentInBillScreenDelegate(AddressOf Me.setTaxPercentInBillScreen)
        Me.BeginInvoke(setTaxPercentInBillScreenInvoker, taxPercent)

        Dim setBillsListInvoker As New setBillsListDelegate(AddressOf Me.setBillsList)
        Me.BeginInvoke(setBillsListInvoker, billsTable)

        Dim setBillsGridInvoker As New setBillsGridDelegate(AddressOf Me.setBillsGrid)
        Me.BeginInvoke(setBillsGridInvoker, billsTableForGrid)
    End Sub

    Delegate Sub setBillsListDelegate(billsTable As DataTable)

    Sub setBillsList(billsTable As DataTable)
        Dim dummyFirstRow As DataRow = billsTable.NewRow()
        dummyFirstRow("id") = -1
        dummyFirstRow("name") = "Select a bill id..."
        billsTable.Rows.InsertAt(dummyFirstRow, 0)

        cmbBillsBillIdList.BindingContext = New BindingContext()
        cmbBillsBillIdList.DataSource = billsTable
    End Sub

    Delegate Sub setBillsGridDelegate(itemPriceTable As DataTable)

    Sub setBillsGrid(itemPriceTable As DataTable)
        dgvBillsBillGrid.DataSource = itemPriceTable
        If itemPriceTable.Rows.Count > 0 Then
            dgvBillsBillGrid.FirstDisplayedScrollingRowIndex = itemPriceTable.Rows.Count - 1
        End If
    End Sub

    Sub loadItemPriceTreeView(entityId As Integer)
        Dim thread As Thread = New Thread(AddressOf loadItemPriceTreeViewInThread)
        thread.IsBackground = True
        thread.Start(entityId)
    End Sub

    Delegate Sub setTaxPercentInBillScreenDelegate(taxPercent As Decimal)

    Sub setTaxPercentInBillScreen(taxPercent As Decimal)
        txtBillsTaxPercent.Text = taxPercent
    End Sub

    Sub loadItemPriceTreeViewInThread(entityId As Integer)

        Dim itemCategoryQuery = New SqlCommand("Select ic.id, ic.name as categoryName from ItemPriceEntityWise ip,
                            Item i, ItemCategory ic where ip.itemId = i.id and i.categoryId=ic.id and 
                            ip.entityId=" + entityId.ToString() + " group by ic.id, ic.name", dbConnection)
        Dim itemCategoryAdapter = New SqlDataAdapter()
        itemCategoryAdapter.SelectCommand = itemCategoryQuery
        Dim itemCategoryAndPriceDataset As DataSet = New DataSet
        itemCategoryAdapter.Fill(itemCategoryAndPriceDataset, "ItemCategory")
        Dim itemCategoryTable As DataTable = itemCategoryAndPriceDataset.Tables(0)

        Dim itemPriceQuery = New SqlCommand("Select ip.id, i.categoryId, i.name as itemName, ip.price
                             from ItemPriceEntityWise ip, Item i where ip.itemId = i.id and 
                             ip.entityId=" + entityId.ToString(), dbConnection)
        Dim itemPriceAdapter = New SqlDataAdapter()
        itemPriceAdapter.SelectCommand = itemPriceQuery
        itemPriceAdapter.Fill(itemCategoryAndPriceDataset, "ItemPriceEntityWise")
        Dim itemPriceTable As DataTable = itemCategoryAndPriceDataset.Tables(1)

        'Create a data relation object to facilitate the relationship between the Customers and Orders data tables.
        itemCategoryAndPriceDataset.Relations.Add("CategoryWiseItems", itemCategoryTable.Columns("id"),
                                                  itemPriceTable.Columns("categoryId"))

        Dim setItemPriceTreeDataInvoker As New setItemPriceTreeDataDelegate(AddressOf Me.setItemPriceTreeData)
        Me.BeginInvoke(setItemPriceTreeDataInvoker, itemCategoryAndPriceDataset)

    End Sub

    Sub getselectedItemsPriceIds(selectedItemsPriceIds As List(Of String), currentnode As TreeNode)
        For Each node As TreeNode In currentnode.Nodes
            If node.Tag <> "-1" AndAlso node.Checked Then
                selectedItemsPriceIds.Add(node.Tag)
            End If

            getselectedItemsPriceIds(selectedItemsPriceIds, node)
        Next
    End Sub

    Private Sub tvBillsItemsToSelect_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvBillsBillItems.AfterCheck
        log.Debug("tvBillSelectionItemsToSelect_AfterCheck: called")
        tvBillsBillItems.SelectedNode = Nothing

        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                log.Debug("tvBillSelectionItemsToSelect_AfterCheck: calling checkChildNodes")
                checkChildNodes(e.Node, e.Node.Checked)
            End If
            checkParentNodes(e.Node, e.Node.Checked)
        End If

        If e.Node.Tag = "-1" Then
            Return
        End If

        Dim selectedItemsPriceIds As List(Of String) = New List(Of String)
        getselectedItemsPriceIds(selectedItemsPriceIds, tvBillsBillItems.TopNode)

        Dim billItemsQtyDataTable As New DataTable
        billItemsQtyDataTable.Columns.AddRange(New DataColumn() {New DataColumn("id", GetType(Integer)),
                                               New DataColumn("itemName", GetType(String)),
                                               New DataColumn("itemPrice", GetType(Decimal)),
                                               New DataColumn("qty", GetType(Integer))})

        Dim itemPriceId As Integer = -1
        Dim itemName As String = String.Empty
        Dim itemPrice As Decimal = -1
        Dim selectedItemDetails As List(Of String) = New List(Of String)
        For Each itemPriceStr As String In selectedItemsPriceIds
            selectedItemDetails.Clear()
            log.Debug("itemPriceStr: " + itemPriceStr)
            selectedItemDetails.AddRange(itemPriceStr.Split(":"c))
            itemPriceId = Integer.Parse(selectedItemDetails.ElementAt(0))
            log.Debug("itemPriceId: " + itemPriceId.ToString)
            itemName = selectedItemDetails.ElementAt(1)
            itemPrice = Decimal.Parse(selectedItemDetails.ElementAt(2))
            billItemsQtyDataTable.Rows.Add(itemPriceId, itemName, itemPrice, 1)
        Next
        dgvBillsItemsQty.DataSource = billItemsQtyDataTable

        txtBillsItemPriceIds.Text = String.Join(",", selectedItemsPriceIds)

        log.Debug("tvBillSelectionItemsToSelect_AfterCheck: " + txtBillsItemPriceIds.Text)

        'loadSelectedItemPrices(selectedItemsPriceIds)
    End Sub

    Sub loadSelectedItemPrices(selectedItemsPriceIds As List(Of Integer))
        Dim thread As Thread = New Thread(AddressOf loadSelectedItemPricesInThread)
        thread.IsBackground = True
        thread.Start(selectedItemsPriceIds)
    End Sub

    Sub loadSelectedItemPricesInThread(selectedItemsPriceIds As List(Of Integer))
        Dim selectedItemPricesTotal As Decimal = 0

        If selectedItemsPriceIds.Count = 0 Then
            selectedItemPricesTotal = 0
        Else
            'Dim selectedItemPricesQuery = New SqlCommand("Select ip.*,i.name as itemName from ItemPriceEntityWise ip, item i 
            '        where ip.itemId = i.id and ip.id in (" + String.Join(", ", selectedItemsPriceIds) + ")", dbConnection)
            'Dim selectedItemPricesAdapter = New SqlDataAdapter()
            'selectedItemPricesAdapter.SelectCommand = selectedItemPricesQuery
            'Dim selectedItemPricesDataSet = New DataSet
            'selectedItemPricesAdapter.Fill(selectedItemPricesDataSet, "ItemPriceEntityWise")
            'Dim selectedItemPricesTable As DataTable = selectedItemPricesDataSet.Tables(0)

            Dim selectedItemPricesTotalQuery = New SqlCommand("Select sum(price) as totalPrice from ItemPriceEntityWise 
                where id in (" + String.Join(",", selectedItemsPriceIds) + ")", dbConnection)
            Dim selectedItemPricesTotalAdapter = New SqlDataAdapter()
            selectedItemPricesTotalAdapter.SelectCommand = selectedItemPricesTotalQuery
            Dim selectedItemPricesTotalDataSet = New DataSet
            selectedItemPricesTotalAdapter.Fill(selectedItemPricesTotalDataSet, "ItemPriceTotal")
            Dim selectedItemPricesTotalTable As DataTable = selectedItemPricesTotalDataSet.Tables(0)


            If selectedItemPricesTotalTable.Rows.Count > 0 Then
                selectedItemPricesTotal = selectedItemPricesTotalTable.Rows(0).Item("totalPrice")
                'Dim selectedItemPricesTotalRow As DataRow = selectedItemPricesTable.NewRow
                'selectedItemPricesTotalRow("price") = selectedItemPricesTotal.ToString
                'selectedItemPricesTotalRow("itemName") = "Total"
                'selectedItemPricesTable.Rows.Add(selectedItemPricesTotalRow)
            End If
        End If

        Dim setSelectedItemPricesGridInvoker As New setSelectedItemPricesGridDelegate(AddressOf Me.setSelectedItemPricesGrid)
        Me.BeginInvoke(setSelectedItemPricesGridInvoker, selectedItemPricesTotal)
    End Sub

    Delegate Sub setSelectedItemPricesGridDelegate(selectedItemPricesTotal As Decimal)

    Sub setSelectedItemPricesGrid(selectedItemPricesTotal As Decimal)
        txtBillsItemTotalPrice.Text = selectedItemPricesTotal
    End Sub


    Private Sub cmbBillsBillIdList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBillsBillIdList.SelectedIndexChanged
        If (cmbBillsBillIdList.SelectedIndex = -1 Or cmbBillsBillIdList.SelectedValue = -1) Then
            emptyBillsScreen()
            Return
        End If

        loadBillDetailsByBillId(cmbBillsEntityList.SelectedValue)
        'loadItemPriceTreeView(cmbBillsEntityList.SelectedValue)
    End Sub

    Private Sub loadBillDetailsByBillId(entityId As Integer)
        Dim billId As Integer = cmbBillsBillIdList.SelectedValue
        gSelectedBillId = billId

        Dim itemCategoryAndPriceDataset As DataSet = New DataSet

        Dim billSelectQuery = New SqlCommand("select * from bill where id=" + billId.ToString, dbConnection)
        Dim billDataAdapter = New SqlDataAdapter()
        billDataAdapter.SelectCommand = billSelectQuery
        billDataAdapter.Fill(itemCategoryAndPriceDataset, "Bill")
        Dim billTable = itemCategoryAndPriceDataset.Tables("Bill")

        If (billTable.Rows.Count > 0) Then
            Dim dataRow = billTable.Rows(0)
            txtBillsDisplayBillId.Text = dataRow.Item("displayBillId")
            dtpBillsBillDate.Text = dataRow.Item("dateTime")
            txtBillsItemPriceIds.Text = dataRow.Item("itemPriceIds")
            txtBillsItemTotalPrice.Text = dataRow.Item("itemsPriceInTotal")
            txtBillsTaxAmount.Text = dataRow.Item("taxAmount")
            txtBillsFinalBillAmount.Text = dataRow.Item("finalBillAmount")
            txtBillsRemarks.Text = If(dataRow.Item("remarks") Is DBNull.Value, "", dataRow.Item("remarks"))
            txtBillsPlaceCameFrom.Text = If(dataRow.Item("placeCameFrom") Is DBNull.Value, "", dataRow.Item("placeCameFrom"))
        End If

        Dim itemCategoryQuery = New SqlCommand("Select ic.id, ic.name as categoryName from ItemPriceEntityWise ip,
                            Item i, ItemCategory ic where ip.itemId = i.id and i.categoryId=ic.id and 
                            ip.entityId=" + entityId.ToString() + " group by ic.id, ic.name", dbConnection)
        Dim itemCategoryAdapter = New SqlDataAdapter()
        itemCategoryAdapter.SelectCommand = itemCategoryQuery
        itemCategoryAdapter.Fill(itemCategoryAndPriceDataset, "ItemCategory")
        Dim itemCategoryTable As DataTable = itemCategoryAndPriceDataset.Tables("ItemCategory")

        Dim itemPriceQuery = New SqlCommand("Select ip.id, i.categoryId, i.name as itemName, ip.price
                             from ItemPriceEntityWise ip, Item i where ip.itemId = i.id and 
                             ip.entityId=" + entityId.ToString(), dbConnection)
        Dim itemPriceAdapter = New SqlDataAdapter()
        itemPriceAdapter.SelectCommand = itemPriceQuery
        itemPriceAdapter.Fill(itemCategoryAndPriceDataset, "ItemPriceEntityWise")
        Dim itemPriceTable As DataTable = itemCategoryAndPriceDataset.Tables("ItemPriceEntityWise")

        'Create a data relation object to facilitate the relationship between the Customers and Orders data tables.
        itemCategoryAndPriceDataset.Relations.Add("CategoryWiseItems", itemCategoryTable.Columns("id"),
                                                  itemPriceTable.Columns("categoryId"))

        Dim setItemPriceTreeDataInvoker As New setItemPriceTreeDataDelegate(AddressOf Me.setItemPriceTreeData)
        Me.BeginInvoke(setItemPriceTreeDataInvoker, itemCategoryAndPriceDataset)
    End Sub

    Delegate Sub setItemPriceTreeDataDelegate(itemCategoryAndPriceDataset As DataSet)

    Sub setItemPriceTreeData(itemCategoryAndPriceDataset As DataSet)

        log.Debug("setItemPriceTreeData: called")

        Dim billTable = itemCategoryAndPriceDataset.Tables("Bill")
        Dim itemCategoryTable = itemCategoryAndPriceDataset.Tables("ItemCategory")
        Dim itemPriceTable = itemCategoryAndPriceDataset.Tables("ItemPriceEntityWise")

        Dim itemPriceIdsList As List(Of String) = New List(Of String)

        If billTable IsNot Nothing AndAlso billTable.Rows.Count > 0 Then
            Dim dataRow = billTable.Rows(0)
            Dim itemPriceIds As String = dataRow.Item("itemPriceIds")
            itemPriceIdsList.AddRange(itemPriceIds.Split(","c))
        End If

        tvBillsBillItems.Nodes.Clear()
        Dim availableItemsNode As TreeNode = New TreeNode("Available Items")
        availableItemsNode.Tag = "-1"
        tvBillsBillItems.Nodes.Add(availableItemsNode)

        Dim itemCategoryRow As DataRow
        For Each itemCategoryRow In itemCategoryTable.Rows
            Dim itemCategoryNode As TreeNode = New TreeNode(itemCategoryRow.Item("categoryName"))
            itemCategoryNode.Tag = "-1"
            availableItemsNode.Nodes.Add(itemCategoryNode)

            Dim itemPriceRow As DataRow
            For Each itemPriceRow In itemCategoryRow.GetChildRows("CategoryWiseItems")
                Dim itemPriceNode As TreeNode = New TreeNode(itemPriceRow.Item("itemName") & " - Price: " & itemPriceRow.Item("price"))
                Dim itemPriceId As Integer = itemPriceRow.Item("id")
                itemPriceNode.Tag = itemPriceId.ToString + ":" + itemPriceRow.Item("itemName") + ":" + itemPriceRow.Item("price").ToString
                If itemPriceIdsList.Contains(itemPriceId.ToString) Then
                    log.Debug("setItemPriceTreeData: " + itemPriceId.ToString + "found in list. so making it as checked node")
                    itemPriceNode.Checked = True
                End If
                itemCategoryNode.Nodes.Add(itemPriceNode)

            Next itemPriceRow

        Next itemCategoryRow

        tvBillsBillItems.ExpandAll()

    End Sub

    Sub resetBillsScreen()
        resetIndexOfComboBox(cmbBillsBillIdList)
    End Sub

    Sub emptyBillsScreen()
        txtBillsDisplayBillId.Text = ""
        dtpBillsBillDate.Text = ""
        txtBillsItemPriceIds.Text = ""
        txtBillsItemTotalPrice.Text = ""
        txtBillsTaxAmount.Text = ""
        txtBillsFinalBillAmount.Text = ""
        txtBillsRemarks.Text = ""
        txtBillsPlaceCameFrom.Text = ""
        deselectAllNodes(tvBillsBillItems.TopNode)
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        resetBillsScreen()
    End Sub

    Private Sub btnBillsAdd_Click(sender As Object, e As EventArgs) Handles btnBillsAdd.Click
        Try
            If cmbBillsEntityList.SelectedIndex = -1 Or cmbBillsEntityList.SelectedValue = -1 Then
                MessageBox.Show("Select a valid entity")
                cmbBillsEntityList.Focus()
            ElseIf txtBillsDisplayBillId.Text.Trim() = "" Then
                MessageBox.Show("Enter valid display bill id")
                txtBillsDisplayBillId.Focus()
            ElseIf txtBillsItemPriceIds.Text.Trim() = "" Or txtBillsItemTotalPrice.Text.Trim() = "" Or txtBillsFinalBillAmount.Text.Trim() = "" Then

                MessageBox.Show("Select atleast one item to bill")
                txtBillsItemPriceIds.Focus()
            Else
                Dim query As String = String.Empty
                query &= "INSERT INTO Bill (displayBillId, entityId, dateTime, itemPriceIds, itemsPriceInTotal, taxAmount, finalBillAmount, remarks, placeCameFrom) "
                query &= "VALUES (@displayBillId, @entityId, @dateTime, @itemPriceIds, @itemsPriceInTotal, @taxAmount, @finalBillAmount, @remarks, @placeCameFrom); Select SCOPE_IDENTITY()"
                Dim newBillNo As Integer = -1

                Using comm As New SqlCommand()
                    With comm
                        .Connection = dbConnection
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@displayBillId", txtBillsDisplayBillId.Text)
                        .Parameters.AddWithValue("@entityId", cmbBillsEntityList.SelectedValue)
                        .Parameters.AddWithValue("@dateTime", dtpBillsBillDate.Value)
                        .Parameters.AddWithValue("@itemPriceIds", txtBillsItemPriceIds.Text)
                        .Parameters.AddWithValue("@itemsPriceInTotal", txtBillsItemTotalPrice.Text)
                        .Parameters.AddWithValue("@taxAmount", getDecimalZeroIfNull(txtBillsTaxAmount))
                        .Parameters.AddWithValue("@finalBillAmount", txtBillsFinalBillAmount.Text)
                        .Parameters.AddWithValue("@remarks", getDBNullValueIfTextBoxNull(txtBillsRemarks))
                        .Parameters.AddWithValue("@placeCameFrom", getDBNullValueIfTextBoxNull(txtBillsPlaceCameFrom))
                    End With
                    newBillNo = CInt(comm.ExecuteScalar())
                End Using

                Dim itemPriceIds As String = txtBillsItemPriceIds.Text
                Dim itemPriceIdsList As List(Of String) = New List(Of String)
                itemPriceIdsList.AddRange(itemPriceIds.Split(","c))

                query = String.Empty
                query &= "INSERT INTO BillItems (billId, itemPriceId, qty) "
                query &= "VALUES (@billId, @itemPriceId, @qty)"
                Dim cmdSql As New SqlCommand(query, dbConnection)
                cmdSql.CommandType = CommandType.Text
                'daSql.InsertCommand = cmdSql

                For Each itemPriceId As Integer In itemPriceIdsList
                    cmdSql.Parameters.Clear()
                    With cmdSql
                        .Connection = dbConnection
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@billId", newBillNo.ToString)
                        .Parameters.AddWithValue("@itemPriceId", itemPriceId.ToString)
                        .Parameters.AddWithValue("@qty", 1)
                    End With
                    cmdSql.ExecuteNonQuery()
                Next

                MessageBox.Show("Bills successfully added")
                loadBillsListAndGridInThread(cmbBillsEntityList.SelectedValue)
            End If
        Catch sqlEx As SqlException When sqlEx.Number = 2627
            MsgBox("Duplicate Bills entry. check if any other bills exists with same bill name")
        End Try
    End Sub

    Private Sub txtBillsItemTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtBillsItemTotalPrice.TextChanged
        Dim taxPercent As Decimal = getDecimalZeroIfNull(txtBillsTaxPercent)
        Dim billsItemsTotalPrice As Decimal = getDecimalZeroIfNull(txtBillsItemTotalPrice)
        Dim taxAmount As Decimal = billsItemsTotalPrice * taxPercent / 100
        txtBillsTaxAmount.Text = Format(taxAmount, "0.00")
        txtBillsFinalBillAmount.Text = billsItemsTotalPrice + taxAmount
    End Sub

    Function getDecimalZeroIfNull(textBox As TextBox) As Decimal
        Dim returnValue As Decimal = Decimal.Parse(If(String.IsNullOrEmpty(textBox.Text), 0, textBox.Text))
        Return returnValue
    End Function

    Function getIntegerZeroIfNull(textBox As TextBox) As Integer
        Dim returnValue As Integer = Integer.Parse(If(String.IsNullOrEmpty(textBox.Text), 0, textBox.Text))
        Return returnValue
    End Function

    Function getDBNullValueIfTextBoxNull(textBox As TextBox) As Object
        Dim returnValue = If(String.IsNullOrEmpty(textBox.Text), DBNull.Value, textBox.Text)
        Return returnValue
    End Function

    Function getDBNullValueIfComboBoxNull(comboBox As ComboBox) As Object
        Dim returnValue = If(String.IsNullOrEmpty(comboBox.Text), DBNull.Value, comboBox.Text)
        Return returnValue
    End Function

    Private Sub checkChildNodes(ByVal parentNode As TreeNode, isparentNodeChecked As Boolean)
        For Each childNode As TreeNode In parentNode.Nodes
            If childNode.Checked <> isparentNodeChecked Then
                childNode.Checked = isparentNodeChecked
            End If

            If childNode.Nodes.Count > 0 Then
                checkChildNodes(childNode, childNode.Checked)
            End If
        Next
    End Sub

    Private Sub checkParentNodes(ByVal childNode As TreeNode, isChildNodeChecked As Boolean)
        Dim parentNode As TreeNode = childNode.Parent

        If parentNode Is Nothing Then
            Return
        End If

        If childNode.Checked = True And parentNode.Checked = False Then
            parentNode.Checked = True
            checkParentNodes(parentNode, parentNode.Checked)
            Return
        End If

        Dim noneSelected As Boolean = True
        If childNode.Checked = False Then
            For Each childNodeInParent As TreeNode In parentNode.Nodes
                If childNodeInParent.Checked = True Then
                    noneSelected = False
                    Exit For
                End If
            Next
            If noneSelected = True Then
                parentNode.Checked = False
                checkParentNodes(parentNode, parentNode.Checked)
            End If
        End If

    End Sub

    Private Sub deselectAllNodes(ByVal node As TreeNode)
        If node Is Nothing Then
            Return
        End If
        node.Checked = False
        For Each childNode As TreeNode In node.Nodes
            deselectAllNodes(childNode)
        Next
    End Sub

    Private Sub dgvBillsBillGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBillsBillGrid.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim billId As Integer = dgvBillsBillGrid.Item("BillsBillId", e.RowIndex).Value
        cmbBillsBillIdList.SelectedValue = billId

        loadBillDetailInReport(billId)
    End Sub

    Private Sub btnBillsUpdate_Click(sender As Object, e As EventArgs) Handles btnBillsUpdate.Click
        If (gSelectedBillId = -1) Then
            MessageBox.Show("Please select a bill id")
            cmbBillsBillIdList.Focus()
            Return
        End If

        If txtBillsDisplayBillId.Text.Trim() = "" Then
            MessageBox.Show("Enter valid display bill id")
            txtBillsDisplayBillId.Focus()
        ElseIf txtBillsItemPriceIds.Text.Trim() = "" Or txtBillsItemTotalPrice.Text.Trim() = "" Or txtBillsFinalBillAmount.Text.Trim() = "" Then
            MessageBox.Show("Select atleast one item to bill")
            txtBillsItemPriceIds.Focus()
        Else

            Dim query As String = String.Empty
            query &= "UPDATE Bill set displayBillId=@displayBillId, entityId=@entityId, dateTime=@dateTime, 
                        itemPriceIds=@itemPriceIds, itemsPriceInTotal=@itemsPriceInTotal, taxAmount=@taxAmount, 
                        finalBillAmount=@finalBillAmount, remarks=@remarks, placeCameFrom=@placeCameFrom 
                        where id=@billId"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@billId", gSelectedBillId.ToString)
                    .Parameters.AddWithValue("@displayBillId", txtBillsDisplayBillId.Text)
                    .Parameters.AddWithValue("@entityId", cmbBillsEntityList.SelectedValue)
                    .Parameters.AddWithValue("@dateTime", dtpBillsBillDate.Value)
                    .Parameters.AddWithValue("@itemPriceIds", txtBillsItemPriceIds.Text)
                    .Parameters.AddWithValue("@itemsPriceInTotal", txtBillsItemTotalPrice.Text)
                    .Parameters.AddWithValue("@taxAmount", getDecimalZeroIfNull(txtBillsTaxAmount))
                    .Parameters.AddWithValue("@finalBillAmount", txtBillsFinalBillAmount.Text)
                    .Parameters.AddWithValue("@remarks", getDBNullValueIfTextBoxNull(txtBillsRemarks))
                    .Parameters.AddWithValue("@placeCameFrom", getDBNullValueIfTextBoxNull(txtBillsPlaceCameFrom))
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Bills successfully updated")
            loadBillsListAndGridInThread(cmbBillsEntityList.SelectedValue)
        End If

    End Sub

    Private Sub btnBillsDelete_Click(sender As Object, e As EventArgs) Handles btnBillsDelete.Click
        If (gSelectedBillId = -1) Then
            MessageBox.Show("Please select a bill id")
            cmbBillsBillIdList.Focus()
            Return
        End If

        If MessageBox.Show("Are you sure to delete this bill - " & gSelectedBillId.ToString & " ?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim query As String = String.Empty
            query &= "DELETE FROM bill where id=@id"

            Using comm As New SqlCommand()
                With comm
                    .Connection = dbConnection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", gSelectedBillId.ToString)
                End With
                comm.ExecuteNonQuery()
            End Using
            MessageBox.Show("Bill successfully deleted")
            loadBillsListAndGridInThread(cmbBillsEntityList.SelectedValue)
        End If
    End Sub

    Sub loadBillDetailInReport(billId As Integer)
        Dim thread As Thread = New Thread(AddressOf loadBillDetailInReportInThread)
        thread.IsBackground = True
        thread.Start(billId)
    End Sub

    Sub loadBillDetailInReportInThread(billId As Integer)
        Dim billDetailQuery = New SqlCommand("select i.name,ip.price from ItemPriceEntityWise ip, Item i where i.id=ip.itemId and ip.id in (Select itemPriceIds from Bill where id=" + billId.ToString + ")", dbConnection)
        Dim billDetailAdapter = New SqlDataAdapter()
        billDetailAdapter.SelectCommand = billDetailQuery
        Dim billDetailDataSet = New DataSet
        billDetailAdapter.Fill(billDetailDataSet, "BillDetail")
        Dim billDetailTable As DataTable = billDetailDataSet.Tables(0)

        log.Debug("billDetailTable row count: " + billDetailTable.Rows.Count.ToString)

        Dim setBillDetailInReportInvoker As New setBillDetailInReportDelegate(AddressOf Me.setBillDetailInReport)
        Me.BeginInvoke(setBillDetailInReportInvoker, billDetailTable)
    End Sub

    Delegate Sub setBillDetailInReportDelegate(billDetailTable As DataTable)

    Sub setBillDetailInReport(billDetailTable As DataTable)
        Dim billCrystalReport As New CR_GeneralBill

        billCrystalReport.SetDataSource(billDetailTable)
        crvBillReport.ReportSource = billCrystalReport
    End Sub

    Private Sub dgvBillsItemsQty_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBillsItemsQty.CellValueChanged
        If e.ColumnIndex = 3 Then
            txtBillsItemTotalPrice.Text = getTotalPriceFromBillItemsQtyGrid(dgvBillsItemsQty.DataSource)
        End If
    End Sub

    Private Function getTotalPriceFromBillItemsQtyGrid(billItemPriceQtyTable As DataTable) As Decimal
        If billItemPriceQtyTable Is Nothing Then
            Return 0
        End If

        Dim totalPriceAmount As Decimal = 0
        For Each dataRow As DataRow In billItemPriceQtyTable.Rows
            totalPriceAmount += Decimal.Parse(dataRow.Item("itemPrice")) * Integer.Parse(dataRow.Item("qty"))
        Next

        Return totalPriceAmount
    End Function

    Private Sub dgvBillsItemsQty_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvBillsItemsQty.DataSourceChanged
        txtBillsItemTotalPrice.Text = getTotalPriceFromBillItemsQtyGrid(dgvBillsItemsQty.DataSource)
    End Sub
End Class