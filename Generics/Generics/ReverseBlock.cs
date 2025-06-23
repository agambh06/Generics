using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ReverseBlock:IBlock<string>
    {
        public string Process(string input)
        {
            for (int i = input.Length-1; i >=0 ; i--)
            {
                char c = input[i];
                input.Remove(i);
                input = c + input;
            }
            return input;
        }
    }
}
