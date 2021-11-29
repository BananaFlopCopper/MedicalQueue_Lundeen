using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Lundeen
{
    class ERQueue
    {
        private static readonly int _lowestPriority = 5;
        private static Queue<Patient>[] _queueList = new Queue<Patient>[_lowestPriority];
        public int _count { get; private set; }
        public ERQueue()
        {
            for (int i = 0; i < _queueList.Length; i++)
            {
                _queueList[i] = new Queue<Patient>();
            }
        }

        public void Add(Patient patient)
        { 
            _queueList[patient.Priority-1].Enqueue(patient);
        }

        public string Remove()
        {
            for (int i = 0; i < _queueList.Length; i++)
            {
                Node<Patient> FirstInQueue = _queueList[i].Dequeue();
                if(FirstInQueue != null)
                {
                    return FirstInQueue.Data.ToString();
                }
            }
            return "No Patients in Queue";
        }

        public string List()
        { 
            string Contents = "";
            for (int i = 0; i < _queueList.Length; i++)
            {
                Contents += _queueList[i].ToString();
            }
            if(Contents == "")
            {
                return "There are no patients in the queue.";
            }
            return Contents;
        }
    }
}
