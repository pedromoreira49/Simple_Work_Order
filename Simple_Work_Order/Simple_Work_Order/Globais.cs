using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Work_Order
{
    public class Globais
    {
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string database = path + @"database\";
        public static string workOrders = path + @"workorders\";
        public static string images = path + @"images\";
    }
}
