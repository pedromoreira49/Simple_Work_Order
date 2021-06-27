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
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Works_Order(Client Varchar(100), Contact Varchar(100), WorkID Varchar(10), Equip Varchar(240), Work Varchar(240), Price Varchar(30), DateIn Varchar(100))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetWorks()
        {
            SQLiteDataAdapter data = null;
            DataTable dt = new DataTable();
            try
            {
                using(var cmd = DBconnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Works_Order";
                    data = new SQLiteDataAdapter(cmd.CommandText, DBconnection());
                    data.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void Register(WorkOrders works)
        {
            try
            {
                using (var cmd = DBconnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Works_Order(Client, Contact, WorkID, Equip, Work, Price, DateIn) values (@Client, @Contact, @WorkID, @Equip, @Work, @Price, @DateIn)";
                    cmd.Parameters.AddWithValue("@Client", works.Client);
                    cmd.Parameters.AddWithValue("@Contact", works.Contact);
                    cmd.Parameters.AddWithValue("@WorkID", works.WorkID);
                    cmd.Parameters.AddWithValue("@Equip", works.Equip);
                    cmd.Parameters.AddWithValue("@Work", works.Work);
                    cmd.Parameters.AddWithValue("@Price", works.Price);
                    cmd.Parameters.AddWithValue("@DateIn", works.DateIn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Validation(string WorkID)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            using (var cmd = DBconnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Works_Order WHERE WorkID = " + WorkID + " LIMIT 1";
                da = new SQLiteDataAdapter(cmd.CommandText, DBconnection());
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchDatas(string Client)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            using (var cmd = DBconnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Works_Order WHERE Client LIKE " + "'" + Client + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, DBconnection());
                da.Fill(dt);
                return dt;
            }
        }

        public static void Delete(string WorkID)
        {
            using (var cmd = DBconnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Works_Order WHERE WorkID =  " + WorkID;
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetDatasByWorkID(string WorkID)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = DBconnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Works_Order WHERE OsNumber = " + WorkID;
                da = new SQLiteDataAdapter(cmd.CommandText, DBconnection());
                da.Fill(dt);
                return dt;
            }
        }

        public static void UpdateDatas(WorkOrders works)
        {
            var workId = FormUpdate.WorkID();
            try
            {
                using(var cmd = DBconnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Works_Order SET Client=@Client, Contact=@Contact, WorkID=@WorkID, Equip=@Equip, Work=@Work, Price=@Price WHERE WorkID = " +  workId;
                    cmd.Parameters.AddWithValue("@Client", works.Client);
                    cmd.Parameters.AddWithValue("@Contact", works.Contact);
                    cmd.Parameters.AddWithValue("@WorkID", works.WorkID);
                    cmd.Parameters.AddWithValue("@Equip", works.Equip);
                    cmd.Parameters.AddWithValue("@Work", works.Work);
                    cmd.Parameters.AddWithValue("@Price", works.Price);
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
