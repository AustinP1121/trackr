using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackrForms.trackrDBDataSetTableAdapters;

namespace trackrForms
{
    public partial class Dashboard : Form
    {
        public static bool dbUpdated = false;

        //  Constructor should load first, so call the load function from here
        public Dashboard()
        {
            InitializeComponent();
            //LoadDataFromTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            var myForm = new CreateHabit();
            myForm.Show();
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            tableLayout.Controls.Clear();
            LoadDataFromTable();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            dateLabel.Visible = true;
            CheckLastDate();
            LoadDataFromTable();

            // TODO: This line of code loads data into the 'trackrDBDataSet.habitHistoryTable' table. You can move, or remove it, as needed.
            this.habitHistoryTableTableAdapter.Fill(this.trackrDBDataSet.habitHistoryTable);
        } 

        //Inputs new entries into habitHistory because it is a new day
        //Sets a value of todaysValue as 0, until the user inputs values into dashboard
        private void CheckLastDate()
        {
            DateTime today = DateTime.Parse(DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM");

            trackrDBDataSet.habitHistoryTableDataTable habitDates = new trackrDBDataSet.habitHistoryTableDataTable();
            habitHistoryTableTableAdapter.FillByDateOrder(habitDates);

            DateTime lastDate;
            try
            {
                lastDate = DateTime.Parse(habitDates.Rows[0].ItemArray[2].ToString());
            }
            catch(System.IndexOutOfRangeException ex)
            {
                lastDate = today;
            }

            if (lastDate < today)
            {
                //trackrDBDataSet.habitTableDataTable allHabits = new trackrDBDataSet.habitTableDataTable();
                //habitTableTableAdapter.Fill(allHabits);
                trackrDBDataSet.habitTableDataTable currentHabits = new trackrDBDataSet.habitTableDataTable();
                habitTableTableAdapter.FillByCurrentlyTracked(currentHabits);



                if (lastDate.AddDays(1) == today)
                {
                    trackrDBDataSet.habitHistoryTableDataTable yesterdayHabits = new trackrDBDataSet.habitHistoryTableDataTable();
                    habitHistoryTableTableAdapter.FillByDateJoining(yesterdayHabits, lastDate);

                    for (int currentRow = 0; currentRow < yesterdayHabits.Rows.Count; currentRow++)
                    {
                        string name = yesterdayHabits.Rows[currentRow].ItemArray[1].ToString();
                        bool goalMet = Boolean.Parse(yesterdayHabits.Rows[currentRow].ItemArray[5].ToString());
                        int streak = Int32.Parse(yesterdayHabits.Rows[currentRow].ItemArray[10].ToString());
                        if (goalMet)
                        {
                            streak++;
                        }
                        else
                        {
                            streak = 0;
                        }
                        habitTableTableAdapter.UpdateStreak(streak, name);
                    }
                }
                
                for (int currentRow = 0; currentRow < currentHabits.Rows.Count; currentRow++)
                {
                    string name = currentHabits.Rows[currentRow].ItemArray[1].ToString();
                    int goal = Int32.Parse(currentHabits.Rows[currentRow].ItemArray[3].ToString());
                    bool positive = Boolean.Parse(currentHabits.Rows[currentRow].ItemArray[4].ToString());
                    bool goalMet = false;
                    if (positive && 0 >= goal)
                    {
                        goalMet = true;
                    }
                    else if (!positive && 0 <= goal)
                    {
                        goalMet = true;
                    }

                    habitHistoryTableTableAdapter.Insert(name, today, 0, goal, goalMet);
                }
            }
        }

        private void LoadDataFromTable()
        {
           //No longer using this Table Adapter
           // trackrDBDataSet.habitTableDataTable habitData = new trackrDBDataSet.habitTableDataTable();
           // habitTableTableAdapter.Fill(habitData);

            //I am using a new Table Adapter that combines the two data tables based on currently tracked habits

            //Right now, all the dates should go into the database as 12:00:00 AM or 00:00:00
            string today = DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM";
            trackrDBDataSet.habitHistoryTableDataTable habitHistory = new trackrDBDataSet.habitHistoryTableDataTable();
            habitHistoryTableTableAdapter.FillByDateJoining(habitHistory, DateTime.Parse(today));

            tableLayout.RowCount = habitHistory.Rows.Count;

            for (int currentRow = 0; currentRow < habitHistory.Rows.Count; currentRow++)
            {
                //Habit Column
                Label currentHabit = new Label();
                currentHabit.Text = habitHistory.Rows[currentRow].ItemArray[1].ToString();
                // [0].ToString().ToUpper() + habitHistory.Rows[currentRow].ItemArray[1].ToString().Substring(1)
                currentHabit.Name = "currentHabit" + currentRow + "Label";
                currentHabit.TextAlign = ContentAlignment.MiddleCenter;
                currentHabit.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentHabit, 0, currentRow);

                //  Goal Column
                Label currentGoal = new Label();
                currentGoal.Text = habitHistory.Rows[currentRow].ItemArray[7].ToString();
                currentGoal.Name = "currentGoal" + currentRow + "Label";
                currentGoal.TextAlign = ContentAlignment.MiddleCenter;
                currentGoal.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentGoal, 1, currentRow);

               //Progress column

                //case for numeric goal
                if (habitHistory.Rows[currentRow].ItemArray[8].ToString() == "Numerical")
                {
                    NumericUpDown currentCurrentGoal = new NumericUpDown();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    currentCurrentGoal.Size = new Size(121, 38);
                    currentCurrentGoal.Margin = new Padding(3, 10, 3, 3);
                    currentCurrentGoal.Value = Decimal.Parse(habitHistory.Rows[currentRow].ItemArray[6].ToString());
                    currentCurrentGoal.DecimalPlaces = 2;

                    //Adds event to be associated with conditional formating
                    currentCurrentGoal.ValueChanged += new System.EventHandler(numericChanged);
                }

                //case for binary goal
                else if (habitHistory.Rows[currentRow].ItemArray[8].ToString() == "Binary")
                {
                    CheckBox currentCurrentGoal = new CheckBox();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    //currentCurrentGoal.Size = new Size(121, 38);
                    //currentCurrentGoal.Dock = DockStyle.Left;
                    currentCurrentGoal.Margin = new Padding(57, 8, 3, 3);
                    if (habitHistory.Rows[currentRow].ItemArray[6].ToString() == "1")
                    {
                        currentCurrentGoal.Checked = true;
                    }
                    else
                    {
                        currentCurrentGoal.Checked = false;
                    }
                    

                    //Event associated with conditional formatting
                    currentCurrentGoal.CheckStateChanged += new System.EventHandler(checkChanged);
                }

                //  Streak Column
                Label currentStreak = new Label();
                currentStreak.Text = habitHistory.Rows[currentRow].ItemArray[12].ToString();
                currentStreak.Name = "currentStreak" + currentRow + "Label";
                currentStreak.TextAlign = ContentAlignment.MiddleCenter;
                currentStreak.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentStreak, 3, currentRow);

                dbUpdated = false;
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Write Current Progress into habitHistory data table
            UploadCurrentProgress();
        }

        //The user input on the dashboard gets uploaded into the habitHistory table
        private void UploadCurrentProgress()
        {
            string today = DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM";
            trackrDBDataSet.habitHistoryTableDataTable habitHistory = new trackrDBDataSet.habitHistoryTableDataTable();
            habitHistoryTableTableAdapter.FillByDateJoining(habitHistory, DateTime.Parse(today));

            trackrDBDataSet.habitTableDataTable getLength = new trackrDBDataSet.habitTableDataTable();

            //  Gets all the rows that are being tracked and thus represented by the tableLayout
            habitTableTableAdapter.FillByCurrentlyTracked(getLength);
            int tableEntries = getLength.Rows.Count;

            //for (int row = 0; row < tableLayout.RowCount; row++)
            for (int row = 0; row < tableEntries; row++)
            {
                //  When adding a control, this is needed as there are now more table entries than drawn in the tableLayout.
                if (tableEntries > tableLayout.RowCount)
                    return;
                var c = tableLayout.GetControlFromPosition(2, row);
                string name = tableLayout.GetControlFromPosition(0, row).Text;
                DataRow[] entry = habitHistory.Select("habit = '" + name + "'");
                decimal todaysValue = 0;
                decimal todaysGoal = Decimal.Parse(tableLayout.GetControlFromPosition(1,row).Text);
                bool goalMet = false;
                bool positive = Boolean.Parse(entry[0].ItemArray[10].ToString());

                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        todaysValue = 1;
                        goalMet = true;
                    }
                    else
                    {
                        todaysValue = 0;
                    }
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)c;
                    todaysValue = (decimal)(num.Value);
                    if (positive && todaysValue >= todaysGoal)
                    {
                        goalMet = true;
                    }
                    else if (!positive && todaysValue <= todaysGoal)
                    {
                        goalMet = true;
                    }
                }

                habitHistoryTableTableAdapter.UpdateTodaysProgress(todaysValue, goalMet, name, DateTime.Parse(today));
            }
        }

        private void numericChanged(object sender, EventArgs e)
        {
            //TODO: Conditional  formatting based on if goal is met yet
        }

        private void checkChanged(object sender, EventArgs e)
        {
            //TODO: Conditional  formatting based on if goal is met yet
        }

        private void displayMetricsButton_Click(object sender, EventArgs e)
        {
            CreateMetrics form = new CreateMetrics();
            form.Show();
        }

        private void tableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditHabitsButton_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            EditHabits form = new EditHabits();
            form.Show();
        }
    }
}
