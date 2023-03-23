using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using trackrForms.trackrDBDataSetTableAdapters;

namespace trackrForms
{
    public partial class CreateHabit : Form
    {
        public CreateHabit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (typeNameComboBox.SelectedItem.ToString() == "Numerical")
            {
                pos_negLabel.Visible = true;
                pos_negComboBox.Visible = true;
                thresholdLabel.Visible = true;
                thresholdNumericUpDown.Visible = true;
                more_lessLabel.Visible = false;
            }
            else
            {
                pos_negLabel.Visible = false;
                pos_negComboBox.Visible = false;
                thresholdLabel.Visible = false;
                thresholdNumericUpDown.Visible = false;
                more_lessLabel.Visible = false;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (pos_negComboBox.SelectedItem.ToString() == "Positive")
            {
                more_lessLabel.Text = "or more";
                more_lessLabel.Visible = true;
            }
            else if (pos_negComboBox.SelectedItem.ToString() == "Negative")
            {
                more_lessLabel.Text = "or less";
                more_lessLabel.Visible = true;
            }
            else
            {
                more_lessLabel.Visible = false;
            }
            
        }

        private void createHabitButton_Click(object sender, EventArgs e)
        {
            
            //  Create table both to test and retrieve largest ID value for insertion into the table.
            trackrDBDataSet.habitTableDataTable newTable = new trackrDBDataSet.habitTableDataTable();
            habitTableTableAdapter.Fill(newTable);
            trackrDBDataSet.habitHistoryTableDataTable habitHistory = new trackrDBDataSet.habitHistoryTableDataTable();
            //var historyAdapter = new habitHistoryTableTableAdapter();
            //habitHistoryTableTableAdapter h = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            //h.Fill(habitHistory);
            habitHistoryTableTableAdapter1.Fill(habitHistory);

            //  Get the amount of entries in the database before editing.
            int initialRowCount = newTable.Rows.Count;

            //  Input validation for habits
            if (habitNameTextBox.Text == String.Empty || !(typeNameComboBox.Text == "Binary" || typeNameComboBox.Text == "Numerical") || (typeNameComboBox.Text == "Numerical" && !(pos_negComboBox.Text == "Positive" || pos_negComboBox.Text == "Negative")))
            {
                MessageBox.Show("Some or all of your input values are not correct.\nPlease ensure your habit has a title," +
                    " is either Binary or Numerical, and if the habit is numerical, is either positive or negative.");
                return;
            }

            try
            {
                int id = newTable.Rows.Count + 1;
                string name = habitNameTextBox.Text;
                string type = typeNameComboBox.Text;
                int goal = typeNameComboBox.Text == "Binary" ? 1 : Int32.Parse(thresholdNumericUpDown.Value.ToString());
                bool positive = pos_negComboBox.Text == "Positive" || typeNameComboBox.Text == "Binary";
                DateTime today = DateTime.Parse(DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM");
                bool goalMet = false;
                if (positive && 0 >= goal)
                {
                    goalMet = true;
                }
                else if (!positive && 0 <= goal)
                {
                    goalMet = true;
                }


                habitTableTableAdapter.Insert(id, name, type, goal, positive, true, 0);
                //  Insert value based on the user input
                /*
                habitTableTableAdapter.Insert(newTable.Rows.Count + 1, habitNameTextBox.Text, typeNameComboBox.Text, 
                    typeNameComboBox.Text == "Binary" ? 1 : Int32.Parse(thresholdNumericUpDown.Value.ToString()),
                    pos_negComboBox.Text == "Positive" || typeNameComboBox.Text == "Binary", true, 0);
                */
                //string today = DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM";
                
                habitHistoryTableTableAdapter1.Insert(name, today, 0, goal, goalMet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //  Fill table again to show more proof that the table was locally updated, as according to the program (Shows RowsCount, ID of newest row)
            habitTableTableAdapter.Fill(newTable);
            if (newTable.Rows.Count > initialRowCount)
                MessageBox.Show("Habit successfully added to your habit dashboard!");
            else
                MessageBox.Show("Habit was not added to the dashboard. Did you create a habit with the same name as an existing habit?");

            Dashboard.dbUpdated = true;

            //  Close form
            Close();
        }

        private void CreateHabit_Load(object sender, EventArgs e)
        {

        }
    }
}
