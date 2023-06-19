namespace OopsConcept
{
    internal class Program : Interface_One, Interface_Two
    {
        static void Main(string[] args)
        {
            Interface_One interface_One = new Program();
            interface_One.one();
            Interface_Two interface_Two = new Program();
            interface_Two.two();
            Console.ReadLine();
            InterfaceClassTwo interfaceClassTwo = new InterfaceClassTwo();
            interfaceClassTwo.two();

        }

        public void one()
        {
            Console.WriteLine("Mahesh");
        }

        public void two()
        {
            Console.WriteLine("Kumar");
        }
    }
}