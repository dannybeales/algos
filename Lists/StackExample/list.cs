using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTesting
{
    class List<T> //<T> Templates a class
    {
        // 
        public class Node
        {
            public T Data;
            public Node Next;
            
        }

        private Node head;
        private int count = 0;

        public T Head { get { return head.Data;  } }//allow stack.cs to access the data in head

        public int Count
        {
            get { return count; }
        }

        public List()
        {
            head = null;
        }

        ~List()
        {
            
        }

        public void InsertBeginning(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            count++;
        }

        public T RemoveBeginning()
        {

            T ret = default(T);

            if (head != null)
            {
                ret = head.Data;
                if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                    head = head.Next;
                }
            }
            count--;
            return ret;
        }

        public void InsertAfter(int count, T data)
        {
            Node newNode = new Node { Data = data };
            Node current = head;
            int counter = 0;
            while (current != null)
            {

                if(counter == count || current.Next == null)
                {
                    if (current.Next != null)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        counter++;

                        break;                        
                    }
                }
                current = current.Next;
                
            }
        }

        public T RemoveAfter(int count)
        {
            T ret = default(T);

            Node current = head;
            int counter = 0;

            while (current != null)
            {

                if (current.Next != null)
                {
                    ret = current.Next.Data;
                    current.Next = current.Next.Next;
                    counter--;   
                }

                break;
            }

                current = current.Next;
                      
                return ret;
        }
    }
}
