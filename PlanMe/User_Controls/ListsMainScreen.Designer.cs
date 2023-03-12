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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListOfTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PlanMe.Properties.Resources.MyLists;
            this.pictureBox1.Location = new System.Drawing.Point(364, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(135, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1075, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 103);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfTasks
            // 
            this.ListOfTasks.AllowUserToAddRows = false;
            this.ListOfTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfTasks.Location = new System.Drawing.Point(475, 267);
            this.ListOfTasks.Name = "ListOfTasks";
            this.ListOfTasks.RowHeadersWidth = 72;
            this.ListOfTasks.RowTemplate.Height = 37;
            this.ListOfTasks.Size = new System.Drawing.Size(419, 367);
            this.ListOfTasks.TabIndex = 19;
            this.ListOfTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfTasks_CellContentClick);
            // 
            // ListsMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlanMe.Properties.Resources.background;
            this.Controls.Add(this.ListOfTasks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListsMainScreen";
            this.Size = new System.Drawing.Size(1350, 750);
            this.Load += new System.EventHandler(this.ListsMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private DataGridView ListOfTasks;
    }
}
