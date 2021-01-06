
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridMahasiswa
            // 
            this.datagridMahasiswa.AllowUserToAddRows = false;
            this.datagridMahasiswa.AllowUserToDeleteRows = false;
            this.datagridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMahasiswa.Location = new System.Drawing.Point(12, 169);
            this.datagridMahasiswa.Name = "datagridMahasiswa";
            this.datagridMahasiswa.ReadOnly = true;
            this.datagridMahasiswa.RowHeadersWidth = 62;
            this.datagridMahasiswa.RowTemplate.Height = 28;
            this.datagridMahasiswa.Size = new System.Drawing.Size(776, 269);
            this.datagridMahasiswa.TabIndex = 0;
            this.datagridMahasiswa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMahasiswa_CellDoubleClick);
            // 
            // Menu2InputPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagridMahasiswa);
            this.Name = "Menu2InputPembayaran";
            this.Text = "Menu 2";
            ((System.ComponentModel.ISupportInitialize)(this.datagridMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridMahasiswa;
    }
}