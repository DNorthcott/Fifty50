using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
    /// Transaction classes provide a record of a transaction between the user and other persons.  The transactions
    /// keep records of the datetime, comments, value and type of transaction. 
    /// </summary>
    class Transaction
    {

        public Transaction(Person person, DateTime datetime, string comments, double value, Type type)
        {
            
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public override bool Equals(Object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}