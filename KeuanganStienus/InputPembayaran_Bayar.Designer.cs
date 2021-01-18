
namespace KeuanganStienus
{
    partial class InputPembayaran_Bayar
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
            this.tbNim = new System.Windows.Forms.TextBox();
            this.lbNim = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.lbNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dtListTagihan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtListTagihan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(88, 11);
            this.tbNim.Name = "tbNim";
            this.tbNim.ReadOnly = true;
            this.tbNim.Size = new System.Drawing.Size(189, 26);
            this.tbNim.TabIndex = 0;
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Location = new System.Drawing.Point(16, 14);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(38, 20);
            this.lbNim.TabIndex = 1;
            this.lbNim.Text = "NIM";
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.Location = new System.Drawing.Point(1090, 11);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(156, 65);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Bayar";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(16, 53);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(51, 20);
            this.lbNama.TabIndex = 3;
            this.lbNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(88, 50);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(189, 26);
            this.tbNama.TabIndex = 4;
            // 
            // dtListTagihan
            // 
            this.dtListTagihan.AllowUserToAddRows = false;
            this.dtListTagihan.AllowUserToDeleteRows = false;
            this.dtListTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListTagihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListTagihan.Location = new System.Drawing.Point(12, 102);
            this.dtListTagihan.Name = "dtListTagihan";
            this.dtListTagihan.RowHeadersWidth = 62;
            this.dtListTagihan.RowTemplate.Height = 28;
            this.dtListTagihan.Size = new System.Drawing.Size(1234, 550);
            this.dtListTagihan.TabIndex = 5;
            this.dtListTagihan.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtListTagihan_EditingControlShowing);
            this.dtListTagihan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtListTagihan_KeyPress);
            // 
            // TambahPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dtListTagihan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbNim);
            this.Controls.Add(this.tbNim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahPembayaran";
            this.Text = "TambahPembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.dtListTagihan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.Label lbNim;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.DataGridView dtListTagihan;
    }
}