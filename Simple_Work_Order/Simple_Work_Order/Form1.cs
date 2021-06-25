using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
