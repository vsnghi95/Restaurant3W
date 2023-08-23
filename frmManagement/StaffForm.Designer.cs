namespace frmManagement
{
    partial class StaffForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtNumG = new System.Windows.Forms.TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbbPrepay = new System.Windows.Forms.ComboBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtPrepay = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            dgvFood = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            btnComfirm = new System.Windows.Forms.Button();
            cbbFood = new System.Windows.Forms.ComboBox();
            btnReverse = new System.Windows.Forms.Button();
            txtStatus = new System.Windows.Forms.TextBox();
            txtStatus2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(258, 19);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(241, 32);
            label1.TabIndex = 0;
            label1.Text = "Customer Infomation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 98);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 186);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 269);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(332, 431);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(207, 32);
            label5.TabIndex = 4;
            label5.Text = "Order Infotmation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(908, 19);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(269, 32);
            label6.TabIndex = 5;
            label6.Text = "Reservation Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(674, 98);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(203, 32);
            label7.TabIndex = 6;
            label7.Text = "Number Of Guest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(674, 186);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(178, 32);
            label8.TabIndex = 7;
            label8.Text = "Prepay Method";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(674, 269);
            label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(151, 32);
            label9.TabIndex = 8;
            label9.Text = "Prepay Value";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(22, 585);
            label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(106, 32);
            label10.TabIndex = 10;
            label10.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(22, 497);
            label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(139, 32);
            label11.TabIndex = 9;
            label11.Text = "Food Name";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(121, 92);
            txtName.Margin = new System.Windows.Forms.Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(518, 39);
            txtName.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(121, 169);
            txtPhone.Margin = new System.Windows.Forms.Padding(6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(518, 39);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(121, 262);
            txtEmail.Margin = new System.Windows.Forms.Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(518, 39);
            txtEmail.TabIndex = 13;
            // 
            // txtNumG
            // 
            txtNumG.Location = new System.Drawing.Point(871, 98);
            txtNumG.Margin = new System.Windows.Forms.Padding(6);
            txtNumG.Name = "txtNumG";
            txtNumG.Size = new System.Drawing.Size(556, 39);
            txtNumG.TabIndex = 14;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // cbbPrepay
            // 
            cbbPrepay.FormattingEnabled = true;
            cbbPrepay.Location = new System.Drawing.Point(871, 179);
            cbbPrepay.Margin = new System.Windows.Forms.Padding(6);
            cbbPrepay.Name = "cbbPrepay";
            cbbPrepay.Size = new System.Drawing.Size(556, 40);
            cbbPrepay.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(871, 356);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(556, 39);
            dateTimePicker1.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(162, 578);
            txtQuantity.Margin = new System.Windows.Forms.Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(518, 39);
            txtQuantity.TabIndex = 18;
            // 
            // txtPrepay
            // 
            txtPrepay.Location = new System.Drawing.Point(871, 273);
            txtPrepay.Margin = new System.Windows.Forms.Padding(6);
            txtPrepay.Name = "txtPrepay";
            txtPrepay.Size = new System.Drawing.Size(556, 39);
            txtPrepay.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(674, 369);
            label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(134, 32);
            label12.TabIndex = 20;
            label12.Text = "Date Picker";
            // 
            // dgvFood
            // 
            dgvFood.AllowUserToAddRows = false;
            dgvFood.AllowUserToDeleteRows = false;
            dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new System.Drawing.Point(711, 491);
            dgvFood.Margin = new System.Windows.Forms.Padding(6);
            dgvFood.Name = "dgvFood";
            dgvFood.ReadOnly = true;
            dgvFood.RowHeadersWidth = 82;
            dgvFood.RowTemplate.Height = 25;
            dgvFood.Size = new System.Drawing.Size(719, 333);
            dgvFood.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(455, 640);
            button1.Margin = new System.Windows.Forms.Padding(6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(228, 49);
            button1.TabIndex = 22;
            button1.Text = "Add Food";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnComfirm
            // 
            btnComfirm.Location = new System.Drawing.Point(22, 820);
            btnComfirm.Margin = new System.Windows.Forms.Padding(6);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new System.Drawing.Size(139, 114);
            btnComfirm.TabIndex = 23;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // cbbFood
            // 
            cbbFood.FormattingEnabled = true;
            cbbFood.Location = new System.Drawing.Point(162, 494);
            cbbFood.Name = "cbbFood";
            cbbFood.Size = new System.Drawing.Size(518, 40);
            cbbFood.TabIndex = 24;
            // 
            // btnReverse
            // 
            btnReverse.Location = new System.Drawing.Point(22, 349);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new System.Drawing.Size(253, 46);
            btnReverse.TabIndex = 25;
            btnReverse.Text = "Add Reservation";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(339, 353);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(300, 39);
            txtStatus.TabIndex = 26;
            txtStatus.Text = "STATUS";
            // 
            // txtStatus2
            // 
            txtStatus2.Location = new System.Drawing.Point(339, 745);
            txtStatus2.Name = "txtStatus2";
            txtStatus2.Size = new System.Drawing.Size(344, 39);
            txtStatus2.TabIndex = 27;
            txtStatus2.Text = "No Food Have Been Order";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1486, 960);
            Controls.Add(txtStatus2);
            Controls.Add(txtStatus);
            Controls.Add(btnReverse);
            Controls.Add(cbbFood);
            Controls.Add(btnComfirm);
            Controls.Add(button1);
            Controls.Add(dgvFood);
            Controls.Add(label12);
            Controls.Add(txtPrepay);
            Controls.Add(txtQuantity);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbbPrepay);
            Controls.Add(txtNumG);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "StaffForm";
            Text = "StaffForm";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumG;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.ComboBox cbbPrepay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrepay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtStatus2;
    }
}