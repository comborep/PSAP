﻿namespace PSAP.VIEW.BSVIEW
{
    partial class FrmApprovalList
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
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlApprovalList = new DevExpress.XtraGrid.GridControl();
            this.bSApprovalList = new System.Windows.Forms.BindingSource(this.components);
            this.dSApprovalList = new System.Data.DataSet();
            this.TableApprovalList = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColTypeNo = new System.Data.DataColumn();
            this.dataColApprover = new System.Data.DataColumn();
            this.dataColAppSequence = new System.Data.DataColumn();
            this.gridViewApprovalList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpTypeNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpApprover = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAppSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSplx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDxxsz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplxbxxz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSprbnwkqcxcz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBnszxmdsprqcxcz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSyspxxsjcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXyspxxsjcw = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            this.pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlApprovalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSApprovalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSApprovalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableApprovalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpTypeNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpApprover)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.btnUp);
            this.pnlToolBar.Controls.Add(this.btnDown);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(664, 40);
            this.pnlToolBar.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(496, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.TabStop = false;
            this.btnUp.Text = "上移";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(578, 9);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 1;
            this.btnDown.TabStop = false;
            this.btnDown.Text = "下移";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlApprovalList);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(664, 322);
            this.pnlGrid.TabIndex = 10;
            // 
            // gridCrlApprovalList
            // 
            this.gridCrlApprovalList.DataSource = this.bSApprovalList;
            this.gridCrlApprovalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlApprovalList.Location = new System.Drawing.Point(2, 2);
            this.gridCrlApprovalList.MainView = this.gridViewApprovalList;
            this.gridCrlApprovalList.Name = "gridCrlApprovalList";
            this.gridCrlApprovalList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpTypeNo,
            this.repItemLookUpApprover});
            this.gridCrlApprovalList.Size = new System.Drawing.Size(660, 318);
            this.gridCrlApprovalList.TabIndex = 8;
            this.gridCrlApprovalList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewApprovalList});
            // 
            // bSApprovalList
            // 
            this.bSApprovalList.DataMember = "ApprovalList";
            this.bSApprovalList.DataSource = this.dSApprovalList;
            // 
            // dSApprovalList
            // 
            this.dSApprovalList.DataSetName = "NewDataSet";
            this.dSApprovalList.Tables.AddRange(new System.Data.DataTable[] {
            this.TableApprovalList});
            // 
            // TableApprovalList
            // 
            this.TableApprovalList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColTypeNo,
            this.dataColApprover,
            this.dataColAppSequence});
            this.TableApprovalList.TableName = "ApprovalList";
            this.TableApprovalList.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableApprovalList_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColTypeNo
            // 
            this.dataColTypeNo.Caption = "审批类型编码";
            this.dataColTypeNo.ColumnName = "TypeNo";
            // 
            // dataColApprover
            // 
            this.dataColApprover.Caption = "审批人";
            this.dataColApprover.ColumnName = "Approver";
            this.dataColApprover.DataType = typeof(int);
            // 
            // dataColAppSequence
            // 
            this.dataColAppSequence.Caption = "审批顺序";
            this.dataColAppSequence.ColumnName = "AppSequence";
            this.dataColAppSequence.DataType = typeof(int);
            // 
            // gridViewApprovalList
            // 
            this.gridViewApprovalList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colTypeNo,
            this.colApprover,
            this.colAppSequence});
            this.gridViewApprovalList.GridControl = this.gridCrlApprovalList;
            this.gridViewApprovalList.IndicatorWidth = 40;
            this.gridViewApprovalList.Name = "gridViewApprovalList";
            this.gridViewApprovalList.OptionsBehavior.Editable = false;
            this.gridViewApprovalList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewApprovalList.OptionsView.ColumnAutoWidth = false;
            this.gridViewApprovalList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewApprovalList.OptionsView.ShowFooter = true;
            this.gridViewApprovalList.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colTypeNo
            // 
            this.colTypeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeNo.ColumnEdit = this.repItemLookUpTypeNo;
            this.colTypeNo.FieldName = "TypeNo";
            this.colTypeNo.Name = "colTypeNo";
            this.colTypeNo.OptionsColumn.AllowEdit = false;
            this.colTypeNo.OptionsColumn.TabStop = false;
            this.colTypeNo.Visible = true;
            this.colTypeNo.VisibleIndex = 0;
            this.colTypeNo.Width = 120;
            // 
            // repItemLookUpTypeNo
            // 
            this.repItemLookUpTypeNo.AutoHeight = false;
            this.repItemLookUpTypeNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpTypeNo.DisplayMember = "TypeNoText";
            this.repItemLookUpTypeNo.Name = "repItemLookUpTypeNo";
            this.repItemLookUpTypeNo.NullText = "";
            this.repItemLookUpTypeNo.ValueMember = "TypeNo";
            // 
            // colApprover
            // 
            this.colApprover.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colApprover.AppearanceHeader.Options.UseForeColor = true;
            this.colApprover.AppearanceHeader.Options.UseTextOptions = true;
            this.colApprover.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApprover.ColumnEdit = this.repItemLookUpApprover;
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            this.colApprover.Visible = true;
            this.colApprover.VisibleIndex = 1;
            this.colApprover.Width = 120;
            // 
            // repItemLookUpApprover
            // 
            this.repItemLookUpApprover.AutoHeight = false;
            this.repItemLookUpApprover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpApprover.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名字")});
            this.repItemLookUpApprover.DisplayMember = "EmpName";
            this.repItemLookUpApprover.Name = "repItemLookUpApprover";
            this.repItemLookUpApprover.NullText = "";
            this.repItemLookUpApprover.ValueMember = "AutoId";
            // 
            // colAppSequence
            // 
            this.colAppSequence.AppearanceHeader.Options.UseTextOptions = true;
            this.colAppSequence.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAppSequence.FieldName = "AppSequence";
            this.colAppSequence.Name = "colAppSequence";
            this.colAppSequence.OptionsColumn.AllowEdit = false;
            this.colAppSequence.OptionsColumn.TabStop = false;
            this.colAppSequence.Visible = true;
            this.colAppSequence.VisibleIndex = 2;
            this.colAppSequence.Width = 80;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSplx,
            this.tsmiDxxsz,
            this.tsmiSplxbxxz,
            this.tsmiSprbnwkqcxcz,
            this.tsmiBnszxmdsprqcxcz,
            this.tsmiSyspxxsjcw,
            this.tsmiXyspxxsjcw});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(281, 158);
            // 
            // tsmiSplx
            // 
            this.tsmiSplx.Name = "tsmiSplx";
            this.tsmiSplx.Size = new System.Drawing.Size(280, 22);
            this.tsmiSplx.Text = "审批类型";
            // 
            // tsmiDxxsz
            // 
            this.tsmiDxxsz.Name = "tsmiDxxsz";
            this.tsmiDxxsz.Size = new System.Drawing.Size(280, 22);
            this.tsmiDxxsz.Text = "的信息设置";
            // 
            // tsmiSplxbxxz
            // 
            this.tsmiSplxbxxz.Name = "tsmiSplxbxxz";
            this.tsmiSplxbxxz.Size = new System.Drawing.Size(280, 22);
            this.tsmiSplxbxxz.Text = "审批类型必须选择，请重新操作。";
            // 
            // tsmiSprbnwkqcxcz
            // 
            this.tsmiSprbnwkqcxcz.Name = "tsmiSprbnwkqcxcz";
            this.tsmiSprbnwkqcxcz.Size = new System.Drawing.Size(280, 22);
            this.tsmiSprbnwkqcxcz.Text = "审批人不能为空，请重新操作。";
            // 
            // tsmiBnszxmdsprqcxcz
            // 
            this.tsmiBnszxmdsprqcxcz.Name = "tsmiBnszxmdsprqcxcz";
            this.tsmiBnszxmdsprqcxcz.Size = new System.Drawing.Size(280, 22);
            this.tsmiBnszxmdsprqcxcz.Text = "不能设置相同的审批人，请重新操作。";
            // 
            // tsmiSyspxxsjcw
            // 
            this.tsmiSyspxxsjcw.Name = "tsmiSyspxxsjcw";
            this.tsmiSyspxxsjcw.Size = new System.Drawing.Size(280, 22);
            this.tsmiSyspxxsjcw.Text = "上移审批信息事件错误。";
            // 
            // tsmiXyspxxsjcw
            // 
            this.tsmiXyspxxsjcw.Name = "tsmiXyspxxsjcw";
            this.tsmiXyspxxsjcw.Size = new System.Drawing.Size(280, 22);
            this.tsmiXyspxxsjcw.Text = "下移审批信息事件错误。";
            // 
            // FrmApprovalList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlToolBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "FrmApprovalList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "审批信息";
            this.Text = "审批信息";
            this.Load += new System.EventHandler(this.FrmApprovalList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            this.pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlApprovalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSApprovalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSApprovalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableApprovalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpTypeNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpApprover)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlApprovalList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewApprovalList;
        private System.Windows.Forms.BindingSource bSApprovalList;
        private System.Data.DataSet dSApprovalList;
        private System.Data.DataTable TableApprovalList;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColTypeNo;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColAppSequence;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colAppSequence;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpTypeNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpApprover;
        private DevExpress.XtraEditors.SimpleButton btnUp;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        internal System.Windows.Forms.ContextMenuStrip cms;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSplx;
        internal System.Windows.Forms.ToolStripMenuItem tsmiDxxsz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSplxbxxz;
        private System.Windows.Forms.ToolStripMenuItem tsmiSprbnwkqcxcz;
        private System.Windows.Forms.ToolStripMenuItem tsmiBnszxmdsprqcxcz;
        internal System.Windows.Forms.ToolStripMenuItem tsmiSyspxxsjcw;
        internal System.Windows.Forms.ToolStripMenuItem tsmiXyspxxsjcw;
    }
}