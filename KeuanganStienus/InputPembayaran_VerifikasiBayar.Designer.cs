
namespace KeuanganStienus
{
    partial class InputPembayaran_VerifikasiBayar
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
            this.dtPembayaran = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.btBayar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPembayaran
            // 
            this.dtPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPembayaran.Location = new System.Drawing.Point(12, 104);
            this.dtPembayaran.Name = "dtPembayaran";
            this.dtPembayaran.RowHeadersWidth = 62;
            this.dtPembayaran.RowTemplate.Height = 28;
            this.dtPembayaran.Size = new System.Drawing.Size(776, 334);
            this.dtPembayaran.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIM";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(65, 17);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(232, 26);
            this.tbNama.TabIndex = 3;
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(65, 56);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(232, 26);
            this.tbNim.TabIndex = 4;
            // 
            // btBayar
            // 
            this.btBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBayar.Location = new System.Drawing.Point(647, 12);
            this.btBayar.Name = "btBayar";
            this.btBayar.Size = new System.Drawing.Size(141, 67);
            this.btBayar.TabIndex = 5;
            this.btBayar.Text = "Bayar";
            this.btBayar.UseVisualStyleBackColor = true;
            this.btBayar.Click += new System.EventHandler(this.btBayar_Click);
            // 
            // VerifikasiPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBayar);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPembayaran);
            this.Name = "VerifikasiPembayaran";
            this.Text = "VerifikasiPembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.dtPembayaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPembayaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.Button btBayar;
    }
}