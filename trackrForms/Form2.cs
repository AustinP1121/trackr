using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (comboBox1.SelectedItem.ToString() == "Numerical")
            {
                label3.Visible = true;
                comboBox2.Visible = true;
                label4.Visible = true;
                numericUpDown1.Visible = true;
                label5.Visible = false;
            }
            else
            {
                label3.Visible = false;
                comboBox2.Visible = false;
                label4.Visible = false;
                numericUpDown1.Visible = false;
                label5.Visible = false;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Positive")
            {
                label5.Text = "or more";
                label5.Visible = true;
            }
            else if (comboBox2.SelectedItem.ToString() == "Negative")
            {
                label5.Text = "or less";
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
