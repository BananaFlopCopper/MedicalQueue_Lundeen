using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Lundeen
{
    class Queue<T>
    {
        // Linked List with a Tail, to make Enqueue more efficient.
        private Node<T> _head;
        private Node<T> _tail;
        public void Enqueue(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            if (_head != null)
            {
                _tail.Next = newNode;
                _tail = newNode;
            } else
            {
                _head = newNode;
                _tail = newNode;
            }    
        }

        public Node<T> Dequeue()
        {
            if(_head != null)
            {
                Node<T> Temp = _head;
                _head = _head.Next;
                return Temp;
            }
            return null;
        }

        public override string ToString()
        {
            Node<T> Current = _head;
            string QueueList = "";
            while(Current != null) {
                QueueList += Current.Data.ToString() + "\n";
                Current = Current.Next;
            }
            // Can be Empty
            return QueueList;
        }
    }
}
