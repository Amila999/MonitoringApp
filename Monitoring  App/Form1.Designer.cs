
namespace Monitoring__App
{
    partial class MonitoringApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMeasurementData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridMeasurementData = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAverageData = new System.Windows.Forms.TextBox();
            this.txtMinData = new System.Windows.Forms.TextBox();
            this.txtMaxData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasurementData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMeasurementData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMeasurementData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMeasurementData.Legends.Add(legend1);
            this.chartMeasurementData.Location = new System.Drawing.Point(58, 89);
            this.chartMeasurementData.Name = "chartMeasurementData";
            this.chartMeasurementData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature [Deg C]";
            this.chartMeasurementData.Series.Add(series1);
            this.chartMeasurementData.Size = new System.Drawing.Size(1040, 365);
            this.chartMeasurementData.TabIndex = 0;
            this.chartMeasurementData.Text = "chart1";
            // 
            // gridMeasurementData
            // 
            this.gridMeasurementData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMeasurementData.Location = new System.Drawing.Point(85, 514);
            this.gridMeasurementData.Name = "gridMeasurementData";
            this.gridMeasurementData.Size = new System.Drawing.Size(596, 278);
            this.gridMeasurementData.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(791, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Average Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(791, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 735);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Temperature";
            // 
            // txtAverageData
            // 
            this.txtAverageData.Location = new System.Drawing.Point(796, 576);
            this.txtAverageData.Name = "txtAverageData";
            this.txtAverageData.Size = new System.Drawing.Size(100, 20);
            this.txtAverageData.TabIndex = 5;
            // 
            // txtMinData
            // 
            this.txtMinData.Location = new System.Drawing.Point(796, 674);
            this.txtMinData.Name = "txtMinData";
            this.txtMinData.Size = new System.Drawing.Size(100, 20);
            this.txtMinData.TabIndex = 5;
            // 
            // txtMaxData
            // 
            this.txtMaxData.Location = new System.Drawing.Point(796, 763);
            this.txtMaxData.Name = "txtMaxData";
            this.txtMaxData.Size = new System.Drawing.Size(100, 20);
            this.txtMaxData.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Deg C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 677);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deg C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(903, 766);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deg C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Measurement Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Temperature [Deg C]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 33);
            this.label9.TabIndex = 9;
            this.label9.Text = "Temperature Monitor";
            // 
            // MonitoringApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 804);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxData);
            this.Controls.Add(this.txtMinData);
            this.Controls.Add(this.txtAverageData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMeasurementData);
            this.Controls.Add(this.chartMeasurementData);
            this.Name = "MonitoringApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Monitor System";
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurementData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasurementData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurementData;
        private System.Windows.Forms.DataGridView gridMeasurementData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAverageData;
        private System.Windows.Forms.TextBox txtMinData;
        private System.Windows.Forms.TextBox txtMaxData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

