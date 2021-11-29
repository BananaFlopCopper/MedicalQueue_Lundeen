using System;

namespace MedicalQueue_Lundeen
{
    class Program
    {
        private static char[] _number = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            string Answers = "APLQ";
            string Input;
            ERQueue List = new ERQueue();
            bool Quit = false;

            while (Quit != true)
            {
                Input = " ";
                while (!Answers.Contains(Input.ToUpper()[0]))
                {
                    Console.WriteLine("(A)dd Patient\t(P)rocess Current Patient\t(L)ist All in Queue\t(Q)uit");
                    Input = Console.ReadLine();
                }
                Console.Clear();

                switch (Input[0])
                {
                    case 'A':
                        string PatientInput = "";
                        while (!GoodInput(PatientInput))
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter name and priority(Example: John/3, name John and priority 3)");
                            PatientInput = Console.ReadLine();
                        }
                        int Priority = int.Parse(PatientInput.Substring(PatientInput.IndexOf('/') + 1, 1));
                        PatientInput = PatientInput.Substring(0, PatientInput.IndexOf('/'));
                        
                        Patient newPatient = new Patient(PatientInput, Priority);
                        List.Add(newPatient);
                        break;
                    case 'P':
                        Console.WriteLine(List.Remove()); 
                        break;
                    case 'L':
                        Console.WriteLine(List.List());
                        break;
                    case 'Q':
                        Quit = true;
                        break;
                }
            }
        }

        public static bool GoodInput(string Input)
        {
            if (Input.Contains('/'))
            {
                Input = Input.Substring(Input.IndexOf('/') + 1);
                int Prioritycheck = Input.IndexOfAny(_number);
                if (Prioritycheck != -1 && Prioritycheck == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
