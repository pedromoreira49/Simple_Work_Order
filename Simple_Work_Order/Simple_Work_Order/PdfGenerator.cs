using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using iTextSharp;
using iTextSharp.text.pdf;

namespace Simple_Work_Order
{
    class PdfGenerator
    {
        public static string works = Globais.workOrders;
        public static string slogo = Globais.images;

        public static void Create(WorkOrders works)
        {
            var workID = Interaction.InputBox("Informe o ID da ordem de serviço: ", "Gerar Arquivo em PDF");
            var dt = Database.GetDatasByWorkID(workID);


        }
    }
}
