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
            LoadDataFromTable();
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
            // TODO: This line of code loads data into the 'trackrDBDataSet.habitHistoryTable' table. You can move, or remove it, as needed.
            this.habitHistoryTableTableAdapter.Fill(this.trackrDBDataSet.habitHistoryTable);
        } 

        private void LoadDataFromTable()
        {
            trackrDBDataSet.habitTableDataTable habitData = new trackrDBDataSet.habitTableDataTable();
            habitTableTableAdapter.Fill(habitData);

            for(int currentRow = 0; currentRow < habitData.Rows.Count; currentRow++)
            {
                //  Habit Column
                Label currentHabit = new Label();
                currentHabit.Text = habitData.Rows[currentRow].ItemArray[1].ToString();
                currentHabit.Name = "currentHabit" + currentRow + "Label";
                currentHabit.TextAlign = ContentAlignment.MiddleCenter;
                currentHabit.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentHabit, 0, currentRow);

                //  Goal Column
                Label currentGoal = new Label();
                currentGoal.Text = habitData.Rows[currentRow].ItemArray[3].ToString();
                currentGoal.Name = "currentGoal" + currentRow + "Label";
                currentGoal.TextAlign = ContentAlignment.MiddleCenter;
                currentGoal.Size = new Size(121, 38);
                tableLayout.Controls.Add(currentGoal, 1, currentRow);

                //  Progress towards daily goal Column
                if (habitData.Rows[currentRow].ItemArray[2].ToString() == "Numerical")
                {
                    NumericUpDown currentCurrentGoal = new NumericUpDown();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    currentCurrentGoal.Size = new Size(121, 38);
                    currentCurrentGoal.Margin = new Padding(3, 10, 3, 3);
                }
                else if(habitData.Rows[currentRow].ItemArray[2].ToString() == "Binary")
                {
                    CheckBox currentCurrentGoal = new CheckBox();
                    tableLayout.Controls.Add(currentCurrentGoal, 2, currentRow);
                    currentCurrentGoal.Name = "currentCurrentGoal" + currentRow + "Label";
                    currentCurrentGoal.Size = new Size(121, 38);
                }

                //  Streak Column
                Label currentStreak = new Label();
                currentStreak.Text = habitData.Rows[currentRow].ItemArray[6].ToString();
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
    }
}
