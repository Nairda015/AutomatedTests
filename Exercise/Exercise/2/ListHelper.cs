using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class ListHelper
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            for (var i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] % 2 != 0) continue;
                listOfNumbers.RemoveAt(i);
                i--;
            }
            return listOfNumbers;
        }
    }
}
