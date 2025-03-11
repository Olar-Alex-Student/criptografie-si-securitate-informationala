using Labs.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Algoritmi
{
    public class Vigenere
    {
        public Alfabet Alfabet = new Alfabet();

        public string VegenereCript(string message, string password)
        {
            string newMessage = String.Empty;

            for(int i = 0; i < message.Length; i++)
            {
                if (message[i].ToString() == " ")
                {
                    newMessage += " ";
                }
                else
                {
                    var idexOfCharMessage = Alfabet.Litere.IndexOf(message[i].ToString());
                    var idexOfCharPassword = Alfabet.Litere.IndexOf(password[i % password.Length].ToString());
                    var indexOdCharNewMessage = (26 + idexOfCharMessage + idexOfCharPassword) % 26;
                    newMessage += Alfabet.Litere[indexOdCharNewMessage];
                }
            }

            return newMessage;
        }

        public string VegenereDecript(string message, string password)
        {
            string newMessage = String.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].ToString() == " ")
                {
                    newMessage += " ";
                }
                else
                {
                    var idexOfCharMessage = Alfabet.Litere.IndexOf(message[i].ToString());
                    var idexOfCharPassword = Alfabet.Litere.IndexOf(password[i % password.Length].ToString());
                    var indexOdCharNewMessage = (26 + idexOfCharMessage - idexOfCharPassword) % 26;
                    newMessage += Alfabet.Litere[indexOdCharNewMessage];
                }
            }

            return newMessage;
        }
    }
}
