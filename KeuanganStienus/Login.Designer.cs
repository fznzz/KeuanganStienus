
namespace KeuanganStienus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUname = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.pnDrag = new System.Windows.Forms.Panel();
            this.dragControl1 = new KeuanganStienus.DragControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dragControl2 = new KeuanganStienus.DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUname
            // 
            this.tbUname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUname.Location = new System.Drawing.Point(139, 13);
            this.tbUname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(153, 30);
            this.tbUname.TabIndex = 0;
            this.tbUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUname_KeyDown);
            // 
            // tbPass
            // 
            this.tbPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(139, 46);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(153, 30);
            this.tbPass.TabIndex = 1;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUname.Location = new System.Drawing.Point(8, 15);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(102, 25);
            this.lbUname.TabIndex = 2;
            this.lbUname.Text = "Username";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(8, 48);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(98, 25);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(193)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(300, 196);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(140, 51);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // BtClose
            // 
            this.BtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtClose.BackgroundImage")));
            this.BtClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtClose.FlatAppearance.BorderSize = 0;
            this.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClose.Location = new System.Drawing.Point(414, 10);
            this.BtClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(27, 24);
            this.BtClose.TabIndex = 2;
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pnDrag
            // 
            this.pnDrag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.pnDrag.Location = new System.Drawing.Point(0, 0);
            this.pnDrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDrag.Name = "pnDrag";
            this.pnDrag.Size = new System.Drawing.Size(44, 257);
            this.pnDrag.TabIndex = 7;
            // 
            // dragControl1
            // 
            this.dragControl1.selectControl = this.pnDrag;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtClose);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Location = new System.Drawing.Point(44, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 257);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 43);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "STIE Nusa Megarkencana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "© 2021 Fauzan Pradana";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tbUname);
            this.panel2.Controls.Add(this.lbUname);
            this.panel2.Controls.Add(this.lbPass);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Location = new System.Drawing.Point(72, 97);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 94);
            this.panel2.TabIndex = 0;
            // 
            // dragControl2
            // 
            this.dragControl2.selectControl = this.panel3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbUname;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Panel pnDrag;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DragControl dragControl2;
    }
}

