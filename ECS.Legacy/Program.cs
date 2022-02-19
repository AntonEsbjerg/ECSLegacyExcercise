using System;
using ECS.Legacy.Writer;

namespace ECS.Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter writer = new ConsoleWriter();

            writer.Write("Testing ECS.Legacy");

            // Make an ECS with a threshold of 23
            var control = new ECSClass(23);

            for (int i = 1; i <= 15; i++)
            {


                writer.Write($"Running regulation number {i}");

                control.Regulate();
            }


        }
    }
}
