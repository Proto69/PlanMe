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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 62);
            label1.TabIndex = 0;
            label1.Text = "Add a task";
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.ForestGreen;
            AddTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.WhiteSmoke;
            AddTaskButton.Location = new Point(232, 330);
            AddTaskButton.Margin = new Padding(4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(225, 75);
            AddTaskButton.TabIndex = 1;
            AddTaskButton.Text = "Add";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(216, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(265, 30);
            label2.TabIndex = 2;
            label2.Text = "____________________________";
            // 
            // NameOfTaskBox
            // 
            NameOfTaskBox.BackColor = Color.White;
            NameOfTaskBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfTaskBox.Location = new Point(118, 220);
            NameOfTaskBox.Margin = new Padding(4);
            NameOfTaskBox.Name = "NameOfTaskBox";
            NameOfTaskBox.PlaceholderText = "Write your task here...";
            NameOfTaskBox.Size = new Size(474, 45);
            NameOfTaskBox.TabIndex = 3;
            // 
            // AddATask
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(NameOfTaskBox);
            Controls.Add(AddTaskButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "AddATask";
            Size = new Size(728, 492);
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
