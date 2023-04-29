using System;

namespace MangoInfoApp
{
    class ConsumeMango
    {
        public void SqueeezeMango(object sender, MangoEventArgs e)
        {
            Console.WriteLine("Squeezing " + e.Number
            + " of " + e.MangoInfo + " mangoes");
        }
    }

}
