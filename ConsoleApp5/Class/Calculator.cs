using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Class
{
    public class Calculator
    {
        public string UserName { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        
        public string Greeting()
        {
            return $"Hello!  {UserName}. ";
        }

        public int Addiation()
        {
            return FirstNumber + SecondNumber;
        }
        public int Subtraction()
        {
            return FirstNumber - SecondNumber;
        }
        public int Multiplation()
        {
            return FirstNumber * SecondNumber;
        }
        public int Dividation()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
