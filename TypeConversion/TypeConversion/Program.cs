namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            // # IMPLICIT TYPE CONVERSOIN

            // implicit conversion works when data loss will not happen 
            // Example a byte to a int conversion in this case a int can easily 
            // store a byte so we wont need to do anything in this itll convert automatically.
            byte b = 1;
            int i = b;
            Console.WriteLine(b);

            // # EXPLICIT TYPE CONVERSOIN

            // Now we did a explicit type conversion as the byte is smaller than an int
            // so we converted a to a byte but beacuse data was not that big no loss will happen.

            int a = 1;
            byte bb = (byte) a;
            Console.WriteLine(bb);

            // now if we try the same but insted of 1 set value to 1000 a byte can only store 255 values so data loss happend.
            int c = 1000;
            byte bbb = (byte)c; 
            Console.WriteLine(bbb); // output 232

            // # NON explicit conversion
            // in this case if we try to instead store the 1234 value into a byte that can only store 255 values
            // That will cause issues and we wont be able to do it dataloss will so happen and exeception will occur an overflow exception
            string number = "1234";
            int u = Convert.ToInt32(number);
            Console.WriteLine(u);

            // handling a execption
            try {

                //string j = "1234";
                //byte k = Convert.ToByte(j);
                //Console.WriteLine(k);

                string j = "1234";
                int k = Convert.ToInt32(j);
                Console.WriteLine(k);

                // Converting a string to a boolien
                string val = "true";
                bool flag = Convert.ToBoolean(val);
                Console.WriteLine(flag);
            }
            catch (Exception) {
                Console.WriteLine(" number can not be converted to string");
            }
            
        
        
        }
    }
}