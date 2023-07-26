using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Reflection
{
    class Car
    {
        // Fields
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int Year { get; set; }
        public double CurrentValue { get; set; }

        // Constructor
        public Car(string make, string model, string registration, int year, double currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            CurrentValue = currentValue;
        }

        // Method to get the current value of the car
        public double GetCurrentValue()
        {
            return CurrentValue;
        }

        // Method to get the year of the car
        public int GetYear()
        {
            return Year;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Car: {Make} {Model}\nRegistration: {Registration}\nYear: {Year}\nCurrent Value: {CurrentValue:C}";
        }
    }
}
