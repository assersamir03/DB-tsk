using System.Data;

namespace DB_task
{
    internal class finctionBase
    {
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
        }
    }
}