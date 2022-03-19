namespace Practice
{
    class Program
    {
        static void UsePhone(object obj)
        {
            ((PhoneInterface) obj).MakeCall();
        }
        static void Main(string[] args)
        {
            Tardis t = new Tardis();
            UsePhone(t);
            PhoneBooth pb = new PhoneBooth();
            UsePhone(pb);
        }
    }
}
