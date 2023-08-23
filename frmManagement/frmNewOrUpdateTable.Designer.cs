namespace frmManagement
{
    partial class frmNewOrUpdateTable
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
            components = new System.ComponentModel.Container();
            txtTableID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtTableName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtCapacity = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtStatus = new System.Windows.Forms.TextBox();
            btInsertorUpdate = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtTableID
            // 
            txtTableID.Location = new System.Drawing.Point(122, 92);
            txtTableID.Name = "txtTableID";
            txtTableID.Size = new System.Drawing.Size(225, 27);
            txtTableID.TabIndex = 0;
            txtTableID.Validating += txtTableID_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(20, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Table ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(20, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 3;
            label2.Text = "Table Name";
            // 
            // txtTableName
            // 
            txtTableName.Location = new System.Drawing.Point(122, 150);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new System.Drawing.Size(225, 27);
            txtTableName.TabIndex = 2;
            txtTableName.Validating += txtTableName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(20, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "Capacity ";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new System.Drawing.Point(122, 205);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new System.Drawing.Size(225, 27);
            txtCapacity.TabIndex = 4;
            txtCapacity.Validating += txtCapacity_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(20, 260);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 25);
            label4.TabIndex = 7;
            label4.Text = "Status ";
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(122, 258);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(225, 27);
            txtStatus.TabIndex = 6;
            txtStatus.Validating += txtStatus_Validating;
            // 
            // btInsertorUpdate
            // 
            btInsertorUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            btInsertorUpdate.Location = new System.Drawing.Point(157, 320);
            btInsertorUpdate.Name = "btInsertorUpdate";
            btInsertorUpdate.Size = new System.Drawing.Size(122, 47);
            btInsertorUpdate.TabIndex = 8;
            btInsertorUpdate.Text = "Insert";
            btInsertorUpdate.UseVisualStyleBackColor = false;
            btInsertorUpdate.Click += btInsertorUpdate_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmNewOrUpdateTable
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PowderBlue;
            ClientSize = new System.Drawing.Size(373, 450);
            Controls.Add(btInsertorUpdate);
            Controls.Add(label4);
            Controls.Add(txtStatus);
            Controls.Add(label3);
            Controls.Add(txtCapacity);
            Controls.Add(label2);
            Controls.Add(txtTableName);
            Controls.Add(label1);
            Controls.Add(txtTableID);
            Name = "frmNewOrUpdateTable";
            Text = "frmNewOrUpdateTable";
            Load += frmNewOrUpdateTable_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btInsertorUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}