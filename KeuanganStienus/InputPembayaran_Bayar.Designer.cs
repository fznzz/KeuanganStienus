﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPembayaran_Bayar));
            this.tbNim = new System.Windows.Forms.TextBox();
            this.lbNim = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.lbNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dtListTagihan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlusDeposit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinusDeposit = new System.Windows.Forms.TextBox();
            this.chbDepositOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListTagihan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNim
            // 
            this.tbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNim.Location = new System.Drawing.Point(75, 83);
            this.tbNim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNim.Name = "tbNim";
            this.tbNim.ReadOnly = true;
            this.tbNim.Size = new System.Drawing.Size(231, 27);
            this.tbNim.TabIndex = 0;
            // 
            // lbNim
            // 
            this.lbNim.AutoSize = true;
            this.lbNim.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNim.Location = new System.Drawing.Point(11, 86);
            this.lbNim.Name = "lbNim";
            this.lbNim.Size = new System.Drawing.Size(40, 20);
            this.lbNim.TabIndex = 1;
            this.lbNim.Text = "NIM";
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.White;
            this.btNext.Location = new System.Drawing.Point(908, 83);
            this.btNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(139, 58);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "Bayar";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(11, 115);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(51, 20);
            this.lbNama.TabIndex = 3;
            this.lbNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(75, 113);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNama.Name = "tbNama";
            this.tbNama.ReadOnly = true;
            this.tbNama.Size = new System.Drawing.Size(231, 27);
            this.tbNama.TabIndex = 4;
            // 
            // dtListTagihan
            // 
            this.dtListTagihan.AllowUserToAddRows = false;
            this.dtListTagihan.AllowUserToDeleteRows = false;
            this.dtListTagihan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListTagihan.BackgroundColor = System.Drawing.Color.White;
            this.dtListTagihan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(219)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListTagihan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListTagihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListTagihan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(174)))), ((int)(((byte)(204)))));
            this.dtListTagihan.Location = new System.Drawing.Point(11, 142);
            this.dtListTagihan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtListTagihan.Name = "dtListTagihan";
            this.dtListTagihan.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(189)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListTagihan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtListTagihan.RowTemplate.Height = 28;
            this.dtListTagihan.Size = new System.Drawing.Size(1036, 481);
            this.dtListTagihan.TabIndex = 0;
            this.dtListTagihan.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtListTagihan_EditingControlShowing);
            this.dtListTagihan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtListTagihan_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 72);
            this.panel2.TabIndex = 5;
            // 
            // btBack
            // 
            this.btBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBack.BackgroundImage")));
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Location = new System.Drawing.Point(20, 10);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(62, 56);
            this.btBack.TabIndex = 0;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 58);
            this.label6.TabIndex = 8;
            this.label6.Text = "Input Pembayaran";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Deposit";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaldo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(541, 83);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(132, 27);
            this.tbSaldo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ditambah";
            // 
            // tbPlusDeposit
            // 
            this.tbPlusDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlusDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlusDeposit.Location = new System.Drawing.Point(770, 114);
            this.tbPlusDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlusDeposit.Name = "tbPlusDeposit";
            this.tbPlusDeposit.Size = new System.Drawing.Size(132, 27);
            this.tbPlusDeposit.TabIndex = 3;
            this.tbPlusDeposit.TextChanged += new System.EventHandler(this.tbPlusDeposit_TextChanged);
            this.tbPlusDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlusDeposit_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Digunakan";
            // 
            // tbMinusDeposit
            // 
            this.tbMinusDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinusDeposit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinusDeposit.Location = new System.Drawing.Point(770, 83);
            this.tbMinusDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMinusDeposit.Name = "tbMinusDeposit";
            this.tbMinusDeposit.Size = new System.Drawing.Size(132, 27);
            this.tbMinusDeposit.TabIndex = 2;
            this.tbMinusDeposit.TextChanged += new System.EventHandler(this.tbMinusDeposit_TextChanged);
            this.tbMinusDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinusDeposit_KeyPress);
            // 
            // chbDepositOnly
            // 
            this.chbDepositOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbDepositOnly.AutoSize = true;
            this.chbDepositOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbDepositOnly.FlatAppearance.BorderSize = 0;
            this.chbDepositOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbDepositOnly.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDepositOnly.Location = new System.Drawing.Point(467, 117);
            this.chbDepositOnly.Name = "chbDepositOnly";
            this.chbDepositOnly.Size = new System.Drawing.Size(121, 24);
            this.chbDepositOnly.TabIndex = 1;
            this.chbDepositOnly.Text = "Deposit Only";
            this.chbDepositOnly.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbDepositOnly.UseVisualStyleBackColor = true;
            // 
            // InputPembayaran_Bayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.chbDepositOnly);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.dtListTagihan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbPlusDeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.tbMinusDeposit);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbNim);
            this.Controls.Add(this.tbNim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputPembayaran_Bayar";
            this.Text = "TambahPembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.dtListTagihan)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlusDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinusDeposit;
        private System.Windows.Forms.CheckBox chbDepositOnly;
    }
}