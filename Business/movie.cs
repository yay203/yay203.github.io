using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{

    public class movie
    {
        public bool Insert(MvcModel.movieData datmovie)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into movie (mname,mpic,mtype,mmtime,mpress,mscore,maddress,mting,mbrand,mcc,mprice,status,turnurl)  values (@mname,@mpic,@mtype,@mmtime,@mpress,@mscore,@maddress,@mting,@mbrand,@mcc,@mprice,@status,@turnurl) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@mname", datmovie.mname);
                objDB.Command.Parameters.AddWithValue("@mpic", datmovie.mpic);
                objDB.Command.Parameters.AddWithValue("@mtype", datmovie.mtype);
                objDB.Command.Parameters.AddWithValue("@mmtime", datmovie.mmtime);
                objDB.Command.Parameters.AddWithValue("@mpress", datmovie.mpress);
                objDB.Command.Parameters.AddWithValue("@mscore", datmovie.mscore);
                objDB.Command.Parameters.AddWithValue("@maddress", datmovie.maddress);
                objDB.Command.Parameters.AddWithValue("@mting", datmovie.mting);
                objDB.Command.Parameters.AddWithValue("@mbrand", datmovie.mbrand);
                objDB.Command.Parameters.AddWithValue("@mcc", datmovie.mcc);
                objDB.Command.Parameters.AddWithValue("@mprice", datmovie.mprice);
                objDB.Command.Parameters.AddWithValue("@status", datmovie.status);
                objDB.Command.Parameters.AddWithValue("@turnurl", datmovie.turnurl);
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
        public bool Modify(MvcModel.movieData datmovie)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update movie set mname=@mname,mpic=@mpic,mtype=@mtype,mmtime=@mmtime,mpress=@mpress,mscore=@mscore,maddress=@maddress,mting=@mting,mbrand=@mbrand,mcc=@mcc,mprice=@mprice,status=@status,turnurl=@turnurl where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@mname", datmovie.mname);
                objDB.Command.Parameters.AddWithValue("@mpic", datmovie.mpic);
                objDB.Command.Parameters.AddWithValue("@mtype", datmovie.mtype);
                objDB.Command.Parameters.AddWithValue("@mmtime", datmovie.mmtime);
                objDB.Command.Parameters.AddWithValue("@mpress", datmovie.mpress);
                objDB.Command.Parameters.AddWithValue("@mscore", datmovie.mscore);
                objDB.Command.Parameters.AddWithValue("@maddress", datmovie.maddress);
                objDB.Command.Parameters.AddWithValue("@mting", datmovie.mting);
                objDB.Command.Parameters.AddWithValue("@mbrand", datmovie.mbrand);
                objDB.Command.Parameters.AddWithValue("@mcc", datmovie.mcc);
                objDB.Command.Parameters.AddWithValue("@mprice", datmovie.mprice);
                objDB.Command.Parameters.AddWithValue("@status", datmovie.status);
                objDB.Command.Parameters.AddWithValue("@turnurl", datmovie.turnurl);
                objDB.Command.Parameters.AddWithValue("@Id", datmovie.Id);
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
                string strSql = "delete from movie where Id=" + Id + "";
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

        public MvcModel.movieData[] Select(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.movieData[] datmovie = new MvcModel.movieData[1];
            string sql = "select * from movie where 1= 1  ";
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
                        datmovie = new MvcModel.movieData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datmovie[i] = new MvcModel.movieData();
                            datmovie[i].mname = ds.Tables[0].Rows[i]["mname"].ToString();
                            datmovie[i].mpic = ds.Tables[0].Rows[i]["mpic"].ToString();
                            datmovie[i].mtype = ds.Tables[0].Rows[i]["mtype"].ToString();
                            datmovie[i].mmtime = ds.Tables[0].Rows[i]["mmtime"].ToString();
                            datmovie[i].mpress = ds.Tables[0].Rows[i]["mpress"].ToString();
                            datmovie[i].mscore = ds.Tables[0].Rows[i]["mscore"].ToString();
                            datmovie[i].maddress = ds.Tables[0].Rows[i]["maddress"].ToString();
                            datmovie[i].mting = ds.Tables[0].Rows[i]["mting"].ToString();
                            datmovie[i].mbrand = ds.Tables[0].Rows[i]["mbrand"].ToString();
                            datmovie[i].mcc = ds.Tables[0].Rows[i]["mcc"].ToString();
                            datmovie[i].mprice = ds.Tables[0].Rows[i]["mprice"].ToString();
                            datmovie[i].status = ds.Tables[0].Rows[i]["status"].ToString();
                            datmovie[i].turnurl = ds.Tables[0].Rows[i]["turnurl"].ToString();
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
            return datmovie;
        }
        public MvcModel.movieData SelectData(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            MvcModel.movieData datmovie = new MvcModel.movieData();
            string sql = "select * from movie where 1= 1  ";
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
                            datmovie.Id =Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]) ;
                            datmovie.mname = ds.Tables[0].Rows[i]["mname"].ToString();
                            datmovie.mpic = ds.Tables[0].Rows[i]["mpic"].ToString();
                            datmovie.mtype = ds.Tables[0].Rows[i]["mtype"].ToString();
                            datmovie.mmtime = ds.Tables[0].Rows[i]["mmtime"].ToString();
                            datmovie.mpress = ds.Tables[0].Rows[i]["mpress"].ToString();
                            datmovie.mscore = ds.Tables[0].Rows[i]["mscore"].ToString();
                            datmovie.maddress = ds.Tables[0].Rows[i]["maddress"].ToString();
                            datmovie.mting = ds.Tables[0].Rows[i]["mting"].ToString();
                            datmovie.mbrand = ds.Tables[0].Rows[i]["mbrand"].ToString();
                            datmovie.mcc = ds.Tables[0].Rows[i]["mcc"].ToString();
                            datmovie.mprice = ds.Tables[0].Rows[i]["mprice"].ToString();
                            datmovie.status = ds.Tables[0].Rows[i]["status"].ToString();
                            datmovie.turnurl = ds.Tables[0].Rows[i]["turnurl"].ToString();
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
            return datmovie;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from movie where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }

        public DataTable Top(string num)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select top " + num + " * from movie  order by id desc";
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
            string sql = "select count (1)  from movie where id > 0";
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
                sql = "select top " + pagesize + " * from movie where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from movie where id not in (select top " + (pageindex - 1) * pagesize + " id from movie order by id desc) " + casestr + " order by id desc";
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
