using System;
using System.Collections.Generic;
using System.Text;

namespace PhilsLibrary
{
   public class Library<T>:IEnumerable
    {
        T[] stored = new T[10];
        int count;

        public void Add(T books)
        {

        }

        public int Count()
        {
            return count;
        }

      /*  public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                // yield break
                yield return items[i];
            }

        }



        // Enumerable - means it can be iterated through
        // Enumerator - is the actual "thing" that walks through the sequence through the list


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
    }




}


