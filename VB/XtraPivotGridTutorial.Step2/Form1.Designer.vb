﻿Namespace XtraPivotGridTutorial
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup2 As New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup3 As New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipCity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.xtraPivotGridTutorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New NwindDataSet.nwindDataSet()
            Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldFreight1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipperCompany1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.xtraPivotGridTutorialViewTableAdapter = New NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xtraPivotGridTutorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Year"
            Me.fieldOrderDate.FieldName = "OrderDate"
            Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
            ' 
            ' fieldOrderDate1
            ' 
            Me.fieldOrderDate1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate1.AreaIndex = 1
            Me.fieldOrderDate1.Caption = "Quarter"
            Me.fieldOrderDate1.ExpandedInFieldsGroup = False
            Me.fieldOrderDate1.FieldName = "OrderDate"
            Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
            Me.fieldOrderDate1.ValueFormat.FormatString = "Quarter {0}"
            Me.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldOrderDate2
            ' 
            Me.fieldOrderDate2.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate2.AreaIndex = 2
            Me.fieldOrderDate2.Caption = "Month"
            Me.fieldOrderDate2.ExpandedInFieldsGroup = False
            Me.fieldOrderDate2.FieldName = "OrderDate"
            Me.fieldOrderDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDate2.Name = "fieldOrderDate2"
            Me.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2"
            Me.fieldOrderDate2.Visible = False
            ' 
            ' fieldOrderDate3
            ' 
            Me.fieldOrderDate3.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldOrderDate3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate3.AreaIndex = 3
            Me.fieldOrderDate3.Caption = "Day"
            Me.fieldOrderDate3.FieldName = "OrderDate"
            Me.fieldOrderDate3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay
            Me.fieldOrderDate3.Name = "fieldOrderDate3"
            Me.fieldOrderDate3.UnboundFieldName = "fieldOrderDate3"
            Me.fieldOrderDate3.Visible = False
            ' 
            ' fieldShipCountry1
            ' 
            Me.fieldShipCountry1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldShipCountry1.AreaIndex = 0
            Me.fieldShipCountry1.Caption = "Ship Country"
            Me.fieldShipCountry1.FieldName = "ShipCountry"
            Me.fieldShipCountry1.Name = "fieldShipCountry1"
            Me.fieldShipCountry1.Visible = False
            ' 
            ' fieldShipCity1
            ' 
            Me.fieldShipCity1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldShipCity1.AreaIndex = 1
            Me.fieldShipCity1.Caption = "Ship City"
            Me.fieldShipCity1.FieldName = "ShipCity"
            Me.fieldShipCity1.Name = "fieldShipCity1"
            Me.fieldShipCity1.Visible = False
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category"
            Me.fieldCategoryName1.FieldName = "CategoryName"
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "Product"
            Me.fieldProductName1.FieldName = "ProductName"
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.xtraPivotGridTutorialBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldProductName1, Me.fieldUnitPrice1, Me.fieldQuantity1, Me.fieldPrice1, Me.fieldExtendedPrice1, Me.fieldFreight1, Me.fieldSalesPerson1, Me.fieldShipCountry1, Me.fieldShipCity1, Me.fieldShipperCompany1, Me.fieldOrderDate, Me.fieldOrderDate1, Me.fieldOrderDate2, Me.fieldOrderDate3, Me.fieldOrderDate4})
            pivotGridGroup1.Caption = "Calendar"
            pivotGridGroup1.Fields.Add(Me.fieldOrderDate)
            pivotGridGroup1.Fields.Add(Me.fieldOrderDate1)
            pivotGridGroup1.Fields.Add(Me.fieldOrderDate2)
            pivotGridGroup1.Fields.Add(Me.fieldOrderDate3)
            pivotGridGroup1.Hierarchy = Nothing
            pivotGridGroup1.ShowNewValues = True
            pivotGridGroup2.Caption = "Ship Info"
            pivotGridGroup2.Fields.Add(Me.fieldShipCountry1)
            pivotGridGroup2.Fields.Add(Me.fieldShipCity1)
            pivotGridGroup2.Hierarchy = Nothing
            pivotGridGroup2.ShowNewValues = True
            pivotGridGroup3.Caption = "Product Info"
            pivotGridGroup3.Fields.Add(Me.fieldCategoryName1)
            pivotGridGroup3.Fields.Add(Me.fieldProductName1)
            pivotGridGroup3.Hierarchy = Nothing
            pivotGridGroup3.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1, pivotGridGroup2, pivotGridGroup3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(1012, 541)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' xtraPivotGridTutorialBindingSource
            ' 
            Me.xtraPivotGridTutorialBindingSource.DataMember = "XtraPivotGridTutorialView"
            Me.xtraPivotGridTutorialBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldUnitPrice1
            ' 
            Me.fieldUnitPrice1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldUnitPrice1.AreaIndex = 0
            Me.fieldUnitPrice1.Caption = "Unit Price"
            Me.fieldUnitPrice1.FieldName = "UnitPrice"
            Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
            Me.fieldUnitPrice1.Visible = False
            ' 
            ' fieldQuantity1
            ' 
            Me.fieldQuantity1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity1.AreaIndex = 1
            Me.fieldQuantity1.Caption = "Quantity"
            Me.fieldQuantity1.FieldName = "Quantity"
            Me.fieldQuantity1.Name = "fieldQuantity1"
            ' 
            ' fieldPrice1
            ' 
            Me.fieldPrice1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPrice1.AreaIndex = 0
            Me.fieldPrice1.Caption = "Amount"
            Me.fieldPrice1.CellFormat.FormatString = "C0"
            Me.fieldPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldPrice1.FieldName = "Price"
            Me.fieldPrice1.Name = "fieldPrice1"
            ' 
            ' fieldExtendedPrice1
            ' 
            Me.fieldExtendedPrice1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.Caption = "Extended Amount"
            Me.fieldExtendedPrice1.CellFormat.FormatString = "C0"
            Me.fieldExtendedPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice1.FieldName = "ExtendedPrice"
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            Me.fieldExtendedPrice1.Visible = False
            ' 
            ' fieldFreight1
            ' 
            Me.fieldFreight1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldFreight1.AreaIndex = 0
            Me.fieldFreight1.Caption = "Freight"
            Me.fieldFreight1.CellFormat.FormatString = "C0"
            Me.fieldFreight1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldFreight1.FieldName = "Freight"
            Me.fieldFreight1.Name = "fieldFreight1"
            Me.fieldFreight1.Visible = False
            ' 
            ' fieldSalesPerson1
            ' 
            Me.fieldSalesPerson1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldSalesPerson1.AreaIndex = 0
            Me.fieldSalesPerson1.Caption = "Sales Person"
            Me.fieldSalesPerson1.FieldName = "SalesPerson"
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            Me.fieldSalesPerson1.Visible = False
            ' 
            ' fieldShipperCompany1
            ' 
            Me.fieldShipperCompany1.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldShipperCompany1.AreaIndex = 0
            Me.fieldShipperCompany1.Caption = "Shipper Company"
            Me.fieldShipperCompany1.FieldName = "ShipperCompany"
            Me.fieldShipperCompany1.Name = "fieldShipperCompany1"
            Me.fieldShipperCompany1.Visible = False
            ' 
            ' fieldOrderDate4
            ' 
            Me.fieldOrderDate4.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
            Me.fieldOrderDate4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate4.AreaIndex = 4
            Me.fieldOrderDate4.Caption = "Date"
            Me.fieldOrderDate4.FieldName = "OrderDate"
            Me.fieldOrderDate4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
            Me.fieldOrderDate4.Name = "fieldOrderDate4"
            Me.fieldOrderDate4.UnboundFieldName = "fieldOrderDate4"
            Me.fieldOrderDate4.Visible = False
            ' 
            ' xtraPivotGridTutorialViewTableAdapter
            ' 
            Me.xtraPivotGridTutorialViewTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1012, 541)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "XtraPivotGridTutorial.Step2"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xtraPivotGridTutorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As NwindDataSet.nwindDataSet
        Private xtraPivotGridTutorialViewTableAdapter As NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter
        Private xtraPivotGridTutorialBindingSource As System.Windows.Forms.BindingSource
        Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldFreight1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipCountry1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipCity1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipperCompany1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderDate2 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderDate3 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldOrderDate4 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

