namespace PlanMe.User_Controls
{
    partial class SeeAPlan
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
            DatePlanPicker = new DateTimePicker();
            label2 = new Label();
            ShowButton = new Button();
            PlansDataGridView = new DataGridView();
            ClearDateButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlansDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 46);
            label1.Name = "label1";
            label1.Size = new Size(205, 54);
            label1.TabIndex = 2;
            label1.Text = "See a plan";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(47, 127);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Enter name ...";
            NameBox.Size = new Size(243, 30);
            NameBox.TabIndex = 3;
            // 
            // DatePlanPicker
            // 
            DatePlanPicker.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DatePlanPicker.Location = new Point(47, 174);
            DatePlanPicker.Name = "DatePlanPicker";
            DatePlanPicker.Size = new Size(243, 30);
            DatePlanPicker.TabIndex = 4;
            DatePlanPicker.Value = new DateTime(2023, 3, 14, 16, 42, 27, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(267, 20);
            label2.TabIndex = 5;
            label2.Text = "___________________________________________";
            // 
            // ShowButton
            // 
            ShowButton.BackColor = Color.ForestGreen;
            ShowButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ShowButton.ForeColor = SystemColors.ButtonHighlight;
            ShowButton.Location = new Point(47, 316);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(243, 62);
            ShowButton.TabIndex = 6;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = false;
            ShowButton.Click += ShowButton_Click;
            // 
            // PlansDataGridView
            // 
            PlansDataGridView.AllowUserToAddRows = false;
            PlansDataGridView.BackgroundColor = SystemColors.Control;
            PlansDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlansDataGridView.Location = new Point(367, 19);
            PlansDataGridView.Name = "PlansDataGridView";
            PlansDataGridView.RowHeadersWidth = 51;
            PlansDataGridView.Size = new Size(515, 465);
            PlansDataGridView.TabIndex = 7;
            PlansDataGridView.CellEndEdit += PlansDataGridView_CellEndEdit;
            // 
            // ClearDateButton
            // 
            ClearDateButton.BackColor = Color.Transparent;
            ClearDateButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ClearDateButton.ForeColor = Color.ForestGreen;
            ClearDateButton.Location = new Point(47, 225);
            ClearDateButton.Name = "ClearDateButton";
            ClearDateButton.Size = new Size(243, 39);
            ClearDateButton.TabIndex = 8;
            ClearDateButton.Text = "Clear date";
            ClearDateButton.UseVisualStyleBackColor = false;
            ClearDateButton.Click += ClearDateButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.ForestGreen;
            BackButton.Location = new Point(47, 384);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(243, 52);
            BackButton.TabIndex = 10;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SeeAPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SeeAPlanBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(BackButton);
            Controls.Add(ClearDateButton);
            Controls.Add(PlansDataGridView);
            Controls.Add(ShowButton);
            Controls.Add(DatePlanPicker);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "SeeAPlan";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)PlansDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private DateTimePicker DatePlanPicker;
        private Label label2;
        private Button ShowButton;
        private DataGridView PlansDataGridView;
        private Button ClearDateButton;
        private Button BackButton;
    }
}
