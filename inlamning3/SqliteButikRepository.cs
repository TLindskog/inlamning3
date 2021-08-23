using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace inlamning3
{
    class SqliteButikRepository
    {
        private const string _connectionString = "Data Source=.\\inlamning3.db";

        public void PrintVersion()
        {
            using var connection = new SqliteConnection(_connectionString);
            Console.WriteLine(connection.ServerVersion);
        }
    }
}
