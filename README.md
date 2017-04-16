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

## Tests

Tests written in xUnit with xunit.runners.visualstudio.

Open in Visual Studio 2017 or later to compile and run the test suite.
