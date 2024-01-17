using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the count of cities :");

                string countStr = Console.ReadLine();
                int count = Convert.ToInt32(countStr);
                ChinaCity[] chinaCity = new ChinaCity[count];
                for (int i = 0; i < chinaCity.Length; i++)
                {
                    ChinaCity chinaCity1 = new ChinaCity();
                    Console.WriteLine("Enter the name of the city that you want to add :");
                    string chinaCity2 = Console.ReadLine();
                    chinaCity.Name = chinaCity2;

                }



                Console.WriteLine("Enter the population of the city : ");
                string populationStr = Console.ReadLine();
                int population = Convert.ToInt32(populationStr);
            }
    }
}
