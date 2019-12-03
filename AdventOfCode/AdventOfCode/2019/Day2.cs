using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode._2019
{
    public static class Day2
    {
        public static List<int> getArray()
        {
            return new List<int>() { 1, 12, 2, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 19, 5, 23, 2, 23, 6, 27, 1, 27, 5, 31, 2, 6, 31, 35, 1, 5, 35, 39, 2, 39, 9, 43, 1, 43, 5, 47, 1, 10, 47, 51, 1, 51, 6, 55, 1, 55, 10, 59, 1, 59, 6, 63, 2, 13, 63, 67, 1, 9, 67, 71, 2, 6, 71, 75, 1, 5, 75, 79, 1, 9, 79, 83, 2, 6, 83, 87, 1, 5, 87, 91, 2, 6, 91, 95, 2, 95, 9, 99, 1, 99, 6, 103, 1, 103, 13, 107, 2, 13, 107, 111, 2, 111, 10, 115, 1, 115, 6, 119, 1, 6, 119, 123, 2, 6, 123, 127, 1, 127, 5, 131, 2, 131, 6, 135, 1, 135, 2, 139, 1, 139, 9, 0, 99, 2, 14, 0, 0 };

            //return new List<int>() { 1, 0, 0, 0, 99 };// becomes 2,0,0,0,99(1 + 1 = 2).
            //return new List<int>() { 2, 3, 0, 3, 99 };// becomes 2,3,0,6,99(3 * 2 = 6).
            //return new List<int>() { 2, 4, 4, 5, 99, 0 };// becomes 2,4,4,5,99,9801(99 * 99 = 9801).
            //return new List<int>() { 1, 1, 1, 4, 99, 5, 6, 0, 99 };//becomes 30,1,1,4,2,5,6,0,99.
        }

        public static int GetValue(List<int> list)
        {
            var index = 0;

            var notFinchid = true;
            var result = 0;

            do
            {
                var value = list[index];
                switch (value)
                {
                    case 1:
                        list[list[index + 3]] = Opcode1();
                        break;
                    case 2:
                        list[list[index + 3]] = Opcode2();
                        break;
                    case 99:
                        notFinchid = false;
                        result = list[0];
                        break;
                    default:
                        throw new NotImplementedException();

                }
                index += 4;
            } while (notFinchid);


            return result;

            int GetValueAtIndex(int i)
            {
                //return list[i];
                var valueIndex = list[i];
                return list[valueIndex];
            }

            int Opcode1()
            {
                int v1 = GetValueAtIndex(index + 1);
                int v2 = GetValueAtIndex(index + 2);
                return v1 + v2;
            }

            int Opcode2()
            {
                int v1 = GetValueAtIndex(index + 1);
                int v2 = GetValueAtIndex(index + 2);
                return v1 * v2;
            }
        }
    }
}
