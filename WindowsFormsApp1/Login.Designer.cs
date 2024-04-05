namespace WindowsFormsApp1
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBoxA = new System.Windows.Forms.TextBox();
            this.loginTextBoxA = new System.Windows.Forms.TextBox();
            this.boxShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Логин";
            // 
            // passwordTextBoxA
            // 
            this.passwordTextBoxA.Location = new System.Drawing.Point(165, 137);
            this.passwordTextBoxA.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBoxA.Name = "passwordTextBoxA";
            this.passwordTextBoxA.Size = new System.Drawing.Size(300, 27);
            this.passwordTextBoxA.TabIndex = 12;
            this.passwordTextBoxA.UseSystemPasswordChar = true;
            // 
            // loginTextBoxA
            // 
            this.loginTextBoxA.Location = new System.Drawing.Point(165, 100);
            this.loginTextBoxA.Margin = new System.Windows.Forms.Padding(5);
            this.loginTextBoxA.Name = "loginTextBoxA";
            this.loginTextBoxA.Size = new System.Drawing.Size(300, 27);
            this.loginTextBoxA.TabIndex = 11;
            // 
            // boxShowPassword
            // 
            this.boxShowPassword.AutoSize = true;
            this.boxShowPassword.Location = new System.Drawing.Point(288, 174);
            this.boxShowPassword.Margin = new System.Windows.Forms.Padding(5);
            this.boxShowPassword.Name = "boxShowPassword";
            this.boxShowPassword.Size = new System.Drawing.Size(177, 24);
            this.boxShowPassword.TabIndex = 10;
            this.boxShowPassword.Text = "Показать пароль";
            this.boxShowPassword.UseVisualStyleBackColor = true;
            this.boxShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBoxA);
            this.Controls.Add(this.loginTextBoxA);
            this.Controls.Add(this.boxShowPassword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBoxA;
        private System.Windows.Forms.TextBox loginTextBoxA;
        private System.Windows.Forms.CheckBox boxShowPassword;
        private System.Windows.Forms.Label label1;
    }
}