namespace randomclss
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("type your lenght of password you want");
            var passswordlength = Convert.ToInt32(Console.ReadLine());

            var buffer = new char[passswordlength];

            for(int i = 0; i < passswordlength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);        }
    }
}