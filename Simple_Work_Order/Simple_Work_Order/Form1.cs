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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                Globais.CreatePaths();
                Database.CreateDatabase();
                Database.CreateTable();
                ShowDatas();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void ShowDatas()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = Database.GetWorks();
                dataGridWorksOrder.DataSource = dataTable;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message);
            }
        }

        private void Clear()
        {
            txtBoxClient.Clear();
            txtBoxContact.Clear();
            txtBoxEquip.Clear();
            txtBoxPrice.Clear();
            txtBoxWork.Clear();
            txtBoxWorkID.Clear();
        }

        private bool TextValid()
        {
            if(txtBoxClient.Text == "" || txtBoxContact.Text == "" || txtBoxEquip.Text == "" || txtBoxWorkID.Text == "")
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
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (!TextValid())
            {
                MessageBox.Show("Por favor, informe os campos necessários!");
                txtBoxClient.Focus();
                txtBoxContact.Focus();
                txtBoxEquip.Focus();
                txtBoxWorkID.Focus();
            }else if(DatasValid()){
                MessageBox.Show("O ID da Ordem de Serviço já foi Registrada!");
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
                works.DateIn = DateTime.Now.ToString();

                Database.Register(works);
                ShowDatas();
                Clear();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowDatas();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var client = Interaction.InputBox("Informe o nome do Cliente:", "Pesquisar pelo nome do Cliente");

            if (!string.IsNullOrEmpty(client))
            {
                dt = Database.SearchDatas(client);
                dataGridWorksOrder.DataSource = dt;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var WorkID = Interaction.InputBox("Informe o ID da Ordem de serviço que será deletada: ", "Deletar Ordem de Serviço");
            if (!string.IsNullOrEmpty(WorkID))
            {
                Database.Delete(WorkID);
            }
        }

        private void bnt_Print_Click(object sender, EventArgs e)
        {
            WorkOrders works = new WorkOrders();
            PdfGenerator.Create(works);
        }
    }
}
