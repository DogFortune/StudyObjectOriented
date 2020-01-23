using System;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new JetEngine();
            Handle handle = new QuickHandle();
            Brake brake = new AntilockBrake();

            Car car = new Car(engine, handle, brake);

            car.Start();
            car.TurnLeft();
            car.Stop();

            Console.ReadKey();
        }
    }
}
