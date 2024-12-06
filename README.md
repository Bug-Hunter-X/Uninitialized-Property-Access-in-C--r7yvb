# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior, such as unexpected default values (e.g., 0 for integers) or exceptions (depending on the property's implementation).  The `bug.cs` file shows the problematic code; `bugSolution.cs` provides a corrected version.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the code. Note the output, which may vary depending on the property's default value.

## Solution

The `bugSolution.cs` file shows a corrected version.  Always initialize properties explicitly, or within a constructor if it makes sense.