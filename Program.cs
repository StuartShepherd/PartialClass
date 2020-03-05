using System;

namespace PartialClass
{
    class Program
    {
        public partial class PartialClass
        {
            private string _firstName;
            private string _lastName;

            public string FirstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return _lastName;
                }
                set
                {
                    _lastName = value;
                }
            }
        }

        public partial class PartialClass
        {
            public void FullName()
            {
                Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            }
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
            partialClass.FullName();

            Console.ReadLine();
        }
    }
}