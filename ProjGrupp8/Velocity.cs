using System;

namespace ProjGrupp8
{
    public class Velocity
    {
        public double s = 0, t = 0, v = 0;

        public Velocity()
        {
            Console.Clear();
            Console.WriteLine("-- Velocity --\n");
            /* En meny för Velocity */
            bool inLoop = true;
            float userInput;
            showStats();

            while (inLoop)
            {
                // Presenterar alla val användaren har
                Console.WriteLine("1. Input distance kilometers [km]");
                Console.WriteLine("2. Input time seconds [s]");
                Console.WriteLine("3. Return to main menu");
                Console.Write("~ ");
                if (float.TryParse(Console.ReadLine(), out userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.Write("s = ");
                            s = Checkinput();
                            showStats();
                            break;
                        case 2:
                            Console.Write("t = ");
                            t = Checkinput();
                            showStats();
                            break;
                        case 3:
                            inLoop = false;
                            Console.Clear();
                            break;
                        default:
                            showStats();
                            Console.WriteLine("Please select a number between [1-3]");
                            break;
                    }
                }
                else
                {
                    showStats();
                    Console.WriteLine("Please select a number between [1-3]");
                }
            }
        }
        static double Checkinput()
        {
            double v = 0;
            bool validate = false;
            while (!validate)
            {
                validate = double.TryParse(Console.ReadLine(), out v);
                if (!validate) Console.Write("Please try again \n ~ ");
            }
            return v;
        }

        void showStats()
        {
            Console.Clear();
            v = (s * 1000) / t;
            Console.Write(" >> |  Velocity (v) : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0}",v);
            Console.ResetColor();
            Console.Write(" m/s - {2} km/s |  Distance (s) : {0} km |  Time (t)  :  {1} seconds | << \n", s, t, v*3.6d);
        }
    }
}