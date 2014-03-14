using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UseBookSellers.Models
{
    public class Practice
    {
        public void Run()
        {
            // Constructor
            Car ford = new Car();

            // Assignment (set values)
            ford.Make = "Ford";
            ford.Model = "F150";
            ford.NumDoors = 2;
            ford.MaxSpeed = 120.65;

            // Get Values
            string x = ford.Make;
        }
    }
    public class Car
    {
        // Get means we can retrieve value
        // Set means we can assign value
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public double MaxSpeed { get; set; }
    }
}
