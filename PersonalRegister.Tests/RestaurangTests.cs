using NUnit.Framework;
using System;

namespace PersonalRegister.Tests
{
    /// <summary>
    /// Klass med test av klassen Reastaurang
    /// </summary>
    public class RestaurangTests
    {
        public Restaurang Restaurang { get; set; }

        [SetUp]
        public void Setup()
        {
            Restaurang = new Restaurang();
        }


        /// <summary>
        /// Testa att det går sätta namn på restaurangen
        /// </summary>
        [Test]
        public void Namn()
        {
            Restaurang.Namn = "Kalles restaurang";

            Assert.AreEqual("Kalles restaurang", Restaurang.Namn);
        }


        /// <summary>
        /// Testar att det går lägga till en och två anställd till listan med anställda
        /// </summary>
        [Test]
        public void AddAnstalld()
        {
            Anstalld anstalld = new Anstalld();
            anstalld.ForNamn = "Kalle";
            anstalld.EfterNamn = "Andersson";
            anstalld.Lon = 123.45;

            Restaurang.AddAnstalld(anstalld);
            Assert.AreEqual(1, Restaurang.Anstallda.Count);

            Restaurang.AddAnstalld(anstalld);
            Assert.AreEqual(2, Restaurang.Anstallda.Count);
        }


        /// <summary>
        /// Testar att metoden AddAnstalld kastar undantag ArgumentNullException om referensen till Anstalld är null
        /// </summary>
        [Test]
        public void AddAnstalld_ArgumentNullException()
        {
            Anstalld anstalld = null;

            Assert.Throws<ArgumentNullException>(() => Restaurang.AddAnstalld(anstalld));
        }
    }
}
