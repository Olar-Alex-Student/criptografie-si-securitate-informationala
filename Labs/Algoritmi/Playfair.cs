using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Algoritmi
{
    public class Playfair
    {
        public string[,] GenerateMatrix(string password)
        {
            string[,] matrix = new string[5, 5];

            password = password.Replace('J', 'I').Replace(" ", "");

            HashSet<char> used = new HashSet<char>();
            List<char> passwords = new List<char>(); 

            foreach(var character in password)
            {
                if(used.Add(character))
                {
                    passwords.Add(character);
                }
            }

            for(var i = 'A'; i <= 'Z'; i++)
            {
                if(i != 'J' && used.Add(i))
                {
                    passwords.Add(i);
                }
            }

            int index = 0;
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = passwords[index++].ToString();
                }
            }

            return matrix;
        }

        public string ProcessMessage(string message)
        {
            string newMessage = String.Empty;

            for(int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                {
                    if (i > 0 && message[i] == message[i - 1] && i % 2 == 1)
                    {
                        newMessage += 'X';
                    }
                    else
                    {
                        newMessage += message[i];
                    }
                }
            }

            if (newMessage.Length % 2 == 1)
            {
                newMessage += 'X';
            }

            return newMessage;
        }

        public int[] Position(string letter, string[,] matrix)
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == letter)
                    {
                        var list = new int[2];
                        list[0] = i;
                        list[1] = j;
                        return list;
                    }
                }
            }

            return null;
        }

        public string PlayFairCript(string message, string[,] matrix)
        {
            string newMessage = String.Empty;

            for(int i = 0; i < message.Length; i = i+2)
            {
                var letterA = message[i].ToString();
                var letterB = message[i+1].ToString();
                var posA = Position(letterA, matrix);
                var posB = Position(letterB, matrix);

                if (posA[0] == posB[0])
                {
                    newMessage += matrix[posA[0], (5 + posA[1] + 1) % 5];
                    newMessage += matrix[posB[0], (5 + posB[1] + 1) % 5];
                }
                else if (posA[1] == posB[1])
                {
                    newMessage += matrix[(5 + posA[0] + 1) % 5, posA[1]];
                    newMessage += matrix[(5 + posB[0] + 1) % 5, posB[1]];
                }
                else
                {
                    newMessage += matrix[posA[0], posB[1]];
                    newMessage += matrix[posB[0], posA[1]];
                }
            }

            return newMessage;
        }
        
        public string PlayFairDecript(string message, string[,] matrix)
        {
            string newMessage = String.Empty;

            for(int i = 0; i < message.Length; i = i+2)
            {
                var letterA = message[i].ToString();
                var letterB = message[i+1].ToString();
                var posA = Position(letterA, matrix);
                var posB = Position(letterB, matrix);

                if (posA[0] == posB[0])
                {
                    newMessage += matrix[posA[0], (5 + posA[1] - 1) % 5];
                    newMessage += matrix[posB[0], (5 + posB[1] - 1) % 5];
                }
                else if (posA[1] == posB[1])
                {
                    newMessage += matrix[(5 + posA[0] - 1) % 5, posA[1]];
                    newMessage += matrix[(5 + posB[0] - 1) % 5, posB[1]];
                }
                else
                {
                    newMessage += matrix[posA[0], posB[1]];
                    newMessage += matrix[posB[0], posA[1]];
                }
            }

            return newMessage;
        }
    }
}
