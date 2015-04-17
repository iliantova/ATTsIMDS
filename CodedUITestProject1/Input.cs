using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject1
{
    class Input
    {
        public static string InputText(int row, int col)
        {
            int numberRow = row;
            int numberCol = col;
            string[,] inputFail = new string[numberRow, numberCol];
            string result = "";
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))

                for (int i = 0; i < numberRow; i++)
                {
                    string[] inputNumber = reader.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < numberCol; j++)
                    {

                        inputFail[i, j] = inputNumber[j];

                    }
                }
            return result = inputFail[numberRow - 1, numberCol - 1];

        }
    }
}
