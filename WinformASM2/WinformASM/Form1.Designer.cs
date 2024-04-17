namespace WinformASM
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
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_MK = new System.Windows.Forms.TextBox();
            this.d_Logout = new System.Windows.Forms.Button();
            this.d_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(12, 102);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(128, 24);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID Đăng Nhập";
            this.lb_ID.Click += new System.EventHandler(this.lb_ID_Click);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(48, 160);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(89, 24);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Mật Khẩu";
            this.lb_Password.Click += new System.EventHandler(this.lb_Password_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(143, 102);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(385, 31);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // tb_MK
            // 
            this.tb_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MK.Location = new System.Drawing.Point(143, 160);
            this.tb_MK.Multiline = true;
            this.tb_MK.Name = "tb_MK";
            this.tb_MK.Size = new System.Drawing.Size(385, 31);
            this.tb_MK.TabIndex = 3;
            this.tb_MK.TextChanged += new System.EventHandler(this.tb_MK_TextChanged);
            // 
            // d_Logout
            // 
            this.d_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_Logout.Location = new System.Drawing.Point(402, 230);
            this.d_Logout.Name = "d_Logout";
            this.d_Logout.Size = new System.Drawing.Size(126, 36);
            this.d_Logout.TabIndex = 4;
            this.d_Logout.Text = "Thoát";
            this.d_Logout.UseVisualStyleBackColor = true;
            this.d_Logout.Click += new System.EventHandler(this.d_Logout_Click);
            // 
            // d_Login
            // 
            this.d_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_Login.Location = new System.Drawing.Point(270, 230);
            this.d_Login.Name = "d_Login";
            this.d_Login.Size = new System.Drawing.Size(126, 36);
            this.d_Login.TabIndex = 5;
            this.d_Login.Text = "Đăng Nhập";
            this.d_Login.UseVisualStyleBackColor = true;
            this.d_Login.Click += new System.EventHandler(this.d_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 274);
            this.Controls.Add(this.d_Login);
            this.Controls.Add(this.d_Logout);
            this.Controls.Add(this.tb_MK);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fc_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_MK;
        private System.Windows.Forms.Button d_Logout;
        private System.Windows.Forms.Button d_Login;
    }
}

