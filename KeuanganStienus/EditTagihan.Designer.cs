
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
            this.btTambahTagihan = new System.Windows.Forms.Button();
            this.btEditTagihan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTambahTagihan
            // 
            this.btTambahTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTambahTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btTambahTagihan.FlatAppearance.BorderSize = 0;
            this.btTambahTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTambahTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTambahTagihan.ForeColor = System.Drawing.Color.White;
            this.btTambahTagihan.Location = new System.Drawing.Point(42, 118);
            this.btTambahTagihan.Name = "btTambahTagihan";
            this.btTambahTagihan.Size = new System.Drawing.Size(455, 449);
            this.btTambahTagihan.TabIndex = 9;
            this.btTambahTagihan.Text = "Tambah Tagihan";
            this.btTambahTagihan.UseVisualStyleBackColor = false;
            this.btTambahTagihan.Click += new System.EventHandler(this.btTambahTagihan_Click);
            // 
            // btEditTagihan
            // 
            this.btEditTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btEditTagihan.FlatAppearance.BorderSize = 0;
            this.btEditTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditTagihan.ForeColor = System.Drawing.Color.White;
            this.btEditTagihan.Location = new System.Drawing.Point(533, 118);
            this.btEditTagihan.Name = "btEditTagihan";
            this.btEditTagihan.Size = new System.Drawing.Size(455, 449);
            this.btEditTagihan.TabIndex = 8;
            this.btEditTagihan.Text = "Edit Tagihan";
            this.btEditTagihan.UseVisualStyleBackColor = false;
            this.btEditTagihan.Click += new System.EventHandler(this.btEditTagihan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pengaturan Tagihan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 90);
            this.panel1.TabIndex = 10;
            // 
            // EditTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btTambahTagihan);
            this.Controls.Add(this.btEditTagihan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTagihan";
            this.Text = "Menu3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTambahTagihan;
        private System.Windows.Forms.Button btEditTagihan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}