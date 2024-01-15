using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace del_app.BL
{
    internal class New_Order
    {

        public DataTable get_stores()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_store_names", null);
            return dt;
        }

        public String get_city_price(String city_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@city_name", SqlDbType.VarChar, 50);
            param[0].Value = city_name;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_city_price", param);
            String x=" ";
            if (dt.Rows.Count>0)
            x = dt.Rows[0][0].ToString();
            return x;
        }

       
        public DataTable get_cities()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_cities", null);
            return dt;
        }

       

        public void add_new_order(String store_id, int product_price, int del_price, String city , String customer_name,String customer_tel)
        {
            DAL.DataAccessLayer DAL =new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@store_id", SqlDbType.VarChar,30);
            param[0].Value = store_id;
            param[1] = new SqlParameter("@prod_price", SqlDbType.Int);
            param[1].Value = product_price;
            param[2] = new SqlParameter("@city_price", SqlDbType.Int);
            param[2].Value = del_price;
            param[3] = new SqlParameter("@city_name", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@cust_name", SqlDbType.VarChar, 50);
            param[4].Value = customer_name;
            param[5] = new SqlParameter("@cust_tel", SqlDbType.NChar,15);
            param[5].Value = customer_tel;
            param[6] = new SqlParameter("@state", SqlDbType.NChar, 15);
            param[6].Value = "قيد الاجراء";
            DAL.open();
            DAL.exec_cmd("add_order", param);
        }

    }
}
