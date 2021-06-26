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
                var msgBox = MessageBox.Show("ID da ordem de serviço já em uso. Gostaria de manter esse ID?", "AVISO!");
                if(msgBox == DialogResult.OK)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (TextValid())
            {
                MessageBox.Show("Por favor, informe todos os campos necessários!");
                txtBoxClient.Focus();
                txtBoxContact.Focus();
                txtBoxEquip.Focus();
                txtBoxWorkID.Focus();
            }else if (DatasValid())
            {
                MessageBox.Show("ID da ordem de serviço já cadastrado!");
                txtBoxWorkID.Focus();
            }
            else
            {
                WorkOrders works = new WorkOrders();
                works.Client = txtBoxClient.Text.ToUpper();
                works.Contact = txtBoxContact.Text.ToUpper();
                works.Equip = txtBoxEquip.Text.ToUpper();
                works.WorkID = txtBoxWorkID.Text;
                works.Work = txtBoxWork.Text.ToUpper();
                works.Price = txtBoxPrice.Text;

                Database.UpdateDatas(works);

                Close();
            }
        }
    }
}
