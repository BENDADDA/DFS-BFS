using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First_Search_with_Matrix
{
    class BFSGraph
    {
        int[,] Matrix;
        int size;
        public BFSGraph(int[,] Matrix)
        {
            this.Matrix = Matrix;
            this.size = Matrix.GetLength(1);
        }
        
        // Explorer
        public void BFSExplorer(int StartVertix)
        {
            bool[] visted = new bool[size];
            for (int i = 0; i < size; i++)
                visted[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertix);
            while (queue.Count !=0)
            {
                int n = queue.Peek();
                visted[n] = true;
                for (int i = 0; i < size; i++)
                {
                    if(Matrix[n,i]==1)
                        if (!visted[i])
                        {
                            queue.Enqueue(i);
                            visted[i] = true;
                        }
                }


                    int Nout = queue.Dequeue();
                    Console.WriteLine("Visite Node:" + Nout);
                
            }


        }

        //Breadth fist search
        public bool BFS(int StartVertix,int element)
        {
            bool[] visted = new bool[size];
            for (int i = 0; i < size; i++)
                visted[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertix);
            while (queue.Count != 0)
            {
                int n = queue.Peek();
                visted[n] = true;
                for (int i = 0; i < size; i++)
                {
                    if (Matrix[n, i] == 1)
                        if (!visted[i])
                        {
                            if (i == element||n==element) return true;
                            queue.Enqueue(i);
                            visted[i] = true;
                        }
                }
              queue.Dequeue();
            }
            return false;
        }

        //-----------------------------------------end.

    }
}
