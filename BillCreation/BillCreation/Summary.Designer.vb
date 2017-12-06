<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBillTotalAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvEntityWiseTotal = New System.Windows.Forms.DataGridView()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDateWiseTotal = New System.Windows.Forms.DataGridView()
        Me.dateWiseTotaldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entityWiseTotalEntityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntityWiseBillsCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entityWiseTotalEntityAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEntityWiseTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDateWiseTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBillTotalAmount
        '
        Me.txtBillTotalAmount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillTotalAmount.Location = New System.Drawing.Point(141, 6)
        Me.txtBillTotalAmount.Name = "txtBillTotalAmount"
        Me.txtBillTotalAmount.ReadOnly = True
        Me.txtBillTotalAmount.Size = New System.Drawing.Size(153, 32)
        Me.txtBillTotalAmount.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvEntityWiseTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 702)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entity Wise Total "
        '
        'dgvEntityWiseTotal
        '
        Me.dgvEntityWiseTotal.AllowUserToAddRows = False
        Me.dgvEntityWiseTotal.AllowUserToDeleteRows = False
        Me.dgvEntityWiseTotal.AllowUserToResizeRows = False
        Me.dgvEntityWiseTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntityWiseTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.entityWiseTotalEntityName, Me.EntityWiseBillsCount, Me.entityWiseTotalEntityAmount})
        Me.dgvEntityWiseTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEntityWiseTotal.Location = New System.Drawing.Point(3, 22)
        Me.dgvEntityWiseTotal.Name = "dgvEntityWiseTotal"
        Me.dgvEntityWiseTotal.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEntityWiseTotal.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEntityWiseTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntityWiseTotal.Size = New System.Drawing.Size(449, 677)
        Me.dgvEntityWiseTotal.TabIndex = 0
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(49, 14)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(86, 13)
        Me.Label40.TabIndex = 28
        Me.Label40.Text = "Total Bill Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDateWiseTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(544, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 699)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Wise Total"
        '
        'dgvDateWiseTotal
        '
        Me.dgvDateWiseTotal.AllowUserToAddRows = False
        Me.dgvDateWiseTotal.AllowUserToDeleteRows = False
        Me.dgvDateWiseTotal.AllowUserToResizeRows = False
        Me.dgvDateWiseTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDateWiseTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateWiseTotaldate, Me.DataGridViewTextBoxColumn2})
        Me.dgvDateWiseTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDateWiseTotal.Location = New System.Drawing.Point(3, 22)
        Me.dgvDateWiseTotal.Name = "dgvDateWiseTotal"
        Me.dgvDateWiseTotal.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDateWiseTotal.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDateWiseTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDateWiseTotal.Size = New System.Drawing.Size(375, 674)
        Me.dgvDateWiseTotal.TabIndex = 0
        '
        'dateWiseTotaldate
        '
        Me.dateWiseTotaldate.DataPropertyName = "datetime"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.dateWiseTotaldate.DefaultCellStyle = DataGridViewCellStyle3
        Me.dateWiseTotaldate.HeaderText = "date"
        Me.dateWiseTotaldate.Name = "dateWiseTotaldate"
        Me.dateWiseTotaldate.Width = 170
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "totalAmount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "total"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'entityWiseTotalEntityName
        '
        Me.entityWiseTotalEntityName.DataPropertyName = "name"
        Me.entityWiseTotalEntityName.HeaderText = "name"
        Me.entityWiseTotalEntityName.Name = "entityWiseTotalEntityName"
        Me.entityWiseTotalEntityName.Width = 250
        '
        'EntityWiseBillsCount
        '
        Me.EntityWiseBillsCount.DataPropertyName = "billCount"
        Me.EntityWiseBillsCount.HeaderText = "bill count"
        Me.EntityWiseBillsCount.Name = "EntityWiseBillsCount"
        '
        'entityWiseTotalEntityAmount
        '
        Me.entityWiseTotalEntityAmount.DataPropertyName = "total"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.entityWiseTotalEntityAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.entityWiseTotalEntityAmount.HeaderText = "total"
        Me.entityWiseTotalEntityAmount.Name = "entityWiseTotalEntityAmount"
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtBillTotalAmount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Summary"
        Me.Text = "Summary"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvEntityWiseTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDateWiseTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBillTotalAmount As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvEntityWiseTotal As DataGridView
    Friend WithEvents Label40 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvDateWiseTotal As DataGridView
    Friend WithEvents dateWiseTotaldate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents entityWiseTotalEntityName As DataGridViewTextBoxColumn
    Friend WithEvents EntityWiseBillsCount As DataGridViewTextBoxColumn
    Friend WithEvents entityWiseTotalEntityAmount As DataGridViewTextBoxColumn
End Class
