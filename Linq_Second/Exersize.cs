﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Second
{
    class Exersize
    {

      public void NewLinq() {

            int[] badgers = { 36, 5, 91, 3, 41, 69, 8 };

            var skunks =
            from pigeon in badgers
            where (pigeon != 36 && pigeon < 50)
            orderby pigeon descending
            select pigeon + 5;

            var bears = skunks.Take(3);

            var weasels =
                from sparrow in bears
                select sparrow - 1;

           


            Console.WriteLine("Get your kikcks on route {0}", weasels.Sum());
        }
    }
}
