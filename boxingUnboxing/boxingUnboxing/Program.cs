


using System.Collections;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            // when we try to convert a value type ie thats stored in stack to a refrence type ie that is stored in heap 
            // CLR on backend convertsit so that is called boxing and unboxing
            var list = new ArrayList();
            list.Add(1);
            list.Add("Sheeraz");
            list.Add(DateTime.Today);

            var anotherlist = new List<int>();

            anotherlist.Add(1);

        }
    }
}