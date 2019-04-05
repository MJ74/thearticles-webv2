using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Text;

namespace WEBv2.App_Code
{
    public class DBHandler
    {

        SqlConnection con = new SqlConnection();
        /// <summary>
        /// Select the Database
        /// 1 for Services, 2 for Ent, 3 for Edu
        /// </summary>
        /// <param name="DBno">values 1 2 3</param>
        public void DBsel(int DBno)
        {
            if (DBno == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString1"].ConnectionString;
            }
            else if (DBno == 2)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString2"].ConnectionString;
            }
            else if (DBno == 3)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString3"].ConnectionString;
            }
            else if  (DBno == 4)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString4"].ConnectionString;

            }
        }
        
        /// <summary>
        /// inserts data into a given table in database 1
        /// </summary>
        /// <param name="TbN">table name</param>
        public void InsertIntoDB(string TbN)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into '" + TbN + "' (Id, Name, Email, URL, PIN) values(@id, @name, @email, @url, @pin)", con);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">Table Name</param>
        /// <param name="w"></param>
        /// <param name="e"></param>
        /// <param name="r"></param>
        /// <param name="t"></param>
        /// <param name="y"></param>
        public void InsertIntoDB(string o, string w, string e, string r, string t, string y)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into '" + o + "' (Id, Name, Email, URL, PIN) values(@p1, @p2, @p3, @4, @5)", con);
            cmd.Parameters.Add("@p1", System.Data.SqlDbType.Int).Value = w;
            cmd.Parameters.AddWithValue("@p2", e);
            cmd.Parameters.AddWithValue("@p3", r);
            cmd.Parameters.AddWithValue("@p4", t);
            cmd.Parameters.AddWithValue("@p4", y);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateDB()
        {

        }

        public void ReadDB(out string read, string Tb)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT from '" + Tb + "'");
            read =  Convert.ToString(cmd.ExecuteNonQuery());
            
        }
    }
}