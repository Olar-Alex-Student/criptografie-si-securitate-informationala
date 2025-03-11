using Labs.Algoritmi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Labs
{
    public class Lab3
    {
        Breviar Breviar = new Breviar();

        public void Ex1()
        {
            int[] order = new int[] { 3, 1, 5, 2, 4 };
            var matrix = Breviar.PrepareMatrix("THE ART OF PROGRAMMING", 5, 4);
            var criptBreviar = Breviar.BreviarCript(matrix, order, 5, 4);
            var readCriptBreviar = Breviar.ReadMatrix(criptBreviar, 5, 4);

            Console.WriteLine(readCriptBreviar);
        }
    }
}
