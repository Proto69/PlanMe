namespace PlanMe.User_Controls
{
    partial class AddATask
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
            AddTaskButton = new Button();
            label2 = new Label();
            NameOfTaskBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 54);
            label1.TabIndex = 0;
            label1.Text = "Add a task";
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.ForestGreen;
            AddTaskButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.WhiteSmoke;
            AddTaskButton.Location = new Point(208, 292);
            AddTaskButton.Margin = new Padding(2);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(166, 61);
            AddTaskButton.TabIndex = 1;
            AddTaskButton.Text = "Add";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(142, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 2;
            label2.Text = "___________________________________________________";
            // 
            // NameOfTaskBox
            // 
            NameOfTaskBox.BackColor = Color.White;
            NameOfTaskBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfTaskBox.Location = new Point(157, 197);
            NameOfTaskBox.Margin = new Padding(2);
            NameOfTaskBox.Name = "NameOfTaskBox";
            NameOfTaskBox.PlaceholderText = "Write your task here...";
            NameOfTaskBox.Size = new Size(278, 36);
            NameOfTaskBox.TabIndex = 3;
            // 
            // AddATask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(NameOfTaskBox);
            Controls.Add(AddTaskButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddATask";
            Size = new Size(600, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddTaskButton;
        private Label label2;
        private TextBox NameOfTaskBox;
    }
}
