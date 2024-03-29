﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaTriangle
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string msg = "";
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)//check slides for zero condidtion
                return msg += "Incorrect values";
            if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)//
            {
                if (side1 == side2 && side2 == side3)//check for quilateral
                    return msg += "equilateral";
                else if (side1 == side2 || side2 == side3 || side1 == side3)//check for isoceles
                    return msg += "isoceles";
                else
                    return msg += "scalene";//check scalene
            }
            else { return msg += "invalid form"; }
            return msg;
        }
    }
}
