Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports NLog

Public Class Summary
    Dim dbConnection As SqlConnection
    Dim log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection = New SqlConnection("server=HIBAIL56209\ELASQLEXPRESS;Database=pos_billing;Integrated Security=true; MultipleActiveResultSets=True;")
        dbConnection.Open()

        loadTotalAmount()

    End Sub

    Sub loadTotalAmount()
        Dim thread As Thread = New Thread(AddressOf loadTotalAmountInThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Sub loadTotalAmountInThread()
        Dim entityTotalQuery = New SqlCommand("select e.name, count(1) as billCount, sum(b.itemsPriceInTotal+isnull(b.taxAmount1,0)+isnull(b.taxAmount2,0)+isnull(b.tipAmount,0)) as total from entity e, bill b where e.id=b.entityId group by e.name", dbConnection)
        Dim entityTotalAdapter = New SqlDataAdapter()
        entityTotalAdapter.SelectCommand = entityTotalQuery
        Dim totalDataSet = New DataSet
        entityTotalAdapter.Fill(totalDataSet, "EntityTotal")
        Dim entityTotalTable As DataTable = totalDataSet.Tables("EntityTotal")

        Dim dateWiseTotalQuery = New SqlCommand("select CAST(dateTime AS DATE) as dateTime, sum(itemsPriceInTotal+isnull(taxAmount1,0)+isnull(taxAmount2,0)+isnull(tipAmount,0)) as totalAmount from bill group by CAST(dateTime AS DATE)", dbConnection)
        Dim dateWiseTotalAdapter = New SqlDataAdapter()
        dateWiseTotalAdapter.SelectCommand = dateWiseTotalQuery
        dateWiseTotalAdapter.Fill(totalDataSet, "dateWiseTotal")
        Dim dateWiseTotalTable As DataTable = totalDataSet.Tables("dateWiseTotal")

        Dim totalQuery = New SqlCommand("select sum(itemsPriceInTotal+isnull(taxAmount1,0)+isnull(taxAmount2,0)+isnull(tipAmount,0)) as totalAmount from bill", dbConnection)
        Dim totalAdapter = New SqlDataAdapter()
        totalAdapter.SelectCommand = totalQuery
        totalAdapter.Fill(totalDataSet, "totalBillAmount")
        Dim totalTable As DataTable = totalDataSet.Tables("totalBillAmount")

        Dim totalAmount As Decimal = 0
        If totalTable.Rows.Count > 0 Then
            totalAmount = totalTable.Rows(0).Item("totalAmount")
        End If

        Dim setBillTotalAmountInvoker As New setsetEntityListDelegate(AddressOf Me.setBillTotalAmount)
        Me.BeginInvoke(setBillTotalAmountInvoker, totalAmount)

        Dim setEntityTotalGridInvoker As New setEntityTotalGridDelegate(AddressOf Me.setEntityTotalGrid)
        Me.BeginInvoke(setEntityTotalGridInvoker, entityTotalTable)

        Dim setDateWiseTotalGridInvoker As New setDateWiseTotalGridDelegate(AddressOf Me.setDateWiseTotalGrid)
        Me.BeginInvoke(setDateWiseTotalGridInvoker, dateWiseTotalTable)
    End Sub

    Delegate Sub setsetEntityListDelegate(entityTable As Decimal)

    Sub setBillTotalAmount(totalAmount As Decimal)
        txtBillTotalAmount.Text = totalAmount.ToString
    End Sub

    Delegate Sub setEntityTotalGridDelegate(entityTable As DataTable)

    Sub setEntityTotalGrid(entityTotalTable As DataTable)
        dgvEntityWiseTotal.DataSource = entityTotalTable
        If entityTotalTable.Rows.Count > 0 Then
            dgvEntityWiseTotal.FirstDisplayedScrollingRowIndex = entityTotalTable.Rows.Count - 1
        End If
    End Sub

    Delegate Sub setDateWiseTotalGridDelegate(dateWiseTotalTable As DataTable)

    Sub setDateWiseTotalGrid(dateWiseTotalTable As DataTable)
        dgvDateWiseTotal.DataSource = dateWiseTotalTable
        If dateWiseTotalTable.Rows.Count > 0 Then
            dgvDateWiseTotal.FirstDisplayedScrollingRowIndex = dateWiseTotalTable.Rows.Count - 1
        End If
    End Sub
End Class