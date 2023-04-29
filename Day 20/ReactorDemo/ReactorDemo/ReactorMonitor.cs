using System;

namespace ReactorDemo
{
    class ReactorMonitor
    {
        public ReactorMonitor(Reactor myReactor)
        {
            myReactor.OnMeltdown += new Reactor.MeltdownHandler(DisplayMessage);
        }
        public void DisplayMessage(object myReactor, MeltdownEventArgs myMEA)
        {
            Console.WriteLine(myMEA.Message);
        }
    }

}