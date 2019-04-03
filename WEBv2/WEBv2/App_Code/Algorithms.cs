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
    public class Algorithms
    {

        SqlConnection con = new SqlConnection();
        /// <summary>
        /// Generates ID for a new order 
        /// </summary>
        /// <param name="control"></param>
        public void GenerateAutoID(string control)
        {
            int num = 105;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(Id) from HWFONTS", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            control = num + i.ToString();
        }
        
        private static string _numbers = "0123456789";
        Random random = new Random();
        /// <summary>
        /// Generates PIN for the order
        /// </summary>
        /// <param name="control"></param>
        public void GeneratePIN(out string control)
        {
            StringBuilder builder = new StringBuilder(6);
            string numberAsString = "";
            int numberAsNumber = 0;

            for (var i = 0; i < 6; i++)
            {
                builder.Append(_numbers[random.Next(0, _numbers.Length)]);
            }

            numberAsString = builder.ToString();
            numberAsNumber = int.Parse(numberAsString);
            control = Convert.ToString(numberAsNumber);
        }

    }
}