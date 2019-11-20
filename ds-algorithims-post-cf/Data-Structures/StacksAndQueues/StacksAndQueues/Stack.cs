using System;
namespace ds_algorithims_post_cf.DataStructures.StacksAndQueues.StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node; 
        }

        public int Pop()
        {
            int popValue = Top.Value;
            Top = Top.Next;
            return popValue;
        }

        public int Peek()
        {
            int peekValue = Top.Value;
            return peekValue;
        }

        public bool IsEmpty()
        {
            if(Top != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
