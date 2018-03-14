using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo
{
    class CapitalLetter : Exception
    {
        public CapitalLetter(String msg)
             : base(msg)
        {
        }
    }
}
