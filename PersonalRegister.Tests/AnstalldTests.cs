using NUnit.Framework;

namespace PersonalRegister.Tests
{
    /// <summary>
    /// Klas med test av klassen Anstalld
    /// </summary>
    public class AnstalldTests
    {
        public Anstalld Anstalld { get; set; }


        [SetUp]
        public void Setup()
        {
            Anstalld = new Anstalld();
        }

        [Test]
        public void Namn()
        {
            Anstalld.ForNamn = "Kalle";
            Anstalld.EfterNamn = "Andersson";

            Assert.AreEqual("Kalle", Anstalld.ForNamn);

            Assert.AreEqual("Andersson", Anstalld.EfterNamn);
        }


        [Test]
        public void Lon()
        {
            Anstalld.Lon = 1234.50;
            Assert.AreEqual(1234.50, Anstalld.Lon);
        }
    }
}