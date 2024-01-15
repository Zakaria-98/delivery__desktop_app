using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace del_app.BL
{
    internal class New_Store
    {

        public void add_new_store(string store_id, string store_name, string customer_tel)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@store_id", SqlDbType.VarChar, 30);
            param[0].Value=store_id;
            param[1] = new SqlParameter("@store_name", SqlDbType.VarChar, 50);
            param[1].Value=store_name;
            param[2] = new SqlParameter("@store_tel", SqlDbType.NChar, 15);
            param[2].Value=customer_tel;
            
            DAL.exec_cmd("new_store", param);
        }
    }
}
