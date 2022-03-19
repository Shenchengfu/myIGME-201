namespace Practice
{
    public class Program
    {
        public static void Main()
        {
            Tuple<double, double, double> formula;
            SortedList<Tuple<double, double, double>, double> list =
    						new SortedList<Tuple<double, double, double>, double>();
            for (double w = -2; w <= 0; w += 0.2)
            {
                for (double y = -1; y <= 1; y += 0.1)
                {
                    for (double x = 0; x <= 4; x += 0.1)
                    {
                        if (w <= 0 && y <= 1 && x <= 4)
                        {
                            double z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7;
                            formula = new Tuple<double, double, double>(Math.Round(w, 1), 
							Math.Round(x, 1), Math.Round(y, 1));
                            list[formula] = Math.Round(z, 3);
                            Console.WriteLine(formula + ", " + list[formula]);
                        }
                    }
                }
            }
    }
}