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
            SubjectsComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            AddSubjectButton = new ToolStripMenuItem();
            DeleteSubjectButton = new ToolStripMenuItem();
            RegNewUser = new ToolStripMenuItem();
            EditButton = new Button();
            DeleteButton = new Button();
            DoneButton = new Button();
            textBox_task = new TextBox();
            textBox_desk = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            AddTaskButton = new Button();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
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
            dataGridView1.Size = new Size(700, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.White;
            RefreshButton.BackgroundImageLayout = ImageLayout.Center;
            RefreshButton.Location = new Point(889, 174);
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
            dataGridView2.Size = new Size(700, 315);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // SubjectsComboBox
            // 
            SubjectsComboBox.BackColor = Color.WhiteSmoke;
            SubjectsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubjectsComboBox.FormattingEnabled = true;
            SubjectsComboBox.Location = new Point(776, 73);
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
            menuStrip1.Size = new Size(1033, 30);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddSubjectButton, DeleteSubjectButton, RegNewUser });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // AddSubjectButton
            // 
            AddSubjectButton.Name = "AddSubjectButton";
            AddSubjectButton.Size = new Size(224, 26);
            AddSubjectButton.Text = "add subject";
            AddSubjectButton.Click += AddSubjectButtonClick;
            // 
            // DeleteSubjectButton
            // 
            DeleteSubjectButton.Name = "DeleteSubjectButton";
            DeleteSubjectButton.Size = new Size(224, 26);
            DeleteSubjectButton.Text = "delete subject";
            DeleteSubjectButton.Click += DeleteSubjectButtonClick;
            // 
            // RegNewUser
            // 
            RegNewUser.Name = "RegNewUser";
            RegNewUser.Size = new Size(224, 26);
            RegNewUser.Text = "reg new user";
            RegNewUser.Click += RegNewUser_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(776, 233);
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
            DeleteButton.BackColor = Color.White;
            DeleteButton.Location = new Point(889, 233);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 40);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButtonClick;
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.White;
            DoneButton.Location = new Point(776, 174);
            DoneButton.Margin = new Padding(3, 4, 3, 4);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(107, 40);
            DoneButton.TabIndex = 17;
            DoneButton.Text = "(Un)done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneClick;
            // 
            // textBox_task
            // 
            textBox_task.Location = new Point(776, 328);
            textBox_task.Margin = new Padding(3, 4, 3, 4);
            textBox_task.Multiline = true;
            textBox_task.Name = "textBox_task";
            textBox_task.Size = new Size(220, 54);
            textBox_task.TabIndex = 18;
            // 
            // textBox_desk
            // 
            textBox_desk.Location = new Point(776, 432);
            textBox_desk.Margin = new Padding(3, 4, 3, 4);
            textBox_desk.Multiline = true;
            textBox_desk.Name = "textBox_desk";
            textBox_desk.Size = new Size(220, 54);
            textBox_desk.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(776, 516);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.White;
            AddTaskButton.Location = new Point(799, 573);
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
            dateTimePicker2.Location = new Point(776, 34);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 24;
            dateTimePicker2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(776, 298);
            label2.Name = "label2";
            label2.Size = new Size(116, 26);
            label2.TabIndex = 27;
            label2.Text = "New task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(776, 406);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 28;
            label3.Text = "Description:";
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Location = new Point(889, 117);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(107, 40);
            button10.TabIndex = 29;
            button10.Text = "All";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1033, 646);
            Controls.Add(button10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(AddTaskButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_desk);
            Controls.Add(textBox_task);
            Controls.Add(DoneButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SubjectsComboBox);
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
        private Label label2;
        private Label label3;
        private Button button10;
        private Button button1;
        private ToolStripMenuItem RegNewUser;
    }
}