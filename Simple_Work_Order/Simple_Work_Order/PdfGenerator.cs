using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Simple_Work_Order
{
    class PdfGenerator
    {
        public static string worksDir = Globais.workorders;
        public static string slogo = Globais.images;

        public static void Create(WorkOrders works)
        {
            var workID = Interaction.InputBox("Informe o ID da ordem de serviço: ", "Gerar Arquivo em PDF");
            var dt = Database.GetDatasByWorkID(workID);

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 20, 20);

            string id = workID;

            string path = $@"{worksDir}" + $"WorkOrder{id}.pdf";

            if (!File.Exists(path))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

                doc.Open();

                string s_img_logo = $@"{slogo}minha-logo.png";
                Image img = Image.GetInstance(s_img_logo);
                img.ScaleAbsolute(130, 130);
                img.Alignment = Element.ALIGN_CENTER;
                doc.Add(img);

                Paragraph space = new Paragraph();
                space.Add("\n\n");
                doc.Add(space);

                PdfPTable table = new PdfPTable(2);
                table.AddCell($"Client: {dt.Rows[0].Field<string>("Client")}");
                table.AddCell($"Contact: {dt.Rows[0].Field<string>("Contact")}");
                table.AddCell($"Date In: {dt.Rows[0].Field<string>("DateIn")}");
                table.AddCell($"Work ID: {dt.Rows[0].Field<string>("WorkID")}");

                doc.Add(table);
                doc.Add(space);

                Paragraph equip = new Paragraph();
                equip.Font = new Font(Font.FontFamily.COURIER, 14);
                equip.Alignment = Element.ALIGN_CENTER;
                equip.Add($"\n\nEquipament: {dt.Rows[0].Field<string>("Equip")}");
                doc.Add(equip);

                doc.Add(space);

                PdfPTable work = new PdfPTable(1);
                work.AddCell("Work:");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");
                work.AddCell("+");

                doc.Add(work);

                Paragraph price = new Paragraph();
                price.Font = new Font(Font.FontFamily.COURIER, 14);
                price.Alignment = Element.ALIGN_CENTER;
                price.Add($"Price: {dt.Rows[0].Field<string>("Price")}");

                doc.Add(price);

                Paragraph line = new Paragraph();
                string content = "\n\n___________________                                ___________________";
                line.Add(content);

                Paragraph assn = new Paragraph();
                string content2 = "Ass. Cliente                                       Ass. Funcionário";
                assn.Add(content2);

                doc.Add(line);
                doc.Add(assn);

                doc.Close();
                MessageBox.Show("Ordem de serviço criada com sucesso!");
            }
            else
            {
                MessageBox.Show("Ordem de serviço já foi impressa!");
            }
        }
    }
}
