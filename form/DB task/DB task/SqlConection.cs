namespace DB_task
{
    internal class SqlConection
    {
        private SqlConection conStr;

        public SqlConection(string constr)
        {
            Constr = constr;
        }

        public SqlConection(SqlConection conStr)
        {
            this.conStr = conStr;
        }

        public string Constr { get; }

        public static implicit operator SqlConection(string v)
        {
            throw new NotImplementedException();
        }
    }
}