using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Algoritmi
{
    public class Breviar
    {
        public string[,] PrepareMatrix(string message, int rows, int column)
        {
            string[,] matrix = new string[rows, column];
            string[] filler = { "Q", "X", "Y", "X" };
            int fillerIndex = 0;
            message = message.Replace(" ", "");

            List<string> used = new List<string>();

            foreach (var character in message)
            {
                used.Add(character.ToString());
            }

            while(used.Count < rows * column)
            {
                used.Add(filler[fillerIndex++]);
            }

            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = used[index++];
                }
            }

            return matrix;
        }

        public string[,] BreviarCript(string[,] matrix, int[] order, int rows, int columns)
        {
            var matrixClone = matrix;

            string[,] newMatrix = new string[rows, columns];

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i, j] = matrixClone[order[i]-1, j];
                }
            }

            return newMatrix;
        }

        public string ReadMatrix(string[,] matrix, int rows, int columns)
        {
            var newMessage = String.Empty;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    newMessage += matrix[j, i];
                }
            }

            return newMessage;
        }
    }
}
