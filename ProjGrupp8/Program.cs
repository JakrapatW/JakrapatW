using System;
using System.Threading.Tasks;

namespace ProjGrupp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*Clear konsolen, gör rent konsol meny*/
            Menu();
        }
        static void Menu() //Meny metod
        {
            bool inLoop = true;
            while (inLoop) /* whileloop för huvudmenyerna */
            {
                Console.ResetColor();
                /* Presenterar val för användaren nummer mellan 1-6 */
                Console.WriteLine("Please choose between these options below [1-6]\n");
                Console.WriteLine("1. Convert between Fahrenheit/Celsius/Kelvin");
                Console.WriteLine("2. Convert between inch/cm/foot/yards/m");
                Console.WriteLine("3. Calculate velocity");
                Console.WriteLine("4. Calculate Ohm's Law [U,R,I]");
                Console.WriteLine("5. Calculate areas");
                Console.WriteLine("6. Exit");

                /* User Input */

                int userChoice;
                Console.Write("~ ");
                if (Int32.TryParse(Console.ReadLine(), out userChoice)) /* Låt användaren skriva in -> Int32 för att se om det är ett nummer */
                {
                    /* Switch sats är smidigare än if sats vid flera val */
                    switch (userChoice)
                    {
                        case 1:
                            Temperature Temp = new Temperature();
                            break;
                        case 2:
                            Length convertLength = new Length();
                            break;
                        case 3:
                            Velocity vel = new Velocity();
                            break;
                        case 4:
                            Ohm Ohm = new Ohm();
                            break;
                        case 5:
                            Areas area = new Areas();
                            break;
                        case 6:
                            inLoop = false;
                            Console.Clear();
                            Console.WriteLine("Thanks and see you again!!");
                            break;
                        default: // Om inget av passande tal skrivs in, prova igen
                            Console.Clear();
                            Console.WriteLine("----- > Not an valid option < -----\n");
                            break;
                    }
                }
                else // Om användaren inte skriver in ett tal
                {
                    Console.Clear();
                    Console.WriteLine("Not an valid input~!, please try again :)\n");
                }
            }
        }
    }
}
