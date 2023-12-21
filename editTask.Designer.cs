namespace ToDo
{
    partial class editTask
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
            textBox_id = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            AcceptChangesButton = new Button();
            textBoxtask = new TextBox();
            textBox_des = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(14, 1);
            textBox_id.Margin = new Padding(3, 4, 3, 4);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(114, 27);
            textBox_id.TabIndex = 0;
            textBox_id.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 238);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // AcceptChangesButton
            // 
            AcceptChangesButton.Anchor = AnchorStyles.Bottom;
            AcceptChangesButton.Location = new Point(159, 330);
            AcceptChangesButton.Margin = new Padding(3, 4, 3, 4);
            AcceptChangesButton.Name = "AcceptChangesButton";
            AcceptChangesButton.Size = new Size(164, 31);
            AcceptChangesButton.TabIndex = 2;
            AcceptChangesButton.Text = "Accept changes";
            AcceptChangesButton.UseVisualStyleBackColor = true;
            AcceptChangesButton.Click += AcceptChangesButtonClick;
            // 
            // textBoxtask
            // 
            textBoxtask.Location = new Point(125, 73);
            textBoxtask.Margin = new Padding(3, 4, 3, 4);
            textBoxtask.Multiline = true;
            textBoxtask.Name = "textBoxtask";
            textBoxtask.Size = new Size(219, 47);
            textBoxtask.TabIndex = 3;
            // 
            // textBox_des
            // 
            textBox_des.Location = new Point(125, 163);
            textBox_des.Margin = new Padding(3, 4, 3, 4);
            textBox_des.Multiline = true;
            textBox_des.Name = "textBox_des";
            textBox_des.Size = new Size(220, 54);
            textBox_des.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(203, 283);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Done";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 43);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 29;
            label2.Text = "Edit task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 137);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 30;
            label3.Text = "Description:";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 395);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox_des);
            Controls.Add(textBoxtask);
            Controls.Add(AcceptChangesButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_id);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private DateTimePicker dateTimePicker1;
        private Button AcceptChangesButton;
        private TextBox textBoxtask;
        private TextBox textBox_des;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
    }
}