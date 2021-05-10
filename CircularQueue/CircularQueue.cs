using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class CircularQueue
    {
        private int rear;
        private int front;
        public int SizeOfQueue { get; set; }

        private int[] queueArray;

        public int Rear
        {
            get { return rear; }
            set { rear = value; }
        }

        public int Front
        {
            get { return front; }
            set { front = value; }
        }

        // Empty constructor.
        public CircularQueue()
        {
            ; ;
        }

        public CircularQueue(int sizeOfQueue)
        {
            this.Front = -1;
            this.Rear = -1;
            this.SizeOfQueue = sizeOfQueue;
            queueArray = new int[sizeOfQueue];
        }

        /**     -- Method header comment
         *  Method          :   EnQueue
         *  Description     :   This method is responsible for adding an item
         *                      to the circular queue.
         *  Parameters      :   queue, data
         *  Returns         :   None
         */
        public void EnQueue(int[] queue, int data)
        {
            // Check to see if the queue is filled.
            if (IsFull() == true)
            {
                return;
            }
            
            if (IsEmpty() == true)
            {
                Front += 1;
            }
            Rear = (Rear + 1) % SizeOfQueue;
            queue[Rear] = data;
        }

        /**     -- Method header comment
         *  Method          :   DeQueue
         *  Description     :   This metbod is responsible for removing an item
         *                      from the circular queue.
         *  Parameters      :   queue
         *  Returns         :   delete
         */
        public void DeQueue(int[] queue)
        {
            if ((IsEmpty()) == true)
            {
                return;
            }
            int delete = queue[Front];
            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;
            }
            else
            {
                Front = (Front + 1) % SizeOfQueue;
            }
        }

        /**     -- Method header comment
         *  Method          :   IsEmpty
         *  Description     :   This method will check the circular queue to see if
         *                      it is empty.
         *  Parameters      :   None
         *  Returns         :   true, false
         */
        public bool IsEmpty()
        {   
            if (Front == -1)
            {
                return true;
            }
            return false;
        }

        /**     -- Method header comment
         *  Method          :   Peek
         *  Description     :   This method will return the current peek of the circular queue.
         *  Parameters      :   queue
         *  Returns         :   queue[Front]
         */
        public int Peek(int[] queue)
        {
            if ((IsEmpty()) == true)
            {
                return -1;
            }
            return queue[Front];
        }

        /**     -- Method header comment
         *  Method          :   IsFull
         *  Description     :   This method will check the circular queue to see if it is filled.
         *  Parameters      :   None
         *  Returns         :   true, false;
         */
        public bool IsFull()
        {
            int check = (Rear + 1) % SizeOfQueue;
            if (check == Front)
            {
                return true;
            }
            return false;
        }

        /**     -- Method header comment
         *  Method          :   ShowQueue
         *  Description     :   This method is responsible for displaying the circular queue.
         *  Parameters      :   queue
         *  Returns         :   None
         */
        public void ShowQueue(int[] queue)
        {
            if (Rear >= Front)
            {
                int index = Front;
                while (index <= Rear)
                {
                    Console.WriteLine(queue[index]);
                    index = (index + 1) % SizeOfQueue;
                }
            }
        }
    }
}
