using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Fifty50.Src.Model;
using NUnit.Framework;

namespace Fifty50.Tests
{
    [TestFixture]
    class PersonTests
    {

        /// <summary>
        /// Tests the compare to function.
        /// 
        /// The ordering of the person class is sorted by first name, then by last name alphabetically.
        /// Words are sorted in the same fashion in a word dictionary.
        /// </summary>
        [Test]
        public void CompareToTest()
        {
            Person bob = new Person(1, "Bob", "Arraon", "stevejobs@hotmail.com");
            Person bob2 = new Person(1, "Bob", "Jobs", "markwaynew@gmail.com");
            Person bob3 = new Person(1, "Bobs", "Jobs", "markwaynew@gmail.com");
            Person bob4 = new Person(1, "Bobs", "Jobsy", "markwaynew@gmail.com");
            Person allen = new Person(1, "Allen", "Jobs", "markwaynew@gmail.com");
            Person steve = new Person(1, "Steve", "Jobs", "markwaynew@gmail.com");
            Person steve1 = new Person(2, "Steve", "Jobs", "markwasdaaynew@gmail.com");
            Person sarah = new Person(2, "Sarah", "Skaven", "SarahSkaven@gmail.com");
            Person john = new Person(72, "John", "Solo", "johnsolo@gmail.com");
            Person luke = new Person(12, "luke", "jacobs", "lukejacobs@gmail.com");

            // 1. Test for two objects that occur in the same position in the sort.
            Assert.Zero(steve.CompareTo(steve1));

            /* 2.Test for where this instance preceeds the object due to first name and last name occuring
                before the object.
            */
            Assert.Negative(bob.CompareTo(steve));

            // 3. Test for where this instance preceeds the object due to first name preceeding but not last name.
            Assert.Negative(allen.CompareTo(bob));

            // 4. Test for where this instance preceeds the object where first names are equal and last name are not.
            Assert.Negative(bob.CompareTo(bob2));

            /* 5. Test for where this instance preceeds the object where first name preceeds the other, and last name
             is equal.
            */
            Assert.Negative(allen.CompareTo(bob2));

            /* 6. Test for where this instance follows the object due to first name and last name occuring
              after the object the object.
            */
            Assert.Positive(steve.CompareTo(bob));

            // 7. Test for where this instance follows the object due to first name occuring after but not last name.
            Assert.Positive(luke.CompareTo(bob));

            // 8. Test for where this instance follows the object where first names are equal and last name are not.
            Assert.Positive(bob2.CompareTo(bob));

            // 9. Test for where this instance follows the object where first name follows the other, and last name
            // is equal.
            Assert.Positive(steve.CompareTo(allen));

            // 10.  Test for when first name is similar for most characters, except last character.
            Assert.Negative(bob2.CompareTo(bob3));

            // 11. Test for equal first name, last name similar except last character.
            Assert.Negative(bob3.CompareTo(bob4));
        }



        /// <summary>
        /// Tests that white space in front of a name is removed on construction of new person object.
        /// </summary>
        [Test]
        public void NameSpacesTest()
        {
            //Test for spaces in front of string.
            Person bob = new Person(1, " Bob", " Arraon", "stevejobs@hotmail.com");
            Person bob1 = new Person(1, "              Bob", "         Arraon", "stevejobs@hotmail.com");

            Assert.True(bob.FName == "Bob");

            Assert.True(bob.LName == "Arroan");

            Assert.True(bob1.FName == "Bob");

            Assert.True(bob1.LName == "Arroan");

            //Test for spaces after name.

            Person bob2 = new Person(1, "Bob ", "Arraon ", "stevejobs@hotmail.com");
            Person bob3 = new Person(1, "Bob         ", "Arraon        ", "stevejobs@hotmail.com");

            Assert.True(bob2.FName == "Bob");

            Assert.True(bob2.LName == "Arroan");

            Assert.True(bob3.FName == "Bob");

            Assert.True(bob3.LName == "Arroan");

            //Test for not removing white space in middle of names.

            Person bob4 = new Person(1, " Mary Jane ", " Arraon The First ", "stevejobs@hotmail.com");
           

            Assert.True(bob4.FName == "Mary Jane");

            Assert.True(bob4.LName == "Arraon The First");

        }

        /// <summary>
        /// Tests that an exception is thrown if constructor is passed an empty first name string.
        /// </summary>
        [Test]
        public void ConstructorFirstNameEmptyException()
        {
            Assert.Catch(() => new Person(1, "", "Name", "test@email.com"));
        }

        /// <summary>
        /// Tests that an expception is thrown if a constructor is passed an empty last name string.
        /// </summary>
        [Test]
        public void ConstructorLastNameEmptyException()
        {
            Assert.Catch(() => new Person(1, "Name", "", "test@email.com"));
        }

        /// <summary>
        /// Tests that an expception is thrown if a constructor is passed a string longer than 50 characters for first 
        /// name.
        /// </summary>
        [Test]
        public void ConstructorFirstNameLengthException()
        {
            Assert.Catch(() => new Person(1, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Name", "test@email.com"));
        }


        /// <summary>
        /// Tests that an expception is thrown if a constructor is passed a string longer than 50 characters for last 
        /// name.
        /// </summary>
        [Test]
        public void ConstructorLastNameLengthException()
        {
            Assert.Catch(() => new Person(1, "Name", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "test@email.com"));
        }

        /// <summary>
        /// Tests that an exception is thrown if a constructor is passed an invalid email.  Eg requires
        /// xxxx@xxxx.x pattern.
        /// </summary>
        [Test]
        public void ConstructorEmailException()
        {

        }
    }
}