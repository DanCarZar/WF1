using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WF1.Data
{
    public static class DbConnectionFactory
    {
        private static string ConnectionString =>
            $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pos.db")}";

        public static IDbConnection Create()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}
