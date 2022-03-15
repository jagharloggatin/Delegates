using System;

namespace Lambda1 // Note: actual namespace depends on the project name.
{
    public class Program
    {

        public enum Vehicles
        {
            Car, Truck, MC, Biscycle
        }

        static IEnumerable<Vehicles>GetVehicles()
        {
            for (int i = (int)Vehicles.Car; i < (int)Vehicles.Biscycle + 1; i++)
            {
                yield return (Vehicles)i;
            }
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            List<Vehicles> carList = new List<Vehicles>();

            for (int i = 0; i < 100; i++)   
            carList.Add((Vehicles)rnd.Next(0, 4));

            int counterCar = 0;
            int counterTruck = 0;
            int counterMc = 0;
            int counterBiscycle = 0;


            //Min lösning
            carList.ForEach(vehicle =>
            {
                if (vehicle == Vehicles.Car)
                    counterCar++;

                if (vehicle == Vehicles.Truck)
                    counterTruck++;

                if (vehicle == Vehicles.MC)
                    counterMc++;

                if (vehicle == Vehicles.Biscycle)
                    counterBiscycle++;
            });
            Console.WriteLine($"Cars: {counterCar} Trucks: {counterTruck} MC: {counterMc} Biscycle: {counterBiscycle}\n");
            
            //Annan lösning
            for (int i = (int)Vehicles.Car; i < (int)Vehicles.Biscycle + 1; i++)
            {
                int _counter = 0;
                int search = i;

                carList.ForEach(car =>
                {
                    if (car == (Vehicles)search)
                        _counter++;
                });
                Console.WriteLine($"{(Vehicles)search,-10} {_counter}");
            }
        }
    }
}
//1. En enumtyp av fordon
//2. En lista av slumpmässiga fordon
//3. i C finns det en metod som heter foreach .foreach
//4. med hjälp av c vill jag att ni 
//- skriver ut antal av varje fordon
//- använd lambda och capture variabel (är den variabeln fångar)

//List <int> myList = new List<int> {1,2,3,4,5,6,7};

//int searchVar = 3;
//int counterVar = 0;

//myList.ForEach(n => 
//{
//    if (n == searchVar)
//        counterVar++;
//});
//Console.WriteLine($"The list has {counterVar} elements of {searchVar}");


