using System;

namespace CovidSafetyHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyworkers = {"doctor", "nurse", "midwife", "paramedic", "delievery driver", "police officer", "retail worker"};
            string[] generalterm = {"nhs worker", "health and social care worker", "retail worker", "utility worker", "armed forces", "public transport"};
            bool inside = true;
            bool keyworker = false;
            string response;
            string jobrole;

            Console.WriteLine("Hey how are you doing! I'm here to advise you if it is best for you to be outside or inside during this lockdown period.");
            do
            {
                Console.WriteLine("Are you currently inside or outside ?");
                response = Console.ReadLine().ToLower();
            }

            while (response != "inside" && response != "outside");

            if (response == "inside")
            {
                inside = true;
            }
            else if (response == "outside")
            {
                inside = false;
            }

            if (inside == false)
            {
                Console.WriteLine("What is your job role?");
                jobrole = Console.ReadLine().ToLower();

                for (int i = 0; i < keyworkers.Length; i++)
                {
                    if (keyworkers[i].Contains(jobrole))
                    {
                        keyworker = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine("You don't seem to be a key worker, what is the general term for your job role?");
                jobrole = Console.ReadLine().ToLower();
                for (int i = 0; i < generalterm.Length; i++)
                {
                    if (generalterm[i].Contains(jobrole))
                    {
                        keyworker = true;
                    }
                    else
                    {
                        keyworker = false;
                        i++;
                    }
                }

                if(inside == false && keyworker == false)
                {
                    Console.WriteLine("work from home");
                }
                else if (inside = false && keyworker == true)
                {
                    Console.WriteLine("stay safe");
                }
            }
            else
            {
                Console.WriteLine("Take care, only leave when necessary.");
                Console.WriteLine("stay safe.");
            }
            Console.ReadLine();
        }
    }
}
