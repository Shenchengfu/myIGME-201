using System;

namespace PE8Q5
{
    // Author: Shencheng Fu
    // Purpose: Question 5 for PE 8.
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: To store values of x,y,z in the formula
        // z = 3 * y * y + 2 * x - 1 in a 3D array 
        // Restrictions: None.
        static void Main(string[] args)
        {
            double[,,] result = new double[20, 30, 3];
            double x = -1;
            for (int i = 0; i < 20; i++)
            {
                double y = 1;
                result[i, 0, 0] = x;
                for (int j = 0; j < 30; j++)
                {
                    result[i, j, 2] = 3 * y * y + 2 * x - 1;
                    result[0, j, 0] = y;
                    y += 0.1;
                }
                x += 0.1;
            }
        }
    }
}
