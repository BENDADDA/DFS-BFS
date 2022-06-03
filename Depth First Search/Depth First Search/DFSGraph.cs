using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depth_First_Search
{
    class DFSGraph
    {
        AdjacencyList[] array;
        int size;
        public DFSGraph(int size)
        {
            this.size = size;
            array = new AdjacencyList[this.size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new AdjacencyList();
                array[i].head = null;
            }

        }
        //Method Add,the complexty time is O(1).
        public void AddNode(int src, int dest)
        {
            Node newnode = new Node(dest, null);
            newnode.next = array[src].head;
            array[src].head = newnode;
        }
        //Method Depth First Search Explorer,the complexty time is O(n).
        public void DFSExplorer(int StartVertex)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
                visited[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertex);
            while (stack.Count!=0)
            {
                int n = stack.Pop();
                stack.Push(n);
                Node head = array[n].head;
                visited[n] = true;
                bool isDone = true;
                while (head != null)
                {
                    if (!visited[head.dest])
                    {
                        stack.Push(head.dest);
                        isDone = false;
                        break;
                    }
                    else head = head.next;
                }
                if (isDone) 
                {
                    int NOut = stack.Pop();
                    Console.WriteLine("Visit node:"+NOut);
                }
                  
            }
          }
        
        //Mithod Depth First Search.
        public bool DFS(int StartVertex,int element)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
                visited[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertex);
            while (stack.Count != 0)
            {
                int n = stack.Pop();
                stack.Push(n);
                Node head = array[n].head;
                visited[n] = true;
                bool isDone = true;
                while (head != null)
                {
                    if (head.dest == element) return true;
                    if (!visited[head.dest])
                    {
                        stack.Push(head.dest);
                        isDone = false;
                        break;
                    }
                    else head = head.next;
                    
                }
                if (isDone)
                {
                    int NOut = stack.Pop();
                   
                }

            }
            return false;

        }


        
    }
}
