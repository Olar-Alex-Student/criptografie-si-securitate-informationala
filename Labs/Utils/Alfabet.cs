using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Utils
{
    public class Alfabet
    {
        public List<string> Litere = Enumerable.Range('A', 26)
                                          .Select(c => ((char)c).ToString())
                                          .ToList();
    }
}
