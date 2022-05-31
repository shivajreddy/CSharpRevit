using System;

namespace ConsoleApp1
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        // Constructor
        public DbCommand(DbConnection dbConnection)
        {
            // validate DbConnection to be sql. check for null or empty string
            // sample validation -> "sql://db"
            try
            {
                _dbConnection = dbConnection as Program.SqlConnection;
                if (_dbConnection == null)
                    throw new ArgumentException($"{dbConnection} is not sql");
                //throw new ArgumentException($"{dbConnection.ConnectionString} is not valid connection string");
                //if (dbConnection.ConnectionString != "sql://db")
                //    throw new ArgumentException($"{dbConnection.ConnectionString} is not valid connection string");
                //_dbConnection = dbConnection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        // Methods
        public void Execute(string instruction)
        {
            _dbConnection.Open();
            Console.WriteLine($"{instruction} completed successfully ✅");
            _dbConnection.Close();
        }

    }
    internal class Program
    {

        public class SqlConnection : DbConnection
        {
            // Constructor
            public SqlConnection(string connc_string)
                : base(connc_string)
            {

            }

            // Methods
            public override void Open()
            {
                Console.WriteLine("SQL connection is now open");
            }

            public override void Close()
            {
                Console.WriteLine("SQL connection is now closed");
            }
        }

        public class MongoConnection : DbConnection
        {
            //ctor
            public MongoConnection(string connectin_string)
                : base(connectin_string)
            {
            }

            public override void Open() => Console.WriteLine("MongoDb Connection is open");
            public override void Close() => Console.WriteLine("MongoDb Connection is closed");
        }

        static void Main(string[] args)
        {
            var sqlDb = new SqlConnection("sql://db");
            var cmd1 = new DbCommand(sqlDb);
            cmd1.Execute("say hello");
            sqlDb.Open();

            var mongo1 = new MongoConnection("mongo://db/123");
            var cmd2 = new DbCommand(mongo1);


        }
    }
}
