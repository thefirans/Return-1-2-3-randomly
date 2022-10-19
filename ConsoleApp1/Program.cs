using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Program1
    {
        public static int OneTwoThree()
        {
            var random = new System.Random();
            return random.Next() * (3 - 1) + 1;
        }
    }
}
