using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deph_First_Search_with_matrix
{
    class DFSGraph
    {
        int[,] Matrix;
        int size;
        public DFSGraph(int[,] Matrix)
        {
            this.Matrix = Matrix;
            this.size = Matrix.GetLength(1);
        }
        
        // Explorer
        public void DFSExplorer(int StartVertix)
        {
            bool[] visted = new bool[size];
            for (int i = 0; i < size; i++)
                visted[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertix);
            while (stack.Count !=0)
            {
                int n = stack.Peek();
                visted[n] = true;
                bool isdone = true;
                for (int i = 0; i < size; i++)
                {
                    if(Matrix[n,i]==1)
                        if (!visted[i])
                        {
                            stack.Push(i);
                            isdone = false;
                            break;
                        }
                }
                if (isdone) 
                {
                    int Nout = stack.Pop();
                    Console.WriteLine("Visite Node:" + Nout);
                }
            }


        }

        //Depth first search
        public bool DFS(int StartVertix,int element)
        {
            bool[] visted = new bool[size];
            for (int i = 0; i < size; i++)
                visted[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertix);
            while (stack.Count != 0)
            {
                int n;
                if (element==(n=stack.Peek())) return true;
                visted[n] = true;       
                bool isdone = true;
                for (int i = 0; i < size; i++)
                {
                    if (Matrix[n, i] == 1)
                        if (!visted[i])
                        {  
                            stack.Push(i);
                            isdone = false;
                            break;
                        }
                }
                if (isdone) stack.Pop();
            }
            return false;
        }
    


    }
}
