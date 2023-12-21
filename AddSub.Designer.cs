namespace ToDo
{
    partial class AddSub
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
            textBox1 = new TextBox();
            AddSubjectButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(63, 61);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 0;
            // 
            // AddSubjectButton
            // 
            AddSubjectButton.BackColor = Color.White;
            AddSubjectButton.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddSubjectButton.Location = new Point(63, 400);
            AddSubjectButton.Margin = new Padding(3, 4, 3, 4);
            AddSubjectButton.Name = "AddSubjectButton";
            AddSubjectButton.Size = new Size(220, 44);
            AddSubjectButton.TabIndex = 1;
            AddSubjectButton.Text = "Add subject";
            AddSubjectButton.UseVisualStyleBackColor = false;
            AddSubjectButton.Click += AddSubjectButtonClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 130);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(63, 202);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 273);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(63, 344);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 27);
            textBox5.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 31);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 28;
            label2.Text = "New subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 104);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 29;
            label3.Text = "Exam type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 176);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 30;
            label1.Text = "Teachers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 247);
            label4.Name = "label4";
            label4.Size = new Size(141, 22);
            label4.TabIndex = 31;
            label4.Text = "Requirements:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 318);
            label5.Name = "label5";
            label5.Size = new Size(67, 22);
            label5.TabIndex = 32;
            label5.Text = "Notes:";
            // 
            // AddSub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(353, 493);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(AddSubjectButton);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddSub";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button AddSubjectButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}