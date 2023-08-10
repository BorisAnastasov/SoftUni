using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void CheckIf_Dummy_LosesHealth_Correctly()
        {
            Dummy dummy = new(11, 10);
            dummy.TakeAttack(5);
            Assert.AreEqual(6, dummy.Health);
        }
        [Test]
        public void DeadDummy_ShouldThrowException_WhenAttacked()
        {
            Dummy dummy = new(0, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(2));
        }
        [Test]
        public void Dummy_GiveExpierience_WhenDies()
        {
            Dummy dummy = new(0, 10);
            int exp = dummy.GiveExperience();
            Assert.AreEqual(10, exp);
        }
        [Test]
        public void Dummy_CantGiveExperience_WhenDead()
        {
            Dummy dummy = new(2, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}