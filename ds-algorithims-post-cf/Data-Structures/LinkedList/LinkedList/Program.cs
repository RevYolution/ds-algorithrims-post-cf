using System;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void MainLinkedList(string[] args)
        {
        }

        public Node Current { get; set; }
        public Node Head { get; set; }

        /// <summary>
        /// Adds a new node to the LL at the head position.
        /// </summary>
        /// <param name="value">The value that will be assigned to the new head node</param>
        public void Insert(int value)
        {
            //Instanciates a now node instance with the given value
            Node node = new Node(value);

            //Sets the value of the new node with the value being brought in
            node.Value = value;

            //Sets the new nodes next value to the current head
            node.Next = Head;

            //Sets the new node as the head of the LL
            Head = node;
        }

        /// <summary>
        /// Goes through the LL to check if a given value is present in the LL.
        /// </summary>
        /// <param name="value">Value that is being searched for</param>
        /// <returns>Returns a bool of positive if value present and negitive if not.</returns>
        public bool Includes(int value)
        {
            //Set what is being looked at to the head
            Current = Head;

            //Traveses through the list until the Current is equal to null
            while (Current!=null)
            {
            //If the value of the current node is equal to the value given returns true
            if (Current.Value == value)
            {
                return true;
            }
            //If the value of the current node is not equal to the value given set Current equal to the next node.
            else
            {
                Current = Current.Next;
            }
            }

            //If the list does not contain the value given return false.
            return false;
        }

        public string Print()
        {
            StringBuilder builder = new StringBuilder();

            Current = Head;

            while (Current!=null)
            {
                builder.Append(Current.Value);
                if (Current.Next!=null)
                {
                    builder.Append("=>");
                }
                Current = Current.Next;
            }

            return builder.ToString();
        }
    }
}
