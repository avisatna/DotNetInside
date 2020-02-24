using System;
using System.Collections;

namespace StringProgramms
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCountOfEachCharInCharArray();
        }

        public static void GetCountOfEachCharInCharArray()
        {
            string[] strArr = { "a", "b", "b", "c", "a", "a", "c", "c", "d", "b" };
            Hashtable hashtable = new Hashtable();

            foreach (var item in strArr)
            {
                if (hashtable.ContainsKey(item))
                {
                    hashtable[item] = Convert.ToInt32(hashtable[item]) + 1;
                }
                else
                {
                    hashtable.Add(item, 1);
                }
            }

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        public static void GetLastCharOfEachWord()
        {

        }
    }
}
