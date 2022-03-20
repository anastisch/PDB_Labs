using Lab2_Sotring;
using NUnit.Framework;

namespace Lab3_Sorting_Tests
{
    public class KeyComparatorTest
    {
        [Test]
        public void TestComparePersonsByName()
        {
            Person firstPerson = new Person("Boba");
            Person secondPerson = new Person("Biba");
            Person thirdPerson = new Person("Boba");

            IComparator<Person> nameComparator = new KeyComparator<Person, string>(person => person.Name);
            
            int actualResult = nameComparator.Compare(firstPerson, secondPerson);
            Assert.Greater(actualResult, 0);
            
            actualResult = nameComparator.Compare(secondPerson, firstPerson);
            Assert.Less(actualResult, 0);

            actualResult = nameComparator.Compare(thirdPerson, firstPerson);
            Assert.AreEqual(0, actualResult);
        }

        private class Person
        {
            public string Name { get; }

            public Person(string name)
            { 
                Name = name;
            }
        }
    }
}