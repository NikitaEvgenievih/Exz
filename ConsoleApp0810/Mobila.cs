using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0810
{
    public class Mobila
    {
        public string Nomer { get; set; }
        public int Batarea { get; set; }
        public bool SimKarta { get; set; }

        public Mobila()
        {
        }

        public Mobila(string nomer, int batarea, bool simKarta)
        {
            Nomer = nomer;
            Batarea = batarea;
            SimKarta = simKarta;
        }
        public void Call(string mob1)
        {
            if(Batarea == 0)
            {
                throw new DivideByZeroException("Ваш телефон разряжен полностью!");
            }
            else if (!SimKarta)
            {
                throw new NotImplementedException("В вашем телефоне нету симкарты!");
            }
            else if (mob1.Length != 13 || !mob1.StartsWith("+380"))
            {
                throw new NotImplementedException("");
            }
            Console.WriteLine("Звонок!");
        }
    }
}
