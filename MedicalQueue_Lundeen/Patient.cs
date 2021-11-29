using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Lundeen
{
    class Patient
    {
        public readonly string Name;
        public readonly int Priority;
        public Patient(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
        public override string ToString()
        {
            return Name + "\t" + Priority;
        }
    }
}
