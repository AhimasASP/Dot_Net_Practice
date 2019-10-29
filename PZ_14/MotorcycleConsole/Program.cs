using System;

namespace MotorcycleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleConsole myConsoleMotorcycle = new MotorcycleConsole("Honda");
            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1000);
            myConsoleMotorcycle.Move(5000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;

            myConsoleMotorcycle = new MotorcycleConsole("Honda");
            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1000);
            myConsoleMotorcycle.Move(5000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;
        }
    }
}
