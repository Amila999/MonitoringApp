using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Monitoring__App
{
    public class MeasurementData
    {
        public int MeasurementId { get; set; }
        public DateTime MeasurementTimeStamp { get; set; }
        public double MeasurementValue { get; set; }
        public double FahrenheitValue { get; set; }

        public List<MeasurementData> GetMeasurementData()
        {
            string connectionString = @"DATA SOURCE=DESKTOP-D4R0VU6\WINCC;DATABASE=SENSOR_SYSTEM;Integrated Security = True";
            List<MeasurementData> measurementDataList = new List<MeasurementData>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select MeasurementId, MeasurementTimeStamp, MeasurementValue, FahrenheitValue from GetMeasurementData where SensorName = 'TC01-1'";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    MeasurementData measurementData = new MeasurementData();

                    measurementData.MeasurementId = Convert.ToInt32(dr["MeasurementId"]);
                    measurementData.MeasurementTimeStamp = Convert.ToDateTime(dr["MeasurementTimeStamp"]);
                    measurementData.MeasurementValue = Convert.ToDouble(dr["MeasurementValue"]);
                    measurementData.FahrenheitValue = Convert.ToDouble(dr["FahrenheitValue"]);
                    measurementDataList.Add(measurementData);
                }
            }
            con.Close();
            return measurementDataList;
        }
    }

    public class StatisticsData 
    {
        public int StatisticsDataId { get; set; }
        public double AverageData { get; set; }
        public double MinData { get; set; }
        public double MaxData { get; set; }

        public StatisticsData GetStatisticsData()
        {
            StatisticsData statisticsData = new StatisticsData();
            string connectionString = @"DATA SOURCE=DESKTOP-D4R0VU6\WINCC;DATABASE=SENSOR_SYSTEM;Integrated Security = True";
            
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select AverageData, MinData,MaxData from GetStatisticsData where SensorName = 'TC01-1'";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read()) 
                {
                    statisticsData.AverageData = Convert.ToDouble(dr["AverageData"]);
                    statisticsData.MinData = Convert.ToDouble(dr["MinData"]);
                    statisticsData.MaxData = Convert.ToDouble(dr["MaxData"]);
                }
            }
            return statisticsData;
        }
    }
}
