namespace PlanMe.User_Controls
{
    partial class AddAPlan
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
            label1 = new Label();
            NameBox = new TextBox();
            DateBox = new TextBox();
            InfoBox = new TextBox();
            AddPlanButton = new Button();
            label2 = new Label();
            timeBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 62);
            label1.Name = "label1";
            label1.Size = new Size(181, 46);
            label1.TabIndex = 1;
            label1.Text = "Add a plan";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(137, 148);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name ";
            NameBox.Size = new Size(306, 32);
            NameBox.TabIndex = 2;
            // 
            // DateBox
            // 
            DateBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DateBox.Location = new Point(140, 198);
            DateBox.Name = "DateBox";
            DateBox.PlaceholderText = "Date (dd/MM/yyyy)";
            DateBox.Size = new Size(306, 32);
            DateBox.TabIndex = 3;
            // 
            // InfoBox
            // 
            InfoBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InfoBox.Location = new Point(140, 296);
            InfoBox.Name = "InfoBox";
            InfoBox.PlaceholderText = "About";
            InfoBox.Size = new Size(306, 32);
            InfoBox.TabIndex = 5;
            // 
            // AddPlanButton
            // 
            AddPlanButton.BackColor = Color.ForestGreen;
            AddPlanButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddPlanButton.ForeColor = SystemColors.ButtonHighlight;
            AddPlanButton.Location = new Point(220, 334);
            AddPlanButton.Name = "AddPlanButton";
            AddPlanButton.Size = new Size(143, 47);
            AddPlanButton.TabIndex = 7;
            AddPlanButton.Text = "Add";
            AddPlanButton.UseVisualStyleBackColor = false;
            AddPlanButton.Click += AddPlanButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(137, 98);
            label2.Name = "label2";
            label2.Size = new Size(309, 20);
            label2.TabIndex = 6;
            label2.Text = "__________________________________________________";
            // 
            // timeBox
            // 
            timeBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            timeBox.Location = new Point(140, 246);
            timeBox.Name = "timeBox";
            timeBox.PlaceholderText = "Time (hh:mm:ss)";
            timeBox.Size = new Size(306, 32);
            timeBox.TabIndex = 4;
            // 
            // AddAPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(timeBox);
            Controls.Add(AddPlanButton);
            Controls.Add(InfoBox);
            Controls.Add(DateBox);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddAPlan";
            Size = new Size(600, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private TextBox DateBox;
        private TextBox InfoBox;
        private Button AddPlanButton;
        private Label label2;
        private TextBox timeBox;
    }
}
