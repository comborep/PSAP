﻿using PSAP.DAO.BSDAO;
using PSAP.DAO.SADAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmStnSummary : DockContent
    {
        #region 私有变量

        FrmStnSummaryDAO ssDAO = new FrmStnSummaryDAO();
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        /// <summary>
        /// 要查询的报价单号
        /// </summary>
        public static string queryAutoQuotationNoStr = "";

        /// <summary>
        /// 工位信息的AutoId
        /// </summary>
        public static int queryStnSummaryListAutoIdInt = 0;

        /// <summary>
        /// 工位和模块关系的AutoId
        /// </summary>
        public static int queryListModuleAutoIdInt = 0;

        /// <summary>
        /// 最后新增的ID
        /// </summary>
        private int lastNewStnListAutoId = 0;

        #endregion

        #region 构造方法

        public FrmStnSummary()
        {
            InitializeComponent();
        }

        #endregion

        #region 窗体事件

        /// <summary>
        /// 窗体加载事件 
        /// </summary>
        private void FrmStnSummary_Load(object sender, EventArgs e)
        {
            try
            {
                btnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体激活事件
        /// </summary>
        private void FrmStnSummary_Activated(object sender, EventArgs e)
        {
            try
            {
                if (queryAutoQuotationNoStr != "")
                {
                    btnEditAutoQuotationNo.Text = queryAutoQuotationNoStr;
                    queryAutoQuotationNoStr = "";
                    btnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体激活事件错误。", ex);
            }
        }

        /// <summary>
        /// 窗体显示事件
        /// </summary>
        private void FrmStnSummary_Shown(object sender, EventArgs e)
        {
            //dockPnlRight.Width = SystemInfo.DragForm_LeftDock_Width;
        }

        #endregion

        #region 左侧工位信息登记区域的事件和方法

        /// <summary>
        /// 刷新工位主表信息
        /// </summary>
        private void RefreshStnSummary(string autoQuotationNoStr, string ssNoStr)
        {
            TableStnSummary.Rows.Clear();
            ssDAO.QueryStnSummary(TableStnSummary, autoQuotationNoStr, ssNoStr);
            if (TableStnSummary.Rows.Count > 0)
            {
                btnEditAutoQuotationNo.Text = DataTypeConvert.GetString(TableStnSummary.Rows[0]["AutoQuotationNo"]);
                ssNoStr = DataTypeConvert.GetString(TableStnSummary.Rows[0]["SSNo"]);
                textPrepared.Text = DataTypeConvert.GetString(TableStnSummary.Rows[0]["Prepared"]);
                textGetTime.Text = DataTypeConvert.GetDateTime(TableStnSummary.Rows[0]["GetTime"]).ToString("yyyy-MM-dd HH:mm:ss");

                RefreshStnSummaryList(ssNoStr);
            }
            else
            {
                int count = ssDAO.QueryQuotationBaseInfoCount(autoQuotationNoStr);
                if(count >0)
                    btnEditAutoQuotationNo.Text = autoQuotationNoStr;
                else
                    btnEditAutoQuotationNo.Text = "";
                textPrepared.Text = "";
                textGetTime.Text = "";

                TableStnList.Rows.Clear();
                TableStnListModule.Rows.Clear();
            }
        }

        /// <summary>
        /// 刷新工位的明细信息
        /// </summary>
        private void RefreshStnSummaryList(string ssNoStr)
        {
            int lastAutoIdInt = 0;
            string lastSSNoStr = "";
            if (bindingSource_StnList.Current != null)
            {
                DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                lastAutoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                lastSSNoStr = DataTypeConvert.GetString(headRow["SSNo"]);

                if (lastNewStnListAutoId != 0)
                {
                    lastAutoIdInt = lastNewStnListAutoId;
                    lastNewStnListAutoId = 0;
                }
            }

            TableStnList.Rows.Clear();
            ssDAO.QueryStnSummaryList(TableStnList, ssNoStr);

            if (queryStnSummaryListAutoIdInt > 0)
            {
                for (int i = 0; i < gridViewStnList.DataRowCount; i++)
                {
                    if (DataTypeConvert.GetInt(gridViewStnList.GetDataRow(i)["AutoId"]) == queryStnSummaryListAutoIdInt)
                    {
                        gridViewStnList.FocusedRowHandle = i;
                        break;
                    }
                }
                queryStnSummaryListAutoIdInt = 0;
            }
            else if (lastSSNoStr == ssNoStr && lastAutoIdInt > 0)
            {
                for (int i = 0; i < gridViewStnList.DataRowCount; i++)
                {
                    if (DataTypeConvert.GetInt(gridViewStnList.GetDataRow(i)["AutoId"]) == lastAutoIdInt)
                    {
                        gridViewStnList.FocusedRowHandle = i;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 刷新工位和模块关系信息
        /// </summary>
        private void RefreshStnListModule(int stnListIdInt)
        {
            TableStnListModule.Rows.Clear();
            ssDAO.QueryStnListModule(TableStnListModule, stnListIdInt);
        }

        /// <summary>
        /// 显示选择报价单号和工位序号的窗体
        /// </summary>
        private void ShowSelectQuotationInfo()
        {
            FrmSelectQuotationInfo quoForm = new FrmSelectQuotationInfo();
            if (quoForm.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = quoForm.gridViewQuotation.GetFocusedDataRow();
                if (dr != null)
                {
                    string autoQuotationNoStr = DataTypeConvert.GetString(dr["AutoQuotationNo"]);
                    RefreshStnSummary(autoQuotationNoStr, "");
                }
            }
        }

        /// <summary>
        /// 选择报价单号
        /// </summary>
        private void btnEditAutoQuotationNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                ShowSelectQuotationInfo();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择报价单号错误。", ex);
            }
        }
        
        /// <summary>
        /// 报价单号手动输入后检测
        /// </summary>
        private void btnEditAutoQuotationNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if(btnEditAutoQuotationNo.Text.Trim()=="")
                {
                    string autoQuotationNoStr = "-1";
                    RefreshStnSummary(autoQuotationNoStr, "");
                }
                else
                {
                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text;
                    RefreshStnSummary(autoQuotationNoStr, "");
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--报价单号手动输入后检测错误。", ex);
            }
        }

        /// <summary>
        /// 刷新当前工位的所有信息
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditAutoQuotationNo.Text != "")
                {
                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text;
                    RefreshStnSummary(autoQuotationNoStr, "");
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新当前工位的所有信息错误。", ex);
            }
        }

        /// <summary>
        /// 刷新工位功能模块信息
        /// </summary>
        private void gridViewStnList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridViewStnList.GetFocusedDataRow() != null)
                {
                    int autoIdInt = DataTypeConvert.GetInt(gridViewStnList.GetFocusedDataRow()["AutoId"]);
                    if (autoIdInt != 0)
                        RefreshStnListModule(autoIdInt);

                    //Set_ButtonEditGrid_State(true);

                    if (queryListModuleAutoIdInt > 0)
                    {
                        for (int i = 0; i < gridViewModuleList.DataRowCount; i++)
                        {
                            if (DataTypeConvert.GetInt(gridViewModuleList.GetDataRow(i)["AutoId"]) == queryListModuleAutoIdInt)
                            {
                                gridViewModuleList.OptionsSelection.MultiSelect = false;
                                gridViewModuleList.FocusedRowHandle = i;
                                queryListModuleAutoIdInt = 0;
                                gridViewModuleList.OptionsSelection.MultiSelect = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    TableStnListModule.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新工位功能模块信息错误。", ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewStnList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewStnList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ControlHandler.GridView_GetFocusedCellDisplayText_KeyDown(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--获取单元格显示的信息错误。", ex);
            }
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        private void btnStnListNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditAutoQuotationNo.Text.Trim() == "")
                {
                    MessageHandler.ShowMessageBox("请先查询报价单号，确定要操作的报价单，再进行工位信息登记。");
                    return;
                }

                //TableStnList.Rows.Clear();
                DataRow baseRow = TableStnList.NewRow();
                TableStnList.Rows.Add(baseRow);
                bindingSource_StnList.MoveLast();

                Set_ButtonEditGrid_State(false);
                textEditStnNo.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--新增按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        private void btnStnListSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnList.Rows.Count == 0 || bindingSource_StnList.Current == null)
                    return;

                if (btnStnListSave.Text != "保存")
                {
                    Set_ButtonEditGrid_State(false);
                    textEditStnNo.Focus();
                }
                else
                {
                    bindingSource_StnList.EndEdit();
                    DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;

                    if (textEditStnNo.Text.Trim() == "")
                    {
                        MessageHandler.ShowMessageBox("站号不能为空，请重新操作。");
                        textEditStnNo.Focus();
                        return;
                    }

                    string autoQuotationNoStr = btnEditAutoQuotationNo.Text;
                    int ret = ssDAO.SaveStnSummaryList(autoQuotationNoStr, headRow, ref lastNewStnListAutoId);
                    switch (ret)
                    {
                        case -1:

                            break;
                        case 1:

                            break;
                        case 0:
                            return;
                    }

                    btnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--保存按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void btnStnListCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_StnList.Current != null)
                {
                    bindingSource_StnList.CancelEdit();
                    ((DataRowView)bindingSource_StnList.Current).Row.RejectChanges();

                    btnRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--取消按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        private void btnStnListDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnList.Rows.Count == 0 || bindingSource_StnList.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有工位信息记录，不能进行删除。");
                    return;
                }
                DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                if (ssDAO.CheckStnList_IsModule(null, autoIdInt))
                    return;

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                if (ssDAO.DeleteStnSummaryList(autoIdInt))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    btnRefresh_Click(null, null);
                }
                else
                {
                    btnRefresh_Click(null, null);
                }

                Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除按钮事件错误。", ex);
            }
        }

        /// <summary>
        /// 设定主表的默认值
        /// </summary>
        private void TableStnList_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                if (TableStnSummary.Rows.Count > 0)
                {
                    e.Row["SSNo"] = TableStnSummary.Rows[0]["SSNo"];
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定主表的默认值错误。", ex);
            }
        }

        /// <summary>
        /// 设定按钮编辑区列表区的状态
        /// </summary>
        private void Set_ButtonEditGrid_State(bool state)
        {
            btnEditAutoQuotationNo.Properties.Buttons[0].Enabled = state;

            btnStnListNew.Enabled = state;
            if (state)
            {
                btnStnListSave.Text = "修改";
            }
            else
            {
                btnStnListSave.Text = "保存";
            }
            btnStnListCancel.Enabled = !state;
            btnStnListDelete.Enabled = state;
            btnRefresh.Enabled = state;

            btnModuleSelect.Enabled = state;
            btnModuleDelete.Enabled = state;

            btnModuleEdit.Enabled = state;
            btnModuleCopyEdit.Enabled = state;

            textEditStnNo.ReadOnly = state;
            textEditStnDesc.ReadOnly = state;

            if (this.Controls.ContainsKey("lblEditFlag"))
            {
                //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
                if (state)
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "";
                }
                else
                {
                    ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
                }
            }
        }

        #endregion

        #region 左侧工位功能模块列表区域的事件和方法

        /// <summary>
        /// 选择工位功能模块
        /// </summary>
        private void btnModuleSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource_StnList.Current == null)
                {
                    MessageHandler.ShowMessageBox("请选择要操作的工位信息。");
                    return;
                }

                FrmSelectStnModule ssmForm = new FrmSelectStnModule();
                if (ssmForm.ShowDialog() == DialogResult.OK)
                {
                    DataRow headRow = ((DataRowView)bindingSource_StnList.Current).Row;
                    int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                    string stnNoStr = DataTypeConvert.GetString(headRow["StnNo"]);
                    if (ssDAO.SaveStnListModule(autoIdInt, stnNoStr, ssmForm.smNoStrList))
                    {
                        gridViewStnList_FocusedRowChanged(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择工位功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 删除工位功能模块
        /// </summary>
        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableStnListModule.Rows.Count == 0 || bindingSource_StnListModule.Current == null)
                {
                    MessageHandler.ShowMessageBox("当前没有工位功能模块记录，不能进行删除。");
                    return;
                }

                if (MessageHandler.ShowMessageBox_YesNo("确定要删除当前选中的记录吗？") != DialogResult.Yes)
                {
                    return;
                }
                List<int> autoIdIntList = new List<int>();
                int[] selectLineNoList = gridViewModuleList.GetSelectedRows();
                if (selectLineNoList.Length > 0)
                {
                    foreach (int i in selectLineNoList)
                    {
                        autoIdIntList.Add(DataTypeConvert.GetInt(gridViewModuleList.GetRowCellValue(i, "AutoId")));
                    }
                }
                else
                {
                    DataRow headRow = ((DataRowView)bindingSource_StnListModule.Current).Row;
                    int autoIdInt = DataTypeConvert.GetInt(headRow["AutoId"]);
                    autoIdIntList.Add(autoIdInt);
                }

                if (ssDAO.DeleteStnListModule(autoIdIntList))
                {
                    MessageHandler.ShowMessageBox("删除成功。");
                    gridViewStnList_FocusedRowChanged(null, null);
                }
                else
                {
                    gridViewStnList_FocusedRowChanged(null, null);
                }
                //Set_ButtonEditGrid_State(true);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--删除工位功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 编辑基础功能模块
        /// </summary>
        private void btnModuleEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow focusedRow = gridViewModuleList.GetFocusedDataRow();
                if (focusedRow == null)
                {
                    MessageHandler.ShowMessageBox("请选择要进行编辑的功能模块。");
                    return;
                }

                string smNoStr = DataTypeConvert.GetString(focusedRow["SMNo"]);
                int autoIdInt = DataTypeConvert.GetInt(focusedRow["AutoId"]);

                int count = ssDAO.QueryOtherStnUseModuleCount(smNoStr, autoIdInt);
                if (count > 0)
                {
                    if (MessageHandler.ShowMessageBox_YesNo(string.Format("功能模块[{0}]除去当前记录还有{1}个工位信息使用，确认继续修改吗？", smNoStr, count)) != DialogResult.Yes)
                        return;
                }

                FrmStnModule.querySMNoStr = smNoStr;
                ViewHandler.ShowRightWindow("FrmStnModule");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--编辑基础功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 复制编辑基础功能模块
        /// </summary>
        private void btnModuleCopy_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow focusedRow = gridViewModuleList.GetFocusedDataRow();
                if (focusedRow == null)
                {
                    MessageHandler.ShowMessageBox("请选择要进行复制编辑的功能模块。");
                    return;
                }

                string smNoStr = DataTypeConvert.GetString(focusedRow["SMNo"]);
                int autoIdInt = DataTypeConvert.GetInt(focusedRow["AutoId"]);

                FrmStnModule.copySMNoStr = smNoStr;
                FrmStnModule.StnSummaryListModule_AutoId = autoIdInt;
                FrmStnModule smForm = new FrmStnModule();
                smForm.ShowDialog();

                btnRefresh_Click(null, null);

                for (int i = 0; i < gridViewModuleList.DataRowCount; i++)
                {
                    if (DataTypeConvert.GetInt(gridViewModuleList.GetDataRow(i)["AutoId"]) == autoIdInt)
                    {
                        gridViewModuleList.FocusedRowHandle = i;
                        break;
                    }
                }

                //ViewHandler.ShowRightWindow("FrmStnModule");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--复制编辑基础功能模块错误。", ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewModuleList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    btnModuleEdit_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
            }
        }

        /// <summary>
        /// 刷新功能模块的明细信息
        /// </summary>
        private void gridViewModuleList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow focusedRow = gridViewModuleList.GetFocusedDataRow();
                if (focusedRow != null)
                {
                    string smNoStr = DataTypeConvert.GetString(focusedRow["SMNo"]);
                    if (smNoStr != "")
                        QueryDeliveryDetail(smNoStr);
                }
                else
                {
                    QueryDeliveryDetail("");
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--刷新功能模块的明细信息错误。", ex);
            }
        }

        /// <summary>
        /// 根据功能模块号查询相关的供货明细信息
        /// </summary>
        private void QueryDeliveryDetail(string smNoStr)
        {
            dataSet_DeliveryDetail.Tables[0].Rows.Clear();
            if (smNoStr != "")
            {
                ssDAO.QueryDeliveryDetail_AllInfo(dataSet_DeliveryDetail.Tables[0], smNoStr);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.SaveDevGridControlExportToExcel(gridViewDeliveryDetail);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
            }
        }

        #endregion

    }
}
