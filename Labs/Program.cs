using Labs.Labs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Program
    {
        static public Lab1 Lab1 = new Lab1();
        static public Lab2 Lab2 = new Lab2();
        static public Lab3 Lab3 = new Lab3();
        static void Main(string[] args)
        {
            Lab1.Ex1();
            Lab1.Ex2();
            Lab1.Ex3();
            Lab1.Ex4();
            Lab1.Ex6();
            Lab1.Ex7();
            Lab1.Ex8();
            Lab1.Ex9();

            Console.WriteLine("-----");

            Lab2.Ex1();
            Lab2.Ex2();
            //Lab2.Ex1_1();
            //Lab2.Ex2_2();
            Lab2.Ex3();
            Lab2.Ex4();
            //Lab2.Ex3_3();
            //Lab2.Ex4_4();

            Console.WriteLine("-----");

            Lab3.Ex1();

            Console.ReadLine();
        }
    }
}
