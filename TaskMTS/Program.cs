using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMTS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,8,5,4,5,6,9,5};
            int value = 5;
            var NewList = list.Where(x => x != value).ToList();
            foreach (var g in NewList) 
            {
                Console.WriteLine(g);
            }
        }
    }
}
