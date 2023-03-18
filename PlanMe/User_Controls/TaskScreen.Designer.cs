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
            SaveButton.Location = new Point(1082, 634);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(210, 90);
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
            TaskDataGridView.Location = new Point(100, 159);
            TaskDataGridView.Margin = new Padding(4);
            TaskDataGridView.Name = "TaskDataGridView";
            TaskDataGridView.RowHeadersWidth = 51;
            TaskDataGridView.RowTemplate.Height = 29;
            TaskDataGridView.Size = new Size(554, 566);
            TaskDataGridView.TabIndex = 15;
            TaskDataGridView.CellEndEdit += TaskDataGridView_CellEndEdit;
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.Transparent;
            AddTaskButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.ForestGreen;
            AddTaskButton.Location = new Point(862, 536);
            AddTaskButton.Margin = new Padding(4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(429, 90);
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
            label1.Location = new Point(291, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 56);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyLists;
            pictureBox1.Location = new Point(924, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.ForestGreen;
            BackButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(862, 634);
            BackButton.Margin = new Padding(4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(210, 90);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // TaskScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TaskScreenBG2;
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(AddTaskButton);
            Controls.Add(TaskDataGridView);
            Controls.Add(SaveButton);
            Margin = new Padding(4);
            Name = "TaskScreen";
            Size = new Size(1350, 750);
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
