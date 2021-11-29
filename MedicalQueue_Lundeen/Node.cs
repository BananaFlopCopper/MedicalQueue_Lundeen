using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Lundeen
{
    class Node<T>
    {
        public Node<T> Next;
        public readonly T Data;
        public Node(T data)
        {
            Data = data;
        }
    }
}
