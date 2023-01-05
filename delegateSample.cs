using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void DelegateName(int x, int y);
    public class Sample
    {
            public void Addition(int a, int b)
            {
                Console.WriteLine(a + b);
            }
    }
}


// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Sample s = new Sample();
DelegateName dn = new DelegateName(s.Addition);
dn(5, 6);

