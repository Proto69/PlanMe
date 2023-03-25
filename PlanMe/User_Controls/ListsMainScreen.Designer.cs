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
            CreateListButton = new Button();
            ListOfTasks = new DataGridView();
            ShowTasks = new DataGridViewButtonColumn();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListOfTasks).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyLists;
            pictureBox1.Location = new Point(312, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(98, 134);
            label2.Name = "label2";
            label2.Size = new Size(717, 20);
            label2.TabIndex = 17;
            label2.Text = "______________________________________________________________________________________________________________________";
            // 
            // CreateListButton
            // 
            CreateListButton.Anchor = AnchorStyles.None;
            CreateListButton.BackColor = Color.ForestGreen;
            CreateListButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CreateListButton.ForeColor = SystemColors.ButtonHighlight;
            CreateListButton.Location = new Point(472, 408);
            CreateListButton.Margin = new Padding(2, 2, 2, 2);
            CreateListButton.Name = "CreateListButton";
            CreateListButton.Size = new Size(204, 62);
            CreateListButton.TabIndex = 18;
            CreateListButton.Text = "Create a list";
            CreateListButton.UseVisualStyleBackColor = false;
            CreateListButton.Click += CreateListButton_Click;
            // 
            // ListOfTasks
            // 
            ListOfTasks.AllowUserToAddRows = false;
            ListOfTasks.Anchor = AnchorStyles.None;
            ListOfTasks.BackgroundColor = SystemColors.Control;
            ListOfTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListOfTasks.Columns.AddRange(new DataGridViewColumn[] { ShowTasks });
            ListOfTasks.Location = new Point(243, 173);
            ListOfTasks.Margin = new Padding(2, 2, 2, 2);
            ListOfTasks.Name = "ListOfTasks";
            ListOfTasks.RowHeadersWidth = 72;
            ListOfTasks.RowTemplate.Height = 37;
            ListOfTasks.Size = new Size(433, 218);
            ListOfTasks.TabIndex = 19;
            ListOfTasks.CellContentClick += ListOfTasks_CellContentClick;
            ListOfTasks.CellEndEdit += ListOfTasks_CellEndEdit;
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
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.ForestGreen;
            BackButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(243, 408);
            BackButton.Margin = new Padding(2, 2, 2, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(204, 62);
            BackButton.TabIndex = 20;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ListsMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ListsMainScreenBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(BackButton);
            Controls.Add(ListOfTasks);
            Controls.Add(CreateListButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "ListsMainScreen";
            Size = new Size(900, 500);
            Load += ListsMainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListOfTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Button CreateListButton;
        private DataGridView ListOfTasks;
        private DataGridViewButtonColumn ShowTasks;
        private Button BackButton;
    }
}
