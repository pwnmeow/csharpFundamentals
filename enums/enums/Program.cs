namespace Csharpfundamentals
{
    // When we have similar data one of whiich will be valid we can make a enum its like a object in js but you can only 
    // Select one value fromthe choices so somewhat like graphql Enum 
    // By default its only int 
    public enum ShippingMethod
    {
        RegularAirMail = 0,
        RegisterAirMail = 1,
        Express = 2
    }
    class Program
    {
        static void Main(string[] args)
        {

            // here this returns methods value to be 2 beacuse thats what it is suppsed to be for express shipping method
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            // From enum id to enum name this returns express beacuse value of express is 2 
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            // also can be done 
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shipmet = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shipmet);

        }
    }
}