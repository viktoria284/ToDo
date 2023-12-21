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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.textBoxtask = new System.Windows.Forms.TextBox();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(12, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 23);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AcceptChangesButton.Location = new System.Drawing.Point(139, 248);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(144, 23);
            this.AcceptChangesButton.TabIndex = 2;
            this.AcceptChangesButton.Text = "Accept changes";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            // 
            // textBoxtask
            // 
            this.textBoxtask.Location = new System.Drawing.Point(109, 55);
            this.textBoxtask.Multiline = true;
            this.textBoxtask.Name = "textBoxtask";
            this.textBoxtask.Size = new System.Drawing.Size(192, 36);
            this.textBoxtask.TabIndex = 3;
            // 
            // textBox_des
            // 
            this.textBox_des.Location = new System.Drawing.Point(109, 122);
            this.textBox_des.Multiline = true;
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(193, 42);
            this.textBox_des.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(178, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Done";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Edit task:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Description:";
            // 
            // editTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_des);
            this.Controls.Add(this.textBoxtask);
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_id);
            this.Name = "editTask";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.editTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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