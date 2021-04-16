
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
            this.btEdit = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
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
            this.dtMahasiswa.Location = new System.Drawing.Point(11, 154);
            this.dtMahasiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dtMahasiswa.Size = new System.Drawing.Size(1036, 470);
            this.dtMahasiswa.TabIndex = 0;
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNim.Location = new System.Drawing.Point(17, 84);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(40, 20);
            this.lbNim.TabIndex = 1;
            this.lbNim.Text = "NIM";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(17, 114);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(51, 20);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama";
            // 
            // lbJurusan
            // 
            this.lbJurusan.AutoSize = true;
            this.lbJurusan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJurusan.Location = new System.Drawing.Point(289, 85);
            this.lbJurusan.Name = "lbJurusan";
            this.lbJurusan.Size = new System.Drawing.Size(63, 20);
            this.lbJurusan.TabIndex = 3;
            this.lbJurusan.Text = "Jurusan";
            // 
            // lbKelas
            // 
            this.lbKelas.AutoSize = true;
            this.lbKelas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKelas.Location = new System.Drawing.Point(289, 115);
            this.lbKelas.Name = "lbKelas";
            this.lbKelas.Size = new System.Drawing.Size(47, 20);
            this.lbKelas.TabIndex = 4;
            this.lbKelas.Text = "Kelas";
            // 
            // tbNim
            // 
            this.tbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNim.Location = new System.Drawing.Point(74, 82);
            this.tbNim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNim.Name = "tbNim";
            this.tbNim.ReadOnly = true;
            this.tbNim.Size = new System.Drawing.Size(209, 27);
            this.tbNim.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(74, 111);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(209, 27);
            this.tbNama.TabIndex = 6;
            // 
            // tbJurusan
            // 
            this.tbJurusan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJurusan.Location = new System.Drawing.Point(358, 83);
            this.tbJurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbJurusan.Name = "tbJurusan";
            this.tbJurusan.ReadOnly = true;
            this.tbJurusan.Size = new System.Drawing.Size(154, 27);
            this.tbJurusan.TabIndex = 7;
            // 
            // tbKelas
            // 
            this.tbKelas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKelas.Location = new System.Drawing.Point(358, 112);
            this.tbKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.ReadOnly = true;
            this.tbKelas.Size = new System.Drawing.Size(154, 27);
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
            this.btTagihan.Location = new System.Drawing.Point(799, 82);
            this.btTagihan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTagihan.Name = "btTagihan";
            this.btTagihan.Size = new System.Drawing.Size(120, 57);
            this.btTagihan.TabIndex = 3;
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
            this.btPembayaran.Location = new System.Drawing.Point(925, 82);
            this.btPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPembayaran.Name = "btPembayaran";
            this.btPembayaran.Size = new System.Drawing.Size(121, 57);
            this.btPembayaran.TabIndex = 4;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 72);
            this.panel2.TabIndex = 5;
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
            this.label6.Location = new System.Drawing.Point(300, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Mahasiswa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(672, 82);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(121, 57);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Tambah Tagihan Baru";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btPrint.FlatAppearance.BorderSize = 0;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(545, 82);
            this.btPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(121, 57);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "Cetak Histori";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // DataMahasiswa_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btEdit);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btPrint;
    }
}