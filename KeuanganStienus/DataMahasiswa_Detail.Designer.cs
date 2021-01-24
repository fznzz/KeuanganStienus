
namespace KeuanganStienus
{
    partial class DataMahasiswa_Detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMahasiswa_Detail));
            this.dtMahasiswa = new System.Windows.Forms.DataGridView();
            this.lbNim = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbJurusan = new System.Windows.Forms.Label();
            this.lbKelas = new System.Windows.Forms.Label();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbJurusan = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            this.btTagihan = new System.Windows.Forms.Button();
            this.btPembayaran = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMahasiswa
            // 
            this.dtMahasiswa.AllowUserToAddRows = false;
            this.dtMahasiswa.AllowUserToDeleteRows = false;
            this.dtMahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMahasiswa.BackgroundColor = System.Drawing.Color.White;
            this.dtMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(219)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMahasiswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(174)))), ((int)(((byte)(204)))));
            this.dtMahasiswa.Location = new System.Drawing.Point(12, 192);
            this.dtMahasiswa.Name = "dtMahasiswa";
            this.dtMahasiswa.ReadOnly = true;
            this.dtMahasiswa.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMahasiswa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtMahasiswa.RowTemplate.Height = 28;
            this.dtMahasiswa.Size = new System.Drawing.Size(1004, 407);
            this.dtMahasiswa.TabIndex = 2;
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNim.Location = new System.Drawing.Point(19, 105);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(48, 24);
            this.lbNim.TabIndex = 1;
            this.lbNim.Text = "NIM";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(19, 142);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(62, 24);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama";
            // 
            // lbJurusan
            // 
            this.lbJurusan.AutoSize = true;
            this.lbJurusan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJurusan.Location = new System.Drawing.Point(373, 105);
            this.lbJurusan.Name = "lbJurusan";
            this.lbJurusan.Size = new System.Drawing.Size(75, 24);
            this.lbJurusan.TabIndex = 3;
            this.lbJurusan.Text = "Jurusan";
            // 
            // lbKelas
            // 
            this.lbKelas.AutoSize = true;
            this.lbKelas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKelas.Location = new System.Drawing.Point(373, 142);
            this.lbKelas.Name = "lbKelas";
            this.lbKelas.Size = new System.Drawing.Size(54, 24);
            this.lbKelas.TabIndex = 4;
            this.lbKelas.Text = "Kelas";
            // 
            // tbNim
            // 
            this.tbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNim.Location = new System.Drawing.Point(119, 102);
            this.tbNim.Name = "tbNim";
            this.tbNim.ReadOnly = true;
            this.tbNim.Size = new System.Drawing.Size(248, 31);
            this.tbNim.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(119, 139);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(248, 31);
            this.tbNama.TabIndex = 6;
            // 
            // tbJurusan
            // 
            this.tbJurusan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJurusan.Location = new System.Drawing.Point(473, 102);
            this.tbJurusan.Name = "tbJurusan";
            this.tbJurusan.ReadOnly = true;
            this.tbJurusan.Size = new System.Drawing.Size(248, 31);
            this.tbJurusan.TabIndex = 7;
            // 
            // tbKelas
            // 
            this.tbKelas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKelas.Location = new System.Drawing.Point(473, 139);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.ReadOnly = true;
            this.tbKelas.Size = new System.Drawing.Size(248, 31);
            this.tbKelas.TabIndex = 8;
            // 
            // btTagihan
            // 
            this.btTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btTagihan.FlatAppearance.BorderSize = 0;
            this.btTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTagihan.ForeColor = System.Drawing.Color.White;
            this.btTagihan.Location = new System.Drawing.Point(736, 102);
            this.btTagihan.Name = "btTagihan";
            this.btTagihan.Size = new System.Drawing.Size(137, 68);
            this.btTagihan.TabIndex = 0;
            this.btTagihan.Text = "Tagihan Aktif";
            this.btTagihan.UseVisualStyleBackColor = false;
            this.btTagihan.Click += new System.EventHandler(this.btTagihan_Click);
            // 
            // btPembayaran
            // 
            this.btPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btPembayaran.FlatAppearance.BorderSize = 0;
            this.btPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPembayaran.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPembayaran.ForeColor = System.Drawing.Color.White;
            this.btPembayaran.Location = new System.Drawing.Point(879, 102);
            this.btPembayaran.Name = "btPembayaran";
            this.btPembayaran.Size = new System.Drawing.Size(137, 68);
            this.btPembayaran.TabIndex = 1;
            this.btPembayaran.Text = "Histori Pembayaran";
            this.btPembayaran.UseVisualStyleBackColor = false;
            this.btPembayaran.Click += new System.EventHandler(this.btPembayaran_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 90);
            this.panel2.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(23, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(70, 70);
            this.btBack.TabIndex = 0;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 52);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Mahasiswa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataMahasiswa_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btPembayaran);
            this.Controls.Add(this.btTagihan);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tbJurusan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.lbKelas);
            this.Controls.Add(this.lbJurusan);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNim);
            this.Controls.Add(this.dtMahasiswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataMahasiswa_Detail";
            this.ShowIcon = false;
            this.Text = "Data Mahasiswa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dataMahasiswa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMahasiswa;
        private System.Windows.Forms.Label lbNim;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbJurusan;
        private System.Windows.Forms.Label lbKelas;
        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbJurusan;
        private System.Windows.Forms.TextBox tbKelas;
        private System.Windows.Forms.Button btTagihan;
        private System.Windows.Forms.Button btPembayaran;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label6;
    }
}