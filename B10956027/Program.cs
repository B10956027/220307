using System;

namespace B10956027
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int meal = (int)meal_cost;
            int tip_percent = 15;
            int tax_percent = 8;

            int total = meal+tip_percent+tax_percent;

            Console.WriteLine("用餐總費用："+total);


        }
    }
}
