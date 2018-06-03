using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class Dictionary
    {
        public void knowDictionary()
        {
            string mystring = "Hi I am Ankit Patel";
            mystring = mystring.ToLower();
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            foreach (char ch in mystring)
            {
                if (charDict.ContainsKey(ch))
                {
                    charDict[ch] += 1;
                }
                else
                {
                    charDict.Add(ch,1);
                }
            }
            foreach(char key in charDict.Keys)
            {
                Console.Write("'{0}':{1},", key, charDict[key]);
            }
            //printing key value through KeyValue type
            Console.WriteLine();
            
            foreach (KeyValuePair<char,int> pair in charDict)
            {
                Console.Write("'{0}':{1},", pair.Key, pair.Value);
            }

            //Sorting by key
            var list = charDict.Keys.ToList();
            list.Sort();
            Console.WriteLine();
            foreach (char key in list)
            {
                Console.Write("'{0}':{1},", key, charDict[key]);
            }

            // Use OrderBy method to sort by key.
            foreach (var item in charDict.OrderBy(i => i.Key))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // Use OrderBy method to sort by key.
            var sortedOrder = charDict.OrderBy(i => i.Value);
            foreach (var item in sortedOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Getting key of a max value
            var keyval = charDict.OrderBy(i => i.Value).Last().Key;
            Console.WriteLine(keyval);

        }

    }
}
