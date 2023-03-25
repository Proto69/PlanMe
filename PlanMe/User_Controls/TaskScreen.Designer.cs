namespace PlanMe.User_Controls
{
    partial class TaskScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            TaskDataGridView = new DataGridView();
            AddTaskButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TaskDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.ForestGreen;
            SaveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.WhiteSmoke;
            SaveButton.Location = new Point(721, 423);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 60);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // TaskDataGridView
            // 
            TaskDataGridView.AllowUserToAddRows = false;
            TaskDataGridView.BackgroundColor = SystemColors.Control;
            TaskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskDataGridView.Location = new Point(69, 106);
            TaskDataGridView.Name = "TaskDataGridView";
            TaskDataGridView.RowHeadersWidth = 51;
            TaskDataGridView.RowTemplate.Height = 29;
            TaskDataGridView.Size = new Size(367, 377);
            TaskDataGridView.TabIndex = 15;
            TaskDataGridView.CellEndEdit += TaskDataGridView_CellEndEdit;
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.Transparent;
            AddTaskButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.ForestGreen;
            AddTaskButton.Location = new Point(575, 357);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(286, 60);
            AddTaskButton.TabIndex = 16;
            AddTaskButton.Text = "Add a task";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(194, 61);
            label1.Name = "label1";
            label1.Size = new Size(96, 42);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyLists;
            pictureBox1.Location = new Point(616, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.ForestGreen;
            BackButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(575, 423);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(140, 60);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // TaskScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TaskScreenBG2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(AddTaskButton);
            Controls.Add(TaskDataGridView);
            Controls.Add(SaveButton);
            DoubleBuffered = true;
            Name = "TaskScreen";
            Size = new Size(900, 500);
            Load += TaskScreen_Load;
            ((System.ComponentModel.ISupportInitialize)TaskDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private DataGridView TaskDataGridView;
        private Button AddTaskButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BackButton;
    }
}
