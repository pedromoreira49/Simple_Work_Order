
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
            this.txtBoxValue = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxObservations = new System.Windows.Forms.TextBox();
            this.bnt_Imprimir = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txtBoxContato = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEquipamento = new System.Windows.Forms.TextBox();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.labelOsNumber = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtBoxOsNumber = new System.Windows.Forms.TextBox();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.dataGridFservices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFservices)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxValue.Location = new System.Drawing.Point(475, 90);
            this.txtBoxValue.Mask = "R$00000,00";
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.Size = new System.Drawing.Size(207, 29);
            this.txtBoxValue.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(477, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Orçamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(477, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Observações:";
            // 
            // txtBoxObservations
            // 
            this.txtBoxObservations.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxObservations.Location = new System.Drawing.Point(475, 31);
            this.txtBoxObservations.Name = "txtBoxObservations";
            this.txtBoxObservations.Size = new System.Drawing.Size(207, 29);
            this.txtBoxObservations.TabIndex = 39;
            // 
            // bnt_Imprimir
            // 
            this.bnt_Imprimir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bnt_Imprimir.ForeColor = System.Drawing.Color.Black;
            this.bnt_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Imprimir.Image")));
            this.bnt_Imprimir.Location = new System.Drawing.Point(727, 71);
            this.bnt_Imprimir.Name = "bnt_Imprimir";
            this.bnt_Imprimir.Size = new System.Drawing.Size(61, 47);
            this.bnt_Imprimir.TabIndex = 38;
            this.bnt_Imprimir.UseVisualStyleBackColor = false;
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
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(519, 134);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(163, 47);
            this.btn_Update.TabIndex = 36;
            this.btn_Update.Text = "Alterar Dados";
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
            this.btn_Refresh.Text = "Atualizar dados";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(181, 134);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(163, 47);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Pesquisar";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 134);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(163, 47);
            this.btn_Cadastrar.TabIndex = 33;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            // 
            // txtBoxContato
            // 
            this.txtBoxContato.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxContato.Location = new System.Drawing.Point(246, 31);
            this.txtBoxContato.Mask = "(00) 00000-0000";
            this.txtBoxContato.Name = "txtBoxContato";
            this.txtBoxContato.Size = new System.Drawing.Size(207, 29);
            this.txtBoxContato.TabIndex = 32;
            // 
            // txtBoxEquipamento
            // 
            this.txtBoxEquipamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxEquipamento.Location = new System.Drawing.Point(248, 89);
            this.txtBoxEquipamento.Name = "txtBoxEquipamento";
            this.txtBoxEquipamento.Size = new System.Drawing.Size(205, 29);
            this.txtBoxEquipamento.TabIndex = 31;
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquipamento.Location = new System.Drawing.Point(246, 71);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(87, 16);
            this.labelEquipamento.TabIndex = 30;
            this.labelEquipamento.Text = "Equipamento:";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(246, 13);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(56, 16);
            this.labelContato.TabIndex = 29;
            this.labelContato.Text = "Contato:";
            // 
            // labelOsNumber
            // 
            this.labelOsNumber.AutoSize = true;
            this.labelOsNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOsNumber.Location = new System.Drawing.Point(14, 71);
            this.labelOsNumber.Name = "labelOsNumber";
            this.labelOsNumber.Size = new System.Drawing.Size(114, 16);
            this.labelOsNumber.TabIndex = 28;
            this.labelOsNumber.Text = "Ordem de Serviço:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(14, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(51, 16);
            this.labelCliente.TabIndex = 27;
            this.labelCliente.Text = "Cliente:";
            // 
            // txtBoxOsNumber
            // 
            this.txtBoxOsNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxOsNumber.Location = new System.Drawing.Point(14, 89);
            this.txtBoxOsNumber.Name = "txtBoxOsNumber";
            this.txtBoxOsNumber.Size = new System.Drawing.Size(205, 29);
            this.txtBoxOsNumber.TabIndex = 26;
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCliente.Location = new System.Drawing.Point(12, 31);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(207, 29);
            this.txtBoxCliente.TabIndex = 25;
            // 
            // dataGridFservices
            // 
            this.dataGridFservices.AllowUserToAddRows = false;
            this.dataGridFservices.AllowUserToDeleteRows = false;
            this.dataGridFservices.AllowUserToResizeColumns = false;
            this.dataGridFservices.AllowUserToResizeRows = false;
            this.dataGridFservices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFservices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridFservices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFservices.Location = new System.Drawing.Point(12, 218);
            this.dataGridFservices.Name = "dataGridFservices";
            this.dataGridFservices.ReadOnly = true;
            this.dataGridFservices.RowHeadersVisible = false;
            this.dataGridFservices.RowTemplate.Height = 25;
            this.dataGridFservices.Size = new System.Drawing.Size(776, 220);
            this.dataGridFservices.TabIndex = 24;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxObservations);
            this.Controls.Add(this.bnt_Imprimir);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txtBoxContato);
            this.Controls.Add(this.txtBoxEquipamento);
            this.Controls.Add(this.labelEquipamento);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelOsNumber);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtBoxOsNumber);
            this.Controls.Add(this.txtBoxCliente);
            this.Controls.Add(this.dataGridFservices);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Simple Work Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFservices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxObservations;
        private System.Windows.Forms.Button bnt_Imprimir;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox txtBoxContato;
        private System.Windows.Forms.TextBox txtBoxEquipamento;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Label labelOsNumber;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtBoxOsNumber;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.DataGridView dataGridFservices;
    }
}

