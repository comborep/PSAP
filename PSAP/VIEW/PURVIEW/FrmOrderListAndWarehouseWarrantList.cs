﻿using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
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
    public partial class FrmOrderListAndWarehouseWarrantList : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmOrderDAO orderDAO = new FrmOrderDAO();
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();

        /// <summary>
        /// 最后一次查询的SQL
        /// </summary>
        string lastQuerySqlStr = "";

        public FrmOrderListAndWarehouseWarrantList()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(f);
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件错误
        /// </summary>
        private void FrmOrderListAndWarehouseWarrantList_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = BaseSQL.GetServerDateTime();
                dateOrderDateBegin.DateTime = nowDate.Date.AddDays(-SystemInfo.OrderQueryDate_DefaultDays);
                dateOrderDateEnd.DateTime = nowDate.Date;

                lookUpReqDep.Properties.DataSource = commonDAO.QueryDepartment(true);
                lookUpReqDep.ItemIndex = 0;
                lookUpPurCategory.Properties.DataSource = commonDAO.QueryPurCategory(true);
                lookUpPurCategory.ItemIndex = 0;
                searchLookUpBussinessBaseNo.Properties.DataSource = commonDAO.QueryBussinessBaseInfo(true);
                searchLookUpBussinessBaseNo.Text = "全部";
                comboBoxReqState.SelectedIndex = 0;
                searchLookUpProjectNo.Properties.DataSource = commonDAO.QueryProjectList(true);
                searchLookUpProjectNo.Text = "全部";
                searchLookUpCodeFileName.Properties.DataSource = commonDAO.QueryPartsCode(true);
                searchLookUpCodeFileName.Text = "全部";

                repSearchProjectNo.DataSource = commonDAO.QueryProjectList(false);
                repLookUpPurCategory.DataSource = commonDAO.QueryPurCategory(false);
                repSearchBussinessBaseNo.DataSource = commonDAO.QueryBussinessBaseInfo(false);
                repLookUpReqDep.DataSource = commonDAO.QueryDepartment(false);
                repLookUpRepertoryNo.DataSource = commonDAO.QueryRepertoryInfo(false);
                repSearchShelfId.DataSource = commonDAO.QueryShelfInfo(false);

                gridBottomOrderHead.pageRowCount = SystemInfo.OrderQueryGrid_PageRowCount;

                btnQuery_Click(null, null);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCtjzsjcw.Text , ex);
            }
        }

        /// <summary>
        /// 设定列表显示信息
        /// </summary>
        private void gridViewOrderList_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            switch(e.Column.FieldName)
            {
                case "ReqState":
                    e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
                    break;
                case "WarehouseState":
                    e.DisplayText = CommonHandler.Get_WarehouseState_Desc(e.Value.ToString());
                    break;
            }
            
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewOrderList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewOrderList_KeyDown(object sender, KeyEventArgs e)
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
        /// 查询按钮事件
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateOrderDateBegin.EditValue == null || dateOrderDateEnd.EditValue == null)
                {
                    MessageHandler.ShowMessageBox(tsmidgribnwk.Text);// ("订购日期不能为空，请设置后重新进行查询。");
                    if (dateOrderDateBegin.EditValue == null)
                        dateOrderDateBegin.Focus();
                    else
                        dateOrderDateEnd.Focus();
                    return;
                }
                string orderDateBeginStr = dateOrderDateBegin.DateTime.ToString("yyyy-MM-dd");
                string orderDateEndStr = dateOrderDateEnd.DateTime.AddDays(1).ToString("yyyy-MM-dd");

                string reqDepStr = lookUpReqDep.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpReqDep.EditValue) : "";
                string purCategoryStr = lookUpPurCategory.ItemIndex > 0 ? DataTypeConvert.GetString(lookUpPurCategory.EditValue) : "";
                string bussinessBaseNoStr = DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) != "全部" ? DataTypeConvert.GetString(searchLookUpBussinessBaseNo.EditValue) : "";
                int reqStateInt = CommonHandler.Get_OrderState_No(comboBoxReqState.Text); 
                string projectNoStr = searchLookUpProjectNo.Text != "全部" ? DataTypeConvert.GetString(searchLookUpProjectNo.EditValue) : "";
                string codeFileNameStr = searchLookUpCodeFileName.Text != "全部" ? DataTypeConvert.GetString(searchLookUpCodeFileName.EditValue) : "";
                string commonStr = textCommon.Text.Trim();
                dataSet_Order.Tables[0].Clear();

                string querySqlStr = orderDAO.Query_OrderListAndWarehouseWarrantList(orderDateBeginStr, orderDateEndStr, reqDepStr, purCategoryStr, bussinessBaseNoStr, reqStateInt, projectNoStr, codeFileNameStr, commonStr);
                lastQuerySqlStr = querySqlStr;
                string countSqlStr = commonDAO.QuerySqlTranTotalCountSql(querySqlStr);
                gridBottomOrderHead.QueryGridData(ref dataSet_Order, "OrderList", querySqlStr, countSqlStr, true);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxansjcw.Text , ex);
            }
        }

        /// <summary>
        /// 查询结果存为Excel
        /// </summary>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //FileHandler.SaveDevGridControlExportToExcel(gridViewOrderList);
                if (gridBottomOrderHead.pageCount <= 1)
                    FileHandler.SaveDevGridControlExportToExcel(gridViewOrderList);
                else
                    commonDAO.SaveExcel_QueryAllData(dataSet_Order.Tables[0], lastQuerySqlStr, gridViewOrderList);
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--查询结果存为Excel错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiCxjgcwexcelcw.Text , ex);
            }
        }

        /// <summary>
        /// 双击查询明细
        /// </summary>
        private void gridViewOrderList_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    string orderHeadNoStr = DataTypeConvert.GetString(gridViewOrderList.GetFocusedDataRow()["OrderHeadNo"]);
                    int autoIdInt = DataTypeConvert.GetInt(gridViewOrderList.GetFocusedDataRow()["AutoId"]);
                    FrmOrder.queryOrderHeadNo = orderHeadNoStr;
                    FrmOrder.queryListAutoId = autoIdInt;
                    ViewHandler.ShowRightWindow("FrmOrder");
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--双击查询明细错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiSjcxmxcw.Text , ex);
            }
        }

        /// <summary>
        /// 设置Grid单元格合并
        /// </summary>
        private void gridViewOrderList_CellMerge(object sender, CellMergeEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string firstColumnFieldName = "AutoId";

                switch (e.Column.FieldName)
                {
                    case "WarehouseWarrant":
                    case "WarehouseWarrantDate":
                    case "WarehouseState":
                    case "WWQty":
                    case "RepertoryNo":
                    case "ShelfId":

                        break;
                    default:
                        {
                            string valueFirstColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, firstColumnFieldName));
                            string valueFirstColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, firstColumnFieldName));
                            string valueOtherColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, e.Column.FieldName));
                            string valueOtherColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, e.Column.FieldName));
                            e.Merge = valueFirstColumn1 == valueFirstColumn2 && valueOtherColumn1 == valueOtherColumn2;
                            e.Handled = true;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设置Grid单元格合并错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--"+f.tsmiSzgriddyghbcw.Text , ex);
            }
        }
    }
}
