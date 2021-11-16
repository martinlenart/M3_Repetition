using System;
using System.Collections.Generic;

namespace OperatorOverload
{
    class Program
    {
        class A : IEquatable<A>, IComparable<A>
        {
            public int myInt;
            public float myFloat;

            public static A operator +(A a1, A a2) => Add(a1, a2);
            public static bool operator == (A a1, A a2) => a1.Equals(a2);
            public static bool operator !=(A a1, A a2) => !a1.Equals(a2);

            public static A Add (A a1, A a2)
            {
                var newA = new A();
                newA.myInt = a1.myInt + a2.myInt;
                newA.myFloat = a1.myFloat + a2.myFloat;
                return newA;
            }

            public bool Equals(A other) => (myInt, myFloat) == (other.myInt, other.myFloat);
            public int CompareTo(A other)
            {
                if (myInt != other.myInt)
                    return myInt.CompareTo(other.myInt);

                return myFloat.CompareTo(other.myFloat);
            }

            public override bool Equals(object obj) => Equals(obj as A);
            public override int GetHashCode() => (myInt, myFloat).GetHashCode();

            public static class Factory
            {
                public static List<A> CreateList(int NumberOfItems)
                {
                    var myList = new List<A>();
                    for (int i = 0; i < NumberOfItems; i++)
                    {
                        myList.Add(new A());
                    }

                    return myList;
                }
            }
        }

        static void Main(string[] args)
        {
            var a1 = new A { myInt = 5 };
            var a2 = new A { myInt = 15 };

            Console.WriteLine(a1 != a2); // True

            //var a3 = A.Add(a1, a2);
            var a3 = a1 + a2;
            Console.WriteLine(a3.myInt);

            var aList = A.Factory.CreateList(10);
            Console.WriteLine(aList.Count);
        }
    }
}
