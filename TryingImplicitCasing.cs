using System; // means that we can use classes from the System namespace.

namespace MyApplication
{
  class Program
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
