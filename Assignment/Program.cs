using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source
            {
                Id = 1,
                Name = "Shashank",
                Age = 24,
                Occupation = "Software Engineer"

            };

            Destination destination = new Destination();

            PropertyMapper.MapProperties(source, destination);

            Console.WriteLine("Mapped properties in the Destination class:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Occupation: {destination.Occupation}");
        }
    }
}

//using Assignment;
//using System;
//using System.Reflection;
//namespace Assignment
//{
//    public class Program
//    {
//        public static void MapProperties(Source source, Destination destination)
//        {
//            Type sourceType = typeof(Source);
//            Type destinationType = typeof(Destination);

//            PropertyInfo[] sourceProperties = sourceType.GetProperties();
//            PropertyInfo[] destinationProperties = destinationType.GetProperties();

//            foreach (PropertyInfo sourceProperty in sourceProperties)
//            {
//                PropertyInfo destinationProperty = Array.Find(destinationProperties,
//                    p => p.Name == sourceProperty.Name && p.PropertyType == sourceProperty.PropertyType);

//                if (destinationProperty != null && destinationProperty.CanWrite)
//                {
//                    object value = sourceProperty.GetValue(source);
//                    destinationProperty.SetValue(destination, value);
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Source source = new Source
//            {
//                Name = "Shashank",
//                Age = 24,

//            };

//            Destination destination = new Destination
//            {
//                Occupation = "Software Engineer",
//                Email = "Shashank@gmail.com"
//            };

//            MapProperties(source, destination);

//            Console.WriteLine("  Mapping Successful!!!");
//            Console.WriteLine("=========================");
//            Console.WriteLine("Name: " + destination.Name);
//            Console.WriteLine("Age: " + destination.Age);
//            Console.WriteLine("Occupation: " + destination.Occupation);
//            Console.WriteLine("Email: " + destination.Email);

//            Console.ReadKey();
//        }



//    }
//}
