using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus
{
    public class Joseph
    {
        public static int eneMeneMu(int[] list, int k)
        {
            int result;
            int length = list.Length - 1;
            if (length == 0)
                return (list[0]);
		else {
                int[] newList = new int[length];
                for (int i = 0; i < length; i++)
                    newList[i] = list[(i + k) % list.Length];
                result = eneMeneMu(newList, k);
                return result;
            }
        }
    }
}
