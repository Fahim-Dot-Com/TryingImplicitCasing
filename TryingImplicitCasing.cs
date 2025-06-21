using System; // means that we can use classes from the System namespace.

namespace MyApplication  // is used to organize your code, and it is a container for classes and other namespaces.
{
  class Program // is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
  {
    static void Main(string[] args)
    {
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);     // Outputs 9
      Console.WriteLine(myDouble);  // Outputs 9 (as a double)
    }
  }
}
