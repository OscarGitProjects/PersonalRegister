using NUnit.Framework;

namespace PersonalRegister.Tests
{
    /// <summary>
    /// Klass med test av klassen Anstalld
    /// </summary>
    public class AnstalldTests
    {
        public Anstalld Anstalld { get; set; }


        [SetUp]
        public void Setup()
        {
            Anstalld = new Anstalld();
        }

        /// <summary>
        /// Testar att man kan lägga till uppgifter om den anställdes förnamn och efternamn
        /// </summary>
        [Test]
        public void Namn()
        {
            Anstalld.ForNamn = "Kalle";
            Anstalld.EfterNamn = "Andersson";

            Assert.AreEqual("Kalle", Anstalld.ForNamn);

            Assert.AreEqual("Andersson", Anstalld.EfterNamn);
        }


        /// <summary>
        /// Testar att man kan lägga till uppgifter om den anställdes lön
        /// </summary>
        [Test]
        public void Lon()
        {
            Anstalld.Lon = 1234.50;
            Assert.AreEqual(1234.50, Anstalld.Lon);
        }
    }
}