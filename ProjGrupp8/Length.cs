using System;

namespace ProjGrupp8
{
    public class Length
    {
        float cm, inch, m, feet, yard;
        public Length()
        {
            LengthMenu();
        }
        void LengthMenu()
        {
            bool inLoop = true;
            int userChoice;
            while (inLoop)
            {
                Console.Clear();
                Console.WriteLine("-- Convert between inch/cm/feet/yards/m --\n");

                Console.WriteLine("1. Inch");
                Console.WriteLine("2. cm");
                Console.WriteLine("3. Feet");
                Console.WriteLine("4. Yards");
                Console.WriteLine("5. m");
                Console.WriteLine("6. Return to main menu");

                Console.Write("~ ");
                if (Int32.TryParse(Console.ReadLine(), out userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Input in inches");
                            convertInches(Checkinput());
                            inLoop = false;
                            break;
                        case 2:
                            Console.WriteLine("Input in cm");
                            Console.Write("~ ");
                            convertCentimeter(float.Parse(Console.ReadLine()));
                            inLoop = false;
                            break;
                        case 3:
                            Console.WriteLine("Input in feet");
                            Console.Write("~ ");
                            convertFeet(float.Parse(Console.ReadLine()));
                            inLoop = false;
                            break;
                        case 4:
                            Console.WriteLine("Input in yards");
                            Console.Write("~ ");
                            convertYards(float.Parse(Console.ReadLine()));
                            inLoop = false;
                            break;
                        case 5:
                            Console.WriteLine("Input in meters");
                            Console.Write("~ ");
                            convertMeters(float.Parse(Console.ReadLine()));
                            inLoop = false;
                            break;
                        case 6:
                            inLoop = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Please select a number between [1-6]");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please select a number between [1-6]");
                }
            }
        }

        public void convertInches(float inch)
        {
            Console.Clear();

            cm = inch * 2.54f;
            feet = inch / 12f;
            yard = inch / 36f;
            m = inch / 39.37f;
            Console.WriteLine("--> {0} inches <--\n", inch);
            Console.WriteLine(" = {0} m", m);
            Console.WriteLine(" = {0} cm", cm);
            Console.WriteLine(" = {0} feet", feet);
            Console.WriteLine(" = {0} yards", yard);
        }
        public void convertCentimeter(float cm)
        {
            Console.Clear();

            inch = cm / 2.54f;
            feet = cm / 30.48f;
            yard = cm / 91.44f;
            m = cm / 10f;
            Console.WriteLine("--> {0} cm <--\n", cm);
            Console.WriteLine(" = {0} m", m);
            Console.WriteLine(" = {0} inches", inch);
            Console.WriteLine(" = {0} feet", feet);
            Console.WriteLine(" = {0} yards", yard);
        }
        public void convertFeet(float feet)
        {
            Console.Clear();

            inch = feet * 12f;
            yard = feet / 3f;
            m = feet / 3.281f;
            cm = feet * 30.48f;

            Console.WriteLine("--> {0} feet <--\n", feet);
            Console.WriteLine(" = {0} m", m);
            Console.WriteLine(" = {0} cm", cm);
            Console.WriteLine(" = {0} inches", inch);
            Console.WriteLine(" = {0} yards", yard);
        }
        public void convertYards(float yard)
        {
            Console.Clear();

            m = yard / 1.094f;
            cm = yard * 91.44f;
            inch = yard * 36f;
            feet = yard * 3f;

            Console.WriteLine("--> {0} yard <--\n", yard);
            Console.WriteLine(" = {0} m", m);
            Console.WriteLine(" = {0} cm", cm);
            Console.WriteLine(" = {0} inches", inch);
            Console.WriteLine(" = {0} feet", feet);
        }
        public void convertMeters(float m)
        {
            Console.Clear();

            cm = m * 100f;
            inch = m * 39.37f;
            feet = m * 3.281f;
            yard = m * 1.094f;

            Console.WriteLine("--> {0} m <--\n", m);
            Console.WriteLine(" = {0} cm", cm);
            Console.WriteLine(" = {0} inches", inch);
            Console.WriteLine(" = {0} feet", feet);
            Console.WriteLine(" = {0} yards", yard);
        }

        static float Checkinput()
        {
            float v = 0;
            bool validate = false;
            while (!validate)
            {
                Console.Write("~ ");
                validate = float.TryParse(Console.ReadLine(), out v);
                if (!validate) Console.WriteLine("Please try again");
            }
            return v;
        }
    }
}