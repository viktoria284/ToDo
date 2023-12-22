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
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox_password2 = new TextBox();
            textBox_password = new TextBox();
            textBox_login = new TextBox();
            label2 = new Label();
            SignUpButton = new Button();
            LogInPage = new LinkLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(110, 230);
            label4.Name = "label4";
            label4.Size = new Size(174, 22);
            label4.TabIndex = 37;
            label4.Text = "Repeat password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 160);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 36;
            label1.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 35;
            label3.Text = "Login:";
            // 
            // textBox_password2
            // 
            textBox_password2.Location = new Point(110, 256);
            textBox_password2.Margin = new Padding(3, 4, 3, 4);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.Size = new Size(227, 27);
            textBox_password2.TabIndex = 34;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(110, 186);
            textBox_password.Margin = new Padding(3, 4, 3, 4);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(227, 27);
            textBox_password.TabIndex = 33;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(110, 115);
            textBox_login.Margin = new Padding(3, 4, 3, 4);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(227, 27);
            textBox_login.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 35);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 38;
            label2.Text = "Sign up";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.White;
            SignUpButton.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(110, 340);
            SignUpButton.Margin = new Padding(3, 4, 3, 4);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(220, 40);
            SignUpButton.TabIndex = 39;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LogInPage
            // 
            LogInPage.AutoSize = true;
            LogInPage.Location = new Point(146, 393);
            LogInPage.Name = "LogInPage";
            LogInPage.Size = new Size(158, 20);
            LogInPage.TabIndex = 40;
            LogInPage.TabStop = true;
            LogInPage.Text = "Already have account?";
            LogInPage.LinkClicked += LogInPage_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(180, 299);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 458);
            Controls.Add(checkBox1);
            Controls.Add(LogInPage);
            Controls.Add(SignUpButton);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox_password2);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "Sign_up";
            Text = "Sign_up";
            Load += Sign_up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox textBox_password2;
        private TextBox textBox_password;
        private TextBox textBox_login;
        private Label label2;
        private Button SignUpButton;
        private LinkLabel LogInPage;
        private CheckBox checkBox1;
    }
}