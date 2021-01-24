
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTagihan));
            this.btTambahTagihan = new System.Windows.Forms.Button();
            this.btEditTagihan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTambahTagihan
            // 
            this.btTambahTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btTambahTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btTambahTagihan.FlatAppearance.BorderSize = 0;
            this.btTambahTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTambahTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTambahTagihan.ForeColor = System.Drawing.Color.White;
            this.btTambahTagihan.Image = ((System.Drawing.Image)(resources.GetObject("btTambahTagihan.Image")));
            this.btTambahTagihan.Location = new System.Drawing.Point(40, 45);
            this.btTambahTagihan.Name = "btTambahTagihan";
            this.btTambahTagihan.Size = new System.Drawing.Size(413, 409);
            this.btTambahTagihan.TabIndex = 0;
            this.btTambahTagihan.Text = "Tambah Tagihan";
            this.btTambahTagihan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTambahTagihan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTambahTagihan.UseVisualStyleBackColor = false;
            this.btTambahTagihan.Click += new System.EventHandler(this.btTambahTagihan_Click);
            // 
            // btEditTagihan
            // 
            this.btEditTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btEditTagihan.FlatAppearance.BorderSize = 0;
            this.btEditTagihan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditTagihan.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditTagihan.ForeColor = System.Drawing.Color.White;
            this.btEditTagihan.Image = ((System.Drawing.Image)(resources.GetObject("btEditTagihan.Image")));
            this.btEditTagihan.Location = new System.Drawing.Point(40, 45);
            this.btEditTagihan.Name = "btEditTagihan";
            this.btEditTagihan.Size = new System.Drawing.Size(401, 409);
            this.btEditTagihan.TabIndex = 0;
            this.btEditTagihan.Text = "Edit Tagihan";
            this.btEditTagihan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditTagihan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEditTagihan.UseVisualStyleBackColor = false;
            this.btEditTagihan.Click += new System.EventHandler(this.btEditTagihan_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pengaturan Tagihan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 90);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 503);
            this.panel2.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btTambahTagihan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btEditTagihan);
            this.splitContainer1.Size = new System.Drawing.Size(998, 497);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // EditTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTagihan";
            this.Text = "Menu3";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTambahTagihan;
        private System.Windows.Forms.Button btEditTagihan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}