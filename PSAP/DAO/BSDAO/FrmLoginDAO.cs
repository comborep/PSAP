﻿using PSAP.ENTITY.BSENTITY;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmLoginDAO
    {
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="strPassworNew"></param>
        /// <param name="strLoginId"></param>
        public static void ChangePassword(string strPassworNew, string strLoginId)
        {
            string sql = @"update BS_UserInfo set LoginPwd = '" + strPassworNew + "' where LoginId like '" + strLoginId + "'";
            BaseSQL.ExecuteSql(sql);

        }

        public static UserInfo CheckUser(string txtUserID, string txtPassword,string strLanuage)
        {
            string sqlString = "select a.*,b.DepartmentName,c.RoleNo,d.RoleName " +
            "from BS_UserInfo a left join BS_Department b on a.DepartmentNo=b.DepartmentNo " +
            "left join BS_RoleUser c on a.AutoID=c.UserNo " +  //autoID是UserInfo表的关键字
            "left join BS_Role d on c.RoleNo=d.RoleNo " +
            "where a.LoginID='" + txtUserID + "' and a.LoginPwd='" + txtPassword + "'";
            DataSet ds = new DataSet();
            ds = BaseSQL.Query(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                SystemInfo.user = new UserInfo();
                SystemInfo.user.DepartmentNo = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                SystemInfo.user.EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                SystemInfo.user.LoginID = ds.Tables[0].Rows[0]["LoginID"].ToString();
                SystemInfo.user.DepartmentName = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                SystemInfo.user.RoleNo = ds.Tables[0].Rows[0]["RoleNo"].ToString();
                SystemInfo.user.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                SystemInfo.user.AutoId = (int)ds.Tables[0].Rows[0]["AutoId"];
                SystemInfo.user.Lanuage = strLanuage;
                return SystemInfo.user;
            }
            else
            {
                return SystemInfo.user;
            }
        }

        /// <summary>
        /// 获得语种类别数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GegLanguageCategory()
        {
            DataTable dt;
            string sql = "select LanguageName,LanguageText from BS_LanguageCategory";
            dt=BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 查询该登陆ID的用户数量
        /// </summary>
        public int QueryUserInfoCount(string loginIdStr)
        {
            string sqlStr = string.Format("select Count(*) from BS_UserInfo where LoginId = '{0}'", loginIdStr);
            int count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            return count;
        }
    }
}
