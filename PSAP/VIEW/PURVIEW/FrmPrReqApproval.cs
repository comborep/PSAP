﻿using PSAP.DAO.BSDAO;
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
    public partial class FrmPrReqApproval : DockContent
    {
        /// <summary>
        /// 请购单号
        /// </summary>
        string prReqNoStr = "";

        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();
        FrmApprovalDAO approvalDAO = new FrmApprovalDAO();

        public FrmPrReqApproval()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        public FrmPrReqApproval(string prReqNo)
        {
            InitializeComponent();
            this.prReqNoStr = prReqNo;
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmApprovalPrReq_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpApprovalType.Properties.DataSource = new FrmCommonDAO().QueryApprovalType(false);

                approvalDAO.QueryPrReqHead(dataSet_PrReq.Tables[0], prReqNoStr);
                if (dataSet_PrReq.Tables[0].Rows.Count == 0)
                {
                    MessageHandler.ShowMessageBox(tsmiCxqgd.Text);// ("查询请购订单信息错误，请重新操作。");
                    return;
                }
                string typeNoStr = DataTypeConvert.GetString(dataSet_PrReq.Tables[0].Rows[0]["ApprovalType"]);
                int approvalCatInt = DataTypeConvert.GetInt(dataSet_PrReq.Tables[0].Rows[0]["ApprovalCat"]);
                approvalDAO.QueryPrReqApprovalInfo(dataSet_PrReq.Tables[1], prReqNoStr, typeNoStr);

                if (approvalCatInt == 0)
                {
                    for (int i = 0; i < dataSet_PrReq.Tables[1].Rows.Count; i++)
                    {
                        if (DataTypeConvert.GetString(dataSet_PrReq.Tables[1].Rows[i]["prReqNo"]) == "")
                        {
                            if (DataTypeConvert.GetInt(dataSet_PrReq.Tables[1].Rows[i]["Approver"]) != SystemInfo.user.AutoId)
                                btnApproval.Enabled = false;
                            else
                                btnApproval.Enabled = true;
                            return;
                        }
                    }
                }
                else if (approvalCatInt == 1 || approvalCatInt == 2)
                {
                    if (dataSet_PrReq.Tables[1].Select(string.Format("IsNull(prReqNo,'')='' and Approver={0}", SystemInfo.user.AutoId)).Length == 0)
                    {
                        btnApproval.Enabled = false;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCtjz.Text, ex);
            }
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewOrderAppInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            ControlHandler.GridView_CustomDrawRowIndicator(e);
        }

        /// <summary>
        /// 获取单元格显示的信息
        /// </summary>
        private void gridViewOrderAppInfo_KeyDown(object sender, KeyEventArgs e)
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
        /// 设定状态显示文字
        /// </summary>
        private void textReqState_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                e.DisplayText = CommonHandler.Get_OrderState_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 设定审批方式显示文字
        /// </summary>
        private void textApprovalCat_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                e.DisplayText = CommonHandler.Get_ApprovalCat_Desc(e.Value.ToString());
            }
        }

        /// <summary>
        /// 审批按钮事件
        /// </summary>
        private void btnApproval_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet_PrReq.Tables[0].Rows[0]["Select"] = true;
                int successCountInt = 0;
                if (!prReqDAO.PrReqApprovalInfo_Multi(dataSet_PrReq.Tables[0], ref successCountInt))
                {

                }
                if (successCountInt > 0)
                {
                    MessageHandler.ShowMessageBox(tsmiSpcg.Text);// ("审批成功。");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--审批按钮事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSpcg.Text, ex);
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
