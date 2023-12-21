namespace ToDo
{
    partial class Sign_up
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LogInPage = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Access";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LogInPage
            // 
            this.LogInPage.AutoSize = true;
            this.LogInPage.Location = new System.Drawing.Point(327, 382);
            this.LogInPage.Name = "LogInPage";
            this.LogInPage.Size = new System.Drawing.Size(126, 15);
            this.LogInPage.TabIndex = 106;
            this.LogInPage.TabStop = true;
            this.LogInPage.Text = "Already have account?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(297, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 30);
            this.button1.TabIndex = 105;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(349, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 104;
            this.label11.Text = "Sign up";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(297, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 103;
            this.label12.Text = "Repeat password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(297, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 102;
            this.label13.Text = "Password:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(297, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 101;
            this.label14.Text = "Email:";
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(297, 276);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(199, 23);
            this.textBox_password2.TabIndex = 100;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(297, 224);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(199, 23);
            this.textBox_password.TabIndex = 99;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(297, 171);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(199, 23);
            this.textBox_login.TabIndex = 98;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 485);
            this.Controls.Add(this.LogInPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.checkBox1);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox checkBox1;
        private LinkLabel LogInPage;
        private Button button1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox_password2;
        private TextBox textBox_password;
        private TextBox textBox_login;
    }
}