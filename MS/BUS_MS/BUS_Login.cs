using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_MS;
using System.Data;
using System.Data.SqlClient;
namespace BUS_MS
{
    public class BUS_Login
    {
        DAL_Login da = new DAL_Login();
        public bool getUser(string username, string pass)
        {
            return da.getUser(username, pass);
        }
    }
}
