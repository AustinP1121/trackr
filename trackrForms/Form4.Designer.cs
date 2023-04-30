namespace trackrForms
{
    partial class EditHabits
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editHabitButton = new System.Windows.Forms.Button();
            this.deleteHabitButton = new System.Windows.Forms.Button();
            this.habitDataGridView = new System.Windows.Forms.DataGridView();
            this.habit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.habitTableTableAdap = new trackrForms.trackrDBDataSetTableAdapters.habitTableTableAdapter();
            this.posNegComboBox = new System.Windows.Forms.ComboBox();
            this.newHabitNameLabel = new System.Windows.Forms.Label();
            this.posNegLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.acceptChangesButton = new System.Windows.Forms.Button();
            this.currentlyTrackingLabel = new System.Windows.Forms.Label();
            this.currentlyTrackingCheckBox = new System.Windows.Forms.CheckBox();
            this.habitHistoryTableTableAdap = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            this.returnToDashboardButton = new System.Windows.Forms.Button();
            this.editDeleteContainer = new System.Windows.Forms.GroupBox();
            this.newHabitNameTextBox = new System.Windows.Forms.TextBox();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.editDeleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.habitDataGridView)).BeginInit();
            this.editDeleteContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // editHabitButton
            // 
            this.editHabitButton.Location = new System.Drawing.Point(105, 475);
            this.editHabitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editHabitButton.Name = "editHabitButton";
            this.editHabitButton.Size = new System.Drawing.Size(113, 28);
            this.editHabitButton.TabIndex = 1;
            this.editHabitButton.Text = "Edit Habit";
            this.editHabitButton.UseVisualStyleBackColor = true;
            this.editHabitButton.Click += new System.EventHandler(this.editHabitButton_Click);
            // 
            // deleteHabitButton
            // 
            this.deleteHabitButton.Location = new System.Drawing.Point(244, 475);
            this.deleteHabitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteHabitButton.Name = "deleteHabitButton";
            this.deleteHabitButton.Size = new System.Drawing.Size(120, 28);
            this.deleteHabitButton.TabIndex = 2;
            this.deleteHabitButton.Text = "Delete Habit";
            this.deleteHabitButton.UseVisualStyleBackColor = true;
            this.deleteHabitButton.Click += new System.EventHandler(this.deleteHabitButton_Click);
            // 
            // habitDataGridView
            // 
            this.habitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habit,
            this.tracked});
            this.habitDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.habitDataGridView.Location = new System.Drawing.Point(75, 98);
            this.habitDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.habitDataGridView.Name = "habitDataGridView";
            this.habitDataGridView.RowHeadersWidth = 51;
            this.habitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.habitDataGridView.Size = new System.Drawing.Size(324, 352);
            this.habitDataGridView.TabIndex = 3;
            this.habitDataGridView.SelectionChanged += new System.EventHandler(this.habitDataGridView_SelectionChanged);
            // 
            // habit
            // 
            this.habit.HeaderText = "Habit Name";
            this.habit.MinimumWidth = 6;
            this.habit.Name = "habit";
            this.habit.Width = 125;
            // 
            // tracked
            // 
            this.tracked.HeaderText = "Currently Tracked";
            this.tracked.MinimumWidth = 6;
            this.tracked.Name = "tracked";
            this.tracked.Width = 125;
            // 
            // habitTableTableAdap
            // 
            this.habitTableTableAdap.ClearBeforeFill = true;
            // 
            // posNegComboBox
            // 
            this.posNegComboBox.FormattingEnabled = true;
            this.posNegComboBox.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.posNegComboBox.Location = new System.Drawing.Point(597, 327);
            this.posNegComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.posNegComboBox.Name = "posNegComboBox";
            this.posNegComboBox.Size = new System.Drawing.Size(160, 24);
            this.posNegComboBox.TabIndex = 6;
            this.posNegComboBox.Visible = false;
            // 
            // newHabitNameLabel
            // 
            this.newHabitNameLabel.AutoSize = true;
            this.newHabitNameLabel.Location = new System.Drawing.Point(640, 197);
            this.newHabitNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newHabitNameLabel.Name = "newHabitNameLabel";
            this.newHabitNameLabel.Size = new System.Drawing.Size(82, 17);
            this.newHabitNameLabel.TabIndex = 7;
            this.newHabitNameLabel.Text = "Habit Name";
            this.newHabitNameLabel.Visible = false;
            // 
            // posNegLabel
            // 
            this.posNegLabel.AutoSize = true;
            this.posNegLabel.Location = new System.Drawing.Point(617, 298);
            this.posNegLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.posNegLabel.Name = "posNegLabel";
            this.posNegLabel.Size = new System.Drawing.Size(117, 17);
            this.posNegLabel.TabIndex = 8;
            this.posNegLabel.Text = "Positive/Negative";
            this.posNegLabel.Visible = false;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(641, 398);
            this.thresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(72, 17);
            this.thresholdLabel.TabIndex = 9;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.Visible = false;
            // 
            // acceptChangesButton
            // 
            this.acceptChangesButton.Location = new System.Drawing.Point(605, 475);
            this.acceptChangesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptChangesButton.Name = "acceptChangesButton";
            this.acceptChangesButton.Size = new System.Drawing.Size(147, 28);
            this.acceptChangesButton.TabIndex = 10;
            this.acceptChangesButton.Text = "Accept Changes";
            this.acceptChangesButton.UseVisualStyleBackColor = true;
            this.acceptChangesButton.Visible = false;
            this.acceptChangesButton.Click += new System.EventHandler(this.acceptChangesButton_Click);
            // 
            // currentlyTrackingLabel
            // 
            this.currentlyTrackingLabel.AutoSize = true;
            this.currentlyTrackingLabel.Location = new System.Drawing.Point(613, 102);
            this.currentlyTrackingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentlyTrackingLabel.Name = "currentlyTrackingLabel";
            this.currentlyTrackingLabel.Size = new System.Drawing.Size(131, 17);
            this.currentlyTrackingLabel.TabIndex = 11;
            this.currentlyTrackingLabel.Text = "Continue Tracking?";
            this.currentlyTrackingLabel.Visible = false;
            // 
            // currentlyTrackingCheckBox
            // 
            this.currentlyTrackingCheckBox.AutoSize = true;
            this.currentlyTrackingCheckBox.Location = new System.Drawing.Point(668, 130);
            this.currentlyTrackingCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentlyTrackingCheckBox.Name = "currentlyTrackingCheckBox";
            this.currentlyTrackingCheckBox.Size = new System.Drawing.Size(18, 17);
            this.currentlyTrackingCheckBox.TabIndex = 12;
            this.currentlyTrackingCheckBox.UseVisualStyleBackColor = true;
            this.currentlyTrackingCheckBox.Visible = false;
            // 
            // habitHistoryTableTableAdap
            // 
            this.habitHistoryTableTableAdap.ClearBeforeFill = true;
            // 
            // returnToDashboardButton
            // 
            this.returnToDashboardButton.Location = new System.Drawing.Point(357, 527);
            this.returnToDashboardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnToDashboardButton.Name = "returnToDashboardButton";
            this.returnToDashboardButton.Size = new System.Drawing.Size(184, 28);
            this.returnToDashboardButton.TabIndex = 13;
            this.returnToDashboardButton.Text = "Return to Dashboard";
            this.returnToDashboardButton.UseVisualStyleBackColor = true;
            this.returnToDashboardButton.Click += new System.EventHandler(this.returnToDashboardButton_Click);
            // 
            // editDeleteContainer
            // 
            this.editDeleteContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editDeleteContainer.Controls.Add(this.newHabitNameTextBox);
            this.editDeleteContainer.Controls.Add(this.thresholdNumericUpDown);
            this.editDeleteContainer.Controls.Add(this.editDeleteLabel);
            this.editDeleteContainer.Controls.Add(this.habitDataGridView);
            this.editDeleteContainer.Controls.Add(this.returnToDashboardButton);
            this.editDeleteContainer.Controls.Add(this.editHabitButton);
            this.editDeleteContainer.Controls.Add(this.currentlyTrackingCheckBox);
            this.editDeleteContainer.Controls.Add(this.deleteHabitButton);
            this.editDeleteContainer.Controls.Add(this.currentlyTrackingLabel);
            this.editDeleteContainer.Controls.Add(this.acceptChangesButton);
            this.editDeleteContainer.Controls.Add(this.thresholdLabel);
            this.editDeleteContainer.Controls.Add(this.posNegComboBox);
            this.editDeleteContainer.Controls.Add(this.posNegLabel);
            this.editDeleteContainer.Controls.Add(this.newHabitNameLabel);
            this.editDeleteContainer.Location = new System.Drawing.Point(131, 15);
            this.editDeleteContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editDeleteContainer.Name = "editDeleteContainer";
            this.editDeleteContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editDeleteContainer.Size = new System.Drawing.Size(877, 588);
            this.editDeleteContainer.TabIndex = 14;
            this.editDeleteContainer.TabStop = false;
            // 
            // newHabitNameTextBox
            // 
            this.newHabitNameTextBox.Location = new System.Drawing.Point(597, 228);
            this.newHabitNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newHabitNameTextBox.Name = "newHabitNameTextBox";
            this.newHabitNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.newHabitNameTextBox.TabIndex = 16;
            this.newHabitNameTextBox.Visible = false;
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.DecimalPlaces = 2;
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(620, 426);
            this.thresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thresholdNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.thresholdNumericUpDown.TabIndex = 15;
            this.thresholdNumericUpDown.Visible = false;
            // 
            // editDeleteLabel
            // 
            this.editDeleteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editDeleteLabel.AutoSize = true;
            this.editDeleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDeleteLabel.Location = new System.Drawing.Point(252, 20);
            this.editDeleteLabel.Name = "editDeleteLabel";
            this.editDeleteLabel.Size = new System.Drawing.Size(350, 39);
            this.editDeleteLabel.TabIndex = 14;
            this.editDeleteLabel.Text = "Edit or Delete Habits";
            this.editDeleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditHabits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 638);
            this.Controls.Add(this.editDeleteContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditHabits";
            this.Text = "Edit Habits";
            ((System.ComponentModel.ISupportInitialize)(this.habitDataGridView)).EndInit();
            this.editDeleteContainer.ResumeLayout(false);
            this.editDeleteContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editHabitButton;
        private System.Windows.Forms.Button deleteHabitButton;
        private System.Windows.Forms.DataGridView habitDataGridView;
        private trackrDBDataSetTableAdapters.habitTableTableAdapter habitTableTableAdap;
        private System.Windows.Forms.DataGridViewTextBoxColumn habit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tracked;
        private System.Windows.Forms.ComboBox posNegComboBox;
        private System.Windows.Forms.Label newHabitNameLabel;
        private System.Windows.Forms.Label posNegLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Button acceptChangesButton;
        private System.Windows.Forms.Label currentlyTrackingLabel;
        private System.Windows.Forms.CheckBox currentlyTrackingCheckBox;
        private trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter habitHistoryTableTableAdap;
        private System.Windows.Forms.Button returnToDashboardButton;
        private System.Windows.Forms.GroupBox editDeleteContainer;
        private System.Windows.Forms.Label editDeleteLabel;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.TextBox newHabitNameTextBox;
    }
}