namespace PlanMe.User_Controls
{
    partial class ListsMainScreen
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            listOfTasks = new DataGridView();
            ShowTasks = new DataGridViewButtonColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listOfTasks).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyLists;
            pictureBox1.Location = new Point(243, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(90, 137);
            label2.Name = "label2";
            label2.Size = new Size(717, 20);
            label2.TabIndex = 17;
            label2.Text = "______________________________________________________________________________________________________________________";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(472, 408);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(204, 53);
            button1.TabIndex = 18;
            button1.Text = "Create a list";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listOfTasks
            // 
            listOfTasks.AllowUserToAddRows = false;
            listOfTasks.Anchor = AnchorStyles.None;
            listOfTasks.BackgroundColor = SystemColors.Control;
            listOfTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listOfTasks.Columns.AddRange(new DataGridViewColumn[] { ShowTasks });
            listOfTasks.Location = new Point(243, 178);
            listOfTasks.Margin = new Padding(2);
            listOfTasks.Name = "listOfTasks";
            listOfTasks.RowHeadersWidth = 72;
            listOfTasks.RowTemplate.Height = 37;
            listOfTasks.Size = new Size(433, 209);
            listOfTasks.TabIndex = 19;
            listOfTasks.CellContentClick += dataGridView1_CellContentClick;
            listOfTasks.CellEndEdit += ListOfTasks_CellEndEdit;
            // 
            // ShowTasks
            // 
            ShowTasks.HeaderText = "ShowTasks";
            ShowTasks.MinimumWidth = 6;
            ShowTasks.Name = "ShowTasks";
            ShowTasks.ReadOnly = true;
            ShowTasks.Text = "Show Tasks";
            ShowTasks.Width = 125;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(243, 408);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(204, 53);
            button2.TabIndex = 20;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // ListsMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ListsMainScreenBG;
            Controls.Add(button2);
            Controls.Add(listOfTasks);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "ListsMainScreen";
            Size = new Size(900, 500);
            Load += ListsMainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)listOfTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private DataGridView listOfTasks;
        private DataGridViewButtonColumn ShowTasks;
        private Button button2;
    }
}
