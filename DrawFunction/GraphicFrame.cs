using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DrawFunction
{
    public partial class GraphicFrame : Form
    {
        double zum = 10;
        FileStream fs;
        StreamReader rw;
        XmlSerializer serializator = new XmlSerializer(typeof(List<double>));

        public GraphicFrame()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            chart1.Series[0].Points.Clear();
            List<double> acsXY = this.getList();
            for(int i = 0; i < acsXY.Count(); ++i)
            {
                chart1.Series[0].Points.AddXY(i, acsXY[i]);
            }
        }

        private List<double> getList()
        {
            List<double> lout;
            fs = File.Open(fileName.Text.ToString(), FileMode.Open);
            rw = new StreamReader(fs);
            lout = (List<double>)serializator.Deserialize(rw);
            rw.Close();
            fs.Close();
            return lout;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFileDialog.FileName;
            }
        }

        private void zumUp_Click(object sender, EventArgs e)
        {
            zum += 0.002;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(zum, zum + 0.002);
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(zum, zum + 0.002);
        }

        private void zumDown_Click(object sender, EventArgs e)
        {
            zum = 1;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
