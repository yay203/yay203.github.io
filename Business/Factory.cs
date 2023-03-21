using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Business
{
    public class Factory
    {
        /// <summary>
        ///The core of the simple factory: create objects based on user input and assign them to the parent class.
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static GetTable GetGetTable(string tablename)
        {
            GetTable GetTable = null;
            switch (tablename)
            {
                case "Users":
                    GetTable = new Users();
                    break;
                case "Movie":
                    GetTable = new Movie();
                    break;
                case "Comment":
                    GetTable = new Comment();
                    break;
            }
            return GetTable;
        }
    }

    public abstract class GetTable
    {
        public abstract DataTable SelectAll();
    }

    public class Users : GetTable
    {
        public override DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from users where 1 = 1 ";
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;

        }
    }
    public class Movie : GetTable
    {
        public override DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from movie where 1 = 1 ";
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }
    }
    public class Comment : GetTable
    {
        public override DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from comment where 1 = 1 ";
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;

        }
    }
}
