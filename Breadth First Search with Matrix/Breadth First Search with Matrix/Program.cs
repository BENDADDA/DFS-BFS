using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First_Search_with_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] Matrix = new int[,]
            {

          //   0  1  2  3  4 
        /*0*/{ 0, 1, 1, 0, 0 },
        /*1*/{ 0, 0, 0, 0, 1 },
        /*2*/{ 1, 0, 0, 0, 1 },
        /*3*/{ 0, 1, 1, 0, 0 },
        /*4*/{ 0, 1, 0, 1, 0 },
             
            };

            BFSGraph graph = new BFSGraph(Matrix);
            graph.BFSExplorer(3);
            Console.WriteLine();
            Console.WriteLine(graph.BFS(0, 5));
          
            Console.ReadKey();
        }
    }
}
