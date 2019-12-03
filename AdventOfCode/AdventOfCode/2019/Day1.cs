using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode._2019
{
    public static class Day1
    {
        public static List<int> getArray()
        {
            return new List<int>{137857, 121089, 138217, 109202, 82225, 65823, 110808, 82512, 71144, 129168, 142785, 103418, 99710, 84192, 115757, 52318, 137911, 56254, 76634, 66071, 127842, 109339, 98408, 139481, 95628, 78679, 111571, 131078, 79085, 72375, 56248, 60740, 85461, 144773, 55946, 114634, 120127, 72284, 140489, 141471, 122177, 102224, 91708, 120190, 119453, 62930, 64543, 53581, 69276, 111118, 57458, 135155, 85937, 93962, 98877, 101615, 107952, 139285, 55459, 113772, 121742, 79283, 98389, 61720, 110494, 110170, 125851, 111776, 122679, 91843, 94138, 63348, 71461, 75067, 62334, 62799, 59647, 86722, 82468, 91995, 133229, 111361, 140125, 63884, 65911, 135857, 61515, 82726, 66453, 106329, 89199, 68089, 136698, 117180, 97577, 68922, 130528, 72076, 73691, 65800};
        }

        public static int getTotalFule(List<int> list)
        {
            var result = 0;
            foreach (var item in list)
            {
                result += fuleCalc(item);
            }
            return result;
        }

        public static int fuleCalc(int value)
        {
            int result = 0;

            var x = value / 3;
            result = x - 2;


            return result;
        }
    }
}
