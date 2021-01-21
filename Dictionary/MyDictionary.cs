using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey id, TValue item)
        {
            TKey[] tempArray1 = keys;
            TValue[] tempArray2 = values;

            keys = new TKey[keys.Length+1];
            for (int i=0; i<tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
            }

            keys[keys.Length - 1] = id;

            values = new TValue[values.Length+1];
            for(int j=0; j<tempArray2.Length; j++)
            {
                values[j] = tempArray2[j];

            }

            values[values.Length - 1] = item;

            Console.WriteLine(id);
            Console.WriteLine(item);
        }
        public int Length
        {
            get { return values.Length; }
         
        }

        public TValue[] Values
        {
            get { return values; }

        }

        public TKey[] Keys
        {
            get { return keys; }
        }


    }
}
