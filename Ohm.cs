using System;

namespace ProjGrupp8
{
    public class Ohm
    {
        public Ohm()
        {
            Console.Clear();
            Console.WriteLine("==== Ohm's Law ====\n");
            int userChoice;
            float ohm = 0, volt = 0, amps = 0; // Definerar värden
            bool inLoop = true;
            while (inLoop) // En loop för sub-meny
            {
                Console.WriteLine("Voltage (U) : {0} V", volt);
                Console.WriteLine("Ohm (R) : {0}", ohm);
                Console.WriteLine("Amps (A) : {0} I\n\n", amps);

                Console.WriteLine("1. Calculate U");
                Console.WriteLine("2. Calculate R");
                Console.WriteLine("3. Calculate I");
                Console.WriteLine("4. Return to main menu");
                Console.Write("\n ~ ");


                if (Int32.TryParse(Console.ReadLine(), out userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            ohm = Checkinput("R"); // Kallar CheckInput för TryParse
                            amps = Checkinput("I");
                            volt = ohm * amps;
                            break;
                        case 2:
                            volt = Checkinput("U");
                            amps = Checkinput("I");
                            ohm = volt / amps;
                            break;
                        case 3:
                            volt = Checkinput("U");
                            ohm = Checkinput("R");
                            amps = volt / ohm;
                            break;
                        case 4:
                            inLoop = false;
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Input, please try again\n");
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
                if (!validate) Console.Write("Please try again \n");
            }
            return v;
        }
    }
}