using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //slowacki Balladyna Kordian
        //mickiewicz sonety tadeusz

        //toyota: auris, yaris
        //ford: fiesta, focus

        //usa abrams, pershing
        //german maus tiger

        [TestMethod]
        public void TestMethod1()
        {
            SimpleFactory.Factory factory = SimpleFactory.Factory.getInstance();
            SimpleFactory.Books.Book balladyna = factory.createBook("BALLADYNA");
            Assert.AreEqual("Juliusz Slowacki Balladyna", balladyna.getName());
        }

        [TestMethod]
        public void TestMethod2()
        {
            FactoryMethod.Books.BookStore slowackiStore = FactoryMethod.Books.SlowackiStore.getInstance();
            FactoryMethod.Books.Book balladyna = slowackiStore.createBook("BALLADYNA");
            Assert.AreEqual("Juliusz Slowacki Balladyna", balladyna.getName());
        }

        [TestMethod]
        public void TestMethod3()
        {
            AbstractFactory.Books.AbstractFactory abstractFactory = AbstractFactory.Books.ConcreteFactory1.getInstance();
            AbstractFactory.Books.AbstractSlowacki balladyna = abstractFactory.createSlowackiBook();
            Assert.AreEqual("Juliusz Slowacki Balladyna", balladyna.Author+ " " +balladyna.Title);
        }
    }
}
