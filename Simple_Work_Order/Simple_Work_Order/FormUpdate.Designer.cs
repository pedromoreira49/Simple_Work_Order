
namespace Simple_Work_Order
{
    partial class FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxWork = new System.Windows.Forms.TextBox();
            this.txtBoxContact = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxEquip = new System.Windows.Forms.TextBox();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.labelOsNumber = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtBoxWorkID = new System.Windows.Forms.TextBox();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPrice.Location = new System.Drawing.Point(14, 325);
            this.txtBoxPrice.Mask = "R$00000,00";
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(308, 29);
            this.txtBoxPrice.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Work:";
            // 
            // txtBoxWork
            // 
            this.txtBoxWork.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxWork.Location = new System.Drawing.Point(14, 266);
            this.txtBoxWork.Name = "txtBoxWork";
            this.txtBoxWork.Size = new System.Drawing.Size(308, 29);
            this.txtBoxWork.TabIndex = 51;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxContact.Location = new System.Drawing.Point(12, 150);
            this.txtBoxContact.Mask = "(00) 00000-0000";
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(310, 29);
            this.txtBoxContact.TabIndex = 50;
            // 
            // txtBoxEquip
            // 
            this.txtBoxEquip.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxEquip.Location = new System.Drawing.Point(14, 208);
            this.txtBoxEquip.Name = "txtBoxEquip";
            this.txtBoxEquip.Size = new System.Drawing.Size(308, 29);
            this.txtBoxEquip.TabIndex = 49;
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquipamento.Location = new System.Drawing.Point(12, 190);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(48, 16);
            this.labelEquipamento.TabIndex = 48;
            this.labelEquipamento.Text = "Equip: ";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(12, 132);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(56, 16);
            this.labelContato.TabIndex = 47;
            this.labelContato.Text = "Contact:";
            // 
            // labelOsNumber
            // 
            this.labelOsNumber.AutoSize = true;
            this.labelOsNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOsNumber.Location = new System.Drawing.Point(14, 71);
            this.labelOsNumber.Name = "labelOsNumber";
            this.labelOsNumber.Size = new System.Drawing.Size(58, 16);
            this.labelOsNumber.TabIndex = 46;
            this.labelOsNumber.Text = "Work ID:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(14, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 16);
            this.labelCliente.TabIndex = 45;
            this.labelCliente.Text = "Client:";
            // 
            // txtBoxWorkID
            // 
            this.txtBoxWorkID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxWorkID.Location = new System.Drawing.Point(14, 89);
            this.txtBoxWorkID.Name = "txtBoxWorkID";
            this.txtBoxWorkID.Size = new System.Drawing.Size(308, 29);
            this.txtBoxWorkID.TabIndex = 44;
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxClient.Location = new System.Drawing.Point(12, 31);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(310, 29);
            this.txtBoxClient.TabIndex = 43;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(177, 375);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(145, 47);
            this.btn_Cancel.TabIndex = 56;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirm.Location = new System.Drawing.Point(14, 375);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(145, 47);
            this.btn_Confirm.TabIndex = 55;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxWork);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.txtBoxEquip);
            this.Controls.Add(this.labelEquipamento);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelOsNumber);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtBoxWorkID);
            this.Controls.Add(this.txtBoxClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdate";
            this.ShowIcon = false;
            this.Text = "Update ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxWork;
        private System.Windows.Forms.MaskedTextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxEquip;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Label labelOsNumber;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtBoxWorkID;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
    }
}