using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("war and Peace", "Leo Tolstoy", 850);
            Book b2 = new Book("The graps of Wrath", "Leo Tolstoy", 509);
            
            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
             Console.WriteLine(b2.GetDescription());

            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1._name = "Alux Huxly";
        }
    }
}
