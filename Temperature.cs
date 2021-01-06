using System;
namespace ProjGrupp8
{
    public class Temperature
    {
        public Temperature()
        {
            Console.Clear();
            bool inLoop = true;
            int userChoice;
            float F = 0, C = 0, K = 0; // Definerar grader float
            while (inLoop)
            {
                Console.WriteLine("-- Convert between Fahrenheit/Celsius/Kelvin --\n");
                Console.WriteLine("1. Fahrenheit");
                Console.WriteLine("2. Celsius");
                Console.WriteLine("3. Kelvin");
                Console.WriteLine("4. Return to main menu");
                Console.Write("~ ");
                if (Int32.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.Clear();
                    switch (userChoice)
                    {
                        case 1:
                            F = Checkinput("Fahrenheit F");
                            C = ((F - 32f) * 5f / 9f);
                            K = C + 273.15f;

                            Console.WriteLine("{0} F", F);
                            Console.WriteLine("{0} C", C);
                            Console.WriteLine("{0} K", K);
                            askContinue();
                            break;
                        case 2:
                            C = Checkinput("Celsius C");
                            F = (C * (9f / 5f)) + 32f;
                            K = C + 273.15f;

                            Console.WriteLine("{0} F", F);
                            Console.WriteLine("{0} C", C);
                            Console.WriteLine("{0} K", K);
                            askContinue();
                            break;
                        case 3:
                            K = Checkinput("Kelvin K");
                            F = ((K - 273.15f) * (9f / 5f) + 32f);
                            C = ((K - 273.15f));

                            Console.WriteLine("{0} F", F);
                            Console.WriteLine("{0} C", C);
                            Console.WriteLine("{0} K", K);
                            askContinue();
                            break;
                        case 4:
                            inLoop = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("-- Invalid Input --\n");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("-- Invalid Input --\n");
                }
            }
        }
        static float Checkinput(string temp) // En metod som kollar av om användaren har skrivit in ett nummer eller float
        {
            float v = 0;
            bool validate = false;
            while (!validate)
            {
                Console.Write("{0} = ", temp);
                validate = float.TryParse(Console.ReadLine(), out v);
                if (!validate) Console.WriteLine("Please try again");
            }
            return v;
        }
        void askContinue()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.WriteLine("\n");
            Console.Clear();
        }

    }
}