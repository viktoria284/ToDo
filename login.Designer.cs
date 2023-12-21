namespace ToDo
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
            LogInButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox_password = new TextBox();
            textBox_login = new TextBox();
            SignUpPage = new LinkLabel();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.White;
            LogInButton.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(104, 296);
            LogInButton.Margin = new Padding(3, 4, 3, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(220, 40);
            LogInButton.TabIndex = 47;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 68);
            label2.Name = "label2";
            label2.Size = new Size(81, 27);
            label2.TabIndex = 46;
            label2.Text = "Log in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 203);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 44;
            label1.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 132);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 43;
            label3.Text = "Email:";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(104, 229);
            textBox_password.Margin = new Padding(3, 4, 3, 4);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(227, 27);
            textBox_password.TabIndex = 41;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(104, 158);
            textBox_login.Margin = new Padding(3, 4, 3, 4);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(227, 27);
            textBox_login.TabIndex = 40;
            // 
            // SignUpPage
            // 
            SignUpPage.AutoSize = true;
            SignUpPage.Location = new Point(136, 351);
            SignUpPage.Name = "SignUpPage";
            SignUpPage.Size = new Size(163, 20);
            SignUpPage.TabIndex = 48;
            SignUpPage.TabStop = true;
            SignUpPage.Text = "Don't have an account?";
            SignUpPage.LinkClicked += SignUpPage_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(SignUpPage);
            Controls.Add(LogInButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox_password;
        private TextBox textBox_login;
        private LinkLabel SignUpPage;
    }
}