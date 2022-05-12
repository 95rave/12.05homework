using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace homework12._05
{
    class Country
    {


        public string Name;
        public static int TotalPopulation;
        public ArrayList Cities;


        public Country(string name)
        {
            Name = name;
            Cities = new ArrayList();

        }
        static  Country()
        {
            TotalPopulation = 0;
        }

        public void Add(City city)
        {
            Cities.Add(city);
        }
         
      public void FindAllByPopulation(int min, int max)
        {
            foreach (City item in Cities)
            {
                if (item.Population > min && item.Population < max)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Sum()
        {
           
            foreach (City item in Cities)
            {
                TotalPopulation += item.Population;
            }
            Console.WriteLine("Total Population of country: "+ TotalPopulation);
        }
         
        
           


    }
}
