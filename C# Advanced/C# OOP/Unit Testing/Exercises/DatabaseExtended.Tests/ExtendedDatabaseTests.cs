namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using System;
    using System.Globalization;
    using System.Security.Cryptography.X509Certificates;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void CountChecking()
        {
            Database db = new Database();
            Person person = new(20, "David");
            db.Add(person);
            Assert.AreEqual(1, db.Count);

        }
        [Test]
        public void ConstructorPersonChecking()
        {
            Person person = new(20, "David");
            Assert.AreEqual(person.Id, 20);
            Assert.AreEqual(person.UserName, "David");

        }
        [Test]
        public void ConstructorDataBaseChecking() 
        {
            Database database = new();
            Person person = new(20, "David");
            database.Add(person);
            Person person1 = new(21, "qre");
            database.Add(person1);
            Person person2 = new(22, "Dqrq3avid");
            database.Add(person2);
            Person person3 = new(23, "Davaeter2id");
            database.Add(person3);
            Person person4 = new(24, "Daar32vid");
            database.Add(person4);
            Person person5 = new(26, "Davaewr32id");
            database.Add(person5);
            Person person6 = new(27, "Davatgw4rid");
            database.Add(person6);
            Person person7 = new(28, "Daat3rfwvid");
            database.Add(person7);
            Person person8 = new(29, "Dac   rvid");
            database.Add(person8);
            Person person9 = new(67, "Davvwatid");
            database.Add(person9);
            Person person10 = new(30, "Davawtvid");
            database.Add(person10);
            Person person11 = new(31, "Daaygewvid");
            database.Add(person11);
            Person person12 = new(32, "Davsaerthid");
            database.Add(person12);
            Person person13 = new(33, "8p978oty");
            database.Add(person13);
            Person person14 = new(34, "qec");
            database.Add(person14);
            Person person15 = new(45, "5n6u67b");
            database.Add(person15);
            Assert.AreEqual(16,database.Count);                
        }
        [Test]
        public void ConstructorDataBaseCheckingAbove16()
        {
            
            Person person = new(20, "David");
            Person person1 = new(21, "qre");
            Person person2 = new(22, "Dqrq3avid");
            Person person3 = new(23, "Davaeter2id");
            Person person4 = new(24, "Daar32vid");
            Person person5 = new(26, "Davaewr32id");
            Person person6 = new(27, "Davatgw4rid");
            Person person7 = new(28, "Daat3rfwvid");
            Person person8 = new(29, "Dac   rvid");
            Person person9 = new(67, "Davvwatid");
            Person person10 = new(30, "Davawtvid");
            Person person11 = new(31, "Daaygewvid");
            Person person12 = new(32, "Davsaerthid");
            Person person13 = new(33, "8p978oty");
            Person person14 = new(34, "qec");
            Person person15 = new(45, "5n6u67b");
            Person person16 = new(46, "fvdrge");

            Person[] database = new Person[17] 
            { 
            person,person1,person2,person3,person4,person5,person6,person7,person8,person9,person10,person11,person12,person13,person14,person15,
            person16

            };
            
            Assert.Throws<ArgumentException>(() =>
            {
                Database db = new(database);
            }, "Provided data length should be in range [0..16]!");
        }
        [Test]
        public void AddMethod()
        {
            Person person = new(20, "David");
            Database database = new();
            database.Add(person);
            Assert.AreEqual(person, database.FindById(person.Id));
        }
        [Test]
        public void AddMethodCount16()
        {
            Database database = new();
            Person person = new(20, "David");
            database.Add(person);
            Person person1 = new(21, "qre");
            database.Add(person1);
            Person person2 = new(22, "Dqrq3avid");
            database.Add(person2);
            Person person3 = new(23, "Davaeter2id");
            database.Add(person3);
            Person person4 = new(24, "Daar32vid");
            database.Add(person4);
            Person person5 = new(26, "Davaewr32id");
            database.Add(person5);
            Person person6 = new(27, "Davatgw4rid");
            database.Add(person6);
            Person person7 = new(28, "Daat3rfwvid");
            database.Add(person7);
            Person person8 = new(29, "Dac   rvid");
            database.Add(person8);
            Person person9 = new(67, "Davvwatid");
            database.Add(person9);
            Person person10 = new(30, "Davawtvid");
            database.Add(person10);
            Person person11 = new(31, "Daaygewvid");
            database.Add(person11);
            Person person12 = new(32, "Davsaerthid");
            database.Add(person12);
            Person person13 = new(33, "8p978oty");
            database.Add(person13);
            Person person14 = new(34, "qec");
            database.Add(person14);
            Person person15 = new(45, "5n6u67b");
            database.Add(person15);

            

            Person p = new(100, "Ivan");
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(p);
            }, "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void AddMethodBYId()
        {
            Person noa = new(20, "Noa");
            Person ivan = new(20, "Ivan");
            Database database = new();
            database.Add(noa);
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(ivan);
            }, "There is already user with this Id!");
        }
        [Test]
        public void AddMethodBYName()
        {
            Person noa = new(20, "Noa");
            Person ivan = new(21, "Noa");
            Database database = new();
            database.Add(noa);
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(ivan);
            }, "There is already user with this username!");
        }
        [Test]
        public void RemoveMethod()
        {
            Person person = new(20, "David");
            Database database = new();
            database.Add(person);
            database.Remove();
            Assert.AreEqual(0, database.Count);
        }
        [Test]
        public void RemoveMethodCount0()
        {
            Database database = new();
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            },null);
            
        }
        [Test]
        public void FindByIdMethod() 
        {
            Person person = new(20, "David");
            Database database = new();
            database.Add(person);
            var item = database.FindById(person.Id);
            Assert.AreEqual(item, person);
        }
        [Test]
        public void FindByIdMethodPositiv()
        {
            Person person = new(20, "David");
            Database database = new();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var item = database.FindById(-1);
            }, "Id should be a positive number!");
            
        }
        [Test]
        public void FindByIdMethodNoPerson()
        {
            Person person = new(20, "David");
            Database database = new();
            Assert.Throws<InvalidOperationException>(() =>
            {
                var item = database.FindById(1);
            }, "No user is present by this ID!");
        }
        [Test]
        public void FindByNameMethod()
        {
            Person person = new(20, "David");
            Database database = new();
            database.Add(person);
            var item = database.FindByUsername(person.UserName);
            Assert.AreEqual(item, person);
        }
        public void FindByNameMethodPositiv()
        {
            Person person = new(20, "David");
            Database database = new();
            Assert.Throws<ArgumentNullException>(() =>
            {
                var item = database.FindByUsername("");
            }, "Username parameter is null!");
        }
        [Test]
        public void FindByNameMethodNoPerson()
        {
            Person person = new(20, "David");
            Database database = new();
            Assert.Throws<InvalidOperationException>(() =>
            {
                var item = database.FindByUsername("Ivan");
            }, "No user is present by this username!");
        }
        [Test]
        public void Test_AddingMoreThan16PopleThrows()
        {
            Database database = new();
            int id = 2;
            for (char name = 'G'; name < 'G' + 15; name++, id++)
            {
                database.Add(new Person(id, name.ToString()));
            }

            TestDelegate testDelegate = () => database.Add(new Person(3, "Ivan"));
            Assert.Throws<InvalidOperationException>(testDelegate, "Can add more than 16 people");
        }
        [Test]
        public void Test_TryingToInvokFindByUsernameWithEmptyOrNullNameThrows()
        {
            Database database = new();
            TestDelegate testDelegate = () => { database.FindByUsername(string.Empty); database.FindByUsername(null); };
            Assert.Throws<ArgumentNullException>(testDelegate, "Can apply user with empty/null name");
        }
    }
}