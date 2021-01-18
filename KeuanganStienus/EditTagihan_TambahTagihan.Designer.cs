
namespace KeuanganStienus
{
    partial class EditTagihan_TambahTagihan
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
            this.tbNamaTagihan = new System.Windows.Forms.TextBox();
            this.tbJumlahTagihan = new System.Windows.Forms.TextBox();
            this.tbSemesterTagihan = new System.Windows.Forms.TextBox();
            this.tbKodeTagihan = new System.Windows.Forms.TextBox();
            this.lbNamaTagihan = new System.Windows.Forms.Label();
            this.lbKodeTagihan = new System.Windows.Forms.Label();
            this.lbJumlahTagihan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJurusan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKelas = new System.Windows.Forms.ComboBox();
            this.tbAngkatan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNamaTagihan
            // 
            this.tbNamaTagihan.Location = new System.Drawing.Point(162, 107);
            this.tbNamaTagihan.MaxLength = 50;
            this.tbNamaTagihan.Name = "tbNamaTagihan";
            this.tbNamaTagihan.Size = new System.Drawing.Size(301, 26);
            this.tbNamaTagihan.TabIndex = 0;
            // 
            // tbJumlahTagihan
            // 
            this.tbJumlahTagihan.Location = new System.Drawing.Point(162, 171);
            this.tbJumlahTagihan.Name = "tbJumlahTagihan";
            this.tbJumlahTagihan.Size = new System.Drawing.Size(301, 26);
            this.tbJumlahTagihan.TabIndex = 2;
            this.tbJumlahTagihan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlahTagihan_KeyPress);
            // 
            // tbSemesterTagihan
            // 
            this.tbSemesterTagihan.Location = new System.Drawing.Point(162, 203);
            this.tbSemesterTagihan.MaxLength = 2;
            this.tbSemesterTagihan.Name = "tbSemesterTagihan";
            this.tbSemesterTagihan.Size = new System.Drawing.Size(301, 26);
            this.tbSemesterTagihan.TabIndex = 3;
            // 
            // tbKodeTagihan
            // 
            this.tbKodeTagihan.Location = new System.Drawing.Point(162, 139);
            this.tbKodeTagihan.MaxLength = 3;
            this.tbKodeTagihan.Name = "tbKodeTagihan";
            this.tbKodeTagihan.Size = new System.Drawing.Size(301, 26);
            this.tbKodeTagihan.TabIndex = 1;
            // 
            // lbNamaTagihan
            // 
            this.lbNamaTagihan.AutoSize = true;
            this.lbNamaTagihan.Location = new System.Drawing.Point(12, 110);
            this.lbNamaTagihan.Name = "lbNamaTagihan";
            this.lbNamaTagihan.Size = new System.Drawing.Size(112, 20);
            this.lbNamaTagihan.TabIndex = 4;
            this.lbNamaTagihan.Text = "Nama Tagihan";
            // 
            // lbKodeTagihan
            // 
            this.lbKodeTagihan.AutoSize = true;
            this.lbKodeTagihan.Location = new System.Drawing.Point(12, 142);
            this.lbKodeTagihan.Name = "lbKodeTagihan";
            this.lbKodeTagihan.Size = new System.Drawing.Size(107, 20);
            this.lbKodeTagihan.TabIndex = 5;
            this.lbKodeTagihan.Text = "Kode Tagihan";
            // 
            // lbJumlahTagihan
            // 
            this.lbJumlahTagihan.AutoSize = true;
            this.lbJumlahTagihan.Location = new System.Drawing.Point(12, 174);
            this.lbJumlahTagihan.Name = "lbJumlahTagihan";
            this.lbJumlahTagihan.Size = new System.Drawing.Size(121, 20);
            this.lbJumlahTagihan.TabIndex = 6;
            this.lbJumlahTagihan.Text = "Jumlah Tagihan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Semester Tagihan";
            // 
            // cbJurusan
            // 
            this.cbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJurusan.FormattingEnabled = true;
            this.cbJurusan.Items.AddRange(new object[] {
            "Akuntansi",
            "Manajemen"});
            this.cbJurusan.Location = new System.Drawing.Point(162, 235);
            this.cbJurusan.Name = "cbJurusan";
            this.cbJurusan.Size = new System.Drawing.Size(301, 28);
            this.cbJurusan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kelas";
            // 
            // cbKelas
            // 
            this.cbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKelas.FormattingEnabled = true;
            this.cbKelas.Items.AddRange(new object[] {
            "Reguler",
            "Malam"});
            this.cbKelas.Location = new System.Drawing.Point(162, 269);
            this.cbKelas.Name = "cbKelas";
            this.cbKelas.Size = new System.Drawing.Size(301, 28);
            this.cbKelas.TabIndex = 5;
            // 
            // tbAngkatan
            // 
            this.tbAngkatan.Location = new System.Drawing.Point(162, 303);
            this.tbAngkatan.MaxLength = 2;
            this.tbAngkatan.Name = "tbAngkatan";
            this.tbAngkatan.Size = new System.Drawing.Size(301, 26);
            this.tbAngkatan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tahun Angkatan";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(672, 371);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(116, 67);
            this.btOk.TabIndex = 8;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tambah Tagihan";
            // 
            // TambahTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAngkatan);
            this.Controls.Add(this.cbKelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJurusan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbJumlahTagihan);
            this.Controls.Add(this.lbKodeTagihan);
            this.Controls.Add(this.lbNamaTagihan);
            this.Controls.Add(this.tbKodeTagihan);
            this.Controls.Add(this.tbSemesterTagihan);
            this.Controls.Add(this.tbJumlahTagihan);
            this.Controls.Add(this.tbNamaTagihan);
            this.Name = "TambahTagihan";
            this.Text = "TambahTagihan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaTagihan;
        private System.Windows.Forms.TextBox tbJumlahTagihan;
        private System.Windows.Forms.TextBox tbSemesterTagihan;
        private System.Windows.Forms.TextBox tbKodeTagihan;
        private System.Windows.Forms.Label lbNamaTagihan;
        private System.Windows.Forms.Label lbKodeTagihan;
        private System.Windows.Forms.Label lbJumlahTagihan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbJurusan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKelas;
        private System.Windows.Forms.TextBox tbAngkatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label5;
    }
}