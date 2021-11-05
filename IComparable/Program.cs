using System;

namespace IComparable
{
    public struct StructA : IComparable<StructA>
    {
        public int prop1 { get; set; }
        public decimal prop2 { get; init; }

        public bool[] array;

        public int CompareTo(StructA other)
        {
            if (prop1 != other.prop1)
                return prop1.CompareTo(other.prop1);
            else
                return prop2.CompareTo(other.prop2);
        }
        public StructA(int antal) 
        {
            prop1 = default;
            prop2 = default;
            array = new bool[antal];
        }
    }
    public class ClassA
    {
        public int prop1 { get; set; }
        public decimal prop2 { get; init; }

        public bool[] array;

        public ClassA(int antal)
        {
            prop1 = default;
            prop2 = default;
            array = new bool[antal];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StructA myStruct1 = new StructA(2);
            StructA myStruct2 = new StructA(5);

            ClassA myClass1 = new ClassA(2);
            ClassA myClass2 = new ClassA(5);

            myClass1 = null;
            myClass2 = null;
           
            myStruct1 = default;
            myStruct2 = default;

        }
    }
}
