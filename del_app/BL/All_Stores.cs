using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace del_app.BL
{
    internal class All_Stores
    {

        public DataTable get_stores()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_store_names", null);
            return dt;
        }

        public DataTable get_orders(String store_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@store_id", SqlDbType.VarChar, 30);
            param[0].Value = store_id;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_store_orders", param);
            return dt;
        }

        public DataTable get_orders_state(String store_id, String state)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@store_id", SqlDbType.VarChar, 30);
            param[0].Value = store_id;
            param[1] = new SqlParameter("@state", SqlDbType.VarChar, 30);
            param[1].Value = state;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();

            dt = DAL.selectdata("get_store_orders_state", param);
            return dt;
        }
        public DataTable get_store_account(String store_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@store_id", SqlDbType.VarChar, 30);
            param[0].Value = store_id;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("store_account", param);
            return dt;
        }
    }
}
