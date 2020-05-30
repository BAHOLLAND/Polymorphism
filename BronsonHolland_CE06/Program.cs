using System;

namespace BronsonHolland_CE06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(
                    "1. Add Employee\n" +
                    "2. Remove Employee\n" +
                    "3. Display Payroll\n" +
                    "4. Exit\n" +
                    "Please select one of the options: ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "add employee":
                        {
                            Console.Clear();
                        }
                        break;
                    case "2":
                    case "remove employee":
                        {
                            Console.Clear();
                        }
                        break;
                    case "3":
                    case "display payroll":
                        {
                            Console.Clear();
                        }
                        break;
                    case "4":
                    case "exit":
                        {

                            return;
                        }
                }
            }
        }
    }
}