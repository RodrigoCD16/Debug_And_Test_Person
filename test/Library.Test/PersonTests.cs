using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        Person p1 = new Person("John Doe", "1.234.567-8");
        IdUtils verifier = new IdUtils();

        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void EmptyNameTest() // Cambiá el nombre para indicar qué estás probando
        {
            p1.Name = "";
            const string expected = "John Doe";
            Assert.AreEqual(expected, p1.Name);
        }
        
        [Test]
        public void ValidNameChangeTest() // Cambiá el nombre para indicar qué estás probando
        {
            p1.Name = "John Snow";
            const string expected = "John Snow";
            Assert.AreEqual(expected, p1.Name);
        }

        [Test]
        public void InvalidLongerIDTest() // Cambiá el nombre para indicar qué estás probando
        {
            verifier.IdIsValid("1.234.567.910-8");
            const string expected = "False";
            Assert.AreEqual(expected, p1.ID);
        }
    }
}