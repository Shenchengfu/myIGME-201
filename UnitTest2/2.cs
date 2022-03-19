// Potential suggestion for changing the Circus class
namespace Practice
{
    public sealed class Circus
    {
        public string name;

	 public Circus(string n){
		
		this.name = n;
    	}
    }


    static class Program
    {
        static void Main()
        {
 
            Circus myCircus = new Circus("Colorado");
        }
    }
}