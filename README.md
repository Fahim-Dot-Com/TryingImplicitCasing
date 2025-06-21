# TryingImplicitCasing
# C# Implicit Casting Example

This is a simple C# console application that demonstrates **implicit casting** (also known as automatic type conversion) from an `int` to a `double`.

## 📌 What It Does

The program defines an integer value and assigns it to a double variable. Since this is a **safe and widening conversion**, it happens automatically. The program then prints both values to the console.

### Output:
```
9
9
```
## 📷 Interaction Example.
W3School NET IDE
![Screenshot_20250621_091554_Chrome](https://github.com/user-attachments/assets/36c06d9d-82d8-4cb4-a6e2-70d0e626b813)

Note: The second line appears as `9`, but it is technically a `double` (i.e., `9.0`), depending on formatting and context.

## 💡 Concept Demonstrated

- **Implicit Casting (Widening Conversion)**: 
  - When a smaller type is converted to a larger type without needing manual conversion.
  - Example: `int → double`

## 🧠 Code Overview

```csharp
using System;

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
```

▶️ How to Run
Ensure the .NET SDK is installed on your machine.

Open a terminal or command prompt in the project folder.

Use the following commands to run the app:
```
dotnet build
dotnet run
```

🛠️ Requirements
.NET SDK 5.0 or higher

Any code editor (Visual Studio, VS Code, JetBrains Rider, etc.)

🧾 License
This project is free to use for learning and educational purposes.
