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
            saveButton = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(721, 423);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 60);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(369, 377);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(575, 357);
            button1.Name = "button1";
            button1.Size = new Size(286, 60);
            button1.TabIndex = 16;
            button1.Text = "Add a task";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(575, 423);
            button2.Name = "button2";
            button2.Size = new Size(140, 60);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += back_Click;
            // 
            // TaskScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TaskScreenBG2;
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(saveButton);
            Name = "TaskScreen";
            Size = new Size(900, 500);
            Load += TaskScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveButton;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
