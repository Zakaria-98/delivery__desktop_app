using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace del_app.BL
{
    internal class New_City
    {

        public void add_new_city( string city, int city_price)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@city", SqlDbType.VarChar, 30);
            param[0].Value = city;
            param[1] = new SqlParameter("@city_price", SqlDbType.Int);
            param[1].Value = city_price;

            DAL.exec_cmd("new_city", param);
        }
    }
}
