using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace DrawFunction
{
    public partial class GraphicFrame : Form
    {
        bool color = true;

        int maxPoints = 60;
        int series = -1;
        double zum = 50;
        FileStream fs;
        StreamReader rw;
        XmlSerializer serializator = new XmlSerializer(typeof(List<double>));

        public GraphicFrame()
        {
            InitializeComponent();
            chart1.ChartAreas.Add(new ChartArea("mychart"));
            chart1.ChartAreas["mychart"].InnerPlotPosition = new ElementPosition(5,-70,100,100);
        }

        private void draw_Click(object sender, EventArgs e)
        {
            double point = 0;
            int listPoint;
            double timebuf = 0;
            ++series;
            chart1.Series.Add(new Series(series.ToString()));
            chart1.Series[series.ToString()].ChartArea = "mychart";
            chart1.Series[series.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            if (color)
            {
                chart1.Series[series.ToString()].Color = Color.Red;
            }else
            {
                chart1.Series[series.ToString()].Color = Color.Blue;
            }
            chart1.Series[series.ToString()].BorderWidth = 1;
            List<double> acsXY = this.getList();
            List<double> acsTime = this.getTime();
            listPoint = acsXY.Count();
            for(int i = 0; i < listPoint; ++i)
            {
                //  point += ((double)maxPoints / (double)listPoint);
                point = i;
                chart1.Series[series.ToString()].Points.AddXY((acsTime[i]), acsXY[i]);
            }
           // chart1.Series[0].Points.
        }

        private List<double> getTime()
        {
            List <double> lout;
            XmlSerializer serializator = new XmlSerializer(typeof(List<double>));
            fs = File.Open(button2.Text.ToString(), FileMode.Open);
            rw = new StreamReader(fs);
            lout = (List<double>)serializator.Deserialize(rw);
            rw.Close();
            fs.Close();
            return lout;
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
            //chart1.Series[series.ToString()]
            zum -= 5;
            chart1.ChartAreas["mychart"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["mychart"].AxisX.ScaleView.Zoom(0, zum);
            chart1.ChartAreas["mychart"].AxisY.ScaleView.Zoom(0, zum);
        }

        private void zumDown_Click(object sender, EventArgs e)
        {
            zum += 5;
            chart1.ChartAreas["mychart"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["mychart"].AxisX.ScaleView.Zoom(0, zum);
            chart1.ChartAreas["mychart"].AxisY.ScaleView.Zoom(0, zum);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            series = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                button2.Text = openFileDialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.color = !this.color;
        }
    }
}
