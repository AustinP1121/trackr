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
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
                var plt = new ScottPlot.Plot(600, 400);

                double[] values = { 779, 586 };
                string centerText=$"{values[0] / values.Sum() * 100:00.0}%";
                Color color1 = Color.FromArgb(255, 0, 150, 200);
                Color color2 = Color.FromArgb(100, 0, 150, 200);

                var pie = plt.AddPie(values);
                pie.DonutSize = .6;
                pie.DonutLabel = centerText;
                pie.CenterFont.Color = color1;
                pie.OutlineSize = 2;
                pie.SliceFillColors = new Color[] { color1, color2 };

                new ScottPlot.FormsPlotViewer(plt).ShowDialog();


        }
    }
}
