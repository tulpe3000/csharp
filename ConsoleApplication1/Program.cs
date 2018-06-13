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
            int n = 300;
            int k = 300;
            int[] list = makeList(n);
            Console.WriteLine(Joseph.eneMeneMu(list,k));
            Console.ReadKey();
        }

        private static int[] makeList(int n)
        {
            int[] list = new int[n];
           for (int i=0; i < n; i++)
            {
                list[i] = i + 1;
            }
            return list;
        }
    }
}
