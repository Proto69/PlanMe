namespace PlanMe.User_Controls
{
    partial class Plans
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
            AddPlanButton = new Button();
            SeePlanButton = new Button();
            BackButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MyPlans;
            pictureBox1.Location = new Point(170, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AddPlanButton
            // 
            AddPlanButton.BackColor = Color.ForestGreen;
            AddPlanButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddPlanButton.ForeColor = SystemColors.ButtonHighlight;
            AddPlanButton.Location = new Point(458, 327);
            AddPlanButton.Name = "AddPlanButton";
            AddPlanButton.Size = new Size(255, 70);
            AddPlanButton.TabIndex = 1;
            AddPlanButton.Text = "Add a plan";
            AddPlanButton.UseVisualStyleBackColor = false;
            AddPlanButton.Click += AddPlanButton_Click;
            // 
            // SeePlanButton
            // 
            SeePlanButton.BackColor = Color.ForestGreen;
            SeePlanButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SeePlanButton.ForeColor = SystemColors.ButtonHighlight;
            SeePlanButton.Location = new Point(170, 236);
            SeePlanButton.Name = "SeePlanButton";
            SeePlanButton.Size = new Size(543, 70);
            SeePlanButton.TabIndex = 2;
            SeePlanButton.Text = "See a plan";
            SeePlanButton.UseVisualStyleBackColor = false;
            SeePlanButton.Click += SeePlanButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.ForestGreen;
            BackButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(170, 327);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(255, 70);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(108, 180);
            label2.Name = "label2";
            label2.Size = new Size(699, 20);
            label2.TabIndex = 18;
            label2.Text = "___________________________________________________________________________________________________________________";
            // 
            // Plans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PlansBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(BackButton);
            Controls.Add(SeePlanButton);
            Controls.Add(AddPlanButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Plans";
            Size = new Size(900, 500);
            Load += Plans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AddPlanButton;
        private Button SeePlanButton;
        private Button BackButton;
        private Label label2;
    }
}
