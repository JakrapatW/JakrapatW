using System;

namespace ProjGrupp8
{
    public class Areas
    {
        /* double area, volume, rectangle, triangle, cirkle, cube, pyramid, sphere; */
        double[] areas = new double[6];
        public Areas()
        {
            MainMenu();
        }
        void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("-- Areas & Volumes --\n");
            /* En meny för Area och volym */
            bool inLoop = true;
            float userInput;

            while (inLoop)
            {
                // Presenterar alla val användaren har
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Cirkle & Sphere");
                Console.WriteLine("4. Cube");
                Console.WriteLine("5. Pyramid");
                Console.WriteLine("6. Return to main menu");
                Console.Write("~ ");
                if (float.TryParse(Console.ReadLine(), out userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            areas[0] = Rectangle();
                            askContinue();
                            break;
                        case 2:
                            Console.Clear();
                            areas[1] = Triangle();
                            askContinue();
                            break;
                        case 3:
                            Console.Clear();
                            Cirkle();
                            askContinue();
                            break;
                        case 4:
                            Console.Clear();
                            Cube();
                            askContinue();
                            break;
                        case 5:
                            Console.Clear();
                            Pyramid();
                            askContinue();
                            break;
                        case 6:
                            inLoop = false;
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please select a number between [1-6]");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please select a number between [1-6]");
                }
            }
        }
        //float l, float h, float w
        static double Rectangle()
        {
            Console.WriteLine("-- Measurements in meters (m) --\n-- Rectangle --\n");
            double a, v, l, h, w;
            l = Checkinput("Length l");
            h = Checkinput("Height h");
            w = Checkinput("Width w");
            a = 2d * (l) + 2d * (h) + 2d * (w);
            v = l * h * w;
            Console.WriteLine("--- > Area = {0} m2", Math.Round(a, 3));
            Console.WriteLine("--- > Volume = {0} m3", Math.Round(v, 3));
            return a;
        }
        static double Triangle()
        {
            Console.WriteLine("-- Measurements are in meters (m) --\n-- Triangle --\n");
            double a, b, h;
            b = Checkinput("Base b");
            h = Checkinput("Height h");
            a = (h * b) / 2d;
            Console.WriteLine("--- > Area = {0} m2", Math.Round(a, 3));
            return a;
        }
        static double Cirkle()
        {
            Console.WriteLine("-- Measurements are in meters (m) --\n-- Cirkle and Spheres --\n");
            double a, v, r;
            r = (Checkinput("Radius r"));
            a = (double)(Math.PI) * r * r;
            v = (double)(4 / 3) * (double)Math.PI * r * r * r;
            Console.WriteLine("--- > Area   = {0} m2", Math.Round(a, 3));
            Console.WriteLine("--- > Volume = {0} m3", Math.Round(v, 3));
            return a;
        }
        static double Cube()
        {
            Console.WriteLine("-- Measurements in meters (m) --\n-- Cube --\n");
            double a, v, l, h, w;
            l = Checkinput("Length l");
            h = Checkinput("Height h");
            w = Checkinput("Width w");
            a = 2d * (l) + 2d * (h) + 2d * (w);
            v = l * h * w;
            Console.WriteLine("--- > Area = {0} m2", Math.Round(a, 3));
            Console.WriteLine("--- > Volume = {0} m3", Math.Round(v, 3));
            return a;
        }
        static double Pyramid()
        {
            Console.WriteLine("-- Measurements in meters (m) --\n-- Pyramid --\n");
            double a, v, l, h, w;
            l = Checkinput("Length l");
            h = Checkinput("Height h");
            w = Checkinput("Width w");

            a = (l * w) + (l * Math.Sqrt(Math.Pow(w / 2, 2) + Math.Pow(h, 2))) + (w * Math.Sqrt(Math.Pow(l / 2, 2) + Math.Pow(h, 2)));


            v = (l * h * w)/3d;
            Console.WriteLine("--- > Area = {0} m2", Math.Round(a, 3));
            Console.WriteLine("--- > Volume = {0} m3", Math.Round(v, 3));
            return a;
        }
        void askContinue()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.WriteLine("\n");
        }
        static double Checkinput(string a) // En metod som kollar av om användaren har skrivit in ett nummer eller float
        {
            double v = 0;
            bool validate = false;
            while (!validate)
            {
                Console.Write("{0} = ", a);
                validate = double.TryParse(Console.ReadLine(), out v);
                if (!validate) Console.WriteLine("Please try again");
            }
            return v;
        }
    }
}