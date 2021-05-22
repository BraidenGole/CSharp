using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Functions
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                this.Data = data;
                this.Prev = null;
                this.Next = null;
            }
        }

        /**     -- Method header comment
         *  Method          :   Push
         *  Description     :   This method is responsible for pushing the data
         *                      to the doubly linked list at the begining.
         *  Parameters      :   head, data
         *  Returns         :   None
         */
        public void Push(ref Node head, int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            newNode.Prev = null;

            if (head != null)
            {
                head.Prev = newNode;
            }
            head = newNode;
        }

        /**     -- Method header comment
         *  Method          :   InsertInBetween
         *  Description     :   This method is responsible for inserting in-beween
         *                      two nodes given a node.
         *  Parameters      :   node, data
         *  Returns         :   None
         */
        public void InsertInBetween(Node node, int data)
        {
            if (node == null)
            {
                return;
            }

            Node newNode = new Node(data);
            newNode.Next = node.Next;
            node.Next = newNode;
            newNode.Prev = node;

            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;
            }
        }

        /**     -- Method header comment
         *  Method          :   Append
         *  Description     :   This method is responsible for inserting the node at the end.
         *  Parameters      :   head, tail, data
         *  Returns         :   None
         */
        public void Append(ref Node head, ref Node tail, int data)
        {
            Node newNode = new Node(data);
            newNode.Prev = newNode.Next = null;

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }
            else
            {
                Node rootNode = head;
                Node followingNode = head.Next;

                while (followingNode != null)
                {   
                    rootNode = followingNode;
                    followingNode = followingNode.Next;
                }
                newNode.Prev = rootNode;
                newNode.Next = followingNode;
                rootNode.Next = newNode;

                if (followingNode == null)
                {
                    tail = newNode;
                }
                else
                {
                    followingNode.Prev = newNode;
                }
            }
        }

        /**     -- Method header comment
         *  Method          :   Delete
         *  Description     :   This method is responsible for deleting a node.
         *  Parameters      :   head, tail, number
         *  Returns         :   None
         */
        public void Delete(ref Node head, ref Node tail, int number)
        {
            Node headRef = null;
            headRef = head;

            while (headRef != null)
            {
                if (headRef.Data == number)
                {
                    if (headRef == head)
                    {
                        head = headRef.Next;
                        head.Prev = null;
                        return;
                    }

                    if (headRef.Next != null)
                    {
                        headRef.Prev.Next = headRef.Next;
                        return;
                    }

                    if (headRef == tail)
                    {
                        tail = headRef.Prev;
                        tail.Next = null;
                        return;
                    }
                }
                headRef = headRef.Next;
            }
        }

        /**     -- Method header comment
         *  Method          :   ShowList
         *  Description     :   This function will show the doubly linked list.
         *  Parameters      :   head
         *  Returns         :   None
         */
        public void ShowList(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }

        /**     -- Method header comment
         *  Method          :   ShowReversedList
         *  Description     :   This method is responsible for showing the list
         *                      from the tail end.
         *  Parameters      :   tail
         *  Returns         :   None
         */
        public void ShowReversedList(Node tail)
        {
            while (tail != null)
            {
                Console.WriteLine(tail.Data);
                tail = tail.Prev;
            }
        }
    }
}
