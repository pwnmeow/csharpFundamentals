// See https://aka.ms/new-console-template for more information
namespace Csharpfundamentals
{
    class Program
    {
        static void Main(string[] args) {

            //Csharp first you specify a arrays return type and then you also allocate memory to that arry.
            // It can not be remodified 
            int[] numbers = new int[3];
            // can also be done with var numbers = new int[3]; 

            Console.WriteLine(numbers[0] = 1);
            Console.WriteLine(numbers[1] = 2);
            Console.WriteLine(numbers[2] = 3);

            // If we manually dont change the value of default data type the value will be false for bulls and for ints itll be 0
            bool[] bools = new bool[3];
            bools[0] = true;

            Console.WriteLine(bools[0]);
            Console.WriteLine(bools[1]);
            Console.WriteLine(bools[2]);

            string[] names = new string[3];

            Console.WriteLine(names[0] = "sheeraz");
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);




        }
    }
}