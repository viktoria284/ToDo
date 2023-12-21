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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(38, 65);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 23);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(38, 105);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 23);
            this.textBox_password.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(38, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 264);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "login";
            this.Text = "login";
          //  this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

 
            LogInButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox3
            // 
            textBox3.Location = new Point(104, 229);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 41;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 158);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 40;
            textBox2.TextChanged += textBox2_TextChanged;
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
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
 
        }

        #endregion
 
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button1;
        private LinkLabel linkLabel1;
 
        private Button LogInButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private LinkLabel SignUpPage;
 
    }
}