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
            addButton = new Button();
            label2 = new Label();
            text = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 50);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 0;
            label1.Text = "Add a task";
            // 
            // addButton
            // 
            addButton.BackColor = Color.ForestGreen;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.WhiteSmoke;
            addButton.Location = new Point(232, 230);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 50);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(144, 86);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 2;
            label2.Text = "____________________________";
            // 
            // text
            // 
            text.BackColor = Color.White;
            text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text.Location = new Point(79, 147);
            text.Name = "text";
            text.PlaceholderText = "Write your task here...";
            text.Size = new Size(317, 34);
            text.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(79, 230);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddATask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(button1);
            Controls.Add(text);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddATask";
            Size = new Size(485, 328);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Label label2;
        private TextBox text;
        private Button button1;
    }
}
