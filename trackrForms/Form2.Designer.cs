
namespace trackrForms
{
    partial class CreateHabit
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
            this.habitNameTextBox = new System.Windows.Forms.TextBox();
            this.createHabitButton = new System.Windows.Forms.Button();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeNameComboBox = new System.Windows.Forms.ComboBox();
            this.pos_negComboBox = new System.Windows.Forms.ComboBox();
            this.habitNameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.pos_negLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.more_lessLabel = new System.Windows.Forms.Label();
            this.scheduleCheckBox = new System.Windows.Forms.Label();
            this.mondayCheckBox = new System.Windows.Forms.CheckBox();
            this.tusdayCheckBox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.thursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.fridayCheckBox = new System.Windows.Forms.CheckBox();
            this.saturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.sundayCheckBox = new System.Windows.Forms.CheckBox();
            this.scheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.habitTableTableAdapter = new trackrForms.trackrDBDataSetTableAdapters.habitTableTableAdapter();
            this.trackrDBDataSet1 = new trackrForms.trackrDBDataSet();
            this.habitHistoryTableTableAdapter1 = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.scheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // habitNameTextBox
            // 
            this.habitNameTextBox.Location = new System.Drawing.Point(145, 76);
            this.habitNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.habitNameTextBox.Name = "habitNameTextBox";
            this.habitNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.habitNameTextBox.TabIndex = 0;
            // 
            // createHabitButton
            // 
            this.createHabitButton.Location = new System.Drawing.Point(232, 289);
            this.createHabitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createHabitButton.Name = "createHabitButton";
            this.createHabitButton.Size = new System.Drawing.Size(91, 19);
            this.createHabitButton.TabIndex = 1;
            this.createHabitButton.Text = "Create Habit";
            this.createHabitButton.UseVisualStyleBackColor = true;
            this.createHabitButton.Click += new System.EventHandler(this.createHabitButton_Click);
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(307, 133);
            this.thresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.thresholdNumericUpDown.TabIndex = 2;
            this.thresholdNumericUpDown.Visible = false;
            // 
            // typeNameComboBox
            // 
            this.typeNameComboBox.FormattingEnabled = true;
            this.typeNameComboBox.Items.AddRange(new object[] {
            "Binary",
            "Numerical"});
            this.typeNameComboBox.Location = new System.Drawing.Point(306, 74);
            this.typeNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeNameComboBox.Name = "typeNameComboBox";
            this.typeNameComboBox.Size = new System.Drawing.Size(92, 21);
            this.typeNameComboBox.TabIndex = 3;
            this.typeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.typeNameComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // pos_negComboBox
            // 
            this.pos_negComboBox.FormattingEnabled = true;
            this.pos_negComboBox.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.pos_negComboBox.Location = new System.Drawing.Point(145, 133);
            this.pos_negComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pos_negComboBox.Name = "pos_negComboBox";
            this.pos_negComboBox.Size = new System.Drawing.Size(92, 21);
            this.pos_negComboBox.TabIndex = 4;
            this.pos_negComboBox.Visible = false;
            this.pos_negComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // habitNameLabel
            // 
            this.habitNameLabel.AutoSize = true;
            this.habitNameLabel.Location = new System.Drawing.Point(164, 50);
            this.habitNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.habitNameLabel.Name = "habitNameLabel";
            this.habitNameLabel.Size = new System.Drawing.Size(63, 13);
            this.habitNameLabel.TabIndex = 5;
            this.habitNameLabel.Text = "Habit Name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(334, 50);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type";
            // 
            // pos_negLabel
            // 
            this.pos_negLabel.AutoSize = true;
            this.pos_negLabel.Location = new System.Drawing.Point(148, 111);
            this.pos_negLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pos_negLabel.Name = "pos_negLabel";
            this.pos_negLabel.Size = new System.Drawing.Size(92, 13);
            this.pos_negLabel.TabIndex = 7;
            this.pos_negLabel.Text = "Positive/Negative";
            this.pos_negLabel.Visible = false;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(320, 111);
            this.thresholdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(54, 13);
            this.thresholdLabel.TabIndex = 8;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.Visible = false;
            // 
            // more_lessLabel
            // 
            this.more_lessLabel.AutoSize = true;
            this.more_lessLabel.Location = new System.Drawing.Point(401, 135);
            this.more_lessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.more_lessLabel.Name = "more_lessLabel";
            this.more_lessLabel.Size = new System.Drawing.Size(42, 13);
            this.more_lessLabel.TabIndex = 9;
            this.more_lessLabel.Text = "or more";
            this.more_lessLabel.Visible = false;
            // 
            // scheduleCheckBox
            // 
            this.scheduleCheckBox.AutoSize = true;
            this.scheduleCheckBox.Location = new System.Drawing.Point(100, 15);
            this.scheduleCheckBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scheduleCheckBox.Name = "scheduleCheckBox";
            this.scheduleCheckBox.Size = new System.Drawing.Size(52, 13);
            this.scheduleCheckBox.TabIndex = 10;
            this.scheduleCheckBox.Text = "Schedule";
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mondayCheckBox.Checked = true;
            this.mondayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mondayCheckBox.Location = new System.Drawing.Point(12, 35);
            this.mondayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(32, 31);
            this.mondayCheckBox.TabIndex = 11;
            this.mondayCheckBox.Text = "Mon";
            this.mondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // tusdayCheckBox
            // 
            this.tusdayCheckBox.AutoSize = true;
            this.tusdayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tusdayCheckBox.Checked = true;
            this.tusdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tusdayCheckBox.Location = new System.Drawing.Point(46, 35);
            this.tusdayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tusdayCheckBox.Name = "tusdayCheckBox";
            this.tusdayCheckBox.Size = new System.Drawing.Size(30, 31);
            this.tusdayCheckBox.TabIndex = 12;
            this.tusdayCheckBox.Text = "Tue";
            this.tusdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // wednesdayCheckBox
            // 
            this.wednesdayCheckBox.AutoSize = true;
            this.wednesdayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wednesdayCheckBox.Checked = true;
            this.wednesdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wednesdayCheckBox.Location = new System.Drawing.Point(78, 35);
            this.wednesdayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(34, 31);
            this.wednesdayCheckBox.TabIndex = 13;
            this.wednesdayCheckBox.Text = "Wed";
            this.wednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // thursdayCheckBox
            // 
            this.thursdayCheckBox.AutoSize = true;
            this.thursdayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.thursdayCheckBox.Checked = true;
            this.thursdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thursdayCheckBox.Location = new System.Drawing.Point(113, 35);
            this.thursdayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thursdayCheckBox.Name = "thursdayCheckBox";
            this.thursdayCheckBox.Size = new System.Drawing.Size(30, 31);
            this.thursdayCheckBox.TabIndex = 14;
            this.thursdayCheckBox.Text = "Thu";
            this.thursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // fridayCheckBox
            // 
            this.fridayCheckBox.AutoSize = true;
            this.fridayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fridayCheckBox.Checked = true;
            this.fridayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fridayCheckBox.Location = new System.Drawing.Point(146, 35);
            this.fridayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(22, 31);
            this.fridayCheckBox.TabIndex = 15;
            this.fridayCheckBox.Text = "Fri";
            this.fridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // saturdayCheckBox
            // 
            this.saturdayCheckBox.AutoSize = true;
            this.saturdayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saturdayCheckBox.Checked = true;
            this.saturdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saturdayCheckBox.Location = new System.Drawing.Point(177, 35);
            this.saturdayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saturdayCheckBox.Name = "saturdayCheckBox";
            this.saturdayCheckBox.Size = new System.Drawing.Size(27, 31);
            this.saturdayCheckBox.TabIndex = 16;
            this.saturdayCheckBox.Text = "Sat";
            this.saturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // sundayCheckBox
            // 
            this.sundayCheckBox.AutoSize = true;
            this.sundayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sundayCheckBox.Checked = true;
            this.sundayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sundayCheckBox.Location = new System.Drawing.Point(212, 35);
            this.sundayCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(30, 31);
            this.sundayCheckBox.TabIndex = 17;
            this.sundayCheckBox.Text = "Sun";
            this.sundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // scheduleGroupBox
            // 
            this.scheduleGroupBox.Controls.Add(this.mondayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.scheduleCheckBox);
            this.scheduleGroupBox.Controls.Add(this.sundayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.tusdayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.saturdayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.wednesdayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.fridayCheckBox);
            this.scheduleGroupBox.Controls.Add(this.thursdayCheckBox);
            this.scheduleGroupBox.Location = new System.Drawing.Point(145, 170);
            this.scheduleGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleGroupBox.Name = "scheduleGroupBox";
            this.scheduleGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleGroupBox.Size = new System.Drawing.Size(260, 78);
            this.scheduleGroupBox.TabIndex = 18;
            this.scheduleGroupBox.TabStop = false;
            // 
            // habitTableTableAdapter
            // 
            this.habitTableTableAdapter.ClearBeforeFill = true;
            // 
            // trackrDBDataSet1
            // 
            this.trackrDBDataSet1.DataSetName = "trackrDBDataSet";
            this.trackrDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitHistoryTableTableAdapter1
            // 
            this.habitHistoryTableTableAdapter1.ClearBeforeFill = true;
            // 
            // CreateHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.scheduleGroupBox);
            this.Controls.Add(this.more_lessLabel);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.pos_negLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.habitNameLabel);
            this.Controls.Add(this.pos_negComboBox);
            this.Controls.Add(this.typeNameComboBox);
            this.Controls.Add(this.thresholdNumericUpDown);
            this.Controls.Add(this.createHabitButton);
            this.Controls.Add(this.habitNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateHabit";
            this.Text = "New Habit";
            this.Load += new System.EventHandler(this.CreateHabit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.scheduleGroupBox.ResumeLayout(false);
            this.scheduleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox habitNameTextBox;
        private System.Windows.Forms.Button createHabitButton;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.ComboBox typeNameComboBox;
        private System.Windows.Forms.ComboBox pos_negComboBox;
        private System.Windows.Forms.Label habitNameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label pos_negLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.Label more_lessLabel;
        private System.Windows.Forms.Label scheduleCheckBox;
        private System.Windows.Forms.CheckBox mondayCheckBox;
        private System.Windows.Forms.CheckBox tusdayCheckBox;
        private System.Windows.Forms.CheckBox wednesdayCheckBox;
        private System.Windows.Forms.CheckBox thursdayCheckBox;
        private System.Windows.Forms.CheckBox fridayCheckBox;
        private System.Windows.Forms.CheckBox saturdayCheckBox;
        private System.Windows.Forms.CheckBox sundayCheckBox;
        private System.Windows.Forms.GroupBox scheduleGroupBox;
        private trackrDBDataSetTableAdapters.habitTableTableAdapter habitTableTableAdapter;
        private trackrDBDataSet trackrDBDataSet1;
        private trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter habitHistoryTableTableAdapter1;
    }
}