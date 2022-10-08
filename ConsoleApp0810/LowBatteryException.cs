using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0810
{
    public class LowBatteryException : Exception
    {
        public Mobila ExceptionTarget { get; set; }

        public LowBatteryException() : base()
        {

        }

        public LowBatteryException(string massage) : base(massage)
        {

        }

        public LowBatteryException(string massage, Mobila exceptionTarget) : base(massage)
        {
            ExceptionTarget = exceptionTarget;
        }
    }
}
