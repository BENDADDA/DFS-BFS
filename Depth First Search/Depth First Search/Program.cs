using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depth_First_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            DFSGraph graph = new DFSGraph(5);
            graph.AddNode(0, 2);
            graph.AddNode(0, 1);
            graph.AddNode(1, 4);
            graph.AddNode(1, 3);
            graph.AddNode(1, 0);
            graph.AddNode(2, 4);
            graph.AddNode(2, 3);
            graph.AddNode(2, 0);
            graph.AddNode(3, 2);
            graph.AddNode(3, 1);
            graph.AddNode(4, 2);
            graph.AddNode(4, 1);
            graph.DFSExplorer(2);
            Console.WriteLine(graph.DFS(2, 1));
            Console.ReadKey();
        }
    }
}
