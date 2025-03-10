using Labs.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Algoritmi
{
    public class Cezar
    {
        public Alfabet Alfabet = new Alfabet();

        public string CezarCript(string message, int k)
        {
            string newMessage = String.Empty;

            foreach (var character in message)
            {
                if(character.ToString() == " ")
                {
                    newMessage += " ";
                }

                var indexOfChar = Alfabet.Litere.IndexOf(character.ToString());
                var newChar = Alfabet.Litere[(indexOfChar + k + 26) % 26];
                newMessage += newChar.ToString();
            }

            return newMessage;
        }
        
        public string CezarDecript(string message, int k)
        {
            string newMessage = String.Empty;

            foreach (var character in message)
            {
                if (character.ToString() == " ")
                {
                    newMessage += " ";
                }

                var indexOfChar = Alfabet.Litere.IndexOf(character.ToString());
                var newChar = Alfabet.Litere[(26 + indexOfChar - k) % 26];
                newMessage += newChar.ToString();
            }

            return newMessage;
        }
    }
}
