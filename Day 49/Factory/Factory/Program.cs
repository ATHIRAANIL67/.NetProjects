using System;
namespace Factory
{
    interface Food
    {
        string getType();
    }

    class Pizza : Food
    {
        public string getType()
        {
            return "Someone ordered Fast Food!";
        }
    }

    class Cake : Food
    {
        public string getType()
        {
            return "Someone ordered a Dessert!";
        }
    }

    class FoodFactory
    {
        public Food getFood(string order)
        {
            if (order.Equals("pizza"))
                return new Pizza();
            else if (order.Equals("cake"))
                return new Cake();
            else
                return null;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            FoodFactory myFactory = new FoodFactory();

            string order = Console.ReadLine().Trim();
            Food food = myFactory.getFood(order);

            Console.WriteLine("The factory returned class " + food.GetType().Name);
            Console.WriteLine(food.getType());
        }
    }
}