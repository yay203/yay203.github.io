using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{

    public class comment
    {
        public bool Insert(MvcModel.commentData datcomment)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into comment (moduel,mid,userid,thedate,thescore,thecon)  values (@moduel,@mid,@userid,@thedate,@thescore,@thecon) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@moduel", datcomment.moduel);
                objDB.Command.Parameters.AddWithValue("@mid", datcomment.mid);
                objDB.Command.Parameters.AddWithValue("@userid", datcomment.userid);
                objDB.Command.Parameters.AddWithValue("@thedate", datcomment.thedate);
                objDB.Command.Parameters.AddWithValue("@thescore", datcomment.thescore);
                objDB.Command.Parameters.AddWithValue("@thecon", datcomment.thecon);
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
        public bool Modify(MvcModel.commentData datcomment)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update comment set moduel=@moduel,mid=@mid,userid=@userid,thedate=@thedate,thescore=@thescore,thecon=@thecon where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@moduel", datcomment.moduel);
                objDB.Command.Parameters.AddWithValue("@mid", datcomment.mid);
                objDB.Command.Parameters.AddWithValue("@userid", datcomment.userid);
                objDB.Command.Parameters.AddWithValue("@thedate", datcomment.thedate);
                objDB.Command.Parameters.AddWithValue("@thescore", datcomment.thescore);
                objDB.Command.Parameters.AddWithValue("@thecon", datcomment.thecon);
                objDB.Command.Parameters.AddWithValue("@Id", datcomment.Id);
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
                string strSql = "delete from comment where Id=" + Id + "";
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

        public MvcModel.commentData[] Select(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.commentData[] datcomment = new MvcModel.commentData[1];
            string sql = "select * from comment where 1= 1  ";
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
                        datcomment = new MvcModel.commentData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datcomment[i] = new MvcModel.commentData();
                            datcomment[i].moduel = ds.Tables[0].Rows[i]["moduel"].ToString();
                            datcomment[i].mid = ds.Tables[0].Rows[i]["mid"].ToString();
                            datcomment[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datcomment[i].thedate = ds.Tables[0].Rows[i]["thedate"].ToString();
                            datcomment[i].thescore = ds.Tables[0].Rows[i]["thescore"].ToString();
                            datcomment[i].thecon = ds.Tables[0].Rows[i]["thecon"].ToString();
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
            return datcomment;
        }
        public MvcModel.commentData SelectData(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.commentData datcomment = new MvcModel.commentData();
            string sql = "select * from comment where 1= 1  ";
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
                            datcomment.moduel = ds.Tables[0].Rows[i]["moduel"].ToString();
                            datcomment.mid = ds.Tables[0].Rows[i]["mid"].ToString();
                            datcomment.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datcomment.thedate = ds.Tables[0].Rows[i]["thedate"].ToString();
                            datcomment.thescore = ds.Tables[0].Rows[i]["thescore"].ToString();
                            datcomment.thecon = ds.Tables[0].Rows[i]["thecon"].ToString();
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
            return datcomment;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from comment where 1 = 1 ";
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
            string sql = "select count (1)  from comment where id > 0";
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
                sql = "select top " + pagesize + " * from comment where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from comment where id not in (select top " + (pageindex - 1) * pagesize + " id from comment order by id desc) " + casestr + " order by id desc";
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
