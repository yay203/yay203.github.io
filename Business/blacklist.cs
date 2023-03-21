using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{

    public class blacklist
    {
        public bool Login(string thestr)
        {
            bool flag = false;
            string strSql = "SELECT * FROM blacklist WHERE thestr like '%" + thestr + "%'";
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            DataTable dt = objDB.QueryDataTable(strSql, "Users");
            if (dt != null && dt.Rows.Count > 0)
            {
                flag = true;
            }
            else
            {

            }
            dt = null;
            return flag;
        }

        public bool Insert(MvcModel.blacklistData datblacklist)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into blacklist (thestr,thetime)  values (@thestr,@thetime) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thestr", datblacklist.thestr);
                objDB.Command.Parameters.AddWithValue("@thetime", datblacklist.thetime);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false);
            return bRel;
        }
        public bool Modify(MvcModel.blacklistData datblacklist)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update blacklist set thestr=@thestr,thetime=@thetime where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thestr", datblacklist.thestr);
                objDB.Command.Parameters.AddWithValue("@thetime", datblacklist.thetime);
                objDB.Command.Parameters.AddWithValue("@Id", datblacklist.Id);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { iRel = -1; }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false); return bRel;
        }
        public bool Delete(string Id)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "delete from blacklist where Id=" + Id + "";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false);
            return bRel;
        }

        public MvcModel.blacklistData[] Select(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.blacklistData[] datblacklist = new MvcModel.blacklistData[1];
            string sql = "select * from blacklist where 1= 1  ";
            sql += casestr;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datblacklist = new MvcModel.blacklistData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datblacklist[i] = new MvcModel.blacklistData();
                            datblacklist[i].thestr = ds.Tables[0].Rows[i]["thestr"].ToString();
                            datblacklist[i].thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return datblacklist;
        }
        public MvcModel.blacklistData SelectData(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.blacklistData datblacklist = new MvcModel.blacklistData();
            string sql = "select * from blacklist where 1= 1  ";
            sql += casestr;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            datblacklist.thestr = ds.Tables[0].Rows[i]["thestr"].ToString();
                            datblacklist.thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return datblacklist;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from blacklist where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }
        public int CalcCountSearch(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select count (1)  from blacklist where id > 0";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return (dt == null) ? 0 : int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable SelectAllFenyeSearch(int pagesize, int pageindex, string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "";
            if ((pageindex - 1) * pagesize == 0)
            {
                sql = "select top " + pagesize + " * from blacklist where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from blacklist where id not in (select top " + (pageindex - 1) * pagesize + " id from blacklist order by id desc) " + casestr + " order by id desc";
            }
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }
    }
}
