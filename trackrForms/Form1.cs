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
            var myForm = new CreateHabit();
            myForm.Show();
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");
            dateLabel.Visible = true;
            LoadDataFromTable();

            // TODO: This line of code loads data into the 'trackrDBDataSet.habitHistoryTable' table. You can move, or remove it, as needed.
            this.habitHistoryTableTableAdapter.Fill(this.trackrDBDataSet.habitHistoryTable);
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

            for (int currentRow = 0; currentRow<habitHistory.Rows.Count;currentRow++)
            {
                //Habit Column
                Label currentHabit = new Label();
                currentHabit.Text = habitHistory.Rows[currentRow].ItemArray[1].ToString();
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
                if (habitHistory.Rows[currentRow].ItemArray[6].ToString() == "Numerical")
                {
                    NumericUpDown currentCurrentGoal = new NumericUpDown();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    currentCurrentGoal.Size = new Size(121, 38);
                    currentCurrentGoal.Margin = new Padding(3, 10, 3, 3);
                    currentCurrentGoal.Value = Int32.Parse(habitHistory.Rows[currentRow].ItemArray[3].ToString());

                    //Adds event to be associated with conditional formating
                    currentCurrentGoal.ValueChanged += new System.EventHandler(numericChanged);
                }

                //case for binary goal
                else if (habitHistory.Rows[currentRow].ItemArray[6].ToString() == "Binary")
                {
                    CheckBox currentCurrentGoal = new CheckBox();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    currentCurrentGoal.Size = new Size(121, 38);
                    if (habitHistory.Rows[currentRow].ItemArray[3].ToString() == "1")
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
                currentStreak.Text = habitHistory.Rows[currentRow].ItemArray[10].ToString();
                currentStreak.Name = "currentStreak" + currentRow + "Label";
                currentStreak.TextAlign = ContentAlignment.MiddleCenter;
                currentStreak.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentStreak, 3, currentRow);

                dbUpdated = false;
            }

             
             

        }

        private void updateDashboardButton_Click(object sender, EventArgs e)
        {
            tableLayout.Controls.Clear();
            LoadDataFromTable();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Write Current Progress into habitHistory data table
        }

        private void numericChanged(object sender, EventArgs e)
        {
            //TODO: Conditional  formatting based on if goal is met yet
        }

        private void checkChanged(object sender, EventArgs e)
        {
            //TODO: Conditional  formatting based on if goal is met yet
        }
    }

    
}
