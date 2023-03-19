﻿namespace PlanMe.User_Controls
{
    partial class AddAList
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
            label2 = new Label();
            CreateListButton = new Button();
            ListNameBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 1;
            label1.Text = "Create a list";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(189, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 3;
            label2.Text = "________________________________";
            // 
            // CreateListButton
            // 
            CreateListButton.BackColor = Color.ForestGreen;
            CreateListButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateListButton.ForeColor = SystemColors.Control;
            CreateListButton.Location = new Point(201, 252);
            CreateListButton.Margin = new Padding(2, 2, 2, 2);
            CreateListButton.Name = "CreateListButton";
            CreateListButton.Size = new Size(183, 67);
            CreateListButton.TabIndex = 4;
            CreateListButton.Text = "Create";
            CreateListButton.UseVisualStyleBackColor = false;
            CreateListButton.Click += CreateListButton_Click;
            // 
            // ListNameBox
            // 
            ListNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListNameBox.Location = new Point(180, 170);
            ListNameBox.Margin = new Padding(2, 2, 2, 2);
            ListNameBox.Name = "ListNameBox";
            ListNameBox.PlaceholderText = "Write list's name...";
            ListNameBox.Size = new Size(224, 34);
            ListNameBox.TabIndex = 5;
            // 
            // AddAList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(ListNameBox);
            Controls.Add(CreateListButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAList";
            Size = new Size(600, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CreateListButton;
        private TextBox ListNameBox;
    }
}
