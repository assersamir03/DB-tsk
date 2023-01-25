using System.Data;

namespace DB_task
{
    internal class SqlDataAdapter
    {
        private SqlConection conStr;

        public SqlDataAdapter(string query, finction.Constr constr)
        {
            Query = query;
            Constr = constr;
        }

        public SqlDataAdapter(string query, SqlConection conStr)
        {
            Query = query;
            this.conStr = conStr;
        }

        public string Query { get; }
        public finction.Constr Constr { get; }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}