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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            saveButton = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 2;
            label2.Text = "__________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(653, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 77);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.ForestGreen;
            saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.WhiteSmoke;
            saveButton.Location = new Point(731, 423);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 60);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.ForestGreen;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.LightGray;
            textBox1.Location = new Point(35, 29);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(348, 52);
            textBox1.TabIndex = 14;
            textBox1.Text = " All tasks";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(345, 377);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // TaskScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(saveButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "TaskScreen";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Button saveButton;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
