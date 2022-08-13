namespace AnimalsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the main program");

            var dog = new Animals(new Walkable());

            dog.Eat("dog");

            var fish = new Animals(new Swimable());

            fish.Eat("GoldFish");

            var snake = new Animals();

            snake.Eat("Snake");
        }
       
    }
}