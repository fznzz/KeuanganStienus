
namespace KeuanganStienus
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSide = new System.Windows.Forms.Panel();
            this.btSettings = new System.Windows.Forms.Button();
            this.btMenuEditTagihan = new System.Windows.Forms.Button();
            this.btMenuInputPembayaran = new System.Windows.Forms.Button();
            this.btMenuDataMahasiswa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbLABELADMIN = new System.Windows.Forms.Label();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.pnContent = new System.Windows.Forms.Panel();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.dragControl1 = new KeuanganStienus.DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pnSide);
            this.panel1.Controls.Add(this.btSettings);
            this.panel1.Controls.Add(this.btMenuEditTagihan);
            this.panel1.Controls.Add(this.btMenuInputPembayaran);
            this.panel1.Controls.Add(this.btMenuDataMahasiswa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.White;
            this.pnSide.Location = new System.Drawing.Point(12, 166);
            this.pnSide.Name = "pnSide";
            this.pnSide.Size = new System.Drawing.Size(5, 126);
            this.pnSide.TabIndex = 4;
            // 
            // btSettings
            // 
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSettings.Image = ((System.Drawing.Image)(resources.GetObject("btSettings.Image")));
            this.btSettings.Location = new System.Drawing.Point(24, 562);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(220, 126);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "Pengaturan";
            this.btSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btMenuEditTagihan
            // 
            this.btMenuEditTagihan.FlatAppearance.BorderSize = 0;
            this.btMenuEditTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuEditTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuEditTagihan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenuEditTagihan.Image = ((System.Drawing.Image)(resources.GetObject("btMenuEditTagihan.Image")));
            this.btMenuEditTagihan.Location = new System.Drawing.Point(24, 430);
            this.btMenuEditTagihan.Name = "btMenuEditTagihan";
            this.btMenuEditTagihan.Size = new System.Drawing.Size(226, 126);
            this.btMenuEditTagihan.TabIndex = 2;
            this.btMenuEditTagihan.Text = "Pengaturan Tagihan";
            this.btMenuEditTagihan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMenuEditTagihan.UseVisualStyleBackColor = true;
            this.btMenuEditTagihan.Click += new System.EventHandler(this.btMenuEditTagihan_Click);
            // 
            // btMenuInputPembayaran
            // 
            this.btMenuInputPembayaran.FlatAppearance.BorderSize = 0;
            this.btMenuInputPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuInputPembayaran.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuInputPembayaran.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenuInputPembayaran.Image = ((System.Drawing.Image)(resources.GetObject("btMenuInputPembayaran.Image")));
            this.btMenuInputPembayaran.Location = new System.Drawing.Point(24, 298);
            this.btMenuInputPembayaran.Name = "btMenuInputPembayaran";
            this.btMenuInputPembayaran.Size = new System.Drawing.Size(226, 126);
            this.btMenuInputPembayaran.TabIndex = 2;
            this.btMenuInputPembayaran.Text = "Input Pembayaran";
            this.btMenuInputPembayaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMenuInputPembayaran.UseVisualStyleBackColor = true;
            this.btMenuInputPembayaran.Click += new System.EventHandler(this.btMenuInputPembayaran_Click);
            // 
            // btMenuDataMahasiswa
            // 
            this.btMenuDataMahasiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMenuDataMahasiswa.FlatAppearance.BorderSize = 0;
            this.btMenuDataMahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuDataMahasiswa.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuDataMahasiswa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenuDataMahasiswa.Image = ((System.Drawing.Image)(resources.GetObject("btMenuDataMahasiswa.Image")));
            this.btMenuDataMahasiswa.Location = new System.Drawing.Point(24, 166);
            this.btMenuDataMahasiswa.Name = "btMenuDataMahasiswa";
            this.btMenuDataMahasiswa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btMenuDataMahasiswa.Size = new System.Drawing.Size(226, 126);
            this.btMenuDataMahasiswa.TabIndex = 2;
            this.btMenuDataMahasiswa.Text = "Data Mahasiswa";
            this.btMenuDataMahasiswa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMenuDataMahasiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMenuDataMahasiswa.UseVisualStyleBackColor = true;
            this.btMenuDataMahasiswa.Click += new System.EventHandler(this.btMenuDataMahasiswa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 148);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "STIENUS";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.btClose);
            this.pnHeader.Location = new System.Drawing.Point(250, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1031, 52);
            this.pnHeader.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(23, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Informasi Pembayaran Mahasiswa";
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(988, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.lbLABELADMIN);
            this.panel4.Controls.Add(this.lbTanggal);
            this.panel4.Location = new System.Drawing.Point(250, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1031, 57);
            this.panel4.TabIndex = 3;
            // 
            // lbLABELADMIN
            // 
            this.lbLABELADMIN.AutoSize = true;
            this.lbLABELADMIN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLABELADMIN.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLABELADMIN.Location = new System.Drawing.Point(23, 15);
            this.lbLABELADMIN.Name = "lbLABELADMIN";
            this.lbLABELADMIN.Size = new System.Drawing.Size(88, 25);
            this.lbLABELADMIN.TabIndex = 1;
            this.lbLABELADMIN.Text = "Admin : ";
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTanggal.Location = new System.Drawing.Point(825, 15);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTanggal.Size = new System.Drawing.Size(241, 25);
            this.lbTanggal.TabIndex = 0;
            this.lbTanggal.Text = "HH:MM:SS DD:MM:YYYY";
            // 
            // pnContent
            // 
            this.pnContent.Location = new System.Drawing.Point(250, 106);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1028, 611);
            this.pnContent.TabIndex = 4;
            // 
            // timerJam
            // 
            this.timerJam.Tick += new System.EventHandler(this.timerJam_Tick);
            // 
            // dragControl1
            // 
            this.dragControl1.selectControl = this.pnHeader;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Aplikasi Keuangan STIENUS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Button btMenuEditTagihan;
        private System.Windows.Forms.Button btMenuInputPembayaran;
        private System.Windows.Forms.Button btMenuDataMahasiswa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btClose;
        private DragControl dragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.Label lbLABELADMIN;
        private System.Windows.Forms.Button btSettings;
    }
}