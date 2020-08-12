namespace MyNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFactoryMethod();
            //TestAbstractFactory();
            //TestBuilder();
            //TestPrototype();

            SOLIDPrinciplesTest();
        }

        private static void SOLIDPrinciplesTest()
        {
            new SOLID_Principles.Liskov.Example1.Client();
        }

        private static void TestFactoryMethod()
        {
            new DesignPatterns.Creational.FactoryMethod.Client();
        }

        public static void TestAbstractFactory()
        {
            new DesignPatterns.Creational.AbstractFactory.Client();
        }

        public static void TestBuilder()
        {
            new DesignPatterns.Creational.Builder.Client();
        }

        public static void TestPrototype()
        {
            new DesignPatterns.Creational.Prototype.Client();
        }
    }
}
