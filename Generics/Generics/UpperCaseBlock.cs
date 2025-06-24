using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class UpperCaseBlock:IBlock<T>
    {
        public UpperCaseBlock()
        {
            
        }
       public T Process(T input)
       {
            return input.ToUpper();
       }
    }
}
