using System;
using System.Collections.Generic;

namespace Alg_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Service> cars = new List<Service>();

            for (int i = 0; i < 50; i++)
            {
                DateTime date = Generator.LastDateGenerator();
                cars.Add(new Service()
                {
                    num = Generator.NumGenerator(),
                    car = Generator.CarGenerator(),
                    owner = Generator.OwnerGenerator(),
                    lastDate = date,
                    endDate = Generator.EndDateGenerator(date)
                });
            }
            bool exit = false;
            while (!exit)
            {
                SwapColors();
                Console.WriteLine("Customers\n");
                SwapColors();
                foreach (Service aService in cars)
                {
                        Console.WriteLine(aService);
                }
                SwapColors();
                Console.WriteLine("\nActions");
                SwapColors();
                Console.Write("\n");
                Console.WriteLine("1. Show Lada owners\n" +
                    "2. Sort");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            
                            List<Service> list = new List<Service>();
                            bool check = false;
                            foreach (Service aService in cars)
                            {
                                if (aService.car.Equals("Lada"))
                                {
                                    list.Add(aService);
                                    check = true;
                                }
                            }
                            foreach (Service aService in list)
                                Console.WriteLine(aService);
                            if (!check)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("None");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            list.Sort(delegate (Service x, Service y)
                            {
                                if (x.num == null && y.num == null) return 0;
                                else if (x.num == null) return -1;
                                else if (y.num == null) return 1;
                                else return x.num.CompareTo(y.num);
                            });

                            SwapColors();
                            Console.WriteLine("Search:");

                            foreach (Service aService in list)
                                Console.WriteLine(aService);

                            SwapColors();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            List<Service> list = new List<Service>();
                            int size = 0;
                            bool check = true;
                            foreach (Service aService in cars)
                            {                    
                                size++;
                            }
                            DateTime dateLast;
                            DateTime dateEnd;
                            foreach (Service aService in cars)
                            {
                                dateLast = aService.lastDate;
                                dateEnd = aService.endDate;
                                
                                if (dateLast.Month + 1 == dateEnd.Month && dateLast.Year == dateEnd.Year)
                                {
                                    list.Add(aService);
                                }
                                    
                            }
                            
                            list.Sort(delegate (Service x, Service y)
                            {
                                if (x.lastDate == null && y.lastDate == null) return 0;
                                else if (x.lastDate == null) return -1;
                                else if (y.lastDate == null) return 1;
                                else return x.lastDate.CompareTo(y.lastDate);
                            });

                            SwapColors();
                            Console.WriteLine("Search:");

                            foreach (Service aService in list)
                                Console.WriteLine(aService);

                            SwapColors();
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            }
            

        }

        private static void SwapColors()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }
    }
}
