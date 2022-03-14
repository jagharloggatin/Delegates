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
            Func<int, string> CompanyResponse = AlarmResponseCompany1;

            for (int i = 0; i < 4; i++)
            {
                string response = CompanyResponse(i);
                Console.WriteLine(response);

            }

            //Utbytt med for-loop och Func

            //AlarmResponse CompanyResponse = new AlarmResponse(AlarmResponseCompany1);
            //string response = CompanyResponse.Invoke(3);
            //Console.WriteLine(response);
        }
        static string AlarmResponseCompany1(int priority) =>
            (priority) switch
            {
                1 => "Comapny1 Critical Level",
                2 => "Comapny1 Moderate Level",
                3 => "Comapny1 Easy Level",
                _ => "Comapny1 Unknown Level"
            };

    }
}
