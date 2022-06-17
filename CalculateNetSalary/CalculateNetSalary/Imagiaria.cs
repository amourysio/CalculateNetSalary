using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateNetSalary
{
    /// <summary>
    /// if there is a need to have a new tax in the future, should create a new  constant variable and add it to the GetNetSalary method
    /// and will be deducted from the current salary.
    /// </summary>
    /// <param class="Imagiaria"></param>
    internal class Imagiaria
    {
        private string name;
        private decimal salary;
        private const decimal ABOVE = 1000;
        public const decimal HIGHER = 3000;
        private const decimal INCOME = (decimal)0.10;
        private const decimal SOCIAL = (decimal)0.15;
        /// <summary>
        /// Constructor whos get Name and Salary of Person
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Salary"></param>
        /// <exception cref="ArgumentException"></exception>
        public Imagiaria(string Name, decimal Salary)
        {
            if (Salary < 0)// Check for negative value
                throw new ArgumentException("Only Possitive Value!");

            this.name = Name;
            this.salary = Salary;
        }


        private bool CheckForAbove() => salary > ABOVE; // Check if Salary is Above 1000$
        private bool CheckForHigher() => salary > HIGHER;// Check if Salary is Higher than 3000$

        /// <summary>
        /// This method calculate the person salary and get the taxes if there have for Country Imagiaria.
        /// </summary>
        /// <param method="GetNetSalary"></param>
        public void GetNetSalary()
        {
            // I use this method for check if the person should have to pay tax of country,
            // if person get more than 1000$ IDR.
            if (CheckForAbove())
            {
                decimal tempSalary;
                //double check for salary, because taxes is not up to 3000$ IDR.
                if (CheckForHigher())
                {
                    // by using tempSalary variable i can get the % of taxes.
                    tempSalary = HIGHER - ABOVE;
                    decimal tax = (salary - ABOVE) * INCOME;
                    decimal social = tempSalary * SOCIAL;
                    //Remove social and income tax from current salary.
                    salary -= social + tax;

                    Console.Write(name + ":" + salary + "$");
                }
                //every person who get smaller than 3000$ IDR.
                else
                {
                    // by using tempSalary variable i can get the % of taxes.
                    tempSalary = salary - ABOVE;
                    decimal tax = tempSalary * INCOME;
                    decimal social = tempSalary * SOCIAL;
                    //Remove social and income tax from current salary.
                    salary -= social + tax;
                    Console.Write(name + ":" + salary + "$");
                }

            }
            //If a person salary is Above or Equal to 1000$ IDR
            else
            {
                Console.WriteLine(name + ":" + salary + "$");
            }
        }
    }
}
