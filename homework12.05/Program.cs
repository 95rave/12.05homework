using System;
using System.Collections.Generic;

namespace homework12._05
{
    class Program
    {
        static void Main(string[] args)
        {
            NewPalace:
            Console.WriteLine("Enter the name of the country");
            string countryName = Console.ReadLine();
            Country country = new Country(countryName);
            Console.WriteLine("How many city do you add?");
            int count = Convert.ToInt32(Console.ReadLine());


            while (count!=0)
            {
                Console.WriteLine("Enter the name of the city");
                string cityName = Console.ReadLine();
                Console.WriteLine(cityName+" OF Population count");
                int population = Convert.ToInt32(Console.ReadLine());
               
                City city = new City(cityName,population);
                country.Add(city);
                
                count--;
            }
            Console.WriteLine("Enter the minumum count");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum count");
            int max = Convert.ToInt32(Console.ReadLine());
            country.FindAllByPopulation(min, max);

            country.Sum();
            goto NewPalace;

        }


            
            
    }
}
