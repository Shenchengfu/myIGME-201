using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            double eImagCoord, eRealCoord;
            int iterations;
            bool flag1 = true;
            bool flag2 = true;

            do
            {
                Console.WriteLine("Please enter the imagCoord value");
                if (Double.TryParse(Console.ReadLine(), out eImagCoord) && eImagCoord > -1.2)
                {
                    flag1 = false;
                }
                else
                {
                    Console.WriteLine("Not an integer.");
                }
            } while (flag1);

            do
            {
                Console.WriteLine("Please enter the realCoord value");
                if (Double.TryParse(Console.ReadLine(), out eRealCoord) && eRealCoord < 1.77)
                {
                    flag2 = false;
                }
                else
                {
                    Console.WriteLine("Not an integer.");
                }
            } while (flag2);

            for (imagCoord = eImagCoord; imagCoord >= -1.2; imagCoord -= (eImagCoord + 1.2) / 48)
            {
                for (realCoord = eRealCoord; realCoord <= 1.77; realCoord += (1.77 - eRealCoord) / 80)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
