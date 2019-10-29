using System;

namespace MotorcycleConsole
{
    

   sealed public class MotorcycleConsole
    {
        public string Model { get; set; }
        public static int Odometer { get; set; }
        public int DailyDistance { get; set; }

        public MotorcycleConsole(string name)
        {
            Model = name;
        }

        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine("Engine started");
        }

        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"<ove to {distance} km.");
        }

        public void StopEngine()
        {
            Odometer += DailyDistance;
            Console.WriteLine("Engine stopped");
            Console.WriteLine($"Total distance is {Odometer}");
        }

        public void GoToService(int totalDistance)
        {

        }
    }
}