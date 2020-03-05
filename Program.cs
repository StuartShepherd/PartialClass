using System;

namespace PartialClass
{
    class Program
    {
        public partial class PartialClass
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public partial class PartialClass
        {
            public string FullName => $"{FirstName} {LastName}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Partial Class");
            Console.WriteLine("The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.");
            Console.WriteLine("All the parts must use the partial keyword. All the parts must be available at compile time to form the final type. ");
            Console.WriteLine("All the parts must have the same accessibility, such as public, private, and so on.");
            Console.WriteLine();

            PartialClass partialClass = new PartialClass
            {
                FirstName = "Stuart",
                LastName = "Shepherd"
            };
            Console.WriteLine(partialClass.FullName);
            Console.ReadLine();
        }
    }
}