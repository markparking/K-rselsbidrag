using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørselsbidrag
{
    public class Logic : LogicBase
    {
        public Logic()
        {
        }

        public double kmPerDag { get; set; }
        public int broType { get; set; }

 
        public double Output()
        {
            double bropenge = BroPenge(broType);
            double penge = 0;

            if (kmPerDag > 120)
            {
                double temp = kmPerDag - 120;
                penge = temp * over120Km;
                kmPerDag -= temp;
            }

            if (kmPerDag > 24)
            {
                double temp = kmPerDag - 24;
                penge += temp * under120Km;
                kmPerDag -= temp;
            }

            if ((kmPerDag - 24) * 2.16 + penge + bropenge > 0)
            {
                double result = (kmPerDag - 24) * 2.16 + penge + bropenge;
                Console.WriteLine(result);
                return result;
            }
            else
            {
                double output = 0;
                Console.WriteLine(output);
                return output;
            }
        }
        public double BroPenge(int broType)
        {

            if (broType == 0)
            {
                return 0;
            }

            if (broType == 1)
            {
                return 50 * 2;
            }

            return 110 * 2;
        }
    }
    interface Outputs
    {
        double Output();
        double BroPenge();
    }
}
