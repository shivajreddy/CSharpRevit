using System;

namespace ConsoleApp1
{
    public abstract class DbConnection
    {

        // Props
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        // Constructor
        public DbConnection(string connection_string)
        {
            if (!string.IsNullOrEmpty(connection_string))
                ConnectionString = connection_string;
        }

        // Methods
        public abstract void Open();
        public abstract void Close();

    }
}