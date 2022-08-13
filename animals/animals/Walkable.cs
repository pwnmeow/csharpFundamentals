namespace AnimalsExample
{
    public class Walkable
    {
        public void Walk()
        {
            Console.WriteLine("Hey i am walking");
        }
        public void Walk(string name)
        {
            Console.WriteLine("Hey i am "+ name +" and i walk !!");
        }
    }
}