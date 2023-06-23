using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørselsbidrag
{
    public abstract class LogicBase
    {
        public double under120Km = 2.16;
        public double over120Km = 1.08;
        public double kmMin = 24;
    }
}
