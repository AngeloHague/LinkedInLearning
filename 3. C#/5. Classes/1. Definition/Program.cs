using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Hobbit", "J.R.R. Tolkien", 310);
            Book b3 = new Book("The Lord of the Rings", "J.R.R. Tolkien", 1178);
            
            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
            Console.WriteLine(b3.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1._name = "War and Peace 2"; // Error: _name is inaccessible due to its protection level

        }
    }
}
