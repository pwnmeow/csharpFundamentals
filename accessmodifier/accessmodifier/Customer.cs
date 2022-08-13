namespace AccessModifier
{
    // Available anywhere in main we can call this directly
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public void Promote()
        {
            Console.WriteLine("I am public call me");
        }

        private void VerySecretImplementaion()
        {
            Console.WriteLine("cant be accessed from outside of this class");
        }
    }
}