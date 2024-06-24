using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkSixteenPowerNumberTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minNumber = 4;
            int maxNumber = 100;
            int numberPower = 2;
            int numberPowerTwo = 2;
            int countPowerNumber = 0;

            Random random = new Random();
            number = random.Next(minNumber, maxNumber);

            while(numberPower < number)
            {
                numberPower *= numberPowerTwo;
                ++countPowerNumber;
            }

            Console.WriteLine($"the minimum power of two greater than the given {number} " +
                $"is equal to the degree of the number {countPowerNumber}");
        }
    }
}
