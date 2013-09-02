using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class StringPerm
    {
        private string[] element;
        private int order;

        //implement a constructor that accepts a string array as a single input parameter and creates the identity permutation element:
        public StringPerm(string[] atoms)
        {
            if (atoms == null) throw new ArgumentNullException("atoms");
            if (!IsValid(atoms)) throw new ArgumentException("atoms");
            this.element = new string[atoms.Length];
            atoms.CopyTo(this.element, 0); this.order = atoms.Length;
        }
        //public StringPerm(string[] atoms, int k) 
        //{ ... }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ ");
            for (int i = 0; i < this.order; ++i)
            {
                result.Append(this.element[i]); result.Append(" ");
            }
            result.Append("}");
            return result.ToString();
        }
        public static bool IsValid(string[] e)
        {
            if (e == null) return false;
            if (e.Length < 2) return false;
            for (int i = 0; i < e.Length - 1; ++i)
            {
                if (e[i].CompareTo(e[i + 1]) >= 0)
                    return false;
            }
            return true;
        }

        public StringPerm Successor()
        {
            StringPerm result = new StringPerm(this.element);
            int left, right;
            // Step #1 - Find left value 
            left = result.order - 2;
            while ((result.element[left].CompareTo(result.element[left + 1])) >= 0 && (left >= 1))
            {
                --left;
            }
            if ((left == 0) && (this.element[left].CompareTo(this.element[left + 1])) >= 0)
            {
                return null;
            }

            // Step #2 - find right; first value > left 
            right = result.order - 1;
            while (result.element[left].CompareTo(result.element[right]) >= 0)
            {
                --right;
            }

            // Step #3 - swap [left] and [right] 
            string temp = result.element[left];
            result.element[left] = result.element[right];
            result.element[right] = temp;

            // Step #4 - reverse order the tail 
            int i = left + 1;
            int j = result.order - 1;
            while (i < j)
            {
                temp = result.element[i];
                result.element[i++] = result.element[j];
                result.element[j--] = temp;
            }
            return result;
        }
        //public static ulong FactorialCompute(int n) { ... } 
        //public static ulong FactorialLookup(int n) { ... } 
        //public static ulong FactorialRecursive(int n) { ... } 
    } 
}
