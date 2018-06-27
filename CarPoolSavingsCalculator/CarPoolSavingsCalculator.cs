using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolSavingsCalculator
{
    class CarPoolSavingsCalculator
    {
        static void Main(string[] args)
        {
            int totalMilesDrivenPerDay, costPerGallonOfGasInCents, averageMilesPerGallon, dailyParkingFeesInCents, dailyTollsInCents, dailyCostToCarPoolInCents, dailySavingsFromSwitchingToCarPool;

            Console.WriteLine("Enter the total miles you drive each day: ");
            totalMilesDrivenPerDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cost per gallon of gas in cents: ");
            costPerGallonOfGasInCents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the average miles per gallon: ");
            averageMilesPerGallon= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total daily parking fees in cents: ");
            dailyParkingFeesInCents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total daily toll expenses in cents: ");
            dailyTollsInCents = Convert.ToInt32(Console.ReadLine());

            int totalDailyMilageCostInCents = totalMilesDrivenPerDay * costPerGallonOfGasInCents * averageMilesPerGallon;
            int totalDailyFixedCostInCents = dailyParkingFeesInCents + dailyTollsInCents;
            int totalDailyDriveCostInCents = (totalDailyMilageCostInCents + totalDailyFixedCostInCents) * 2;

            Console.WriteLine("Your total cost to drive to work per day is: {0}", totalDailyDriveCostInCents);
            Console.WriteLine("Enter the daily cost to car-pool in cents: ");

            dailyCostToCarPoolInCents = Convert.ToInt32(Console.ReadLine());
            dailySavingsFromSwitchingToCarPool = totalDailyDriveCostInCents - dailyCostToCarPoolInCents;

            if (dailySavingsFromSwitchingToCarPool > 0)
                Console.WriteLine("Your daily savings by switching to car-pooling in cents is: {0}", dailySavingsFromSwitchingToCarPool);
            else
                Console.WriteLine("You won't save by car-pooling, keep pumping those fossil fuels into the atmosphere!!");



        }
    }
}
