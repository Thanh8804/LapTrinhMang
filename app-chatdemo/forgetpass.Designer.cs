namespace app_chatdemo
{
    partial class forgetpass
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnforgetpass = new System.Windows.Forms.Button();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.txbgmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Quên mật khẩu";
            // 
            // btnforgetpass
            // 
            this.btnforgetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgetpass.Location = new System.Drawing.Point(246, 293);
            this.btnforgetpass.Name = "btnforgetpass";
            this.btnforgetpass.Size = new System.Drawing.Size(183, 32);
            this.btnforgetpass.TabIndex = 20;
            this.btnforgetpass.Text = "Quên mật khẩu";
            this.btnforgetpass.UseVisualStyleBackColor = true;
            this.btnforgetpass.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbuser
            // 
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(197, 205);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(276, 27);
            this.tbuser.TabIndex = 19;
            // 
            // txbgmail
            // 
            this.txbgmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbgmail.Location = new System.Drawing.Point(197, 260);
            this.txbgmail.Name = "txbgmail";
            this.txbgmail.Size = new System.Drawing.Size(276, 27);
            this.txbgmail.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gmail";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài khoản";
            // 
            // forgetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app_chatdemo.Properties.Resources.website_background_image_size_psd_vector_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnforgetpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.txbgmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "forgetpass";
            this.Text = "forgetpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnforgetpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox txbgmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}