using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm10
{
    public class Generic<T>
    {
        private T[] array;

        public Generic(T[] obj)
        {
            array = obj;
        }

        public Generic()
        {

        }

        public T[] AddElements(T[] newElements)
        {
            var list = array.ToList();
            list.AddRange(newElements);
            array = list.ToArray();
            return array;
        }

        public T[] DeleteElements(T elementToDelete)
        {
            var list = array.ToList();
            list.RemoveAll(x => x.Equals(elementToDelete));
            array = list.ToArray();
            return array;
        }

        public T GetElementByIndex(int index)
        {
            return array[index];
        }

        public int GetArrayLength()
        {
            return array.Length;
        }
    }
}
