using System.Drawing;

namespace SealedClasses
{

    
        // Sealed classes dont let you override meathods or clasess its opposite of abstract
   
    public class Program
    {
        static void Main(string[] args)
        {
  

            var ring = new Circle();
            var box = new Rectangle();
            var scale = new Triangle();

            var shapes = new List<Shape>();
            shapes.Add(ring);
            shapes.Add(box);
            shapes.Add(scale);

foreach (var shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}