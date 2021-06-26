using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simple_Work_Order
{
    public class Globais
    {
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string database = path + @"database\";
        public static string workOrders = path + @"workorders\";
        public static string images = path + @"images\";

        public static void CreatePaths()
        {
            if (!Directory.Exists(database))
            {
                Directory.CreateDirectory(database);
            }
            if (!Directory.Exists(workOrders))
            {
                Directory.CreateDirectory(workOrders);
            }
            if (!Directory.Exists(images))
            {
                Directory.CreateDirectory(images);
            }
        }
    }
}
