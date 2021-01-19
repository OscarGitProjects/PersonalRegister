using NUnit.Framework;

namespace PersonalRegister.Tests
{
    public class RestaurangTests
    {
        public Restaurang Restaurang { get; set; }

        [SetUp]
        public void Setup()
        {
            Restaurang = new Restaurang();
        }


        [Test]
        public void Namn()
        {
            Restaurang.Namn = "Kalles restaurang";

            Assert.AreEqual("Kalles restaurang", Restaurang.Namn);
        }
    }
}
