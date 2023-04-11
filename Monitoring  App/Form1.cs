using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace Monitoring__App
{
    public partial class MonitoringApp : Form
    {
        List<MeasurementData> measurementList = new List<MeasurementData>();
        MeasurementData measurementData = new MeasurementData();

        public MonitoringApp()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            measurementList = measurementData.GetMeasurementData();
            FillDataGrid();
            FillChart();
            FillStatisticsFields();
        }

        private void FillDataGrid() 
        {
            gridMeasurementData.AutoGenerateColumns = true;
            gridMeasurementData.DataSource = measurementList;
            gridMeasurementData.Columns[0].HeaderText = "Measurement ID";
            gridMeasurementData.Columns[1].HeaderText = "Measurement Timestamp";
            gridMeasurementData.Columns[2].HeaderText = "Temperature [Celsius]";
            gridMeasurementData.Columns[3].HeaderText = "Temperature [Fahrenheit]";
        }

        private void FillChart()
        {
            chartMeasurementData.Series.Clear();
            chartMeasurementData.Series.Add("MeasurementData");
            chartMeasurementData.Series["MeasurementData"].ChartType = SeriesChartType.Line;

            ChartArea area = chartMeasurementData.ChartAreas[0];
            area.AxisY.Minimum = 23;
            area.AxisY.Maximum = 30;

            foreach (MeasurementData data in measurementList)
            {
                chartMeasurementData.Series["MeasurementData"].Points.AddXY(data.MeasurementId, data.MeasurementValue);
            }
        }

        private void FillStatisticsFields() 
        {
            StatisticsData statisticsData = new StatisticsData();
            statisticsData = statisticsData.GetStatisticsData();

            txtAverageData.Text = statisticsData.AverageData.ToString();
            txtMaxData.Text = statisticsData.MaxData.ToString();
            txtMinData.Text = statisticsData.MinData.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            measurementList = measurementData.GetMeasurementData();
            FillDataGrid();
            FillChart();
            FillStatisticsFields();
        }
    }
}
