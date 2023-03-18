
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
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.scheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // habitNameTextBox
            // 
            this.habitNameTextBox.Location = new System.Drawing.Point(193, 94);
            this.habitNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.habitNameTextBox.Name = "habitNameTextBox";
            this.habitNameTextBox.Size = new System.Drawing.Size(135, 22);
            this.habitNameTextBox.TabIndex = 0;
            // 
            // createHabitButton
            // 
            this.createHabitButton.Location = new System.Drawing.Point(327, 377);
            this.createHabitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createHabitButton.Name = "createHabitButton";
            this.createHabitButton.Size = new System.Drawing.Size(121, 23);
            this.createHabitButton.TabIndex = 1;
            this.createHabitButton.Text = "Create Habit";
            this.createHabitButton.UseVisualStyleBackColor = true;
            this.createHabitButton.Click += new System.EventHandler(this.createHabitButton_Click);
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(409, 164);
            this.thresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.thresholdNumericUpDown.TabIndex = 2;
            this.thresholdNumericUpDown.Visible = false;
            // 
            // typeNameComboBox
            // 
            this.typeNameComboBox.FormattingEnabled = true;
            this.typeNameComboBox.Items.AddRange(new object[] {
            "Binary",
            "Numerical"});
            this.typeNameComboBox.Location = new System.Drawing.Point(408, 91);
            this.typeNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeNameComboBox.Name = "typeNameComboBox";
            this.typeNameComboBox.Size = new System.Drawing.Size(121, 24);
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
            this.pos_negComboBox.Location = new System.Drawing.Point(193, 164);
            this.pos_negComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pos_negComboBox.Name = "pos_negComboBox";
            this.pos_negComboBox.Size = new System.Drawing.Size(121, 24);
            this.pos_negComboBox.TabIndex = 4;
            this.pos_negComboBox.Visible = false;
            this.pos_negComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // habitNameLabel
            // 
            this.habitNameLabel.AutoSize = true;
            this.habitNameLabel.Location = new System.Drawing.Point(219, 62);
            this.habitNameLabel.Name = "habitNameLabel";
            this.habitNameLabel.Size = new System.Drawing.Size(82, 17);
            this.habitNameLabel.TabIndex = 5;
            this.habitNameLabel.Text = "Habit Name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(445, 62);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type";
            // 
            // pos_negLabel
            // 
            this.pos_negLabel.AutoSize = true;
            this.pos_negLabel.Location = new System.Drawing.Point(197, 137);
            this.pos_negLabel.Name = "pos_negLabel";
            this.pos_negLabel.Size = new System.Drawing.Size(117, 17);
            this.pos_negLabel.TabIndex = 7;
            this.pos_negLabel.Text = "Positive/Negative";
            this.pos_negLabel.Visible = false;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(427, 137);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(72, 17);
            this.thresholdLabel.TabIndex = 8;
            this.thresholdLabel.Text = "Threshold";
            this.thresholdLabel.Visible = false;
            // 
            // more_lessLabel
            // 
            this.more_lessLabel.AutoSize = true;
            this.more_lessLabel.Location = new System.Drawing.Point(535, 166);
            this.more_lessLabel.Name = "more_lessLabel";
            this.more_lessLabel.Size = new System.Drawing.Size(57, 17);
            this.more_lessLabel.TabIndex = 9;
            this.more_lessLabel.Text = "or more";
            this.more_lessLabel.Visible = false;
            // 
            // scheduleCheckBox
            // 
            this.scheduleCheckBox.AutoSize = true;
            this.scheduleCheckBox.Location = new System.Drawing.Point(133, 18);
            this.scheduleCheckBox.Name = "scheduleCheckBox";
            this.scheduleCheckBox.Size = new System.Drawing.Size(67, 17);
            this.scheduleCheckBox.TabIndex = 10;
            this.scheduleCheckBox.Text = "Schedule";
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mondayCheckBox.Checked = true;
            this.mondayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mondayCheckBox.Location = new System.Drawing.Point(16, 43);
            this.mondayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(39, 38);
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
            this.tusdayCheckBox.Location = new System.Drawing.Point(61, 43);
            this.tusdayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tusdayCheckBox.Name = "tusdayCheckBox";
            this.tusdayCheckBox.Size = new System.Drawing.Size(37, 38);
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
            this.wednesdayCheckBox.Location = new System.Drawing.Point(104, 43);
            this.wednesdayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(41, 38);
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
            this.thursdayCheckBox.Location = new System.Drawing.Point(151, 43);
            this.thursdayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thursdayCheckBox.Name = "thursdayCheckBox";
            this.thursdayCheckBox.Size = new System.Drawing.Size(37, 38);
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
            this.fridayCheckBox.Location = new System.Drawing.Point(195, 43);
            this.fridayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(28, 38);
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
            this.saturdayCheckBox.Location = new System.Drawing.Point(236, 43);
            this.saturdayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saturdayCheckBox.Name = "saturdayCheckBox";
            this.saturdayCheckBox.Size = new System.Drawing.Size(33, 38);
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
            this.sundayCheckBox.Location = new System.Drawing.Point(283, 43);
            this.sundayCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(37, 38);
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
            this.scheduleGroupBox.Location = new System.Drawing.Point(193, 209);
            this.scheduleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleGroupBox.Name = "scheduleGroupBox";
            this.scheduleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleGroupBox.Size = new System.Drawing.Size(347, 96);
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
            // CreateHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}