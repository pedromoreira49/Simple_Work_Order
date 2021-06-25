﻿using System;
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

        public static void CreateDatabase()
        {
            if (!File.Exists($"{database}WorksOrder.sqlite"))
            {
                SQLiteConnection.CreateFile($@"{database}WorksOrder.sqlite");
            }
        }

        public static void CreateTable()
        {
            try
            {
                using(var cmd = DBconnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Works_Order(Client Varchar(100), Contact Varchar(100), WorkID Varchar(5), Equip Varchar(240), Work Varchar(240), Price Varchar(30), DateIn Varchar(100))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
