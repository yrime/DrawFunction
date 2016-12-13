namespace DrawFunction
{
    partial class GraphicFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.draw = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.zumUp = new System.Windows.Forms.Button();
            this.zumDown = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(1004, 183);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(162, 50);
            this.draw.TabIndex = 1;
            this.draw.Text = "draw  Graph";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(1004, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(162, 51);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "open file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.SystemColors.Control;
            this.fileName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fileName.Location = new System.Drawing.Point(1004, 239);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(162, 26);
            this.fileName.TabIndex = 4;
            // 
            // zumUp
            // 
            this.zumUp.Location = new System.Drawing.Point(1004, 69);
            this.zumUp.Name = "zumUp";
            this.zumUp.Size = new System.Drawing.Size(162, 52);
            this.zumUp.TabIndex = 5;
            this.zumUp.Text = "zum +";
            this.zumUp.UseVisualStyleBackColor = true;
            this.zumUp.Click += new System.EventHandler(this.zumUp_Click);
            // 
            // zumDown
            // 
            this.zumDown.Location = new System.Drawing.Point(1004, 127);
            this.zumDown.Name = "zumDown";
            this.zumDown.Size = new System.Drawing.Size(162, 50);
            this.zumDown.TabIndex = 6;
            this.zumDown.Text = "zum -";
            this.zumDown.UseVisualStyleBackColor = true;
            this.zumDown.Click += new System.EventHandler(this.zumDown_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(998, 644);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1004, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1004, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1004, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GraphicFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zumDown);
            this.Controls.Add(this.zumUp);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.draw);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GraphicFrame";
            this.Text = "Graphic";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button zumUp;
        private System.Windows.Forms.Button zumDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

