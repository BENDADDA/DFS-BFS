using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            BFSGraph graph = new BFSGraph(5);
            graph.AddTD(0, 4);
            graph.AddTD(0, 3);
            graph.AddTD(0, 1);
            graph.AddTD(1, 4); 
            graph.AddTD(1, 3);
            graph.AddTD(1, 2);
            graph.AddTD(2, 4);
            graph.AddTD(2, 3);
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            graph.BFSExplorer(n);         
            Console.ReadKey();
        }
    }
}
