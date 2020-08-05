namespace MyNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAbstractFactory();
        }

        private static void TestFactoryMethod()
        {
            new DesignPatterns.Creational.FactoryMethod.Client();
        }

        public static void TestAbstractFactory()
        {
            new DesignPatterns.Creational.AbstractFactory.Client();
        }
    }
}
