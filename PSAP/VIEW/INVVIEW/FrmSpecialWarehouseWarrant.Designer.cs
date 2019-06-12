﻿namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSpecialWarehouseWarrant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet_SWW = new System.Data.DataSet();
            this.dataTableSWWHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColSpecialWarehouseWarrant = new System.Data.DataColumn();
            this.dataColWarehouseWarrantDate = new System.Data.DataColumn();
            this.dataColRepertoryNo = new System.Data.DataColumn();
            this.dataColPrepared = new System.Data.DataColumn();
            this.dataColPreparedIp = new System.Data.DataColumn();
            this.dataColumnRemark = new System.Data.DataColumn();
            this.dataColApprovalType = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColWarehouseState = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataTableSWWList = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnSpecialWarehouseWarrant = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColPrReqListRemark = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.dataColShelfId = new System.Data.DataColumn();
            this.dataColumnProjectNo = new System.Data.DataColumn();
            this.bindingSource_SWWHead = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_SWWList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlSWWList = new DevExpress.XtraGrid.GridControl();
            this.gridViewSWWList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnWarehouseReceipt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchCodeFileName = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchCodeFileNameView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colShelfId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchShelfId = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchShelfIdView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColShelfNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColShelfLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchProjectNo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repSearchProjectNoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboBoxStnNo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repbtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pnlMiddle = new DevExpress.XtraEditors.PanelControl();
            this.checkAll = new DevExpress.XtraEditors.CheckEdit();
            this.gridControlSWWHead = new DevExpress.XtraGrid.GridControl();
            this.gridViewSWWHead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colWarehouseWarrant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpReqDep = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWarehouseWarrantDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepertoryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpRepertoryNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colApprovalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpApprovalType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRemark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlMiddleTop = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.comboBoxWarehouseState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpRepertoryNo = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpApprover = new DevExpress.XtraEditors.LookUpEdit();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPrepared = new DevExpress.XtraEditors.LookUpEdit();
            this.dateSWWDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab1 = new DevExpress.XtraEditors.LabelControl();
            this.dateSWWDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.labRepertoryNo = new DevExpress.XtraEditors.LabelControl();
            this.labApprover = new DevExpress.XtraEditors.LabelControl();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.labPrepared = new DevExpress.XtraEditors.LabelControl();
            this.labWarehouseState = new DevExpress.XtraEditors.LabelControl();
            this.labSWWDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SWW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSWWList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SWWList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSWWList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSWWList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchShelfId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchShelfIdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).BeginInit();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSWWHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).BeginInit();
            this.pnlMiddleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateBegin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_SWW
            // 
            this.dataSet_SWW.DataSetName = "NewDataSet";
            this.dataSet_SWW.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableSWWHead,
            this.dataTableSWWList});
            // 
            // dataTableSWWHead
            // 
            this.dataTableSWWHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColSpecialWarehouseWarrant,
            this.dataColWarehouseWarrantDate,
            this.dataColRepertoryNo,
            this.dataColPrepared,
            this.dataColPreparedIp,
            this.dataColumnRemark,
            this.dataColApprovalType,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColWarehouseState,
            this.dataColSelect,
            this.dataColReqDep});
            this.dataTableSWWHead.TableName = "SWWHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColSpecialWarehouseWarrant
            // 
            this.dataColSpecialWarehouseWarrant.Caption = "预算外入库单号";
            this.dataColSpecialWarehouseWarrant.ColumnName = "SpecialWarehouseWarrant";
            // 
            // dataColWarehouseWarrantDate
            // 
            this.dataColWarehouseWarrantDate.Caption = "入库日期";
            this.dataColWarehouseWarrantDate.ColumnName = "SpecialWarehouseWarrantDate";
            this.dataColWarehouseWarrantDate.DataType = typeof(System.DateTime);
            // 
            // dataColRepertoryNo
            // 
            this.dataColRepertoryNo.Caption = "入库仓库";
            this.dataColRepertoryNo.ColumnName = "RepertoryNo";
            // 
            // dataColPrepared
            // 
            this.dataColPrepared.Caption = "制单人";
            this.dataColPrepared.ColumnName = "Prepared";
            // 
            // dataColPreparedIp
            // 
            this.dataColPreparedIp.Caption = "制单人IP";
            this.dataColPreparedIp.ColumnName = "PreparedIp";
            // 
            // dataColumnRemark
            // 
            this.dataColumnRemark.Caption = "备注";
            this.dataColumnRemark.ColumnName = "Remark";
            // 
            // dataColApprovalType
            // 
            this.dataColApprovalType.Caption = "审核类型";
            this.dataColApprovalType.ColumnName = "ApprovalType";
            // 
            // dataColModifier
            // 
            this.dataColModifier.Caption = "修改人";
            this.dataColModifier.ColumnName = "Modifier";
            // 
            // dataColModifierIp
            // 
            this.dataColModifierIp.Caption = "修改人IP";
            this.dataColModifierIp.ColumnName = "ModifierIp";
            // 
            // dataColModifierTime
            // 
            this.dataColModifierTime.Caption = "修改时间";
            this.dataColModifierTime.ColumnName = "ModifierTime";
            this.dataColModifierTime.DataType = typeof(System.DateTime);
            // 
            // dataColWarehouseState
            // 
            this.dataColWarehouseState.Caption = "状态";
            this.dataColWarehouseState.ColumnName = "WarehouseState";
            this.dataColWarehouseState.DataType = typeof(int);
            // 
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "入库部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // dataTableSWWList
            // 
            this.dataTableSWWList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnSpecialWarehouseWarrant,
            this.dataColCodeFileName,
            this.dataColQty,
            this.dataColProjectNo,
            this.dataColStnNo,
            this.dataColPrReqListRemark,
            this.dataColCodeName,
            this.dataColShelfId,
            this.dataColumnProjectNo});
            this.dataTableSWWList.TableName = "SWWList";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            // 
            // dataColumnSpecialWarehouseWarrant
            // 
            this.dataColumnSpecialWarehouseWarrant.Caption = "预算外入库单号";
            this.dataColumnSpecialWarehouseWarrant.ColumnName = "SpecialWarehouseWarrant";
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "零件编号";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "入库数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(double);
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectName";
            // 
            // dataColStnNo
            // 
            this.dataColStnNo.Caption = "站号";
            this.dataColStnNo.ColumnName = "StnNo";
            // 
            // dataColPrReqListRemark
            // 
            this.dataColPrReqListRemark.Caption = "备注";
            this.dataColPrReqListRemark.ColumnName = "Remark";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // dataColShelfId
            // 
            this.dataColShelfId.Caption = "货架号";
            this.dataColShelfId.ColumnName = "ShelfId";
            this.dataColShelfId.DataType = typeof(int);
            // 
            // dataColumnProjectNo
            // 
            this.dataColumnProjectNo.Caption = "项目编号";
            this.dataColumnProjectNo.ColumnName = "ProjectNo";
            // 
            // bindingSource_SWWHead
            // 
            this.bindingSource_SWWHead.DataMember = "SWWHead";
            this.bindingSource_SWWHead.DataSource = this.dataSet_SWW;
            // 
            // bindingSource_SWWList
            // 
            this.bindingSource_SWWList.DataMember = "SWWList";
            this.bindingSource_SWWList.DataSource = this.dataSet_SWW;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Controls.Add(this.splitterControl1);
            this.pnlRight.Controls.Add(this.pnlMiddle);
            this.pnlRight.Controls.Add(this.pnltop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1264, 681);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnListAdd);
            this.pnlBottom.Controls.Add(this.gridControlSWWList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 322);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1264, 359);
            this.pnlBottom.TabIndex = 9;
            // 
            // btnListAdd
            // 
            this.btnListAdd.Enabled = false;
            this.btnListAdd.Location = new System.Drawing.Point(2, 2);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(40, 21);
            this.btnListAdd.TabIndex = 27;
            this.btnListAdd.Text = "+";
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // gridControlSWWList
            // 
            this.gridControlSWWList.AllowDrop = true;
            this.gridControlSWWList.DataSource = this.bindingSource_SWWList;
            this.gridControlSWWList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSWWList.Location = new System.Drawing.Point(2, 2);
            this.gridControlSWWList.MainView = this.gridViewSWWList;
            this.gridControlSWWList.Name = "gridControlSWWList";
            this.gridControlSWWList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSpinQty,
            this.repSearchCodeFileName,
            this.repbtnDelete,
            this.repSearchShelfId,
            this.repComboBoxStnNo,
            this.repSearchProjectNo});
            this.gridControlSWWList.Size = new System.Drawing.Size(1260, 355);
            this.gridControlSWWList.TabIndex = 28;
            this.gridControlSWWList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSWWList});
            // 
            // gridViewSWWList
            // 
            this.gridViewSWWList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId1,
            this.columnWarehouseReceipt,
            this.colCodeFileName,
            this.colCodeName,
            this.colQty,
            this.colShelfId,
            this.colRemark,
            this.colProjectName,
            this.colStnNo,
            this.colDelete,
            this.colProjectNo});
            this.gridViewSWWList.GridControl = this.gridControlSWWList;
            this.gridViewSWWList.IndicatorWidth = 40;
            this.gridViewSWWList.Name = "gridViewSWWList";
            this.gridViewSWWList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSWWList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSWWList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSWWList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSWWList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSWWList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSWWList.OptionsView.ColumnAutoWidth = false;
            this.gridViewSWWList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSWWList.OptionsView.ShowFooter = true;
            this.gridViewSWWList.OptionsView.ShowGroupPanel = false;
            this.gridViewSWWList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSWWHead_CustomDrawRowIndicator);
            this.gridViewSWWList.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewSWWList_InitNewRow);
            this.gridViewSWWList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSWWList_FocusedRowChanged);
            this.gridViewSWWList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSWWList_CellValueChanged);
            this.gridViewSWWList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSWWList_KeyDown);
            // 
            // colAutoId1
            // 
            this.colAutoId1.FieldName = "AutoId";
            this.colAutoId1.Name = "colAutoId1";
            // 
            // columnWarehouseReceipt
            // 
            this.columnWarehouseReceipt.AppearanceHeader.Options.UseTextOptions = true;
            this.columnWarehouseReceipt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnWarehouseReceipt.FieldName = "SpecialWarehouseWarrant";
            this.columnWarehouseReceipt.Name = "columnWarehouseReceipt";
            this.columnWarehouseReceipt.OptionsColumn.AllowEdit = false;
            this.columnWarehouseReceipt.OptionsColumn.TabStop = false;
            this.columnWarehouseReceipt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.columnWarehouseReceipt.Visible = true;
            this.columnWarehouseReceipt.VisibleIndex = 0;
            this.columnWarehouseReceipt.Width = 110;
            // 
            // colCodeFileName
            // 
            this.colCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeFileName.ColumnEdit = this.repSearchCodeFileName;
            this.colCodeFileName.FieldName = "CodeFileName";
            this.colCodeFileName.Name = "colCodeFileName";
            this.colCodeFileName.OptionsColumn.AllowEdit = false;
            this.colCodeFileName.Visible = true;
            this.colCodeFileName.VisibleIndex = 1;
            this.colCodeFileName.Width = 110;
            // 
            // repSearchCodeFileName
            // 
            this.repSearchCodeFileName.AutoHeight = false;
            this.repSearchCodeFileName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchCodeFileName.DisplayMember = "CodeFileName";
            this.repSearchCodeFileName.Name = "repSearchCodeFileName";
            this.repSearchCodeFileName.NullText = "";
            this.repSearchCodeFileName.ValueMember = "CodeFileName";
            this.repSearchCodeFileName.View = this.repSearchCodeFileNameView;
            // 
            // repSearchCodeFileNameView
            // 
            this.repSearchCodeFileNameView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumnCodeFileName,
            this.gridColumnCodeName});
            this.repSearchCodeFileNameView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchCodeFileNameView.IndicatorWidth = 60;
            this.repSearchCodeFileNameView.Name = "repSearchCodeFileNameView";
            this.repSearchCodeFileNameView.OptionsBehavior.Editable = false;
            this.repSearchCodeFileNameView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchCodeFileNameView.OptionsView.ShowGroupPanel = false;
            this.repSearchCodeFileNameView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AutoId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumnCodeFileName
            // 
            this.gridColumnCodeFileName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeFileName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeFileName.Caption = "零件编号";
            this.gridColumnCodeFileName.FieldName = "CodeFileName";
            this.gridColumnCodeFileName.Name = "gridColumnCodeFileName";
            this.gridColumnCodeFileName.Visible = true;
            this.gridColumnCodeFileName.VisibleIndex = 0;
            this.gridColumnCodeFileName.Width = 130;
            // 
            // gridColumnCodeName
            // 
            this.gridColumnCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodeName.Caption = "零件名称";
            this.gridColumnCodeName.FieldName = "CodeName";
            this.gridColumnCodeName.Name = "gridColumnCodeName";
            this.gridColumnCodeName.Visible = true;
            this.gridColumnCodeName.VisibleIndex = 1;
            this.gridColumnCodeName.Width = 130;
            // 
            // colCodeName
            // 
            this.colCodeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodeName.FieldName = "CodeName";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.OptionsColumn.AllowEdit = false;
            this.colCodeName.OptionsColumn.TabStop = false;
            this.colCodeName.Visible = true;
            this.colCodeName.VisibleIndex = 2;
            this.colCodeName.Width = 110;
            // 
            // colQty
            // 
            this.colQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQty.ColumnEdit = this.repSpinQty;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0:0.##}")});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 4;
            this.colQty.Width = 80;
            // 
            // repSpinQty
            // 
            this.repSpinQty.AutoHeight = false;
            this.repSpinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinQty.DisplayFormat.FormatString = "d";
            this.repSpinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.EditFormat.FormatString = "d";
            this.repSpinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repSpinQty.MaxValue = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.repSpinQty.Name = "repSpinQty";
            // 
            // colShelfId
            // 
            this.colShelfId.AppearanceHeader.Options.UseTextOptions = true;
            this.colShelfId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShelfId.ColumnEdit = this.repSearchShelfId;
            this.colShelfId.FieldName = "ShelfId";
            this.colShelfId.Name = "colShelfId";
            this.colShelfId.OptionsColumn.AllowEdit = false;
            this.colShelfId.Visible = true;
            this.colShelfId.VisibleIndex = 3;
            this.colShelfId.Width = 100;
            // 
            // repSearchShelfId
            // 
            this.repSearchShelfId.AutoHeight = false;
            this.repSearchShelfId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchShelfId.DisplayMember = "ShelfNo";
            this.repSearchShelfId.Name = "repSearchShelfId";
            this.repSearchShelfId.NullText = "";
            this.repSearchShelfId.ValueMember = "AutoId";
            this.repSearchShelfId.View = this.repSearchShelfIdView;
            // 
            // repSearchShelfIdView
            // 
            this.repSearchShelfIdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColAutoId,
            this.gridColShelfNo,
            this.gridColShelfLocation});
            this.repSearchShelfIdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchShelfIdView.IndicatorWidth = 60;
            this.repSearchShelfIdView.Name = "repSearchShelfIdView";
            this.repSearchShelfIdView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchShelfIdView.OptionsView.ShowGroupPanel = false;
            this.repSearchShelfIdView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColAutoId
            // 
            this.gridColAutoId.Caption = "AutoId";
            this.gridColAutoId.FieldName = "AutoId";
            this.gridColAutoId.Name = "gridColAutoId";
            // 
            // gridColShelfNo
            // 
            this.gridColShelfNo.Caption = "货架编号";
            this.gridColShelfNo.FieldName = "ShelfNo";
            this.gridColShelfNo.Name = "gridColShelfNo";
            this.gridColShelfNo.Visible = true;
            this.gridColShelfNo.VisibleIndex = 0;
            // 
            // gridColShelfLocation
            // 
            this.gridColShelfLocation.Caption = "货架位置";
            this.gridColShelfLocation.FieldName = "ShelfLocation";
            this.gridColShelfLocation.Name = "gridColShelfLocation";
            this.gridColShelfLocation.Visible = true;
            this.gridColShelfLocation.VisibleIndex = 1;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.AllowEdit = false;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            this.colRemark.Width = 120;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProjectName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProjectName.ColumnEdit = this.repSearchProjectNo;
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 5;
            this.colProjectName.Width = 120;
            // 
            // repSearchProjectNo
            // 
            this.repSearchProjectNo.AutoHeight = false;
            this.repSearchProjectNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchProjectNo.DisplayMember = "ProjectName";
            this.repSearchProjectNo.Name = "repSearchProjectNo";
            this.repSearchProjectNo.NullText = "";
            this.repSearchProjectNo.ValueMember = "ProjectName";
            this.repSearchProjectNo.View = this.repSearchProjectNoView;
            // 
            // repSearchProjectNoView
            // 
            this.repSearchProjectNoView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProjectNo,
            this.gridColumnProjectName});
            this.repSearchProjectNoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repSearchProjectNoView.IndicatorWidth = 60;
            this.repSearchProjectNoView.Name = "repSearchProjectNoView";
            this.repSearchProjectNoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repSearchProjectNoView.OptionsView.ShowGroupPanel = false;
            this.repSearchProjectNoView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.repSearchCodeFileNameView_CustomDrawRowIndicator);
            // 
            // gridColumnProjectNo
            // 
            this.gridColumnProjectNo.Caption = "项目号";
            this.gridColumnProjectNo.FieldName = "ProjectNo";
            this.gridColumnProjectNo.Name = "gridColumnProjectNo";
            this.gridColumnProjectNo.Visible = true;
            this.gridColumnProjectNo.VisibleIndex = 0;
            // 
            // gridColumnProjectName
            // 
            this.gridColumnProjectName.Caption = "项目名称";
            this.gridColumnProjectName.FieldName = "ProjectName";
            this.gridColumnProjectName.Name = "gridColumnProjectName";
            this.gridColumnProjectName.Visible = true;
            this.gridColumnProjectName.VisibleIndex = 1;
            // 
            // colStnNo
            // 
            this.colStnNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colStnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStnNo.ColumnEdit = this.repComboBoxStnNo;
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.OptionsColumn.AllowEdit = false;
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 6;
            this.colStnNo.Width = 100;
            // 
            // repComboBoxStnNo
            // 
            this.repComboBoxStnNo.AutoHeight = false;
            this.repComboBoxStnNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboBoxStnNo.DropDownRows = 10;
            this.repComboBoxStnNo.ImmediatePopup = true;
            this.repComboBoxStnNo.Name = "repComboBoxStnNo";
            // 
            // colDelete
            // 
            this.colDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.ColumnEdit = this.repbtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 8;
            this.colDelete.Width = 27;
            // 
            // repbtnDelete
            // 
            this.repbtnDelete.AutoHeight = false;
            this.repbtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repbtnDelete.Name = "repbtnDelete";
            this.repbtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repbtnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repbtnDelete_ButtonClick);
            // 
            // colProjectNo
            // 
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 317);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1264, 5);
            this.splitterControl1.TabIndex = 8;
            this.splitterControl1.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.checkAll);
            this.pnlMiddle.Controls.Add(this.gridControlSWWHead);
            this.pnlMiddle.Controls.Add(this.pnlMiddleTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 78);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1264, 239);
            this.pnlMiddle.TabIndex = 2;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(53, 38);
            this.checkAll.Margin = new System.Windows.Forms.Padding(4);
            this.checkAll.Name = "checkAll";
            this.checkAll.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAll.Properties.Appearance.Options.UseBackColor = true;
            this.checkAll.Properties.Caption = "";
            this.checkAll.Size = new System.Drawing.Size(25, 19);
            this.checkAll.TabIndex = 20;
            this.checkAll.TabStop = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // gridControlSWWHead
            // 
            this.gridControlSWWHead.DataSource = this.bindingSource_SWWHead;
            this.gridControlSWWHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSWWHead.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSWWHead.Location = new System.Drawing.Point(2, 36);
            this.gridControlSWWHead.MainView = this.gridViewSWWHead;
            this.gridControlSWWHead.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSWWHead.Name = "gridControlSWWHead";
            this.gridControlSWWHead.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpRepertoryNo,
            this.repCheckSelect,
            this.repLookUpApprovalType,
            this.repLookUpReqDep});
            this.gridControlSWWHead.Size = new System.Drawing.Size(1260, 201);
            this.gridControlSWWHead.TabIndex = 5;
            this.gridControlSWWHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSWWHead});
            // 
            // gridViewSWWHead
            // 
            this.gridViewSWWHead.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colSelect,
            this.colWarehouseWarrant,
            this.colWarehouseState,
            this.colReqDep,
            this.colWarehouseWarrantDate,
            this.colRepertoryNo,
            this.colApprovalType,
            this.colRemark1,
            this.colPrepared,
            this.colModifier});
            this.gridViewSWWHead.GridControl = this.gridControlSWWHead;
            this.gridViewSWWHead.IndicatorWidth = 40;
            this.gridViewSWWHead.Name = "gridViewSWWHead";
            this.gridViewSWWHead.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSWWHead.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSWWHead.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSWWHead.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSWWHead.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSWWHead.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSWWHead.OptionsView.ColumnAutoWidth = false;
            this.gridViewSWWHead.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSWWHead.OptionsView.ShowFooter = true;
            this.gridViewSWWHead.OptionsView.ShowGroupPanel = false;
            this.gridViewSWWHead.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewSWWHead_CustomDrawRowIndicator);
            this.gridViewSWWHead.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewSWWHead_InitNewRow);
            this.gridViewSWWHead.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSWWHead_FocusedRowChanged);
            this.gridViewSWWHead.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewSWWHead_CustomColumnDisplayText);
            this.gridViewSWWHead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSWWHead_KeyDown);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colSelect
            // 
            this.colSelect.ColumnEdit = this.repCheckSelect;
            this.colSelect.FieldName = "Select";
            this.colSelect.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            this.colSelect.Width = 35;
            // 
            // repCheckSelect
            // 
            this.repCheckSelect.AutoHeight = false;
            this.repCheckSelect.Name = "repCheckSelect";
            this.repCheckSelect.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repCheckSelect.ValueGrayed = false;
            this.repCheckSelect.EditValueChanged += new System.EventHandler(this.repCheckSelect_EditValueChanged);
            // 
            // colWarehouseWarrant
            // 
            this.colWarehouseWarrant.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrant.FieldName = "SpecialWarehouseWarrant";
            this.colWarehouseWarrant.Name = "colWarehouseWarrant";
            this.colWarehouseWarrant.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrant.OptionsColumn.TabStop = false;
            this.colWarehouseWarrant.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "WarehouseWarrant", "共计{0}条")});
            this.colWarehouseWarrant.Visible = true;
            this.colWarehouseWarrant.VisibleIndex = 1;
            this.colWarehouseWarrant.Width = 110;
            // 
            // colWarehouseState
            // 
            this.colWarehouseState.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseState.FieldName = "WarehouseState";
            this.colWarehouseState.Name = "colWarehouseState";
            this.colWarehouseState.OptionsColumn.AllowEdit = false;
            this.colWarehouseState.OptionsColumn.TabStop = false;
            this.colWarehouseState.Visible = true;
            this.colWarehouseState.VisibleIndex = 2;
            this.colWarehouseState.Width = 60;
            // 
            // colReqDep
            // 
            this.colReqDep.AppearanceHeader.Options.UseTextOptions = true;
            this.colReqDep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReqDep.ColumnEdit = this.repLookUpReqDep;
            this.colReqDep.FieldName = "ReqDep";
            this.colReqDep.Name = "colReqDep";
            this.colReqDep.OptionsColumn.AllowEdit = false;
            this.colReqDep.OptionsColumn.TabStop = false;
            this.colReqDep.Visible = true;
            this.colReqDep.VisibleIndex = 7;
            this.colReqDep.Width = 110;
            // 
            // repLookUpReqDep
            // 
            this.repLookUpReqDep.AutoHeight = false;
            this.repLookUpReqDep.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpReqDep.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称")});
            this.repLookUpReqDep.DisplayMember = "DepartmentName";
            this.repLookUpReqDep.Name = "repLookUpReqDep";
            this.repLookUpReqDep.NullText = "";
            this.repLookUpReqDep.ValueMember = "DepartmentNo";
            // 
            // colWarehouseWarrantDate
            // 
            this.colWarehouseWarrantDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouseWarrantDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouseWarrantDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colWarehouseWarrantDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWarehouseWarrantDate.FieldName = "SpecialWarehouseWarrantDate";
            this.colWarehouseWarrantDate.Name = "colWarehouseWarrantDate";
            this.colWarehouseWarrantDate.OptionsColumn.AllowEdit = false;
            this.colWarehouseWarrantDate.OptionsColumn.TabStop = false;
            this.colWarehouseWarrantDate.Visible = true;
            this.colWarehouseWarrantDate.VisibleIndex = 3;
            this.colWarehouseWarrantDate.Width = 90;
            // 
            // colRepertoryNo
            // 
            this.colRepertoryNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRepertoryNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRepertoryNo.ColumnEdit = this.repLookUpRepertoryNo;
            this.colRepertoryNo.FieldName = "RepertoryNo";
            this.colRepertoryNo.Name = "colRepertoryNo";
            this.colRepertoryNo.OptionsColumn.AllowEdit = false;
            this.colRepertoryNo.Visible = true;
            this.colRepertoryNo.VisibleIndex = 4;
            this.colRepertoryNo.Width = 100;
            // 
            // repLookUpRepertoryNo
            // 
            this.repLookUpRepertoryNo.AutoHeight = false;
            this.repLookUpRepertoryNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpRepertoryNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.repLookUpRepertoryNo.DisplayMember = "RepertoryName";
            this.repLookUpRepertoryNo.Name = "repLookUpRepertoryNo";
            this.repLookUpRepertoryNo.NullText = "";
            this.repLookUpRepertoryNo.ValueMember = "RepertoryNo";
            // 
            // colApprovalType
            // 
            this.colApprovalType.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprovalType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprovalType.ColumnEdit = this.repLookUpApprovalType;
            this.colApprovalType.FieldName = "ApprovalType";
            this.colApprovalType.Name = "colApprovalType";
            this.colApprovalType.OptionsColumn.AllowEdit = false;
            this.colApprovalType.Visible = true;
            this.colApprovalType.VisibleIndex = 5;
            this.colApprovalType.Width = 100;
            // 
            // repLookUpApprovalType
            // 
            this.repLookUpApprovalType.AutoHeight = false;
            this.repLookUpApprovalType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpApprovalType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNo", "审批类型"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeNoText", "审批名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ApprovalText", "审批方式")});
            this.repLookUpApprovalType.DisplayMember = "TypeNoText";
            this.repLookUpApprovalType.Name = "repLookUpApprovalType";
            this.repLookUpApprovalType.NullText = "";
            this.repLookUpApprovalType.ValueMember = "TypeNo";
            // 
            // colRemark1
            // 
            this.colRemark1.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark1.FieldName = "Remark";
            this.colRemark1.Name = "colRemark1";
            this.colRemark1.OptionsColumn.AllowEdit = false;
            this.colRemark1.Visible = true;
            this.colRemark1.VisibleIndex = 6;
            this.colRemark1.Width = 100;
            // 
            // colPrepared
            // 
            this.colPrepared.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrepared.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrepared.FieldName = "Prepared";
            this.colPrepared.Name = "colPrepared";
            this.colPrepared.OptionsColumn.AllowEdit = false;
            this.colPrepared.OptionsColumn.TabStop = false;
            this.colPrepared.Visible = true;
            this.colPrepared.VisibleIndex = 8;
            this.colPrepared.Width = 70;
            // 
            // colModifier
            // 
            this.colModifier.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.OptionsColumn.AllowEdit = false;
            this.colModifier.OptionsColumn.TabStop = false;
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 9;
            this.colModifier.Width = 70;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.Controls.Add(this.btnNew);
            this.pnlMiddleTop.Controls.Add(this.btnPreview);
            this.pnlMiddleTop.Controls.Add(this.btnCancelApprove);
            this.pnlMiddleTop.Controls.Add(this.btnApprove);
            this.pnlMiddleTop.Controls.Add(this.btnDelete);
            this.pnlMiddleTop.Controls.Add(this.btnCancel);
            this.pnlMiddleTop.Controls.Add(this.btnSave);
            this.pnlMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleTop.Location = new System.Drawing.Point(2, 2);
            this.pnlMiddleTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(1260, 34);
            this.pnlMiddleTop.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "新增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(491, 5);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.TabStop = false;
            this.btnPreview.Text = "预览";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancelApprove
            // 
            this.btnCancelApprove.Location = new System.Drawing.Point(410, 5);
            this.btnCancelApprove.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelApprove.Name = "btnCancelApprove";
            this.btnCancelApprove.Size = new System.Drawing.Size(75, 23);
            this.btnCancelApprove.TabIndex = 23;
            this.btnCancelApprove.TabStop = false;
            this.btnCancelApprove.Text = "取消审批";
            this.btnCancelApprove.Click += new System.EventHandler(this.btnCancelApprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(329, 5);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 22;
            this.btnApprove.TabStop = false;
            this.btnApprove.Text = "审批";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(167, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "修改";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.comboBoxWarehouseState);
            this.pnltop.Controls.Add(this.lookUpRepertoryNo);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.lookUpApprover);
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.lookUpPrepared);
            this.pnltop.Controls.Add(this.dateSWWDateEnd);
            this.pnltop.Controls.Add(this.lab1);
            this.pnltop.Controls.Add(this.dateSWWDateBegin);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.labRepertoryNo);
            this.pnltop.Controls.Add(this.labApprover);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.labPrepared);
            this.pnltop.Controls.Add(this.labWarehouseState);
            this.pnltop.Controls.Add(this.labSWWDate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1264, 78);
            this.pnltop.TabIndex = 1;
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(630, 14);
            this.lookUpReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpReqDep.Name = "lookUpReqDep";
            this.lookUpReqDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpReqDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpReqDep.Properties.DisplayMember = "DepartmentName";
            this.lookUpReqDep.Properties.NullText = "";
            this.lookUpReqDep.Properties.ValueMember = "DepartmentNo";
            this.lookUpReqDep.Size = new System.Drawing.Size(120, 20);
            this.lookUpReqDep.TabIndex = 3;
            // 
            // comboBoxWarehouseState
            // 
            this.comboBoxWarehouseState.EnterMoveNextControl = true;
            this.comboBoxWarehouseState.Location = new System.Drawing.Point(836, 14);
            this.comboBoxWarehouseState.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWarehouseState.Name = "comboBoxWarehouseState";
            this.comboBoxWarehouseState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxWarehouseState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审批",
            "审批",
            "审批中"});
            this.comboBoxWarehouseState.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxWarehouseState.Size = new System.Drawing.Size(120, 20);
            this.comboBoxWarehouseState.TabIndex = 4;
            // 
            // lookUpRepertoryNo
            // 
            this.lookUpRepertoryNo.EnterMoveNextControl = true;
            this.lookUpRepertoryNo.Location = new System.Drawing.Point(424, 14);
            this.lookUpRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpRepertoryNo.Name = "lookUpRepertoryNo";
            this.lookUpRepertoryNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRepertoryNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryNo", "仓库编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryName", "仓库名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepertoryTypeText", "仓库类型")});
            this.lookUpRepertoryNo.Properties.DisplayMember = "RepertoryName";
            this.lookUpRepertoryNo.Properties.NullText = "";
            this.lookUpRepertoryNo.Properties.ValueMember = "RepertoryNo";
            this.lookUpRepertoryNo.Size = new System.Drawing.Size(120, 20);
            this.lookUpRepertoryNo.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(629, 43);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lookUpApprover
            // 
            this.lookUpApprover.EnterMoveNextControl = true;
            this.lookUpApprover.Location = new System.Drawing.Point(264, 44);
            this.lookUpApprover.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpApprover.Name = "lookUpApprover";
            this.lookUpApprover.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpApprover.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApprover.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpApprover.Properties.DisplayMember = "EmpName";
            this.lookUpApprover.Properties.NullText = "";
            this.lookUpApprover.Properties.ValueMember = "AutoId";
            this.lookUpApprover.Size = new System.Drawing.Size(100, 20);
            this.lookUpApprover.TabIndex = 6;
            this.lookUpApprover.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpApprover_KeyDown);
            // 
            // textCommon
            // 
            this.textCommon.EnterMoveNextControl = true;
            this.textCommon.Location = new System.Drawing.Point(454, 44);
            this.textCommon.Margin = new System.Windows.Forms.Padding(4);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 7;
            // 
            // lookUpPrepared
            // 
            this.lookUpPrepared.EnterMoveNextControl = true;
            this.lookUpPrepared.Location = new System.Drawing.Point(74, 44);
            this.lookUpPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpPrepared.Name = "lookUpPrepared";
            this.lookUpPrepared.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPrepared.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPrepared.Properties.DisplayMember = "EmpName";
            this.lookUpPrepared.Properties.NullText = "";
            this.lookUpPrepared.Properties.ValueMember = "EmpName";
            this.lookUpPrepared.Size = new System.Drawing.Size(120, 20);
            this.lookUpPrepared.TabIndex = 5;
            // 
            // dateSWWDateEnd
            // 
            this.dateSWWDateEnd.EditValue = null;
            this.dateSWWDateEnd.EnterMoveNextControl = true;
            this.dateSWWDateEnd.Location = new System.Drawing.Point(238, 14);
            this.dateSWWDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateSWWDateEnd.Name = "dateSWWDateEnd";
            this.dateSWWDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSWWDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSWWDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSWWDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSWWDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSWWDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSWWDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSWWDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateSWWDateEnd.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.Location = new System.Drawing.Point(228, 17);
            this.lab1.Margin = new System.Windows.Forms.Padding(4);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(4, 14);
            this.lab1.TabIndex = 6;
            this.lab1.Text = "-";
            // 
            // dateSWWDateBegin
            // 
            this.dateSWWDateBegin.EditValue = null;
            this.dateSWWDateBegin.EnterMoveNextControl = true;
            this.dateSWWDateBegin.Location = new System.Drawing.Point(122, 14);
            this.dateSWWDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dateSWWDateBegin.Name = "dateSWWDateBegin";
            this.dateSWWDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSWWDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSWWDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSWWDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSWWDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSWWDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSWWDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSWWDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateSWWDateBegin.TabIndex = 0;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(564, 17);
            this.labReqDep.Margin = new System.Windows.Forms.Padding(4);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 32;
            this.labReqDep.Text = "入库部门：";
            // 
            // labRepertoryNo
            // 
            this.labRepertoryNo.Location = new System.Drawing.Point(358, 17);
            this.labRepertoryNo.Margin = new System.Windows.Forms.Padding(4);
            this.labRepertoryNo.Name = "labRepertoryNo";
            this.labRepertoryNo.Size = new System.Drawing.Size(60, 14);
            this.labRepertoryNo.TabIndex = 26;
            this.labRepertoryNo.Text = "入库仓库：";
            // 
            // labApprover
            // 
            this.labApprover.Location = new System.Drawing.Point(212, 47);
            this.labApprover.Margin = new System.Windows.Forms.Padding(4);
            this.labApprover.Name = "labApprover";
            this.labApprover.Size = new System.Drawing.Size(48, 14);
            this.labApprover.TabIndex = 24;
            this.labApprover.Text = "审批人：";
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(386, 47);
            this.labCommon.Margin = new System.Windows.Forms.Padding(4);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 22;
            this.labCommon.Text = "通用查询：";
            // 
            // labPrepared
            // 
            this.labPrepared.Location = new System.Drawing.Point(20, 47);
            this.labPrepared.Margin = new System.Windows.Forms.Padding(4);
            this.labPrepared.Name = "labPrepared";
            this.labPrepared.Size = new System.Drawing.Size(48, 14);
            this.labPrepared.TabIndex = 20;
            this.labPrepared.Text = "制单人：";
            // 
            // labWarehouseState
            // 
            this.labWarehouseState.Location = new System.Drawing.Point(770, 17);
            this.labWarehouseState.Margin = new System.Windows.Forms.Padding(4);
            this.labWarehouseState.Name = "labWarehouseState";
            this.labWarehouseState.Size = new System.Drawing.Size(60, 14);
            this.labWarehouseState.TabIndex = 30;
            this.labWarehouseState.Text = "单据状态：";
            // 
            // labSWWDate
            // 
            this.labSWWDate.Location = new System.Drawing.Point(20, 17);
            this.labSWWDate.Margin = new System.Windows.Forms.Padding(4);
            this.labSWWDate.Name = "labSWWDate";
            this.labSWWDate.Size = new System.Drawing.Size(96, 14);
            this.labSWWDate.TabIndex = 5;
            this.labSWWDate.Text = "预算外入库日期：";
            // 
            // FrmSpecialWarehouseWarrant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlRight);
            this.Name = "FrmSpecialWarehouseWarrant";
            this.TabText = "预算外入库单";
            this.Text = "预算外入库单";
            this.Activated += new System.EventHandler(this.FrmSpecialWarehouseWarrant_Activated);
            this.Load += new System.EventHandler(this.FrmSpecialWarehouseWarrant_Load);
            this.Shown += new System.EventHandler(this.FrmSpecialWarehouseWarrant_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SWW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSWWList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_SWWList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSWWList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSWWList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchCodeFileNameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchShelfId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchShelfIdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchProjectNoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxStnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddle)).EndInit();
            this.pnlMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSWWHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpReqDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpRepertoryNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpApprovalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMiddleTop)).EndInit();
            this.pnlMiddleTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxWarehouseState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRepertoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApprover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPrepared.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSWWDateBegin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet_SWW;
        private System.Data.DataTable dataTableSWWHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColSpecialWarehouseWarrant;
        private System.Data.DataColumn dataColWarehouseWarrantDate;
        private System.Data.DataColumn dataColRepertoryNo;
        private System.Data.DataColumn dataColPrepared;
        private System.Data.DataColumn dataColPreparedIp;
        private System.Data.DataColumn dataColumnRemark;
        private System.Data.DataColumn dataColApprovalType;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColWarehouseState;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataTable dataTableSWWList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnSpecialWarehouseWarrant;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColPrReqListRemark;
        private System.Data.DataColumn dataColCodeName;
        private System.Data.DataColumn dataColShelfId;
        private System.Windows.Forms.BindingSource bindingSource_SWWHead;
        private System.Windows.Forms.BindingSource bindingSource_SWWList;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxWarehouseState;
        private DevExpress.XtraEditors.LookUpEdit lookUpRepertoryNo;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LookUpEdit lookUpApprover;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LookUpEdit lookUpPrepared;
        private DevExpress.XtraEditors.DateEdit dateSWWDateEnd;
        private DevExpress.XtraEditors.LabelControl lab1;
        private DevExpress.XtraEditors.DateEdit dateSWWDateBegin;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.LabelControl labRepertoryNo;
        private DevExpress.XtraEditors.LabelControl labApprover;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.LabelControl labPrepared;
        private DevExpress.XtraEditors.LabelControl labWarehouseState;
        private DevExpress.XtraEditors.LabelControl labSWWDate;
        private DevExpress.XtraEditors.PanelControl pnlMiddle;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.PanelControl pnlMiddleTop;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnCancelApprove;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControlSWWHead;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSWWHead;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrant;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseState;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseWarrantDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRepertoryNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpRepertoryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpApprovalType;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrepared;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraEditors.CheckEdit checkAll;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnListAdd;
        private System.Data.DataColumn dataColumnProjectNo;
        private DevExpress.XtraGrid.GridControl gridControlSWWList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSWWList;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId1;
        private DevExpress.XtraGrid.Columns.GridColumn columnWarehouseReceipt;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchCodeFileName;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchCodeFileNameView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeFileName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinQty;
        private DevExpress.XtraGrid.Columns.GridColumn colShelfId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchShelfId;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchShelfIdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColShelfNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColShelfLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchProjectNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repSearchProjectNoView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboBoxStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repbtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
    }
}