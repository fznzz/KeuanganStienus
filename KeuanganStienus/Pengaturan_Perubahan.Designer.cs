
namespace KeuanganStienus
{
    partial class Pengaturan_Perubahan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pengaturan_Perubahan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtHistori = new System.Windows.Forms.DataGridView();
            this.btExport6 = new System.Windows.Forms.Button();
            this.btExportAll = new System.Windows.Forms.Button();
            this.btConn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistori)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 72);
            this.panel2.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(20, 10);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(62, 56);
            this.btBack.TabIndex = 0;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(522, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Histori Perubahan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtHistori
            // 
            this.dtHistori.AllowUserToAddRows = false;
            this.dtHistori.AllowUserToDeleteRows = false;
            this.dtHistori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHistori.BackgroundColor = System.Drawing.Color.White;
            this.dtHistori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(219)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtHistori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistori.Location = new System.Drawing.Point(12, 120);
            this.dtHistori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHistori.Name = "dtHistori";
            this.dtHistori.ReadOnly = true;
            this.dtHistori.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistori.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtHistori.RowTemplate.Height = 28;
            this.dtHistori.Size = new System.Drawing.Size(1036, 502);
            this.dtHistori.TabIndex = 4;
            // 
            // btExport6
            // 
            this.btExport6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExport6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btExport6.FlatAppearance.BorderSize = 0;
            this.btExport6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExport6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport6.ForeColor = System.Drawing.Color.White;
            this.btExport6.Location = new System.Drawing.Point(516, 76);
            this.btExport6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExport6.Name = "btExport6";
            this.btExport6.Size = new System.Drawing.Size(250, 34);
            this.btExport6.TabIndex = 10;
            this.btExport6.Text = "Ekspor ke Excel (6 Bulan)";
            this.btExport6.UseVisualStyleBackColor = false;
            this.btExport6.Click += new System.EventHandler(this.btExport6_Click);
            // 
            // btExportAll
            // 
            this.btExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btExportAll.FlatAppearance.BorderSize = 0;
            this.btExportAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportAll.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportAll.ForeColor = System.Drawing.Color.White;
            this.btExportAll.Location = new System.Drawing.Point(772, 76);
            this.btExportAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExportAll.Name = "btExportAll";
            this.btExportAll.Size = new System.Drawing.Size(170, 34);
            this.btExportAll.TabIndex = 9;
            this.btExportAll.Text = "Ekspor ke Excel";
            this.btExportAll.UseVisualStyleBackColor = false;
            this.btExportAll.Click += new System.EventHandler(this.btExportAll_Click);
            // 
            // btConn
            // 
            this.btConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btConn.FlatAppearance.BorderSize = 0;
            this.btConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConn.ForeColor = System.Drawing.Color.White;
            this.btConn.Location = new System.Drawing.Point(948, 76);
            this.btConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(100, 34);
            this.btConn.TabIndex = 8;
            this.btConn.Text = "Refresh";
            this.btConn.UseVisualStyleBackColor = false;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // Pengaturan_Perubahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.btExport6);
            this.Controls.Add(this.btExportAll);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.dtHistori);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pengaturan_Perubahan";
            this.Text = "EditTagihan_Perubahan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHistori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtHistori;
        private System.Windows.Forms.Button btExport6;
        private System.Windows.Forms.Button btExportAll;
        private System.Windows.Forms.Button btConn;
    }
}