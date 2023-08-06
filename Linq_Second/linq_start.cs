using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linq_Second
{
    class linq_start
    {   
       
        static int[] values = new int[]  { 0, 12, 44, 36, 92, 54, 13, 8 };

        IEnumerable<int> result = from v in values
                                  where v < 37
                                  orderby -v
                                  select v;

        public void ShowTheResult()
        {
            foreach (int i in result)
                Console.Write($"{i} ");
        }

    }
}
