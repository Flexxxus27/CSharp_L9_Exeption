using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L9
{
    public class BankruptExeption : Exception
    {
        public BankruptExeption(string message) : base (message) { }
    }
}
