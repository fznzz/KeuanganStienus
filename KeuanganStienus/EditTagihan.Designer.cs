
namespace KeuanganStienus
{
    partial class EditTagihan
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
            this.btEditTagihan = new System.Windows.Forms.Button();
            this.btTambahTagihan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEditTagihan
            // 
            this.btEditTagihan.Location = new System.Drawing.Point(601, 96);
            this.btEditTagihan.Name = "btEditTagihan";
            this.btEditTagihan.Size = new System.Drawing.Size(377, 181);
            this.btEditTagihan.TabIndex = 8;
            this.btEditTagihan.Text = "Edit Tagihan";
            this.btEditTagihan.UseVisualStyleBackColor = true;
            this.btEditTagihan.Click += new System.EventHandler(this.btEditTagihan_Click);
            // 
            // btTambahTagihan
            // 
            this.btTambahTagihan.Location = new System.Drawing.Point(114, 100);
            this.btTambahTagihan.Name = "btTambahTagihan";
            this.btTambahTagihan.Size = new System.Drawing.Size(377, 181);
            this.btTambahTagihan.TabIndex = 9;
            this.btTambahTagihan.Text = "Tambah Tagihan";
            this.btTambahTagihan.UseVisualStyleBackColor = true;
            this.btTambahTagihan.Click += new System.EventHandler(this.btTambahTagihan_Click);
            // 
            // Menu3InputTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 644);
            this.Controls.Add(this.btTambahTagihan);
            this.Controls.Add(this.btEditTagihan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu3InputTagihan";
            this.Text = "Menu3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEditTagihan;
        private System.Windows.Forms.Button btTambahTagihan;
    }
}