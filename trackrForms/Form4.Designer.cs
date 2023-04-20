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
            this.habitTableTableAdap = new trackrForms.trackrDBDataSetTableAdapters.habitTableTableAdapter();
            this.habit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.habitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.posNegComboBox = new System.Windows.Forms.ComboBox();
            this.habitTypeLabel = new System.Windows.Forms.Label();
            this.posNegLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.acceptChangesButton = new System.Windows.Forms.Button();
            this.currentlyTrackingLabel = new System.Windows.Forms.Label();
            this.currentlyTrackingCheckBox = new System.Windows.Forms.CheckBox();
            this.habitHistoryTableTableAdap = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            this.returnToDashboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.habitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editHabitButton
            // 
            this.editHabitButton.Location = new System.Drawing.Point(141, 353);
            this.editHabitButton.Name = "editHabitButton";
            this.editHabitButton.Size = new System.Drawing.Size(85, 23);
            this.editHabitButton.TabIndex = 1;
            this.editHabitButton.Text = "Edit Habit";
            this.editHabitButton.UseVisualStyleBackColor = true;
            this.editHabitButton.Click += new System.EventHandler(this.editHabitButton_Click);
            // 
            // deleteHabitButton
            // 
            this.deleteHabitButton.Location = new System.Drawing.Point(245, 353);
            this.deleteHabitButton.Name = "deleteHabitButton";
            this.deleteHabitButton.Size = new System.Drawing.Size(90, 23);
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
            this.habitDataGridView.Location = new System.Drawing.Point(118, 47);
            this.habitDataGridView.Name = "habitDataGridView";
            this.habitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.habitDataGridView.Size = new System.Drawing.Size(243, 286);
            this.habitDataGridView.TabIndex = 3;
            this.habitDataGridView.SelectionChanged += new System.EventHandler(this.habitDataGridView_SelectionChanged);
            // 
            // habitTableTableAdap
            // 
            this.habitTableTableAdap.ClearBeforeFill = true;
            // 
            // habit
            // 
            this.habit.HeaderText = "Habit Name";
            this.habit.Name = "habit";
            // 
            // tracked
            // 
            this.tracked.HeaderText = "Currently Tracked";
            this.tracked.Name = "tracked";
            // 
            // habitTypeComboBox
            // 
            this.habitTypeComboBox.FormattingEnabled = true;
            this.habitTypeComboBox.Items.AddRange(new object[] {
            "Binary",
            "Numerical"});
            this.habitTypeComboBox.Location = new System.Drawing.Point(510, 150);
            this.habitTypeComboBox.Name = "habitTypeComboBox";
            this.habitTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.habitTypeComboBox.TabIndex = 4;
            this.habitTypeComboBox.Visible = false;
            this.habitTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.habitTypeComboBox_SelectedIndexChanged);
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(521, 313);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(100, 20);
            this.thresholdTextBox.TabIndex = 5;
            this.thresholdTextBox.Visible = false;
            // 
            // posNegComboBox
            // 
            this.posNegComboBox.FormattingEnabled = true;
            this.posNegComboBox.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.posNegComboBox.Location = new System.Drawing.Point(510, 233);
            this.posNegComboBox.Name = "posNegComboBox";
            this.posNegComboBox.Size = new System.Drawing.Size(121, 21);
            this.posNegComboBox.TabIndex = 6;
            this.posNegComboBox.Visible = false;
            // 
            // habitTypeLabel
            // 
            this.habitTypeLabel.AutoSize = true;
            this.habitTypeLabel.Location = new System.Drawing.Point(542, 127);
            this.habitTypeLabel.Name = "habitTypeLabel";
            this.habitTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.habitTypeLabel.TabIndex = 7;
            this.habitTypeLabel.Text = "Habit Type";
            this.habitTypeLabel.Visible = false;
            // 
            // posNegLabel
            // 
            this.posNegLabel.AutoSize = true;
            this.posNegLabel.Location = new System.Drawing.Point(525, 209);
            this.posNegLabel.Name = "posNegLabel";
            this.posNegLabel.Size = new System.Drawing.Size(92, 13);
            this.posNegLabel.TabIndex = 8;
            this.posNegLabel.Text = "Positive/Negative";
            this.posNegLabel.Visible = false;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(543, 290);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.thresholdLabel.TabIndex = 9;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.Visible = false;
            // 
            // acceptChangesButton
            // 
            this.acceptChangesButton.Location = new System.Drawing.Point(512, 353);
            this.acceptChangesButton.Name = "acceptChangesButton";
            this.acceptChangesButton.Size = new System.Drawing.Size(110, 23);
            this.acceptChangesButton.TabIndex = 10;
            this.acceptChangesButton.Text = "Accept Changes";
            this.acceptChangesButton.UseVisualStyleBackColor = true;
            this.acceptChangesButton.Visible = false;
            this.acceptChangesButton.Click += new System.EventHandler(this.acceptChangesButton_Click);
            // 
            // currentlyTrackingLabel
            // 
            this.currentlyTrackingLabel.AutoSize = true;
            this.currentlyTrackingLabel.Location = new System.Drawing.Point(522, 50);
            this.currentlyTrackingLabel.Name = "currentlyTrackingLabel";
            this.currentlyTrackingLabel.Size = new System.Drawing.Size(100, 13);
            this.currentlyTrackingLabel.TabIndex = 11;
            this.currentlyTrackingLabel.Text = "Continue Tracking?";
            this.currentlyTrackingLabel.Visible = false;
            // 
            // currentlyTrackingCheckBox
            // 
            this.currentlyTrackingCheckBox.AutoSize = true;
            this.currentlyTrackingCheckBox.Location = new System.Drawing.Point(563, 73);
            this.currentlyTrackingCheckBox.Name = "currentlyTrackingCheckBox";
            this.currentlyTrackingCheckBox.Size = new System.Drawing.Size(15, 14);
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
            this.returnToDashboardButton.Location = new System.Drawing.Point(330, 395);
            this.returnToDashboardButton.Name = "returnToDashboardButton";
            this.returnToDashboardButton.Size = new System.Drawing.Size(138, 23);
            this.returnToDashboardButton.TabIndex = 13;
            this.returnToDashboardButton.Text = "Return to Dashbaord";
            this.returnToDashboardButton.UseVisualStyleBackColor = true;
            this.returnToDashboardButton.Click += new System.EventHandler(this.returnToDashboardButton_Click);
            // 
            // EditHabits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnToDashboardButton);
            this.Controls.Add(this.currentlyTrackingCheckBox);
            this.Controls.Add(this.currentlyTrackingLabel);
            this.Controls.Add(this.acceptChangesButton);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.posNegLabel);
            this.Controls.Add(this.habitTypeLabel);
            this.Controls.Add(this.posNegComboBox);
            this.Controls.Add(this.thresholdTextBox);
            this.Controls.Add(this.habitTypeComboBox);
            this.Controls.Add(this.habitDataGridView);
            this.Controls.Add(this.deleteHabitButton);
            this.Controls.Add(this.editHabitButton);
            this.Name = "EditHabits";
            this.Text = "Edit Habits";
            ((System.ComponentModel.ISupportInitialize)(this.habitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editHabitButton;
        private System.Windows.Forms.Button deleteHabitButton;
        private System.Windows.Forms.DataGridView habitDataGridView;
        private trackrDBDataSetTableAdapters.habitTableTableAdapter habitTableTableAdap;
        private System.Windows.Forms.DataGridViewTextBoxColumn habit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tracked;
        private System.Windows.Forms.ComboBox habitTypeComboBox;
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.ComboBox posNegComboBox;
        private System.Windows.Forms.Label habitTypeLabel;
        private System.Windows.Forms.Label posNegLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Button acceptChangesButton;
        private System.Windows.Forms.Label currentlyTrackingLabel;
        private System.Windows.Forms.CheckBox currentlyTrackingCheckBox;
        private trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter habitHistoryTableTableAdap;
        private System.Windows.Forms.Button returnToDashboardButton;
    }
}