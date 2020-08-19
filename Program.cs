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

            //TestAdapterPatter();
            TestBridgePattern();

            //SOLIDPrinciplesTest();

            //new POO.Client();
        }

        private static void SOLIDPrinciplesTest()
        {
            new SOLID_Principles.Liskov.Example1.Client();
        }

        #region Creational Patters 
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

        #endregion

        #region Structural Pattern
        private static void TestAdapterPatter()
        {
            new DesignPatterns.Structural.Adapter.Client();
        }

        private static void TestBridgePattern()
        {
            new DesignPatterns.Structural.Bridge.Client();
        }
        #endregion
    }
}
