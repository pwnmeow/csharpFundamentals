namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditions
            
            int hour = 15;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning time!");
            }else if (hour >= 12 && hour < 18)
            {
               Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("Its evening");
            }



            // Switch
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)



        }
    }
}