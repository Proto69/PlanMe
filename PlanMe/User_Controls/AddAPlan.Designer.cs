﻿namespace PlanMe.User_Controls
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
            button1 = new Button();
            label2 = new Label();
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
            DateBox.PlaceholderText = "Date";
            DateBox.Size = new Size(306, 32);
            DateBox.TabIndex = 3;
            // 
            // InfoBox
            // 
            InfoBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            InfoBox.Location = new Point(137, 253);
            InfoBox.Name = "InfoBox";
            InfoBox.PlaceholderText = "About";
            InfoBox.Size = new Size(306, 32);
            InfoBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(201, 313);
            button1.Name = "button1";
            button1.Size = new Size(183, 47);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // AddAPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(button1);
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
        private Button button1;
        private Label label2;
    }
}