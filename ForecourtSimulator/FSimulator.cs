using System;

namespace ForecourtSimulator
{
    public static class FSimulator
    {
        private static readonly Random getrandom = new Random();
        public static decimal simulateNozzle(){

            return getrandom.Next(1, 120);
        } 


    }
}
