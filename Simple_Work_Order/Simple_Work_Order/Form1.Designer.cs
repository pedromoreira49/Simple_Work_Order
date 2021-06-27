
namespace Simple_Work_Order
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxWork = new System.Windows.Forms.TextBox();
            this.bnt_Print = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txtBoxContact = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEquip = new System.Windows.Forms.TextBox();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.labelOsNumber = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtBoxWorkID = new System.Windows.Forms.TextBox();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.dataGridWorksOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorksOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPrice.Location = new System.Drawing.Point(475, 90);
            this.txtBoxPrice.Mask = "R$00000,00";
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(207, 29);
            this.txtBoxPrice.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(477, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(477, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Work:";
            // 
            // txtBoxWork
            // 
            this.txtBoxWork.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxWork.Location = new System.Drawing.Point(475, 31);
            this.txtBoxWork.Name = "txtBoxWork";
            this.txtBoxWork.Size = new System.Drawing.Size(207, 29);
            this.txtBoxWork.TabIndex = 39;
            // 
            // bnt_Print
            // 
            this.bnt_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bnt_Print.ForeColor = System.Drawing.Color.Black;
            this.bnt_Print.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Print.Image")));
            this.bnt_Print.Location = new System.Drawing.Point(727, 71);
            this.bnt_Print.Name = "bnt_Print";
            this.bnt_Print.Size = new System.Drawing.Size(61, 47);
            this.bnt_Print.TabIndex = 38;
            this.bnt_Print.UseVisualStyleBackColor = false;
            this.bnt_Print.Click += new System.EventHandler(this.bnt_Print_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(727, 13);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(61, 47);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(519, 134);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(163, 47);
            this.btn_Update.TabIndex = 36;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(350, 134);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(163, 47);
            this.btn_Refresh.TabIndex = 35;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(181, 134);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(163, 47);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Register.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.Location = new System.Drawing.Point(12, 134);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(163, 47);
            this.btn_Register.TabIndex = 33;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxContact.Location = new System.Drawing.Point(246, 31);
            this.txtBoxContact.Mask = "(00) 00000-0000";
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(207, 29);
            this.txtBoxContact.TabIndex = 32;
            // 
            // txtBoxEquip
            // 
            this.txtBoxEquip.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxEquip.Location = new System.Drawing.Point(248, 89);
            this.txtBoxEquip.Name = "txtBoxEquip";
            this.txtBoxEquip.Size = new System.Drawing.Size(205, 29);
            this.txtBoxEquip.TabIndex = 31;
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquipamento.Location = new System.Drawing.Point(246, 71);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(48, 16);
            this.labelEquipamento.TabIndex = 30;
            this.labelEquipamento.Text = "Equip: ";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(246, 13);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(56, 16);
            this.labelContato.TabIndex = 29;
            this.labelContato.Text = "Contact:";
            // 
            // labelOsNumber
            // 
            this.labelOsNumber.AutoSize = true;
            this.labelOsNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOsNumber.Location = new System.Drawing.Point(14, 71);
            this.labelOsNumber.Name = "labelOsNumber";
            this.labelOsNumber.Size = new System.Drawing.Size(58, 16);
            this.labelOsNumber.TabIndex = 28;
            this.labelOsNumber.Text = "Work ID:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(14, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 16);
            this.labelCliente.TabIndex = 27;
            this.labelCliente.Text = "Client:";
            // 
            // txtBoxWorkID
            // 
            this.txtBoxWorkID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxWorkID.Location = new System.Drawing.Point(14, 89);
            this.txtBoxWorkID.Name = "txtBoxWorkID";
            this.txtBoxWorkID.Size = new System.Drawing.Size(205, 29);
            this.txtBoxWorkID.TabIndex = 26;
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxClient.Location = new System.Drawing.Point(12, 31);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(207, 29);
            this.txtBoxClient.TabIndex = 25;
            // 
            // dataGridWorksOrder
            // 
            this.dataGridWorksOrder.AllowUserToAddRows = false;
            this.dataGridWorksOrder.AllowUserToDeleteRows = false;
            this.dataGridWorksOrder.AllowUserToResizeColumns = false;
            this.dataGridWorksOrder.AllowUserToResizeRows = false;
            this.dataGridWorksOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorksOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridWorksOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorksOrder.Location = new System.Drawing.Point(12, 218);
            this.dataGridWorksOrder.Name = "dataGridWorksOrder";
            this.dataGridWorksOrder.ReadOnly = true;
            this.dataGridWorksOrder.RowHeadersVisible = false;
            this.dataGridWorksOrder.RowTemplate.Height = 25;
            this.dataGridWorksOrder.Size = new System.Drawing.Size(776, 220);
            this.dataGridWorksOrder.TabIndex = 24;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxWork);
            this.Controls.Add(this.bnt_Print);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.txtBoxEquip);
            this.Controls.Add(this.labelEquipamento);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelOsNumber);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtBoxWorkID);
            this.Controls.Add(this.txtBoxClient);
            this.Controls.Add(this.dataGridWorksOrder);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Simple Work Order";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorksOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxWork;
        private System.Windows.Forms.Button bnt_Print;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.MaskedTextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxEquip;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Label labelOsNumber;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtBoxWorkID;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.DataGridView dataGridWorksOrder;
    }
}

