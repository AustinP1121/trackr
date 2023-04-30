using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackrForms.trackrDBDataSetTableAdapters;

/*
 *  Desc:   Form4.cs implements the editing and deleting functions as specified in the SRS for trackr via a GUI. This GUI, form EditHabits, provides
 *              users with a dataGridView object containing all of the habits in the database, including those that the user has stopped tracking.
 *              These can then be edited, changing whether or not the habit is tracked, whether the habit is binary or numerical, and if numerical,
 *              the positivity/negativity of a habit and the completion threshold. Once the user accepts the changes they have made, these will be
 *              reflected in the database. The user can also delete habits from this window. Upon choosing a habit to delete and pressing the delete button,
 *              the program verifies with the user if they would like to delete the habit. If the user presses "Yes" in this messageBox, the habit
 *              will be deleted in both the habitTable and the habitHistoryTable. The dataGridView will then be updated to reflect the changes in the database.
 *  By:     Larry Johnson (Put your name here if you edit this program)
 *  On:     4/4/2023
 */

namespace trackrForms
{
    public partial class EditHabits : Form
    {
        trackrDBDataSet.habitTableDataTable listBoxInput;
        bool binaryHabit;

        public EditHabits()
        {
            InitializeComponent();

            //  Table will have two columns:
            //      Column 0: Habit Name
            //      Column 1: Currently Tracked
            listBoxInput = new trackrDBDataSet.habitTableDataTable();

            UpdateDataGridView();
        }

        private void habitDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //  When the form loads initially, the selectedRows property is initialized to 0, which triggers this event handler.
            //      This would cause an exception trying to access the selected row that does not exist.
            if (habitDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            //  If currently editing, and the user changes the habit being edited, reset the editing controls (e.g., habitTypeComboBox)
            if (currentlyTrackingLabel.Visible)
            {
                ResetControls();
            }

            //  Extract one row from the habitTable based on the name of the habit in the selected row.
            trackrDBDataSet.habitTableRow currentRow = listBoxInput.FindByhabit(habitDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            //  Fill the editing controls with information from the habitTable (note, these controls are still not visible).
            newHabitNameTextBox.Text = currentRow[1].ToString();
            binaryHabit = currentRow[2].ToString() == "Binary";
            posNegComboBox.Text = bool.Parse(currentRow[4].ToString()) ? "Positive" : "Negative";
            thresholdNumericUpDown.Value = Convert.ToDecimal(currentRow[3]);
            currentlyTrackingCheckBox.Checked = bool.Parse(currentRow[5].ToString());
        }

        private void UpdateDataGridView()
        {
            //  Reset the state of the habitDataGridView object so it can be refilled from scratch
            habitDataGridView.Rows.Clear();

            //  Fill the habitTableDataTable with updated information from the database
            habitTableTableAdap.Fill(listBoxInput);

            //  For each item in the habitTableDataTable, add an entry to the habitDataGridView containing the habit name and the currentlyTracked value.
            for(int i = 0; i < listBoxInput.Rows.Count; i++)
            {
                object[] items = { listBoxInput.Rows[i][1].ToString(), bool.Parse(listBoxInput.Rows[i][5].ToString()) };
                habitDataGridView.Rows.Add(items);
            }
        }

        private void editHabitButton_Click(object sender, EventArgs e)
        {
            //  Enable all controls necessary to edit a binary habit
            newHabitNameLabel.Visible = true;
            newHabitNameTextBox.Visible = true;
            currentlyTrackingLabel.Visible = true;
            currentlyTrackingCheckBox.Visible = true;
            acceptChangesButton.Visible = true;

            //  Then, call the following event handler to test if the habit is numerical and needs more controls to edit.
            if (!binaryHabit)
            {
                posNegLabel.Visible = true;
                posNegComboBox.Visible = true;
                thresholdLabel.Visible = true;
                thresholdNumericUpDown.Visible = true;
            }
            /*else
            {
                posNegLabel.Visible = false;
                posNegComboBox.Visible = false;
                thresholdLabel.Visible = false;
                thresholdNumericUpDown.Visible = false;
            }*/
        }

        private void acceptChangesButton_Click(object sender, EventArgs e)
        {
            //  Input Validation

            //  For Numerical habits...
            if(thresholdNumericUpDown.Visible)
            {
                //  Test threshold value
                int test;
                if(!Int32.TryParse(thresholdNumericUpDown.Text, out test) && (test > 100 || test < 0))
                {
                    MessageBox.Show("Please input an integer value between 0 and 100 for your threshold.");
                    return;
                }
            }
            //  Input validation has succeeded

            string originalHabit = habitDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            //  For binary habits, input the values that the user has edited, with "positive" set to true and "currentGoal" set to 1.
            if (binaryHabit)
            {
                habitTableTableAdap.UpdateHabitEntry(1, true, currentlyTrackingCheckBox.Checked, originalHabit);
            }
            //  For numerical habits, input the values that the user has edited.
            else
            {
                habitTableTableAdap.UpdateHabitEntry(Convert.ToDecimal(thresholdNumericUpDown.Text),
                    posNegComboBox.Text == "Positive", currentlyTrackingCheckBox.Checked, originalHabit);
            }

            //  Update today's goal in habitHistoryTable as well, so that a history of the habit goals is kept. Also this is referenced by the daily dashboard.
            habitHistoryTableTableAdap.UpdateEditHabit(newHabitNameTextBox.Text, Decimal.Parse(thresholdNumericUpDown.Text), originalHabit, DateTime.Today);

            //  Also, if the name of the habit was changed, update the name in all records in the habitHistoryTable

            //  Reset all the editing controls, and update the dataGridView to reflect changes..
            ResetControls();
            UpdateDataGridView();
        }

        private void ResetControls()
        {
            //  Turn off ALL of the editing controls.
            currentlyTrackingLabel.Visible = false;
            currentlyTrackingCheckBox.Visible = false;
            newHabitNameLabel.Visible = false;
            newHabitNameTextBox.Visible = false;
            posNegLabel.Visible = false;
            posNegComboBox.Visible = false;
            thresholdLabel.Visible = false;
            thresholdNumericUpDown.Visible = false;
            acceptChangesButton.Visible = false;
        }

        private void deleteHabitButton_Click(object sender, EventArgs e)
        {
            //  Verify with the user that they want to delete the habit they have selected.
            if(MessageBox.Show("Are you sure you want to delete \"" + habitDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "\"?",
                "Delete Habit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //  If the user agrees to deleting the habit, delete all instances from the habitHistoryTable and the instance from habitTable
                habitTableTableAdap.DeleteByHabit(habitDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                habitHistoryTableTableAdap.DeleteByHabit(habitDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
            
            //  Update the dataGridView object to reflect changes to the database.
            UpdateDataGridView();
        }

        private void returnToDashboardButton_Click(object sender, EventArgs e)
        {
            //  Close the form.
            Close();
            
        }
    }
}
