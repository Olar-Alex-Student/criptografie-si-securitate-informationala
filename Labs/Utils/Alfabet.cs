using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Utils
{
    public class Alfabet
    {
        public List<string> Litere = new List<string>();

        public Alfabet()
        {
            for(var i = 'A'; i <= 'Z'; i++)
            {
                Litere.Add(i.ToString());
            }
        }
    }
}
