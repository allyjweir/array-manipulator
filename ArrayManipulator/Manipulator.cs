using System;
using System.Collections.Generic;
using System.Linq;

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
        public static IEnumerable<IEnumerable<int>> Split(IEnumerable<int> originalArray, int divisor)
        {
            // Check parameters meet requirements of method.
            if (originalArray.Count() < 1)
            {
                throw new ArgumentException("Cannot process an empty array");
            }
            if (divisor < 1)
            {
                throw new ArgumentException("Divisor must be a positive integer");
            }

            // Round up the newArrayLength to make sure we grab any remainder
            // if the originalArray does not divide exactly by the divisor.
            var newArrayLength =
                (int)Math.Ceiling((double)originalArray.Count() / divisor);

            var splitArrays = new List<IEnumerable<int>>();

            for (int i = 0; i < divisor; i++)
            {
                var newArray = originalArray
                    .Take(newArrayLength);

                splitArrays.Add(newArray);

                // Reassign originalArray to not include the ones we just 
                // extracted and placed in our splitArrays List.
                originalArray = originalArray.Skip(newArrayLength);
            }

            return splitArrays;
        }
    }
}
