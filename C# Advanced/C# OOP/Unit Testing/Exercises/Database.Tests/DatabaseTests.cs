namespace Database.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using System;

    [TestFixture]
    public class DatabaseTests
    {

        [SetUp]
        public void SetUp()
        {
            
        }
        [TestCase(new int[] {})]
        [TestCase(new int[] { 1,2,3,4,5})]
        [TestCase(new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 })]
        public void ConstructorInitializeWithCount(int[] data)
        {
            var db= new Database(data);
            int exp = data.Length;
            int actual = db.Count;
            Assert.AreEqual(exp, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,17 })]
        public void CapacityShouldBe16(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database(data);
            }, "Array's capacity must be exactly 16 integers!");            
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void AddMethodTestWithCount(int[] data)
        {
            var db = new Database(data);
            db.Add(1);
            Assert.AreEqual(9, db.Count);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})]
        public void AddMethodTestAbove16(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database(data);
                db.Add(1);
            }, "Array's capacity must be exactly 16 integers!");
           
        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void RemoveMethodTestWithCount(int[] data)
        {
            var db = new Database(data);
            db.Remove();
            Assert.AreEqual(7, db.Count);
        }
        [TestCase(new int[] {})]
        public void RemoveMethodTestEqual0(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var db = new Database(data);
                db.Remove();
            }, "The collection is empty!");
           
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        public void FetchMethodTest(int[] data)
        {
            var db = new Database(data);
            int[] result = db.Fetch();
            Assert.AreEqual(data, result);
        }
    }
}
