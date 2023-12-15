using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project.V10.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows, cols;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToString(line_r[j]);
                }
            }
            return arrayValues;
        }
    }
}
