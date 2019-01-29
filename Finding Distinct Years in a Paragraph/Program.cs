using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Humblefool has bron on 12-12-1993. He completed his school by 12-01-2006. 
						   He has been wroking with Google since 11-11-2011.";
            string[] li = str.Split(' ');
            List<int> years = new List<int>();
            foreach(var item in li)
            {               
                DateTime year;
                bool flag = DateTime.TryParse(item,out year);
                if (flag)
                {
                    years.Add(year.Year);
                } 
            }            
            int count = years.Distinct().Count();
            Console.WriteLine("Distinct years - "+count);
            Console.ReadKey();
        }
    }
}
