using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Second
{
    class ComicClass
    {
        public string Name { get; set; }
        public int Issue { get; set; }
        public override string ToString() => $"{Name} (Issue #{Issue})";
        public static readonly IEnumerable<ComicClass> Catalog = new List<ComicClass>
        {
            new ComicClass {Name = "Johnny America vs. the Pinko", Issue = 6},
            new ComicClass {Name = "Rock and Roll (limited edition)", Issue = 19},
            new ComicClass {Name = "Woman's work", Issue = 36},
            new ComicClass {Name = "Hippie Madness(misprinted)", Issue = 57},
            new ComicClass {Name = "Revenge of the New Wave Freak (demaged)", Issue = 68},
            new ComicClass {Name = "Balck Monday", Issue = 74},
            new ComicClass {Name = "Tribal Tatto Madness", Issue = 83},
            new ComicClass {Name = "The Death of the Object", Issue = 97},
        };

        public static readonly IReadOnlyDictionary<int, decimal> Prices = new Dictionary<int, decimal>
        {
            { 6, 3600M },
            {19, 500M },
            {36, 650M },
            {57, 13525M },
            {68, 250M },
            {74, 75M },
            {83, 25.75M },
            {97, 35.25M },
        };

        public void Comic()
        {

            IEnumerable<ComicClass> mostExpensive =
        from comic in ComicClass.Catalog
        where ComicClass.Prices[comic.Issue] > 500
        orderby -ComicClass.Prices[comic.Issue]
        select comic;
            Console.WriteLine();
            Console.WriteLine();
            foreach (ComicClass comic in mostExpensive)
            {
           
               
                Console.WriteLine($"{comic} is worth {ComicClass.Prices[comic.Issue]:c}");
            }
        }
    }
}
