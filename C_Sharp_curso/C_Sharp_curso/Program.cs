using System;

namespace C_Sharp_curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datetime
            DateTime dateTime = new DateTime(2015,1,1);
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: "+now.Minute);

            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString("dd-MM-yy HH:mm"));

            //timestamp
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            //Console.WriteLine("Duration: " + duration);

            //Properties
            var totalMinutes = duration.TotalMinutes;
            var minutes = duration.Minutes;
            Console.WriteLine(totalMinutes);
            Console.WriteLine(minutes);

            //Add
            var addMinutes = duration.Add(TimeSpan.FromMinutes(8));
            var subtract = duration.Subtract(TimeSpan.FromMinutes(2));

            //ToString
            var toString = duration.ToString();

            //Parse
            var parse = TimeSpan.Parse("01:02:03");





        }
    }
}
