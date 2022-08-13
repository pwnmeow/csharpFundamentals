namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Customer();
            // Beacuse customer class is public we can call it
            john.Promote();

            // this will throw errors as this is a secret meathod in the class
           // john.VerySecretImplementaion();
        }
    }
}