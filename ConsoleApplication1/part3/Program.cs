using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace part3
{
    class Program
    {
        static void findMatch(string str, string strpat)
        {
            Regex pat = new Regex(strpat);
            MatchCollection matches = pat.Matches(str);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine($"Найдено:{match.Value}");
            }
            else
                Console.WriteLine("Не найдено");
        }

        static void Main(string[] args)
        {
            Console.Write("Input str: ");
            string str = Console.ReadLine();

            string strpat = @"[0-9]+";
            //Console.WriteLine((Regex.IsMatch(str, strpat)) ? "Есть совпадения" : "Нет совпадений");
            findMatch(str, strpat);
        }
    }
}

