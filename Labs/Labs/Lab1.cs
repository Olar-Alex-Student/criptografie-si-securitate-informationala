using Labs.Algoritmi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Labs
{
    public class Lab1
    {
        public Cezar Cezar = new Cezar();
        public Vigenere Vigenere = new Vigenere();

        public void Ex1()
        {
            var criptCezar = Cezar.CezarCript("CALCULATOR", 9);
            Console.WriteLine(criptCezar.ToString());
        }

        public void Ex2()
        {
            var criptCezar = Cezar.CezarCript("DIGITAL SIGNATURE", 3);
            Console.WriteLine(criptCezar.ToString());
        }

        public void Ex3()
        {
            for (int i = 0; i < 26; i++)
            {
                var decriptCezar = Cezar.CezarDecript("WIGYVMXEXIMR JSVQEXMSREPE", i);

                Console.WriteLine(decriptCezar.ToString() + " i: " + i);
            }
        }
        
        public void Ex4()
        {
            for (int i = 0; i < 26; i++)
            {
                var decriptCezar = Cezar.CezarDecript("YZKBKPUHY", i);

                Console.WriteLine(decriptCezar.ToString() + " i: " + i);
            }
        }

        public void Ex6()
        {
            var criptVigenere = Vigenere.VegenereCript("CRIPTOGRAFIE", "TEST");
            
            Console.WriteLine(criptVigenere.ToString());
        }

        public void Ex7()
        {
            var criptVigenere = Vigenere.VegenereCript("THE ART OF PROGRAMMING", "PYTHON");

            Console.WriteLine(criptVigenere.ToString());
        }

        public void Ex8()
        {
            var descriptVigenere = Vigenere.VegenereDecript("PCWKPOVVIEMFPSOWROVABWTDI", "PASSWORD");

            Console.WriteLine(descriptVigenere.ToString());
        }
        
        public void Ex9()
        {
            var descriptVigenere = Vigenere.VegenereDecript("WRKADIXNBKUNJBZSMTMBVGXA", "ENIGMA");

            Console.WriteLine(descriptVigenere.ToString());
        }
    }
}
