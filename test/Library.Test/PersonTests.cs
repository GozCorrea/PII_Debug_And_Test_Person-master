using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void TestInvalidId() // Cambiá el nombre para indicar qué estás probando
        {
            Person test = new Person("John Doe", "4.604.998-7");
            test.ID = "46049986";
            const string expected = "46049987";
            const string actual = "46049987";
            Assert.Equals (expected, actual);
        }
    }
}