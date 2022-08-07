namespace stringfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "sheeraz ali";
            Console.WriteLine("Trim :" + name.Trim());
            Console.WriteLine("Uppercase :" + name.ToUpper());
            Console.WriteLine("Lowercase :" + name.ToLower());

            var indexoflastname = name.IndexOf(" ");
            Console.WriteLine("Lastname index :" + indexoflastname);
            
            var firstname =  name.Substring(0, indexoflastname);
            Console.WriteLine("Substringed firstname :" + firstname);
            
            var lastname = name.Substring(indexoflastname + 1);
            Console.WriteLine("Substringed lastname :" + lastname);

            var names = name.Split(' ');
            Console.WriteLine("Firstname :" + names[0]);
            Console.WriteLine("Lastname :" + names[1]);

    
            Console.WriteLine("Replaced :" + name.Replace("sheeraz", "sameen"));

            if (string.IsNullOrEmpty(null)){
                Console.WriteLine("invalid");
            }
            else if(string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Still invalid");
            }
            else
            {
                Console.WriteLine("valid");
            }


            var str = "25";
            var age = Convert.ToByte(str);

            Console.WriteLine(age);

            float price = 29.95f;

            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));


        }
    }
}