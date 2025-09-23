using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.Algorythms
{
    public abstract class AlgoBase
    {
        public abstract string Description { get; }
        public abstract int MaxVectorSize { get; }
        public virtual void Execute(int[] vector) { }
    }
}
