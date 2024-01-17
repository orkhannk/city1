using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class City
    {
        protected string Name;
        protected int Population;


        public virtual int CityPopulation
        {
            get
            {
                return Population;
            }
            set
            {
                if (value >= 0)
                    Population = value;
            }

        }
        public string CityName
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20 && CheckCityName(value))
                    Name = value;
            }

        }




        private bool CheckCityName(string cityName)
        {
            for (int i = 0; i < cityName.Length; i++)
            {
                if (!char.IsLetter(cityName[i]))
                    return false;
            }
            return true;
        }

        //public virtual void SetName(string value)
        // {
        //     if (value.Length >= 3 && value.Length <= 20)
        //         Name = value;

        // }

        // public string GetName()
        // {
        //     return Name;

        // }


        // public virtual void SetPopulation (int value)
        // {
        //     if (value >= 0)
        //         Population = value;
        // }
        // public int GetPopulation()
        // {
        //     return Population;
        // }
    }
}
