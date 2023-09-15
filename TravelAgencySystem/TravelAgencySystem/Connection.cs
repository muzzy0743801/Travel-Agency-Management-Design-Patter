using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelAgencySystem
{
    public  class Connection
    {
        protected Connection()
        {

        }
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2FC7BGT\SQL;Initial Catalog=TravelAgencySystem;Integrated Security=True");
        public static SqlConnection GetCon()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
          
            return con;
        }
    }
}
