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
            ListOfTasks = new DataGridView();
            ShowTasks = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListOfTasks).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyLists;
            pictureBox1.Location = new Point(364, 42);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(135, 206);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1075, 30);
            label2.TabIndex = 17;
            label2.Text = "______________________________________________________________________________________________________________________";
            // 
            // button1
            // 
            button1.Location = new Point(1008, 573);
            button1.Name = "button1";
            button1.Size = new Size(260, 104);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListOfTasks
            // 
            ListOfTasks.AllowUserToAddRows = false;
            ListOfTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListOfTasks.Columns.AddRange(new DataGridViewColumn[] { ShowTasks });
            ListOfTasks.Location = new Point(364, 267);
            ListOfTasks.Name = "ListOfTasks";
            ListOfTasks.RowHeadersWidth = 72;
            ListOfTasks.RowTemplate.Height = 37;
            ListOfTasks.Size = new Size(650, 368);
            ListOfTasks.TabIndex = 19;
            ListOfTasks.CellEndEdit += ListOfTasks_CellEndEdit;
            // 
            // ShowTasks
            // 
            ShowTasks.HeaderText = "ShowTasks";
            ShowTasks.MinimumWidth = 6;
            ShowTasks.Name = "ShowTasks";
            ShowTasks.ReadOnly = true;
            ShowTasks.Width = 125;
            // 
            // ListsMainScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(ListOfTasks);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ListsMainScreen";
            Size = new Size(1350, 750);
            Load += ListsMainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListOfTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private DataGridView ListOfTasks;
        private DataGridViewButtonColumn ShowTasks;
    }
}
