using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Simple_Work_Order
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        public static string WorkID()
        {
            var workID = Interaction.InputBox("Informe o ID da Ordem de serviço para alterar: ", "Alterar Ordem de serviço");
            if (!string.IsNullOrEmpty(workID))
            {
                return workID;
            }
            else
            {
                return null;
            }
        }

        private bool TextValid()
        {
            if (txtBoxClient.Text == "" || txtBoxContact.Text == "" || txtBoxEquip.Text == "" || txtBoxWorkID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool DatasValid()
        {
            DataTable dt = new DataTable();
            dt = Database.Validation(txtBoxWorkID.Text);
            int result = dt.Rows.Count;
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
