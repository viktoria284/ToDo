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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SignUpButton = new Button();
            LogInPage = new LinkLabel();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(110, 237);
            label4.Name = "label4";
            label4.Size = new Size(174, 22);
            label4.TabIndex = 37;
            label4.Text = "Repeat password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 167);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 36;
            label1.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 96);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 35;
            label3.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 263);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 27);
            textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 193);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 122);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(169, 42);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 38;
            label2.Text = "Sign up";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.White;
            SignUpButton.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(110, 320);
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
            LogInPage.Location = new Point(146, 373);
            LogInPage.Name = "LogInPage";
            LogInPage.Size = new Size(158, 20);
            LogInPage.TabIndex = 40;
            LogInPage.TabStop = true;
            LogInPage.Text = "Already have account?";
            LogInPage.LinkClicked += LogInPage_LinkClicked;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(LogInPage);
            Controls.Add(SignUpButton);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Button SignUpButton;
        private LinkLabel LogInPage;
    }
}