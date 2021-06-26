using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 20, 20);

            string id = workID;

            string path = $@"{works}" + $"WorkOrder{id}.pdf";

            if (!File.Exists(path))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

                doc.Open();

                string s_img_logo = $@"{slogo}sua-logo-aqui";
                Image img = Image.GetInstance(s_img_logo);
                img.ScaleAbsolute(img);
                img.Alignment = Element.ALIGN_CENTER;
                doc.Add(img);
            }
        }
    }
}
