﻿
namespace KeuanganStienus
{
    partial class Menu2InputPembayaran
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
            this.datagridMahasiswa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btConn = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridMahasiswa
            // 
            this.datagridMahasiswa.AllowUserToAddRows = false;
            this.datagridMahasiswa.AllowUserToDeleteRows = false;
            this.datagridMahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMahasiswa.Location = new System.Drawing.Point(12, 61);
            this.datagridMahasiswa.Name = "datagridMahasiswa";
            this.datagridMahasiswa.ReadOnly = true;
            this.datagridMahasiswa.RowHeadersWidth = 62;
            this.datagridMahasiswa.RowTemplate.Height = 28;
            this.datagridMahasiswa.Size = new System.Drawing.Size(1031, 571);
            this.datagridMahasiswa.TabIndex = 0;
            this.datagridMahasiswa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMahasiswa_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cari Mahasiswa :";
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(931, 12);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(112, 43);
            this.btConn.TabIndex = 9;
            this.btConn.Text = "Refresh";
            this.btConn.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbSearch.Location = new System.Drawing.Point(146, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(311, 26);
            this.tbSearch.TabIndex = 8;
            // 
            // Menu2InputPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.datagridMahasiswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu2InputPembayaran";
            this.Text = "Menu 2";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridMahasiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.TextBox tbSearch;
    }
}