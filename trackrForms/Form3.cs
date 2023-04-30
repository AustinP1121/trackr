using ScottPlot;
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

        public void FillMetricsTable()
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
                habitHistoryTableTableAdapter1.FillByHabit(habitHistoryTable, habit);

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

                //firstDate retrieves the value of the first entry in the habitHistoryTable filled by specific habit (dates are in ascending order)
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
                Label longestStreak = new Label();
                longestStreak.Text = habitRow.ItemArray[7].ToString();
                //dateTimeLabel.Name = "dateTime" + i + "Label";
                longestStreak.TextAlign = ContentAlignment.MiddleCenter;
                longestStreak.Size = new Size(121, 38);
                tableLayout.Controls.Add(longestStreak, 2, i - emptyRows);
                
                //Create column for Graphing button
                Button graphButton = new Button();
                graphButton.Text = "Graph!";
                graphButton.Size = new Size(90, 27);
                tableLayout.Controls.Add(graphButton, 3, i - emptyRows);

                //Clicking event handler
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
            //Control object            
            Control C = (Control)sender;

            //Gets the row of the graph button
            TableLayoutPanelCellPosition p = tableLayout.GetPositionFromControl(C);
            int row = p.Row;

            //Get the text of the habit label from corresponding row
            string name = tableLayout.GetControlFromPosition(0, row).Text;

            //Figure out the type of the habit
            trackrDBDataSet.habitTableDataTable habitTable = new trackrDBDataSet.habitTableDataTable();
            habitTableTableAdapter1.FillByType(habitTable, name);
            string type = habitTable.Rows[0].ItemArray[2].ToString();
            
            //Pie Chart if binary
            if (type == "Binary")
            {
                //Get percent completion from row 2 of the table layout
                string percentCompletion = tableLayout.GetControlFromPosition(1, row).Text;
                double percent = double.Parse(percentCompletion.Substring(0, percentCompletion.Length - 1));

                var plt = new ScottPlot.Plot();
                plt.Title(name);

                double[] values = { percent, 100 - percent };
                string[] labels = { "Completion Rate", "Incomplete Rate" };
                

                Color color1 = Color.FromArgb(255, 0, 150, 200);
                Color color2 = Color.FromArgb(100, 0, 150, 200);

                var pie = plt.AddPie(values);
                pie.SliceLabels = labels;
                plt.Legend();
                pie.Size = .7;
                pie.DonutSize = .5;
                pie.DonutLabel = percentCompletion;
                pie.OutlineSize = 2;
                pie.SliceFillColors = new Color[] { color1, color2 };

                plt.SaveFig("pie_donutText.png");
                new ScottPlot.FormsPlotViewer(plt).ShowDialog();
            }

            //Line graph if numerical
            if (type == "Numerical")
            {
                //Get all the date of the specific habit (order by date)
                trackrDBDataSet.habitHistoryTableDataTable habitHistoryTable = new trackrDBDataSet.habitHistoryTableDataTable();
                habitHistoryTableTableAdapter1.FillByHabit(habitHistoryTable, name);

                //This creates the arrays for the x and y axis
                DateTime[] dataX = new DateTime[habitHistoryTable.Rows.Count];
                double[] dataY = new double[habitHistoryTable.Rows.Count];

                double[] dataGoal = new double[habitHistoryTable.Rows.Count];

                for (int i = 0; i < habitHistoryTable.Rows.Count; i++)
                {
                    dataX[i] = (DateTime)habitHistoryTable.Rows[i].ItemArray[2];
                    //if(dataX[i] != DateTime.Today)
                    dataY[i] = Convert.ToDouble(habitHistoryTable.Rows[i].ItemArray[3]);

                    dataGoal[i] = Convert.ToDouble(habitHistoryTable.Rows[i].ItemArray[4]);
                }

                double[] xs = dataX.Select(x => x.ToOADate()).ToArray();

                var scaPlt = new ScottPlot.Plot(400, 300);
                scaPlt.Title(name);

                scaPlt.XAxis.DateTimeFormat(true);
                scaPlt.AddScatter(xs, dataY, label: "Daily Value");
                scaPlt.AddScatter(xs, dataGoal, label: "Daily Goal");
                scaPlt.Legend(true, Alignment.UpperLeft);
                scaPlt.XAxis.Label("Dates Tracked");
                scaPlt.YAxis.Label("Number Value of Habit");
                new ScottPlot.FormsPlotViewer(scaPlt).ShowDialog();
            }
        }

        private void firstDateCompletedColumnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
