using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class NullableRefTypesSample
    {

        public static void Run()
        {
            //nullable reference type
            string? text = null;
            //override it
            //string! text = "Inigo Montoya"



            string text1 = null;
            // Warning: Cannot convert null to non-nullable reference
            string? text2 = null;
            string text3 = text2;
            // Warning: Possible null reference assignment
            Console.WriteLine(text2.Length);
            // Warning: Possible dereference of a null reference
            if (text2 != null) { Console.WriteLine(text2.Length); }
            // Allowed given check for null



            //Enable Suppression of Static Flow Analysis Warning

            string? text5; 
            if (object.ReferenceEquals(text5, null))
            {
                var type = text5!.GetType();
            }

            string moreText = text5!;


            //System.Runtime.CompilerServices.NullableAttribute
        }
    }
}
