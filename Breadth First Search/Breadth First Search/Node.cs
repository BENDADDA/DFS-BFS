using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_First_Search
{
    class Node
    {
       public int dest;
       public Node next;
        public Node(int dest, Node next)
        {
            this.dest = dest;
            this.next = null;
        }
    }
}
