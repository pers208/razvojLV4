using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.GetLength(0);
            int colCount = data[0].GetLength(0);
            double[] matrix = new double[colCount];
            for (int i = 0; i < colCount; i++)
            {
                for(int j = 0; j < rowCount; j++)
                {
                    matrix[i]+= data[j][i];
                }
                matrix[i] /= rowCount;
            }
            return matrix;
        }
    }
}
