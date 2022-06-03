using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First_Search
{
    class BFSGraph
    {
        AdjacencyList[] array;
        int size;
        //The Complexty Time Is O(n)
        public BFSGraph(int size)
        {
            this.size = size;
            array = new AdjacencyList[this.size];
            for(int i=0;i<size;i++)
            {
                array[i]=new AdjacencyList();
                array[i].head=null;
            }
        }
        //The Complexty Time Is O(1)
        public void AddNode(int src,int dest)
        {
            Node newnode=new Node(dest,null);
            newnode.next=array[src].head;
            array[src].head = newnode;
        }
        //<=>
        public void AddTD(int src,int dest)
        {
            AddNode(src,dest);
            AddNode(dest,src);
        }
        //Method Breadth First Search Explorer
        public void BFSExplorer(int StartVertex)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
                visited[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertex);
            visited[StartVertex] = true;
            while (queue.Count != 0)
            {
                int n = queue.Peek();
                Node head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.dest]) {
                        queue.Enqueue(head.dest);
                        visited[head.dest] = true;
                    }
                    head = head.next;
                }
                int Nout = queue.Dequeue();
                
                Console.WriteLine("Visite Node:" + Nout);

            
            }
            
        

        }

        //Method Breadth First Search 
        public bool BFS(int StartVertex,int element)
        {
            bool[] visited = new bool[size];
            for (int i = 0; i < size; i++)
                visited[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertex);
            visited[StartVertex] = true;
            while (queue.Count != 0)
            {
                int n = queue.Peek();
                Node head = array[n].head;
                while (head != null)
                {
                    if (head.dest == element) return true;
                    if (!visited[head.dest])
                    {

                        queue.Enqueue(head.dest);
                        visited[head.dest] = true;
                        
                    }
                    head = head.next;
                }
                int Nout = queue.Dequeue();

                Console.WriteLine("Visite Node:" + Nout);
            

            }


            return false;
        }


    }
}
