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
    /// Type classes are used to create a mapping between a code and the type name.
    /// </summary>
    class Type : IComparable
    {

        public Type(string code, string typeName)
        {
            
        }

        public int CompareTo(object obj)
        {
            return 0;
        }



    }
}