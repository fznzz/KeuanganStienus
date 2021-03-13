
namespace KeuanganStienus
{
    partial class DataMahasiswa_TambahMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMahasiswa_TambahMahasiswa));
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbJurusan = new System.Windows.Forms.ComboBox();
            this.cbKelas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAngkatan = new System.Windows.Forms.TextBox();
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(290, 57);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(321, 27);
            this.tbNama.TabIndex = 0;
            // 
            // tbNim
            // 
            this.tbNim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNim.Location = new System.Drawing.Point(290, 86);
            this.tbNim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(321, 27);
            this.tbNim.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.Location = new System.Drawing.Point(873, 563);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(174, 60);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jurusan";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kelas";
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
            this.panel2.TabIndex = 2;
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
            this.label6.Location = new System.Drawing.Point(224, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(611, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tambah Mahasiswa Baru";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbJurusan
            // 
            this.cbJurusan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJurusan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJurusan.FormattingEnabled = true;
            this.cbJurusan.Items.AddRange(new object[] {
            "Akuntansi",
            "Manajemen"});
            this.cbJurusan.Location = new System.Drawing.Point(290, 116);
            this.cbJurusan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbJurusan.Name = "cbJurusan";
            this.cbJurusan.Size = new System.Drawing.Size(321, 28);
            this.cbJurusan.TabIndex = 2;
            // 
            // cbKelas
            // 
            this.cbKelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKelas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.Items.AddRange(new object[] {
            "Reguler",
            "Malam"});
            this.cbKelas.Location = new System.Drawing.Point(290, 146);
            this.cbKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(321, 28);
            this.cbKelas.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAngkatan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbKelas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbJurusan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNama);
            this.panel1.Controls.Add(this.tbNim);
            this.panel1.Location = new System.Drawing.Point(152, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 220);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Angkatan";
            // 
            // tbAngkatan
            // 
            this.tbAngkatan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAngkatan.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAngkatan.Location = new System.Drawing.Point(290, 176);
            this.tbAngkatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngkatan.MaxLength = 2;
            this.tbAngkatan.Name = "tbAngkatan";
            this.tbAngkatan.Size = new System.Drawing.Size(321, 27);
            this.tbAngkatan.TabIndex = 11;
            this.tbAngkatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAngkatan_KeyPress);
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btImport.FlatAppearance.BorderSize = 0;
            this.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImport.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.ForeColor = System.Drawing.Color.White;
            this.btImport.Location = new System.Drawing.Point(659, 563);
            this.btImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(208, 60);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "Impor dari File Excel";
            this.btImport.UseVisualStyleBackColor = false;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DataMahasiswa_TambahMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataMahasiswa_TambahMahasiswa";
            this.ShowIcon = false;
            this.Text = "Tambah Mahasiswa";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbJurusan;
        private System.Windows.Forms.ComboBox cbKelas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAngkatan;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}