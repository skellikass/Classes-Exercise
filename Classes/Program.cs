using Microsoft.VisualBasic;
using System.Reflection;
using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a class named Car - make sure it is public
            
            //In the Main method:
            //Create a new instance of the Car class
            //Set values in the properties for the object
            //Print the values of each property to the Console

            Car car1 = new Car() { Make = "Toyota", Model = "Camry Hybrid", Year = 2007 };
            Console.WriteLine($"car1 is a {car1.Year} {car1.Make} {car1.Model}");

        }
}
}
