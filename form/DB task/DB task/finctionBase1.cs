using System.Data;

namespace DB_task
{
    internal class finctionBase1
    {
        private SqlCommand Cmd;
        private string Constr;
        private SqlConection ConStr;
        private DataTable dt;
        private SqlDataAdapter sda;
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
        }
    }
}