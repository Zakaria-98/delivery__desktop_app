using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace del_app.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection sqlconnection;
        public DataAccessLayer() {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS01; Database=deliverydb; Integrated Security=true");
        }

        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }

        }
        
        public DataTable selectdata(string stored_proc, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(stored_proc, sqlconnection);
            sqlcmd.CommandType = CommandType.StoredProcedure;
           // sqlcmd.CommandText = stored_proc;
            if (param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        


        public void exec_cmd(string stored_proc, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(stored_proc,sqlconnection);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //sqlcmd.CommandText = stored_proc;
            if(param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }

        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

    }

}
