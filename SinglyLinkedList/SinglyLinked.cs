using System;

namespace SinglyLinkedList
{
    public class SinglyLinked
    {
        public class Node
        {
            private int data;
            private Node next;

            public int Data 
            { 
                get { return data; }
                set { data = value; }
            }

            public Node Next 
            { 
                get { return next; }
                set { next = value; }
            }

            public Node()
            {
                ; ;
            }

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        /**     -- Method header comment
         *  Method          :   InsertAtHead
         *  Description     :   This method will insert data at the head of the list.
         *  Parameters      :   head, newData
         *  Returns         :   head
         */
        public Node InsertAtHead(Node head, int newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = null;

            newNode.Next = head;
            head = newNode;
            return head;
        }

        /**     -- Method header comment
         *  Method          :   InsertInBetween
         *  Description     :   This method will insert a node in-between two nodes.
         *  Parameters      :   aNode, newData
         *  Returns         :   aNode
         */
        public Node InsertInBetween(Node aNode, int newData)
        {
            if (aNode == null)
            {
                return null;
            }

            Node newNode = new Node(newData);
            newNode.Next = aNode.Next;
            aNode.Next = newNode;
            return aNode;
        }

        /**     -- Method header comment
         *  Method          :   InsertNode
         *  Description     :   This method is responsible for inserting a node insto
         *                      the singly linked list.
         *  Parameters      :   head, newData
         *  Returns         :   head
         */
        public Node InsertNode(Node head, int newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = null;
            
            if (head == null)
            {
                head = newNode;
                return head;
            } 
            else
            {
                Node headReference = null;

                headReference = head;
                while (headReference.Next != null)
                {
                    headReference = headReference.Next;
                }
                headReference.Next = newNode;
            }
            return head;
        }

        /**     -- Method header comment
         *  Method          :   UpdateNode
         *  Description     :   This method will update the data of a specific
         *                      node of choice.
         *  Parameters      :   head, nodeToUpdate, newData
         *  Returns         :   head
         */
        public Node UpdateNode(Node head, Node nodeToUpdate, int newData)
        {
            if (head == null || nodeToUpdate == null)
            {
                return null;
            }

            while (head != null)
            {
                if (head.Data == nodeToUpdate.Data)
                {
                    head.Data = newData;
                    return head;
                }
                head = head.Next;
            }
            return null;
        }

        /**     -- Method header comment
         *  Method          :   DeleteFromHead
         *  Description     :   This method will delete a node from the head of the list.
         *  Parameters      :   head
         *  Returns         :   None
         */
        public Node DeleteFromHead(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Node delete = head;
            head = head.Next;
            return head;
        }

        /**     -- Method header comment
         *  Method          :   DeleteRangeOfNodes
         *  Description     :   This method will delete a range of nodes example
         *                      from the head to the next next next entry.
         *  Parameters      :   start, endingNode
         *  Returns         :   head
         */
        public Node DeleteRangeOfNodes(Node start, Node endingNode)
        {
            if (start == null)
            {
                return null;
            }
            if (endingNode == null)
            {
                return null;
            }

            while (start != null)
            {
                if (start.Data == endingNode.Data)
                {
                    Node delete = start;
                    start = start.Next;
                    return start;
                }
                start = start.Next;
            }
            return null;
        }
        
        /**     -- Method header comment
         *  Method          :   ShowList
         *  Description     :   This method will show the contents within the linked list.
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

    }
}
