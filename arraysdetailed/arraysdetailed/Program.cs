namespace arraylists { 
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 4, 3, 21, 9, 5, 93 };

            // Length
            Console.WriteLine("Length: "+ numbers.Length); 
            
            // IndexOf
            var index = Array.IndexOf(numbers, 21);  
            Console.WriteLine(index);

            // Clear 
            Console.WriteLine("Cleard the array");
            Array.Clear(numbers, 0, 2);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            // Copy 
            int[] anotherarry = new int[3];
            Console.WriteLine("Copied  the array");
            Array.Copy(numbers, anotherarry, 2);

            foreach (var item in anotherarry)
            {
                Console.WriteLine(item);
            }

            // Sort 
            Console.WriteLine("Sorted  the array");
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Reverse 
            Console.WriteLine("Reversed  the array");
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }

}