using Algorythms_Logic.Algorythms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms_Logic.BinaryOperations
{
    public abstract class PowBase : AlgoBase
    {
        private int stepCount;
        public abstract int StepCount { get; }
        public override abstract string Description { get; }
        public override abstract int MaxVectorSize { get; }
        public abstract int MaxBasisNumber { get; }
        public virtual void Execute(int basis, int arg) { }
    }
}
