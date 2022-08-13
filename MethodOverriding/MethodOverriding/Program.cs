namespace MethodOverriding
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Meathod overloadiung is meathod with same name diffrent params
            // But meathod overriding means 
            // Inheariting a meathod from a parent class and then changing its implementation


            var ring = new Circle();
            var box = new Rectangle();
            var scale = new Triangle();

            var shapes = new List<Shape>();
            shapes.Add(ring);
            shapes.Add(box);
            shapes.Add(scale);


            // Here we made 3 shape objects like circle Rectangle triangle these are defined in the 
            // Shape.cs file and inherit from the base class of shapes 
            // now we run Draw and based on the type of shape it behaves diffrently
            foreach(var shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}