using System;
using System.Collections.Generic;

namespace ArrayManipulator
{
    public class Manipulator
    {
        /// <summary>
        /// Splits an array by the divisor provided, returning a 
        /// <see cref="List{T}"/> of arrays, equally sized. 
        /// <para>
        /// Where the original array does not divide equally by the divisor 
        /// then the remainder will be returned as a shorter array.
        /// </summary>
        /// <param name="originalArray">The array of integers to be broken up
        /// into shorter, equal length arrays.</param>
        /// <param name="divisor">The number of arrays that should be returned
        /// by the method.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="int[]"/></returns>
        public static List<int[]> Split(int[] originalArray, int divisor)
        {
            throw new NotImplementedException();
        }
    }
}
