
namespace KeuanganStienus
{
    partial class EditTagihan_HistoriPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTagihan_HistoriPembayaran));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btConn = new System.Windows.Forms.Button();
            this.btExportAll = new System.Windows.Forms.Button();
            this.btExport6 = new System.Windows.Forms.Button();
            this.dtHistori = new System.Windows.Forms.DataGridView();
            this.btListPembayaran = new System.Windows.Forms.Button();
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
            this.panel2.TabIndex = 4;
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
            this.label6.Location = new System.Drawing.Point(300, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Histori Pembayaran";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConn
            // 
            this.btConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btConn.FlatAppearance.BorderSize = 0;
            this.btConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConn.ForeColor = System.Drawing.Color.White;
            this.btConn.Location = new System.Drawing.Point(946, 76);
            this.btConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(100, 34);
            this.btConn.TabIndex = 5;
            this.btConn.Text = "Refresh";
            this.btConn.UseVisualStyleBackColor = false;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btExportAll
            // 
            this.btExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btExportAll.FlatAppearance.BorderSize = 0;
            this.btExportAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportAll.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportAll.ForeColor = System.Drawing.Color.White;
            this.btExportAll.Location = new System.Drawing.Point(770, 76);
            this.btExportAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExportAll.Name = "btExportAll";
            this.btExportAll.Size = new System.Drawing.Size(170, 34);
            this.btExportAll.TabIndex = 6;
            this.btExportAll.Text = "Ekspor ke Excel";
            this.btExportAll.UseVisualStyleBackColor = false;
            this.btExportAll.Click += new System.EventHandler(this.btExportAll_Click);
            // 
            // btExport6
            // 
            this.btExport6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExport6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btExport6.FlatAppearance.BorderSize = 0;
            this.btExport6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExport6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExport6.ForeColor = System.Drawing.Color.White;
            this.btExport6.Location = new System.Drawing.Point(514, 76);
            this.btExport6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExport6.Name = "btExport6";
            this.btExport6.Size = new System.Drawing.Size(250, 34);
            this.btExport6.TabIndex = 7;
            this.btExport6.Text = "Ekspor ke Excel (6 Bulan)";
            this.btExport6.UseVisualStyleBackColor = false;
            this.btExport6.Click += new System.EventHandler(this.btExport6_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(219)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtHistori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistori.Location = new System.Drawing.Point(12, 126);
            this.dtHistori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHistori.Name = "dtHistori";
            this.dtHistori.ReadOnly = true;
            this.dtHistori.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistori.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtHistori.RowTemplate.Height = 28;
            this.dtHistori.Size = new System.Drawing.Size(1034, 496);
            this.dtHistori.TabIndex = 8;
            // 
            // btListPembayaran
            // 
            this.btListPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListPembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btListPembayaran.FlatAppearance.BorderSize = 0;
            this.btListPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListPembayaran.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListPembayaran.ForeColor = System.Drawing.Color.White;
            this.btListPembayaran.Location = new System.Drawing.Point(289, 76);
            this.btListPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btListPembayaran.Name = "btListPembayaran";
            this.btListPembayaran.Size = new System.Drawing.Size(219, 34);
            this.btListPembayaran.TabIndex = 9;
            this.btListPembayaran.Text = "Pembayaran Individu";
            this.btListPembayaran.UseVisualStyleBackColor = false;
            this.btListPembayaran.Click += new System.EventHandler(this.btListPembayaran_Click);
            // 
            // EditTagihan_HistoriPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.btListPembayaran);
            this.Controls.Add(this.dtHistori);
            this.Controls.Add(this.btExport6);
            this.Controls.Add(this.btExportAll);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTagihan_HistoriPembayaran";
            this.Text = "EditTagihan_Pembayaran";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHistori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btExportAll;
        private System.Windows.Forms.Button btExport6;
        private System.Windows.Forms.DataGridView dtHistori;
        private System.Windows.Forms.Button btListPembayaran;
    }
}