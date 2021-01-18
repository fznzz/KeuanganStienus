
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dtListMahasiswa = new System.Windows.Forms.DataGridView();
            this.btConn = new System.Windows.Forms.Button();
            this.btTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbSearch.Location = new System.Drawing.Point(146, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(311, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtListMahasiswa
            // 
            this.dtListMahasiswa.AllowUserToAddRows = false;
            this.dtListMahasiswa.AllowUserToDeleteRows = false;
            this.dtListMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListMahasiswa.Location = new System.Drawing.Point(12, 61);
            this.dtListMahasiswa.Name = "dtListMahasiswa";
            this.dtListMahasiswa.ReadOnly = true;
            this.dtListMahasiswa.RowHeadersWidth = 62;
            this.dtListMahasiswa.RowTemplate.Height = 28;
            this.dtListMahasiswa.Size = new System.Drawing.Size(1031, 571);
            this.dtListMahasiswa.TabIndex = 2;
            this.dtListMahasiswa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData1_CellDoubleClick);
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(931, 12);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(112, 43);
            this.btConn.TabIndex = 5;
            this.btConn.Text = "Refresh";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(748, 12);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(177, 43);
            this.btTambah.TabIndex = 6;
            this.btTambah.Text = "Tambah Mahasiswa";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cari Mahasiswa :";
            // 
            // Menu1DataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.dtListMahasiswa);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu1DataMahasiswa";
            this.Text = "Menu 1";
            ((System.ComponentModel.ISupportInitialize)(this.dtListMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dtListMahasiswa;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Label label1;
    }
}