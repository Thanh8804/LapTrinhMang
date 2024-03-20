namespace app_chatdemo
{
    partial class login
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnforgetpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(364, 280);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(131, 32);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(217, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 32);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // tbuser
            // 
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(217, 192);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(276, 27);
            this.tbuser.TabIndex = 10;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(217, 247);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(276, 27);
            this.tbpassword.TabIndex = 9;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đăng nhập";
            // 
            // btnforgetpass
            // 
            this.btnforgetpass.Location = new System.Drawing.Point(368, 318);
            this.btnforgetpass.Name = "btnforgetpass";
            this.btnforgetpass.Size = new System.Drawing.Size(126, 23);
            this.btnforgetpass.TabIndex = 15;
            this.btnforgetpass.Text = "Quên mật khẩu";
            this.btnforgetpass.UseVisualStyleBackColor = true;
            this.btnforgetpass.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app_chatdemo.Properties.Resources.website_background_image_size_psd_vector_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 465);
            this.Controls.Add(this.btnforgetpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnforgetpass;
    }
}

