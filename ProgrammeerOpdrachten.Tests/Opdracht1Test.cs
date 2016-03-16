using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammeerOpdrachten.Tests
{
    [TestClass]
    public class Opdracht1Test
    {
        [TestMethod]
        public void KanIkUitslapen_GeenWerkDagEnGeenVakantie_KanUitslapen()
        {
            var sut = new Opdracht1();

            bool result = sut.KanIkUitslapen(false, false);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void KanIkUitslapen_WerkDagEnGeenVakantie_KanNietUitslapen()
        {
            var sut = new Opdracht1();

            bool result = sut.KanIkUitslapen(true, false);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void KanIkUitslapen_GeenWerkDagWelVakantie_KanUitslapen()
        {
            var sut = new Opdracht1();

            bool result = sut.KanIkUitslapen(false, true);

            Assert.IsTrue(result);
        }
    }
}
