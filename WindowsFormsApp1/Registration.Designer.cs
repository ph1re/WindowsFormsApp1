namespace WindowsFormsApp1
{
    partial class Registration
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
            this.enter = new System.Windows.Forms.Label();
            this.boxShowPassword = new System.Windows.Forms.CheckBox();
            this.guna2TextBox1 = new System.Windows.Forms.TextBox();
            this.guna2TextBox2 = new System.Windows.Forms.TextBox();
            this.guna2TextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Location = new System.Drawing.Point(270, 270);
            this.enter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(61, 20);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // boxShowPassword
            // 
            this.boxShowPassword.AutoSize = true;
            this.boxShowPassword.Location = new System.Drawing.Point(288, 204);
            this.boxShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.boxShowPassword.Name = "boxShowPassword";
            this.boxShowPassword.Size = new System.Drawing.Size(177, 24);
            this.boxShowPassword.TabIndex = 1;
            this.boxShowPassword.Text = "Показать пароль";
            this.boxShowPassword.UseVisualStyleBackColor = true;
            this.boxShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Location = new System.Drawing.Point(165, 100);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Size = new System.Drawing.Size(300, 27);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Location = new System.Drawing.Point(165, 135);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.Size = new System.Drawing.Size(300, 27);
            this.guna2TextBox2.TabIndex = 3;
            this.guna2TextBox2.UseSystemPasswordChar = true;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Location = new System.Drawing.Point(165, 169);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.Size = new System.Drawing.Size(300, 27);
            this.guna2TextBox3.TabIndex = 4;
            this.guna2TextBox3.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.boxShowPassword);
            this.Controls.Add(this.enter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.CheckBox boxShowPassword;
        private System.Windows.Forms.TextBox guna2TextBox1;
        private System.Windows.Forms.TextBox guna2TextBox2;
        private System.Windows.Forms.TextBox guna2TextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}