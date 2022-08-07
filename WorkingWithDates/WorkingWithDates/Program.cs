namespace datestuff
{
    class Program
    {
        static void Main(string[] args)
        {
           var dateTime = new DateTime(2015,1 ,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour :" + now.Hour);
            Console.WriteLine("Minute :" + now.Minute);

            var tommorow = dateTime.AddDays(1);
            var yesterday = dateTime.AddDays(-1);


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("DD-yy-MM"));




            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(0,0,0);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("duration :" + duration);

            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan1.TotalMinutes);

            Console.WriteLine("add example :" +timeSpan.Add(timeSpan.fro))
        }
    }
}