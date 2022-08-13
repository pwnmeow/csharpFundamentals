namespace AnimalsExample
{
    public class Animals{


        private readonly Walkable _walkable;
        private readonly Swimable _swimable;

        public Animals()
        {
            Console.WriteLine("Not specified if walks");
        }
        public Animals(Walkable walkable)
        {
                _walkable = walkable;
        }

        public Animals(Swimable swimable)
        {
            _swimable = swimable;
        }
        private int Age { get; set; }

        public void Eat(string name) {
            Console.WriteLine("Heyy i am " + name + " and i eat mmmmm omomom.");
            if (_walkable != null)
            {
                _walkable.Walk(name);
            }
            else if(_swimable != null)
            {
                _swimable.Swim(name);
            }else 
            {
                Console.WriteLine("Yeh i dont walk or swim probably");
            }
        }
        public void Sleep(string name)
        {
            Console.WriteLine("Heyy i am " + name + " and i Sleep zzzzzzzzzzzzzzzzz!");
        }
    }
}