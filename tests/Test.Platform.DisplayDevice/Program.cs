using System;

namespace Test.Platform.DisplayDevice
{
    class Program
    {
        enum Mode
        {
            Bounds,
            Modes,
            Quit,
        };

        static void Main(string[] args)
        {
            var indices = new OpenTK.DisplayIndex[]
            {
                OpenTK.DisplayIndex.Primary,

                OpenTK.DisplayIndex.First,
                OpenTK.DisplayIndex.Second,
                OpenTK.DisplayIndex.Third,
                OpenTK.DisplayIndex.Fourth,
                OpenTK.DisplayIndex.Fifth,
                OpenTK.DisplayIndex.Sixth,
            };


            var mode = Mode.Bounds;

            while (mode != Mode.Quit)
            {
                Console.Clear();

                foreach (var index in indices)
                {
                    Console.WriteLine("================================================================================");
                    Console.WriteLine(index);

                    var display = OpenTK.DisplayDevice.GetDisplay(index);
                    if (display != null)
                    {
                        Console.WriteLine(display);
                        Console.WriteLine("Primary: {0}", display.IsPrimary);

                        if (mode == Mode.Bounds)
                        {
                            Console.WriteLine("Current Resolution: {0}", display.CurrentResolution);
                        }
                        else
                        {
                            foreach(var res in display.AvailableResolutions)
                            {
                                Console.WriteLine(res);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("GetDisplay returned null");
                    }
                }

                Console.WriteLine("Press A to list all availible modes");
                Console.WriteLine("Press B to list all bounds");
                Console.WriteLine("Press Q to quit");
                Console.WriteLine("Press any other key to update");

                while (!Console.KeyAvailable) { }

                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        mode = Mode.Modes;
                        break;
                    case ConsoleKey.B:
                        mode = Mode.Bounds;
                        break;
                    case ConsoleKey.Q:
                        mode = Mode.Quit;
                        break;
                }
            }
        }
    }
}
