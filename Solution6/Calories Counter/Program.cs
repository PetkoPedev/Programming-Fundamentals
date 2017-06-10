using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheese = 0;
            var tomatoSause = 0;
            var salami = 0;
            var pepper = 0;
            var totalCalories = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                if(ingredients == "cheese")
                {
                    cheese += 500;
                }
                else if(ingredients == "tomato sauce")
                {
                    tomatoSause += 150;
                }
                else if(ingredients == "salami")
                {
                    salami += 600;
                }
                else if(ingredients == "pepper")
                {
                    pepper += 50;
                }
            }
            totalCalories = cheese + tomatoSause + salami + pepper;
            Console.WriteLine("Total calories: {0}", totalCalories);
        }
    }
}
