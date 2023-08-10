using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeGettersTest()
        {
            Axe axe = new Axe(10, 10);
            Assert.AreEqual(10, axe.AttackPoints);
            Assert.AreEqual(10, axe.DurabilityPoints);
        }
        [Test]
        public void AxeAttackShouldDropDurability()//good
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void TestIfAttackWithNoDurabilityThrowsError()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(()=>axe.Attack(dummy));
        }
    }
}