using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace del_app.BL
{
    internal class All_Orders
    {
        public DataTable get_orders()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_orders", null);
            return dt;
        }
        
            public void update_state(String state,int id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@state", SqlDbType.VarChar, 30);
            param[0].Value = state;
           
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = id;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            DAL.exec_cmd("update_state", param);
            
        }
        public void delete_order( int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            DAL.exec_cmd("delete_order", param);

        }

        public DataTable get_done_orders()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("done_orders", null);
            return dt;
        }


        public DataTable get_account()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("account", null);
            return dt;
        }

        
        internal void update_state(Func<string?> toString, int v)
        {
            throw new NotImplementedException();
        }
    }
}
