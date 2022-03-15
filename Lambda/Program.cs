using System;

namespace DelegateExample1
{
    class Program
    {
        //Utbytt med Func
        //delegate string AlarmResponse(int priority);
        static void Main(string[] args)
        {
            //int inparameter, string ut
            //skrivit som lambda expression istället, metoden används bara just här men kan sparas och användas mer
            //den vet att priority är en in för att Func<int, string> den vet att inparametern är int

            Func<int, string> CompanyResponse = priority => 
            priority switch
                {
                    1 => "Comapny1 Critical Level",
                    2 => "Comapny1 Moderate Level",
                    3 => "Comapny1 Easy Level",
                    _ => "Comapny1 Unknown Level"
                };

            Console.WriteLine(CompanyResponse(1));
                


        }
    }
}
