namespace DB_task
{
    internal class SqlCommand
    {
        public SqlConection Conection { get; internal set; }
        public string CommandText { get; internal set; }

        internal int ExcuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}