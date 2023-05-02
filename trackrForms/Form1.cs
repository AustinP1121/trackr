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
       //What is this?
        public static bool dbUpdated = false;

        public Dashboard()
        {
            InitializeComponent();  
        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            dateLabel.Visible = true;
            CheckLastDate();
            LoadDataFromTable();
        } 

        //Inputs new entries into habitHistory because it is a new day
        //Sets a value of todaysValue as 0, until the user inputs values into dashboard
        //Resets streak to 0 if the user has skipped days
        //Increments streak if the goal was met yesterday
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

            //Case if this is the first time logging in for the day
            if (lastDate < today)
            {
                
                trackrDBDataSet.habitTableDataTable currentHabits = new trackrDBDataSet.habitTableDataTable();
                habitTableTableAdapter.FillByCurrentlyTracked(currentHabits);


                //Need to get previous data from the last date that was logged
                trackrDBDataSet.habitHistoryTableDataTable mostRecentHabits = new trackrDBDataSet.habitHistoryTableDataTable();
                habitHistoryTableTableAdapter.FillByDateJoining(mostRecentHabits, lastDate);


                //for loop to update streak
                for (int currentRow = 0; currentRow < mostRecentHabits.Rows.Count; currentRow++)
                {
                    //Retrieve info from database
                    string name = mostRecentHabits.Rows[currentRow].ItemArray[1].ToString();
                    bool goalMet = Boolean.Parse(mostRecentHabits.Rows[currentRow].ItemArray[5].ToString());
                    int streak = Int32.Parse(mostRecentHabits.Rows[currentRow].ItemArray[10].ToString());
                    int longestStreak = Int32.Parse(mostRecentHabits.Rows[currentRow].ItemArray[11].ToString());
                    //Streak is incremented only if the goal was met and it was met yesterday
                    if (goalMet && lastDate.AddDays(1) == today)
                    {
                        streak++;
                        if (streak > longestStreak)
                        {
                            longestStreak = streak;
                        }

                    }
                    //Streak reset to 0 if the user did not meet goal or did not log in yesterday
                    else
                    {
                        streak = 0;
                    }
                    habitTableTableAdapter.UpdateStreak(streak, longestStreak, name);
                }
                
                
                //Have to initialize current entries for the day since it is a new day
                for (int currentRow = 0; currentRow < currentHabits.Rows.Count; currentRow++)
                {
                    string name = currentHabits.Rows[currentRow].ItemArray[1].ToString();
                    decimal goal = Decimal.Parse(currentHabits.Rows[currentRow].ItemArray[3].ToString());
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
                    //Inserts new entry into habit history table
                    //Sets the progress as a default value of 0
                    habitHistoryTableTableAdapter.Insert(name, today, 0, goal, goalMet);
                }
            }
        }

        private void LoadDataFromTable()
        {

            //Right now, all the dates should go into the database as 12:00:00 AM or 00:00:00
            string today = DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM";

            trackrDBDataSet.habitHistoryTableDataTable habitHistory = new trackrDBDataSet.habitHistoryTableDataTable();
            habitHistoryTableTableAdapter.FillByDateJoining(habitHistory, DateTime.Parse(today));

            tableLayout.RowCount = habitHistory.Rows.Count;

            for (int currentRow = 0; currentRow < habitHistory.Rows.Count; currentRow++)
            {
                //Habit Column
                Label currentHabit = new Label();
                string posOrNeg = "+ ";

                if (!Boolean.Parse(habitHistory.Rows[currentRow].ItemArray[8].ToString()))
                {
                    posOrNeg = "- ";
                }

                bool goalMet = Boolean.Parse(habitHistory.Rows[currentRow].ItemArray[5].ToString());


                currentHabit.Text = posOrNeg + habitHistory.Rows[currentRow].ItemArray[1].ToString();
                currentHabit.Name = "currentHabit" + currentRow + "Label";
                currentHabit.TextAlign = ContentAlignment.MiddleCenter;
                currentHabit.Size = new Size(121, 38);
                //Conditional formatting based on if goal was met
                currentHabit.ForeColor = goalMet ? Color.Green : SystemColors.ControlText;
                tableLayout.Controls.Add(currentHabit, 0, currentRow);

                //  Goal Column
                Label currentGoal = new Label();
                string goalText = habitHistory.Rows[currentRow].ItemArray[4].ToString();
                int i = goalText.IndexOf('.');
                if (Decimal.Parse(goalText.Substring(i)) == 0)
                {
                    goalText = goalText.Substring(0, i);
                }
                currentGoal.Text = goalText;
                currentGoal.TextAlign = ContentAlignment.MiddleCenter;
                currentGoal.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentGoal, 1, currentRow);

               //Progress column

                //case for numeric goal
                if (habitHistory.Rows[currentRow].ItemArray[6].ToString() == "Numerical")
                {
                   //Add numeric up down to table
                    NumericUpDown todaysValue = new NumericUpDown();
                    
                    todaysValue.Size = new Size(121, 38);
                    todaysValue.Maximum = 1000;
                    todaysValue.Margin = new Padding(3, 10, 3, 3);
                    todaysValue.Value = Decimal.Parse(habitHistory.Rows[currentRow].ItemArray[3].ToString());
                    todaysValue.DecimalPlaces = 2;
                    //Conditional formatting based on goal met
                    todaysValue.BackColor = goalMet ? Color.LightGreen : SystemColors.Control;
                    tableLayout.Controls.Add(todaysValue, 2, currentRow);
                    //Adds event to be associated with conditional formating
                    todaysValue.ValueChanged += new System.EventHandler(numericChanged);
                }

                //case for binary goal
                else if (habitHistory.Rows[currentRow].ItemArray[6].ToString() == "Binary")
                {
                    //Add checkbox object for binary habits
                    CheckBox goalCheck = new CheckBox();
                    goalCheck.Size = new Size(121, 38);
                    goalCheck.CheckAlign = ContentAlignment.MiddleCenter;
                    goalCheck.Margin = new Padding(48, 9, 48, 9);
                    if (Decimal.Parse(habitHistory.Rows[currentRow].ItemArray[3].ToString()) == 1)
                    {
                        goalCheck.Checked = true;
                    }
                    else
                    {
                        goalCheck.Checked = false;
                    }
                    tableLayout.Controls.Add(goalCheck, 2, currentRow);

                    //Event associated with conditional formatting
                    goalCheck.CheckStateChanged += new System.EventHandler(checkChanged);
                }

                //  Streak Column
                Label currentStreak = new Label();
                currentStreak.Text = habitHistory.Rows[currentRow].ItemArray[10].ToString();
                currentStreak.TextAlign = ContentAlignment.MiddleCenter;
                currentStreak.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentStreak, 3, currentRow);


                dbUpdated = false;
            }
        }

        //The user input on the dashboard gets uploaded into the habitHistory table
        private void UploadCurrentProgress()
        {
            List<string> habitsOnDD = new List<string>();

            string today = DateTime.Now.ToString("M/dd/yyyy ") + "12:00:00 AM";
            trackrDBDataSet.habitHistoryTableDataTable habitHistory = new trackrDBDataSet.habitHistoryTableDataTable();
            habitHistoryTableTableAdapter.FillByDateJoiningIncludingNotTracked(habitHistory, DateTime.Parse(today));

            trackrDBDataSet.habitTableDataTable getLength = new trackrDBDataSet.habitTableDataTable();

            //  Gets all the rows that are being tracked and thus represented by the tableLayout
            habitTableTableAdapter.FillByCurrentlyTracked(getLength);
            int tableEntries = getLength.Rows.Count;

            for (int row = 0; row < tableEntries; row++)
            {
                //  When adding a control, this is needed as there are now more table entries than drawn in the tableLayout.
                if (tableEntries > tableLayout.RowCount)
                    return;
                string name = tableLayout.GetControlFromPosition(0, row).Text.Substring(2);
                var c = tableLayout.GetControlFromPosition(2, row);

                DataRow[] entry;

                //  How do we fix this if the name of the habit is changed
                entry = habitHistory.Select("habit = '" + name + "'");
                

                //  If entry = {} (no data row) then its name has been changed and this new name should be looked for

                decimal todaysValue = 0;
                decimal todaysGoal = Decimal.Parse(tableLayout.GetControlFromPosition(1, row).Text);
                bool goalMet = false;
                bool positive;
                try
                {
                    positive = Boolean.Parse(entry[0].ItemArray[8].ToString());
                }
                
                //  If entry was empty, select by previous name since a habit by that name no longer exists.
                catch (IndexOutOfRangeException)
                {
                    entry = habitHistory.Select("previousHabitName = '" + name + "'");
                }

                try
                {
                    positive = Boolean.Parse(entry[0].ItemArray[8].ToString());
                }

                //  If there is still no entry, then the habit had to be deleted
                catch (IndexOutOfRangeException)
                {
                    continue;
                }

                //Case if the control is a checkbox (binary habit)
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
                //Case if control is numericUpDown (numerical habit)
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
                //Update entry in habit history table
                habitHistoryTableTableAdapter.UpdateTodaysProgress(todaysValue, goalMet, name, DateTime.Parse(today));
            }
        }

        //Event handler for conditional formatting if numerical value is changed
        private void numericChanged(object sender, EventArgs e)
        {
            //Control object            
            Control C = (Control)sender;
            var num = (NumericUpDown)C;

            TableLayoutPanelCellPosition p = tableLayout.GetPositionFromControl(C);
            int row = p.Row;

            bool isPositive = tableLayout.GetControlFromPosition(0, row).Text.Substring(0,1) == "+";
            decimal goal = Decimal.Parse(tableLayout.GetControlFromPosition(1, row).Text);

            //Case if goal is met - green highlights
            if ((isPositive && num.Value >= goal) || (!isPositive && num.Value <= goal))
            {
                tableLayout.GetControlFromPosition(0, row).ForeColor = Color.Green;
                tableLayout.GetControlFromPosition(2, row).BackColor = Color.LightGreen;
            }
            //Case if goal is not met - default colors
            else
            {
                tableLayout.GetControlFromPosition(0, row).ForeColor = SystemColors.ControlText;
                tableLayout.GetControlFromPosition(2, row).BackColor = SystemColors.Control;
            }


        }

        private void checkChanged(object sender, EventArgs e)
        {
            //TODO: Conditional  formatting based on if goal is met yet
            //Control object            
            Control C = (Control)sender;
            var chk = (CheckBox)C;

            TableLayoutPanelCellPosition p = tableLayout.GetPositionFromControl(C);
            int row = p.Row;

            //Assigns color to text based on if goal was met
            tableLayout.GetControlFromPosition(0, row).ForeColor = chk.Checked ? Color.Green : SystemColors.ControlText;

        }


        //Create Habit Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            var myForm = new CreateHabit();
            myForm.Show();
        }

        //Display metrics click
        private void displayMetricsButton_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            CreateMetrics form = new CreateMetrics();
            form.Show();
        }

        //Edit habits click
        private void EditHabitsButton_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            EditHabits form = new EditHabits();
            form.Show();

        }

        //Syncing button click
        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadCurrentProgress();
            tableLayout.Controls.Clear();
            LoadDataFromTable();
        }

        //Uploads Daily Dashboard progress into database upon form closing
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            UploadCurrentProgress();
        }

    }
}
