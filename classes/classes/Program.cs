
using Csharpfundamentals.Math;

namespace Csharpfundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sheeraz = new Person();
            sheeraz.FirstName = "Sheeraz";
            sheeraz.LastName = "Ali";
            sheeraz.Introduce();

            Calculator calc = new Calculator();
            var result =  calc.Add(5,2);


            // Now we use the Console.WriteLine() function without making it an object unlike calc object
            // This happens beacuse Console.WriteLine is a static meathod which do not need to be initialized 
            // as a object when you use them 
            Console.WriteLine(result);
        }
    }
}