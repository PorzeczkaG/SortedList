using System;
using System.Collections;


namespace Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList st = new SortedList();
            st.Add("1", "abc");
            st.Add("3", "cbc");
            st.Add("2", "bbc");
            st.Add("4", "dbc");
            st.Add("c5", "abc");
            st.Add("z6", "bbc");
            st.Add("j7", "cbc");
            st.Add("a8", "dbc");


            Console.WriteLine("  Ilosc kluczy:    {0}", st.Count);



            ICollection key = st.Keys;

            foreach (String k in key)
            {
                Console.WriteLine(  k + " - " + st[k]);
            }

            Console.Read();
        }
    }
}
