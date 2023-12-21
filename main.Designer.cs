namespace ToDo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            RefreshButton = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SubjectsComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            AddSubjectButton = new ToolStripMenuItem();
            DeleteSubjectButton = new ToolStripMenuItem();
            EditButton = new Button();
            DeleteButton = new Button();
            DoneButton = new Button();
            textBox_task = new TextBox();
            textBox_desk = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            AddTaskButton = new Button();
            dateTimePicker2 = new DateTimePicker();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(44, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(26, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(825, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
 
            // 
            // RefreshButton
            // 
 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(44, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(44, 235);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(645, 213);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(787, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(712, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Страт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(800, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cтоп";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(888, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Сброс";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
 
            RefreshButton.BackColor = Color.White;
            RefreshButton.BackgroundImageLayout = ImageLayout.Center;
            RefreshButton.Location = new Point(1001, 194);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(107, 40);
            RefreshButton.TabIndex = 1;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButtonClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.Location = new Point(26, 298);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(825, 315);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 641);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 4;
            label1.Text = "00:00:00";
            // 
            // button2
            // 
            button2.Location = new Point(170, 701);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 61);
            button2.TabIndex = 5;
            button2.Text = "Страт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 701);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 61);
            button3.TabIndex = 6;
            button3.Text = "Cтоп";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(371, 701);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(94, 61);
            button4.TabIndex = 7;
            button4.Text = "Сброс";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
 
            // 
            // SubjectsComboBox
            
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
 
            SubjectsComboBox.BackColor = Color.WhiteSmoke;
            SubjectsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubjectsComboBox.FormattingEnabled = true;
            SubjectsComboBox.Location = new Point(888, 73);
            SubjectsComboBox.Margin = new Padding(3, 4, 3, 4);
            SubjectsComboBox.Name = "SubjectsComboBox";
            SubjectsComboBox.Size = new Size(220, 36);
            SubjectsComboBox.TabIndex = 11;
            SubjectsComboBox.SelectedIndexChanged += SubjectsComboBox_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1128, 30);
            menuStrip1.TabIndex = 12;
 
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddSubjectButton, DeleteSubjectButton });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // AddSubjectButton
            // 
            AddSubjectButton.Name = "AddSubjectButton";
            AddSubjectButton.Size = new Size(185, 26);
            AddSubjectButton.Text = "add subject";
            AddSubjectButton.Click += AddSubjectButtonClick;
            // 
            // DeleteSubjectButton
            // 
            DeleteSubjectButton.Name = "DeleteSubjectButton";
            DeleteSubjectButton.Size = new Size(185, 26);
            DeleteSubjectButton.Text = "delete subject";
            DeleteSubjectButton.Click += DeleteSubjectButtonClick;
            // 
            // EditButton
            // 
 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(550, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 105);
            this.button7.TabIndex = 15;
            this.button7.Text = "Изменить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(888, 148);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(107, 40);
            EditButton.TabIndex = 15;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButtonClick;
             // 
            // DeleteButton
            // 
 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(380, 470);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 104);
            this.button8.TabIndex = 16;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.delete_Click);
 
            DeleteButton.BackColor = Color.White;
            DeleteButton.Location = new Point(1001, 148);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 40);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButtonClick;
 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(211, 472);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 101);
            this.button9.TabIndex = 17;
            this.button9.Text = "Выполнил(а)";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox_task
            // 
            this.textBox_task.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_task.Location = new System.Drawing.Point(747, 235);
            this.textBox_task.Multiline = true;
            this.textBox_task.Name = "textBox_task";
            this.textBox_task.Size = new System.Drawing.Size(200, 52);
            this.textBox_task.TabIndex = 18;
            // 
            // textBox_desk
            // 
            this.textBox_desk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_desk.Location = new System.Drawing.Point(747, 319);
            this.textBox_desk.Multiline = true;
            this.textBox_desk.Name = "textBox_desk";
            this.textBox_desk.Size = new System.Drawing.Size(200, 48);
            this.textBox_desk.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(747, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 22;
             DoneButton.BackColor = Color.White;
            DoneButton.Location = new Point(888, 194);
            DoneButton.Margin = new Padding(3, 4, 3, 4);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(107, 40);
            DoneButton.TabIndex = 17;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneClick;
            // 
            // textBox_task
            // 
            textBox_task.Location = new Point(888, 328);
            textBox_task.Margin = new Padding(3, 4, 3, 4);
            textBox_task.Multiline = true;
            textBox_task.Name = "textBox_task";
            textBox_task.Size = new Size(220, 54);
            textBox_task.TabIndex = 18;
            // 
            // textBox_desk
            // 
            textBox_desk.Location = new Point(888, 432);
            textBox_desk.Margin = new Padding(3, 4, 3, 4);
            textBox_desk.Multiline = true;
            textBox_desk.Name = "textBox_desk";
            textBox_desk.Size = new Size(220, 54);
            textBox_desk.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(888, 516);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 22;
 
            this.button5.Location = new System.Drawing.Point(769, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 44);
            this.button5.TabIndex = 23;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(712, 159);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(258, 23);
            this.dateTimePicker2.TabIndex = 24;
 
            AddTaskButton.BackColor = Color.White;
            AddTaskButton.Location = new Point(911, 573);
            AddTaskButton.Margin = new Padding(3, 4, 3, 4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(177, 40);
            AddTaskButton.TabIndex = 23;
            AddTaskButton.Text = "Add task";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += AddTaskButtonClick;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(888, 34);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 24;
            dateTimePicker2.Visible = false;
 
            // 
            // button6
            // 
            button6.Location = new Point(26, 632);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(26, 31);
            button6.TabIndex = 26;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label2
            // 
 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1014, 650);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_desk);
            this.Controls.Add(this.textBox_task);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(888, 298);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 27;
            label2.Text = "New task:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(888, 406);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 28;
            label3.Text = "Description:";
            label3.Click += label3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1128, 845);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(dateTimePicker2);
            Controls.Add(AddTaskButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_desk);
            Controls.Add(textBox_task);
            Controls.Add(DoneButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SubjectsComboBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(RefreshButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
 
        }

        #endregion

        private DataGridView dataGridView1;
        private Button RefreshButton;
        private DataGridView dataGridView2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox SubjectsComboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem AddSubjectButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button DoneButton;
        private TextBox textBox_task;
        private TextBox textBox_desk;
        private DateTimePicker dateTimePicker1;
        private Button AddTaskButton;
        private ToolStripMenuItem DeleteSubjectButton;
        private DateTimePicker dateTimePicker2;
        private Button button6;
        private Label label2;
        private Label label3;
    }
}