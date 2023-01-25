using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_task
{
    class finction
    {
        private SqlConection ConStr;
        private SqlCommand Cmd;
        private DataTable dt; 
        private SqlDataAdapter sda;
        private string Constr;
        public finction() 
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\assersami03\Documents\EMPDB.mdf;Integrated Security=True;Connect Timeout=30";
            ConStr = new SqlConection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Conection=ConStr;

        }

        public object Con { get; private set; }

        public DataTable GetData(string Query) 
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string Query) 
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed) 
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExcuteNonQuery();
            return cnt;
        }
    }
}
