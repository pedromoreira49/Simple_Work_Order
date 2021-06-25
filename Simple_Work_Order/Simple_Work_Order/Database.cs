using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace Simple_Work_Order
{
    class Database
    {
        private static SQLiteConnection sqlconnection;
        public static string database = Globais.database;

        private static SQLiteConnection DBconnection()
        {
            sqlconnection = new SQLiteConnection($"Data Source={database}\\WorksOrder.sqlite; Version=3;");
            sqlconnection.Open();
            return sqlconnection;
        }

        
    }
}
