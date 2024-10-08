using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLibr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'A', 'B', 'C', 'D', 'E' };
            MyString myString = new MyString(str);
            Console.WriteLine(myString.EndWith());
            Console.ReadKey();
        }
    }
}
