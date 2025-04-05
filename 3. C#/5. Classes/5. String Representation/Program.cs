using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Every class in C# inherits from Object, which means
            // that every class inherits the ToString() method
            int x = 1000;
            Console.WriteLine(x.ToString()); // prints 1000


            // TODO: if you don't override the method, the default behavior just prints
            // the name of the class and the namespace
            object a = new object();
            Console.WriteLine(a.ToString()); // prints System.Object

            // TODO: use the ToString method on the Book class
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            // Console.WriteLine(b1.ToString()); // prints overriden ToString method
            Console.WriteLine(b1); // defaults to ToString method
            
            // overloaded ToString method
            Console.WriteLine(b1.ToString('B')); // prints overloaded ToString method
            Console.WriteLine(b1.ToString('F')); // prints overloaded ToString method
        }
    }
}
