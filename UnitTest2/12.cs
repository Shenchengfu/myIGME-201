namespace Practice
{
    public class Program
    {
        public static void Main()
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            IList<string> keys = friendBirthdays.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Name: " + k + ", Birthdate: " + friendBirthdays[k].ToString("MM/dd/yyyy"));
            }
        }
    }
}