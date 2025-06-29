using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataFlow<T>:IDataFlow<T> where T : class
    {
        public List<IBlock<T>> _blocks=new List<IBlock<T>>();

        public T RunFlow(T input)
        {
            T value = input;
            foreach (var item in _blocks)
            {
                value = item.Process(value);
            }
            return value;
        }
        public void AddBlock(IBlock<T> block)
        {
            this._blocks.Add(block);
        }
    }
}
