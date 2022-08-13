namespace AbstractClass
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
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle !!!!");
        }
    }


    // Here We declared our Shpe class as abstract and the draw meathod as abstract too
    // Now above we overrided those draw meathods for each of the shapes in shape class
    public abstract class Shape
        {
        public abstract void Draw();

        }
}