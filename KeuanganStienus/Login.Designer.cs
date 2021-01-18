
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
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUname = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUname
            // 
            this.tbUname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUname.Location = new System.Drawing.Point(250, 73);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(172, 35);
            this.tbUname.TabIndex = 0;
            this.tbUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUname_KeyDown);
            // 
            // tbPass
            // 
            this.tbPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(250, 114);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(172, 35);
            this.tbPass.TabIndex = 1;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUname.Location = new System.Drawing.Point(103, 76);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(124, 29);
            this.lbUname.TabIndex = 2;
            this.lbUname.Text = "Username";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(103, 117);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(120, 29);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(320, 245);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(110, 64);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(436, 245);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(110, 64);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 321);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUname);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbUname;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCreate;
    }
}

