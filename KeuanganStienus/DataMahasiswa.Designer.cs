
namespace KeuanganStienus
{
    partial class DataMahasiswa
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
            this.dtMahasiswa = new System.Windows.Forms.DataGridView();
            this.lbNim = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbJurusan = new System.Windows.Forms.Label();
            this.lbKelas = new System.Windows.Forms.Label();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbJurusan = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMahasiswa
            // 
            this.dtMahasiswa.AllowUserToAddRows = false;
            this.dtMahasiswa.AllowUserToDeleteRows = false;
            this.dtMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMahasiswa.Location = new System.Drawing.Point(12, 158);
            this.dtMahasiswa.Name = "dtMahasiswa";
            this.dtMahasiswa.ReadOnly = true;
            this.dtMahasiswa.RowHeadersWidth = 62;
            this.dtMahasiswa.RowTemplate.Height = 28;
            this.dtMahasiswa.Size = new System.Drawing.Size(776, 280);
            this.dtMahasiswa.TabIndex = 0;
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Location = new System.Drawing.Point(12, 15);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(38, 20);
            this.lbNim.TabIndex = 1;
            this.lbNim.Text = "NIM";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(12, 48);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(51, 20);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama";
            // 
            // lbJurusan
            // 
            this.lbJurusan.AutoSize = true;
            this.lbJurusan.Location = new System.Drawing.Point(12, 81);
            this.lbJurusan.Name = "lbJurusan";
            this.lbJurusan.Size = new System.Drawing.Size(66, 20);
            this.lbJurusan.TabIndex = 3;
            this.lbJurusan.Text = "Jurusan";
            // 
            // lbKelas
            // 
            this.lbKelas.AutoSize = true;
            this.lbKelas.Location = new System.Drawing.Point(12, 114);
            this.lbKelas.Name = "lbKelas";
            this.lbKelas.Size = new System.Drawing.Size(48, 20);
            this.lbKelas.TabIndex = 4;
            this.lbKelas.Text = "Kelas";
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(112, 12);
            this.tbNim.Name = "tbNim";
            this.tbNim.ReadOnly = true;
            this.tbNim.Size = new System.Drawing.Size(248, 26);
            this.tbNim.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(112, 45);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(248, 26);
            this.tbNama.TabIndex = 6;
            // 
            // tbJurusan
            // 
            this.tbJurusan.Location = new System.Drawing.Point(112, 78);
            this.tbJurusan.Name = "tbJurusan";
            this.tbJurusan.ReadOnly = true;
            this.tbJurusan.Size = new System.Drawing.Size(248, 26);
            this.tbJurusan.TabIndex = 7;
            // 
            // tbKelas
            // 
            this.tbKelas.Location = new System.Drawing.Point(112, 111);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.ReadOnly = true;
            this.tbKelas.Size = new System.Drawing.Size(248, 26);
            this.tbKelas.TabIndex = 8;
            // 
            // DataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tbJurusan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.lbKelas);
            this.Controls.Add(this.lbJurusan);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNim);
            this.Controls.Add(this.dtMahasiswa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataMahasiswa";
            this.ShowIcon = false;
            this.Text = "Data Mahasiswa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dataMahasiswa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtMahasiswa)).EndInit();
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
    }
}