using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_task
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable Dt;
        private SqlDataAdapter Da;
        private string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\assersami03\Documents\EMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

        }

        public DataTable GetData(string Query)
        {
            Dt = new DataTable();
            Da = new SqlDataAdapter(Query, ConStr);
            Da.Fill(Dt);
            return Dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}