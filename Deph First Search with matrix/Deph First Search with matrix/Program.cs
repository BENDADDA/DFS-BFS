using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deph_First_Search_with_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[,]
            {

          //   0  1  2  3  4 
        /*0*/{ 0, 1, 1, 0, 0 },
        /*1*/{ 1, 0, 0, 1, 1 },
        /*2*/{ 1, 0, 0, 1, 1 },
        /*3*/{ 0, 1, 1, 0, 0 },
        /*4*/{ 0, 1, 1, 0, 0 },
             
            };

            DFSGraph graph = new DFSGraph(Matrix);
            graph.DFSExplorer(4);
          
            bool value =graph.DFS(0,4);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
