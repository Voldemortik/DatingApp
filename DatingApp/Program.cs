using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstStart = new DateTime(2018,8,2);
            DateTime firstStop = new DateTime(2019,6,1);
            var firstDate = (firstStop - firstStart).Days;

            DateTime secondStart = new DateTime(2019, 10, 25);
            DateTime secondStop = DateTime.Now;
            var secondDate = (secondStop - secondStart).Days;

            var resultDatingDays = firstDate + secondDate;
        }
    }
}
