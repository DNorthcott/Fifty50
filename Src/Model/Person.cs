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

namespace Fifty50.Src.Model
{
    /// <summary>
    /// Person class stores information regarding a person.
    /// </summary>
    class Person : IComparable
    {


        public Person(int id, string email, string fName, string lName)
        {
            
        }

        /// <summary>
        /// Persons are sorted on basis of alphabetical ordering of first names.  If first names are equal then sorted
        /// by last name.  If first and last name are equal ordering does not matter.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return 0;
        }

        /// <summary>
        /// Persons are considered equal if they have the same ID.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            return true;
        }

        /// <summary>
        /// Returns the hash code for this person.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns a string in the format "FirstName LastName"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}