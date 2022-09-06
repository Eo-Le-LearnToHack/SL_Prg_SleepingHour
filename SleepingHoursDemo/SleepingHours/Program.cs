using System;

namespace SleepingHours
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> sleepingHours = new List<string>
            {
                "14–17 timer",  //Nyfødte (0-3 måneder):
                "12–15 timer",  //Spædbørn(4 - 11 måneder): 
                "11–14 timer",  //Småbørn(1 - 2 år): 
                "10–13 timer",  //Førskolebørn(3 - 5 år): 
                "9–11 timer",   //Skolebørn(6 - 13 år): 
                "8–10 timer",   //Teenagere(14 - 17 år): 
                "7–9 timer",    //Unge voksne(18 - 25): 
                "7–9 timer",    //Voksne(26 – 64): 
                "7–8 timer"    //Ældre(65 år +): 
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("0\t: Nyfødte (0-3 måneder)\n" +
                    "1\t: Spædbørn(4 - 11 måneder)\n" +
                    "2\t: Småbørn(1 - 2 år)\n" +
                    "3\t: Førskolebørn(3 - 5 år)\n" +
                    "4\t: Skolebørn(6 - 13 år)\n" +
                    "5\t: Teenagere(14 - 17 år)\n" +
                    "6\t: Unge voksne(18 - 25)\n" +
                    "7\t: Voksne(26 – 64)\n" +
                    "8\t: Ældre(65 år +)\n" +
                    "Esc\t: Lukke programmet\n");

                bool bol = false;
                do
                {
                    Console.WriteLine();
                    Console.Write("Indtast det tal som svarer til personens alder (Esc for at lukke programmet) :");

                    ConsoleKeyInfo csi = new();
                    csi = Console.ReadKey(true);
                    if (csi.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine($"\nProgrammet lukker ned.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        try
                        {
                            string aldersIntervalString = Convert.ToString(csi.KeyChar);
                            int aldersIntervalInt = Convert.ToInt32(aldersIntervalString);
                            Console.WriteLine($"\n\nDet anbefales, at personen sover mellem {sleepingHours[aldersIntervalInt]}.");
                            Console.WriteLine($"\nTryk på en vilkårlig tast for at prøve igen.");
                            Console.ReadLine();
                            bol = true;
                        }
                        catch (Exception)
                        {
                            bol = false;
                        }
                    }
                } while (!bol); 
            }
        }
    }
}
