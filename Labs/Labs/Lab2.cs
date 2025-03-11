using Labs.Algoritmi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Labs
{
    public class Lab2
    {
        public Playfair Playfair = new Playfair();
        public void Ex1()
        {
            var matrix = Playfair.GenerateMatrix("MALICIOUS");
            var message = Playfair.ProcessMessage("AUTONOMOUS ATTACK AGENTS");
            var criptPlayFair = Playfair.PlayFairCript(message, matrix);

            Console.WriteLine(criptPlayFair);
        }
        
        public void Ex2()
        {
            var matrix = Playfair.GenerateMatrix("SECRET KEY");
            var message = Playfair.ProcessMessage("THE ART OF PROGRAMMING");
            var criptPlayFair = Playfair.PlayFairCript(message, matrix);

            Console.WriteLine(criptPlayFair);
        }
        
        public void Ex1_1()
        {
            var matrix = Playfair.GenerateMatrix("MALICIOUS");
            var message = Playfair.ProcessMessage("UFNDVEOESBCPPCDTLFNVQD");
            var decriptPlayFair = Playfair.PlayFairDecript(message, matrix);

            Console.WriteLine(decriptPlayFair);
        }
        
        public void Ex2_2()
        {
            var matrix = Playfair.GenerateMatrix("SECRET KEY");
            var message = Playfair.ProcessMessage("CLCYTSMHXBNHCBPUGPIV");
            var decriptPlayFair = Playfair.PlayFairDecript(message, matrix);

            Console.WriteLine(decriptPlayFair);
        }

        public void Ex3()
        {
            var matrix = Playfair.GenerateMatrix("PASSWORD");
            var message = Playfair.ProcessMessage("RFRBD ONU");
            var decriptPlayFair = Playfair.PlayFairDecript(message, matrix);

            Console.WriteLine(decriptPlayFair);
        }
        
        public void Ex4()
        {
            var matrix = Playfair.GenerateMatrix("SECRET KEY");
            var message = Playfair.ProcessMessage("RFGPRTPXCQIEKHGRCDRCTCYCESCYXS");
            var decriptPlayFair = Playfair.PlayFairDecript(message, matrix);

            Console.WriteLine(decriptPlayFair);
        }
        
        public void Ex3_3()
        {
            var matrix = Playfair.GenerateMatrix("PASSWORD");
            var message = Playfair.ProcessMessage("PREDEALX");
            var criptPlayFair = Playfair.PlayFairCript(message, matrix);

            Console.WriteLine(criptPlayFair);
        }
        
        public void Ex4_4()
        {
            var matrix = Playfair.GenerateMatrix("SECRET KEY");
            var message = Playfair.ProcessMessage("SIINCRIPTOGRAFIETACEREAESTEAUR");
            var criptPlayFair = Playfair.PlayFairCript(message, matrix);

            Console.WriteLine(criptPlayFair);
        }
    }
}
