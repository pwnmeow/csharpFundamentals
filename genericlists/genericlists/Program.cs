namespace genericlists
{
    class Program
    {
        static void Main(string[] args)
        {
            // we can initialize the list ahead of time
            // we can add 
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});

            foreach (var number in numbers)
                Console.WriteLine(number);

            // Index from start of arry

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // Index from end of arry
           Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            // Counts objects
            Console.WriteLine("Count: " + numbers.Count());

            // Remove from list first match
            numbers.Remove(1);

            foreach (var number in numbers)
                Console.WriteLine(number);

            // Remove all 1's from the list

            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Console.WriteLine("Now you have all the chars removed");
            foreach (var number in numbers)
                Console.WriteLine(number);


        }
    }
}