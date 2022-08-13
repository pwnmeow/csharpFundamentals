namespace ConstroctorInheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being init");
        }

        public Car(string registrationNumber) 
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being init and registration number is " + registrationNumber);

        }
    }
}