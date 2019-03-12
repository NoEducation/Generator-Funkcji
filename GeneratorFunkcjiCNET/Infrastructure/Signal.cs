using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorFunkcjiCNET.Infrastructure
{
    public class Signal
    {
        public int ResolutionPattern { get; set; }
        public int LenghtSignal { get; set; }
        public TypeSignal TypeSignal { get; set; }

        public double[] SignalValues;

        public double _kwant { get { return LenghtSignal * 2 * 3.14159 / ResolutionPattern; } private set { } } 

        public Signal()
        {
            ResolutionPattern = 8192;
            LenghtSignal = 1;
            TypeSignal = TypeSignal.SINUS;
        }
      
    }
}
