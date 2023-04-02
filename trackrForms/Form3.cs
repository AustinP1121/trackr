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

namespace trackrForms
{
    public partial class CreateMetrics : Form
    {
        public CreateMetrics()
        {
            InitializeComponent();
            FillMetricsTable();
        }

        private void FillMetricsTable()
        {
            //  Need to retrieve habit name, count of a certain habit, and the firstDate of completion.
            //  All of these can be found in the habitHistoryTable

            trackrDBDataSet.habitHistoryTableDataTable habitHistoryTable = new trackrDBDataSet.habitHistoryTableDataTable();
            trackrDBDataSet.habitTableDataTable habitTable = new trackrDBDataSet.habitTableDataTable();

            habitTableTableAdapter1.Fill(habitTable);

            int emptyRows = 0;

            // For each row in habitTable...
            for(int i = 0; i < habitTable.Rows.Count; i++)
            {
                //  Create a DataRow object for each habit (each row in HabitTable)
                DataRow habitRow = habitTable.Rows[i];

                //  If the habit is not being tracked, do not display it in the metrics.
                if ((bool)habitRow.ItemArray[5] == false)
                {
                    emptyRows++;
                    continue;
                }

                //  Determine the name of the habit described by a row in habitTable
                string habit = habitRow.ItemArray[1].ToString();

                //  Using the name of the habit, collect all instances of the habit in habitHistoryTable with dates in ascending order.
                //  Also collects whether or not the habit was completed on a given day.
                habitHistoryTableTableAdapter1.FillByHabitNameAscendingDate(habitHistoryTable, habit);

              //  Collect data about habit name, percent completion, and firstDate
                
                //      habitName is a renaming of the variable habit for easier access.
                string habitName = habit;

                //      percentCompletion stores the calculated value of the completion rate of a specific habit.
                float completions = 0;
                foreach (DataRow row in habitHistoryTable.Rows)
                {
                    if ((bool)row.ItemArray[5] == true)
                        completions++;
                }
                float percentCompletion = (completions / habitHistoryTable.Rows.Count * 100);

                //      firstDate retrieves the value of the first entry in the habitHistoryTable filled by specific habit (dates are in ascending order)
                DateTime firstDate = (DateTime)habitHistoryTable.Rows[0].ItemArray[2];

              //  Add controls for the habit name, percent completion, and firstDate

                    //  MessageBox.Show(String.Format("Adding the following entry to row {0}: {1}, {2}, {3}", i - emptyRows, habitName, firstDate, percentCompletion));

                //  Create a control for the habitName column.
                //  These variables will be redefined every iteration of the habitTable loop, but the controls will continue to exist due to being in the tableLayout.
                Label habitNameLabel = new Label();
                habitNameLabel.Text = habitName;
                habitNameLabel.Name = "habitName" + i + "Label";
                habitNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                habitNameLabel.Size = new Size(121, 38);
                tableLayout.Controls.Add(habitNameLabel, 0, i - emptyRows);

                //  Create a control for the percentCompletion column
                Label percentCompletionLabel = new Label();
                percentCompletionLabel.Text = String.Format("{0:F2}%", percentCompletion);
                percentCompletionLabel.Name = "percentCompletion" + i + "Label";
                percentCompletionLabel.TextAlign = ContentAlignment.MiddleCenter;
                percentCompletionLabel.Size = new Size(121, 38);
                tableLayout.Controls.Add(percentCompletionLabel, 1, i - emptyRows);

                //  Create a control for the dateTime column.
                Label dateTimeLabel = new Label();
                dateTimeLabel.Text = firstDate.ToString("MM/dd/yyyy");
                dateTimeLabel.Name = "dateTime" + i + "Label";
                dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateTimeLabel.Size = new Size(121, 38);
                tableLayout.Controls.Add(dateTimeLabel, 2, i - emptyRows);

                //Create column for Graphing button
                Button graphButton = new Button();
                graphButton.Text = "Graph!";
                graphButton.Size = new Size(90, 27);
                tableLayout.Controls.Add(graphButton, 3, i - emptyRows);

                graphButton.Click += new System.EventHandler(graphButton_Click);

            }
        }

        //  Closes this form
        private void closeMetricsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void graphButton_Click(System.Object sender, EventArgs e)
        {
            //TODO: Display graph for specific habit
            //Have to access whether habit is binary or numerical
            //Display pie chart for binary
            //Display line chart for numerical

            Control C = (Control)sender;

            TableLayoutPanelCellPosition p = tableLayout.GetPositionFromControl(C);

            int row = p.Row;

            //Get the text of the habit label
            string name = tableLayout.GetControlFromPosition(0, row).Text;

        }
    }
}
