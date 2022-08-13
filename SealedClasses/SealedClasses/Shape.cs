namespace SealedClasses
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle !!!!");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle !!!!");
        }
    }


    public class Triangle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Drawing a Triangle !!!!");
        }
    }

        public class Shape
        {
            public virtual void Draw()
            {

            }
        }
    }
}
