﻿namespace ConstroctorInheritance
{
    public class Vehicle

    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Vehical init");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
}