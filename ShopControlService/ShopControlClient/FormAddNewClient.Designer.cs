namespace ShopControlClient
{
    partial class FormAddNewClient
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
            this.label1AddClient = new System.Windows.Forms.Label();
            this.label2AddClient = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDescripton = new System.Windows.Forms.TextBox();
            this.label3AddClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerAddClient = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTotalSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1AddClient
            // 
            this.label1AddClient.AutoSize = true;
            this.label1AddClient.Location = new System.Drawing.Point(13, 13);
            this.label1AddClient.Name = "label1AddClient";
            this.label1AddClient.Size = new System.Drawing.Size(388, 26);
            this.label1AddClient.TabIndex = 0;
            this.label1AddClient.Text = "Регистрация постоянных клиентов магазина, удобно для предоставления \r\nскидки при " +
    "покупке:";
            // 
            // label2AddClient
            // 
            this.label2AddClient.AutoSize = true;
            this.label2AddClient.Location = new System.Drawing.Point(12, 53);
            this.label2AddClient.Name = "label2AddClient";
            this.label2AddClient.Size = new System.Drawing.Size(132, 13);
            this.label2AddClient.TabIndex = 1;
            this.label2AddClient.Text = "Имя покупателя (ФИО) :";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 69);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(381, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxDescripton
            // 
            this.txtBoxDescripton.Location = new System.Drawing.Point(12, 116);
            this.txtBoxDescripton.Multiline = true;
            this.txtBoxDescripton.Name = "txtBoxDescripton";
            this.txtBoxDescripton.Size = new System.Drawing.Size(381, 60);
            this.txtBoxDescripton.TabIndex = 4;
            // 
            // label3AddClient
            // 
            this.label3AddClient.AutoSize = true;
            this.label3AddClient.Location = new System.Drawing.Point(12, 100);
            this.label3AddClient.Name = "label3AddClient";
            this.label3AddClient.Size = new System.Drawing.Size(73, 13);
            this.label3AddClient.TabIndex = 3;
            this.label3AddClient.Text = "Примечание:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dateTimePickerAddClient);
            this.panel1.Controls.Add(this.txtBoxPhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBoxTotalSum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxCardNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 153);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePickerAddClient
            // 
            this.dateTimePickerAddClient.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerAddClient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddClient.Location = new System.Drawing.Point(191, 93);
            this.dateTimePickerAddClient.Name = "dateTimePickerAddClient";
            this.dateTimePickerAddClient.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerAddClient.TabIndex = 10;
            this.dateTimePickerAddClient.Value = new System.DateTime(2017, 2, 8, 18, 7, 44, 0);
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(191, 67);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(178, 20);
            this.txtBoxPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона:";
            // 
            // txtBoxTotalSum
            // 
            this.txtBoxTotalSum.Location = new System.Drawing.Point(191, 119);
            this.txtBoxTotalSum.Name = "txtBoxTotalSum";
            this.txtBoxTotalSum.Size = new System.Drawing.Size(178, 20);
            this.txtBoxTotalSum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Общая сумма покупок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения:";
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Location = new System.Drawing.Point(191, 41);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(178, 20);
            this.txtBoxCardNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер карты:";
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Location = new System.Drawing.Point(191, 15);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(178, 20);
            this.txtBoxDiscount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скидка при покупке (%):";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(236, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 378);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxDescripton);
            this.Controls.Add(this.label3AddClient);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label2AddClient);
            this.Controls.Add(this.label1AddClient);
            this.MaximizeBox = false;
            this.Name = "FormAddNewClient";
            this.Text = "Добавление нового клиента";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNewClient_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1AddClient;
        private System.Windows.Forms.Label label2AddClient;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDescripton;
        private System.Windows.Forms.Label label3AddClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddClient;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTotalSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}