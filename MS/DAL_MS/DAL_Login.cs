using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_MS
{
    public class DAL_Login: DBConnection
    {
        public bool getUser(string username,string pass)
        {
          
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM User WHERE username ='" + username + "' and password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
            catch
            {
                return false;
            }
                con.Close();
                return true;
            }
    }
}
