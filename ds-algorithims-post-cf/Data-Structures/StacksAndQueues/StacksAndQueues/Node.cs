using System;
namespace ds_algorithims_post_cf.DataStructures.StacksAndQueues.StacksAndQueues
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }
}
