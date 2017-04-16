# Array Manipulator

[![Build status](https://ci.appveyor.com/api/projects/status/owks6bwvxj0phtrb?svg=true)](https://ci.appveyor.com/project/allyjweir/array-manipulator)

Given an array of length >= 0, and a positive integer N, return the contents of the array divided into N equally sized arrays.

Where the size of the original array cannot be divided equally by N, the final part should have length equal to the remainder.

Example:
```
Inputs [1, 2, 3, 4, 5] and 3
Output [[1, 2], [3, 4], [5]]
```

## Builds

AppVeyor is used for CI. For more details, click the Build Status badge above.

## To Run

Being written in C#, this project requires Visual Studio to run. Could possibly run in .NET Core on Linux/macOS but untested.

### On Windows (Tested on Win10)

1. Install Visual Studio (developed in VS 2017 Community)
2. Clone the repo
3. Open the solution file (.sln) in Visual Studio
4. On the menu bar at top:
  a. Build -> Build Solution
  b. Test -> Run -> All Tests.
  
## Tests

Tests written in xUnit with xunit.runners.visualstudio.
