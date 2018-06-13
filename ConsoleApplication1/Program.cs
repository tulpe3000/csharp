using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Josephus;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;
            Console.WriteLine(Joseph.eneMeneMu(list,k));
        }
    }
}
