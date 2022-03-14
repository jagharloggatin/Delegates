using System;

namespace DelegateExample1Multicast
{
    class Program
    {
        delegate void AlarmResponse(int priority);
        static void Main(string[] args)
        {
            AlarmResponse CompanyResponse = AlarmResponseCompany1;

            CompanyResponse += AlarmResponseCompany2;
            CompanyResponse += AlarmResponseCompany3;

            CompanyResponse(3);
            Console.WriteLine();
            CompanyResponse -= AlarmResponseCompany2;
            CompanyResponse(1);

        }
        static void AlarmResponseCompany1(int priority)
        {
            Console.WriteLine(theResponse("Company1", priority));
        }
        static void AlarmResponseCompany2(int priority)
        {
            Console.WriteLine(theResponse("Company2", priority));
        }
        static void AlarmResponseCompany3(int priority)
        {
            Console.WriteLine(theResponse("Company3", priority));
        }
        static string theResponse(string company, int priority) =>
            (priority) switch
    {
        1 => $"{company} Critical Level",
        2 => $"{company} Moderate Level",
        3 => $"{company} Easy Level",
        _ => $"{company} Unknown Level"
    };

    }


}
