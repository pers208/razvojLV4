using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int rows = dataset.GetData().Count;
            int cols = dataset.GetData()[0].Count;
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = dataset.GetData()[i][j];
                }
            }
            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
