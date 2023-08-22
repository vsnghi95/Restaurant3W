namespace frmManagement
{
    partial class frmTablee
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
            dgvTable = new System.Windows.Forms.DataGridView();
            btCancel = new System.Windows.Forms.Button();
            btUpdateTable = new System.Windows.Forms.Button();
            btAddTable = new System.Windows.Forms.Button();
            btDeleteTable = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new System.Drawing.Point(1, 169);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 51;
            dgvTable.RowTemplate.Height = 29;
            dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTable.Size = new System.Drawing.Size(507, 261);
            dgvTable.TabIndex = 0;
            dgvTable.CellContentClick += dgvTable_CellContentClick;
            dgvTable.CellDoubleClick += dgvTable_CellDoubleClick;
            // 
            // btCancel
            // 
            btCancel.Location = new System.Drawing.Point(374, 129);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(106, 34);
            btCancel.TabIndex = 1;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btUpdateTable
            // 
            btUpdateTable.Location = new System.Drawing.Point(150, 129);
            btUpdateTable.Name = "btUpdateTable";
            btUpdateTable.Size = new System.Drawing.Size(106, 34);
            btUpdateTable.TabIndex = 2;
            btUpdateTable.Text = "Update";
            btUpdateTable.UseVisualStyleBackColor = true;
            btUpdateTable.Click += btUpdateTable_Click;
            // 
            // btAddTable
            // 
            btAddTable.Location = new System.Drawing.Point(38, 129);
            btAddTable.Name = "btAddTable";
            btAddTable.Size = new System.Drawing.Size(106, 34);
            btAddTable.TabIndex = 3;
            btAddTable.Text = "New Table";
            btAddTable.UseVisualStyleBackColor = true;
            btAddTable.Click += btAddTable_Click;
            // 
            // btDeleteTable
            // 
            btDeleteTable.Location = new System.Drawing.Point(262, 129);
            btDeleteTable.Name = "btDeleteTable";
            btDeleteTable.Size = new System.Drawing.Size(106, 34);
            btDeleteTable.TabIndex = 4;
            btDeleteTable.Text = "Delete ";
            btDeleteTable.UseVisualStyleBackColor = true;
            btDeleteTable.Click += btDeleteTable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(126, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(272, 41);
            label1.TabIndex = 5;
            label1.Text = "Table Management";
            // 
            // frmTablee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(520, 469);
            Controls.Add(label1);
            Controls.Add(btDeleteTable);
            Controls.Add(btAddTable);
            Controls.Add(btUpdateTable);
            Controls.Add(btCancel);
            Controls.Add(dgvTable);
            Name = "frmTablee";
            Text = "frmTablee";
            Load += frmTablee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btUpdateTable;
        private System.Windows.Forms.Button btAddTable;
        private System.Windows.Forms.Button btDeleteTable;
        private System.Windows.Forms.Label label1;
    }
}